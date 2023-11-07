using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cgff_connect.logModels;

public partial class CaCgffliveLogContext : DbContext
{
    public CaCgffliveLogContext()
    {
    }

    public CaCgffliveLogContext(DbContextOptions<CaCgffliveLogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AclRule> AclRules { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Charge> Charges { get; set; }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<GiftCertificate> GiftCertificates { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupEntity> GroupEntities { get; set; }

    public virtual DbSet<GroupEntityAccess> GroupEntityAccesses { get; set; }

    public virtual DbSet<GroupEntityAccountingGroup> GroupEntityAccountingGroups { get; set; }

    public virtual DbSet<GroupEntityAdditionalCharge> GroupEntityAdditionalCharges { get; set; }

    public virtual DbSet<GroupEntityBilling> GroupEntityBillings { get; set; }

    public virtual DbSet<GroupEntityDiscount> GroupEntityDiscounts { get; set; }

    public virtual DbSet<GroupEntityMaintenanceFee> GroupEntityMaintenanceFees { get; set; }

    public virtual DbSet<GroupEntityToGroup> GroupEntityToGroups { get; set; }

    public virtual DbSet<GroupEntityToPackage> GroupEntityToPackages { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Payroll> Payrolls { get; set; }

    public virtual DbSet<PayrollLog> PayrollLogs { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleResource> ScheduleResources { get; set; }

    public virtual DbSet<ScheduleRoom> ScheduleRooms { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserBankAccount> UserBankAccounts { get; set; }

    public virtual DbSet<UserContract> UserContracts { get; set; }

    public virtual DbSet<UserCreditCard> UserCreditCards { get; set; }

    public virtual DbSet<UserCustomFieldsValue> UserCustomFieldsValues { get; set; }

    public virtual DbSet<UserCustomRegistrationFieldsValue> UserCustomRegistrationFieldsValues { get; set; }

    public virtual DbSet<UserEvent> UserEvents { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserGroupSubscription> UserGroupSubscriptions { get; set; }

    public virtual DbSet<UserGroupSubscriptionAction> UserGroupSubscriptionActions { get; set; }

    public virtual DbSet<UserGroupSubscriptionBillingOption> UserGroupSubscriptionBillingOptions { get; set; }

    public virtual DbSet<UserGroupSubscriptionCalculatedFee> UserGroupSubscriptionCalculatedFees { get; set; }

    public virtual DbSet<UserGroupSubscriptionCalculatedFeeDetail> UserGroupSubscriptionCalculatedFeeDetails { get; set; }

    public virtual DbSet<UserGroupSubscriptionCyclePrice> UserGroupSubscriptionCyclePrices { get; set; }

    public virtual DbSet<UserGroupSubscriptionHistory> UserGroupSubscriptionHistories { get; set; }

    public virtual DbSet<UserGroupSubscriptionMaintenanceFee> UserGroupSubscriptionMaintenanceFees { get; set; }

    public virtual DbSet<UserGroupSubscriptionPrice> UserGroupSubscriptionPrices { get; set; }

    public virtual DbSet<UserGroupSubscriptionPriceDetail> UserGroupSubscriptionPriceDetails { get; set; }

    public virtual DbSet<UserGroupSubscriptionSale> UserGroupSubscriptionSales { get; set; }

    public virtual DbSet<UserGroupSubscriptionStatus> UserGroupSubscriptionStatuses { get; set; }

    public virtual DbSet<UserOffsiteAddress> UserOffsiteAddresses { get; set; }

    public virtual DbSet<UserPackage> UserPackages { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<VwUser> VwUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql(Connect.ConnectToRemoteLog(), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.4-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<AclRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("acl_rule")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.RuleId, "rule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.RuleId).HasColumnName("rule_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("address")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.AddressId, "address_id");

            entity.HasIndex(e => e.CountryId, "country_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.StateId, "state_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(40)
                .HasColumnName("postal_code");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attendance")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.AttendanceId, "attendance_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ResourceId, "resource_id");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AType)
                .HasColumnType("enum('trainer','trainee')")
                .HasColumnName("a_type");
            entity.Property(e => e.Attendance1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'attended'")
                .HasColumnName("attendance");
            entity.Property(e => e.AttendanceId).HasColumnName("attendance_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Charge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charge")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ChargeId, "charge_id");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ModifiedDateIndex, "modified_date_index");

            entity.HasIndex(e => e.Type, "type");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingGroupId).HasColumnName("accounting_group_id");
            entity.Property(e => e.ChargeId).HasColumnName("charge_id");
            entity.Property(e => e.EftId).HasColumnName("eft_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedDateIndex).HasColumnName("modified_date_index");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PriceFinal)
                .HasColumnType("float(18,2)")
                .HasColumnName("price_final");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("club")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ClubId, "club_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClubId).HasColumnName("club_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("contract")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("event")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.AccGroupId, "acc_group_id");

            entity.HasIndex(e => e.ComponentId, "component_id");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.EventTypeId, "event_type_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccGroupId).HasColumnName("acc_group_id");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GiftCertificate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gift_certificate")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EntityId, "entity_id");

            entity.HasIndex(e => e.GiftcertificateId, "giftcertificate_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.Receiver, "receiver");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(9, 3)
                .HasColumnName("amount");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.GiftcertificateId).HasColumnName("giftcertificate_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.OriginalAmount)
                .HasPrecision(9, 3)
                .HasColumnName("original_amount");
            entity.Property(e => e.Receiver).HasColumnName("receiver");
            entity.Property(e => e.RefundedAmount)
                .HasPrecision(12, 2)
                .HasColumnName("refunded_amount");
            entity.Property(e => e.SharedWithLinked).HasColumnName("shared_with_linked");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityId, "group_entity_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityId).HasColumnName("group_entity_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_access")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityAccessId, "group_entity_access_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityAccessId).HasColumnName("group_entity_access_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityAccountingGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_accounting_group")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityAccountingGroupId, "group_entity_accounting_group_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityAccountingGroupId).HasColumnName("group_entity_accounting_group_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityAdditionalCharge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_additional_charge")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityAdditionalChargeId, "group_entity_additional_charge_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityAdditionalChargeId).HasColumnName("group_entity_additional_charge_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityBilling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_billing")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityBillingId, "group_entity_billing_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityBillingId).HasColumnName("group_entity_billing_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_discount")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityDiscountId, "group_entity_discount_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityDiscountId).HasColumnName("group_entity_discount_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityMaintenanceFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_maintenance_fee")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityMaintenanceFee1, "group_entity_maintenance_fee");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityMaintenanceFee1).HasColumnName("group_entity_maintenance_fee");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityToGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_to_group")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityToGroupId, "group_entity_to_group_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityToGroupId).HasColumnName("group_entity_to_group_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<GroupEntityToPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("group_entity_to_package")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupEntityToPackageId, "group_entity_to_package_id");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupEntityToPackageId).HasColumnName("group_entity_to_package_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("history")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.LogTransactionId, "log_transaction_id").IsUnique();

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("enum('create','edit','delete','move','sale','attendance')")
                .HasColumnName("action");
            entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");
            entity.Property(e => e.KnownResource).HasColumnName("known_resource");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.Title)
                .HasMaxLength(128)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("instructor")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.InstructorId, "instructor_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("membership")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateFrom).HasColumnName("date_from");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.MembershipId).HasColumnName("membership_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payment")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => new { e.ModifiedDate, e.Type }, "idx_payment_modified_date_type");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ModifiedDateIndex, "modified_date_index");

            entity.HasIndex(e => e.PaymentId, "payment_id");

            entity.HasIndex(e => e.Type, "type");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("float(18,2)")
                .HasColumnName("amount");
            entity.Property(e => e.ChargeId).HasColumnName("charge_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedDateIndex).HasColumnName("modified_date_index");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Payroll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payroll")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.PayrollId, "payroll_id");

            entity.HasIndex(e => e.PayrollType, "payroll_type");

            entity.HasIndex(e => e.StaffId, "staff_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PayrollId).HasColumnName("payroll_id");
            entity.Property(e => e.PayrollType)
                .HasDefaultValueSql("'custom'")
                .HasColumnName("payroll_type");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<PayrollLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payroll_log")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.PayrollLogId, "payroll_log_id");

            entity.HasIndex(e => e.PayrollLogType, "payroll_log_type");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.HasIndex(e => e.StaffId, "staff_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(9, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PayrollLogId).HasColumnName("payroll_log_id");
            entity.Property(e => e.PayrollLogType).HasColumnName("payroll_log_type");
            entity.Property(e => e.RowType).HasColumnName("row_type");
            entity.Property(e => e.ScheduleDate).HasColumnName("schedule_date");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("phone")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PhoneId).HasColumnName("phone_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedule")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.TimeBegin)
                .HasColumnType("time")
                .HasColumnName("time_begin");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("time")
                .HasColumnName("time_end");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<ScheduleResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedule_resource")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ResourceId, "resource_id");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<ScheduleRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedule_room")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.RoomId, "room_id");

            entity.HasIndex(e => e.ScheduleId, "schedule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("transaction")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.ModifiedDateIndex, "modified_date_index");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.HasIndex(e => e.Type, "type");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsEft)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_eft");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedDateIndex).HasColumnName("modified_date_index");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Result)
                .HasMaxLength(20)
                .HasColumnName("result");
            entity.Property(e => e.Total)
                .HasColumnType("float(18,2)")
                .HasColumnName("total");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedBy, "modified_by");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserBankAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_bank_account")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.RowId, "row_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.RowId).HasColumnName("row_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_contract")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserContractId, "user_contract_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserContractId).HasColumnName("user_contract_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserCreditCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_credit_card")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.RowId, "row_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.RowId).HasColumnName("row_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserCustomFieldsValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_custom_fields_values")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FieldId).HasColumnName("field_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserCustomRegistrationFieldsValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_custom_registration_fields_value")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserCustomFieldsId).HasColumnName("user_custom_fields_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_event")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EventId, "event_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomPercent)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnType("float(5,2)")
                .HasColumnName("custom_percent");
            entity.Property(e => e.CustomPrice)
                .HasDefaultValueSql("'-1.00'")
                .HasColumnType("float(18,2)")
                .HasColumnName("custom_price");
            entity.Property(e => e.CustomPriceType)
                .HasDefaultValueSql("'per_hour'")
                .HasColumnType("enum('per_hour','full','season')")
                .HasColumnName("custom_price_type");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.EventTotalCharge)
                .HasColumnType("float(18,2)")
                .HasColumnName("event_total_charge");
            entity.Property(e => e.EventTotalPaid)
                .HasColumnType("float(18,2)")
                .HasColumnName("event_total_paid");
            entity.Property(e => e.IsMakeup).HasColumnName("is_makeup");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Prorate).HasColumnName("prorate");
            entity.Property(e => e.RegDate).HasColumnName("reg_date");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.NextBillDate).HasColumnName("next_bill_date");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UgStatus)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("ug_status");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserGroupSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionId, "user_group_subscription_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionId).HasColumnName("user_group_subscription_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_action")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionActionId, "user_group_subscription_action_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionActionId).HasColumnName("user_group_subscription_action_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionBillingOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_billing_option")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionCalculatedFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_calculated_fee")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.HasIndex(e => e.UserGroupSubscriptionCalculatedFeeId, "user_group_subscription_calculated_fee_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
            entity.Property(e => e.UserGroupSubscriptionCalculatedFeeId).HasColumnName("user_group_subscription_calculated_fee_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionCalculatedFeeDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_calculated_fee_detail")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionCalculatedFeeDetailId, "user_group_subscription_calculated_fee_detail_id");

            entity.HasIndex(e => e.UserGroupSubscriptionCalculatedFeeId, "user_group_subscription_calculated_fee_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionCalculatedFeeDetailId).HasColumnName("user_group_subscription_calculated_fee_detail_id");
            entity.Property(e => e.UserGroupSubscriptionCalculatedFeeId).HasColumnName("user_group_subscription_calculated_fee_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionCyclePrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_cycle_price")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.HasIndex(e => e.UserGroupSubscriptionCyclePriceId, "user_group_subscription_cycle_price_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
            entity.Property(e => e.UserGroupSubscriptionCyclePriceId).HasColumnName("user_group_subscription_cycle_price_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_history")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.SubscriptionId, "subscription_id");

            entity.HasIndex(e => e.UserGroupSubscriptionHistoryId, "user_group_subscription_history_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionHistoryId).HasColumnName("user_group_subscription_history_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionMaintenanceFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_maintenance_fee")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.HasIndex(e => e.UserGroupSubscriptionMaintenanceFeeId, "user_group_subscription_maintenance_fee_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
            entity.Property(e => e.UserGroupSubscriptionMaintenanceFeeId).HasColumnName("user_group_subscription_maintenance_fee_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_price")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.HasIndex(e => e.UserGroupSubscriptionPriceId, "user_group_subscription_price_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
            entity.Property(e => e.UserGroupSubscriptionPriceId).HasColumnName("user_group_subscription_price_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionPriceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_price_detail")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.HasIndex(e => e.UserGroupSubscriptionPriceDetailId, "user_group_subscription_price_detail_id");

            entity.HasIndex(e => e.UserGroupSubscriptionPriceId, "user_group_subscription_price_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
            entity.Property(e => e.UserGroupSubscriptionPriceDetailId).HasColumnName("user_group_subscription_price_detail_id");
            entity.Property(e => e.UserGroupSubscriptionPriceId).HasColumnName("user_group_subscription_price_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_sales")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionBillingOptionId, "user_group_subscription_billing_option_id");

            entity.HasIndex(e => e.UserGroupSubscriptionSalesId, "user_group_subscription_sales_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionBillingOptionId).HasColumnName("user_group_subscription_billing_option_id");
            entity.Property(e => e.UserGroupSubscriptionSalesId).HasColumnName("user_group_subscription_sales_id");
        });

        modelBuilder.Entity<UserGroupSubscriptionStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_group_subscription_status")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserGroupSubscriptionStatusId, "user_group_subscription_status_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserGroupSubscriptionStatusId).HasColumnName("user_group_subscription_status_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserOffsiteAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_offsite_address")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_package")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ComponentId, "component_id");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.PackageId, "package_id");

            entity.HasIndex(e => e.StaffId, "staff_id");

            entity.HasIndex(e => e.UpackageId, "upackage_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.Count)
                .HasColumnType("float(18,2)")
                .HasColumnName("count");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet).HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpackageId).HasColumnName("upackage_id");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_setting")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.ModifiedDate, "modified_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedByIntranet)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified_by_intranet");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<VwUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_user");

            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.LogTransactionId)
                .HasMaxLength(32)
                .HasColumnName("log_transaction_id")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewValues)
                .HasColumnType("mediumtext")
                .HasColumnName("new_values")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.OldValues)
                .HasColumnType("mediumtext")
                .HasColumnName("old_values")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Track)
                .HasColumnType("mediumtext")
                .HasColumnName("track")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Type)
                .HasColumnType("enum('add','modify','remove')")
                .HasColumnName("type")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.UpdatedColumns)
                .HasColumnType("mediumtext")
                .HasColumnName("updated_columns")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
