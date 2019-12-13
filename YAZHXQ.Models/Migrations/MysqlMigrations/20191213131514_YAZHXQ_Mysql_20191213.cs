using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YAZHXQ.Models.Migrations.MysqlMigrations
{
    public partial class YAZHXQ_Mysql_20191213 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "AccountBook",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProId = table.Column<int>(nullable: false),
                    SuppId = table.Column<int>(nullable: true),
                    AccountType = table.Column<int>(nullable: false),
                    IncOrExpType = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    IncOrExpName = table.Column<string>(maxLength: 50, nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBook", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    IsRelease = table.Column<bool>(nullable: false),
                    ReleaseArea = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderID = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchBorrowHistory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArchID = table.Column<int>(nullable: false),
                    BorrowPeople = table.Column<string>(nullable: true),
                    DoStaffID = table.Column<int>(nullable: false),
                    DoDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OldStatus = table.Column<int>(nullable: false),
                    NewStatus = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchBorrowHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchClass",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PID = table.Column<int>(nullable: false),
                    ClassCode = table.Column<string>(maxLength: 200, nullable: false),
                    ClassName = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Hierarchy = table.Column<int>(nullable: false),
                    Path = table.Column<string>(maxLength: 50, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TargetAcrhType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchClass", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchColumn",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PID = table.Column<int>(nullable: false),
                    ColCode = table.Column<string>(maxLength: 50, nullable: false),
                    ColName = table.Column<string>(maxLength: 100, nullable: false),
                    ColType = table.Column<int>(nullable: false),
                    ColText = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    ArchType = table.Column<int>(nullable: false),
                    NullCheck = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchColumn", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchDisplay",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ColID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    DisplayType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchDisplay", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchFile",
                columns: table => new
                {
                    FileID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FileDataID = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 50, nullable: true),
                    FileUrl = table.Column<string>(maxLength: 300, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    DoDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MenuType = table.Column<int>(nullable: false),
                    QCStaffID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    HierarchyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchFile", x => x.FileID);
                });

            migrationBuilder.CreateTable(
                name: "ArchFileDataPrivate",
                columns: table => new
                {
                    FileDataID = table.Column<int>(nullable: false),
                    ColID = table.Column<int>(nullable: false),
                    ColText = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchFileDataPrivate", x => new { x.FileDataID, x.ColID });
                });

            migrationBuilder.CreateTable(
                name: "ArchFileDataPublic",
                columns: table => new
                {
                    FileDataID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuID = table.Column<int>(nullable: false),
                    MenuType = table.Column<int>(nullable: false),
                    ZLStaffID = table.Column<int>(nullable: false),
                    ZLDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchFileDataPublic", x => x.FileDataID);
                });

            migrationBuilder.CreateTable(
                name: "ArchMenu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArchID = table.Column<int>(nullable: false),
                    MenuName = table.Column<string>(maxLength: 200, nullable: false),
                    PageNum = table.Column<int>(nullable: false),
                    FileType = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    DoStaffID = table.Column<int>(nullable: false),
                    DoDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    MenuType = table.Column<int>(nullable: true),
                    ArchType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchMenu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "ArchMenuClass",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PID = table.Column<int>(nullable: false),
                    ClassCode = table.Column<string>(maxLength: 200, nullable: false),
                    ClassName = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Hierarchy = table.Column<int>(nullable: false),
                    Path = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchMenuClass", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchMenuColumn",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PID = table.Column<int>(nullable: false),
                    ColCode = table.Column<string>(maxLength: 50, nullable: false),
                    ColName = table.Column<string>(maxLength: 100, nullable: false),
                    ColType = table.Column<int>(nullable: false),
                    ColText = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    MenuType = table.Column<int>(nullable: false),
                    NullCheck = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchMenuColumn", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchMenuDisplay",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ColCode = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    DisplayType = table.Column<int>(nullable: false),
                    MenuType = table.Column<int>(nullable: false),
                    ArchType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchMenuDisplay", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchPrivate",
                columns: table => new
                {
                    ArchID = table.Column<int>(nullable: false),
                    ColID = table.Column<int>(nullable: false),
                    ColText = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchPrivate", x => new { x.ArchID, x.ColID });
                });

            migrationBuilder.CreateTable(
                name: "ArchPublic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    ArchCode = table.Column<string>(maxLength: 200, nullable: false),
                    DocketCode = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Town = table.Column<int>(nullable: false),
                    Village = table.Column<int>(nullable: false),
                    Group = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Reason = table.Column<string>(maxLength: 500, nullable: true),
                    SHStaffID = table.Column<int>(nullable: false),
                    SHDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ZLStaffID = table.Column<int>(nullable: false),
                    ZLDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SJStaffID = table.Column<int>(nullable: false),
                    SJDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ArchType = table.Column<int>(nullable: false),
                    BorrowPeople = table.Column<string>(nullable: true),
                    BorrowDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BorrowStatus = table.Column<int>(nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StoreBeyound = table.Column<string>(nullable: true),
                    SecretLevel = table.Column<string>(nullable: true),
                    ResponsPoeple = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TargetAcrhId = table.Column<int>(nullable: true),
                    XNDA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchPublic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArchVirtual",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentID = table.Column<int>(nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    OrderID = table.Column<int>(nullable: true),
                    Hierarchy = table.Column<int>(nullable: true),
                    Path = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchVirtual", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BaseData",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Desc = table.Column<string>(maxLength: 200, nullable: true),
                    DataCode = table.Column<string>(maxLength: 20, nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Lvl = table.Column<int>(nullable: false),
                    Path = table.Column<string>(maxLength: 200, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpotId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Length = table.Column<decimal>(nullable: true),
                    Param = table.Column<string>(maxLength: 2000, nullable: true),
                    Remark = table.Column<string>(maxLength: 2000, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CNArea",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    PARENT_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    SHORT_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    PARENT_SHORT_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    NAME = table.Column<string>(maxLength: 500, nullable: true),
                    PROVINCE1 = table.Column<string>(maxLength: 500, nullable: true),
                    CITY1 = table.Column<string>(maxLength: 500, nullable: true),
                    DISTRICT1 = table.Column<string>(maxLength: 500, nullable: true),
                    TOWN1 = table.Column<string>(maxLength: 500, nullable: true),
                    VILLAGE1 = table.Column<string>(maxLength: 500, nullable: true),
                    GRADE = table.Column<int>(nullable: false),
                    PROVINCE = table.Column<string>(maxLength: 500, nullable: true),
                    CITY = table.Column<string>(maxLength: 500, nullable: true),
                    DISTRICT = table.Column<string>(maxLength: 500, nullable: true),
                    TOWN = table.Column<string>(maxLength: 500, nullable: true),
                    VILLAGE = table.Column<string>(maxLength: 500, nullable: true),
                    FULL_NAME = table.Column<string>(maxLength: 500, nullable: true),
                    CATEGORY = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CNArea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DBBackup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    DataBasePath = table.Column<string>(maxLength: 50, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBackup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeptInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(maxLength: 20, nullable: false),
                    OrgCode = table.Column<string>(maxLength: 20, nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Tel = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    ManagerName = table.Column<string>(maxLength: 20, nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(maxLength: 200, nullable: true),
                    Lvl = table.Column<int>(nullable: true),
                    Path = table.Column<string>(maxLength: 200, nullable: true),
                    Grade = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Param = table.Column<string>(maxLength: 2000, nullable: true),
                    Brand = table.Column<string>(maxLength: 20, nullable: true),
                    Quantity = table.Column<decimal>(nullable: true),
                    Unit = table.Column<string>(maxLength: 10, nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(maxLength: 2000, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceOfBasis",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    TableType = table.Column<int>(nullable: false),
                    DataID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceOfBasis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FilePermission",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FileID = table.Column<int>(nullable: false),
                    DeptID = table.Column<int>(nullable: true),
                    StaffID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilePermission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FilesInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(maxLength: 100, nullable: false),
                    FilePath = table.Column<string>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    FileDesc = table.Column<string>(maxLength: 500, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FunAttribute",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FunID = table.Column<int>(nullable: false),
                    LayerAttrID = table.Column<int>(nullable: false),
                    AttributeType = table.Column<int>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunAttribute", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FunctionInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FunctionName = table.Column<string>(maxLength: 200, nullable: false),
                    FunScriptId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    FunctionType = table.Column<int>(nullable: true),
                    StatisticeUnit = table.Column<int>(nullable: true),
                    StatisticalType = table.Column<int>(nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsShow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FunMapService",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FunID = table.Column<int>(nullable: false),
                    MapID = table.Column<int>(nullable: false),
                    LayerIDs = table.Column<string>(nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunMapService", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FunPost",
                columns: table => new
                {
                    FID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunPost", x => new { x.FID, x.PostID });
                });

            migrationBuilder.CreateTable(
                name: "FunRole",
                columns: table => new
                {
                    FID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunRole", x => new { x.FID, x.RoleID });
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GoodsName = table.Column<string>(maxLength: 100, nullable: false),
                    PurchaseID = table.Column<int>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    INQuantity = table.Column<decimal>(nullable: true),
                    OUTQuantity = table.Column<decimal>(nullable: true),
                    WaitQuantity = table.Column<decimal>(nullable: true),
                    Stocks = table.Column<decimal>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    SumMonmey = table.Column<decimal>(nullable: false),
                    Supplier = table.Column<string>(maxLength: 100, nullable: true),
                    ModelNumbers = table.Column<string>(maxLength: 100, nullable: true),
                    Unit = table.Column<string>(maxLength: 20, nullable: true),
                    Parameter = table.Column<string>(maxLength: 100, nullable: true),
                    SourceType = table.Column<int>(nullable: false),
                    ExchangeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HolidaySet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SetDay = table.Column<DateTime>(type: "date", nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidaySet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InBox",
                columns: table => new
                {
                    MsgID = table.Column<int>(nullable: false),
                    ReceiverID = table.Column<int>(nullable: false),
                    ReadTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DelTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InBox", x => new { x.MsgID, x.ReceiverID });
                });

            migrationBuilder.CreateTable(
                name: "Layer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MapID = table.Column<int>(nullable: false),
                    LayerIndex = table.Column<int>(nullable: false),
                    LayerName = table.Column<string>(maxLength: 100, nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsShow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LayerAttribute",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LayersID = table.Column<int>(nullable: false),
                    AttributeName = table.Column<string>(maxLength: 50, nullable: false),
                    Alias = table.Column<string>(maxLength: 50, nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayerAttribute", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LogInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuID = table.Column<int>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    IP = table.Column<string>(maxLength: 25, nullable: false),
                    TableName = table.Column<string>(maxLength: 100, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    AccountNo = table.Column<string>(maxLength: 50, nullable: true),
                    DeptID = table.Column<int>(nullable: true),
                    DeptName = table.Column<string>(maxLength: 200, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MapPost",
                columns: table => new
                {
                    MID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPost", x => new { x.MID, x.PostID });
                });

            migrationBuilder.CreateTable(
                name: "MapRole",
                columns: table => new
                {
                    MID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapRole", x => new { x.MID, x.RoleID });
                });

            migrationBuilder.CreateTable(
                name: "MapService",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MapServiceName = table.Column<string>(maxLength: 200, nullable: false),
                    MapServiceURL = table.Column<string>(maxLength: 500, nullable: false),
                    MapServiceType = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    IsView = table.Column<bool>(nullable: false),
                    ParentID = table.Column<int>(nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapService", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeID = table.Column<int>(nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    CreatorID = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DelTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ModelMenu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuName = table.Column<string>(maxLength: 50, nullable: false),
                    ParentID = table.Column<int>(nullable: true),
                    OrderID = table.Column<int>(nullable: false),
                    ModelType = table.Column<int>(nullable: false),
                    TargetURL = table.Column<string>(maxLength: 100, nullable: true),
                    Lvl = table.Column<int>(nullable: true),
                    Path = table.Column<string>(maxLength: 200, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelMenu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ModelMenuPermission",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuID = table.Column<int>(nullable: false),
                    AreaCode = table.Column<string>(maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(maxLength: 20, nullable: true),
                    ControllerName = table.Column<string>(maxLength: 20, nullable: false),
                    ControllerCode = table.Column<string>(maxLength: 50, nullable: false),
                    ActionName = table.Column<string>(maxLength: 20, nullable: false),
                    ActionCode = table.Column<string>(maxLength: 50, nullable: false),
                    DependOn = table.Column<int>(nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsOpen = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelMenuPermission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(nullable: true),
                    TopicID = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    IsTopicOnly = table.Column<bool>(nullable: false),
                    PubDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 50, nullable: true),
                    Summary = table.Column<string>(maxLength: 80, nullable: true),
                    Source = table.Column<string>(maxLength: 20, nullable: true),
                    Author = table.Column<string>(maxLength: 20, nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NewsTopic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Logo = table.Column<string>(maxLength: 50, nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTopic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PostInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(maxLength: 100, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PostPermissions",
                columns: table => new
                {
                    MPID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPermissions", x => new { x.MPID, x.PostID });
                });

            migrationBuilder.CreateTable(
                name: "ProjectInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PName = table.Column<string>(maxLength: 200, nullable: false),
                    PStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PFinshTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CurrentState = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    PCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    BuildCompany = table.Column<string>(maxLength: 50, nullable: true),
                    BuildCompanyInfo = table.Column<string>(maxLength: 500, nullable: true),
                    ConCompany = table.Column<string>(maxLength: 50, nullable: true),
                    ConCompanyInfo = table.Column<string>(maxLength: 500, nullable: true),
                    Schedule = table.Column<int>(nullable: false),
                    AcceptTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    GISProType = table.Column<int>(nullable: false),
                    GISObjID = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProPlan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProID = table.Column<int>(nullable: false),
                    TabID = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Workers = table.Column<int>(nullable: false),
                    WorkDays = table.Column<decimal>(nullable: true),
                    Leader = table.Column<string>(maxLength: 50, nullable: false),
                    Resource = table.Column<string>(maxLength: 500, nullable: true),
                    WorkFocus = table.Column<string>(maxLength: 500, nullable: true),
                    WorkTask = table.Column<string>(maxLength: 500, nullable: true),
                    WorkResults = table.Column<string>(maxLength: 500, nullable: true),
                    Hazard = table.Column<string>(maxLength: 500, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProPlan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProStakeholder",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Unit = table.Column<string>(maxLength: 200, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: true),
                    Tel = table.Column<string>(maxLength: 100, nullable: false),
                    ProContent = table.Column<string>(maxLength: 200, nullable: true),
                    ProID = table.Column<int>(nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProStakeholder", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PunchClock",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MeId = table.Column<string>(maxLength: 20, nullable: true),
                    AMStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AMEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PMStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PMEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsError = table.Column<int>(nullable: true),
                    MeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MeName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunchClock", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numbers = table.Column<string>(maxLength: 50, nullable: true),
                    Heading = table.Column<string>(maxLength: 100, nullable: false),
                    ProID = table.Column<int>(nullable: true),
                    ApplyTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CompletionTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Remake = table.Column<string>(maxLength: 200, nullable: true),
                    PurchaseType = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrExchange",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GoodsID = table.Column<int>(nullable: false),
                    RetOrExNO = table.Column<string>(maxLength: 50, nullable: false),
                    ProID = table.Column<int>(nullable: true),
                    ApplyTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    GoodsName = table.Column<string>(maxLength: 100, nullable: false),
                    RetOrExType = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Brokerage = table.Column<int>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    ModelNumbers = table.Column<string>(maxLength: 100, nullable: true),
                    Unit = table.Column<string>(maxLength: 20, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RelationNO = table.Column<string>(maxLength: 50, nullable: true),
                    Source = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrExchange", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(maxLength: 2000, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    MPID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.MPID, x.RoleID });
                });

            migrationBuilder.CreateTable(
                name: "SceneFile",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuID = table.Column<int>(nullable: false),
                    DataID = table.Column<int>(nullable: false),
                    TableType = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 200, nullable: false),
                    FileUrl = table.Column<string>(maxLength: 300, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    DoStaffID = table.Column<int>(nullable: false),
                    DoDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FileType = table.Column<string>(nullable: true),
                    ProjTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneFile", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SceneMenu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataID = table.Column<int>(nullable: false),
                    TableType = table.Column<int>(nullable: false),
                    MenuCode = table.Column<string>(maxLength: 200, nullable: true),
                    MenuName = table.Column<string>(maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneMenu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpotBasis",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpotID = table.Column<int>(nullable: false),
                    BasisCode = table.Column<string>(maxLength: 50, nullable: false),
                    BasisClass = table.Column<int>(nullable: false),
                    BasisLocation = table.Column<string>(maxLength: 100, nullable: false),
                    SoilClass = table.Column<string>(maxLength: 100, nullable: true),
                    DesignSize = table.Column<string>(maxLength: 100, nullable: true),
                    DesignCubage = table.Column<string>(maxLength: 100, nullable: true),
                    ActualSize = table.Column<string>(maxLength: 100, nullable: true),
                    ActualCubage = table.Column<string>(maxLength: 100, nullable: true),
                    Remark = table.Column<string>(maxLength: 2000, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotBasis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpotFile",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpotMenuID = table.Column<int>(nullable: false),
                    SpotID = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 200, nullable: false),
                    FileUrl = table.Column<string>(maxLength: 300, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    DoDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    HierarchyID = table.Column<int>(nullable: false),
                    DoStaffID = table.Column<int>(nullable: false),
                    FileType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotFile", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpotMenu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PID = table.Column<int>(nullable: false),
                    MenuCode = table.Column<string>(maxLength: 200, nullable: false),
                    MenuName = table.Column<string>(maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Hierarchy = table.Column<int>(nullable: false),
                    Path = table.Column<string>(maxLength: 50, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SpotID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotMenu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Spotting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProID = table.Column<int>(nullable: false),
                    SpotCode = table.Column<string>(maxLength: 50, nullable: false),
                    SpotName = table.Column<string>(maxLength: 100, nullable: false),
                    SpotSchedule = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 1000, nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    GISSoptType = table.Column<int>(nullable: false),
                    GISSoptID = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SpotClass = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spotting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StaffDepts",
                columns: table => new
                {
                    DeptID = table.Column<int>(nullable: false),
                    StaffID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffDepts", x => new { x.DeptID, x.StaffID });
                });

            migrationBuilder.CreateTable(
                name: "StaffInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountNo = table.Column<string>(maxLength: 20, nullable: false),
                    KQJNo = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    Tel = table.Column<string>(maxLength: 24, nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    AreasCode = table.Column<string>(nullable: true),
                    AccountPwd = table.Column<string>(maxLength: 50, nullable: false),
                    SexName = table.Column<string>(maxLength: 10, nullable: true),
                    SexCode = table.Column<int>(nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    ColledgeName = table.Column<string>(maxLength: 50, nullable: true),
                    ProfessionalName = table.Column<string>(maxLength: 20, nullable: true),
                    StaffImg = table.Column<string>(maxLength: 50, nullable: true),
                    MarriageName = table.Column<string>(maxLength: 10, nullable: true),
                    MarriageCode = table.Column<int>(nullable: true),
                    NationalCode = table.Column<int>(nullable: true),
                    NationalName = table.Column<string>(maxLength: 20, nullable: true),
                    PoliticalStatusName = table.Column<string>(maxLength: 50, nullable: true),
                    PoliticalStatusCode = table.Column<int>(nullable: true),
                    IDNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 320, nullable: true),
                    OtherInfo = table.Column<string>(maxLength: 2000, nullable: true),
                    PostID = table.Column<int>(nullable: true),
                    DeptID = table.Column<int>(nullable: false),
                    StaffIP = table.Column<string>(maxLength: 20, nullable: true),
                    Grade = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StaffPosts",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false),
                    StaffID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffPosts", x => new { x.PostID, x.StaffID });
                });

            migrationBuilder.CreateTable(
                name: "StaffRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false),
                    StaffID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRoles", x => new { x.RoleID, x.StaffID });
                });

            migrationBuilder.CreateTable(
                name: "StockIn",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WareNO = table.Column<string>(maxLength: 50, nullable: false),
                    GoodsID = table.Column<int>(nullable: false),
                    PurNO = table.Column<string>(maxLength: 50, nullable: true),
                    BackNO = table.Column<string>(maxLength: 50, nullable: true),
                    ProID = table.Column<int>(nullable: true),
                    WareTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    GoodsName = table.Column<string>(maxLength: 100, nullable: false),
                    GoodsFrom = table.Column<int>(nullable: false),
                    Brokerage = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    ModelNumbers = table.Column<string>(maxLength: 100, nullable: true),
                    Unit = table.Column<string>(maxLength: 20, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIn", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StockOut",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OutNO = table.Column<string>(maxLength: 50, nullable: false),
                    GoodsID = table.Column<int>(nullable: false),
                    InNO = table.Column<string>(maxLength: 50, nullable: false),
                    ProID = table.Column<int>(nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    GoodsName = table.Column<string>(maxLength: 100, nullable: false),
                    Brokerage = table.Column<int>(nullable: false),
                    Using = table.Column<string>(maxLength: 100, nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    ModelNumbers = table.Column<string>(maxLength: 100, nullable: true),
                    Unit = table.Column<string>(maxLength: 20, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockOut", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupplierInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(maxLength: 50, nullable: false),
                    PostCode = table.Column<string>(maxLength: 10, nullable: true),
                    RegAddr = table.Column<string>(maxLength: 100, nullable: true),
                    CompanyTel = table.Column<string>(maxLength: 20, nullable: true),
                    TAX_ID = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNum = table.Column<string>(maxLength: 20, nullable: true),
                    Bank = table.Column<string>(maxLength: 50, nullable: true),
                    BankAccount = table.Column<string>(maxLength: 30, nullable: true),
                    InvoiceName = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceAddr = table.Column<string>(maxLength: 100, nullable: true),
                    Corporate = table.Column<string>(maxLength: 50, nullable: true),
                    Contacts = table.Column<string>(maxLength: 20, nullable: true),
                    LinkTel = table.Column<string>(maxLength: 20, nullable: true),
                    CompanyNature = table.Column<string>(maxLength: 50, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupplierProject",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SuppId = table.Column<int>(nullable: false),
                    ProId = table.Column<int>(nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    JointTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Goods = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    FirstTel = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    SecondName = table.Column<string>(maxLength: 50, nullable: true),
                    SecondTel = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Remark = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProject", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tb_KnowledgeBase",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(nullable: true),
                    SharedBy = table.Column<string>(maxLength: 30, nullable: true),
                    SharedByName = table.Column<string>(maxLength: 50, nullable: true),
                    SharedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AttachmentUrl = table.Column<string>(maxLength: 100, nullable: true),
                    AttachmentName = table.Column<string>(maxLength: 50, nullable: true),
                    Classfy = table.Column<string>(maxLength: 20, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_KnowledgeBase", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WOrderArchivedRecords",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkOrderID = table.Column<int>(nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: false),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WOrderArchivedRecords", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WOrderFile",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WOrderID = table.Column<int>(nullable: false),
                    WOrderFileType = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 200, nullable: false),
                    FileUrl = table.Column<string>(maxLength: 300, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    FileType = table.Column<string>(nullable: true),
                    ProjTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WOrderFile", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WOrderRepair",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkOrderID = table.Column<int>(nullable: false),
                    RepairContent = table.Column<string>(maxLength: 200, nullable: false),
                    RepairVehicle = table.Column<string>(maxLength: 20, nullable: false),
                    RepairCost = table.Column<string>(maxLength: 20, nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    CreateStaffID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WOrderRepair", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateStaffID = table.Column<int>(nullable: false),
                    Intersection = table.Column<string>(maxLength: 20, nullable: false),
                    DeviceName = table.Column<string>(maxLength: 30, nullable: false),
                    SourceOfError = table.Column<int>(nullable: false),
                    TypeOfError = table.Column<int>(nullable: false),
                    DescOfError = table.Column<string>(maxLength: 200, nullable: false),
                    ProcessStatus = table.Column<int>(nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateStaffID = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchID",
                table: "ArchBorrowHistory",
                column: "ArchID");

            migrationBuilder.CreateIndex(
                name: "IX_FunID",
                table: "FunAttribute",
                column: "FunID");

            migrationBuilder.CreateIndex(
                name: "IX_LayerAttrID",
                table: "FunAttribute",
                column: "LayerAttrID");

            migrationBuilder.CreateIndex(
                name: "IX_FunID",
                table: "FunMapService",
                column: "FunID");

            migrationBuilder.CreateIndex(
                name: "IX_MapID",
                table: "FunMapService",
                column: "MapID");

            migrationBuilder.CreateIndex(
                name: "IX_FID",
                table: "FunPost",
                column: "FID");

            migrationBuilder.CreateIndex(
                name: "IX_PostID",
                table: "FunPost",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_FID",
                table: "FunRole",
                column: "FID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleID",
                table: "FunRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_MapID",
                table: "Layer",
                column: "MapID");

            migrationBuilder.CreateIndex(
                name: "IX_LayersID",
                table: "LayerAttribute",
                column: "LayersID");

            migrationBuilder.CreateIndex(
                name: "IX_MID",
                table: "MapPost",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_PostID",
                table: "MapPost",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_MID",
                table: "MapRole",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleID",
                table: "MapRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CreateStaffID",
                table: "WOrderArchivedRecords",
                column: "CreateStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_CreateStaffID",
                table: "WOrderRepair",
                column: "CreateStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_CreateStaffID",
                table: "WorkOrder",
                column: "CreateStaffID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "AccountBook");

            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "ArchBorrowHistory");

            migrationBuilder.DropTable(
                name: "ArchClass");

            migrationBuilder.DropTable(
                name: "ArchColumn");

            migrationBuilder.DropTable(
                name: "ArchDisplay");

            migrationBuilder.DropTable(
                name: "ArchFile");

            migrationBuilder.DropTable(
                name: "ArchFileDataPrivate");

            migrationBuilder.DropTable(
                name: "ArchFileDataPublic");

            migrationBuilder.DropTable(
                name: "ArchMenu");

            migrationBuilder.DropTable(
                name: "ArchMenuClass");

            migrationBuilder.DropTable(
                name: "ArchMenuColumn");

            migrationBuilder.DropTable(
                name: "ArchMenuDisplay");

            migrationBuilder.DropTable(
                name: "ArchPrivate");

            migrationBuilder.DropTable(
                name: "ArchPublic");

            migrationBuilder.DropTable(
                name: "ArchVirtual");

            migrationBuilder.DropTable(
                name: "BaseData");

            migrationBuilder.DropTable(
                name: "Cable");

            migrationBuilder.DropTable(
                name: "CNArea");

            migrationBuilder.DropTable(
                name: "DBBackup");

            migrationBuilder.DropTable(
                name: "DeptInfo");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "DeviceOfBasis");

            migrationBuilder.DropTable(
                name: "FilePermission");

            migrationBuilder.DropTable(
                name: "FilesInfo");

            migrationBuilder.DropTable(
                name: "FunAttribute");

            migrationBuilder.DropTable(
                name: "FunctionInfo");

            migrationBuilder.DropTable(
                name: "FunMapService");

            migrationBuilder.DropTable(
                name: "FunPost");

            migrationBuilder.DropTable(
                name: "FunRole");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "HolidaySet");

            migrationBuilder.DropTable(
                name: "InBox");

            migrationBuilder.DropTable(
                name: "Layer");

            migrationBuilder.DropTable(
                name: "LayerAttribute");

            migrationBuilder.DropTable(
                name: "LogInfo");

            migrationBuilder.DropTable(
                name: "MapPost");

            migrationBuilder.DropTable(
                name: "MapRole");

            migrationBuilder.DropTable(
                name: "MapService");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "ModelMenu");

            migrationBuilder.DropTable(
                name: "ModelMenuPermission");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsTopic");

            migrationBuilder.DropTable(
                name: "PostInfo");

            migrationBuilder.DropTable(
                name: "PostPermissions");

            migrationBuilder.DropTable(
                name: "ProjectInfo");

            migrationBuilder.DropTable(
                name: "ProPlan");

            migrationBuilder.DropTable(
                name: "ProStakeholder");

            migrationBuilder.DropTable(
                name: "PunchClock");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "ReturnOrExchange");

            migrationBuilder.DropTable(
                name: "RoleInfo");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "SceneFile");

            migrationBuilder.DropTable(
                name: "SceneMenu");

            migrationBuilder.DropTable(
                name: "SpotBasis");

            migrationBuilder.DropTable(
                name: "SpotFile");

            migrationBuilder.DropTable(
                name: "SpotMenu");

            migrationBuilder.DropTable(
                name: "Spotting");

            migrationBuilder.DropTable(
                name: "StaffDepts");

            migrationBuilder.DropTable(
                name: "StaffInfo");

            migrationBuilder.DropTable(
                name: "StaffPosts");

            migrationBuilder.DropTable(
                name: "StaffRoles");

            migrationBuilder.DropTable(
                name: "StockIn");

            migrationBuilder.DropTable(
                name: "StockOut");

            migrationBuilder.DropTable(
                name: "SupplierInfo");

            migrationBuilder.DropTable(
                name: "SupplierProject");

            migrationBuilder.DropTable(
                name: "tb_KnowledgeBase");

            migrationBuilder.DropTable(
                name: "WOrderArchivedRecords");

            migrationBuilder.DropTable(
                name: "WOrderFile");

            migrationBuilder.DropTable(
                name: "WOrderRepair");

            migrationBuilder.DropTable(
                name: "WorkOrder");
        }
    }
}
