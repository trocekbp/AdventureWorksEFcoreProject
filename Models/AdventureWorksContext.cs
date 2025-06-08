﻿using System;
using System.Collections.Generic;
using AdventureWorks.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Models;

public partial class AdventureWorksContext : DbContext
{
    public AdventureWorksContext()
    {
    }

    public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AWBuildVersion> AWBuildVersions { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressType> AddressTypes { get; set; }

    public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

    public virtual DbSet<BusinessEntity> BusinessEntities { get; set; }

    public virtual DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    public virtual DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<CountryRegion> CountryRegions { get; set; }

    public virtual DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

    public virtual DbSet<CreditCard> CreditCards { get; set; }

    public virtual DbSet<Culture> Cultures { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyRate> CurrencyRates { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    public virtual DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Illustration> Illustrations { get; set; }

    public virtual DbSet<JobCandidate> JobCandidates { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Password> Passwords { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PersonCreditCard> PersonCreditCards { get; set; }

    public virtual DbSet<PersonPhone> PersonPhones { get; set; }

    public virtual DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductCostHistory> ProductCostHistories { get; set; }

    public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }

    public virtual DbSet<ProductInventory> ProductInventories { get; set; }

    public virtual DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }

    public virtual DbSet<ProductModel> ProductModels { get; set; }

    public virtual DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }

    public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    public virtual DbSet<ProductPhoto> ProductPhotos { get; set; }

    public virtual DbSet<ProductProductPhoto> ProductProductPhotos { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<ProductSubcategory> ProductSubcategories { get; set; }

    public virtual DbSet<ProductVendor> ProductVendors { get; set; }

    public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

    public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    public virtual DbSet<SalesPerson> SalesPeople { get; set; }

    public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

    public virtual DbSet<SalesReason> SalesReasons { get; set; }

    public virtual DbSet<SalesTaxRate> SalesTaxRates { get; set; }

    public virtual DbSet<SalesTerritory> SalesTerritories { get; set; }

    public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

    public virtual DbSet<ScrapReason> ScrapReasons { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<ShipMethod> ShipMethods { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<SpecialOffer> SpecialOffers { get; set; }

    public virtual DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    public virtual DbSet<StateProvince> StateProvinces { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }

    public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }

    public virtual DbSet<UnitMeasure> UnitMeasures { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }

    public virtual DbSet<vAdditionalContactInfo> vAdditionalContactInfos { get; set; }

    public virtual DbSet<vEmployee> vEmployees { get; set; }

    public virtual DbSet<vEmployeeDepartment> vEmployeeDepartments { get; set; }

    public virtual DbSet<vEmployeeDepartmentHistory> vEmployeeDepartmentHistories { get; set; }

    public virtual DbSet<vIndividualCustomer> vIndividualCustomers { get; set; }

    public virtual DbSet<vJobCandidate> vJobCandidates { get; set; }

    public virtual DbSet<vJobCandidateEducation> vJobCandidateEducations { get; set; }

    public virtual DbSet<vJobCandidateEmployment> vJobCandidateEmployments { get; set; }

    public virtual DbSet<vPersonDemographic> vPersonDemographics { get; set; }

    public virtual DbSet<vProductAndDescription> vProductAndDescriptions { get; set; }

    public virtual DbSet<vProductModelCatalogDescription> vProductModelCatalogDescriptions { get; set; }

    public virtual DbSet<vProductModelInstruction> vProductModelInstructions { get; set; }

    public virtual DbSet<vSalesPerson> vSalesPeople { get; set; }

    public virtual DbSet<vSalesPersonSalesByFiscalYear> vSalesPersonSalesByFiscalYears { get; set; }

    public virtual DbSet<vStateProvinceCountryRegion> vStateProvinceCountryRegions { get; set; }

    public virtual DbSet<vStoreWithAddress> vStoreWithAddresses { get; set; }

    public virtual DbSet<vStoreWithContact> vStoreWithContacts { get; set; }

    public virtual DbSet<vStoreWithDemographic> vStoreWithDemographics { get; set; }

    public virtual DbSet<vVendorWithAddress> vVendorWithAddresses { get; set; }

    public virtual DbSet<vVendorWithContact> vVendorWithContacts { get; set; }

    public  virtual DbSet<CriticalStockViewDTO> CriticalStocks { get; set; } //w celu pobrania raportu stanów magazynpwych

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=AdventureWorks;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AWBuildVersion>(entity =>
        {
            entity.HasKey(e => e.SystemInformationID).HasName("PK_AWBuildVersion_SystemInformationID");

            entity.ToTable("AWBuildVersion", tb => tb.HasComment("Current version number of the AdventureWorks 2016 sample database. "));

            entity.Property(e => e.SystemInformationID)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key for AWBuildVersion records.");
            entity.Property(e => e.Database_Version)
                .HasMaxLength(25)
                .HasComment("Version number of the database in 9.yy.mm.dd.00 format.")
                .HasColumnName("Database Version");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.VersionDate)
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressID).HasName("PK_Address_AddressID");

            entity.ToTable("Address", "Person", tb => tb.HasComment("Street address information for customers, employees, and vendors."));

            entity.HasIndex(e => e.rowguid, "AK_Address_rowguid").IsUnique();

            entity.HasIndex(e => new { e.AddressLine1, e.AddressLine2, e.City, e.StateProvinceID, e.PostalCode }, "IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode").IsUnique();

            entity.HasIndex(e => e.StateProvinceID, "IX_Address_StateProvinceID");

            entity.Property(e => e.AddressID).HasComment("Primary key for Address records.");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(60)
                .HasComment("First street address line.");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(60)
                .HasComment("Second street address line.");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasComment("Name of the city.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .HasComment("Postal code for the street address.");
            entity.Property(e => e.StateProvinceID).HasComment("Unique identification number for the state or province. Foreign key to StateProvince table.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.StateProvince).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StateProvinceID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AddressType>(entity =>
        {
            entity.HasKey(e => e.AddressTypeID).HasName("PK_AddressType_AddressTypeID");

            entity.ToTable("AddressType", "Person", tb => tb.HasComment("Types of addresses stored in the Address table. "));

            entity.HasIndex(e => e.Name, "AK_AddressType_Name").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_AddressType_rowguid").IsUnique();

            entity.Property(e => e.AddressTypeID).HasComment("Primary key for AddressType records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Address type description. For example, Billing, Home, or Shipping.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<BillOfMaterial>(entity =>
        {
            entity.HasKey(e => e.BillOfMaterialsID)
                .HasName("PK_BillOfMaterials_BillOfMaterialsID")
                .IsClustered(false);

            entity.ToTable("BillOfMaterials", "Production", tb => tb.HasComment("Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components."));

            entity.HasIndex(e => new { e.ProductAssemblyID, e.ComponentID, e.StartDate }, "AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.UnitMeasureCode, "IX_BillOfMaterials_UnitMeasureCode");

            entity.Property(e => e.BillOfMaterialsID).HasComment("Primary key for BillOfMaterials records.");
            entity.Property(e => e.BOMLevel).HasComment("Indicates the depth the component is from its parent (AssemblyID).");
            entity.Property(e => e.ComponentID).HasComment("Component identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.EndDate)
                .HasComment("Date the component stopped being used in the assembly item.")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PerAssemblyQty)
                .HasDefaultValueSql("((1.00))")
                .HasComment("Quantity of the component needed to create the assembly.")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductAssemblyID).HasComment("Parent product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date the component started being used in the assembly item.")
                .HasColumnType("datetime");
            entity.Property(e => e.UnitMeasureCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("Standard code identifying the unit of measure for the quantity.");

            entity.HasOne(d => d.Component).WithMany(p => p.BillOfMaterialComponents)
                .HasForeignKey(d => d.ComponentID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductAssembly).WithMany(p => p.BillOfMaterialProductAssemblies).HasForeignKey(d => d.ProductAssemblyID);

            entity.HasOne(d => d.UnitMeasureCodeNavigation).WithMany(p => p.BillOfMaterials)
                .HasForeignKey(d => d.UnitMeasureCode)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<BusinessEntity>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_BusinessEntity_BusinessEntityID");

            entity.ToTable("BusinessEntity", "Person", tb => tb.HasComment("Source of the ID that connects vendors, customers, and employees with address and contact information."));

            entity.HasIndex(e => e.rowguid, "AK_BusinessEntity_rowguid").IsUnique();

            entity.Property(e => e.BusinessEntityID).HasComment("Primary key for all customers, vendors, and employees.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<BusinessEntityAddress>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.AddressID, e.AddressTypeID }).HasName("PK_BusinessEntityAddress_BusinessEntityID_AddressID_AddressTypeID");

            entity.ToTable("BusinessEntityAddress", "Person", tb => tb.HasComment("Cross-reference table mapping customers, vendors, and employees to their addresses."));

            entity.HasIndex(e => e.rowguid, "AK_BusinessEntityAddress_rowguid").IsUnique();

            entity.HasIndex(e => e.AddressID, "IX_BusinessEntityAddress_AddressID");

            entity.HasIndex(e => e.AddressTypeID, "IX_BusinessEntityAddress_AddressTypeID");

            entity.Property(e => e.BusinessEntityID).HasComment("Primary key. Foreign key to BusinessEntity.BusinessEntityID.");
            entity.Property(e => e.AddressID).HasComment("Primary key. Foreign key to Address.AddressID.");
            entity.Property(e => e.AddressTypeID).HasComment("Primary key. Foreign key to AddressType.AddressTypeID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.Address).WithMany(p => p.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.AddressType).WithMany(p => p.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressTypeID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.BusinessEntityAddresses)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<BusinessEntityContact>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.PersonID, e.ContactTypeID }).HasName("PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID");

            entity.ToTable("BusinessEntityContact", "Person", tb => tb.HasComment("Cross-reference table mapping stores, vendors, and employees to people"));

            entity.HasIndex(e => e.rowguid, "AK_BusinessEntityContact_rowguid").IsUnique();

            entity.HasIndex(e => e.ContactTypeID, "IX_BusinessEntityContact_ContactTypeID");

            entity.HasIndex(e => e.PersonID, "IX_BusinessEntityContact_PersonID");

            entity.Property(e => e.BusinessEntityID).HasComment("Primary key. Foreign key to BusinessEntity.BusinessEntityID.");
            entity.Property(e => e.PersonID).HasComment("Primary key. Foreign key to Person.BusinessEntityID.");
            entity.Property(e => e.ContactTypeID).HasComment("Primary key.  Foreign key to ContactType.ContactTypeID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.BusinessEntityContacts)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ContactType).WithMany(p => p.BusinessEntityContacts)
                .HasForeignKey(d => d.ContactTypeID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany(p => p.BusinessEntityContacts)
                .HasForeignKey(d => d.PersonID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.HasKey(e => e.ContactTypeID).HasName("PK_ContactType_ContactTypeID");

            entity.ToTable("ContactType", "Person", tb => tb.HasComment("Lookup table containing the types of business entity contacts."));

            entity.HasIndex(e => e.Name, "AK_ContactType_Name").IsUnique();

            entity.Property(e => e.ContactTypeID).HasComment("Primary key for ContactType records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Contact type description.");
        });

        modelBuilder.Entity<CountryRegion>(entity =>
        {
            entity.HasKey(e => e.CountryRegionCode).HasName("PK_CountryRegion_CountryRegionCode");

            entity.ToTable("CountryRegion", "Person", tb => tb.HasComment("Lookup table containing the ISO standard codes for countries and regions."));

            entity.HasIndex(e => e.Name, "AK_CountryRegion_Name").IsUnique();

            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(3)
                .HasComment("ISO standard code for countries and regions.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Country or region name.");
        });

        modelBuilder.Entity<CountryRegionCurrency>(entity =>
        {
            entity.HasKey(e => new { e.CountryRegionCode, e.CurrencyCode }).HasName("PK_CountryRegionCurrency_CountryRegionCode_CurrencyCode");

            entity.ToTable("CountryRegionCurrency", "Sales", tb => tb.HasComment("Cross-reference table mapping ISO currency codes to a country or region."));

            entity.HasIndex(e => e.CurrencyCode, "IX_CountryRegionCurrency_CurrencyCode");

            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(3)
                .HasComment("ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("ISO standard currency code. Foreign key to Currency.CurrencyCode.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.CountryRegionCurrencies)
                .HasForeignKey(d => d.CountryRegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.CountryRegionCurrencies)
                .HasForeignKey(d => d.CurrencyCode)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.HasKey(e => e.CreditCardID).HasName("PK_CreditCard_CreditCardID");

            entity.ToTable("CreditCard", "Sales", tb => tb.HasComment("Customer credit card information."));

            entity.HasIndex(e => e.CardNumber, "AK_CreditCard_CardNumber").IsUnique();

            entity.Property(e => e.CreditCardID).HasComment("Primary key for CreditCard records.");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(25)
                .HasComment("Credit card number.");
            entity.Property(e => e.CardType)
                .HasMaxLength(50)
                .HasComment("Credit card name.");
            entity.Property(e => e.ExpMonth).HasComment("Credit card expiration month.");
            entity.Property(e => e.ExpYear).HasComment("Credit card expiration year.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Culture>(entity =>
        {
            entity.HasKey(e => e.CultureID).HasName("PK_Culture_CultureID");

            entity.ToTable("Culture", "Production", tb => tb.HasComment("Lookup table containing the languages in which some AdventureWorks data is stored."));

            entity.HasIndex(e => e.Name, "AK_Culture_Name").IsUnique();

            entity.Property(e => e.CultureID)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasComment("Primary key for Culture records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Culture description.");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyCode).HasName("PK_Currency_CurrencyCode");

            entity.ToTable("Currency", "Sales", tb => tb.HasComment("Lookup table containing standard ISO currencies."));

            entity.HasIndex(e => e.Name, "AK_Currency_Name").IsUnique();

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("The ISO code for the Currency.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Currency name.");
        });

        modelBuilder.Entity<CurrencyRate>(entity =>
        {
            entity.HasKey(e => e.CurrencyRateID).HasName("PK_CurrencyRate_CurrencyRateID");

            entity.ToTable("CurrencyRate", "Sales", tb => tb.HasComment("Currency exchange rates."));

            entity.HasIndex(e => new { e.CurrencyRateDate, e.FromCurrencyCode, e.ToCurrencyCode }, "AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode").IsUnique();

            entity.Property(e => e.CurrencyRateID).HasComment("Primary key for CurrencyRate records.");
            entity.Property(e => e.AverageRate)
                .HasComment("Average exchange rate for the day.")
                .HasColumnType("money");
            entity.Property(e => e.CurrencyRateDate)
                .HasComment("Date and time the exchange rate was obtained.")
                .HasColumnType("datetime");
            entity.Property(e => e.EndOfDayRate)
                .HasComment("Final exchange rate for the day.")
                .HasColumnType("money");
            entity.Property(e => e.FromCurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("Exchange rate was converted from this currency code.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.ToCurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("Exchange rate was converted to this currency code.");

            entity.HasOne(d => d.FromCurrencyCodeNavigation).WithMany(p => p.CurrencyRateFromCurrencyCodeNavigations)
                .HasForeignKey(d => d.FromCurrencyCode)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToCurrencyCodeNavigation).WithMany(p => p.CurrencyRateToCurrencyCodeNavigations)
                .HasForeignKey(d => d.ToCurrencyCode)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerID).HasName("PK_Customer_CustomerID");

            entity.ToTable("Customer", "Sales", tb => tb.HasComment("Current customer information. Also see the Person and Store tables."));

            entity.HasIndex(e => e.AccountNumber, "AK_Customer_AccountNumber").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_Customer_rowguid").IsUnique();

            entity.HasIndex(e => e.TerritoryID, "IX_Customer_TerritoryID");

            entity.Property(e => e.CustomerID).HasComment("Primary key.");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComputedColumnSql("(isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),''))", false)
                .HasComment("Unique number identifying the customer assigned by the accounting system.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PersonID).HasComment("Foreign key to Person.BusinessEntityID");
            entity.Property(e => e.StoreID).HasComment("Foreign key to Store.BusinessEntityID");
            entity.Property(e => e.TerritoryID).HasComment("ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.Person).WithMany(p => p.Customers).HasForeignKey(d => d.PersonID);

            entity.HasOne(d => d.Store).WithMany(p => p.Customers).HasForeignKey(d => d.StoreID);

            entity.HasOne(d => d.Territory).WithMany(p => p.Customers).HasForeignKey(d => d.TerritoryID);
        });

        modelBuilder.Entity<DatabaseLog>(entity =>
        {
            entity.HasKey(e => e.DatabaseLogID)
                .HasName("PK_DatabaseLog_DatabaseLogID")
                .IsClustered(false);

            entity.ToTable("DatabaseLog", tb => tb.HasComment("Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog."));

            entity.Property(e => e.DatabaseLogID).HasComment("Primary key for DatabaseLog records.");
            entity.Property(e => e.DatabaseUser)
                .HasMaxLength(128)
                .HasComment("The user who implemented the DDL change.");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasComment("The type of DDL statement that was executed.");
            entity.Property(e => e.Object)
                .HasMaxLength(128)
                .HasComment("The object that was changed by the DDL statment.");
            entity.Property(e => e.PostTime)
                .HasComment("The date and time the DDL change occurred.")
                .HasColumnType("datetime");
            entity.Property(e => e.Schema)
                .HasMaxLength(128)
                .HasComment("The schema to which the changed object belongs.");
            entity.Property(e => e.TSQL).HasComment("The exact Transact-SQL statement that was executed.");
            entity.Property(e => e.XmlEvent)
                .HasComment("The raw XML data generated by database trigger.")
                .HasColumnType("xml");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentID).HasName("PK_Department_DepartmentID");

            entity.ToTable("Department", "HumanResources", tb => tb.HasComment("Lookup table containing the departments within the Adventure Works Cycles company."));

            entity.HasIndex(e => e.Name, "AK_Department_Name").IsUnique();

            entity.Property(e => e.DepartmentID).HasComment("Primary key for Department records.");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .HasComment("Name of the group to which the department belongs.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Name of the department.");
        });

        modelBuilder.Entity<EmailAddress>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.EmailAddressID }).HasName("PK_EmailAddress_BusinessEntityID_EmailAddressID");

            entity.ToTable("EmailAddress", "Person", tb => tb.HasComment("Where to send a person email."));

            entity.HasIndex(e => e.EmailAddress1, "IX_EmailAddress_EmailAddress");

            entity.Property(e => e.BusinessEntityID).HasComment("Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID");
            entity.Property(e => e.EmailAddressID)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key. ID of this email address.");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(50)
                .HasComment("E-mail address for the person.")
                .HasColumnName("EmailAddress");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.EmailAddresses)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_Employee_BusinessEntityID");

            entity.ToTable("Employee", "HumanResources", tb =>
                {
                    tb.HasComment("Employee information such as salary, department, and title.");
                    tb.HasTrigger("dEmployee");
                });

            entity.HasIndex(e => e.LoginID, "AK_Employee_LoginID").IsUnique();

            entity.HasIndex(e => e.NationalIDNumber, "AK_Employee_NationalIDNumber").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_Employee_rowguid").IsUnique();

            entity.Property(e => e.BusinessEntityID)
                .ValueGeneratedNever()
                .HasComment("Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.");
            entity.Property(e => e.BirthDate).HasComment("Date of birth.");
            entity.Property(e => e.CurrentFlag)
                .HasDefaultValue(true)
                .HasComment("0 = Inactive, 1 = Active");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("M = Male, F = Female");
            entity.Property(e => e.HireDate).HasComment("Employee hired on this date.");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .HasComment("Work title such as Buyer or Sales Representative.");
            entity.Property(e => e.LoginID)
                .HasMaxLength(256)
                .HasComment("Network login.");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("M = Married, S = Single");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.NationalIDNumber)
                .HasMaxLength(15)
                .HasComment("Unique national identification number such as a social security number.");
            entity.Property(e => e.OrganizationLevel)
                .HasComputedColumnSql("([OrganizationNode].[GetLevel]())", false)
                .HasComment("The depth of the employee in the corporate hierarchy.");
            entity.Property(e => e.SalariedFlag)
                .HasDefaultValue(true)
                .HasComment("Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.");
            entity.Property(e => e.SickLeaveHours).HasComment("Number of available sick leave hours.");
            entity.Property(e => e.VacationHours).HasComment("Number of available vacation hours.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.StartDate, e.DepartmentID, e.ShiftID }).HasName("PK_EmployeeDepartmentHistory_BusinessEntityID_StartDate_DepartmentID");

            entity.ToTable("EmployeeDepartmentHistory", "HumanResources", tb => tb.HasComment("Employee department transfers."));

            entity.HasIndex(e => e.DepartmentID, "IX_EmployeeDepartmentHistory_DepartmentID");

            entity.HasIndex(e => e.ShiftID, "IX_EmployeeDepartmentHistory_ShiftID");

            entity.Property(e => e.BusinessEntityID).HasComment("Employee identification number. Foreign key to Employee.BusinessEntityID.");
            entity.Property(e => e.StartDate).HasComment("Date the employee started work in the department.");
            entity.Property(e => e.DepartmentID).HasComment("Department in which the employee worked including currently. Foreign key to Department.DepartmentID.");
            entity.Property(e => e.ShiftID).HasComment("Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.");
            entity.Property(e => e.EndDate).HasComment("Date the employee left the department. NULL = Current department.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Department).WithMany(p => p.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Shift).WithMany(p => p.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.ShiftID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<EmployeePayHistory>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.RateChangeDate }).HasName("PK_EmployeePayHistory_BusinessEntityID_RateChangeDate");

            entity.ToTable("EmployeePayHistory", "HumanResources", tb => tb.HasComment("Employee pay history."));

            entity.Property(e => e.BusinessEntityID).HasComment("Employee identification number. Foreign key to Employee.BusinessEntityID.");
            entity.Property(e => e.RateChangeDate)
                .HasComment("Date the change in pay is effective")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PayFrequency).HasComment("1 = Salary received monthly, 2 = Salary received biweekly");
            entity.Property(e => e.Rate)
                .HasComment("Salary hourly rate.")
                .HasColumnType("money");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.EmployeePayHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorLogID).HasName("PK_ErrorLog_ErrorLogID");

            entity.ToTable("ErrorLog", tb => tb.HasComment("Audit table tracking errors in the the AdventureWorks database that are caught by the CATCH block of a TRY...CATCH construct. Data is inserted by stored procedure dbo.uspLogError when it is executed from inside the CATCH block of a TRY...CATCH construct."));

            entity.Property(e => e.ErrorLogID).HasComment("Primary key for ErrorLog records.");
            entity.Property(e => e.ErrorLine).HasComment("The line number at which the error occurred.");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .HasComment("The message text of the error that occurred.");
            entity.Property(e => e.ErrorNumber).HasComment("The error number of the error that occurred.");
            entity.Property(e => e.ErrorProcedure)
                .HasMaxLength(126)
                .HasComment("The name of the stored procedure or trigger where the error occurred.");
            entity.Property(e => e.ErrorSeverity).HasComment("The severity of the error that occurred.");
            entity.Property(e => e.ErrorState).HasComment("The state number of the error that occurred.");
            entity.Property(e => e.ErrorTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("The date and time at which the error occurred.")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(128)
                .HasComment("The user who executed the batch in which the error occurred.");
        });

        modelBuilder.Entity<Illustration>(entity =>
        {
            entity.HasKey(e => e.IllustrationID).HasName("PK_Illustration_IllustrationID");

            entity.ToTable("Illustration", "Production", tb => tb.HasComment("Bicycle assembly diagrams."));

            entity.Property(e => e.IllustrationID).HasComment("Primary key for Illustration records.");
            entity.Property(e => e.Diagram)
                .HasComment("Illustrations used in manufacturing instructions. Stored as XML.")
                .HasColumnType("xml");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<JobCandidate>(entity =>
        {
            entity.HasKey(e => e.JobCandidateID).HasName("PK_JobCandidate_JobCandidateID");

            entity.ToTable("JobCandidate", "HumanResources", tb => tb.HasComment("Résumés submitted to Human Resources by job applicants."));

            entity.HasIndex(e => e.BusinessEntityID, "IX_JobCandidate_BusinessEntityID");

            entity.Property(e => e.JobCandidateID).HasComment("Primary key for JobCandidate records.");
            entity.Property(e => e.BusinessEntityID).HasComment("Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Resume)
                .HasComment("Résumé in XML format.")
                .HasColumnType("xml");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.JobCandidates).HasForeignKey(d => d.BusinessEntityID);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationID).HasName("PK_Location_LocationID");

            entity.ToTable("Location", "Production", tb => tb.HasComment("Product inventory and manufacturing locations."));

            entity.HasIndex(e => e.Name, "AK_Location_Name").IsUnique();

            entity.Property(e => e.LocationID).HasComment("Primary key for Location records.");
            entity.Property(e => e.Availability)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Work capacity (in hours) of the manufacturing location.")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CostRate)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Standard hourly cost of the manufacturing location.")
                .HasColumnType("smallmoney");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Location description.");
        });

        modelBuilder.Entity<Password>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_Password_BusinessEntityID");

            entity.ToTable("Password", "Person", tb => tb.HasComment("One way hashed authentication information"));

            entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasComment("Password for the e-mail account.");
            entity.Property(e => e.PasswordSalt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Random value concatenated with the password string before the password is hashed.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Password)
                .HasForeignKey<Password>(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_Person_BusinessEntityID");

            entity.ToTable("Person", "Person", tb =>
                {
                    tb.HasComment("Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.");
                    tb.HasTrigger("iuPerson");
                });

            entity.HasIndex(e => e.rowguid, "AK_Person_rowguid").IsUnique();

            entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName }, "IX_Person_LastName_FirstName_MiddleName");

            entity.HasIndex(e => e.AdditionalContactInfo, "PXML_Person_AddContact");

            entity.HasIndex(e => e.Demographics, "PXML_Person_Demographics");

            entity.HasIndex(e => e.Demographics, "XMLPATH_Person_Demographics");

            entity.HasIndex(e => e.Demographics, "XMLPROPERTY_Person_Demographics");

            entity.HasIndex(e => e.Demographics, "XMLVALUE_Person_Demographics");

            entity.Property(e => e.BusinessEntityID)
                .ValueGeneratedNever()
                .HasComment("Primary key for Person records.");
            entity.Property(e => e.AdditionalContactInfo)
                .HasComment("Additional contact information about the person stored in xml format. ")
                .HasColumnType("xml");
            entity.Property(e => e.Demographics)
                .HasComment("Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.")
                .HasColumnType("xml");
            entity.Property(e => e.EmailPromotion).HasComment("0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasComment("First name of the person.");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasComment("Last name of the person.");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasComment("Middle name or middle initial of the person.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.NameStyle).HasComment("0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.");
            entity.Property(e => e.PersonType)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact");
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .HasComment("Surname suffix. For example, Sr. or Jr.");
            entity.Property(e => e.Title)
                .HasMaxLength(8)
                .HasComment("A courtesy title. For example, Mr. or Ms.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Person)
                .HasForeignKey<Person>(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PersonCreditCard>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.CreditCardID }).HasName("PK_PersonCreditCard_BusinessEntityID_CreditCardID");

            entity.ToTable("PersonCreditCard", "Sales", tb => tb.HasComment("Cross-reference table mapping people to their credit card information in the CreditCard table. "));

            entity.Property(e => e.BusinessEntityID).HasComment("Business entity identification number. Foreign key to Person.BusinessEntityID.");
            entity.Property(e => e.CreditCardID).HasComment("Credit card identification number. Foreign key to CreditCard.CreditCardID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.PersonCreditCards)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.CreditCard).WithMany(p => p.PersonCreditCards)
                .HasForeignKey(d => d.CreditCardID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PersonPhone>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.PhoneNumber, e.PhoneNumberTypeID }).HasName("PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID");

            entity.ToTable("PersonPhone", "Person", tb => tb.HasComment("Telephone number and type of a person."));

            entity.HasIndex(e => e.PhoneNumber, "IX_PersonPhone_PhoneNumber");

            entity.Property(e => e.BusinessEntityID).HasComment("Business entity identification number. Foreign key to Person.BusinessEntityID.");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(25)
                .HasComment("Telephone number identification number.");
            entity.Property(e => e.PhoneNumberTypeID).HasComment("Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.PersonPhones)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PhoneNumberType).WithMany(p => p.PersonPhones)
                .HasForeignKey(d => d.PhoneNumberTypeID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PhoneNumberType>(entity =>
        {
            entity.HasKey(e => e.PhoneNumberTypeID).HasName("PK_PhoneNumberType_PhoneNumberTypeID");

            entity.ToTable("PhoneNumberType", "Person", tb => tb.HasComment("Type of phone number of a person."));

            entity.Property(e => e.PhoneNumberTypeID).HasComment("Primary key for telephone number type records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Name of the telephone number type");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductID).HasName("PK_Product_ProductID");

            entity.ToTable("Product", "Production", tb => tb.HasComment("Products sold or used in the manfacturing of sold products."));

            entity.HasIndex(e => e.Name, "AK_Product_Name").IsUnique();

            entity.HasIndex(e => e.ProductNumber, "AK_Product_ProductNumber").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_Product_rowguid").IsUnique();

            entity.Property(e => e.ProductID).HasComment("Primary key for Product records.");
            entity.Property(e => e.Class)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("H = High, M = Medium, L = Low");
            entity.Property(e => e.Color)
                .HasMaxLength(15)
                .HasComment("Product color.");
            entity.Property(e => e.DaysToManufacture).HasComment("Number of days required to manufacture the product.");
            entity.Property(e => e.DiscontinuedDate)
                .HasComment("Date the product was discontinued.")
                .HasColumnType("datetime");
            entity.Property(e => e.FinishedGoodsFlag)
                .HasDefaultValue(true)
                .HasComment("0 = Product is not a salable item. 1 = Product is salable.");
            entity.Property(e => e.ListPrice)
                .HasComment("Selling price.")
                .HasColumnType("money");
            entity.Property(e => e.MakeFlag)
                .HasDefaultValue(true)
                .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Name of the product.");
            entity.Property(e => e.ProductLine)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("R = Road, M = Mountain, T = Touring, S = Standard");
            entity.Property(e => e.ProductModelID).HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");
            entity.Property(e => e.ProductNumber)
                .HasMaxLength(25)
                .HasComment("Unique product identification number.");
            entity.Property(e => e.ProductSubcategoryID).HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");
            entity.Property(e => e.ReorderPoint).HasComment("Inventory level that triggers a purchase order or work order. ");
            entity.Property(e => e.SafetyStockLevel).HasComment("Minimum inventory quantity. ");
            entity.Property(e => e.SellEndDate)
                .HasComment("Date the product was no longer available for sale.")
                .HasColumnType("datetime");
            entity.Property(e => e.SellStartDate)
                .HasComment("Date the product was available for sale.")
                .HasColumnType("datetime");
            entity.Property(e => e.Size)
                .HasMaxLength(5)
                .HasComment("Product size.");
            entity.Property(e => e.SizeUnitMeasureCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("Unit of measure for Size column.");
            entity.Property(e => e.StandardCost)
                .HasComment("Standard cost of the product.")
                .HasColumnType("money");
            entity.Property(e => e.Style)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("W = Womens, M = Mens, U = Universal");
            entity.Property(e => e.Weight)
                .HasComment("Product weight.")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.WeightUnitMeasureCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("Unit of measure for Weight column.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.ProductModel).WithMany(p => p.Products).HasForeignKey(d => d.ProductModelID);

            entity.HasOne(d => d.ProductSubcategory).WithMany(p => p.Products).HasForeignKey(d => d.ProductSubcategoryID);

            entity.HasOne(d => d.SizeUnitMeasureCodeNavigation).WithMany(p => p.ProductSizeUnitMeasureCodeNavigations).HasForeignKey(d => d.SizeUnitMeasureCode);

            entity.HasOne(d => d.WeightUnitMeasureCodeNavigation).WithMany(p => p.ProductWeightUnitMeasureCodeNavigations).HasForeignKey(d => d.WeightUnitMeasureCode);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.ProductCategoryID).HasName("PK_ProductCategory_ProductCategoryID");

            entity.ToTable("ProductCategory", "Production", tb => tb.HasComment("High-level product categorization."));

            entity.HasIndex(e => e.Name, "AK_ProductCategory_Name").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_ProductCategory_rowguid").IsUnique();

            entity.Property(e => e.ProductCategoryID).HasComment("Primary key for ProductCategory records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Category description.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<ProductCostHistory>(entity =>
        {
            entity.HasKey(e => new { e.ProductID, e.StartDate }).HasName("PK_ProductCostHistory_ProductID_StartDate");

            entity.ToTable("ProductCostHistory", "Production", tb => tb.HasComment("Changes in the cost of a product over time."));

            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID");
            entity.Property(e => e.StartDate)
                .HasComment("Product cost start date.")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate)
                .HasComment("Product cost end date.")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.StandardCost)
                .HasComment("Standard cost of the product.")
                .HasColumnType("money");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCostHistories)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductDescription>(entity =>
        {
            entity.HasKey(e => e.ProductDescriptionID).HasName("PK_ProductDescription_ProductDescriptionID");

            entity.ToTable("ProductDescription", "Production", tb => tb.HasComment("Product descriptions in several languages."));

            entity.HasIndex(e => e.rowguid, "AK_ProductDescription_rowguid").IsUnique();

            entity.Property(e => e.ProductDescriptionID).HasComment("Primary key for ProductDescription records.");
            entity.Property(e => e.Description)
                .HasMaxLength(400)
                .HasComment("Description of the product.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<ProductInventory>(entity =>
        {
            entity.HasKey(e => new { e.ProductID, e.LocationID }).HasName("PK_ProductInventory_ProductID_LocationID");

            entity.ToTable("ProductInventory", "Production", tb => tb.HasComment("Product inventory information."));

            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.LocationID).HasComment("Inventory location identification number. Foreign key to Location.LocationID. ");
            entity.Property(e => e.Bin).HasComment("Storage container on a shelf in an inventory location.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasComment("Quantity of products in the inventory location.");
            entity.Property(e => e.Shelf)
                .HasMaxLength(10)
                .HasComment("Storage compartment within an inventory location.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.Location).WithMany(p => p.ProductInventories)
                .HasForeignKey(d => d.LocationID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductInventories)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductListPriceHistory>(entity =>
        {
            entity.HasKey(e => new { e.ProductID, e.StartDate }).HasName("PK_ProductListPriceHistory_ProductID_StartDate");

            entity.ToTable("ProductListPriceHistory", "Production", tb => tb.HasComment("Changes in the list price of a product over time."));

            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID");
            entity.Property(e => e.StartDate)
                .HasComment("List price start date.")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate)
                .HasComment("List price end date")
                .HasColumnType("datetime");
            entity.Property(e => e.ListPrice)
                .HasComment("Product list price.")
                .HasColumnType("money");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductListPriceHistories)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductModel>(entity =>
        {
            entity.HasKey(e => e.ProductModelID).HasName("PK_ProductModel_ProductModelID");

            entity.ToTable("ProductModel", "Production", tb => tb.HasComment("Product model classification."));

            entity.HasIndex(e => e.Name, "AK_ProductModel_Name").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_ProductModel_rowguid").IsUnique();

            entity.HasIndex(e => e.CatalogDescription, "PXML_ProductModel_CatalogDescription");

            entity.HasIndex(e => e.Instructions, "PXML_ProductModel_Instructions");

            entity.Property(e => e.ProductModelID).HasComment("Primary key for ProductModel records.");
            entity.Property(e => e.CatalogDescription)
                .HasComment("Detailed product catalog information in xml format.")
                .HasColumnType("xml");
            entity.Property(e => e.Instructions)
                .HasComment("Manufacturing instructions in xml format.")
                .HasColumnType("xml");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Product model description.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<ProductModelIllustration>(entity =>
        {
            entity.HasKey(e => new { e.ProductModelID, e.IllustrationID }).HasName("PK_ProductModelIllustration_ProductModelID_IllustrationID");

            entity.ToTable("ProductModelIllustration", "Production", tb => tb.HasComment("Cross-reference table mapping product models and illustrations."));

            entity.Property(e => e.ProductModelID).HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");
            entity.Property(e => e.IllustrationID).HasComment("Primary key. Foreign key to Illustration.IllustrationID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Illustration).WithMany(p => p.ProductModelIllustrations)
                .HasForeignKey(d => d.IllustrationID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductModel).WithMany(p => p.ProductModelIllustrations)
                .HasForeignKey(d => d.ProductModelID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductModelProductDescriptionCulture>(entity =>
        {
            entity.HasKey(e => new { e.ProductModelID, e.ProductDescriptionID, e.CultureID }).HasName("PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID");

            entity.ToTable("ProductModelProductDescriptionCulture", "Production", tb => tb.HasComment("Cross-reference table mapping product descriptions and the language the description is written in."));

            entity.Property(e => e.ProductModelID).HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");
            entity.Property(e => e.ProductDescriptionID).HasComment("Primary key. Foreign key to ProductDescription.ProductDescriptionID.");
            entity.Property(e => e.CultureID)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasComment("Culture identification number. Foreign key to Culture.CultureID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Culture).WithMany(p => p.ProductModelProductDescriptionCultures)
                .HasForeignKey(d => d.CultureID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductDescription).WithMany(p => p.ProductModelProductDescriptionCultures)
                .HasForeignKey(d => d.ProductDescriptionID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductModel).WithMany(p => p.ProductModelProductDescriptionCultures)
                .HasForeignKey(d => d.ProductModelID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductPhoto>(entity =>
        {
            entity.HasKey(e => e.ProductPhotoID).HasName("PK_ProductPhoto_ProductPhotoID");

            entity.ToTable("ProductPhoto", "Production", tb => tb.HasComment("Product images."));

            entity.Property(e => e.ProductPhotoID).HasComment("Primary key for ProductPhoto records.");
            entity.Property(e => e.LargePhoto).HasComment("Large image of the product.");
            entity.Property(e => e.LargePhotoFileName)
                .HasMaxLength(50)
                .HasComment("Large image file name.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.ThumbNailPhoto).HasComment("Small image of the product.");
            entity.Property(e => e.ThumbnailPhotoFileName)
                .HasMaxLength(50)
                .HasComment("Small image file name.");
        });

        modelBuilder.Entity<ProductProductPhoto>(entity =>
        {
            entity.HasKey(e => new { e.ProductID, e.ProductPhotoID })
                .HasName("PK_ProductProductPhoto_ProductID_ProductPhotoID")
                .IsClustered(false);

            entity.ToTable("ProductProductPhoto", "Production", tb => tb.HasComment("Cross-reference table mapping products and product photos."));

            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.ProductPhotoID).HasComment("Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Primary).HasComment("0 = Photo is not the principal image. 1 = Photo is the principal image.");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductProductPhotos)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductPhoto).WithMany(p => p.ProductProductPhotos)
                .HasForeignKey(d => d.ProductPhotoID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductReview>(entity =>
        {
            entity.HasKey(e => e.ProductReviewID).HasName("PK_ProductReview_ProductReviewID");

            entity.ToTable("ProductReview", "Production", tb => tb.HasComment("Customer reviews of products they have purchased."));

            entity.HasIndex(e => new { e.ProductID, e.ReviewerName }, "IX_ProductReview_ProductID_Name");

            entity.Property(e => e.ProductReviewID).HasComment("Primary key for ProductReview records.");
            entity.Property(e => e.Comments)
                .HasMaxLength(3850)
                .HasComment("Reviewer's comments");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .HasComment("Reviewer's e-mail address.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.Rating).HasComment("Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.");
            entity.Property(e => e.ReviewDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date review was submitted.")
                .HasColumnType("datetime");
            entity.Property(e => e.ReviewerName)
                .HasMaxLength(50)
                .HasComment("Name of the reviewer.");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductSubcategory>(entity =>
        {
            entity.HasKey(e => e.ProductSubcategoryID).HasName("PK_ProductSubcategory_ProductSubcategoryID");

            entity.ToTable("ProductSubcategory", "Production", tb => tb.HasComment("Product subcategories. See ProductCategory table."));

            entity.HasIndex(e => e.Name, "AK_ProductSubcategory_Name").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_ProductSubcategory_rowguid").IsUnique();

            entity.Property(e => e.ProductSubcategoryID).HasComment("Primary key for ProductSubcategory records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Subcategory description.");
            entity.Property(e => e.ProductCategoryID).HasComment("Product category identification number. Foreign key to ProductCategory.ProductCategoryID.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.ProductSubcategories)
                .HasForeignKey(d => d.ProductCategoryID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProductVendor>(entity =>
        {
            entity.HasKey(e => new { e.ProductID, e.BusinessEntityID }).HasName("PK_ProductVendor_ProductID_BusinessEntityID");

            entity.ToTable("ProductVendor", "Purchasing", tb => tb.HasComment("Cross-reference table mapping vendors with the products they supply."));

            entity.HasIndex(e => e.BusinessEntityID, "IX_ProductVendor_BusinessEntityID");

            entity.HasIndex(e => e.UnitMeasureCode, "IX_ProductVendor_UnitMeasureCode");

            entity.Property(e => e.ProductID).HasComment("Primary key. Foreign key to Product.ProductID.");
            entity.Property(e => e.BusinessEntityID).HasComment("Primary key. Foreign key to Vendor.BusinessEntityID.");
            entity.Property(e => e.AverageLeadTime).HasComment("The average span of time (in days) between placing an order with the vendor and receiving the purchased product.");
            entity.Property(e => e.LastReceiptCost)
                .HasComment("The selling price when last purchased.")
                .HasColumnType("money");
            entity.Property(e => e.LastReceiptDate)
                .HasComment("Date the product was last received by the vendor.")
                .HasColumnType("datetime");
            entity.Property(e => e.MaxOrderQty).HasComment("The minimum quantity that should be ordered.");
            entity.Property(e => e.MinOrderQty).HasComment("The maximum quantity that should be ordered.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.OnOrderQty).HasComment("The quantity currently on order.");
            entity.Property(e => e.StandardPrice)
                .HasComment("The vendor's usual selling price.")
                .HasColumnType("money");
            entity.Property(e => e.UnitMeasureCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("The product's unit of measure.");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.ProductVendors)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductVendors)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UnitMeasureCodeNavigation).WithMany(p => p.ProductVendors)
                .HasForeignKey(d => d.UnitMeasureCode)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PurchaseOrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.PurchaseOrderID, e.PurchaseOrderDetailID }).HasName("PK_PurchaseOrderDetail_PurchaseOrderID_PurchaseOrderDetailID");

            entity.ToTable("PurchaseOrderDetail", "Purchasing", tb =>
                {
                    tb.HasComment("Individual products associated with a specific purchase order. See PurchaseOrderHeader.");
                    tb.HasTrigger("iPurchaseOrderDetail");
                    tb.HasTrigger("uPurchaseOrderDetail");
                });

            entity.HasIndex(e => e.ProductID, "IX_PurchaseOrderDetail_ProductID");

            entity.Property(e => e.PurchaseOrderID).HasComment("Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.");
            entity.Property(e => e.PurchaseOrderDetailID)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key. One line number per purchased product.");
            entity.Property(e => e.DueDate)
                .HasComment("Date the product is expected to be received.")
                .HasColumnType("datetime");
            entity.Property(e => e.LineTotal)
                .HasComputedColumnSql("(isnull([OrderQty]*[UnitPrice],(0.00)))", false)
                .HasComment("Per product subtotal. Computed as OrderQty * UnitPrice.")
                .HasColumnType("money");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderQty).HasComment("Quantity ordered.");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.ReceivedQty)
                .HasComment("Quantity actually received from the vendor.")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.RejectedQty)
                .HasComment("Quantity rejected during inspection.")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.StockedQty)
                .HasComputedColumnSql("(isnull([ReceivedQty]-[RejectedQty],(0.00)))", false)
                .HasComment("Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.UnitPrice)
                .HasComment("Vendor's selling price of a single product.")
                .HasColumnType("money");

            entity.HasOne(d => d.Product).WithMany(p => p.PurchaseOrderDetails)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderDetails)
                .HasForeignKey(d => d.PurchaseOrderID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PurchaseOrderHeader>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderID).HasName("PK_PurchaseOrderHeader_PurchaseOrderID");

            entity.ToTable("PurchaseOrderHeader", "Purchasing", tb =>
                {
                    tb.HasComment("General purchase order information. See PurchaseOrderDetail.");
                    tb.HasTrigger("uPurchaseOrderHeader");
                });

            entity.HasIndex(e => e.EmployeeID, "IX_PurchaseOrderHeader_EmployeeID");

            entity.HasIndex(e => e.VendorID, "IX_PurchaseOrderHeader_VendorID");

            entity.Property(e => e.PurchaseOrderID).HasComment("Primary key.");
            entity.Property(e => e.EmployeeID).HasComment("Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.");
            entity.Property(e => e.Freight)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Shipping cost.")
                .HasColumnType("money");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Purchase order creation date.")
                .HasColumnType("datetime");
            entity.Property(e => e.RevisionNumber).HasComment("Incremental number to track changes to the purchase order over time.");
            entity.Property(e => e.ShipDate)
                .HasComment("Estimated shipment date from the vendor.")
                .HasColumnType("datetime");
            entity.Property(e => e.ShipMethodID).HasComment("Shipping method. Foreign key to ShipMethod.ShipMethodID.");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasComment("Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete");
            entity.Property(e => e.SubTotal)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.")
                .HasColumnType("money");
            entity.Property(e => e.TaxAmt)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Tax amount.")
                .HasColumnType("money");
            entity.Property(e => e.TotalDue)
                .HasComputedColumnSql("(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))", true)
                .HasComment("Total due to vendor. Computed as Subtotal + TaxAmt + Freight.")
                .HasColumnType("money");
            entity.Property(e => e.VendorID).HasComment("Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.");

            entity.HasOne(d => d.Employee).WithMany(p => p.PurchaseOrderHeaders)
                .HasForeignKey(d => d.EmployeeID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ShipMethod).WithMany(p => p.PurchaseOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Vendor).WithMany(p => p.PurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SalesOrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.SalesOrderID, e.SalesOrderDetailID }).HasName("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

            entity.ToTable("SalesOrderDetail", "Sales", tb =>
                {
                    tb.HasComment("Individual products associated with a specific sales order. See SalesOrderHeader.");
                    tb.HasTrigger("iduSalesOrderDetail");
                });

            entity.HasIndex(e => e.rowguid, "AK_SalesOrderDetail_rowguid").IsUnique();

            entity.HasIndex(e => e.ProductID, "IX_SalesOrderDetail_ProductID");

            entity.Property(e => e.SalesOrderID).HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");
            entity.Property(e => e.SalesOrderDetailID)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key. One incremental unique number per product sold.");
            entity.Property(e => e.CarrierTrackingNumber)
                .HasMaxLength(25)
                .HasComment("Shipment tracking number supplied by the shipper.");
            entity.Property(e => e.LineTotal)
                .HasComputedColumnSql("(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))", false)
                .HasComment("Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.")
                .HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderQty).HasComment("Quantity ordered per product.");
            entity.Property(e => e.ProductID).HasComment("Product sold to customer. Foreign key to Product.ProductID.");
            entity.Property(e => e.SpecialOfferID).HasComment("Promotional code. Foreign key to SpecialOffer.SpecialOfferID.");
            entity.Property(e => e.UnitPrice)
                .HasComment("Selling price of a single product.")
                .HasColumnType("money");
            entity.Property(e => e.UnitPriceDiscount)
                .HasDefaultValueSql("((0.0))")
                .HasComment("Discount amount.")
                .HasColumnType("money");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderDetails).HasForeignKey(d => d.SalesOrderID);

            entity.HasOne(d => d.SpecialOfferProduct).WithMany(p => p.SalesOrderDetails)
                .HasForeignKey(d => new { d.SpecialOfferID, d.ProductID })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID");
              entity.HasOne(d => d.Product) //to dodałem ja
               .WithMany()
               .HasForeignKey(d => d.ProductID);

        });

        modelBuilder.Entity<SalesOrderHeader>(entity =>
        {
            entity.HasKey(e => e.SalesOrderID).HasName("PK_SalesOrderHeader_SalesOrderID");

            entity.ToTable("SalesOrderHeader", "Sales", tb =>
                {
                    tb.HasComment("General sales order information.");
                    tb.HasTrigger("uSalesOrderHeader");
                });

            entity.HasIndex(e => e.SalesOrderNumber, "AK_SalesOrderHeader_SalesOrderNumber").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_SalesOrderHeader_rowguid").IsUnique();

            entity.HasIndex(e => e.CustomerID, "IX_SalesOrderHeader_CustomerID");

            entity.HasIndex(e => e.SalesPersonID, "IX_SalesOrderHeader_SalesPersonID");

            entity.Property(e => e.SalesOrderID).HasComment("Primary key.");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(15)
                .HasComment("Financial accounting number reference.");
            entity.Property(e => e.BillToAddressID).HasComment("Customer billing address. Foreign key to Address.AddressID.");
            entity.Property(e => e.Comment)
                .HasMaxLength(128)
                .HasComment("Sales representative comments.");
            entity.Property(e => e.CreditCardApprovalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("Approval code provided by the credit card company.");
            entity.Property(e => e.CreditCardID).HasComment("Credit card identification number. Foreign key to CreditCard.CreditCardID.");
            entity.Property(e => e.CurrencyRateID).HasComment("Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.");
            entity.Property(e => e.CustomerID).HasComment("Customer identification number. Foreign key to Customer.BusinessEntityID.");
            entity.Property(e => e.DueDate)
                .HasComment("Date the order is due to the customer.")
                .HasColumnType("datetime");
            entity.Property(e => e.Freight)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Shipping cost.")
                .HasColumnType("money");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.OnlineOrderFlag)
                .HasDefaultValue(true)
                .HasComment("0 = Order placed by sales person. 1 = Order placed online by customer.");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Dates the sales order was created.")
                .HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(25)
                .HasComment("Customer purchase order number reference. ");
            entity.Property(e => e.RevisionNumber).HasComment("Incremental number to track changes to the sales order over time.");
            entity.Property(e => e.SalesOrderNumber)
                .HasMaxLength(25)
                .HasComputedColumnSql("(isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***'))", false)
                .HasComment("Unique sales order identification number.");
            entity.Property(e => e.SalesPersonID).HasComment("Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.");
            entity.Property(e => e.ShipDate)
                .HasComment("Date the order was shipped to the customer.")
                .HasColumnType("datetime");
            entity.Property(e => e.ShipMethodID).HasComment("Shipping method. Foreign key to ShipMethod.ShipMethodID.");
            entity.Property(e => e.ShipToAddressID).HasComment("Customer shipping address. Foreign key to Address.AddressID.");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasComment("Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled");
            entity.Property(e => e.SubTotal)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.")
                .HasColumnType("money");
            entity.Property(e => e.TaxAmt)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Tax amount.")
                .HasColumnType("money");
            entity.Property(e => e.TerritoryID).HasComment("Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.");
            entity.Property(e => e.TotalDue)
                .HasComputedColumnSql("(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))", false)
                .HasComment("Total due from customer. Computed as Subtotal + TaxAmt + Freight.")
                .HasColumnType("money");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BillToAddress).WithMany(p => p.SalesOrderHeaderBillToAddresses)
                .HasForeignKey(d => d.BillToAddressID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.CreditCard).WithMany(p => p.SalesOrderHeaders).HasForeignKey(d => d.CreditCardID);

            entity.HasOne(d => d.CurrencyRate).WithMany(p => p.SalesOrderHeaders).HasForeignKey(d => d.CurrencyRateID);

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesOrderHeaders)
                .HasForeignKey(d => d.CustomerID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.SalesOrderHeaders).HasForeignKey(d => d.SalesPersonID);

            entity.HasOne(d => d.ShipMethod).WithMany(p => p.SalesOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ShipToAddress).WithMany(p => p.SalesOrderHeaderShipToAddresses)
                .HasForeignKey(d => d.ShipToAddressID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Territory).WithMany(p => p.SalesOrderHeaders).HasForeignKey(d => d.TerritoryID);
        });

        modelBuilder.Entity<SalesOrderHeaderSalesReason>(entity =>
        {
            entity.HasKey(e => new { e.SalesOrderID, e.SalesReasonID }).HasName("PK_SalesOrderHeaderSalesReason_SalesOrderID_SalesReasonID");

            entity.ToTable("SalesOrderHeaderSalesReason", "Sales", tb => tb.HasComment("Cross-reference table mapping sales orders to sales reason codes."));

            entity.Property(e => e.SalesOrderID).HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");
            entity.Property(e => e.SalesReasonID).HasComment("Primary key. Foreign key to SalesReason.SalesReasonID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderHeaderSalesReasons).HasForeignKey(d => d.SalesOrderID);

            entity.HasOne(d => d.SalesReason).WithMany(p => p.SalesOrderHeaderSalesReasons)
                .HasForeignKey(d => d.SalesReasonID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SalesPerson>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_SalesPerson_BusinessEntityID");

            entity.ToTable("SalesPerson", "Sales", tb => tb.HasComment("Sales representative current information."));

            entity.HasIndex(e => e.rowguid, "AK_SalesPerson_rowguid").IsUnique();

            entity.Property(e => e.BusinessEntityID)
                .ValueGeneratedNever()
                .HasComment("Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID");
            entity.Property(e => e.Bonus)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Bonus due if quota is met.")
                .HasColumnType("money");
            entity.Property(e => e.CommissionPct)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Commision percent received per sale.")
                .HasColumnType("smallmoney");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.SalesLastYear)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Sales total of previous year.")
                .HasColumnType("money");
            entity.Property(e => e.SalesQuota)
                .HasComment("Projected yearly sales.")
                .HasColumnType("money");
            entity.Property(e => e.SalesYTD)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Sales total year to date.")
                .HasColumnType("money");
            entity.Property(e => e.TerritoryID).HasComment("Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithOne(p => p.SalesPerson)
                .HasForeignKey<SalesPerson>(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Territory).WithMany(p => p.SalesPeople).HasForeignKey(d => d.TerritoryID);
        });

        modelBuilder.Entity<SalesPersonQuotaHistory>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.QuotaDate }).HasName("PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate");

            entity.ToTable("SalesPersonQuotaHistory", "Sales", tb => tb.HasComment("Sales performance tracking."));

            entity.HasIndex(e => e.rowguid, "AK_SalesPersonQuotaHistory_rowguid").IsUnique();

            entity.Property(e => e.BusinessEntityID).HasComment("Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.");
            entity.Property(e => e.QuotaDate)
                .HasComment("Sales quota date.")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.SalesQuota)
                .HasComment("Sales quota amount.")
                .HasColumnType("money");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.SalesPersonQuotaHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SalesReason>(entity =>
        {
            entity.HasKey(e => e.SalesReasonID).HasName("PK_SalesReason_SalesReasonID");

            entity.ToTable("SalesReason", "Sales", tb => tb.HasComment("Lookup table of customer purchase reasons."));

            entity.Property(e => e.SalesReasonID).HasComment("Primary key for SalesReason records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Sales reason description.");
            entity.Property(e => e.ReasonType)
                .HasMaxLength(50)
                .HasComment("Category the sales reason belongs to.");
        });

        modelBuilder.Entity<SalesTaxRate>(entity =>
        {
            entity.HasKey(e => e.SalesTaxRateID).HasName("PK_SalesTaxRate_SalesTaxRateID");

            entity.ToTable("SalesTaxRate", "Sales", tb => tb.HasComment("Tax rate lookup table."));

            entity.HasIndex(e => new { e.StateProvinceID, e.TaxType }, "AK_SalesTaxRate_StateProvinceID_TaxType").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_SalesTaxRate_rowguid").IsUnique();

            entity.Property(e => e.SalesTaxRateID).HasComment("Primary key for SalesTaxRate records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Tax rate description.");
            entity.Property(e => e.StateProvinceID).HasComment("State, province, or country/region the sales tax applies to.");
            entity.Property(e => e.TaxRate)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Tax rate amount.")
                .HasColumnType("smallmoney");
            entity.Property(e => e.TaxType).HasComment("1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.StateProvince).WithMany(p => p.SalesTaxRates)
                .HasForeignKey(d => d.StateProvinceID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SalesTerritory>(entity =>
        {
            entity.HasKey(e => e.TerritoryID).HasName("PK_SalesTerritory_TerritoryID");

            entity.ToTable("SalesTerritory", "Sales", tb => tb.HasComment("Sales territory lookup table."));

            entity.HasIndex(e => e.Name, "AK_SalesTerritory_Name").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_SalesTerritory_rowguid").IsUnique();

            entity.Property(e => e.TerritoryID).HasComment("Primary key for SalesTerritory records.");
            entity.Property(e => e.CostLastYear)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Business costs in the territory the previous year.")
                .HasColumnType("money");
            entity.Property(e => e.CostYTD)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Business costs in the territory year to date.")
                .HasColumnType("money");
            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(3)
                .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .HasComment("Geographic area to which the sales territory belong.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Sales territory description");
            entity.Property(e => e.SalesLastYear)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Sales in the territory the previous year.")
                .HasColumnType("money");
            entity.Property(e => e.SalesYTD)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Sales in the territory year to date.")
                .HasColumnType("money");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.SalesTerritories)
                .HasForeignKey(d => d.CountryRegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SalesTerritoryHistory>(entity =>
        {
            entity.HasKey(e => new { e.BusinessEntityID, e.StartDate, e.TerritoryID }).HasName("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID");

            entity.ToTable("SalesTerritoryHistory", "Sales", tb => tb.HasComment("Sales representative transfers to other sales territories."));

            entity.HasIndex(e => e.rowguid, "AK_SalesTerritoryHistory_rowguid").IsUnique();

            entity.Property(e => e.BusinessEntityID).HasComment("Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.");
            entity.Property(e => e.StartDate)
                .HasComment("Primary key. Date the sales representive started work in the territory.")
                .HasColumnType("datetime");
            entity.Property(e => e.TerritoryID).HasComment("Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.");
            entity.Property(e => e.EndDate)
                .HasComment("Date the sales representative left work in the territory.")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.SalesTerritoryHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Territory).WithMany(p => p.SalesTerritoryHistories)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ScrapReason>(entity =>
        {
            entity.HasKey(e => e.ScrapReasonID).HasName("PK_ScrapReason_ScrapReasonID");

            entity.ToTable("ScrapReason", "Production", tb => tb.HasComment("Manufacturing failure reasons lookup table."));

            entity.HasIndex(e => e.Name, "AK_ScrapReason_Name").IsUnique();

            entity.Property(e => e.ScrapReasonID).HasComment("Primary key for ScrapReason records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Failure description.");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.ShiftID).HasName("PK_Shift_ShiftID");

            entity.ToTable("Shift", "HumanResources", tb => tb.HasComment("Work shift lookup table."));

            entity.HasIndex(e => e.Name, "AK_Shift_Name").IsUnique();

            entity.HasIndex(e => new { e.StartTime, e.EndTime }, "AK_Shift_StartTime_EndTime").IsUnique();

            entity.Property(e => e.ShiftID)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key for Shift records.");
            entity.Property(e => e.EndTime).HasComment("Shift end time.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Shift description.");
            entity.Property(e => e.StartTime).HasComment("Shift start time.");
        });

        modelBuilder.Entity<ShipMethod>(entity =>
        {
            entity.HasKey(e => e.ShipMethodID).HasName("PK_ShipMethod_ShipMethodID");

            entity.ToTable("ShipMethod", "Purchasing", tb => tb.HasComment("Shipping company lookup table."));

            entity.HasIndex(e => e.Name, "AK_ShipMethod_Name").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_ShipMethod_rowguid").IsUnique();

            entity.Property(e => e.ShipMethodID).HasComment("Primary key for ShipMethod records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Shipping company name.");
            entity.Property(e => e.ShipBase)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Minimum shipping charge.")
                .HasColumnType("money");
            entity.Property(e => e.ShipRate)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Shipping charge per pound.")
                .HasColumnType("money");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.HasKey(e => e.ShoppingCartItemID).HasName("PK_ShoppingCartItem_ShoppingCartItemID");

            entity.ToTable("ShoppingCartItem", "Sales", tb => tb.HasComment("Contains online customer orders until the order is submitted or cancelled."));

            entity.HasIndex(e => new { e.ShoppingCartID, e.ProductID }, "IX_ShoppingCartItem_ShoppingCartID_ProductID");

            entity.Property(e => e.ShoppingCartItemID).HasComment("Primary key for ShoppingCartItem records.");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date the time the record was created.")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasComment("Product ordered. Foreign key to Product.ProductID.");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasComment("Product quantity ordered.");
            entity.Property(e => e.ShoppingCartID)
                .HasMaxLength(50)
                .HasComment("Shopping cart identification number.");

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SpecialOffer>(entity =>
        {
            entity.HasKey(e => e.SpecialOfferID).HasName("PK_SpecialOffer_SpecialOfferID");

            entity.ToTable("SpecialOffer", "Sales", tb => tb.HasComment("Sale discounts lookup table."));

            entity.HasIndex(e => e.rowguid, "AK_SpecialOffer_rowguid").IsUnique();

            entity.Property(e => e.SpecialOfferID).HasComment("Primary key for SpecialOffer records.");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasComment("Group the discount applies to such as Reseller or Customer.");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Discount description.");
            entity.Property(e => e.DiscountPct)
                .HasDefaultValueSql("((0.00))")
                .HasComment("Discount precentage.")
                .HasColumnType("smallmoney");
            entity.Property(e => e.EndDate)
                .HasComment("Discount end date.")
                .HasColumnType("datetime");
            entity.Property(e => e.MaxQty).HasComment("Maximum discount percent allowed.");
            entity.Property(e => e.MinQty).HasComment("Minimum discount percent allowed.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasComment("Discount start date.")
                .HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasComment("Discount type category.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<SpecialOfferProduct>(entity =>
        {
            entity.HasKey(e => new { e.SpecialOfferID, e.ProductID }).HasName("PK_SpecialOfferProduct_SpecialOfferID_ProductID");

            entity.ToTable("SpecialOfferProduct", "Sales", tb => tb.HasComment("Cross-reference table mapping products to special offer discounts."));

            entity.HasIndex(e => e.rowguid, "AK_SpecialOfferProduct_rowguid").IsUnique();

            entity.HasIndex(e => e.ProductID, "IX_SpecialOfferProduct_ProductID");

            entity.Property(e => e.SpecialOfferID).HasComment("Primary key for SpecialOfferProduct records.");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.Product).WithMany(p => p.SpecialOfferProducts)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SpecialOffer).WithMany(p => p.SpecialOfferProducts)
                .HasForeignKey(d => d.SpecialOfferID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<StateProvince>(entity =>
        {
            entity.HasKey(e => e.StateProvinceID).HasName("PK_StateProvince_StateProvinceID");

            entity.ToTable("StateProvince", "Person", tb => tb.HasComment("State and province lookup table."));

            entity.HasIndex(e => e.Name, "AK_StateProvince_Name").IsUnique();

            entity.HasIndex(e => new { e.StateProvinceCode, e.CountryRegionCode }, "AK_StateProvince_StateProvinceCode_CountryRegionCode").IsUnique();

            entity.HasIndex(e => e.rowguid, "AK_StateProvince_rowguid").IsUnique();

            entity.Property(e => e.StateProvinceID).HasComment("Primary key for StateProvince records.");
            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(3)
                .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ");
            entity.Property(e => e.IsOnlyStateProvinceFlag)
                .HasDefaultValue(true)
                .HasComment("0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("State or province description.");
            entity.Property(e => e.StateProvinceCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("ISO standard state or province code.");
            entity.Property(e => e.TerritoryID).HasComment("ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.StateProvinces)
                .HasForeignKey(d => d.CountryRegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Territory).WithMany(p => p.StateProvinces)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_Store_BusinessEntityID");

            entity.ToTable("Store", "Sales", tb => tb.HasComment("Customers (resellers) of Adventure Works products."));

            entity.HasIndex(e => e.rowguid, "AK_Store_rowguid").IsUnique();

            entity.HasIndex(e => e.SalesPersonID, "IX_Store_SalesPersonID");

            entity.HasIndex(e => e.Demographics, "PXML_Store_Demographics");

            entity.Property(e => e.BusinessEntityID)
                .ValueGeneratedNever()
                .HasComment("Primary key. Foreign key to Customer.BusinessEntityID.");
            entity.Property(e => e.Demographics)
                .HasComment("Demographic informationg about the store such as the number of employees, annual sales and store type.")
                .HasColumnType("xml");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Name of the store.");
            entity.Property(e => e.SalesPersonID).HasComment("ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Store)
                .HasForeignKey<Store>(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.Stores).HasForeignKey(d => d.SalesPersonID);
        });

        modelBuilder.Entity<TransactionHistory>(entity =>
        {
            entity.HasKey(e => e.TransactionID).HasName("PK_TransactionHistory_TransactionID");

            entity.ToTable("TransactionHistory", "Production", tb => tb.HasComment("Record of each purchase order, sales order, or work order transaction year to date."));

            entity.HasIndex(e => e.ProductID, "IX_TransactionHistory_ProductID");

            entity.HasIndex(e => new { e.ReferenceOrderID, e.ReferenceOrderLineID }, "IX_TransactionHistory_ReferenceOrderID_ReferenceOrderLineID");

            entity.Property(e => e.TransactionID).HasComment("Primary key for TransactionHistory records.");
            entity.Property(e => e.ActualCost)
                .HasComment("Product cost.")
                .HasColumnType("money");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.Quantity).HasComment("Product quantity.");
            entity.Property(e => e.ReferenceOrderID).HasComment("Purchase order, sales order, or work order identification number.");
            entity.Property(e => e.ReferenceOrderLineID).HasComment("Line number associated with the purchase order, sales order, or work order.");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time of the transaction.")
                .HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("W = WorkOrder, S = SalesOrder, P = PurchaseOrder");

            entity.HasOne(d => d.Product).WithMany(p => p.TransactionHistories)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TransactionHistoryArchive>(entity =>
        {
            entity.HasKey(e => e.TransactionID).HasName("PK_TransactionHistoryArchive_TransactionID");

            entity.ToTable("TransactionHistoryArchive", "Production", tb => tb.HasComment("Transactions for previous years."));

            entity.HasIndex(e => e.ProductID, "IX_TransactionHistoryArchive_ProductID");

            entity.HasIndex(e => new { e.ReferenceOrderID, e.ReferenceOrderLineID }, "IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID");

            entity.Property(e => e.TransactionID)
                .ValueGeneratedNever()
                .HasComment("Primary key for TransactionHistoryArchive records.");
            entity.Property(e => e.ActualCost)
                .HasComment("Product cost.")
                .HasColumnType("money");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.Quantity).HasComment("Product quantity.");
            entity.Property(e => e.ReferenceOrderID).HasComment("Purchase order, sales order, or work order identification number.");
            entity.Property(e => e.ReferenceOrderLineID).HasComment("Line number associated with the purchase order, sales order, or work order.");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time of the transaction.")
                .HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("W = Work Order, S = Sales Order, P = Purchase Order");
        });

        modelBuilder.Entity<UnitMeasure>(entity =>
        {
            entity.HasKey(e => e.UnitMeasureCode).HasName("PK_UnitMeasure_UnitMeasureCode");

            entity.ToTable("UnitMeasure", "Production", tb => tb.HasComment("Unit of measure lookup table."));

            entity.HasIndex(e => e.Name, "AK_UnitMeasure_Name").IsUnique();

            entity.Property(e => e.UnitMeasureCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("Primary key.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Unit of measure description.");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityID).HasName("PK_Vendor_BusinessEntityID");

            entity.ToTable("Vendor", "Purchasing", tb =>
                {
                    tb.HasComment("Companies from whom Adventure Works Cycles purchases parts or other goods.");
                    tb.HasTrigger("dVendor");
                });

            entity.HasIndex(e => e.AccountNumber, "AK_Vendor_AccountNumber").IsUnique();

            entity.Property(e => e.BusinessEntityID)
                .ValueGeneratedNever()
                .HasComment("Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(15)
                .HasComment("Vendor account (identification) number.");
            entity.Property(e => e.ActiveFlag)
                .HasDefaultValue(true)
                .HasComment("0 = Vendor no longer used. 1 = Vendor is actively used.");
            entity.Property(e => e.CreditRating).HasComment("1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Company name.");
            entity.Property(e => e.PreferredVendorStatus)
                .HasDefaultValue(true)
                .HasComment("0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.");
            entity.Property(e => e.PurchasingWebServiceURL)
                .HasMaxLength(1024)
                .HasComment("Vendor URL.");

            entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Vendor)
                .HasForeignKey<Vendor>(d => d.BusinessEntityID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity.HasKey(e => e.WorkOrderID).HasName("PK_WorkOrder_WorkOrderID");

            entity.ToTable("WorkOrder", "Production", tb =>
                {
                    tb.HasComment("Manufacturing work orders.");
                    tb.HasTrigger("iWorkOrder");
                    tb.HasTrigger("uWorkOrder");
                });

            entity.HasIndex(e => e.ProductID, "IX_WorkOrder_ProductID");

            entity.HasIndex(e => e.ScrapReasonID, "IX_WorkOrder_ScrapReasonID");

            entity.Property(e => e.WorkOrderID).HasComment("Primary key for WorkOrder records.");
            entity.Property(e => e.DueDate)
                .HasComment("Work order due date.")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate)
                .HasComment("Work order end date.")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderQty).HasComment("Product quantity to build.");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.ScrapReasonID).HasComment("Reason for inspection failure.");
            entity.Property(e => e.ScrappedQty).HasComment("Quantity that failed inspection.");
            entity.Property(e => e.StartDate)
                .HasComment("Work order start date.")
                .HasColumnType("datetime");
            entity.Property(e => e.StockedQty)
                .HasComputedColumnSql("(isnull([OrderQty]-[ScrappedQty],(0)))", false)
                .HasComment("Quantity built and put in inventory.");

            entity.HasOne(d => d.Product).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ScrapReason).WithMany(p => p.WorkOrders).HasForeignKey(d => d.ScrapReasonID);
        });

        modelBuilder.Entity<WorkOrderRouting>(entity =>
        {
            entity.HasKey(e => new { e.WorkOrderID, e.ProductID, e.OperationSequence }).HasName("PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence");

            entity.ToTable("WorkOrderRouting", "Production", tb => tb.HasComment("Work order details."));

            entity.HasIndex(e => e.ProductID, "IX_WorkOrderRouting_ProductID");

            entity.Property(e => e.WorkOrderID).HasComment("Primary key. Foreign key to WorkOrder.WorkOrderID.");
            entity.Property(e => e.ProductID).HasComment("Primary key. Foreign key to Product.ProductID.");
            entity.Property(e => e.OperationSequence).HasComment("Primary key. Indicates the manufacturing process sequence.");
            entity.Property(e => e.ActualCost)
                .HasComment("Actual manufacturing cost.")
                .HasColumnType("money");
            entity.Property(e => e.ActualEndDate)
                .HasComment("Actual end date.")
                .HasColumnType("datetime");
            entity.Property(e => e.ActualResourceHrs)
                .HasComment("Number of manufacturing hours used.")
                .HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ActualStartDate)
                .HasComment("Actual start date.")
                .HasColumnType("datetime");
            entity.Property(e => e.LocationID).HasComment("Manufacturing location where the part is processed. Foreign key to Location.LocationID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PlannedCost)
                .HasComment("Estimated manufacturing cost.")
                .HasColumnType("money");
            entity.Property(e => e.ScheduledEndDate)
                .HasComment("Planned manufacturing end date.")
                .HasColumnType("datetime");
            entity.Property(e => e.ScheduledStartDate)
                .HasComment("Planned manufacturing start date.")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Location).WithMany(p => p.WorkOrderRoutings)
                .HasForeignKey(d => d.LocationID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<vAdditionalContactInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAdditionalContactInfo", "Person");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CountryRegion).HasMaxLength(50);
            entity.Property(e => e.EMailAddress).HasMaxLength(128);
            entity.Property(e => e.EMailTelephoneNumber).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.StateProvince).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(50);
            entity.Property(e => e.TelephoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<vEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vEmployee", "HumanResources");

            entity.Property(e => e.AdditionalContactInfo).HasColumnType("xml");
            entity.Property(e => e.AddressLine1).HasMaxLength(60);
            entity.Property(e => e.AddressLine2).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);
        });

        modelBuilder.Entity<vEmployeeDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vEmployeeDepartment", "HumanResources");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);
        });

        modelBuilder.Entity<vEmployeeDepartmentHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vEmployeeDepartmentHistory", "HumanResources");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);
        });

        modelBuilder.Entity<vIndividualCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vIndividualCustomer", "Sales");

            entity.Property(e => e.AddressLine1).HasMaxLength(60);
            entity.Property(e => e.AddressLine2).HasMaxLength(60);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.Demographics).HasColumnType("xml");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);
        });

        modelBuilder.Entity<vJobCandidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vJobCandidate", "HumanResources");

            entity.Property(e => e.Addr_Loc_City)
                .HasMaxLength(100)
                .HasColumnName("Addr.Loc.City");
            entity.Property(e => e.Addr_Loc_CountryRegion)
                .HasMaxLength(100)
                .HasColumnName("Addr.Loc.CountryRegion");
            entity.Property(e => e.Addr_Loc_State)
                .HasMaxLength(100)
                .HasColumnName("Addr.Loc.State");
            entity.Property(e => e.Addr_PostalCode)
                .HasMaxLength(20)
                .HasColumnName("Addr.PostalCode");
            entity.Property(e => e.Addr_Type)
                .HasMaxLength(30)
                .HasColumnName("Addr.Type");
            entity.Property(e => e.JobCandidateID).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name_First)
                .HasMaxLength(30)
                .HasColumnName("Name.First");
            entity.Property(e => e.Name_Last)
                .HasMaxLength(30)
                .HasColumnName("Name.Last");
            entity.Property(e => e.Name_Middle)
                .HasMaxLength(30)
                .HasColumnName("Name.Middle");
            entity.Property(e => e.Name_Prefix)
                .HasMaxLength(30)
                .HasColumnName("Name.Prefix");
            entity.Property(e => e.Name_Suffix)
                .HasMaxLength(30)
                .HasColumnName("Name.Suffix");
        });

        modelBuilder.Entity<vJobCandidateEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vJobCandidateEducation", "HumanResources");

            entity.Property(e => e.Edu_Degree)
                .HasMaxLength(50)
                .HasColumnName("Edu.Degree");
            entity.Property(e => e.Edu_EndDate)
                .HasColumnType("datetime")
                .HasColumnName("Edu.EndDate");
            entity.Property(e => e.Edu_GPA)
                .HasMaxLength(5)
                .HasColumnName("Edu.GPA");
            entity.Property(e => e.Edu_GPAScale)
                .HasMaxLength(5)
                .HasColumnName("Edu.GPAScale");
            entity.Property(e => e.Edu_Level).HasColumnName("Edu.Level");
            entity.Property(e => e.Edu_Loc_City)
                .HasMaxLength(100)
                .HasColumnName("Edu.Loc.City");
            entity.Property(e => e.Edu_Loc_CountryRegion)
                .HasMaxLength(100)
                .HasColumnName("Edu.Loc.CountryRegion");
            entity.Property(e => e.Edu_Loc_State)
                .HasMaxLength(100)
                .HasColumnName("Edu.Loc.State");
            entity.Property(e => e.Edu_Major)
                .HasMaxLength(50)
                .HasColumnName("Edu.Major");
            entity.Property(e => e.Edu_Minor)
                .HasMaxLength(50)
                .HasColumnName("Edu.Minor");
            entity.Property(e => e.Edu_School)
                .HasMaxLength(100)
                .HasColumnName("Edu.School");
            entity.Property(e => e.Edu_StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Edu.StartDate");
            entity.Property(e => e.JobCandidateID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<vJobCandidateEmployment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vJobCandidateEmployment", "HumanResources");

            entity.Property(e => e.Emp_EndDate)
                .HasColumnType("datetime")
                .HasColumnName("Emp.EndDate");
            entity.Property(e => e.Emp_FunctionCategory).HasColumnName("Emp.FunctionCategory");
            entity.Property(e => e.Emp_IndustryCategory).HasColumnName("Emp.IndustryCategory");
            entity.Property(e => e.Emp_JobTitle)
                .HasMaxLength(100)
                .HasColumnName("Emp.JobTitle");
            entity.Property(e => e.Emp_Loc_City).HasColumnName("Emp.Loc.City");
            entity.Property(e => e.Emp_Loc_CountryRegion).HasColumnName("Emp.Loc.CountryRegion");
            entity.Property(e => e.Emp_Loc_State).HasColumnName("Emp.Loc.State");
            entity.Property(e => e.Emp_OrgName)
                .HasMaxLength(100)
                .HasColumnName("Emp.OrgName");
            entity.Property(e => e.Emp_Responsibility).HasColumnName("Emp.Responsibility");
            entity.Property(e => e.Emp_StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Emp.StartDate");
            entity.Property(e => e.JobCandidateID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<vPersonDemographic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPersonDemographics", "Sales");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.DateFirstPurchase).HasColumnType("datetime");
            entity.Property(e => e.Education).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(1);
            entity.Property(e => e.MaritalStatus).HasMaxLength(1);
            entity.Property(e => e.Occupation).HasMaxLength(30);
            entity.Property(e => e.TotalPurchaseYTD).HasColumnType("money");
            entity.Property(e => e.YearlyIncome).HasMaxLength(30);
        });

        modelBuilder.Entity<vProductAndDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vProductAndDescription", "Production");

            entity.Property(e => e.CultureID)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ProductModel).HasMaxLength(50);
        });

        modelBuilder.Entity<vProductModelCatalogDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vProductModelCatalogDescription", "Production");

            entity.Property(e => e.Color).HasMaxLength(256);
            entity.Property(e => e.Copyright).HasMaxLength(30);
            entity.Property(e => e.Crankset).HasMaxLength(256);
            entity.Property(e => e.MaintenanceDescription).HasMaxLength(256);
            entity.Property(e => e.Material).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NoOfYears).HasMaxLength(256);
            entity.Property(e => e.Pedal).HasMaxLength(256);
            entity.Property(e => e.PictureAngle).HasMaxLength(256);
            entity.Property(e => e.PictureSize).HasMaxLength(256);
            entity.Property(e => e.ProductLine).HasMaxLength(256);
            entity.Property(e => e.ProductModelID).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductPhotoID).HasMaxLength(256);
            entity.Property(e => e.ProductURL).HasMaxLength(256);
            entity.Property(e => e.RiderExperience).HasMaxLength(1024);
            entity.Property(e => e.Saddle).HasMaxLength(256);
            entity.Property(e => e.Style).HasMaxLength(256);
            entity.Property(e => e.WarrantyDescription).HasMaxLength(256);
            entity.Property(e => e.WarrantyPeriod).HasMaxLength(256);
            entity.Property(e => e.Wheel).HasMaxLength(256);
        });

        modelBuilder.Entity<vProductModelInstruction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vProductModelInstructions", "Production");

            entity.Property(e => e.LaborHours).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.MachineHours).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ProductModelID).ValueGeneratedOnAdd();
            entity.Property(e => e.SetupHours).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.Step).HasMaxLength(1024);
        });

        modelBuilder.Entity<vSalesPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vSalesPerson", "Sales");

            entity.Property(e => e.AddressLine1).HasMaxLength(60);
            entity.Property(e => e.AddressLine2).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.SalesLastYear).HasColumnType("money");
            entity.Property(e => e.SalesQuota).HasColumnType("money");
            entity.Property(e => e.SalesYTD).HasColumnType("money");
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.TerritoryGroup).HasMaxLength(50);
            entity.Property(e => e.TerritoryName).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(8);
        });

        modelBuilder.Entity<vSalesPersonSalesByFiscalYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vSalesPersonSalesByFiscalYears", "Sales");

            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.SalesTerritory).HasMaxLength(50);
            entity.Property(e => e._2002)
                .HasColumnType("money")
                .HasColumnName("2002");
            entity.Property(e => e._2003)
                .HasColumnType("money")
                .HasColumnName("2003");
            entity.Property(e => e._2004)
                .HasColumnType("money")
                .HasColumnName("2004");
        });

        modelBuilder.Entity<vStateProvinceCountryRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vStateProvinceCountryRegion", "Person");

            entity.Property(e => e.CountryRegionCode).HasMaxLength(3);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.StateProvinceCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
        });

        modelBuilder.Entity<vStoreWithAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vStoreWithAddresses", "Sales");

            entity.Property(e => e.AddressLine1).HasMaxLength(60);
            entity.Property(e => e.AddressLine2).HasMaxLength(60);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
        });

        modelBuilder.Entity<vStoreWithContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vStoreWithContacts", "Sales");

            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);
        });

        modelBuilder.Entity<vStoreWithDemographic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vStoreWithDemographics", "Sales");

            entity.Property(e => e.AnnualRevenue).HasColumnType("money");
            entity.Property(e => e.AnnualSales).HasColumnType("money");
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.Brands).HasMaxLength(30);
            entity.Property(e => e.BusinessType).HasMaxLength(5);
            entity.Property(e => e.Internet).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Specialty).HasMaxLength(50);
        });

        modelBuilder.Entity<vVendorWithAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vVendorWithAddresses", "Purchasing");

            entity.Property(e => e.AddressLine1).HasMaxLength(60);
            entity.Property(e => e.AddressLine2).HasMaxLength(60);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
        });

        modelBuilder.Entity<vVendorWithContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vVendorWithContacts", "Purchasing");

            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);
        });
        //#CRITICAL STOCK#
        // oznaczamy, że to zapytanie‐tylko (bez klucza, bez tabeli/view)
        modelBuilder
          .Entity<CriticalStockViewDTO>()
          .HasNoKey()
          .ToView(null);

        base.OnModelCreating(modelBuilder);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
