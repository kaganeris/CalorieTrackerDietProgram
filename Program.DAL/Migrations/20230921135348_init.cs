using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meals_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserDetails_AppUsers_ID",
                        column: x => x.ID,
                        principalTable: "AppUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorie = table.Column<float>(type: "real", nullable: false),
                    Measurement = table.Column<float>(type: "real", nullable: false),
                    PortionType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nutritions_AppUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AppUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Nutritions_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersMealsHistories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false),
                    NumberOfNutritions = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersMealsHistories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UsersMealsHistories_AppUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AppUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersMealsHistories_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersMealsHistories_Nutritions_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutritions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Vegetable" },
                    { 2, "Fruit" },
                    { 3, "Soft Drink" },
                    { 4, "Alcohol" },
                    { 5, "Snack" },
                    { 6, "Dessert" },
                    { 7, "Salad" },
                    { 8, "Dairy" },
                    { 9, "Fish and Seafood" },
                    { 10, "Fast Food" },
                    { 11, "Meat or Poultry" },
                    { 12, "Grain, Bean and Nuts" },
                    { 13, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "IsActive", "MealName", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(1181), null, true, "Breakfast", null, null },
                    { 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(1183), null, true, "Lunch", null, null },
                    { 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(1184), null, true, "Dinner", null, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[,]
                {
                    { 1, 60f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(611), null, true, 1f, null, "Artichoke", "\\FoodPhotos\\1.jpg", 8, null },
                    { 2, 50f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(635), null, true, 100f, null, "Arugula", "\\FoodPhotos\\2.jpg", 0, null },
                    { 3, 2f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(640), null, true, 1f, null, "Asparagus", "\\FoodPhotos\\3.jpg", 8, null },
                    { 4, 115f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(641), null, true, 1f, null, "Aubergine", "\\FoodPhotos\\4.jpg", 8, null },
                    { 5, 35f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(643), null, true, 1f, null, "Beetroot", "\\FoodPhotos\\5.jpg", 8, null },
                    { 6, 15f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(644), null, true, 1f, null, "Bell Pepper", "\\FoodPhotos\\6.jpg", 8, null },
                    { 7, 2f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(645), null, true, 1f, null, "Black Olives", "\\FoodPhotos\\7.jpg", 8, null },
                    { 8, 35f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(646), null, true, 100f, null, "Broccoli", "\\FoodPhotos\\8.jpg", 0, null },
                    { 9, 40f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(647), null, true, 100f, null, "Brussels Sprouts", "\\FoodPhotos\\9.jpg", 0, null },
                    { 10, 227f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(648), null, true, 1f, null, "Cabbage", "\\FoodPhotos\\10.jpg", 6, null },
                    { 11, 12f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(650), null, true, 1f, null, "Capsicum", "\\FoodPhotos\\11.jpg", 8, null },
                    { 12, 25f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(651), null, true, 1f, null, "Carrot", "\\FoodPhotos\\12.jpg", 8, null },
                    { 13, 3f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(652), null, true, 1f, null, "Cauliflower", "\\FoodPhotos\\13.jpg", 6, null },
                    { 14, 42f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(653), null, true, 1f, null, "Celery", "\\FoodPhotos\\14.jpg", 10, null },
                    { 15, 20f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(654), null, true, 1f, null, "Cherry Tomato", "\\FoodPhotos\\15.jpg", 8, null },
                    { 16, 134f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(655), null, true, 1f, null, "Chinese Cabbage", "\\FoodPhotos\\16.jpg", 6, null },
                    { 17, 32f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(656), null, true, 100f, null, "Collard Greens", "\\FoodPhotos\\17.jpg", 0, null },
                    { 18, 96f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(657), null, true, 1f, null, "Corn", "\\FoodPhotos\\18.jpg", 8, null },
                    { 19, 20f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(659), null, true, 100f, null, "Courgette", "\\FoodPhotos\\19.jpg", 0, null },
                    { 20, 15f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(661), null, true, 1f, null, "Cucumber", "\\FoodPhotos\\20.jpg", 8, null },
                    { 21, 336f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(662), null, true, 100f, null, "Salami", "\\FoodPhotos\\21.jpg", 0, null },
                    { 22, 17f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(663), null, true, 100f, null, "Endive", "\\FoodPhotos\\22.jpg", 0, null },
                    { 23, 32f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(664), null, true, 100f, null, "Fennel", "\\FoodPhotos\\23.jpg", 0, null },
                    { 24, 4f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(665), null, true, 1f, null, "Garlic", "\\FoodPhotos\\24.jpg", 8, null },
                    { 25, 9f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(666), null, true, 1f, null, "Gherkin", "\\FoodPhotos\\25.jpg", 8, null },
                    { 26, 108f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(667), null, true, 1f, null, "Gourd", "\\FoodPhotos\\26.jpg", 8, null },
                    { 27, 32f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(669), null, true, 100f, null, "Green Beans", "\\FoodPhotos\\27.jpg", 0, null },
                    { 28, 2f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(670), null, true, 1f, null, "Green Olives", "\\FoodPhotos\\28.jpg", 8, null },
                    { 29, 5f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(671), null, true, 1f, null, "Green Onion", "\\FoodPhotos\\29.jpg", 8, null },
                    { 30, 7f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(672), null, true, 5f, null, "Horseradish", "\\FoodPhotos\\30.jpg", 0, null },
                    { 31, 43f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(673), null, true, 100f, null, "Kale", "\\FoodPhotos\\31.jpg", 0, null },
                    { 32, 54f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(674), null, true, 1f, null, "Leek", "\\FoodPhotos\\32.jpg", 8, null },
                    { 33, 109f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(675), null, true, 1f, null, "Lettuce", "\\FoodPhotos\\33.jpg", 8, null },
                    { 34, 1f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(677), null, true, 1f, null, "Mushrooms", "\\FoodPhotos\\34.jpg", 8, null },
                    { 35, 28f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(678), null, true, 100f, null, "Mustard Greens", "\\FoodPhotos\\35.jpg", 0, null },
                    { 36, 33f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(680), null, true, 100f, null, "Okra", "\\FoodPhotos\\36.jpg", 0, null },
                    { 37, 300f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(681), null, true, 100f, null, "Sausage", "\\FoodPhotos\\37.jpg", 0, null },
                    { 38, 34f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(682), null, true, 1f, null, "Onion", "\\FoodPhotos\\38.jpg", 8, null },
                    { 39, 128f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(683), null, true, 1f, null, "Parsnips", "\\FoodPhotos\\39.jpg", 8, null },
                    { 40, 81f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(684), null, true, 100f, null, "Peas", "\\FoodPhotos\\40.jpg", 0, null },
                    { 41, 29f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(685), null, true, 1f, null, "Bacon", "\\FoodPhotos\\41.jpg", 2, null },
                    { 42, 164f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(686), null, true, 1f, null, "Potato", "\\FoodPhotos\\42.jpg", 8, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[,]
                {
                    { 43, 51f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(687), null, true, 1f, null, "Pumpkin", "\\FoodPhotos\\43.jpg", 8, null },
                    { 44, 15f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(690), null, true, 1f, null, "Radishes", "\\FoodPhotos\\44.jpg", 8, null },
                    { 45, 260f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(691), null, true, 1f, null, "Red Cabbage", "\\FoodPhotos\\45.jpg", 8, null },
                    { 46, 147f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(692), null, true, 1f, null, "Rutabaga", "\\FoodPhotos\\46.jpg", 8, null },
                    { 47, 18f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(693), null, true, 1f, null, "Shallots", "\\FoodPhotos\\47.jpg", 8, null },
                    { 48, 130f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(695), null, true, 1f, null, "Squash", "\\FoodPhotos\\48.jpg", 8, null },
                    { 49, 112f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(696), null, true, 1f, null, "Sweet Potato", "\\FoodPhotos\\49.jpg", 8, null },
                    { 50, 20f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(697), null, true, 1f, null, "Tomato", "\\FoodPhotos\\50.jpg", 8, null },
                    { 51, 34f, 1, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(698), null, true, 1f, null, "Turnip", "\\FoodPhotos\\51.jpg", 8, null },
                    { 52, 95f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(699), null, true, 1f, null, "Apple", "\\FoodPhotos\\52.jpg", 8, null },
                    { 53, 17f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(705), null, true, 1f, null, "Apricot", "\\FoodPhotos\\53.jpg", 8, null },
                    { 54, 240f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(707), null, true, 1f, null, "Avocado", "\\FoodPhotos\\54.jpg", 8, null },
                    { 55, 111f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(708), null, true, 1f, null, "Banana", "\\FoodPhotos\\55.jpg", 8, null },
                    { 56, 43f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(709), null, true, 100f, null, "Blackberries", "\\FoodPhotos\\56.jpg", 0, null },
                    { 57, 70f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(710), null, true, 1f, null, "Blood Oranges", "\\FoodPhotos\\57.jpg", 8, null },
                    { 58, 84f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(712), null, true, 100f, null, "Blueberries", "\\FoodPhotos\\58.jpg", 0, null },
                    { 59, 34f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(714), null, true, 100f, null, "Cantaloupe", "\\FoodPhotos\\59.jpg", 0, null },
                    { 60, 4f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(716), null, true, 1f, null, "Cherries", "\\FoodPhotos\\60.jpg", 8, null },
                    { 61, 46f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(717), null, true, 100f, null, "Cranberries", "\\FoodPhotos\\61.jpg", 0, null },
                    { 62, 20f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(718), null, true, 1f, null, "Dates", "\\FoodPhotos\\62.jpg", 8, null },
                    { 63, 37f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(720), null, true, 1f, null, "Figs", "\\FoodPhotos\\63.jpg", 8, null },
                    { 64, 125f, 7, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(721), null, true, 1f, null, "Fruit salad", "\\FoodPhotos\\64.jpg", 5, null },
                    { 65, 67f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(723), null, true, 100f, null, "Grapes", "\\FoodPhotos\\65.jpg", 0, null },
                    { 66, 112f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(724), null, true, 1f, null, "Kiwi", "\\FoodPhotos\\66.jpg", 8, null },
                    { 67, 17f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(725), null, true, 1f, null, "Lemon", "\\FoodPhotos\\67.jpg", 8, null },
                    { 68, 20f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(727), null, true, 1f, null, "Lime", "\\FoodPhotos\\68.jpg", 8, null },
                    { 69, 7f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(728), null, true, 1f, null, "Lychees", "\\FoodPhotos\\69.jpg", 8, null },
                    { 70, 47f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(729), null, true, 1f, null, "Mandarin Oranges", "\\FoodPhotos\\70.jpg", 8, null },
                    { 71, 202f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(730), null, true, 1f, null, "Mango", "\\FoodPhotos\\71.jpg", 8, null },
                    { 72, 66f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(731), null, true, 1f, null, "Nectarine", "\\FoodPhotos\\72.jpg", 8, null },
                    { 73, 62f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(732), null, true, 1f, null, "Orange", "\\FoodPhotos\\73.jpg", 8, null },
                    { 74, 215f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(733), null, true, 1f, null, "Papaya", "\\FoodPhotos\\74.jpg", 8, null },
                    { 75, 17f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(735), null, true, 1f, null, "Passion Fruit", "\\FoodPhotos\\75.jpg", 8, null },
                    { 76, 59f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(736), null, true, 1f, null, "Peach", "\\FoodPhotos\\76.jpg", 8, null },
                    { 77, 101f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(737), null, true, 1f, null, "Pear", "\\FoodPhotos\\77.jpg", 8, null },
                    { 78, 50f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(738), null, true, 100f, null, "Pineapple", "\\FoodPhotos\\78.jpg", 0, null },
                    { 79, 30f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(739), null, true, 1f, null, "Plum", "\\FoodPhotos\\79.jpg", 8, null },
                    { 80, 234f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(741), null, true, 1f, null, "Pomegranate", "\\FoodPhotos\\80.jpg", 8, null },
                    { 81, 300f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(742), null, true, 100f, null, "Raisins", "\\FoodPhotos\\81.jpg", 0, null },
                    { 82, 64f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(743), null, true, 1f, null, "Raspberries", "\\FoodPhotos\\82.jpg", 5, null },
                    { 83, 49f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(744), null, true, 1f, null, "Strawberries", "\\FoodPhotos\\83.jpg", 5, null },
                    { 84, 47f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(745), null, true, 1f, null, "Tangerine", "\\FoodPhotos\\84.jpg", 8, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[,]
                {
                    { 85, 86f, 2, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(746), null, true, 1f, null, "Watermelon", "\\FoodPhotos\\85.jpg", 2, null },
                    { 86, 680f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(748), null, true, 1f, null, "Bacon and Eggs", "\\FoodPhotos\\86.jpg", 9, null },
                    { 87, 150f, 12, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(749), null, true, 100f, null, "Baked Beans", "\\FoodPhotos\\87.jpg", 0, null },
                    { 88, 360f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(750), null, true, 1f, null, "BBQ Ribs", "\\FoodPhotos\\88.jpg", 8, null },
                    { 89, 186f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(752), null, true, 1f, null, "Beef Stew", "\\FoodPhotos\\89.jpg", 5, null },
                    { 90, 170f, 12, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(753), null, true, 100f, null, "Black Rice", "\\FoodPhotos\\90.jpg", 0, null },
                    { 91, 110f, 12, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(754), null, true, 100f, null, "Brown Rice", "\\FoodPhotos\\91.jpg", 0, null },
                    { 92, 326f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(755), null, true, 1f, null, "Burrito", "\\FoodPhotos\\92.jpg", 8, null },
                    { 93, 33f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(756), null, true, 1f, null, "California Roll", "\\FoodPhotos\\93.jpg", 8, null },
                    { 94, 309f, 7, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(757), null, true, 1f, null, "Chicken Caesar Salad", "\\FoodPhotos\\94.jpg", 5, null },
                    { 95, 290f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(758), null, true, 1f, null, "Chicken Marsala", "\\FoodPhotos\\95.jpg", 9, null },
                    { 96, 350f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(759), null, true, 1f, null, "Chicken Tikka Masala", "\\FoodPhotos\\96.jpg", 9, null },
                    { 97, 308f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(761), null, true, 1f, null, "Chimichanga", "\\FoodPhotos\\97.jpg", 8, null },
                    { 98, 160f, 7, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(762), null, true, 1f, null, "Cobb Salad", "\\FoodPhotos\\98.jpg", 5, null },
                    { 99, 180f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(763), null, true, 1f, null, "Corn Dog", "\\FoodPhotos\\99.jpg", 8, null },
                    { 100, 300f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(764), null, true, 1f, null, "Cottage Pie", "\\FoodPhotos\\100.jpg", 2, null },
                    { 101, 323f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(765), null, true, 1f, null, "Enchiladas", "\\FoodPhotos\\101.jpg", 8, null },
                    { 102, 290f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(766), null, true, 1f, null, "Fajita", "\\FoodPhotos\\102.jpg", 9, null },
                    { 103, 585f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(768), null, true, 1f, null, "Fish and Chips", "\\FoodPhotos\\103.jpg", 9, null },
                    { 104, 662f, 12, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(775), null, true, 1f, null, "Fried Rice", "\\FoodPhotos\\104.jpg", 9, null },
                    { 105, 75f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(776), null, true, 1f, null, "Fried Shrimp", "\\FoodPhotos\\105.jpg", 8, null },
                    { 106, 392f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(777), null, true, 1f, null, "Grilled Cheese Sandwich", "\\FoodPhotos\\106.jpg", 9, null },
                    { 107, 352f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(778), null, true, 1f, null, "Ham and Cheese Sandwich", "\\FoodPhotos\\107.jpg", 9, null },
                    { 108, 774f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(780), null, true, 1f, null, "Kebab", "\\FoodPhotos\\108.jpg", 9, null },
                    { 109, 284f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(781), null, true, 1f, null, "Lasagne", "\\FoodPhotos\\109.jpg", 9, null },
                    { 110, 699f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(782), null, true, 1f, null, "Mac and Cheese", "\\FoodPhotos\\110.jpg", 9, null },
                    { 111, 420f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(784), null, true, 1f, null, "Orange Chicken", "\\FoodPhotos\\111.jpg", 9, null },
                    { 112, 375f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(785), null, true, 1f, null, "Pad Thai", "\\FoodPhotos\\112.jpg", 5, null },
                    { 113, 190f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(786), null, true, 1f, null, "Pea Soup", "\\FoodPhotos\\113.jpg", 5, null },
                    { 114, 200f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(788), null, true, 1f, null, "Peanut Butter Sandwich", "\\FoodPhotos\\114.jpg", 8, null },
                    { 115, 300f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(789), null, true, 1f, null, "Philly Cheese Steak", "\\FoodPhotos\\115.jpg", 8, null },
                    { 116, 272f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(790), null, true, 1f, null, "Pizza", "\\FoodPhotos\\116.jpg", 2, null },
                    { 117, 300f, 7, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(791), null, true, 1f, null, "Potato Salad", "\\FoodPhotos\\117.jpg", 5, null },
                    { 118, 500f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(792), null, true, 1f, null, "Ramen", "\\FoodPhotos\\118.jpg", 5, null },
                    { 119, 370f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(796), null, true, 1f, null, "Ravioli", "\\FoodPhotos\\119.jpg", 9, null },
                    { 120, 641f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(797), null, true, 1f, null, "Reuben Sandwich", "\\FoodPhotos\\120.jpg", 8, null },
                    { 121, 110f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(798), null, true, 1f, null, "Roast Beef", "\\FoodPhotos\\121.jpg", 2, null },
                    { 122, 374f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(799), null, true, 1f, null, "Spaghetti Bolognese", "\\FoodPhotos\\122.jpg", 9, null },
                    { 123, 213f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(800), null, true, 1f, null, "Taco", "\\FoodPhotos\\123.jpg", 8, null },
                    { 124, 309f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(801), null, true, 1f, null, "BBQ Chicken Pizza", "\\FoodPhotos\\124.jpg", 2, null },
                    { 125, 314f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(802), null, true, 1f, null, "BBQ Pizza", "\\FoodPhotos\\125.jpg", 2, null },
                    { 126, 714f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(804), null, true, 1f, null, "Beef Pizza", "\\FoodPhotos\\126.jpg", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[,]
                {
                    { 127, 460f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(805), null, true, 1f, null, "Bianca Pizza", "\\FoodPhotos\\127.jpg", 2, null },
                    { 128, 600f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(806), null, true, 1f, null, "Buffalo Chicken Pizza", "\\FoodPhotos\\128.jpg", 2, null },
                    { 129, 168f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(807), null, true, 1f, null, "Cheese Pizza", "\\FoodPhotos\\129.jpg", 2, null },
                    { 130, 309f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(808), null, true, 1f, null, "Chicken Pizza", "\\FoodPhotos\\130.jpg", 2, null },
                    { 131, 313f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(810), null, true, 1f, null, "Deep Dish Pizza", "\\FoodPhotos\\131.jpg", 2, null },
                    { 132, 138f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(811), null, true, 1f, null, "Goat Cheese Pizza", "\\FoodPhotos\\132.jpg", 2, null },
                    { 133, 280f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(812), null, true, 1f, null, "Grilled Pizza", "\\FoodPhotos\\133.jpg", 2, null },
                    { 134, 154f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(813), null, true, 1f, null, "Hawaiian Pizza", "\\FoodPhotos\\134.jpg", 2, null },
                    { 135, 173f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(814), null, true, 1f, null, "Margherita Pizza", "\\FoodPhotos\\135.jpg", 2, null },
                    { 136, 154f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(816), null, true, 1f, null, "Mozzarella Pizza", "\\FoodPhotos\\136.jpg", 2, null },
                    { 137, 611f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(817), null, true, 1f, null, "Mushroom Pizza", "\\FoodPhotos\\137.jpg", 2, null },
                    { 138, 248f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(819), null, true, 1f, null, "Napoli Pizza", "\\FoodPhotos\\138.jpg", 2, null },
                    { 139, 174f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(820), null, true, 1f, null, "New York Style Pizza", "\\FoodPhotos\\139.jpg", 2, null },
                    { 140, 181f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(821), null, true, 1f, null, "Pepperoni Pizza", "\\FoodPhotos\\140.jpg", 2, null },
                    { 141, 380f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(822), null, true, 1f, null, "Pizza Hut Stuffed Crust Pizza", "\\FoodPhotos\\141.jpg", 2, null },
                    { 142, 305f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(823), null, true, 1f, null, "Pizza Hut Supreme Pizza", "\\FoodPhotos\\142.jpg", 2, null },
                    { 143, 330f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(824), null, true, 1f, null, "Quattro Formaggi Pizza", "\\FoodPhotos\\143.jpg", 2, null },
                    { 144, 165f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(825), null, true, 1f, null, "Red Pepper Pizza", "\\FoodPhotos\\144.jpg", 2, null },
                    { 145, 181f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(827), null, true, 1f, null, "Salami Pizza", "\\FoodPhotos\\145.jpg", 2, null },
                    { 146, 177f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(828), null, true, 1f, null, "Sausage Pizza", "\\FoodPhotos\\146.jpg", 2, null },
                    { 147, 186f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(829), null, true, 1f, null, "Seafood Pizza", "\\FoodPhotos\\147.jpg", 2, null },
                    { 148, 190f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(830), null, true, 1f, null, "Shrimp Pizza", "\\FoodPhotos\\148.jpg", 2, null },
                    { 149, 321f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(831), null, true, 1f, null, "Sicilian Pizza", "\\FoodPhotos\\149.jpg", 2, null },
                    { 150, 150f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(832), null, true, 1f, null, "Spinach Feta Pizza", "\\FoodPhotos\\150.jpg", 2, null },
                    { 151, 145f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(833), null, true, 1f, null, "Spinach Pizza", "\\FoodPhotos\\151.jpg", 2, null },
                    { 152, 380f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(835), null, true, 1f, null, "Stuffed Crust Pizza", "\\FoodPhotos\\152.jpg", 2, null },
                    { 153, 157f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(836), null, true, 1f, null, "Thin Crust Pizza", "\\FoodPhotos\\153.jpg", 2, null },
                    { 154, 318f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(837), null, true, 1f, null, "Tuna Pizza", "\\FoodPhotos\\154.jpg", 2, null },
                    { 155, 263f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(843), null, true, 1f, null, "Veggie Pizza", "\\FoodPhotos\\155.jpg", 2, null },
                    { 156, 740f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(845), null, true, 1f, null, "Burger King Angry Whopper", "\\FoodPhotos\\156.jpg", 8, null },
                    { 157, 894f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(846), null, true, 1f, null, "Burger King Double Whopper", "\\FoodPhotos\\157.jpg", 8, null },
                    { 158, 994f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(850), null, true, 1f, null, "Burger King Double Whopper with Cheese", "\\FoodPhotos\\158.jpg", 8, null },
                    { 159, 659f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(851), null, true, 1f, null, "Burger King Original Chicken Sandwich", "\\FoodPhotos\\159.jpg", 8, null },
                    { 160, 591f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(852), null, true, 1f, null, "Burger King Premium Alaskan Fish Sandwich", "\\FoodPhotos\\160.jpg", 8, null },
                    { 161, 1471f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(853), null, true, 1f, null, "Burger King Triple Whopper", "\\FoodPhotos\\161.jpg", 8, null },
                    { 162, 672f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(854), null, true, 1f, null, "Burger King Whopper", "\\FoodPhotos\\162.jpg", 8, null },
                    { 163, 346f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(855), null, true, 1f, null, "Burger King Whopper Jr.", "\\FoodPhotos\\163.jpg", 8, null },
                    { 164, 759f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(856), null, true, 1f, null, "Burger King Whopper with Cheese", "\\FoodPhotos\\164.jpg", 8, null },
                    { 165, 410f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(858), null, true, 1f, null, "Cheeseburger", "\\FoodPhotos\\165.jpg", 8, null },
                    { 166, 170f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(859), null, true, 100f, null, "Chicken Breast", "\\FoodPhotos\\166.jpg", 0, null },
                    { 167, 59f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(860), null, true, 1f, null, "Chicken Nuggets", "\\FoodPhotos\\167.jpg", 8, null },
                    { 168, 410f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(861), null, true, 1f, null, "Chicken Sandwich", "\\FoodPhotos\\168.jpg", 8, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[,]
                {
                    { 169, 367f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(863), null, true, 1f, null, "Chicken Teriyaki Sandwich", "\\FoodPhotos\\169.jpg", 8, null },
                    { 170, 94f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(864), null, true, 1f, null, "Chicken Wings", "\\FoodPhotos\\170.jpg", 8, null },
                    { 171, 398f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(865), null, true, 1f, null, "Curly Fries", "\\FoodPhotos\\171.jpg", 9, null },
                    { 172, 414f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(866), null, true, 1f, null, "Double Cheeseburger", "\\FoodPhotos\\172.jpg", 8, null },
                    { 173, 222f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(867), null, true, 1f, null, "French Fries", "\\FoodPhotos\\173.jpg", 9, null },
                    { 174, 268f, 7, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(869), null, true, 1f, null, "Grilled Chicken Salad", "\\FoodPhotos\\174.jpg", 5, null },
                    { 175, 279f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(870), null, true, 1f, null, "Hamburger", "\\FoodPhotos\\175.jpg", 8, null },
                    { 176, 312f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(871), null, true, 1f, null, "Hot Dog", "\\FoodPhotos\\176.jpg", 8, null },
                    { 177, 481f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(872), null, true, 1f, null, "Meatball Sandwich", "\\FoodPhotos\\177.jpg", 8, null },
                    { 178, 25f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(873), null, true, 1f, null, "Onion Rings", "\\FoodPhotos\\178.jpg", 8, null },
                    { 179, 195f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(874), null, true, 100f, null, "Smoked Salmon", "\\FoodPhotos\\179.jpg", 0, null },
                    { 180, 312f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(875), null, true, 1f, null, "Subway Club Sandwich", "\\FoodPhotos\\180.jpg", 8, null },
                    { 181, 171f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(876), null, true, 1f, null, "Tortilla Wrap", "\\FoodPhotos\\181.jpg", 8, null },
                    { 182, 94f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(878), null, true, 100f, null, "Tuna", "\\FoodPhotos\\182.jpg", 0, null },
                    { 183, 135f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(879), null, true, 100f, null, "Turkey", "\\FoodPhotos\\183.jpg", 0, null },
                    { 184, 389f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(880), null, true, 1f, null, "Veggie Burger", "\\FoodPhotos\\184.jpg", 8, null },
                    { 185, 517f, 10, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(882), null, true, 1f, null, "Zinger", "\\FoodPhotos\\185.jpg", 8, null },
                    { 186, 68f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(883), null, true, 1f, null, "Egg", "\\FoodPhotos\\186.jpg", 8, null },
                    { 187, 160f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(884), null, true, 1f, null, "Steak", "\\FoodPhotos\\187.jpg", 2, null },
                    { 188, 375f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(885), null, true, 100f, null, "Cornflakes", "\\FoodPhotos\\188.jpg", 0, null },
                    { 189, 135f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(886), null, true, 1f, null, "Ice Cream Vanilla", "\\FoodPhotos\\189.jpg", 5, null },
                    { 190, 168f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(887), null, true, 1f, null, "Ice Cream Chocolate", "\\FoodPhotos\\190.jpg", 5, null },
                    { 191, 135f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(889), null, true, 1f, null, "Frozen Yogurt", "\\FoodPhotos\\191.jpg", 5, null },
                    { 192, 60f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(890), null, true, 100f, null, "Yogurt", "\\FoodPhotos\\192.jpg", 0, null },
                    { 193, 235f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(891), null, true, 1f, null, "Eclair", "\\FoodPhotos\\193.jpg", 8, null },
                    { 194, 350f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(892), null, true, 1f, null, "Milkshake", "\\FoodPhotos\\194.jpg", 1, null },
                    { 195, 400f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(893), null, true, 1f, null, "Milkshake Chocolate", "\\FoodPhotos\\195.jpg", 1, null },
                    { 196, 550f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(894), null, true, 100f, null, "Pepperoni", "\\FoodPhotos\\196.jpg", 0, null },
                    { 197, 55f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(895), null, true, 1f, null, "Macarons", "\\FoodPhotos\\197.jpg", 8, null },
                    { 198, 75f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(896), null, true, 1f, null, "Bread", "\\FoodPhotos\\198.jpg", 2, null },
                    { 199, 230f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(898), null, true, 1f, null, "Doughnut", "\\FoodPhotos\\199.jpg", 8, null },
                    { 200, 380f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(899), null, true, 1f, null, "Doughnut Chocolate", "\\FoodPhotos\\200.jpg", 8, null },
                    { 201, 2f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(900), null, true, 1f, null, "Tea", "\\FoodPhotos\\201.jpg", 1, null },
                    { 202, 11f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(902), null, true, 1f, null, "Sugar (Cube)", "\\FoodPhotos\\202.jpg", 8, null },
                    { 203, 387f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(903), null, true, 100f, null, "Sugar ", "\\FoodPhotos\\203.jpg", 0, null },
                    { 204, 373f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(904), null, true, 100f, null, "Sugar Brown", "\\FoodPhotos\\204.jpg", 0, null },
                    { 205, 329f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(905), null, true, 1f, null, "Cheesecake", "\\FoodPhotos\\205.jpg", 2, null },
                    { 206, 400f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(906), null, true, 1f, null, "Muffin", "\\FoodPhotos\\206.jpg", 8, null },
                    { 207, 155f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(912), null, true, 1f, null, "Milk", "\\FoodPhotos\\207.jpg", 1, null },
                    { 208, 87f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(913), null, true, 1f, null, "Milk(Non-Fat)", "\\FoodPhotos\\208.jpg", 1, null },
                    { 209, 230f, 6, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(914), null, true, 1f, null, "Brownie", "\\FoodPhotos\\209.jpg", 2, null },
                    { 210, 264f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(915), null, true, 100f, null, "Feta Cheese", "\\FoodPhotos\\210.jpg", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[,]
                {
                    { 211, 402f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(916), null, true, 100f, null, "Cheddar Cheese", "\\FoodPhotos\\211.jpg", 0, null },
                    { 212, 280f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(917), null, true, 100f, null, "Mozzarella Cheese", "\\FoodPhotos\\212.jpg", 0, null },
                    { 213, 430f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(918), null, true, 100f, null, "Parmesan Cheese", "\\FoodPhotos\\213.jpg", 0, null },
                    { 214, 342f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(920), null, true, 100f, null, "Cream Cheese", "\\FoodPhotos\\214.jpg", 0, null },
                    { 215, 364f, 8, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(921), null, true, 100f, null, "Goat Cheese", "\\FoodPhotos\\215.jpg", 0, null },
                    { 216, 98f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(922), null, true, 1f, null, "Coke", "\\FoodPhotos\\216.jpg", 1, null },
                    { 217, 1f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(925), null, true, 1f, null, "Coke Zero", "\\FoodPhotos\\217.jpg", 1, null },
                    { 218, 2f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(927), null, true, 1f, null, "Americano", "\\FoodPhotos\\218.jpg", 1, null },
                    { 219, 2f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(928), null, true, 1f, null, "Espresso", "\\FoodPhotos\\219.jpg", 1, null },
                    { 220, 70f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(930), null, true, 1f, null, "Cappuccino", "\\FoodPhotos\\220.jpg", 1, null },
                    { 221, 120f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(931), null, true, 1f, null, "Latte", "\\FoodPhotos\\221.jpg", 1, null },
                    { 222, 210f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(932), null, true, 1f, null, "Mocha", "\\FoodPhotos\\222.jpg", 1, null },
                    { 223, 70f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(933), null, true, 1f, null, "Iced Latte", "\\FoodPhotos\\223.jpg", 1, null },
                    { 224, 180f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(934), null, true, 1f, null, "Iced Mocha", "\\FoodPhotos\\224.jpg", 1, null },
                    { 225, 260f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(935), null, true, 1f, null, "Frappuccino", "\\FoodPhotos\\225.jpg", 1, null },
                    { 226, 630f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(936), null, true, 100f, null, "Chocolate(Bitter)", "\\FoodPhotos\\226.jpg", 0, null },
                    { 227, 542f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(938), null, true, 100f, null, "Chocolate(Milk)", "\\FoodPhotos\\227.jpg", 0, null },
                    { 228, 557f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(939), null, true, 100f, null, "Chocolate(White)", "\\FoodPhotos\\228.jpg", 0, null },
                    { 229, 260f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(940), null, true, 100f, null, "Ground Meat", "\\FoodPhotos\\229.jpg", 0, null },
                    { 230, 65f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(941), null, true, 1f, null, "Meatball", "\\FoodPhotos\\230.jpg", 8, null },
                    { 231, 1f, 3, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(942), null, true, 1f, null, "Mineral Water", "\\FoodPhotos\\231.jpg", 1, null },
                    { 232, 119f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(943), null, true, 1f, null, "Olive Oil", "\\FoodPhotos\\232.jpg", 7, null },
                    { 233, 124f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(944), null, true, 1f, null, "Canola Oil", "\\FoodPhotos\\233.jpg", 7, null },
                    { 234, 120f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(945), null, true, 1f, null, "Sunflower Oil", "\\FoodPhotos\\234.jpg", 7, null },
                    { 235, 120f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(947), null, true, 1f, null, "Sesame Oil", "\\FoodPhotos\\235.jpg", 7, null },
                    { 236, 122f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(949), null, true, 1f, null, "Corn Oil", "\\FoodPhotos\\236.jpg", 7, null },
                    { 237, 364f, 13, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(950), null, true, 100f, null, "Flour", "\\FoodPhotos\\237.jpg", 0, null },
                    { 238, 95f, 11, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(951), null, true, 1f, null, "Sunnyside-up", "\\FoodPhotos\\238.jpg", 8, null },
                    { 239, 15f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(952), null, true, 1f, null, "Red Wine", "\\FoodPhotos\\239.jpg", 1, null },
                    { 240, 125f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(953), null, true, 1f, null, "White Wine", "\\FoodPhotos\\240.jpg", 1, null },
                    { 241, 155f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(954), null, true, 1f, null, "Beer", "\\FoodPhotos\\241.jpg", 1, null },
                    { 242, 95f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(955), null, true, 1f, null, "Champagne", "\\FoodPhotos\\242.jpg", 1, null },
                    { 243, 96f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(956), null, true, 1f, null, "Vodka", "\\FoodPhotos\\243.jpg", 1, null },
                    { 244, 97f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(958), null, true, 1f, null, "Rum", "\\FoodPhotos\\244.jpg", 1, null },
                    { 245, 98f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(959), null, true, 1f, null, "Whiskey", "\\FoodPhotos\\245.jpg", 1, null },
                    { 246, 98f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(960), null, true, 1f, null, "Tequila", "\\FoodPhotos\\246.jpg", 1, null },
                    { 247, 96f, 4, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(961), null, true, 1f, null, "Gin", "\\FoodPhotos\\247.jpg", 1, null },
                    { 248, 119f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(962), null, true, 100f, null, "Trout", "\\FoodPhotos\\248.jpg", 0, null },
                    { 249, 111f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(963), null, true, 100f, null, "Halibut", "\\FoodPhotos\\249.jpg", 0, null },
                    { 250, 208f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(965), null, true, 100f, null, "Sardines", "\\FoodPhotos\\250.jpg", 0, null },
                    { 251, 305f, 9, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(966), null, true, 100f, null, "Mackerel", "\\FoodPhotos\\251.jpg", 0, null },
                    { 252, 280f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(967), null, true, 1f, null, "Snickers", "\\FoodPhotos\\252.jpg", 8, null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[] { 253, 250f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(968), null, true, 1f, null, "Twix", "\\FoodPhotos\\253.jpg", 8, null });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "ID", "Calorie", "CategoryID", "CreatedDate", "DeletedDate", "IsActive", "Measurement", "ModifiedDate", "Name", "Picture", "PortionType", "UserID" },
                values: new object[] { 254, 210f, 5, new DateTime(2023, 9, 21, 16, 53, 47, 985, DateTimeKind.Local).AddTicks(969), null, true, 1f, null, "Kit Kat", "\\FoodPhotos\\254.jpg", 8, null });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserId",
                table: "Meals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutritions_CategoryID",
                table: "Nutritions",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Nutritions_UserID",
                table: "Nutritions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersMealsHistories_MealID",
                table: "UsersMealsHistories",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersMealsHistories_NutritionID",
                table: "UsersMealsHistories",
                column: "NutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersMealsHistories_UserID",
                table: "UsersMealsHistories",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "UsersMealsHistories");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
