using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace YAZHXQ.Models.Models
{
    public partial class YAXQZHYYContext : DbContext
    {
        public YAXQZHYYContext()
        {
        }

        public YAXQZHYYContext(DbContextOptions<YAXQZHYYContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<ArchBorrowHistory> ArchBorrowHistory { get; set; }
        public virtual DbSet<ArchClass> ArchClass { get; set; }
        public virtual DbSet<ArchColumn> ArchColumn { get; set; }
        public virtual DbSet<ArchDisplay> ArchDisplay { get; set; }
        public virtual DbSet<ArchFile> ArchFile { get; set; }
        public virtual DbSet<ArchFileDataPrivate> ArchFileDataPrivate { get; set; }
        public virtual DbSet<ArchFileDataPublic> ArchFileDataPublic { get; set; }
        public virtual DbSet<ArchMenu> ArchMenu { get; set; }
        public virtual DbSet<ArchMenuClass> ArchMenuClass { get; set; }
        public virtual DbSet<ArchMenuColumn> ArchMenuColumn { get; set; }
        public virtual DbSet<ArchMenuDisplay> ArchMenuDisplay { get; set; }
        public virtual DbSet<ArchPrivate> ArchPrivate { get; set; }
        public virtual DbSet<ArchPublic> ArchPublic { get; set; }
        public virtual DbSet<ArchVirtual> ArchVirtual { get; set; }
        public virtual DbSet<BaseData> BaseData { get; set; }
        public virtual DbSet<Cable> Cable { get; set; }
        public virtual DbSet<Cnarea> Cnarea { get; set; }
        public virtual DbSet<Dbbackup> Dbbackup { get; set; }
        public virtual DbSet<DeptInfo> DeptInfo { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceOfBasis> DeviceOfBasis { get; set; }
        public virtual DbSet<FilePermission> FilePermission { get; set; }
        public virtual DbSet<FilesInfo> FilesInfo { get; set; }
        public virtual DbSet<FunAttribute> FunAttribute { get; set; }
        public virtual DbSet<FunctionInfo> FunctionInfo { get; set; }
        public virtual DbSet<FunMapService> FunMapService { get; set; }
        public virtual DbSet<FunPost> FunPost { get; set; }
        public virtual DbSet<FunRole> FunRole { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<HolidaySet> HolidaySet { get; set; }
        public virtual DbSet<InBox> InBox { get; set; }
        public virtual DbSet<Layer> Layer { get; set; }
        public virtual DbSet<LayerAttribute> LayerAttribute { get; set; }
        public virtual DbSet<LogInfo> LogInfo { get; set; }
        public virtual DbSet<MapPost> MapPost { get; set; }
        public virtual DbSet<MapRole> MapRole { get; set; }
        public virtual DbSet<MapService> MapService { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<ModelMenu> ModelMenu { get; set; }
        public virtual DbSet<ModelMenuPermission> ModelMenuPermission { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsTopic> NewsTopic { get; set; }
        public virtual DbSet<PostInfo> PostInfo { get; set; }
        public virtual DbSet<PostPermissions> PostPermissions { get; set; }
        public virtual DbSet<ProjectInfo> ProjectInfo { get; set; }
        public virtual DbSet<ProPlan> ProPlan { get; set; }
        public virtual DbSet<ProStakeholder> ProStakeholder { get; set; }
        public virtual DbSet<PunchClock> PunchClock { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<ReturnOrExchange> ReturnOrExchange { get; set; }
        public virtual DbSet<RoleInfo> RoleInfo { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<SceneFile> SceneFile { get; set; }
        public virtual DbSet<SceneMenu> SceneMenu { get; set; }
        public virtual DbSet<SpotBasis> SpotBasis { get; set; }
        public virtual DbSet<SpotFile> SpotFile { get; set; }
        public virtual DbSet<SpotMenu> SpotMenu { get; set; }
        public virtual DbSet<Spotting> Spotting { get; set; }
        public virtual DbSet<StaffDepts> StaffDepts { get; set; }
        public virtual DbSet<StaffInfo> StaffInfo { get; set; }
        public virtual DbSet<StaffPosts> StaffPosts { get; set; }
        public virtual DbSet<StaffRoles> StaffRoles { get; set; }
        public virtual DbSet<StockIn> StockIn { get; set; }
        public virtual DbSet<StockOut> StockOut { get; set; }
        public virtual DbSet<SupplierInfo> SupplierInfo { get; set; }
        public virtual DbSet<SupplierProject> SupplierProject { get; set; }
        public virtual DbSet<TbKnowledgeBase> TbKnowledgeBase { get; set; }
        public virtual DbSet<WorderArchivedRecords> WorderArchivedRecords { get; set; }
        public virtual DbSet<WorderFile> WorderFile { get; set; }
        public virtual DbSet<WorderRepair> WorderRepair { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }

        // Unable to generate entity type for table 'dbo.WOrderDistribute'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=192.168.10.25;Database=YAXQZHYY;User Id=sa;Password=123456");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountBook>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IncOrExpName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArchBorrowHistory>(entity =>
            {
                entity.HasIndex(e => e.ArchId)
                    .HasName("IX_ArchID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArchId).HasColumnName("ArchID");

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoStaffId).HasColumnName("DoStaffID");
            });

            modelBuilder.Entity<ArchClass>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArchColumn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ColText).HasMaxLength(200);

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ArchDisplay>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColId).HasColumnName("ColID");
            });

            modelBuilder.Entity<ArchFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.FileDataId).HasColumnName("FileDataID");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileUrl).HasMaxLength(300);

                entity.Property(e => e.HierarchyId).HasColumnName("HierarchyID");

                entity.Property(e => e.QcstaffId).HasColumnName("QCStaffID");
            });

            modelBuilder.Entity<ArchFileDataPrivate>(entity =>
            {
                entity.HasKey(e => new { e.FileDataId, e.ColId });

                entity.Property(e => e.FileDataId).HasColumnName("FileDataID");

                entity.Property(e => e.ColId).HasColumnName("ColID");

                entity.Property(e => e.ColText).HasMaxLength(200);
            });

            modelBuilder.Entity<ArchFileDataPublic>(entity =>
            {
                entity.HasKey(e => e.FileDataId);

                entity.Property(e => e.FileDataId).HasColumnName("FileDataID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Zldate)
                    .HasColumnName("ZLDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZlstaffId).HasColumnName("ZLStaffID");
            });

            modelBuilder.Entity<ArchMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ArchId).HasColumnName("ArchID");

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoStaffId).HasColumnName("DoStaffID");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(200);
            });

            modelBuilder.Entity<ArchMenuClass>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ArchMenuColumn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ColText).HasMaxLength(200);

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ArchMenuDisplay>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ArchPrivate>(entity =>
            {
                entity.HasKey(e => new { e.ArchId, e.ColId });

                entity.Property(e => e.ArchId).HasColumnName("ArchID");

                entity.Property(e => e.ColId).HasColumnName("ColID");

                entity.Property(e => e.ColText).HasMaxLength(200);
            });

            modelBuilder.Entity<ArchPublic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArchCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BorrowDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocketCode).HasMaxLength(100);

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.Shdate)
                    .HasColumnName("SHDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShstaffId).HasColumnName("SHStaffID");

                entity.Property(e => e.Sjdate)
                    .HasColumnName("SJDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SjstaffId).HasColumnName("SJStaffID");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Xnda).HasColumnName("XNDA");

                entity.Property(e => e.Zldate)
                    .HasColumnName("ZLDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZlstaffId).HasColumnName("ZLStaffID");
            });

            modelBuilder.Entity<ArchVirtual>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);
            });

            modelBuilder.Entity<BaseData>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataCode).HasMaxLength(20);

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Param).HasMaxLength(2000);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cnarea>(entity =>
            {
                entity.ToTable("CNArea");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(500);

                entity.Property(e => e.City1)
                    .HasColumnName("CITY1")
                    .HasMaxLength(500);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.District)
                    .HasColumnName("DISTRICT")
                    .HasMaxLength(500);

                entity.Property(e => e.District1)
                    .HasColumnName("DISTRICT1")
                    .HasMaxLength(500);

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.ParentCode)
                    .HasColumnName("PARENT_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentShortCode)
                    .HasColumnName("PARENT_SHORT_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasMaxLength(500);

                entity.Property(e => e.Province1)
                    .HasColumnName("PROVINCE1")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortCode)
                    .HasColumnName("SHORT_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Town)
                    .HasColumnName("TOWN")
                    .HasMaxLength(500);

                entity.Property(e => e.Town1)
                    .HasColumnName("TOWN1")
                    .HasMaxLength(500);

                entity.Property(e => e.Village)
                    .HasColumnName("VILLAGE")
                    .HasMaxLength(500);

                entity.Property(e => e.Village1)
                    .HasColumnName("VILLAGE1")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dbbackup>(entity =>
            {
                entity.ToTable("DBBackup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataBasePath).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeptInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasMaxLength(200);

                entity.Property(e => e.ManagerName).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrgCode).HasMaxLength(20);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Param).HasMaxLength(2000);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeviceOfBasis>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            });

            modelBuilder.Entity<FilePermission>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<FilesInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileDesc).HasMaxLength(500);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FunAttribute>(entity =>
            {
                entity.HasIndex(e => e.FunId)
                    .HasName("IX_FunID");

                entity.HasIndex(e => e.LayerAttrId)
                    .HasName("IX_LayerAttrID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FunId).HasColumnName("FunID");

                entity.Property(e => e.LayerAttrId).HasColumnName("LayerAttrID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FunctionInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FunMapService>(entity =>
            {
                entity.HasIndex(e => e.FunId)
                    .HasName("IX_FunID");

                entity.HasIndex(e => e.MapId)
                    .HasName("IX_MapID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FunId).HasColumnName("FunID");

                entity.Property(e => e.LayerIds).HasColumnName("LayerIDs");

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FunPost>(entity =>
            {
                entity.HasKey(e => new { e.Fid, e.PostId });

                entity.HasIndex(e => e.Fid)
                    .HasName("IX_FID");

                entity.HasIndex(e => e.PostId)
                    .HasName("IX_PostID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.PostId).HasColumnName("PostID");
            });

            modelBuilder.Entity<FunRole>(entity =>
            {
                entity.HasKey(e => new { e.Fid, e.RoleId });

                entity.HasIndex(e => e.Fid)
                    .HasName("IX_FID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Goods>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Inquantity).HasColumnName("INQuantity");

                entity.Property(e => e.ModelNumbers).HasMaxLength(100);

                entity.Property(e => e.Outquantity).HasColumnName("OUTQuantity");

                entity.Property(e => e.Parameter).HasMaxLength(100);

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.Supplier).HasMaxLength(100);

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HolidaySet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SetDay).HasColumnType("date");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InBox>(entity =>
            {
                entity.HasKey(e => new { e.MsgId, e.ReceiverId });

                entity.Property(e => e.MsgId).HasColumnName("MsgID");

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.DelTime).HasColumnType("datetime");

                entity.Property(e => e.ReadTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Layer>(entity =>
            {
                entity.HasIndex(e => e.MapId)
                    .HasName("IX_MapID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LayerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LayerAttribute>(entity =>
            {
                entity.HasIndex(e => e.LayersId)
                    .HasName("IX_LayersID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LayersId).HasColumnName("LayersID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.DeptName).HasMaxLength(200);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(25);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MapPost>(entity =>
            {
                entity.HasKey(e => new { e.Mid, e.PostId });

                entity.HasIndex(e => e.Mid)
                    .HasName("IX_MID");

                entity.HasIndex(e => e.PostId)
                    .HasName("IX_PostID");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.PostId).HasColumnName("PostID");
            });

            modelBuilder.Entity<MapRole>(entity =>
            {
                entity.HasKey(e => new { e.Mid, e.RoleId });

                entity.HasIndex(e => e.Mid)
                    .HasName("IX_MID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleID");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<MapService>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MapServiceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MapServiceUrl)
                    .IsRequired()
                    .HasColumnName("MapServiceURL")
                    .HasMaxLength(500);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

                entity.Property(e => e.DelTime).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ModelMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.TargetUrl)
                    .HasColumnName("TargetURL")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ModelMenuPermission>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AreaCode).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(20);

                entity.Property(e => e.ControllerCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author).HasMaxLength(20);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).HasMaxLength(50);

                entity.Property(e => e.PubDate).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(20);

                entity.Property(e => e.Summary).HasMaxLength(80);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<NewsTopic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PostInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Desc).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PostPermissions>(entity =>
            {
                entity.HasKey(e => new { e.Mpid, e.PostId });

                entity.Property(e => e.Mpid).HasColumnName("MPID");

                entity.Property(e => e.PostId).HasColumnName("PostID");
            });

            modelBuilder.Entity<ProjectInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptTime).HasColumnType("datetime");

                entity.Property(e => e.BuildCompany).HasMaxLength(50);

                entity.Property(e => e.BuildCompanyInfo).HasMaxLength(500);

                entity.Property(e => e.ConCompany).HasMaxLength(50);

                entity.Property(e => e.ConCompanyInfo).HasMaxLength(500);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GisobjId).HasColumnName("GISObjID");

                entity.Property(e => e.GisproType).HasColumnName("GISProType");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PfinshTime)
                    .HasColumnName("PFinshTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("PName")
                    .HasMaxLength(200);

                entity.Property(e => e.PstartTime)
                    .HasColumnName("PStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProPlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Hazard).HasMaxLength(500);

                entity.Property(e => e.Leader)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.Resource).HasMaxLength(500);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WorkFocus).HasMaxLength(500);

                entity.Property(e => e.WorkResults).HasMaxLength(500);

                entity.Property(e => e.WorkTask).HasMaxLength(500);
            });

            modelBuilder.Entity<ProStakeholder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.ProContent).HasMaxLength(200);

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PunchClock>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmendTime)
                    .HasColumnName("AMEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AmstartTime)
                    .HasColumnName("AMStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeDate).HasColumnType("datetime");

                entity.Property(e => e.MeId).HasMaxLength(20);

                entity.Property(e => e.MeName).HasMaxLength(30);

                entity.Property(e => e.PmendTime)
                    .HasColumnName("PMEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PmstartTime)
                    .HasColumnName("PMStartTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.CompletionTime).HasColumnType("datetime");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Heading)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Numbers).HasMaxLength(50);

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.Remake).HasMaxLength(200);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReturnOrExchange>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModelNumbers).HasMaxLength(100);

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.RelationNo)
                    .HasColumnName("RelationNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RetOrExNo)
                    .IsRequired()
                    .HasColumnName("RetOrExNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoleInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Desc).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.HasKey(e => new { e.Mpid, e.RoleId });

                entity.Property(e => e.Mpid).HasColumnName("MPID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<SceneFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoStaffId).HasColumnName("DoStaffID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FileUrl).HasMaxLength(300);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ProjTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SceneMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.MenuCode).HasMaxLength(200);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpotBasis>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualCubage).HasMaxLength(100);

                entity.Property(e => e.ActualSize).HasMaxLength(100);

                entity.Property(e => e.BasisCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BasisLocation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DesignCubage).HasMaxLength(100);

                entity.Property(e => e.DesignSize).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.SoilClass).HasMaxLength(100);

                entity.Property(e => e.SpotId).HasColumnName("SpotID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpotFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoStaffId).HasColumnName("DoStaffID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FileUrl).HasMaxLength(300);

                entity.Property(e => e.HierarchyId).HasColumnName("HierarchyID");

                entity.Property(e => e.SpotId).HasColumnName("SpotID");

                entity.Property(e => e.SpotMenuId).HasColumnName("SpotMenuID");
            });

            modelBuilder.Entity<SpotMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MenuCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SpotId).HasColumnName("SpotID");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Spotting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GissoptId).HasColumnName("GISSoptID");

                entity.Property(e => e.GissoptType).HasColumnName("GISSoptType");

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.SpotCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpotName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffDepts>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.StaffId });

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<StaffInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountPwd)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.ColledgeName).HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Email).HasMaxLength(320);

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Kqjno)
                    .HasColumnName("KQJNo")
                    .HasMaxLength(20);

                entity.Property(e => e.MarriageName).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NationalName).HasMaxLength(20);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OtherInfo).HasMaxLength(2000);

                entity.Property(e => e.PoliticalStatusName).HasMaxLength(50);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.ProfessionalName).HasMaxLength(20);

                entity.Property(e => e.SexName).HasMaxLength(10);

                entity.Property(e => e.StaffImg).HasMaxLength(50);

                entity.Property(e => e.StaffIp)
                    .HasColumnName("StaffIP")
                    .HasMaxLength(20);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffPosts>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.StaffId });

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<StaffRoles>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.StaffId });

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<StockIn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackNo)
                    .HasColumnName("BackNO")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModelNumbers).HasMaxLength(100);

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.PurNo)
                    .HasColumnName("PurNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WareNo)
                    .IsRequired()
                    .HasColumnName("WareNO")
                    .HasMaxLength(50);

                entity.Property(e => e.WareTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StockOut>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InNo)
                    .IsRequired()
                    .HasColumnName("InNO")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelNumbers).HasMaxLength(100);

                entity.Property(e => e.OutNo)
                    .IsRequired()
                    .HasColumnName("OutNO")
                    .HasMaxLength(50);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Using).HasMaxLength(100);
            });

            modelBuilder.Entity<SupplierInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(30);

                entity.Property(e => e.CompanyNature).HasMaxLength(50);

                entity.Property(e => e.CompanyTel).HasMaxLength(20);

                entity.Property(e => e.Contacts).HasMaxLength(20);

                entity.Property(e => e.Corporate).HasMaxLength(50);

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FaxNum).HasMaxLength(20);

                entity.Property(e => e.InvoiceAddr).HasMaxLength(100);

                entity.Property(e => e.InvoiceName).HasMaxLength(50);

                entity.Property(e => e.LinkTel).HasMaxLength(20);

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.RegAddr).HasMaxLength(100);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxId)
                    .HasColumnName("TAX_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupplierProject>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FirstTel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Goods).HasMaxLength(50);

                entity.Property(e => e.JointTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.SecondName).HasMaxLength(50);

                entity.Property(e => e.SecondTel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbKnowledgeBase>(entity =>
            {
                entity.ToTable("tb_KnowledgeBase");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachmentName).HasMaxLength(50);

                entity.Property(e => e.AttachmentUrl).HasMaxLength(100);

                entity.Property(e => e.Classfy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SharedBy).HasMaxLength(30);

                entity.Property(e => e.SharedByName).HasMaxLength(50);

                entity.Property(e => e.SharedTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorderArchivedRecords>(entity =>
            {
                entity.ToTable("WOrderArchivedRecords");

                entity.HasIndex(e => e.CreateStaffId)
                    .HasName("IX_CreateStaffID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<WorderFile>(entity =>
            {
                entity.ToTable("WOrderFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FileUrl).HasMaxLength(300);

                entity.Property(e => e.ProjTime).HasColumnType("datetime");

                entity.Property(e => e.WorderFileType).HasColumnName("WOrderFileType");

                entity.Property(e => e.WorderId).HasColumnName("WOrderID");
            });

            modelBuilder.Entity<WorderRepair>(entity =>
            {
                entity.ToTable("WOrderRepair");

                entity.HasIndex(e => e.CreateStaffId)
                    .HasName("IX_CreateStaffID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RepairContent)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RepairCost)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RepairVehicle)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasIndex(e => e.CreateStaffId)
                    .HasName("IX_CreateStaffID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateStaffId).HasColumnName("CreateStaffID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DescOfError)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Intersection)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.UpdateStaffId).HasColumnName("UpdateStaffID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });
        }

        /// <summary>
        /// 重写SaveChanges
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            return base.SaveChanges(true);
        }
    }
}
