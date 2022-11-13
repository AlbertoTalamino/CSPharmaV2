using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

public partial class CspharmaInformationalContext : DbContext
{
    public CspharmaInformationalContext()
    {
    }

    public CspharmaInformationalContext(DbContextOptions<CspharmaInformationalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DlkCatAccEmployee> DlkCatAccEmployees { get; set; }

    public virtual DbSet<TdcCatDistributionLine> TdcCatDistributionLines { get; set; }

    public virtual DbSet<TdcCatOrderDevolutionStatus> TdcCatOrderDevolutionStatuses { get; set; }

    public virtual DbSet<TdcCatOrderPaymentStatus> TdcCatOrderPaymentStatuses { get; set; }

    public virtual DbSet<TdcCatOrderShipmentStatus> TdcCatOrderShipmentStatuses { get; set; }

    public virtual DbSet<TdcTchOrderStatus> TdcTchOrderStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=cspharma_informational;User Id=postgres;Password=altair");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DlkCatAccEmployee>(entity =>
        {
            entity.HasKey(e => e.CodEmployee).HasName("dlk_cat_acc_employees_pkey");

            entity.ToTable("dlk_cat_acc_employees", "dlk_informacional");

            entity.Property(e => e.CodEmployee)
                .HasMaxLength(7)
                .HasComment("Code that univocally identifies the employee, consisting of 7 alphanumericals.")
                .HasColumnName("cod_employee");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("Unique identifier of the employee in the system.")
                .HasColumnName("id");
            entity.Property(e => e.KeyEmployee)
                .HasComment("Employee's access code.")
                .HasColumnType("character varying")
                .HasColumnName("key_employee");
            entity.Property(e => e.LevelAccessEmployed)
                .HasDefaultValueSql("2")
                .HasComment("Level of employee access.")
                .HasColumnName("level_access_employed");
            entity.Property(e => e.MdDate)
                .HasComment("Date on which is group is defined insertion.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_date");
            entity.Property(e => e.MdUuid)
                .HasComment("Metadata metadata code indicating the group insertion group to which which belongs to record belongs to.")
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");
        });

        modelBuilder.Entity<TdcCatDistributionLine>(entity =>
        {
            entity.HasKey(e => e.CodLine).HasName("tdc_cat_distribution_lines_pkey");

            entity.ToTable("tdc_cat_distribution_lines", "dwh_controltower", tb => tb.HasComment("Catalogue type entity that collects the information of the distribution lines."));

            entity.Property(e => e.CodLine)
                .HasComment("Code uniquely identifying the road distribution line followed by the consignment:\ncodprovince-codmunicipality-codistrict.")
                .HasColumnType("character varying")
                .HasColumnName("cod_line");
            entity.Property(e => e.CodMunicipality)
                .HasComment("Code that uniquely identifies the municipality.")
                .HasColumnType("character varying")
                .HasColumnName("cod_municipality");
            entity.Property(e => e.CodNeighbourhood)
                .HasComment("Code that uniquely identifies the neighbourhood.")
                .HasColumnType("character varying")
                .HasColumnName("cod_neighbourhood");
            entity.Property(e => e.CodProvince)
                .HasComment("Code that uniquely identifies the province.")
                .HasColumnType("character varying")
                .HasColumnName("cod_province");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('dwh_controltower.tdc_cat_lineas_distribucion_id_seq'::regclass)")
                .HasComment("Unique identifier of the distribution line in the system.")
                .HasColumnName("id");
            entity.Property(e => e.MdDate)
                .HasComment("Date on which the insertion group is defined.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_date");
            entity.Property(e => e.MdUuid)
                .HasComment("Metadata code indicating the insertion group to which the record belongs.")
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");
        });

        modelBuilder.Entity<TdcCatOrderDevolutionStatus>(entity =>
        {
            entity.HasKey(e => e.CodDevolutionStatus).HasName("tdc_cat_order_devolution_status_pkey");

            entity.ToTable("tdc_cat_order_devolution_status", "dwh_controltower", tb => tb.HasComment("Catalogue type entity that collects the status of devolutions."));

            entity.Property(e => e.CodDevolutionStatus)
                .HasComment("Code that uniquely identifies the return status of an order.")
                .HasColumnType("character varying")
                .HasColumnName("cod_devolution_status");
            entity.Property(e => e.DesDevolutionStatus)
                .HasComment("Description of the return status of the order.")
                .HasColumnType("character varying")
                .HasColumnName("des_devolution_status");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('dwh_controltower.tdc_cat_estados_devolucion_pedido_id_seq'::regclass)")
                .HasComment("Unique identifier of the return status of the order in the system.")
                .HasColumnName("id");
            entity.Property(e => e.MdDate)
                .HasComment("Date on which the insertion group is defined.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_date");
            entity.Property(e => e.MdUuid)
                .HasComment("Metadata code indicating the insertion group to which the record belongs.")
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");
        });

        modelBuilder.Entity<TdcCatOrderPaymentStatus>(entity =>
        {
            entity.HasKey(e => e.CodPaymentStatus).HasName("tdc_cat_order_payment_status_pkey");

            entity.ToTable("tdc_cat_order_payment_status", "dwh_controltower", tb => tb.HasComment("Catalogue type entity that collects the information of the playments."));

            entity.Property(e => e.CodPaymentStatus)
                .HasComment("Code that uniquely identifies the payment status of an order.")
                .HasColumnType("character varying")
                .HasColumnName("cod_payment_status");
            entity.Property(e => e.DesPaymentStatus)
                .HasComment("Description of the payment status of the order.")
                .HasColumnType("character varying")
                .HasColumnName("des_payment_status");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('dwh_controltower.tdc_cat_estados_pago_pedido_id_seq'::regclass)")
                .HasComment("Unique identifier of the payment status of the order in the system.")
                .HasColumnName("id");
            entity.Property(e => e.MdDate)
                .HasComment("Date on which the insertion group is defined.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_date");
            entity.Property(e => e.MdUuid)
                .HasComment("Metadata code indicating the insertion group to which the record belongs.")
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");
        });

        modelBuilder.Entity<TdcCatOrderShipmentStatus>(entity =>
        {
            entity.HasKey(e => e.CodShipmentStatus).HasName("tdc_cat_order_shipment_status_pkey");

            entity.ToTable("tdc_cat_order_shipment_status", "dwh_controltower", tb => tb.HasComment("Catalogue type entity that collects the status of the shipments."));

            entity.Property(e => e.CodShipmentStatus)
                .HasComment("Code that uniquely identifies the shipping status of an order.")
                .HasColumnType("character varying")
                .HasColumnName("cod_shipment_status");
            entity.Property(e => e.DesShipmentStatus)
                .HasComment("Description of the shipping status of the order.")
                .HasColumnType("character varying")
                .HasColumnName("des_shipment_status");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('dwh_controltower.tdc_cat_estados_envio_pedido_id_seq'::regclass)")
                .HasComment("Unique identifier of the shipping status of the order in the system.")
                .HasColumnName("id");
            entity.Property(e => e.MdDate)
                .HasComment("Date on which the insertion group is defined.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_date");
            entity.Property(e => e.MdUuid)
                .HasComment("Metadata code indicating the insertion group to which the record belongs.")
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");
        });

        modelBuilder.Entity<TdcTchOrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tdc_tch_order_status_pkey");

            entity.ToTable("tdc_tch_order_status", "dwh_controltower", tb => tb.HasComment("Entity type fact which stores order information."));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('dwh_controltower.tdc_tch_estado_pedidos_id_seq'::regclass)")
                .HasComment("Unique order identifier in the system.")
                .HasColumnName("id");
            entity.Property(e => e.CodDevolutionStatus)
                .HasComment("Code uniquely identifying the return status of an order.")
                .HasColumnType("character varying")
                .HasColumnName("cod_devolution_status");
            entity.Property(e => e.CodLine)
                .HasComment("Code uniquely identifying the road distribution line followed by the consignment:\ncodprovince-codmunicipality-codistrict.")
                .HasColumnType("character varying")
                .HasColumnName("cod_line");
            entity.Property(e => e.CodOrder)
                .HasComment("Code that uniquely identifies an order. It is constructed with:\nprovince-codpharmacy-id.")
                .HasColumnType("character varying")
                .HasColumnName("cod_order");
            entity.Property(e => e.CodOrderStatus)
                .HasComment("Code that uniquely identifies the shipping status of an order.")
                .HasColumnType("character varying")
                .HasColumnName("cod_order_status");
            entity.Property(e => e.CodPaymentStatus)
                .HasComment("Code that uniquely identifies the payment status of an order.")
                .HasColumnType("character varying")
                .HasColumnName("cod_payment_status");
            entity.Property(e => e.MdDate)
                .HasComment("Date on which the insertion group is defined.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_date");
            entity.Property(e => e.MdUuid)
                .HasComment("Metadata code indicating the insertion group to which the record belongs.")
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");

            entity.HasOne(d => d.CodDevolutionStatusNavigation).WithMany(p => p.TdcTchOrderStatuses)
                .HasForeignKey(d => d.CodDevolutionStatus)
                .HasConstraintName("cod_devolution_status_fk");

            entity.HasOne(d => d.CodLineNavigation).WithMany(p => p.TdcTchOrderStatuses)
                .HasForeignKey(d => d.CodLine)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cod_line_fk");

            entity.HasOne(d => d.CodOrderStatusNavigation).WithMany(p => p.TdcTchOrderStatuses)
                .HasForeignKey(d => d.CodOrderStatus)
                .HasConstraintName("cod_shipment_status_fk");

            entity.HasOne(d => d.CodPaymentStatusNavigation).WithMany(p => p.TdcTchOrderStatuses)
                .HasForeignKey(d => d.CodPaymentStatus)
                .HasConstraintName("cod_payment_status_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
