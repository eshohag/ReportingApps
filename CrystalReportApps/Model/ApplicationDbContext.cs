using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CrystalReportApps.Model
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<AverageMassCalculation> AverageMassCalculations { get; set; }
        public virtual DbSet<dbAccountInfo> dbAccountInfoes { get; set; }
        public virtual DbSet<dbBankinfo> dbBankinfoes { get; set; }
        public virtual DbSet<dbBankMasterInfo> dbBankMasterInfoes { get; set; }
        public virtual DbSet<dbPartyInfo> dbPartyInfoes { get; set; }
        public virtual DbSet<dbProductInfo> dbProductInfoes { get; set; }
        public virtual DbSet<MassStore> MassStores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAccountDueCollection> tblAccountDueCollections { get; set; }
        public virtual DbSet<tblAccountHistory> tblAccountHistories { get; set; }
        public virtual DbSet<tblAccountTransaction> tblAccountTransactions { get; set; }
        public virtual DbSet<tblBalanceSheet> tblBalanceSheets { get; set; }
        public virtual DbSet<tblBankSummary> tblBankSummaries { get; set; }
        public virtual DbSet<tblBankTransaction> tblBankTransactions { get; set; }
        public virtual DbSet<tblBrokerInformation> tblBrokerInformations { get; set; }
        public virtual DbSet<tbldemo> tbldemoes { get; set; }
        public virtual DbSet<tblExpense> tblExpenses { get; set; }
        public virtual DbSet<tblstock> tblstocks { get; set; }
        public virtual DbSet<tblMasterTransection> tblMasterTransections { get; set; }
        public virtual DbSet<tblPartyTrnasection> tblPartyTrnasections { get; set; }
        public virtual DbSet<tblStore> tblStores { get; set; }
        public virtual DbSet<tblStoreInDetailse> tblStoreInDetailses { get; set; }
        public virtual DbSet<tblStoreInMaster> tblStoreInMasters { get; set; }
        public virtual DbSet<tblStoreOutDetailse> tblStoreOutDetailses { get; set; }
        public virtual DbSet<tblStoreOutMaster> tblStoreOutMasters { get; set; }
        public virtual DbSet<tblVoucherNo> tblVoucherNoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dbAccountInfo>()
                .HasMany(e => e.tblMasterTransections)
                .WithOptional(e => e.dbAccountInfo)
                .HasForeignKey(e => e.AccountId);

            modelBuilder.Entity<dbAccountInfo>()
                .HasMany(e => e.tblStoreInMasters)
                .WithOptional(e => e.dbAccountInfo)
                .HasForeignKey(e => e.AccountId);

            modelBuilder.Entity<dbProductInfo>()
                .HasMany(e => e.tblStores)
                .WithOptional(e => e.dbProductInfo)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<tblAccountDueCollection>()
                .Property(e => e.DueAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblAccountDueCollection>()
                .Property(e => e.DebitAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblAccountDueCollection>()
                .Property(e => e.CredtiAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblAccountHistory>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblAccountHistory>()
                .Property(e => e.CreditAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblAccountTransaction>()
                .Property(e => e.GrandTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblAccountTransaction>()
                .Property(e => e.ReciveAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.Balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.TotalSale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.ClientDebit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.BankDebit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.ExpenseDebit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.Part1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.BankCredit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.ClientCredit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.labour)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.ExpenseCredit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.Part2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.CashInHand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.PrevAccReceiv)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.TAR)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.CashCollected)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBalanceSheet>()
                .Property(e => e.Summary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblstock>()
                .Property(e => e.PurchaseQty)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblstock>()
                .Property(e => e.SaleQty)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblMasterTransection>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblMasterTransection>()
                .Property(e => e.Cr_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblMasterTransection>()
                .Property(e => e.Dr_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblMasterTransection>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tblMasterTransection>()
                .Property(e => e.TransectionType)
                .IsUnicode(false);

            modelBuilder.Entity<tblMasterTransection>()
                .Property(e => e.MakeBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartyTrnasection>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartyTrnasection>()
                .Property(e => e.DueInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartyTrnasection>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartyTrnasection>()
                .Property(e => e.makeBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartyTrnasection>()
                .Property(e => e.updateBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartyTrnasection>()
                .Property(e => e.deleteBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblStore>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblStore>()
                .Property(e => e.TransetionType)
                .IsUnicode(false);

            modelBuilder.Entity<tblStore>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tblStore>()
                .Property(e => e.Cr_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblStore>()
                .Property(e => e.Dr_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblStore>()
                .Property(e => e.MakeBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreInDetailse>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreInDetailse>()
                .Property(e => e.Qty)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblStoreInDetailse>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblStoreInDetailse>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreInDetailse>()
                .Property(e => e.MakeBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreInMaster>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreInMaster>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblStoreInMaster>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreInMaster>()
                .Property(e => e.MakeBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreOutDetailse>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreOutDetailse>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreOutMaster>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblStoreOutMaster>()
                .Property(e => e.MakeBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblVoucherNo>()
                .Property(e => e.vcNo)
                .IsUnicode(false);
        }
    }
}
