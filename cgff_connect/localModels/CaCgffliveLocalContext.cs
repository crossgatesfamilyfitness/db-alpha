using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cgff_connect.localModels;

public partial class CaCgffliveLocalContext : DbContext
{
    public CaCgffliveLocalContext()
    {
    }

    public CaCgffliveLocalContext(DbContextOptions<CaCgffliveLocalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountingGroup> AccountingGroups { get; set; }

    public virtual DbSet<AccountingGroupItem> AccountingGroupItems { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AnnouncementEntity> AnnouncementEntities { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<BatchConfigure> BatchConfigures { get; set; }

    public virtual DbSet<BillingGroup> BillingGroups { get; set; }

    public virtual DbSet<CaMenu> CaMenus { get; set; }

    public virtual DbSet<CaMenuItem> CaMenuItems { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<CcType> CcTypes { get; set; }

    public virtual DbSet<Charge> Charges { get; set; }

    public virtual DbSet<ChargeDeposit> ChargeDeposits { get; set; }

    public virtual DbSet<ChargeDiscount> ChargeDiscounts { get; set; }

    public virtual DbSet<Check> Checks { get; set; }

    public virtual DbSet<Checkin> Checkins { get; set; }

    public virtual DbSet<CheckinError> CheckinErrors { get; set; }

    public virtual DbSet<ChildcareGuardianLocation> ChildcareGuardianLocations { get; set; }

    public virtual DbSet<ChildcareSchedule> ChildcareSchedules { get; set; }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractTerm> ContractTerms { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<EndOfDay> EndOfDays { get; set; }

    public virtual DbSet<Errorlog> Errorlogs { get; set; }

    public virtual DbSet<ExternalPosLocation> ExternalPosLocations { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupHoldReason> GroupHoldReasons { get; set; }

    public virtual DbSet<GroupType> GroupTypes { get; set; }

    public virtual DbSet<Guardian> Guardians { get; set; }

    public virtual DbSet<HistoricalTransaction> HistoricalTransactions { get; set; }

    public virtual DbSet<KitchenOrder> KitchenOrders { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<MembershipCancellationReason> MembershipCancellationReasons { get; set; }

    public virtual DbSet<MembershipType> MembershipTypes { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<NoteSubject> NoteSubjects { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }

    public virtual DbSet<PaymentTransfer> PaymentTransfers { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<PhoneStatus> PhoneStatuses { get; set; }

    public virtual DbSet<Po> Pos { get; set; }

    public virtual DbSet<ProspectTask> ProspectTasks { get; set; }

    public virtual DbSet<ProspectUserAssignment> ProspectUserAssignments { get; set; }

    public virtual DbSet<ProspectUserTask> ProspectUserTasks { get; set; }

    public virtual DbSet<Refund> Refunds { get; set; }

    public virtual DbSet<ReportsShopInventoryHistory> ReportsShopInventoryHistories { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<ResourceSchedule> ResourceSchedules { get; set; }

    public virtual DbSet<RevenueRecognition> RevenueRecognitions { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleReserve> ScheduleReserves { get; set; }

    public virtual DbSet<ScheduleResource> ScheduleResources { get; set; }

    public virtual DbSet<ShopCategory> ShopCategories { get; set; }

    public virtual DbSet<ShopInventoryHistory> ShopInventoryHistories { get; set; }

    public virtual DbSet<ShopItem> ShopItems { get; set; }

    public virtual DbSet<ShopItemAdjustmentReason> ShopItemAdjustmentReasons { get; set; }

    public virtual DbSet<ShopItemBarcode> ShopItemBarcodes { get; set; }

    public virtual DbSet<ShopItemManufacturer> ShopItemManufacturers { get; set; }

    public virtual DbSet<ShopItemStore> ShopItemStores { get; set; }

    public virtual DbSet<ShopStore> ShopStores { get; set; }

    public virtual DbSet<ShopVendor> ShopVendors { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Tbatch> Tbatches { get; set; }

    public virtual DbSet<TbatchTransaction> TbatchTransactions { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<Transactionlog> Transactionlogs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserArchive> UserArchives { get; set; }

    public virtual DbSet<UserBalance> UserBalances { get; set; }

    public virtual DbSet<UserCustomField> UserCustomFields { get; set; }

    public virtual DbSet<UserCustomFieldsValue> UserCustomFieldsValues { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserGroupHistory> UserGroupHistories { get; set; }

    public virtual DbSet<UserLoginAttempt> UserLoginAttempts { get; set; }

    public virtual DbSet<UserLoginLock> UserLoginLocks { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserStatementPastDue> UserStatementPastDues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql(Connect.ConnectToLocal(), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.1.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AccountingGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("accounting_group")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ComponentId, "component_id");

            entity.HasIndex(e => e.IsInvisible, "is_invisible");

            entity.HasIndex(e => e.Name, "name").IsUnique();

            entity.HasIndex(e => e.NoCustomCharge, "no_custom_charge");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.HasIndex(e => e.TaxRateId, "tax_rate_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acctype)
                .HasDefaultValueSql("'1'")
                .HasColumnName("acctype");
            entity.Property(e => e.BuiltIn).HasColumnName("built_in");
            entity.Property(e => e.CanAddSoldBy).HasColumnName("can_add_sold_by");
            entity.Property(e => e.CogsAcct).HasColumnName("cogs_acct");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.Discountable).HasColumnName("discountable");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.ExpRecognition)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("exp_recognition");
            entity.Property(e => e.GlCode)
                .HasColumnType("text")
                .HasColumnName("gl_code");
            entity.Property(e => e.HideInFilter).HasColumnName("hide_in_filter");
            entity.Property(e => e.InvisibleForPos).HasColumnName("invisible_for_pos");
            entity.Property(e => e.IsDescription).HasColumnName("is_description");
            entity.Property(e => e.IsDisabled).HasColumnName("is_disabled");
            entity.Property(e => e.IsInvisible).HasColumnName("is_invisible");
            entity.Property(e => e.IsUnavailable).HasColumnName("is_unavailable");
            entity.Property(e => e.LiabilityType).HasColumnName("liability_type");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.NoCustomCharge).HasColumnName("no_custom_charge");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.QbInventory).HasColumnName("qb_inventory");
            entity.Property(e => e.RevenueAcct).HasColumnName("revenue_acct");
            entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            entity.Property(e => e.Taxable).HasColumnName("taxable");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.UseDescription)
                .HasMaxLength(250)
                .HasColumnName("use_description");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<AccountingGroupItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("accounting_group_items")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AccountingGroupId, "accounting_group_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("float(9,3)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("address")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.CountryId, "fk_address_country");

            entity.HasIndex(e => e.StateId, "fk_address_state");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.Latitude)
                .HasPrecision(11, 7)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(11, 7)
                .HasColumnName("longitude");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(40)
                .HasColumnName("postal_code");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
            entity.Property(e => e.Street2)
                .HasMaxLength(255)
                .HasColumnName("street2");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_address_country");

            entity.HasOne(d => d.State).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_address_state");
        });

        modelBuilder.Entity<AnnouncementEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("announcement_entity")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AnnouncementId, "announcement_id");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnnouncementId).HasColumnName("announcement_id");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attendance")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Attendance1, "attendance");

            entity.HasIndex(e => e.ChargedNotAttended, "charged_not_attended");

            entity.HasIndex(e => e.ResourceId, "resource_id");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.HasIndex(e => e.Type, "type");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttendFrom)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("attend_from");
            entity.Property(e => e.AttendTo)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("attend_to");
            entity.Property(e => e.Attendance1)
                .HasDefaultValueSql("'attended'")
                .HasColumnType("enum('confirmed','unconfirmed','not attending','attended','not present','reserve','registered','waitlisted')")
                .HasColumnName("attendance");
            entity.Property(e => e.ChargedNotAttended).HasColumnName("charged_not_attended");
            entity.Property(e => e.ConfirmationExpiryDate)
                .HasColumnType("timestamp")
                .HasColumnName("confirmation_expiry_date");
            entity.Property(e => e.FromWaitlist).HasColumnName("from_waitlist");
            entity.Property(e => e.IsOnline).HasColumnName("is_online");
            entity.Property(e => e.IsWaitlistMail).HasColumnName("is_waitlist_mail");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MakeUpDate).HasColumnName("make_up_date");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'trainee'")
                .HasColumnType("enum('trainer','trainee')")
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BatchConfigure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("batch_configure");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdColumnName)
                .HasMaxLength(50)
                .HasColumnName("id_column_name");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .HasColumnName("table_name");
            entity.Property(e => e.UpdateColumnName)
                .HasMaxLength(100)
                .HasColumnName("update_column_name");
            entity.Property(e => e.UpdateFrequencyMinutes).HasColumnName("update_frequency_minutes");
        });

        modelBuilder.Entity<BillingGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("billing_group")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(9, 2)
                .HasColumnName("amount");
            entity.Property(e => e.AmountType)
                .HasDefaultValueSql("'$'")
                .HasColumnType("enum('$','%')")
                .HasColumnName("amount_type");
            entity.Property(e => e.BillToAccType).HasColumnName("bill_to_acc_type");
            entity.Property(e => e.BillToAccount).HasColumnName("bill_to_account");
            entity.Property(e => e.BillToType)
                .HasDefaultValueSql("'$'")
                .HasColumnType("enum('$','%')")
                .HasColumnName("bill_to_type");
            entity.Property(e => e.BillToValue)
                .HasPrecision(9, 2)
                .HasColumnName("bill_to_value");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.DiscountAsStatement).HasColumnName("discount_as_statement");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProrateOptions).HasColumnName("prorate_options");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<CaMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ca_menu")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.SystemName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("system_name");
        });

        modelBuilder.Entity<CaMenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ca_menu_item")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MenuId, "fk_ca_menu_item_ca_menu");

            entity.HasIndex(e => e.ParentId, "fk_ca_menu_item_ca_menu_item1");

            entity.HasIndex(e => e.SystemName, "system_name");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HtmlClass)
                .HasMaxLength(64)
                .HasColumnName("html_class");
            entity.Property(e => e.HtmlId)
                .HasMaxLength(64)
                .HasColumnName("html_id");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.SystemName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("system_name");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");

            entity.HasOne(d => d.Menu).WithMany(p => p.CaMenuItems)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ca_menu_item_ca_menu");
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("calendar")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefaultComponentId).HasColumnName("default_component_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("enum('0','1')")
                .HasColumnName("status");
            entity.Property(e => e.System)
                .HasDefaultValueSql("'0'")
                .HasColumnType("enum('0','1')")
                .HasColumnName("system");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<CcType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cc_types")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Charge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charge")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AccountingGroupId, "accounting_group_id");

            entity.HasIndex(e => e.BillDate, "bill_date");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.EftId, "eft_id");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => new { e.EntityId, e.IsPosted, e.InvoiceDate }, "entity_posted_date");

            entity.HasIndex(e => e.EventDate, "event_date");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.EventStatus, "event_status");

            entity.HasIndex(e => e.ForeignId, "foreign_id");

            entity.HasIndex(e => e.InvoiceDate, "invoice_date");

            entity.HasIndex(e => e.IsOnline, "is_online");

            entity.HasIndex(e => e.IsPosted, "is_posted");

            entity.HasIndex(e => e.ItemId, "item_id");

            entity.HasIndex(e => e.Mode, "mode");

            entity.HasIndex(e => e.OriginalPrice, "original_price");

            entity.HasIndex(e => e.PosId, "pos_id");

            entity.HasIndex(e => e.PostedDate, "posted_date");

            entity.HasIndex(e => e.ReportDate, "report_date");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.HasIndex(e => new { e.ScheduleId, e.SubjectId, e.Mode }, "schedule_subject_mode");

            entity.HasIndex(e => e.ShiftId, "shift_id");

            entity.HasIndex(e => e.SoldBy, "sold_by");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => e.SubjectId, "subject_id");

            entity.HasIndex(e => e.UserFor, "user_for");

            entity.HasIndex(e => e.UserHomeClub, "user_home_club");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => e.Vendor, "vendor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.BillDate)
                .HasComment("Data when charge was created, immutable")
                .HasColumnType("datetime")
                .HasColumnName("bill_date");
            entity.Property(e => e.CancellationCharge).HasColumnName("cancellation_charge");
            entity.Property(e => e.CancellationDate)
                .HasColumnType("datetime")
                .HasColumnName("cancellation_date");
            entity.Property(e => e.ClubTaxRate)
                .HasPrecision(9, 4)
                .HasColumnName("club_tax_rate");
            entity.Property(e => e.CostFinal)
                .HasPrecision(12, 2)
                .HasColumnName("cost_final");
            entity.Property(e => e.CostPerUnit)
                .HasPrecision(12, 2)
                .HasColumnName("cost_per_unit");
            entity.Property(e => e.Count)
                .HasPrecision(9, 2)
                .HasColumnName("count");
            entity.Property(e => e.CustomDescription)
                .HasColumnType("text")
                .HasColumnName("custom_description");
            entity.Property(e => e.CustomTime)
                .HasColumnType("datetime")
                .HasColumnName("custom_time");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateUpdated)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("date_updated");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DescriptionDate)
                .HasColumnType("datetime")
                .HasColumnName("description_date");
            entity.Property(e => e.Discount)
                .HasPrecision(12, 2)
                .HasColumnName("discount");
            entity.Property(e => e.DiscountRate)
                .HasPrecision(9, 5)
                .HasColumnName("discount_rate");
            entity.Property(e => e.EftAmount)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("eft_amount");
            entity.Property(e => e.EftId).HasColumnName("eft_id");
            entity.Property(e => e.EntityId)
                .HasComment("club id taken from accounting group id")
                .HasColumnName("entity_id");
            entity.Property(e => e.EventDate).HasColumnName("event_date");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.EventStatus).HasColumnName("event_status");
            entity.Property(e => e.ExportToQb).HasColumnName("export_to_qb");
            entity.Property(e => e.Finalized).HasColumnName("finalized");
            entity.Property(e => e.ForeignId)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("foreign_id");
            entity.Property(e => e.ForeignText)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("foreign_text");
            entity.Property(e => e.Hide).HasColumnName("hide");
            entity.Property(e => e.InvoiceDate).HasColumnName("invoice_date");
            entity.Property(e => e.InvoiceTime)
                .HasColumnType("datetime")
                .HasColumnName("invoice_time");
            entity.Property(e => e.IsAutomatic)
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_automatic");
            entity.Property(e => e.IsOnline).HasColumnName("is_online");
            entity.Property(e => e.IsPosted).HasColumnName("is_posted");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(32)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("item_id");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.Mode)
                .HasDefaultValueSql("'1'")
                .HasColumnName("mode");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.OriginalDescription)
                .HasColumnType("text")
                .HasColumnName("original_description");
            entity.Property(e => e.OriginalPrice)
                .HasPrecision(12, 2)
                .HasComment("Price when charge was created, immutable")
                .HasColumnName("original_price");
            entity.Property(e => e.PaidOff).HasColumnName("paid_off");
            entity.Property(e => e.PlayerNum).HasColumnName("player_num");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PostedDate).HasColumnName("posted_date");
            entity.Property(e => e.PriceFinal)
                .HasPrecision(12, 2)
                .HasColumnName("price_final");
            entity.Property(e => e.PricePerUnit)
                .HasPrecision(12, 2)
                .HasColumnName("price_per_unit");
            entity.Property(e => e.RefundHistory)
                .HasColumnType("text")
                .HasColumnName("refund_history");
            entity.Property(e => e.Removable).HasColumnName("removable");
            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.ReturnedCount)
                .HasPrecision(13, 6)
                .HasColumnName("returned_count");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.SoldBy).HasColumnName("sold_by");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'unpayed'")
                .HasColumnType("enum('unpayed','payed','voided','refunded','sold')")
                .HasColumnName("status");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.Tax)
                .HasPrecision(9, 3)
                .HasDefaultValueSql("'0.000'")
                .HasColumnName("tax");
            entity.Property(e => e.TaxRate)
                .HasPrecision(9, 4)
                .HasColumnName("tax_rate");
            entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            entity.Property(e => e.TotalPaid)
                .HasPrecision(12, 2)
                .HasColumnName("total_paid");
            entity.Property(e => e.TotalReversed)
                .HasPrecision(12, 2)
                .HasColumnName("total_reversed");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'usage'")
                .HasColumnType("enum('usage','instruction','organization','membership')")
                .HasColumnName("type");
            entity.Property(e => e.Unreal).HasColumnName("unreal");
            entity.Property(e => e.Used).HasColumnName("used");
            entity.Property(e => e.UserFor).HasColumnName("user_for");
            entity.Property(e => e.UserHomeClub)
                .HasComment("club id taken from user profile")
                .HasColumnName("user_home_club");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Vendor).HasColumnName("vendor");
        });

        modelBuilder.Entity<ChargeDeposit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charge_deposit")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccGroupId).HasColumnName("acc_group_id");
            entity.Property(e => e.Amount)
                .HasColumnType("float(9,3)")
                .HasColumnName("amount");
            entity.Property(e => e.ChargeId).HasColumnName("charge_id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DepositChargeId).HasColumnName("deposit_charge_id");
            entity.Property(e => e.DepositCreditPaymentId).HasColumnName("deposit_credit_payment_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.IsRemoved).HasColumnName("is_removed");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ChargeDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charge_discount")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ChargeId, "charge_Id");

            entity.HasIndex(e => e.DiscountId, "discount_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 4)
                .HasColumnName("amount");
            entity.Property(e => e.ChargeId).HasColumnName("charge_id");
            entity.Property(e => e.DiscountId).HasColumnName("discount_id");
            entity.Property(e => e.DiscountType)
                .HasDefaultValueSql("'$'")
                .HasColumnType("enum('$','%')")
                .HasColumnName("discount_type");
            entity.Property(e => e.DiscountValue)
                .HasPrecision(10, 4)
                .HasColumnName("discount_value");
            entity.Property(e => e.RowType)
                .HasDefaultValueSql("'1'")
                .HasColumnName("row_type");
        });

        modelBuilder.Entity<Check>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("check")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AddressId, "address_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Amount)
                .HasPrecision(12, 2)
                .HasColumnName("amount");
            entity.Property(e => e.CheckDate).HasColumnName("check_date");
            entity.Property(e => e.CheckNumber)
                .HasMaxLength(200)
                .HasColumnName("check_number");
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .HasColumnName("city");
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(200)
                .HasColumnName("drivers_license");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(200)
                .HasColumnName("phone_number");
            entity.Property(e => e.State)
                .HasMaxLength(200)
                .HasColumnName("state");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(200)
                .HasColumnName("street_address");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("zip");

            entity.HasOne(d => d.Address).WithMany(p => p.Checks)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_address_id_check");
        });

        modelBuilder.Entity<Checkin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("checkin")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Blocked, "blocked");

            entity.HasIndex(e => e.BlockedDate, "blocked_date");

            entity.HasIndex(e => e.CaacDoorId, "caac_door_id");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => e.In, "in");

            entity.HasIndex(e => e.LocationId, "location_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.BlockedDate).HasColumnName("blocked_date");
            entity.Property(e => e.BlockedTime)
                .HasColumnType("datetime")
                .HasColumnName("blocked_time");
            entity.Property(e => e.CaacDoorId).HasColumnName("caac_door_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Denied)
                .HasComment("0 or 1. Based on checkin errors")
                .HasColumnName("denied");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.In)
                .HasColumnType("datetime")
                .HasColumnName("in");
            entity.Property(e => e.LocationId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("location_id");
            entity.Property(e => e.Out)
                .HasColumnType("datetime")
                .HasColumnName("out");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<CheckinError>(entity =>
        {
            entity.HasKey(e => new { e.CheckinId, e.ErrorType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("checkin_error")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.CheckinId).HasColumnName("checkin_id");
            entity.Property(e => e.ErrorType).HasColumnName("error_type");
        });

        modelBuilder.Entity<ChildcareGuardianLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("childcare_guardian_location")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ChildcareSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("childcare_schedule")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CancellationBy).HasColumnName("cancellation_by");
            entity.Property(e => e.CancellationDatetime)
                .HasColumnType("datetime")
                .HasColumnName("cancellation_datetime");
            entity.Property(e => e.DependentLevel).HasColumnName("dependent_level");
            entity.Property(e => e.DropoffGuardianId).HasColumnName("dropoff_guardian_id");
            entity.Property(e => e.DropoffStaffId).HasColumnName("dropoff_staff_id");
            entity.Property(e => e.GuardianLocation).HasColumnName("guardian_location");
            entity.Property(e => e.OnlineReservation).HasColumnName("online_reservation");
            entity.Property(e => e.PickupGuardianId).HasColumnName("pickup_guardian_id");
            entity.Property(e => e.PickupStaffId).HasColumnName("pickup_staff_id");
            entity.Property(e => e.ReservationDatetime)
                .HasColumnType("datetime")
                .HasColumnName("reservation_datetime");
            entity.Property(e => e.ReservationTimeIn)
                .HasColumnType("time")
                .HasColumnName("reservation_time_in");
            entity.Property(e => e.ReservationTimeOut)
                .HasColumnType("time")
                .HasColumnName("reservation_time_out");
            entity.Property(e => e.ReservedBy).HasColumnName("reserved_by");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'reserve'")
                .HasColumnType("enum('reserve','dropoff','pickup','overdue','canceled')")
                .HasColumnName("status");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("content")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Title, "title").HasAnnotation("MySql:IndexPrefixLength", new[] { 15 });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Frontpage).HasColumnName("frontpage");
            entity.Property(e => e.Fulltext)
                .HasColumnType("text")
                .HasColumnName("fulltext");
            entity.Property(e => e.Introtext)
                .HasColumnType("text")
                .HasColumnName("introtext");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PreviewImage)
                .HasMaxLength(1000)
                .HasColumnName("preview_image");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("contract")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ContractTermsId, "contract_terms_id");

            entity.HasIndex(e => e.Enabled, "enabled");

            entity.HasIndex(e => e.EndDate, "end_Date");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.IsQueue, "is_queue");

            entity.HasIndex(e => e.StartDate, "start_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "user_id_group_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveMonths).HasColumnName("active_months");
            entity.Property(e => e.AuditStatus)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("audit_status");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.ContractFee)
                .HasColumnType("float(18,2)")
                .HasColumnName("contract_fee");
            entity.Property(e => e.ContractTermsId).HasColumnName("contract_terms_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("end_date");
            entity.Property(e => e.EnrollmentFee)
                .HasPrecision(12, 2)
                .HasColumnName("enrollment_fee");
            entity.Property(e => e.Expired).HasColumnName("expired");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.IsQueue).HasColumnName("is_queue");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MonthCount).HasColumnName("month_count");
            entity.Property(e => e.OriginalFee)
                .HasColumnType("float(18,2)")
                .HasColumnName("original_fee");
            entity.Property(e => e.RenewalOption).HasColumnName("renewal_option");
            entity.Property(e => e.RenewalTerm).HasColumnName("renewal_term");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
            entity.Property(e => e.VersionType)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("version_type");

            entity.HasOne(d => d.ContractTerms).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ContractTermsId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_contract_contract_terms_id");
        });

        modelBuilder.Entity<ContractTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("contract_terms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasDefaultValueSql("'membership'")
                .HasColumnType("enum('general','membership','package','add-on','corporate','eft-billing','cancel','event')")
                .HasColumnName("category");
            entity.Property(e => e.EftAuth)
                .HasColumnType("text")
                .HasColumnName("eft_auth");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.TermsConditions)
                .HasColumnType("text")
                .HasColumnName("terms_conditions");
            entity.Property(e => e.WaiverRelease)
                .HasColumnType("text")
                .HasColumnName("waiver_release");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("country")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Alpha2, "ix_alpha2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alpha2)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("alpha2");
            entity.Property(e => e.Alpha3)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("alpha3");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Numeric).HasColumnName("numeric");
            entity.Property(e => e.ShortName)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("short_name");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("discount")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Barcode, "barcode").HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("float(18,2)")
                .HasColumnName("amount");
            entity.Property(e => e.Barcode)
                .HasMaxLength(32)
                .HasColumnName("barcode");
            entity.Property(e => e.Descripiton)
                .HasColumnType("text")
                .HasColumnName("descripiton");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'enabled'")
                .HasColumnType("enum('enabled','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'1'")
                .HasColumnName("type");
        });

        modelBuilder.Entity<EndOfDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("end_of_day")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.PosId, "pos_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cash)
                .HasColumnType("float(18,2)")
                .HasColumnName("cash");
            entity.Property(e => e.Check)
                .HasColumnType("float(18,2)")
                .HasColumnName("check");
            entity.Property(e => e.ClosedBy).HasColumnName("closed_by");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DateClosed)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("date_closed");
            entity.Property(e => e.OpenedBy).HasColumnName("opened_by");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TimeClosed)
                .HasDefaultValueSql("'23:59:59'")
                .HasColumnType("time")
                .HasColumnName("time_closed");
            entity.Property(e => e.TimeOpened)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("time_opened");
        });

        modelBuilder.Entity<Errorlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("errorlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(640)
                .HasDefaultValueSql("'0'")
                .HasColumnName("comment");
            entity.Property(e => e.Description)
                .HasMaxLength(640)
                .HasDefaultValueSql("'0'")
                .HasColumnName("description");
            entity.Property(e => e.SqlStatement)
                .HasMaxLength(10000)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sql_statement");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'")
                .HasColumnName("table_name");
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("time_stamp");
        });

        modelBuilder.Entity<ExternalPosLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("external_pos_location")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("prefix");
            entity.Property(e => e.TaxAccountingGroupId).HasColumnName("tax_accounting_group_id");
            entity.Property(e => e.TaxDescription)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_description");
            entity.Property(e => e.TaxPrefix)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("tax_prefix");
            entity.Property(e => e.TipAccountingGroupId).HasColumnName("tip_accounting_group_id");
            entity.Property(e => e.TipDescription)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("tip_description");
            entity.Property(e => e.TipPrefix)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("tip_prefix");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AddonType, "addon_type");

            entity.HasIndex(e => e.ComponentId, "component_id");

            entity.HasIndex(e => e.ContractTermsId, "contract_terms_id");

            entity.HasIndex(e => e.GroupType, "group_type");

            entity.HasIndex(e => e.IsOnlineRegistration, "is_online_registration");

            entity.HasIndex(e => e.MemberFeeType, "member_fee_type");

            entity.HasIndex(e => e.MembershipTypeId, "membership_type_id");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.HasIndex(e => e.ShowOnCheckin, "show_on_checkin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddonType)
                .HasDefaultValueSql("'Custom'")
                .HasColumnType("enum('Custom','Discount Program','Resource')")
                .HasColumnName("addon_type");
            entity.Property(e => e.AllowFeeProration)
                .HasDefaultValueSql("'1'")
                .HasColumnName("allow_fee_proration");
            entity.Property(e => e.AnnualMaintenanceFee).HasColumnName("annual_maintenance_fee");
            entity.Property(e => e.AutoCancel).HasColumnName("auto_cancel");
            entity.Property(e => e.AutoEnroll).HasColumnName("auto_enroll");
            entity.Property(e => e.AutoRenew).HasColumnName("auto_renew");
            entity.Property(e => e.AutomaticApproval).HasColumnName("automatic_approval");
            entity.Property(e => e.AvailableForOnlineSale).HasColumnName("available_for_online_sale");
            entity.Property(e => e.AvailableForSale).HasColumnName("available_for_sale");
            entity.Property(e => e.AvailableOnStaffSchedule).HasColumnName("available_on_staff_schedule");
            entity.Property(e => e.BillGuestFee).HasColumnName("bill_guest_fee");
            entity.Property(e => e.BillingDay).HasColumnName("billing_day");
            entity.Property(e => e.BillingType)
                .HasDefaultValueSql("'recurring'")
                .HasColumnType("enum('recurring','pif')")
                .HasColumnName("billing_type");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.ContractAgreementTerm)
                .HasDefaultValueSql("'12'")
                .HasColumnName("contract_agreement_term");
            entity.Property(e => e.ContractEnabled).HasColumnName("contract_enabled");
            entity.Property(e => e.ContractLockRate).HasColumnName("contract_lock_rate");
            entity.Property(e => e.ContractRenewalOption)
                .HasDefaultValueSql("'1'")
                .HasColumnName("contract_renewal_option");
            entity.Property(e => e.ContractRenewalTerm).HasColumnName("contract_renewal_term");
            entity.Property(e => e.ContractTermsId).HasColumnName("contract_terms_id");
            entity.Property(e => e.CustomPeriod).HasColumnName("custom_period");
            entity.Property(e => e.CycleDuration)
                .HasDefaultValueSql("'1'")
                .HasColumnName("cycle_duration");
            entity.Property(e => e.CycleType)
                .HasColumnType("enum('day','week','month')")
                .HasColumnName("cycle_type");
            entity.Property(e => e.DeferredRevenue).HasColumnName("deferred_revenue");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOnProfile)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("display_on_profile");
            entity.Property(e => e.DisplayOnSignin).HasColumnName("display_on_signin");
            entity.Property(e => e.DurationType)
                .HasDefaultValueSql("'month'")
                .HasColumnType("enum('month','week','day')")
                .HasColumnName("duration_type");
            entity.Property(e => e.DurationValue).HasColumnName("duration_value");
            entity.Property(e => e.EndDate)
                .HasMaxLength(5)
                .HasDefaultValueSql("'00-00'")
                .IsFixedLength()
                .HasColumnName("end_date");
            entity.Property(e => e.EnrollmentFee)
                .HasColumnType("float(18,2)")
                .HasColumnName("enrollment_fee");
            entity.Property(e => e.FamilyType)
                .HasColumnType("enum('individual','individual_dependents','couple','family')")
                .HasColumnName("family_type");
            entity.Property(e => e.GroupType)
                .HasDefaultValueSql("'1'")
                .HasColumnName("group_type");
            entity.Property(e => e.HasAdditionalCharges).HasColumnName("has_additional_charges");
            entity.Property(e => e.HoldType)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("hold_type");
            entity.Property(e => e.HoldValue)
                .HasColumnType("float(9,2)")
                .HasColumnName("hold_value");
            entity.Property(e => e.IsFamily).HasColumnName("is_family");
            entity.Property(e => e.IsOnlineRegistration).HasColumnName("is_online_registration");
            entity.Property(e => e.IsResource).HasColumnName("is_resource");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.MaxDependents)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("max_dependents");
            entity.Property(e => e.MemberFee)
                .HasColumnType("float(18,2)")
                .HasColumnName("member_fee");
            entity.Property(e => e.MemberFeeType)
                .HasDefaultValueSql("'monthly'")
                .HasColumnType("enum('monthly','custom','annual','cmonthly','trial')")
                .HasColumnName("member_fee_type");
            entity.Property(e => e.MembershipTypeId).HasColumnName("membership_type_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NoGuestFee)
                .HasDefaultValueSql("'0'")
                .HasColumnName("no_guest_fee");
            entity.Property(e => e.NoGuestFeeChild)
                .HasDefaultValueSql("'0'")
                .HasColumnName("no_guest_fee_child");
            entity.Property(e => e.OnlineDescription)
                .HasColumnType("mediumtext")
                .HasColumnName("online_description");
            entity.Property(e => e.OnlineMembershipProration).HasColumnName("online_membership_proration");
            entity.Property(e => e.PAmount)
                .HasColumnType("float(18,2)")
                .HasColumnName("p_amount");
            entity.Property(e => e.PBillingDateDay)
                .HasDefaultValueSql("'1'")
                .HasColumnName("p_billing_date_day");
            entity.Property(e => e.PBillingDateMonth)
                .HasDefaultValueSql("'1'")
                .HasColumnName("p_billing_date_month");
            entity.Property(e => e.PBillingMonth).HasColumnName("p_billing_month");
            entity.Property(e => e.PBillingType)
                .HasDefaultValueSql("'month'")
                .HasColumnType("enum('date','month')")
                .HasColumnName("p_billing_type");
            entity.Property(e => e.PDescription)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("p_description");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.PayNow).HasColumnName("pay_now");
            entity.Property(e => e.PaymentRequired).HasColumnName("payment_required");
            entity.Property(e => e.PosAvailable).HasColumnName("pos_available");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.ProrateLastMonth).HasColumnName("prorate_last_month");
            entity.Property(e => e.RenewBefore).HasColumnName("renew_before");
            entity.Property(e => e.ResourceName)
                .HasMaxLength(255)
                .HasColumnName("resource_name");
            entity.Property(e => e.RevenueMapping)
                .HasDefaultValueSql("'by_home_club'")
                .HasColumnType("enum('by_home_club','by_location_of_sale')")
                .HasColumnName("revenue_mapping");
            entity.Property(e => e.SalesEndDate).HasColumnName("sales_end_date");
            entity.Property(e => e.SalesStartDate).HasColumnName("sales_start_date");
            entity.Property(e => e.ScheduleShow).HasColumnName("schedule_show");
            entity.Property(e => e.ShowOnCheckin).HasColumnName("show_on_checkin");
            entity.Property(e => e.ShowOnMembership).HasColumnName("show_on_membership");
            entity.Property(e => e.ShowOnProspect).HasColumnName("show_on_prospect");
            entity.Property(e => e.StartDate)
                .HasMaxLength(5)
                .HasDefaultValueSql("'00-00'")
                .IsFixedLength()
                .HasColumnName("start_date");
            entity.Property(e => e.StatementDescription)
                .HasMaxLength(255)
                .HasColumnName("statement_description");
            entity.Property(e => e.SysName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sys_name");
            entity.Property(e => e.System).HasColumnName("system");
            entity.Property(e => e.SystemType)
                .HasDefaultValueSql("'base'")
                .HasColumnType("enum('base','non_member','member','staff','front_desc','admin','global_admin','guest','addon','manager','time_clock','check_in','prospect','external_pos','membership_sales','api_staff')")
                .HasColumnName("system_type");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'system'")
                .HasColumnType("enum('system','membership','addon','guest','staff','prospect')")
                .HasColumnName("type");
            entity.Property(e => e.UseNonmemberFee).HasColumnName("use_nonmember_fee");
            entity.Property(e => e.UseSaleSpecificDate).HasColumnName("use_sale_specific_date");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");

            entity.HasOne(d => d.ContractTerms).WithMany(p => p.Groups)
                .HasForeignKey(d => d.ContractTermsId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_group_contract_terms_id");

            entity.HasOne(d => d.MembershipType).WithMany(p => p.Groups)
                .HasForeignKey(d => d.MembershipTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_membership_type_id");
        });

        modelBuilder.Entity<GroupHoldReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_hold_reason")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("reason");
        });

        modelBuilder.Entity<GroupType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Guardian>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("guardian")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.GuardianId, e.ChildId }, "guardian_id_child_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildId).HasColumnName("child_id");
            entity.Property(e => e.GuardianId).HasColumnName("guardian_id");
        });

        modelBuilder.Entity<HistoricalTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("historical_transactions")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("date");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<KitchenOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("kitchen_order")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Timestamp, "timestamp");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Delivery)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("delivery");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("timestamp")
                .HasColumnName("last_updated");
            entity.Property(e => e.OrderNotes)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("order_notes");
            entity.Property(e => e.Pickup).HasColumnName("pickup");
            entity.Property(e => e.StaffMemberId).HasColumnName("staff_member_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'ACTIVE'")
                .HasColumnType("enum('ACTIVE','STARTED','STAGED','DELIVERED')")
                .HasColumnName("status");
            entity.Property(e => e.TableNumber).HasColumnName("table_number");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("membership")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DateFrom, "date_from");

            entity.HasIndex(e => e.DateTo, "date_to");

            entity.HasIndex(e => e.PrimaryId, "primary_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateFrom).HasColumnName("date_from");
            entity.Property(e => e.DateTo).HasColumnName("date_to");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.HoldDate).HasColumnName("hold_date");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.ParentMembershipId).HasColumnName("parent_membership_id");
            entity.Property(e => e.Price)
                .HasColumnType("float(18,2)")
                .HasColumnName("price");
            entity.Property(e => e.PrimaryId).HasColumnName("primary_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'unpaid'")
                .HasColumnType("enum('unpaid','paid','canceled')")
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<MembershipCancellationReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("membership_cancellation_reasons")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("reason");
        });

        modelBuilder.Entity<MembershipType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("membership_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("note")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => new { e.Date, e.EventId }, "date");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.NoteSubjectId, "note_subject_id");

            entity.HasIndex(e => e.Private, "private");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.HasIndex(e => e.ShowAtCheckin, "show_at_checkin");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Dismissed).HasColumnName("dismissed");
            entity.Property(e => e.DismissedBy).HasColumnName("dismissed_by");
            entity.Property(e => e.Edited)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("edited");
            entity.Property(e => e.EditedBy).HasColumnName("edited_by");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.ExpirationDateOnCheckin).HasColumnName("expiration_date_on_checkin");
            entity.Property(e => e.Note1)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.NoteSubjectId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("note_subject_id");
            entity.Property(e => e.NoteSubjectText)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("note_subject_text");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.ShowAtCheckin).HasColumnName("show_at_checkin");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'profile'")
                .HasColumnType("enum('profile','payrolls','event','schedule','checkin','special_needs','equipment','store_vendor','prospect','item_manufacturer')")
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<NoteSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("note_subject")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("notification")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.HasChildren).HasColumnName("has_children");
            entity.Property(e => e.IsHidden).HasColumnName("is_hidden");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.PushSupport).HasColumnName("push_support");
            entity.Property(e => e.SmsSupport).HasColumnName("sms_support");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'99999'")
                .HasColumnName("sort");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payment")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AccGroupId, "acc_group_id");

            entity.HasIndex(e => e.CcTransactionId, "cc_transaction_id");

            entity.HasIndex(e => e.CertificateId, "certificate_id");

            entity.HasIndex(e => e.ChargeId, "charge_id");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.DateIndex, "date_index");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => new { e.EntityId, e.IsPosted, e.DateIndex }, "entity_posted_date");

            entity.HasIndex(e => e.EventDate, "event_date");

            entity.HasIndex(e => e.EventStatus, "event_status");

            entity.HasIndex(e => e.ForeignId, "foreign_id");

            entity.HasIndex(e => e.IsAdjustment, "is_adjustment");

            entity.HasIndex(e => e.IsEft, "is_eft");

            entity.HasIndex(e => e.IsOnline, "is_online");

            entity.HasIndex(e => e.IsPosted, "is_posted");

            entity.HasIndex(e => e.ItemId, "item_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.PEventId, "p_event_id");

            entity.HasIndex(e => e.PMode, "p_mode");

            entity.HasIndex(e => e.PResourceId, "p_resource_id");

            entity.HasIndex(e => e.PScheduleId, "p_schedule_id");

            entity.HasIndex(e => e.PayerId, "payer_id");

            entity.HasIndex(e => e.PfChargeId, "pf_charge_id");

            entity.HasIndex(e => new { e.PfId, e.PfAccGroup, e.PfTypeId }, "pf_id");

            entity.HasIndex(e => e.PosId, "pos_id");

            entity.HasIndex(e => e.PostedDate, "posted_date");

            entity.HasIndex(e => e.PrevId, "prev_id");

            entity.HasIndex(e => e.Pstatus, "pstatus");

            entity.HasIndex(e => e.PtransactionId, "ptransaction_id");

            entity.HasIndex(e => e.RefundId, "refund_id");

            entity.HasIndex(e => e.SellId, "sell_id");

            entity.HasIndex(e => e.ShiftId, "shift_id");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.HasIndex(e => e.TypeId, "type_id");

            entity.HasIndex(e => e.UpackageId, "upackage_id");

            entity.HasIndex(e => e.UserFor, "user_for");

            entity.HasIndex(e => e.UserHomeClub, "user_home_club");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => e.VoidedDate, "voided_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccGroupId).HasColumnName("acc_group_id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.Amount)
                .HasPrecision(12, 2)
                .HasColumnName("amount");
            entity.Property(e => e.AmountReturned)
                .HasPrecision(12, 2)
                .HasColumnName("amount_returned");
            entity.Property(e => e.AmountTotal)
                .HasPrecision(12, 2)
                .HasColumnName("amount_total");
            entity.Property(e => e.CcTransactionId).HasColumnName("cc_transaction_id");
            entity.Property(e => e.CertificateId).HasColumnName("certificate_id");
            entity.Property(e => e.ChargeId).HasColumnName("charge_id");
            entity.Property(e => e.CheckId).HasColumnName("check_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateIndex).HasColumnName("date_index");
            entity.Property(e => e.DepositPayment).HasColumnName("deposit_payment");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Discount)
                .HasPrecision(12, 2)
                .HasColumnName("discount");
            entity.Property(e => e.EntityId)
                .HasComment("club id")
                .HasColumnName("entity_id");
            entity.Property(e => e.EventDate).HasColumnName("event_date");
            entity.Property(e => e.EventStatus).HasColumnName("event_status");
            entity.Property(e => e.ForeignId)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("foreign_id");
            entity.Property(e => e.ForeignText)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("foreign_text");
            entity.Property(e => e.FromEntityId).HasColumnName("from_entity_id");
            entity.Property(e => e.Hide).HasColumnName("hide");
            entity.Property(e => e.IsAdjustment).HasColumnName("is_adjustment");
            entity.Property(e => e.IsEft).HasColumnName("is_eft");
            entity.Property(e => e.IsOnline).HasColumnName("is_online");
            entity.Property(e => e.IsPosted).HasColumnName("is_posted");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("item_id");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.PEventId).HasColumnName("p_event_id");
            entity.Property(e => e.PMode)
                .HasDefaultValueSql("'1'")
                .HasColumnName("p_mode");
            entity.Property(e => e.PResourceId).HasColumnName("p_resource_id");
            entity.Property(e => e.PScheduleId).HasColumnName("p_schedule_id");
            entity.Property(e => e.PackageChId).HasColumnName("package_ch_id");
            entity.Property(e => e.PaidBefore)
                .HasPrecision(12, 2)
                .HasColumnName("paid_before");
            entity.Property(e => e.PaidToday)
                .HasPrecision(12, 2)
                .HasColumnName("paid_today");
            entity.Property(e => e.PayerId).HasColumnName("payer_id");
            entity.Property(e => e.PfAccGroup).HasColumnName("pf_acc_group");
            entity.Property(e => e.PfChargeId).HasColumnName("pf_charge_id");
            entity.Property(e => e.PfId).HasColumnName("pf_id");
            entity.Property(e => e.PfTypeId).HasColumnName("pf_type_id");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PostedDate).HasColumnName("posted_date");
            entity.Property(e => e.PrevData)
                .HasColumnType("mediumtext")
                .HasColumnName("prev_data");
            entity.Property(e => e.PrevId).HasColumnName("prev_id");
            entity.Property(e => e.Pstatus)
                .HasDefaultValueSql("'1'")
                .HasColumnName("pstatus");
            entity.Property(e => e.PtransactionId).HasColumnName("ptransaction_id");
            entity.Property(e => e.RefundId).HasColumnName("refund_id");
            entity.Property(e => e.SellId).HasColumnName("sell_id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.ShopCartId).HasColumnName("shop_cart_id");
            entity.Property(e => e.TaxAmount)
                .HasPrecision(12, 2)
                .HasColumnName("tax_amount");
            entity.Property(e => e.TaxReversed)
                .HasPrecision(12, 2)
                .HasColumnName("tax_reversed");
            entity.Property(e => e.TaxReversedId).HasColumnName("tax_reversed_id");
            entity.Property(e => e.TaxReversedRate)
                .HasPrecision(9, 4)
                .HasColumnName("tax_reversed_rate");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.Unreal).HasColumnName("unreal");
            entity.Property(e => e.UpackageId).HasColumnName("upackage_id");
            entity.Property(e => e.UserFor).HasColumnName("user_for");
            entity.Property(e => e.UserHomeClub)
                .HasComment("club id taken from user profile")
                .HasColumnName("user_home_club");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VirtualCash).HasColumnName("virtual_cash");
            entity.Property(e => e.Voided).HasColumnName("voided");
            entity.Property(e => e.VoidedDate).HasColumnName("voided_date");
            entity.Property(e => e.VoidedTime)
                .HasColumnType("datetime")
                .HasColumnName("voided_time");
        });

        modelBuilder.Entity<PaymentTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payment_transaction")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.CcTransactionId, "cc_transaction_id");

            entity.HasIndex(e => e.CertificateId, "certificate_id");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.IsEft, "is_eft");

            entity.HasIndex(e => e.IsPosted, "is_posted");

            entity.HasIndex(e => e.PMode, "p_mode");

            entity.HasIndex(e => e.PayerId, "payer_id");

            entity.HasIndex(e => e.PosId, "pos_id");

            entity.HasIndex(e => e.PostedDate, "posted_date");

            entity.HasIndex(e => e.ShiftId, "shift_id");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.HasIndex(e => e.TypeId, "type_id");

            entity.HasIndex(e => e.UpackageId, "upackage_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.Amount)
                .HasColumnType("float(18,2)")
                .HasColumnName("amount");
            entity.Property(e => e.CcTransactionId).HasColumnName("cc_transaction_id");
            entity.Property(e => e.CertificateId).HasColumnName("certificate_id");
            entity.Property(e => e.CheckId).HasColumnName("check_id");
            entity.Property(e => e.CreditAmount)
                .HasColumnType("float(18,2)")
                .HasColumnName("credit_amount");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.HasPrevId).HasColumnName("has_prev_id");
            entity.Property(e => e.IsEft).HasColumnName("is_eft");
            entity.Property(e => e.IsPosted).HasColumnName("is_posted");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.OriginalAmount)
                .HasColumnType("float(18,2)")
                .HasColumnName("original_amount");
            entity.Property(e => e.OriginalDescription)
                .HasColumnType("text")
                .HasColumnName("original_description");
            entity.Property(e => e.PMode)
                .HasDefaultValueSql("'1'")
                .HasColumnName("p_mode");
            entity.Property(e => e.PackageChId).HasColumnName("package_ch_id");
            entity.Property(e => e.PayerId).HasColumnName("payer_id");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PostedDate).HasColumnName("posted_date");
            entity.Property(e => e.Pstatus)
                .HasDefaultValueSql("'1'")
                .HasColumnName("pstatus");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("transaction_id");
            entity.Property(e => e.TransactionType).HasColumnName("transaction_type");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UpackageId).HasColumnName("upackage_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VirtualCash).HasColumnName("virtual_cash");
        });

        modelBuilder.Entity<PaymentTransfer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payment_transfer")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.FromPaymentId, "from_payment_id");

            entity.HasIndex(e => e.FromUserId, "from_user_id");

            entity.HasIndex(e => e.ToPaymentId, "to_payment_id");

            entity.HasIndex(e => e.ToUserId, "to_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasComment("date of the transfer")
                .HasColumnName("date");
            entity.Property(e => e.FromPaymentId)
                .HasComment("original payment")
                .HasColumnName("from_payment_id");
            entity.Property(e => e.FromUserId)
                .HasComment("user who paid")
                .HasColumnName("from_user_id");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.ToPaymentId)
                .HasComment("applied credit")
                .HasColumnName("to_payment_id");
            entity.Property(e => e.ToUserId)
                .HasComment("user who had the charge")
                .HasColumnName("to_user_id");
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payment_type")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Sort, "sort");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccGroupName)
                .HasColumnType("text")
                .HasColumnName("acc_group_name");
            entity.Property(e => e.BatchEnabled).HasColumnName("batch_enabled");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.GlCode)
                .HasColumnType("text")
                .HasColumnName("gl_code");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.PosEnabled).HasColumnName("pos_enabled");
            entity.Property(e => e.QbExport).HasColumnName("qb_export");
            entity.Property(e => e.Sort).HasColumnName("sort");
            entity.Property(e => e.StatementEnabled).HasColumnName("statement_enabled");
            entity.Property(e => e.Status)
                .HasColumnType("enum('enabled','disabled')")
                .HasColumnName("status");
            entity.Property(e => e.System).HasColumnName("system");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("phone")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => new { e.UserId, e.PhoneType }, "UserPhoneKey");

            entity.HasIndex(e => e.NumberDigits, "number_digits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");
            entity.Property(e => e.NumberDigits)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("number_digits");
            entity.Property(e => e.PhoneType)
                .HasColumnType("enum('Home','Work','Cell','Other','Emergency')")
                .HasColumnName("phone_type");
            entity.Property(e => e.Primary).HasColumnName("primary");
            entity.Property(e => e.Relation)
                .HasMaxLength(255)
                .HasColumnName("relation");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<PhoneStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("phone_status")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NumberDigits, "number_digits_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastOptinDate)
                .HasColumnType("datetime")
                .HasColumnName("last_optin_date");
            entity.Property(e => e.LastUpdatedAtUserId).HasColumnName("last_updated_at_user_id");
            entity.Property(e => e.LastUpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("last_updated_date");
            entity.Property(e => e.NumberDigits)
                .HasMaxLength(50)
                .HasColumnName("number_digits");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'-1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Po>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AddressId, "address_id");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("address2");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .HasColumnName("caption");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("'US'")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EmvTerminalId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("emv_terminal_id");
            entity.Property(e => e.EnablePin)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_pin");
            entity.Property(e => e.EnableTips).HasColumnName("enable_tips");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.KitchenReceiptGrouping)
                .HasDefaultValueSql("'0'")
                .HasColumnName("kitchen_receipt_grouping");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("location");
            entity.Property(e => e.MultiplePrintjobs).HasColumnName("multiple_printjobs");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.PrintMerchantCopyWithEmail)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("print_merchant_copy_with_email");
            entity.Property(e => e.ShopShortcutMenuId).HasColumnName("shop_shortcut_menu_id");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TipsAccountingGroupId).HasColumnName("tips_accounting_group_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Zip)
                .HasMaxLength(255)
                .HasColumnName("zip");

            entity.HasOne(d => d.AddressNavigation).WithMany(p => p.Pos)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_address_id_pos");
        });

        modelBuilder.Entity<ProspectTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("prospect_tasks")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
            entity.Property(e => e.ShortName)
                .HasMaxLength(32)
                .HasColumnName("short_name");
        });

        modelBuilder.Entity<ProspectUserAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("prospect_user_assignment")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AssignedToId, "assigned_to_id");

            entity.HasIndex(e => e.AssignedToIdSecondary, "assigned_to_id_secondary");

            entity.HasIndex(e => e.ProspectUserId, "prospect_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignedToId).HasColumnName("assigned_to_id");
            entity.Property(e => e.AssignedToIdSecondary).HasColumnName("assigned_to_id_secondary");
            entity.Property(e => e.ProspectUserId).HasColumnName("prospect_user_id");
        });

        modelBuilder.Entity<ProspectUserTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("prospect_user_tasks")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignedToId).HasColumnName("assigned_to_id");
            entity.Property(e => e.CompletedTime)
                .HasColumnType("datetime")
                .HasColumnName("completed_time");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.ProspectOptionId).HasColumnName("prospect_option_id");
            entity.Property(e => e.ProspectTaskId).HasColumnName("prospect_task_id");
            entity.Property(e => e.ProspectUserId).HasColumnName("prospect_user_id");
            entity.Property(e => e.Status)
                .HasMaxLength(16)
                .HasDefaultValueSql("'Open'")
                .HasColumnName("status");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("time")
                .HasColumnName("time_end");
            entity.Property(e => e.TimeStart)
                .HasColumnType("time")
                .HasColumnName("time_start");
        });

        modelBuilder.Entity<Refund>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("refund")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AddedBy, "added_by");

            entity.HasIndex(e => e.ChargeId, "charge_id");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.DateIndex, "date_index");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => new { e.EntityId, e.IsPosted, e.Date }, "entity_posted_date");

            entity.HasIndex(e => e.IsPosted, "is_posted");

            entity.HasIndex(e => e.PaymentId, "payment_id");

            entity.HasIndex(e => e.PosId, "pos_id");

            entity.HasIndex(e => e.PostedDate, "posted_date");

            entity.HasIndex(e => e.RefundReceiptId, "refund_receipt_id");

            entity.HasIndex(e => e.ShiftId, "shift_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.Amount)
                .HasColumnType("float(18,2)")
                .HasColumnName("amount");
            entity.Property(e => e.CcNumber)
                .HasMaxLength(20)
                .HasColumnName("cc_number");
            entity.Property(e => e.CertificateId).HasColumnName("certificate_id");
            entity.Property(e => e.ChargeId).HasColumnName("charge_id");
            entity.Property(e => e.CheckId).HasColumnName("check_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateIndex).HasColumnName("date_index");
            entity.Property(e => e.EntityId)
                .HasComment("club id")
                .HasColumnName("entity_id");
            entity.Property(e => e.ExportToQb)
                .HasComment("export to qb even if charge.export_to_qb=0")
                .HasColumnName("export_to_qb");
            entity.Property(e => e.IsCustom).HasColumnName("is_custom");
            entity.Property(e => e.IsPosted).HasColumnName("is_posted");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.PaymentType).HasColumnName("payment_type");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PostedDate).HasColumnName("posted_date");
            entity.Property(e => e.RefundReceiptId).HasColumnName("refund_receipt_id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("float(18,2)")
                .HasColumnName("total_amount");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'refund'")
                .HasColumnType("enum('refund','void')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<ReportsShopInventoryHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("reports_shop_inventory_history")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReportsId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("reports_id");
            entity.Property(e => e.ShopInventoryHistoryId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("shop_inventory_history_id");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("resource")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ResourceInfoId, "resource_info_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BallMachine)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("ball_machine");
            entity.Property(e => e.CanBeReserved)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("can_be_reserved");
            entity.Property(e => e.CourtLocationId).HasColumnName("court_location_id");
            entity.Property(e => e.CourtTypeId).HasColumnName("court_type_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ExternalResource).HasColumnName("external_resource");
            entity.Property(e => e.Fee)
                .HasPrecision(9, 2)
                .HasColumnName("fee");
            entity.Property(e => e.MaxAttendCnt)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("max_attend_cnt");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ResourceInfoId).HasColumnName("resource_info_id");
            entity.Property(e => e.ResourceTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("resource_type_id");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<ResourceSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("resource_schedule")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.InfoId, "info_id");

            entity.HasIndex(e => e.ResourceId, "resource");

            entity.HasIndex(e => new { e.Date, e.ResourceId }, "resource_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("end_time");
            entity.Property(e => e.InfoId).HasColumnName("info_id");
            entity.Property(e => e.RecurrenceId).HasColumnName("recurrence_id");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("start_time");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'available'")
                .HasColumnType("enum('available','block')")
                .HasColumnName("type")
                .UseCollation("utf8mb3_unicode_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<RevenueRecognition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("revenue_recognition")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.RevenueGroupId, "revenue_group_id_fk");

            entity.HasIndex(e => new { e.SubjectType, e.SubjectId }, "subject");

            entity.HasIndex(e => e.SupposedDate, "supposed_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("float(18,2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountPerDay)
                .HasPrecision(18, 8)
                .HasColumnName("amount_per_day");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.FromGroup).HasColumnName("from_group");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.RevenueGroupId).HasColumnName("revenue_group_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.SubjectType).HasColumnName("subject_type");
            entity.Property(e => e.SupposedDate).HasColumnName("supposed_date");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.ToDate).HasColumnName("to_date");
            entity.Property(e => e.ToGroup).HasColumnName("to_group");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedule")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AttendSaved, "attend_saved");

            entity.HasIndex(e => e.BillGuestFee, "bill_guest_fee");

            entity.HasIndex(e => e.Blocked, "blocked");

            entity.HasIndex(e => e.BlockedDate, "blocked_date");

            entity.HasIndex(e => e.ComponentId, "component_id");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.DirectorId, "director_id");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.ExpiredDate, "expired_date");

            entity.HasIndex(e => e.AreaId, "fk_schedule_location_area");

            entity.HasIndex(e => new { e.ForSale, e.PayrollDate, e.Id, e.EventId }, "for_sale");

            entity.HasIndex(e => e.IsOnline, "is_online");

            entity.HasIndex(e => e.IsPaidOff, "is_paid_off");

            entity.HasIndex(e => e.LocationId, "location_id");

            entity.HasIndex(e => e.PayrollDate, "payroll_date");

            entity.HasIndex(e => e.RecurrenceId, "recurrence_id");

            entity.HasIndex(e => e.SoldForFree, "sold_for_free");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => e.TeeTimeId, "tee_time_id");

            entity.HasIndex(e => e.TimeBegin, "time_begin");

            entity.HasIndex(e => e.TimeEnd, "time_end");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.AttendSaved).HasColumnName("attend_saved");
            entity.Property(e => e.BallMachine).HasColumnName("ball_machine");
            entity.Property(e => e.BallMachineAmount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(18,2)")
                .HasColumnName("ball_machine_amount");
            entity.Property(e => e.BillGuestFee)
                .HasDefaultValueSql("'1'")
                .HasColumnName("bill_guest_fee");
            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.BlockedDate).HasColumnName("blocked_date");
            entity.Property(e => e.BlockedTime)
                .HasColumnType("datetime")
                .HasColumnName("blocked_time");
            entity.Property(e => e.ChargeMember).HasColumnName("charge_member");
            entity.Property(e => e.ChargeSold).HasColumnName("charge_sold");
            entity.Property(e => e.CleanupTimeIncluded).HasColumnName("cleanup_time_included");
            entity.Property(e => e.ComissionRate)
                .HasPrecision(9, 2)
                .HasColumnName("comission_rate");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.Confirmed)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("confirmed");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DirectorId).HasColumnName("director_id");
            entity.Property(e => e.DoNotCharge).HasColumnName("do_not_charge");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.ExpiredDate).HasColumnName("expired_date");
            entity.Property(e => e.ForSale).HasColumnName("for_sale");
            entity.Property(e => e.IsOnline)
                .HasComment("Whether the game was scheduled online.")
                .HasColumnName("is_online");
            entity.Property(e => e.IsPaidOff).HasColumnName("is_paid_off");
            entity.Property(e => e.IsSeria).HasColumnName("is_seria");
            entity.Property(e => e.IsUsed).HasColumnName("is_used");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.LessonType)
                .HasDefaultValueSql("'1'")
                .HasColumnName("lesson_type");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.OffsiteAddress)
                .HasColumnType("tinytext")
                .HasColumnName("offsite_address");
            entity.Property(e => e.PaymentStatus)
                .HasDefaultValueSql("'no_invoice'")
                .HasColumnType("enum('unpaid','paid','no_invoice')")
                .HasColumnName("payment_status");
            entity.Property(e => e.PayrollDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("payroll_date");
            entity.Property(e => e.RecurrenceId).HasColumnName("recurrence_id");
            entity.Property(e => e.SParams)
                .HasColumnType("text")
                .HasColumnName("s_params");
            entity.Property(e => e.SelectedPro).HasColumnName("selected_pro");
            entity.Property(e => e.SetupTimeIncluded).HasColumnName("setup_time_included");
            entity.Property(e => e.SoldForFree).HasColumnName("sold_for_free");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'active'")
                .HasColumnType("enum('active','canceled','disabled','sold')")
                .HasColumnName("status");
            entity.Property(e => e.TeeTimeId).HasColumnName("tee_time_id");
            entity.Property(e => e.TimeBegin)
                .HasColumnType("time")
                .HasColumnName("time_begin");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("time")
                .HasColumnName("time_end");
            entity.Property(e => e.Unavailable).HasColumnName("unavailable");
        });

        modelBuilder.Entity<ScheduleReserve>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedule_reserve")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ResourceId, "fk_schedule_reserve_resource");

            entity.HasIndex(e => e.ResourceTypeId, "fk_schedule_reserve_resource_type");

            entity.HasIndex(e => e.ScheduleId, "fk_schedule_reserve_schedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ResourceTypeId).HasColumnName("resource_type_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<ScheduleResource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("schedule_resource")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ResourceId, "resource_id");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
        });

        modelBuilder.Entity<ShopCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_categories")
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllStores)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("all_stores");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.PrintKitchenReceipt).HasColumnName("print_kitchen_receipt");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<ShopInventoryHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_inventory_history", tb => tb.HasComment("Shop Inventory History"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.ShopItemsId, "shop_items_id");

            entity.HasIndex(e => e.ShopStoreId, "shop_store_id");

            entity.HasIndex(e => e.ShopVendorId, "shop_vendor_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.Cost)
                .HasPrecision(9, 2)
                .HasColumnName("cost");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.InventoryTransferId).HasColumnName("inventory_transfer_id");
            entity.Property(e => e.NewAmount)
                .HasPrecision(12, 4)
                .HasColumnName("new_amount");
            entity.Property(e => e.OldAmount)
                .HasPrecision(12, 4)
                .HasColumnName("old_amount");
            entity.Property(e => e.ReasonCode).HasColumnName("reason_code");
            entity.Property(e => e.ShopItemsId).HasColumnName("shop_items_id");
            entity.Property(e => e.ShopStoreId).HasColumnName("shop_store_id");
            entity.Property(e => e.ShopVendorId).HasColumnName("shop_vendor_id");
        });

        modelBuilder.Entity<ShopItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_items")
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => e.ItemNumber, "item_number");

            entity.HasIndex(e => e.TaxRateId, "tax_rate_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccGroupId).HasColumnName("acc_group_id");
            entity.Property(e => e.Amount)
                .HasPrecision(12, 4)
                .HasColumnName("amount");
            entity.Property(e => e.AvgCost)
                .HasColumnType("float(18,2)")
                .HasColumnName("avg_cost");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Color)
                .HasMaxLength(64)
                .HasColumnName("color");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.Cost)
                .HasColumnType("float(18,2)")
                .HasColumnName("cost");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.ItemNumber)
                .HasMaxLength(250)
                .HasColumnName("item_number");
            entity.Property(e => e.Label)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasComment("label for schedule grid")
                .HasColumnName("label");
            entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Payroll)
                .HasColumnType("float(18,2)")
                .HasColumnName("payroll");
            entity.Property(e => e.Price)
                .HasColumnType("float(18,2)")
                .HasColumnName("price");
            entity.Property(e => e.PriceRules)
                .HasComment("JSON-encoded rules to calculate price.")
                .HasColumnType("text")
                .HasColumnName("price_rules");
            entity.Property(e => e.Size)
                .HasMaxLength(16)
                .HasColumnName("size");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Tax)
                .HasColumnType("float(18,2)")
                .HasColumnName("tax");
            entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            entity.Property(e => e.Taxable)
                .HasDefaultValueSql("'1'")
                .HasColumnName("taxable");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<ShopItemAdjustmentReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_item_adjustment_reason")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Default).HasColumnName("default");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.System)
                .HasDefaultValueSql("'0'")
                .HasColumnName("system");
        });

        modelBuilder.Entity<ShopItemBarcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_item_barcodes", tb => tb.HasComment("Table to store barcodes of shop items"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ItemId, "item_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Barcode)
                .HasMaxLength(255)
                .HasColumnName("barcode");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
        });

        modelBuilder.Entity<ShopItemManufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_item_manufacturer")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AddressId, "address_id");

            entity.HasIndex(e => e.VendorId, "vendor_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.AllStores)
                .HasDefaultValueSql("'1'")
                .HasColumnName("all_stores");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .HasDefaultValueSql("'US'")
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("street_address");
            entity.Property(e => e.StreetAddress2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("street_address2");
            entity.Property(e => e.TimeCreated)
                .HasColumnType("datetime")
                .HasColumnName("time_created");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title")
                .UseCollation("latin1_general_ci");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
            entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("zip");

            entity.HasOne(d => d.Address).WithMany(p => p.ShopItemManufacturers)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_address_id");
        });

        modelBuilder.Entity<ShopItemStore>(entity =>
        {
            entity.HasKey(e => new { e.ShopItemsId, e.ShopStoreId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("shop_item_store", tb => tb.HasComment("Shop Item Store"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AccountingGroupId, "accounting_group_id");

            entity.Property(e => e.ShopItemsId).HasColumnName("shop_items_id");
            entity.Property(e => e.ShopStoreId).HasColumnName("shop_store_id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.Amount)
                .HasPrecision(12, 4)
                .HasColumnName("amount");
            entity.Property(e => e.Available)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("available");
            entity.Property(e => e.AverageCost)
                .HasPrecision(9, 3)
                .HasColumnName("average_cost");
        });

        modelBuilder.Entity<ShopStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_store")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.BillingAddressId, "billing_address_id");

            entity.HasIndex(e => e.LocationId, "location_id");

            entity.HasIndex(e => e.ShippingAddressId, "shipping_address_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");
            entity.Property(e => e.BillingCity)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("billing_city");
            entity.Property(e => e.BillingState)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("billing_state");
            entity.Property(e => e.BillingStreetAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("billing_street_address");
            entity.Property(e => e.BillingStreetAddress2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("billing_street_address2");
            entity.Property(e => e.BillingZip)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("billing_zip");
            entity.Property(e => e.Fax)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fax");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
            entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");
            entity.Property(e => e.ShippingCity)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_city");
            entity.Property(e => e.ShippingState)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_state");
            entity.Property(e => e.ShippingStreetAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_street_address");
            entity.Property(e => e.ShippingStreetAddress2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_street_address2");
            entity.Property(e => e.ShippingZip)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_zip");

            entity.HasOne(d => d.BillingAddress).WithMany(p => p.ShopStoreBillingAddresses)
                .HasForeignKey(d => d.BillingAddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_billing_address_id");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.ShopStoreShippingAddresses)
                .HasForeignKey(d => d.ShippingAddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_shipping_address_id");
        });

        modelBuilder.Entity<ShopVendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_vendor")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AddressId, "address_id");

            entity.HasIndex(e => e.AllStores, "all_stores");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.AllStores)
                .HasDefaultValueSql("'1'")
                .HasColumnName("all_stores");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .HasDefaultValueSql("'US'")
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("street_address");
            entity.Property(e => e.StreetAddress2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("street_address2");
            entity.Property(e => e.TimeCreated)
                .HasColumnType("datetime")
                .HasColumnName("time_created");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("zip");

            entity.HasOne(d => d.Address).WithMany(p => p.ShopVendors)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_sv_ad");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("state")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.CountryId, "fk_state_country");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("code");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("parent_id");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_state_country");
        });

        modelBuilder.Entity<Tbatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tbatch")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("float(18,2)")
                .HasColumnName("total_amount");
            entity.Property(e => e.TransactionType)
                .HasDefaultValueSql("'charge'")
                .HasColumnType("enum('charge','credit','check')")
                .HasColumnName("transaction_type");
            entity.Property(e => e.Type)
                .HasMaxLength(14)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TbatchTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tbatch_transaction")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.TbatchId, "tbatch_id");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TbatchId).HasColumnName("tbatch_id");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("transaction")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Complete, "complete");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EftCode, "eft_code").HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => e.IsCheck, "is_check");

            entity.HasIndex(e => e.IsEft, "is_eft");

            entity.HasIndex(e => e.IsOnline, "is_online");

            entity.HasIndex(e => e.MailBilled, "mail_billed");

            entity.HasIndex(e => e.PosId, "pos_id");

            entity.HasIndex(e => e.Result, "result");

            entity.HasIndex(e => new { e.RetailerId, e.EftCode }, "retailer_eft_code");

            entity.HasIndex(e => e.ShiftId, "shift_id");

            entity.HasIndex(e => e.SubmitStatus, "submit_status").HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.HasIndex(e => e.Time, "time");

            entity.HasIndex(e => e.Unreal, "unreal");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorizationNumber)
                .HasMaxLength(255)
                .HasColumnName("authorization_number");
            entity.Property(e => e.CcTransactionInfo)
                .HasColumnType("text")
                .HasColumnName("cc_transaction_info");
            entity.Property(e => e.ChangeGiven)
                .HasColumnType("float(18,2)")
                .HasColumnName("change_given");
            entity.Property(e => e.Complete)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("complete");
            entity.Property(e => e.CreditCardNumber)
                .HasMaxLength(255)
                .HasColumnName("credit_card_number");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Discount)
                .HasPrecision(9, 2)
                .HasColumnName("discount");
            entity.Property(e => e.EftCode).HasColumnName("eft_code");
            entity.Property(e => e.EftDate)
                .HasColumnType("datetime")
                .HasColumnName("eft_date");
            entity.Property(e => e.EntityId)
                .HasComment("club id")
                .HasColumnName("entity_id");
            entity.Property(e => e.IsCheck).HasColumnName("is_check");
            entity.Property(e => e.IsEft).HasColumnName("is_eft");
            entity.Property(e => e.IsOnline).HasColumnName("is_online");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.MailBilled).HasColumnName("mail_billed");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.Result)
                .HasColumnType("enum('OK','FAILED','DECLINED','DUPLICATE','FRAUD','VOIDED','SUBMITTED')")
                .HasColumnName("result");
            entity.Property(e => e.RetailerId).HasColumnName("retailer_id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.SslApprovalCode)
                .HasMaxLength(50)
                .HasColumnName("ssl_approval_code");
            entity.Property(e => e.SslTxnId)
                .HasMaxLength(50)
                .HasColumnName("ssl_txn_id");
            entity.Property(e => e.SubmitStatus)
                .HasMaxLength(50)
                .HasColumnName("submit_status");
            entity.Property(e => e.Subtotal)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.TParams)
                .HasColumnType("text")
                .HasColumnName("t_params");
            entity.Property(e => e.Tax)
                .HasPrecision(9, 3)
                .HasColumnName("tax");
            entity.Property(e => e.TaxRate)
                .HasPrecision(9, 4)
                .HasColumnName("tax_rate");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.Total)
                .HasPrecision(12, 2)
                .HasColumnName("total");
            entity.Property(e => e.Unreal).HasColumnName("unreal");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Transactionlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("transactionlog");

            entity.HasIndex(e => e.Id, "Index 1");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasColumnName("action");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.EffectiveDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("effective_date");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.SourceOfSync)
                .HasMaxLength(50)
                .HasColumnName("source_of_sync");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasColumnName("table_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AccountNum, "account_num").HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.HasIndex(e => e.ContractNum, "contract_num");

            entity.HasIndex(e => e.DeliveryMethod, "delivery_method");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => e.FirstName, "first_name").HasAnnotation("MySql:IndexPrefixLength", new[] { 20 });

            entity.HasIndex(e => e.HouseCharge, "house_charge");

            entity.HasIndex(e => e.ImportId, "import_id").IsUnique();

            entity.HasIndex(e => e.Joined, "joined");

            entity.HasIndex(e => e.LastName, "last_name").HasAnnotation("MySql:IndexPrefixLength", new[] { 20 });

            entity.HasIndex(e => e.Login, "login");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.Nonmember, "nonmember");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.HasIndex(e => e.PrimaryId, "primary_id");

            entity.HasIndex(e => e.Role, "role");

            entity.HasIndex(e => e.SendMail, "send_mail");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNum).HasColumnName("account_num");
            entity.Property(e => e.Activated).HasColumnName("activated");
            entity.Property(e => e.AdditionalEmails)
                .HasColumnType("text")
                .HasColumnName("additional_emails");
            entity.Property(e => e.Age)
                .HasPrecision(6, 2)
                .HasColumnName("age");
            entity.Property(e => e.Balance)
                .HasColumnType("float(18,2)")
                .HasColumnName("balance");
            entity.Property(e => e.BalanceTill)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("balance_till");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.Cancelled)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("cancelled");
            entity.Property(e => e.CancelledReason)
                .HasMaxLength(255)
                .HasColumnName("cancelled_reason");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Confidence)
                .IsRequired()
                .HasDefaultValueSql("'3'")
                .HasColumnName("confidence");
            entity.Property(e => e.ConfirmedRso).HasColumnName("confirmed_rso");
            entity.Property(e => e.ContractNum).HasColumnName("contract_num");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("'US'")
                .HasColumnName("country_code");
            entity.Property(e => e.CreditLimit).HasColumnName("credit_limit");
            entity.Property(e => e.DcsAddrStatus)
                .HasComment("if 1 address updated by dcs elseif 2 address acknowledge by staff elseif 3 exclude address update by dcs")
                .HasColumnName("dcs_addr_status");
            entity.Property(e => e.DeliveryMethod)
                .HasDefaultValueSql("'none'")
                .HasColumnType("enum('none','email','mail')")
                .HasColumnName("delivery_method");
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(250)
                .HasColumnName("drivers_license");
            entity.Property(e => e.DriversLicenseState)
                .HasMaxLength(10)
                .HasColumnName("drivers_license_state");
            entity.Property(e => e.ELogin)
                .HasMaxLength(100)
                .HasColumnName("e_login");
            entity.Property(e => e.EPass)
                .HasMaxLength(250)
                .HasColumnName("e_pass");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.EmailNotConfirmed).HasColumnName("email_not_confirmed");
            entity.Property(e => e.EntityId)
                .HasComment("home club")
                .HasColumnName("entity_id");
            entity.Property(e => e.Expired).HasColumnName("expired");
            entity.Property(e => e.FamilyAddrType).HasColumnName("family_addr_type");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasColumnName("filename");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.GuestVisits).HasColumnName("guest_visits");
            entity.Property(e => e.HouseCharge)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('no','credit card','bank account','mail bill','trade')")
                .HasColumnName("house_charge");
            entity.Property(e => e.ImportId)
                .HasMaxLength(100)
                .HasColumnName("import_id");
            entity.Property(e => e.IsGlobal).HasColumnName("is_global");
            entity.Property(e => e.IsSystem).HasColumnName("is_system");
            entity.Property(e => e.Joined).HasColumnName("joined");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.LastStatementDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("last_statement_date");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.LastUpdatePasswordDate).HasColumnName("last_update_password_date");
            entity.Property(e => e.LastVisitDate).HasColumnName("last_visit_date");
            entity.Property(e => e.LateFeeExempt)
                .HasDefaultValueSql("'2'")
                .HasColumnName("late_fee_exempt");
            entity.Property(e => e.Login)
                .HasMaxLength(200)
                .HasColumnName("login");
            entity.Property(e => e.MembershipType).HasColumnName("membership_type");
            entity.Property(e => e.MenuCollapsed).HasColumnName("menu_collapsed");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("middle_name");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.Nonmember).HasColumnName("nonmember");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.PosHouseCharge).HasColumnName("pos_house_charge");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PrimaryId).HasColumnName("primary_id");
            entity.Property(e => e.RealDriversLicense)
                .HasMaxLength(255)
                .HasColumnName("real_drivers_license")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ReferralSource)
                .HasMaxLength(256)
                .HasColumnName("referral_source");
            entity.Property(e => e.ReferringMemberId).HasColumnName("referring_member_id");
            entity.Property(e => e.RegisterDate).HasColumnName("register_date");
            entity.Property(e => e.Rep).HasColumnName("rep");
            entity.Property(e => e.RewardPoints)
                .HasPrecision(18, 2)
                .HasColumnName("reward_points");
            entity.Property(e => e.Role)
                .HasDefaultValueSql("'Guest'")
                .HasComment("If user is both staff and member, we set role to Staff, Guest is when he is neither Staff or Member.")
                .HasColumnType("enum('Staff','Guest','Member','Corporate')")
                .HasColumnName("role");
            entity.Property(e => e.Salutation)
                .HasMaxLength(10)
                .HasDefaultValueSql("'Mr'")
                .HasColumnName("salutation");
            entity.Property(e => e.SendMail)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("send_mail");
            entity.Property(e => e.Sex)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sex");
            entity.Property(e => e.State)
                .HasMaxLength(5)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'No membership'")
                .HasColumnType("enum('Active','Inactive','Suspended','Canceled','Removed','Expired','Holded','On Hold','No membership','Online Review','Joined','Non-member','Staff','Corporate Account')")
                .HasColumnName("status");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(255)
                .HasColumnName("street_address");
            entity.Property(e => e.StreetAddress2)
                .HasMaxLength(255)
                .HasColumnName("street_address2");
            entity.Property(e => e.TaxExempt).HasColumnName("tax_exempt");
            entity.Property(e => e.Trade)
                .HasDefaultValueSql("'2'")
                .HasColumnName("trade");
            entity.Property(e => e.UnsubscribeCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("unsubscribe_code");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
            entity.Property(e => e.Zip)
                .HasMaxLength(16)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<UserArchive>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_archive")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ArchiveDate, "archive_date");

            entity.HasIndex(e => e.ArchivedBy, "archived_by");

            entity.HasIndex(e => e.FirstName, "first_name").HasAnnotation("MySql:IndexPrefixLength", new[] { 50 });

            entity.HasIndex(e => e.LastName, "last_name").HasAnnotation("MySql:IndexPrefixLength", new[] { 50 });

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchiveDate).HasColumnName("archive_date");
            entity.Property(e => e.ArchivedBy).HasColumnName("archived_by");
            entity.Property(e => e.ByParentId)
                .HasColumnType("mediumtext")
                .HasColumnName("by_parent_id");
            entity.Property(e => e.ByPrimaryId)
                .HasColumnType("mediumtext")
                .HasColumnName("by_primary_id");
            entity.Property(e => e.ContractNum)
                .HasMaxLength(255)
                .HasColumnName("contract_num");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Events)
                .HasColumnType("mediumtext")
                .HasColumnName("events");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.Joined).HasColumnName("joined");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("login");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserBalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_balance")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DateFrom, "date_from");

            entity.HasIndex(e => e.DateTo, "date_to");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Balance)
                .HasColumnType("float(18,2)")
                .HasColumnName("balance");
            entity.Property(e => e.DateFrom).HasColumnName("date_from");
            entity.Property(e => e.DateTo).HasColumnName("date_to");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.ViewHidden).HasColumnName("view_hidden");
        });

        modelBuilder.Entity<UserCustomField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_custom_fields")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ModifiedBy, "FK_modified_by");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InUse)
                .HasDefaultValueSql("'1'")
                .HasColumnName("in_use");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Params)
                .HasColumnType("mediumtext")
                .HasColumnName("params");
            entity.Property(e => e.Type)
                .HasColumnType("enum('numeric','currency','text','list','date')")
                .HasColumnName("type");
            entity.Property(e => e.UsedFor)
                .HasDefaultValueSql("'profile'")
                .HasColumnType("enum('both','registration','profile')")
                .HasColumnName("used_for");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<UserCustomFieldsValue>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("user_custom_fields_values")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.FieldId, "FK_field");

            entity.HasIndex(e => new { e.UserId, e.FieldId, e.ValueText }, "idx_user_custom_fields_values_user_id_field_id");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.FieldId).HasColumnName("field_id");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
            entity.Property(e => e.ValueDate).HasColumnName("value_date");
            entity.Property(e => e.ValueNumber).HasColumnName("value_number");
            entity.Property(e => e.ValueText).HasColumnName("value_text");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AddonEndDate, "addon_end_date");

            entity.HasIndex(e => e.AddonResourceId, "addon_resource_id");

            entity.HasIndex(e => e.BillTo, "bill_to");

            entity.HasIndex(e => e.BillingTypeGroupId, "billing_type_group_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.HoldType, "hold_type");

            entity.HasIndex(e => new { e.NextBillDate, e.UserId, e.GroupId }, "idx_user_group_next_bill_date_user_id");

            entity.HasIndex(e => e.JoinDate, "join_date");

            entity.HasIndex(e => e.StartBillingDate, "start_billing_date");

            entity.HasIndex(e => e.StopBillingDate, "stop_billing_date");

            entity.HasIndex(e => e.UgStatus, "ug_status");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivateOn).HasColumnName("activate_on");
            entity.Property(e => e.ActivatedDate).HasColumnName("activated_date");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AddonEndDate).HasColumnName("addon_end_date");
            entity.Property(e => e.AddonResourceId).HasColumnName("addon_resource_id");
            entity.Property(e => e.BillTo).HasColumnName("bill_to");
            entity.Property(e => e.BillToPercent)
                .HasColumnType("float(9,2)")
                .HasColumnName("bill_to_percent");
            entity.Property(e => e.BillToType)
                .HasMaxLength(5)
                .HasDefaultValueSql("'%'")
                .HasColumnName("bill_to_type");
            entity.Property(e => e.BillingTypeGroupId).HasColumnName("billing_type_group_id");
            entity.Property(e => e.CancelOn).HasColumnName("cancel_on");
            entity.Property(e => e.CanceledDate).HasColumnName("canceled_date");
            entity.Property(e => e.CanceledReason)
                .HasMaxLength(255)
                .HasColumnName("canceled_reason");
            entity.Property(e => e.CreditAmount)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnType("float(18,2)")
                .HasColumnName("credit_amount");
            entity.Property(e => e.DiscountAsStatement).HasColumnName("discount_as_statement");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.ExpiredDate).HasColumnName("expired_date");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.HoldFrom).HasColumnName("hold_from");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(255)
                .HasColumnName("hold_reason");
            entity.Property(e => e.HoldTo).HasColumnName("hold_to");
            entity.Property(e => e.HoldType)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("hold_type");
            entity.Property(e => e.HoldValue)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnType("float(9,2)")
                .HasColumnName("hold_value");
            entity.Property(e => e.HoldedDate).HasColumnName("holded_date");
            entity.Property(e => e.HowAdded).HasColumnName("how_added");
            entity.Property(e => e.InactivateOn).HasColumnName("inactivate_on");
            entity.Property(e => e.IsHolded).HasColumnName("is_holded");
            entity.Property(e => e.IsMembershipAddon).HasColumnName("is_membership_addon");
            entity.Property(e => e.IsSecondary).HasColumnName("is_secondary");
            entity.Property(e => e.JoinDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("join_date");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.MapRevenueTo).HasColumnName("map_revenue_to");
            entity.Property(e => e.MembershipDiscount)
                .HasColumnType("float(9,2)")
                .HasColumnName("membership_discount");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.MonthlyActivateOn)
                .HasDefaultValueSql("'1'")
                .HasColumnName("monthly_activate_on");
            entity.Property(e => e.MonthlyBillingType)
                .HasDefaultValueSql("'1'")
                .HasColumnName("monthly_billing_type");
            entity.Property(e => e.MonthlyProrateFrom)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("monthly_prorate_from");
            entity.Property(e => e.MonthlyStartBillingFrom)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("monthly_start_billing_from");
            entity.Property(e => e.NextBillDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("next_bill_date");
            entity.Property(e => e.OverrideEnrollmentFee)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("override_enrollment_fee");
            entity.Property(e => e.OverrideFee)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnType("float(18,2)")
                .HasColumnName("override_fee");
            entity.Property(e => e.ReferedBy).HasColumnName("refered_by");
            entity.Property(e => e.ReferedByType)
                .HasMaxLength(5)
                .HasDefaultValueSql("'%'")
                .HasColumnName("refered_by_type");
            entity.Property(e => e.ReferedByValue)
                .HasColumnType("float(9,2)")
                .HasColumnName("refered_by_value");
            entity.Property(e => e.SoldAt).HasColumnName("sold_at");
            entity.Property(e => e.StartBillingDate).HasColumnName("start_billing_date");
            entity.Property(e => e.StopBillingDate).HasColumnName("stop_billing_date");
            entity.Property(e => e.TotalEnrollmentFee)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("total_enrollment_fee");
            entity.Property(e => e.TotalMembershipFee)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("total_membership_fee");
            entity.Property(e => e.UgStatus)
                .HasDefaultValueSql("'Active'")
                .HasColumnType("enum('Active','Inactive','Suspended','Canceled','Expired','Holded','On Hold','Online Review')")
                .HasColumnName("ug_status");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserGroupHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_history")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DateFrom, "date_from");

            entity.HasIndex(e => e.DateTime, "date_time");

            entity.HasIndex(e => e.DateTo, "date_to");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.Hide, "hide");

            entity.HasIndex(e => e.Holdedminus, "holdedminus");

            entity.HasIndex(e => e.Holdedplus, "holdedplus");

            entity.HasIndex(e => e.IsLastInDay, "is_last_in_day");

            entity.HasIndex(e => e.IsNew, "is_new");

            entity.HasIndex(e => e.MarkIsNew, "mark_is_new");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.HasIndex(e => e.Reactivate, "reactivate");

            entity.HasIndex(e => e.Renewed, "renewed");

            entity.HasIndex(e => e.UgStatus, "ug_status");

            entity.HasIndex(e => e.UgStatusOld, "ug_status_old");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddonResourceId).HasColumnName("addon_resource_id");
            entity.Property(e => e.BillingTypeGroupId).HasColumnName("billing_type_group_id");
            entity.Property(e => e.CancelOn)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("cancel_on");
            entity.Property(e => e.CanceledDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("canceled_date");
            entity.Property(e => e.CanceledReason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("canceled_reason");
            entity.Property(e => e.DateFrom)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("date_from");
            entity.Property(e => e.DateTime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.DateTo)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("date_to");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.ExpiredDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("expired_date");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GroupIdNew).HasColumnName("group_id_new");
            entity.Property(e => e.GroupIdOld).HasColumnName("group_id_old");
            entity.Property(e => e.Hide).HasColumnName("hide");
            entity.Property(e => e.HoldFrom)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("hold_from");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(255)
                .HasColumnName("hold_reason");
            entity.Property(e => e.HoldTo)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("hold_to");
            entity.Property(e => e.HoldType)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("hold_type");
            entity.Property(e => e.HoldValue)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("hold_value");
            entity.Property(e => e.HoldedDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("holded_date");
            entity.Property(e => e.Holdedminus).HasColumnName("holdedminus");
            entity.Property(e => e.Holdedplus).HasColumnName("holdedplus");
            entity.Property(e => e.IsHolded).HasColumnName("is_holded");
            entity.Property(e => e.IsLastInDay)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_last_in_day");
            entity.Property(e => e.IsMembershipAddon).HasColumnName("is_membership_addon");
            entity.Property(e => e.IsNew).HasColumnName("is_new");
            entity.Property(e => e.JoinDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("join_date");
            entity.Property(e => e.Linked)
                .HasColumnType("text")
                .HasColumnName("linked");
            entity.Property(e => e.MarkIsNew).HasColumnName("mark_is_new");
            entity.Property(e => e.MembershipGoals)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("membership_goals");
            entity.Property(e => e.MembershipSales)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("membership_sales");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.NextBillDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("next_bill_date");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Reactivate).HasColumnName("reactivate");
            entity.Property(e => e.ReferedBy).HasColumnName("refered_by");
            entity.Property(e => e.ReferedByType)
                .HasMaxLength(5)
                .HasDefaultValueSql("'%'")
                .HasColumnName("refered_by_type");
            entity.Property(e => e.ReferedByValue)
                .HasPrecision(9, 2)
                .HasColumnName("refered_by_value");
            entity.Property(e => e.ReferralSource)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("referral_source");
            entity.Property(e => e.ReferringMemberId).HasColumnName("referring_member_id");
            entity.Property(e => e.Renewed).HasColumnName("renewed");
            entity.Property(e => e.StartBillingDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("start_billing_date");
            entity.Property(e => e.StopBillingDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("stop_billing_date");
            entity.Property(e => e.TotalEnrollmentFee)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("total_enrollment_fee");
            entity.Property(e => e.TotalMembershipFee)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnName("total_membership_fee");
            entity.Property(e => e.UgStatus)
                .HasDefaultValueSql("'Active'")
                .HasColumnType("enum('Active','Inactive','Suspended','Canceled','Expired','Holded','On Hold','Online Review','Removed')")
                .HasColumnName("ug_status");
            entity.Property(e => e.UgStatusOld)
                .HasDefaultValueSql("'Active'")
                .HasColumnType("enum('Active','Inactive','Suspended','Canceled','Expired','Holded','On Hold','Online Review','Removed')")
                .HasColumnName("ug_status_old");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UtcTimestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("utc_timestamp");
        });

        modelBuilder.Entity<UserLoginAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_login_attempt")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "user_login_attempt_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .HasColumnName("ip");
            entity.Property(e => e.LockCounted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("lock_counted");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserLoginLock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_login_lock")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "user_login_lock_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasColumnName("ip");
            entity.Property(e => e.LockedUntil)
                .HasColumnType("datetime")
                .HasColumnName("locked_until");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_setting")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.IntValue, "int_value");

            entity.HasIndex(e => e.Name, "name").HasAnnotation("MySql:IndexPrefixLength", new[] { 20 });

            entity.HasIndex(e => e.StringValue, "string_value");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArrayValue)
                .HasColumnType("mediumtext")
                .HasColumnName("array_value");
            entity.Property(e => e.FloatValue).HasColumnName("float_value");
            entity.Property(e => e.IntValue).HasColumnName("int_value");
            entity.Property(e => e.LastTrack)
                .HasColumnType("mediumtext")
                .HasColumnName("last_track");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.StringValue)
                .HasDefaultValueSql("''")
                .HasColumnName("string_value");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserStatementPastDue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_statement_past_due")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NeedUpdate, "need_update");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Current)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("current");
            entity.Property(e => e.D120)
                .HasPrecision(12, 2)
                .HasColumnName("d120");
            entity.Property(e => e.D30)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("d30");
            entity.Property(e => e.D60)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("d60");
            entity.Property(e => e.D90)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("d90");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NeedUpdate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("need_update");
            entity.Property(e => e.StatementBalance)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("statement_balance");
            entity.Property(e => e.UnusedCredits)
                .HasPrecision(12, 2)
                .HasColumnName("unused_credits");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
