using Microsoft.EntityFrameworkCore.Migrations;

namespace GMall.EFCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbBrand",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Url = table.Column<string>(type: "varchar(50)", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbBrandPicture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PictureId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    UseType = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBrandPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbCategoryPicture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    UseType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PictureId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategoryPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbCategoryProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategoryProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbCategoryPropertyValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyValueId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategoryPropertyValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPicture",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    RemoteUrl = table.Column<string>(type: "varchar(50)", nullable: true),
                    LocalPath = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProduct",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ModelCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(4000)", nullable: true),
                    BrandId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductCustomProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyValue = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductCustomProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductPicture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PictureId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    UseType = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyValueId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyValue = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductSaleProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductSaleProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductSalePropertyValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyValueId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductSalePropertyValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductSku",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    SpecificationId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "0"),
                    PictureId = table.Column<long>(type: "bigint", nullable: false),
                    Sellable = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Available = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductSku", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductSpecification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyString = table.Column<string>(type: "nvarchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductSpecification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbProductSpecificationProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    SpecificationId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    Property = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PropertyValueId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    PropertyValue = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductSpecificationProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPropertyDO",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPropertyDO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPropertyValueDO",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPropertyValueDO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbBrand");

            migrationBuilder.DropTable(
                name: "TbBrandPicture");

            migrationBuilder.DropTable(
                name: "TbCategory");

            migrationBuilder.DropTable(
                name: "TbCategoryPicture");

            migrationBuilder.DropTable(
                name: "TbCategoryProperty");

            migrationBuilder.DropTable(
                name: "TbCategoryPropertyValue");

            migrationBuilder.DropTable(
                name: "TbPicture");

            migrationBuilder.DropTable(
                name: "TbProduct");

            migrationBuilder.DropTable(
                name: "TbProductCustomProperty");

            migrationBuilder.DropTable(
                name: "TbProductPicture");

            migrationBuilder.DropTable(
                name: "TbProductProperty");

            migrationBuilder.DropTable(
                name: "TbProductSaleProperty");

            migrationBuilder.DropTable(
                name: "TbProductSalePropertyValue");

            migrationBuilder.DropTable(
                name: "TbProductSku");

            migrationBuilder.DropTable(
                name: "TbProductSpecification");

            migrationBuilder.DropTable(
                name: "TbProductSpecificationProperty");

            migrationBuilder.DropTable(
                name: "TbPropertyDO");

            migrationBuilder.DropTable(
                name: "TbPropertyValueDO");
        }
    }
}
