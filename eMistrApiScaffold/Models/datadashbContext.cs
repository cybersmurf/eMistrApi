using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eMistrApiScaffold.Models
{
    public partial class datadashbContext : DbContext
    {
        public datadashbContext()
        {
        }

        public datadashbContext(DbContextOptions<datadashbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoLogin> AutoLogin { get; set; }
        public virtual DbSet<COrder> COrder { get; set; }
        public virtual DbSet<COrderDoc> COrderDoc { get; set; }
        public virtual DbSet<Calc> Calc { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<CalendarDay> CalendarDay { get; set; }
        public virtual DbSet<Cidla> Cidla { get; set; }
        public virtual DbSet<CidlaReaddata> CidlaReaddata { get; set; }
        public virtual DbSet<CisDen> CisDen { get; set; }
        public virtual DbSet<CisFrekvence> CisFrekvence { get; set; }
        public virtual DbSet<CisPozice> CisPozice { get; set; }
        public virtual DbSet<CisPracovniSkupina> CisPracovniSkupina { get; set; }
        public virtual DbSet<CisTypProvoz> CisTypProvoz { get; set; }
        public virtual DbSet<CisTypSmeny> CisTypSmeny { get; set; }
        public virtual DbSet<CiselneRady> CiselneRady { get; set; }
        public virtual DbSet<CncGroup> CncGroup { get; set; }
        public virtual DbSet<CncImportCasu> CncImportCasu { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Columns> Columns { get; set; }
        public virtual DbSet<ColumnsBackup> ColumnsBackup { get; set; }
        public virtual DbSet<ColumnsCaption> ColumnsCaption { get; set; }
        public virtual DbSet<ColumnsLog> ColumnsLog { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAdresy> CustomerAdresy { get; set; }
        public virtual DbSet<CustomerOsoby> CustomerOsoby { get; set; }
        public virtual DbSet<CustomerUdalosti> CustomerUdalosti { get; set; }
        public virtual DbSet<CustomerUdalostiTypy> CustomerUdalostiTypy { get; set; }
        public virtual DbSet<Datum> Datum { get; set; }
        public virtual DbSet<Dochazka> Dochazka { get; set; }
        public virtual DbSet<DochazkaMirror> DochazkaMirror { get; set; }
        public virtual DbSet<DochazkaNote> DochazkaNote { get; set; }
        public virtual DbSet<DodaciListy> DodaciListy { get; set; }
        public virtual DbSet<DodaciListyPolozky> DodaciListyPolozky { get; set; }
        public virtual DbSet<DodaciListyZauctovano> DodaciListyZauctovano { get; set; }
        public virtual DbSet<Faktury> Faktury { get; set; }
        public virtual DbSet<FormCaptionHook> FormCaptionHook { get; set; }
        public virtual DbSet<FormySkupina> FormySkupina { get; set; }
        public virtual DbSet<GdprFields> GdprFields { get; set; }
        public virtual DbSet<GdprLogs> GdprLogs { get; set; }
        public virtual DbSet<GdprSettings> GdprSettings { get; set; }
        public virtual DbSet<GlobalSettings> GlobalSettings { get; set; }
        public virtual DbSet<Hnizda> Hnizda { get; set; }
        public virtual DbSet<HnizdaLogins> HnizdaLogins { get; set; }
        public virtual DbSet<InetFilters> InetFilters { get; set; }
        public virtual DbSet<Jednotky> Jednotky { get; set; }
        public virtual DbSet<Kraticka> Kraticka { get; set; }
        public virtual DbSet<Kurz> Kurz { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialPredpokladany> MaterialPredpokladany { get; set; }
        public virtual DbSet<Materialy> Materialy { get; set; }
        public virtual DbSet<NabidkaPolozky> NabidkaPolozky { get; set; }
        public virtual DbSet<NaradiSkupina> NaradiSkupina { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Objednavky> Objednavky { get; set; }
        public virtual DbSet<ObjednavkyPolozky> ObjednavkyPolozky { get; set; }
        public virtual DbSet<ObjednavkyPrijate> ObjednavkyPrijate { get; set; }
        public virtual DbSet<ObjednavkyPrijatePolozky> ObjednavkyPrijatePolozky { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<OperationDefault> OperationDefault { get; set; }
        public virtual DbSet<OperationGroup> OperationGroup { get; set; }
        public virtual DbSet<OrderCalcList> OrderCalcList { get; set; }
        public virtual DbSet<OrderFilter> OrderFilter { get; set; }
        public virtual DbSet<OrderPriorityFont> OrderPriorityFont { get; set; }
        public virtual DbSet<OrderStav> OrderStav { get; set; }
        public virtual DbSet<OrderUrovne> OrderUrovne { get; set; }
        public virtual DbSet<OrderWork> OrderWork { get; set; }
        public virtual DbSet<OrderWorkPlan> OrderWorkPlan { get; set; }
        public virtual DbSet<Packages> Packages { get; set; }
        public virtual DbSet<Pausal> Pausal { get; set; }
        public virtual DbSet<PlanGroupSmeny> PlanGroupSmeny { get; set; }
        public virtual DbSet<PlanMistoPrace> PlanMistoPrace { get; set; }
        public virtual DbSet<PlanNaDen> PlanNaDen { get; set; }
        public virtual DbSet<PlanSmena> PlanSmena { get; set; }
        public virtual DbSet<PlanSmenaNaDen> PlanSmenaNaDen { get; set; }
        public virtual DbSet<PlanSmenaSkupina> PlanSmenaSkupina { get; set; }
        public virtual DbSet<PlanStandardniSmena> PlanStandardniSmena { get; set; }
        public virtual DbSet<PlanWorker> PlanWorker { get; set; }
        public virtual DbSet<PlanWorkerSkupina> PlanWorkerSkupina { get; set; }
        public virtual DbSet<Pozice> Pozice { get; set; }
        public virtual DbSet<ProhlidkyStroje> ProhlidkyStroje { get; set; }
        public virtual DbSet<PruvList> PruvList { get; set; }
        public virtual DbSet<Readdata> Readdata { get; set; }
        public virtual DbSet<ReaddataCeny> ReaddataCeny { get; set; }
        public virtual DbSet<ReaddataFoto> ReaddataFoto { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<RefOperationCnc> RefOperationCnc { get; set; }
        public virtual DbSet<RefOperationWorker> RefOperationWorker { get; set; }
        public virtual DbSet<RefUserOrderstav> RefUserOrderstav { get; set; }
        public virtual DbSet<RefUserOrdertyp> RefUserOrdertyp { get; set; }
        public virtual DbSet<RefWorkerCnc> RefWorkerCnc { get; set; }
        public virtual DbSet<Registrace> Registrace { get; set; }
        public virtual DbSet<RepairType> RepairType { get; set; }
        public virtual DbSet<SablonyOperationGroup> SablonyOperationGroup { get; set; }
        public virtual DbSet<SablonySkladGroup> SablonySkladGroup { get; set; }
        public virtual DbSet<Schedulerresource> Schedulerresource { get; set; }
        public virtual DbSet<Schedulertable> Schedulertable { get; set; }
        public virtual DbSet<Script> Script { get; set; }
        public virtual DbSet<SerialCode> SerialCode { get; set; }
        public virtual DbSet<ServisTyp> ServisTyp { get; set; }
        public virtual DbSet<ServisTypRefStroje> ServisTypRefStroje { get; set; }
        public virtual DbSet<SkladFormy> SkladFormy { get; set; }
        public virtual DbSet<SkladFormyPohyb> SkladFormyPohyb { get; set; }
        public virtual DbSet<SkladFormyReaddata> SkladFormyReaddata { get; set; }
        public virtual DbSet<SkladInventura> SkladInventura { get; set; }
        public virtual DbSet<SkladInventuraPolozky> SkladInventuraPolozky { get; set; }
        public virtual DbSet<SkladInventuraSoupisy> SkladInventuraSoupisy { get; set; }
        public virtual DbSet<SkladMaterial> SkladMaterial { get; set; }
        public virtual DbSet<SkladMaterialDoc> SkladMaterialDoc { get; set; }
        public virtual DbSet<SkladMaterialDodavatele> SkladMaterialDodavatele { get; set; }
        public virtual DbSet<SkladMaterialPohyb> SkladMaterialPohyb { get; set; }
        public virtual DbSet<SkladMaterialPozice> SkladMaterialPozice { get; set; }
        public virtual DbSet<SkladMaterialPoziceReaddata> SkladMaterialPoziceReaddata { get; set; }
        public virtual DbSet<SkladMaterialPrijemky> SkladMaterialPrijemky { get; set; }
        public virtual DbSet<SkladMaterialPrijemkyTypy> SkladMaterialPrijemkyTypy { get; set; }
        public virtual DbSet<SkladMaterialReaddata> SkladMaterialReaddata { get; set; }
        public virtual DbSet<SkladMaterialTvar> SkladMaterialTvar { get; set; }
        public virtual DbSet<SkladMaterialVydejky> SkladMaterialVydejky { get; set; }
        public virtual DbSet<SkladMaterialVydejkyTypy> SkladMaterialVydejkyTypy { get; set; }
        public virtual DbSet<SkladNaradi> SkladNaradi { get; set; }
        public virtual DbSet<SkladNaradiPohyb> SkladNaradiPohyb { get; set; }
        public virtual DbSet<SkladNaradiReaddata> SkladNaradiReaddata { get; set; }
        public virtual DbSet<SkladNaradiStav> SkladNaradiStav { get; set; }
        public virtual DbSet<SkladSkupiny> SkladSkupiny { get; set; }
        public virtual DbSet<SkladyMaterialu> SkladyMaterialu { get; set; }
        public virtual DbSet<SpLog> SpLog { get; set; }
        public virtual DbSet<SpSettings> SpSettings { get; set; }
        public virtual DbSet<Stavydokladu> Stavydokladu { get; set; }
        public virtual DbSet<StrojGroup> StrojGroup { get; set; }
        public virtual DbSet<Stroje> Stroje { get; set; }
        public virtual DbSet<Subdodavky> Subdodavky { get; set; }
        public virtual DbSet<SwTerm> SwTerm { get; set; }
        public virtual DbSet<SwtermRozdel> SwtermRozdel { get; set; }
        public virtual DbSet<System> System { get; set; }
        public virtual DbSet<TechPostup> TechPostup { get; set; }
        public virtual DbSet<TechPostupPolozky> TechPostupPolozky { get; set; }
        public virtual DbSet<Temp> Temp { get; set; }
        public virtual DbSet<Temp2> Temp2 { get; set; }
        public virtual DbSet<Terminal> Terminal { get; set; }
        public virtual DbSet<TiskFormulare> TiskFormulare { get; set; }
        public virtual DbSet<TiskHlavicka> TiskHlavicka { get; set; }
        public virtual DbSet<TiskHlavickaNazvy> TiskHlavickaNazvy { get; set; }
        public virtual DbSet<TiskPrava> TiskPrava { get; set; }
        public virtual DbSet<TypBaleni> TypBaleni { get; set; }
        public virtual DbSet<TypZasilky> TypZasilky { get; set; }
        public virtual DbSet<UkolmzdaTyp> UkolmzdaTyp { get; set; }
        public virtual DbSet<Ukoly> Ukoly { get; set; }
        public virtual DbSet<UkolyOpakovani> UkolyOpakovani { get; set; }
        public virtual DbSet<UkolyPodminky> UkolyPodminky { get; set; }
        public virtual DbSet<UkolyStavy> UkolyStavy { get; set; }
        public virtual DbSet<UserPrintSettings> UserPrintSettings { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<Userlist> Userlist { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UzamceneObdobi> UzamceneObdobi { get; set; }
        public virtual DbSet<UzavreniZakazek> UzavreniZakazek { get; set; }
        public virtual DbSet<VyrobniCalc> VyrobniCalc { get; set; }
        public virtual DbSet<VyrobniCalcMaterial> VyrobniCalcMaterial { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
        public virtual DbSet<WorkerCidla> WorkerCidla { get; set; }
        public virtual DbSet<WorkerProskoleni> WorkerProskoleni { get; set; }
        public virtual DbSet<WorkerProskoleniDruh> WorkerProskoleniDruh { get; set; }
        public virtual DbSet<WorkerProskoleniReaddata> WorkerProskoleniReaddata { get; set; }
        public virtual DbSet<WorkerProskoleniTyp> WorkerProskoleniTyp { get; set; }
        public virtual DbSet<WorkerSmeny> WorkerSmeny { get; set; }
        public virtual DbSet<ZakazkyObjednavky> ZakazkyObjednavky { get; set; }
        public virtual DbSet<ZpusobDopravy> ZpusobDopravy { get; set; }
        public virtual DbSet<ZpusobPlatby> ZpusobPlatby { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySql("server=192.168.11.5;port=3306;user=pracant;password=tnacarp;database=datadashb", x => x.ServerVersion("10.1.43-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoLogin>(entity =>
            {
                entity.ToTable("auto_login");

                entity.HasComment("Tabulka pro ulozeni posledniho prihlaseni");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Pc)
                    .IsRequired()
                    .HasColumnName("pc")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<COrder>(entity =>
            {
                entity.ToTable("c_order");

                entity.HasComment("Zakázky");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.BarId)
                    .HasName("UK_c_order_bar_id")
                    .IsUnique();

                entity.HasIndex(e => e.CiselnaVolitelna1)
                    .HasName("ciselna_volitelna1");

                entity.HasIndex(e => e.CiselnaVolitelna2)
                    .HasName("ciselna_volitelna2");

                entity.HasIndex(e => e.CiselnaVolitelna3)
                    .HasName("ciselna_volitelna3");

                entity.HasIndex(e => e.CiselnaVolitelna4)
                    .HasName("ciselna_volitelna4");

                entity.HasIndex(e => e.CiselnaVolitelna5)
                    .HasName("ciselna_volitelna5");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.HasIndex(e => e.CreatedMatId)
                    .HasName("created_mat_id");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.DatumExpedice)
                    .HasName("datumExpedice");

                entity.HasIndex(e => e.DispTree)
                    .HasName("dispTree");

                entity.HasIndex(e => e.Drawing)
                    .HasName("drawing");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.FinishVyroba)
                    .HasName("finishVyroba");

                entity.HasIndex(e => e.ForcePrepocet)
                    .HasName("force_prepocet");

                entity.HasIndex(e => e.GdprZbyva)
                    .HasName("gdpr_zbyva");

                entity.HasIndex(e => e.MasterOrderId)
                    .HasName("masterOrderId");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OrderCenaJednotka)
                    .HasName("order_cena_jednotka");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.HasIndex(e => e.Rozmer1)
                    .HasName("rozmer1");

                entity.HasIndex(e => e.Rozmer2)
                    .HasName("rozmer2");

                entity.HasIndex(e => e.Rozmer3)
                    .HasName("rozmer3");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.StartVyroba)
                    .HasName("startVyroba");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.HasIndex(e => e.Uroven)
                    .HasName("uroven");

                entity.HasIndex(e => e.Volitelna10)
                    .HasName("volitelna10");

                entity.HasIndex(e => e.Volitelna15)
                    .HasName("volitelna15");

                entity.HasIndex(e => e.Volitelna16)
                    .HasName("volitelna16");

                entity.HasIndex(e => e.Volitelna3)
                    .HasName("volitelna3");

                entity.HasIndex(e => e.ZpusobDopravyId)
                    .HasName("zpusob_dopravy_id");

                entity.HasIndex(e => new { e.BarId, e.DispTree })
                    .HasName("bar_id,dispTree");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Baliku1)
                    .HasColumnName("baliku1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Baliku2)
                    .HasColumnName("baliku2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Baliku3)
                    .HasColumnName("baliku3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CiselnaVolitelna1)
                    .HasColumnName("ciselna_volitelna1")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.CiselnaVolitelna2)
                    .HasColumnName("ciselna_volitelna2")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.CiselnaVolitelna3)
                    .HasColumnName("ciselna_volitelna3")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.CiselnaVolitelna4)
                    .HasColumnName("ciselna_volitelna4")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.CiselnaVolitelna5)
                    .HasColumnName("ciselna_volitelna5")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.CiselnaVolitelna6)
                    .HasColumnName("ciselna_volitelna6")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.CisloObjednavky)
                    .IsRequired()
                    .HasColumnName("cislo_objednavky")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Created)
                    .IsRequired()
                    .HasColumnName("created")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CreatedMatId)
                    .HasColumnName("created_mat_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CustomerIdAdresa)
                    .HasColumnName("customer_id_adresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DatumExpedice)
                    .HasColumnName("datumExpedice")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Datumcaszmeny)
                    .HasColumnName("datumcaszmeny")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DatumovaVolitelna1)
                    .HasColumnName("datumova_volitelna1")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DatumovaVolitelna2)
                    .HasColumnName("datumova_volitelna2")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DatumovaVolitelna3)
                    .HasColumnName("datumova_volitelna3")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DatumovaVolitelna4)
                    .HasColumnName("datumova_volitelna4")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DispTree)
                    .IsRequired()
                    .HasColumnName("dispTree")
                    .HasColumnType("varchar(72)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Drawing)
                    .IsRequired()
                    .HasColumnName("drawing")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DruhaMenaZkratka)
                    .IsRequired()
                    .HasColumnName("druha_mena_zkratka")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EmailUpozornovat)
                    .HasColumnName("email_upozornovat")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Expandovano)
                    .HasColumnName("expandovano")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.ExterniFaktura)
                    .HasColumnName("externi_faktura")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.FinishVyroba)
                    .HasColumnName("finishVyroba")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ForcePrepocet)
                    .HasColumnName("force_prepocet")
                    .HasColumnType("int(5)");

                entity.Property(e => e.GdprAnonymizovano)
                    .HasColumnName("gdpr_anonymizovano")
                    .HasColumnType("int(5)");

                entity.Property(e => e.GdprZbyva)
                    .HasColumnName("gdpr_zbyva")
                    .HasColumnType("int(5)");

                entity.Property(e => e.HasDocs)
                    .HasColumnName("has_docs")
                    .HasColumnType("int(3)");

                entity.Property(e => e.IdCiselnaRada)
                    .HasColumnName("id_ciselna_rada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPohoda)
                    .IsRequired()
                    .HasColumnName("id_pohoda")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IntBarId)
                    .HasColumnName("int_bar_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'9999999999'");

                entity.Property(e => e.IsSablona)
                    .HasColumnName("is_sablona")
                    .HasColumnType("int(1)");

                entity.Property(e => e.KoeficientOn)
                    .HasColumnName("koeficient_on")
                    .HasColumnType("decimal(15,2)")
                    .HasDefaultValueSql("'1.00'");

                entity.Property(e => e.Kusu)
                    .HasColumnName("kusu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.LastOp)
                    .HasColumnName("last_op")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MasterOrderId)
                    .HasColumnName("masterOrderId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MontazDate)
                    .HasColumnName("montaz_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.MontazTime)
                    .HasColumnName("montaz_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note2)
                    .HasColumnName("note2")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NoteNabidka)
                    .HasColumnName("note_nabidka")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OdmenyPredpoklad)
                    .HasColumnName("odmeny_predpoklad")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.OdmenyVyuctovano)
                    .HasColumnName("odmeny_vyuctovano")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.OkenUnit)
                    .HasColumnName("oken_unit")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OperationGroupId)
                    .HasColumnName("operation_group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderCenaJednotka)
                    .HasColumnName("order_cena_jednotka")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PlanKalendar)
                    .HasColumnName("plan_kalendar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PocetKlt)
                    .HasColumnName("pocetKlt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrefixCiselnaRada)
                    .IsRequired()
                    .HasColumnName("prefix_ciselna_rada")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Prevedeno)
                    .HasColumnName("prevedeno")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.PriceUkony)
                    .HasColumnName("price_ukony")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Priorita)
                    .HasColumnName("priorita")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RealMzda)
                    .HasColumnName("real_mzda")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.RealPrice)
                    .HasColumnName("real_price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.RealPrice2)
                    .HasColumnName("real_price2")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.RealTime)
                    .HasColumnName("real_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rozmer1)
                    .HasColumnName("rozmer1")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Rozmer2)
                    .HasColumnName("rozmer2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Rozmer3)
                    .HasColumnName("rozmer3")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.SkladGroupId)
                    .HasColumnName("sklad_group_id")
                    .HasColumnType("int(16)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.StartVyroba)
                    .HasColumnName("startVyroba")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TechpostupId)
                    .HasColumnName("techpostup_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(5)");

                entity.Property(e => e.TypVypoctuCeny)
                    .HasColumnName("typ_vypoctu_ceny")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Ukon10Planks)
                    .HasColumnName("ukon10_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon10Vyrobenoks)
                    .HasColumnName("ukon10_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon11Planks)
                    .HasColumnName("ukon11_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon11Vyrobenoks)
                    .HasColumnName("ukon11_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon12Planks)
                    .HasColumnName("ukon12_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon12Vyrobenoks)
                    .HasColumnName("ukon12_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon13Planks)
                    .HasColumnName("ukon13_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon13Vyrobenoks)
                    .HasColumnName("ukon13_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon14Planks)
                    .HasColumnName("ukon14_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon14Vyrobenoks)
                    .HasColumnName("ukon14_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon15Planks)
                    .HasColumnName("ukon15_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon15Vyrobenoks)
                    .HasColumnName("ukon15_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon1Planks)
                    .HasColumnName("ukon1_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon1Vyrobenoks)
                    .HasColumnName("ukon1_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon2Planks)
                    .HasColumnName("ukon2_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon2Vyrobenoks)
                    .HasColumnName("ukon2_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon3Planks)
                    .HasColumnName("ukon3_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon3Vyrobenoks)
                    .HasColumnName("ukon3_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon4Planks)
                    .HasColumnName("ukon4_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon4Vyrobenoks)
                    .HasColumnName("ukon4_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon5Planks)
                    .HasColumnName("ukon5_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon5Vyrobenoks)
                    .HasColumnName("ukon5_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon6Planks)
                    .HasColumnName("ukon6_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon6Vyrobenoks)
                    .HasColumnName("ukon6_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon7Planks)
                    .HasColumnName("ukon7_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon7Vyrobenoks)
                    .HasColumnName("ukon7_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon8Planks)
                    .HasColumnName("ukon8_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon8Vyrobenoks)
                    .HasColumnName("ukon8_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon9Planks)
                    .HasColumnName("ukon9_planks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Ukon9Vyrobenoks)
                    .HasColumnName("ukon9_vyrobenoks")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Unirec)
                    .HasColumnName("unirec")
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Uroven)
                    .HasColumnName("uroven")
                    .HasColumnType("int(2)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserPrice)
                    .HasColumnName("user_price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.UserPriceMat)
                    .HasColumnName("user_price_mat")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.UserPriceSub)
                    .HasColumnName("user_price_sub")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.UserPriceWork)
                    .HasColumnName("user_price_work")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.UserTime)
                    .HasColumnName("user_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserTimeKsSecond)
                    .HasColumnName("user_time_ks_second")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserTimeOrder)
                    .HasColumnName("user_time_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Viceprace)
                    .HasColumnName("viceprace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Volitelna1)
                    .IsRequired()
                    .HasColumnName("volitelna1")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna10)
                    .IsRequired()
                    .HasColumnName("volitelna10")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna11)
                    .HasColumnName("volitelna11")
                    .HasColumnType("varchar(200)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna12)
                    .HasColumnName("volitelna12")
                    .HasColumnType("varchar(200)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna13)
                    .IsRequired()
                    .HasColumnName("volitelna13")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna14)
                    .IsRequired()
                    .HasColumnName("volitelna14")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna15)
                    .IsRequired()
                    .HasColumnName("volitelna15")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna16)
                    .IsRequired()
                    .HasColumnName("volitelna16")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna2)
                    .IsRequired()
                    .HasColumnName("volitelna2")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna3)
                    .IsRequired()
                    .HasColumnName("volitelna3")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna4)
                    .IsRequired()
                    .HasColumnName("volitelna4")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna5)
                    .IsRequired()
                    .HasColumnName("volitelna5")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna6)
                    .IsRequired()
                    .HasColumnName("volitelna6")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna7)
                    .IsRequired()
                    .HasColumnName("volitelna7")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna8)
                    .IsRequired()
                    .HasColumnName("volitelna8")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna9)
                    .IsRequired()
                    .HasColumnName("volitelna9")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VykresZeSouboru)
                    .HasColumnName("vykres_ze_souboru")
                    .HasColumnType("int(2)");

                entity.Property(e => e.VypoctenoVyrobeno)
                    .HasColumnName("vypocteno_vyrobeno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZpusobDopravyId)
                    .HasColumnName("zpusob_dopravy_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<COrderDoc>(entity =>
            {
                entity.ToTable("c_order_doc");

                entity.HasComment("Dokumenty k zakázkám");

                entity.HasIndex(e => e.DefaultDocument)
                    .HasName("defaultDocument");

                entity.HasIndex(e => e.ExternalListIdRecord)
                    .HasName("external_list_id_record");

                entity.HasIndex(e => e.ExternalListType)
                    .HasName("external_list_type");

                entity.HasIndex(e => e.IsFile)
                    .HasName("isFile");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Path)
                    .HasName("path");

                entity.HasIndex(e => e.ZobrazitNahled)
                    .HasName("zobrazitNahled");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultDocument)
                    .HasColumnName("defaultDocument")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ExternalListIdRecord)
                    .HasColumnName("external_list_id_record")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExternalListType)
                    .IsRequired()
                    .HasColumnName("external_list_type")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IsFile)
                    .HasColumnName("isFile")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZobrazitNahled)
                    .HasColumnName("zobrazitNahled")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<Calc>(entity =>
            {
                entity.ToTable("calc");

                entity.HasComment("Materiálová kalkulaèka");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.MaterialId2)
                    .HasName("material_id2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Koeficient)
                    .HasColumnName("koeficient")
                    .HasColumnType("decimal(9,3)");

                entity.Property(e => e.Koeficient2)
                    .HasColumnName("koeficient2")
                    .HasColumnType("decimal(9,3)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(25)");

                entity.Property(e => e.MaterialId2)
                    .HasColumnName("material_id2")
                    .HasColumnType("int(25)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.ToTable("calendar");

                entity.HasComment("Pracovní kalendáø");

                entity.HasIndex(e => e.Month)
                    .HasName("month");

                entity.HasIndex(e => e.Year)
                    .HasName("year");

                entity.HasIndex(e => new { e.Year, e.Month })
                    .HasName("slozenyIndex");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasColumnName("days")
                    .HasColumnType("varchar(31)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<CalendarDay>(entity =>
            {
                entity.HasKey(e => e.CalendarDate)
                    .HasName("PRIMARY");

                entity.ToTable("calendar_day");

                entity.HasIndex(e => new { e.CalendarDate, e.CalendarInt })
                    .HasName("date_int");

                entity.HasIndex(e => new { e.CalendarDate, e.CalendarInt, e.CalendarDateType })
                    .HasName("date_int_type");

                entity.Property(e => e.CalendarDate)
                    .HasColumnName("calendar_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.CalendarDateType)
                    .IsRequired()
                    .HasColumnName("calendar_date_type")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'D'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CalendarInt)
                    .HasColumnName("calendar_int")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<Cidla>(entity =>
            {
                entity.ToTable("cidla");

                entity.HasComment("Tabulka cidel");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CidlaReaddata>(entity =>
            {
                entity.ToTable("cidla_readdata");

                entity.HasComment("Nactena data cidel");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cas)
                    .HasColumnName("cas")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CidloId)
                    .HasColumnName("cidlo_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CisDen>(entity =>
            {
                entity.HasKey(e => e.IdDen)
                    .HasName("PRIMARY");

                entity.ToTable("cis_den");

                entity.HasComment("Èíselník dnù");

                entity.Property(e => e.IdDen)
                    .HasColumnName("id_den")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CisFrekvence>(entity =>
            {
                entity.ToTable("cis_frekvence");

                entity.HasComment("CIS_FREKVENCE");

                entity.HasIndex(e => e.Kod)
                    .HasName("kod");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kod)
                    .HasColumnName("kod")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(10)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CisPozice>(entity =>
            {
                entity.HasKey(e => e.IdPozice)
                    .HasName("PRIMARY");

                entity.ToTable("cis_pozice");

                entity.HasComment("Èíselník pracovních pozic");

                entity.Property(e => e.IdPozice)
                    .HasColumnName("id_pozice")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PopisFunkce)
                    .IsRequired()
                    .HasColumnName("popis_funkce")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CisPracovniSkupina>(entity =>
            {
                entity.HasKey(e => e.IdPracovniSkupina)
                    .HasName("PRIMARY");

                entity.ToTable("cis_pracovni_skupina");

                entity.HasComment("Èíselník pracovních skupin");

                entity.Property(e => e.IdPracovniSkupina)
                    .HasColumnName("id_pracovni_skupina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vyroba)
                    .HasColumnName("vyroba")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CisTypProvoz>(entity =>
            {
                entity.HasKey(e => e.IdTypProvoz)
                    .HasName("PRIMARY");

                entity.ToTable("cis_typ_provoz");

                entity.HasComment("Èíselník typù provozù");

                entity.Property(e => e.IdTypProvoz)
                    .HasColumnName("id_typ_provoz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DenniFond)
                    .HasColumnName("denni_fond")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.FondHodin)
                    .HasColumnName("fond_hodin")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CisTypSmeny>(entity =>
            {
                entity.HasKey(e => e.IdTypSmeny)
                    .HasName("PRIMARY");

                entity.ToTable("cis_typ_smeny");

                entity.HasComment("èíselník smìn");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZobrazitVPlanu)
                    .HasColumnName("zobrazit_v_planu")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CiselneRady>(entity =>
            {
                entity.ToTable("ciselne_rady");

                entity.HasComment("Tabulka ciselnych rad");

                entity.HasIndex(e => e.Agenda)
                    .HasName("agenda");

                entity.HasIndex(e => e.Aktivni)
                    .HasName("aktivni");

                entity.HasIndex(e => e.Cislo)
                    .HasName("cislo");

                entity.HasIndex(e => e.Defaultni)
                    .HasName("defaultni");

                entity.HasIndex(e => e.Nazev)
                    .HasName("nazev");

                entity.HasIndex(e => e.Prefix)
                    .HasName("prefix");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Agenda)
                    .IsRequired()
                    .HasColumnName("agenda")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Aktivni)
                    .HasColumnName("aktivni")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Cislo)
                    .IsRequired()
                    .HasColumnName("cislo")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Defaultni)
                    .HasColumnName("defaultni")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oddelovac)
                    .IsRequired()
                    .HasColumnName("oddelovac")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sufix)
                    .IsRequired()
                    .HasColumnName("sufix")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CncGroup>(entity =>
            {
                entity.ToTable("cnc_group");

                entity.HasComment("Skupiny CNC stroju");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CncImportCasu>(entity =>
            {
                entity.ToTable("cnc_import_casu");

                entity.HasComment("Tabulka importovaných èasù pro CNC");

                entity.HasIndex(e => e.CncId)
                    .HasName("cnc_id");

                entity.HasIndex(e => e.CncName)
                    .HasName("cnc_name");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.Imported)
                    .HasName("imported");

                entity.HasIndex(e => e.ImportedDatetime)
                    .HasName("imported_datetime");

                entity.HasIndex(e => e.Mnozstvi)
                    .HasName("mnozstvi");

                entity.HasIndex(e => e.Note)
                    .HasName("note");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Processed)
                    .HasName("processed");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncId)
                    .HasColumnName("cnc_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncName)
                    .IsRequired()
                    .HasColumnName("cnc_name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.Imported)
                    .HasColumnName("imported")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ImportedDatetime)
                    .HasColumnName("imported_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'-1'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Colors>(entity =>
            {
                entity.ToTable("colors");

                entity.HasComment("Tabulka nastavení uživatelských barev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color1)
                    .HasColumnName("color1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'16711680'");

                entity.Property(e => e.Color10)
                    .HasColumnName("color10")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color11)
                    .HasColumnName("color11")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color12)
                    .HasColumnName("color12")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color13)
                    .HasColumnName("color13")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.Color14)
                    .HasColumnName("color14")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color15)
                    .HasColumnName("color15")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color16)
                    .HasColumnName("color16")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color17)
                    .HasColumnName("color17")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color18)
                    .HasColumnName("color18")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color19)
                    .HasColumnName("color19")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color2)
                    .HasColumnName("color2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color20)
                    .HasColumnName("color20")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color21)
                    .HasColumnName("color21")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color22)
                    .HasColumnName("color22")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color23)
                    .HasColumnName("color23")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color24)
                    .HasColumnName("color24")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color25)
                    .HasColumnName("color25")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color26)
                    .HasColumnName("color26")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color27)
                    .HasColumnName("color27")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color28)
                    .HasColumnName("color28")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color29)
                    .HasColumnName("color29")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color3)
                    .HasColumnName("color3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color30)
                    .HasColumnName("color30")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color31)
                    .HasColumnName("color31")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color32)
                    .HasColumnName("color32")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color33)
                    .HasColumnName("color33")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color34)
                    .HasColumnName("color34")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color35)
                    .HasColumnName("color35")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color36)
                    .HasColumnName("color36")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color37)
                    .HasColumnName("color37")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color38)
                    .HasColumnName("color38")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color39)
                    .HasColumnName("color39")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color4)
                    .HasColumnName("color4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color40)
                    .HasColumnName("color40")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color41)
                    .HasColumnName("color41")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color42)
                    .HasColumnName("color42")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color43)
                    .HasColumnName("color43")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color44)
                    .HasColumnName("color44")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color45)
                    .HasColumnName("color45")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'16711680'");

                entity.Property(e => e.Color46)
                    .HasColumnName("color46")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8388608'");

                entity.Property(e => e.Color47)
                    .HasColumnName("color47")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.Color48)
                    .HasColumnName("color48")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.Color49)
                    .HasColumnName("color49")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.Color5)
                    .HasColumnName("color5")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'32768'");

                entity.Property(e => e.Color50)
                    .HasColumnName("color50")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color51)
                    .HasColumnName("color51")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color52)
                    .HasColumnName("color52")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color53)
                    .HasColumnName("color53")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color54)
                    .HasColumnName("color54")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color55)
                    .HasColumnName("color55")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'32768'");

                entity.Property(e => e.Color56)
                    .HasColumnName("color56")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color57)
                    .HasColumnName("color57")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color58)
                    .HasColumnName("color58")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color59)
                    .HasColumnName("color59")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color6)
                    .HasColumnName("color6")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.Color60)
                    .HasColumnName("color60")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color61)
                    .HasColumnName("color61")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color62)
                    .HasColumnName("color62")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color63)
                    .HasColumnName("color63")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color64)
                    .HasColumnName("color64")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color65)
                    .HasColumnName("color65")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color66)
                    .HasColumnName("color66")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color67)
                    .HasColumnName("color67")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color68)
                    .HasColumnName("color68")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color69)
                    .HasColumnName("color69")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'16777215'");

                entity.Property(e => e.Color7)
                    .HasColumnName("color7")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color70)
                    .HasColumnName("color70")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color71)
                    .HasColumnName("color71")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color72)
                    .HasColumnName("color72")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color73)
                    .HasColumnName("color73")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'16777215'");

                entity.Property(e => e.Color74)
                    .HasColumnName("color74")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'16777215'");

                entity.Property(e => e.Color75)
                    .HasColumnName("color75")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color76)
                    .HasColumnName("color76")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color8)
                    .HasColumnName("color8")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color9)
                    .HasColumnName("color9")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Columns>(entity =>
            {
                entity.ToTable("columns");

                entity.HasComment("Rozložení sloupcù dbgridu");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgUlAdresyView)
                    .HasColumnName("agUlAdresyView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlOperaceView)
                    .HasColumnName("agUlOperaceView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlSarzeView)
                    .HasColumnName("agUlSarzeView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlSkladView)
                    .HasColumnName("agUlSkladView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlZakazkyView)
                    .HasColumnName("agUlZakazkyView")
                    .HasColumnType("blob");

                entity.Property(e => e.ApplicationSetting)
                    .HasColumnName("application_setting")
                    .HasColumnType("blob");

                entity.Property(e => e.CidlaReaddata)
                    .HasColumnName("cidla_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.Cnc)
                    .HasColumnName("cnc")
                    .HasColumnType("blob");

                entity.Property(e => e.Cncgroup)
                    .HasColumnName("CNCGroup")
                    .HasColumnType("blob");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasColumnType("blob");

                entity.Property(e => e.CustomerOrder)
                    .HasColumnName("customer_order")
                    .HasColumnType("blob");

                entity.Property(e => e.CustomerOsoby)
                    .HasColumnName("customer_osoby")
                    .HasColumnType("blob");

                entity.Property(e => e.CustomerUdalosti)
                    .HasColumnName("customer_udalosti")
                    .HasColumnType("blob");

                entity.Property(e => e.DataColection)
                    .HasColumnName("data_colection")
                    .HasColumnType("blob");

                entity.Property(e => e.Dochazka)
                    .HasColumnName("dochazka")
                    .HasColumnType("blob");

                entity.Property(e => e.Dodacilist1)
                    .HasColumnName("dodacilist1")
                    .HasColumnType("blob");

                entity.Property(e => e.Dodacilist2)
                    .HasColumnName("dodacilist2")
                    .HasColumnType("blob");

                entity.Property(e => e.GrafickyPrehled)
                    .HasColumnName("graficky_prehled")
                    .HasColumnType("blob");

                entity.Property(e => e.HromadnyPohybNar)
                    .HasColumnName("hromadnyPohybNar")
                    .HasColumnType("blob");

                entity.Property(e => e.HromadnyVydej)
                    .HasColumnName("hromadnyVydej")
                    .HasColumnType("blob");

                entity.Property(e => e.KdatuOrder)
                    .HasColumnName("KDatuOrder")
                    .HasColumnType("blob");

                entity.Property(e => e.KdatuOrderWork)
                    .HasColumnName("KDatuOrderWork")
                    .HasColumnType("blob");

                entity.Property(e => e.Materialy)
                    .HasColumnName("materialy")
                    .HasColumnType("blob");

                entity.Property(e => e.NaradiReader)
                    .HasColumnName("naradi_reader")
                    .HasColumnType("blob");

                entity.Property(e => e.Objednavky)
                    .HasColumnName("objednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPolozky)
                    .HasColumnName("objednavky_polozky")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPolozkyNaradi)
                    .HasColumnName("objednavky_polozkyNaradi")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPrijate)
                    .HasColumnName("objednavky_prijate")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPrijatePolozky)
                    .HasColumnName("objednavky_prijate_polozky")
                    .HasColumnType("blob");

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasColumnType("blob");

                entity.Property(e => e.OperationGroup)
                    .HasColumnName("operation_group")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage1)
                    .HasColumnName("order_page1")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage10)
                    .HasColumnName("order_page10")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage11)
                    .HasColumnName("order_page11")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage12)
                    .HasColumnName("order_page12")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage13)
                    .HasColumnName("order_page13")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage2)
                    .HasColumnName("order_page2")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage3)
                    .HasColumnName("order_page3")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage4)
                    .HasColumnName("order_page4")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage5)
                    .HasColumnName("order_page5")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage6)
                    .HasColumnName("order_page6")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage7)
                    .HasColumnName("order_page7")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage8)
                    .HasColumnName("order_page8")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage9)
                    .HasColumnName("order_page9")
                    .HasColumnType("blob");

                entity.Property(e => e.Orderstavy)
                    .HasColumnName("orderstavy")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderworkPlan)
                    .HasColumnName("orderwork_plan")
                    .HasColumnType("blob");

                entity.Property(e => e.Pausal)
                    .HasColumnName("pausal")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatBlokace)
                    .HasColumnName("PPMatBlokace")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatObjednavky)
                    .HasColumnName("PPMatObjednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatPblokace)
                    .HasColumnName("PPMatPBlokace")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatPobjednavky)
                    .HasColumnName("PPMatPObjednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatPvyroba)
                    .HasColumnName("PPMatPVyroba")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatVyroba)
                    .HasColumnName("PPMatVyroba")
                    .HasColumnType("blob");

                entity.Property(e => e.PpskladBlokace)
                    .HasColumnName("PPSkladBlokace")
                    .HasColumnType("blob");

                entity.Property(e => e.PpskladObjednavky)
                    .HasColumnName("PPSkladObjednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.PpskladVyroba)
                    .HasColumnName("PPSkladVyroba")
                    .HasColumnType("blob");

                entity.Property(e => e.Readdata)
                    .HasColumnName("readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.Repairtype)
                    .HasColumnName("repairtype")
                    .HasColumnType("blob");

                entity.Property(e => e.Skladformy)
                    .HasColumnName("skladformy")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladformyPohyb)
                    .HasColumnName("skladformy_pohyb")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladformyReaddata)
                    .HasColumnName("skladformy_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.Skladmaterialu)
                    .HasColumnName("skladmaterialu")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuPrijemky1)
                    .HasColumnName("skladmaterialu_prijemky1")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuPrijemky2)
                    .HasColumnName("skladmaterialu_prijemky2")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuReaddata)
                    .HasColumnName("skladmaterialu_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuVydejky1)
                    .HasColumnName("skladmaterialu_vydejky1")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuVydejky2)
                    .HasColumnName("skladmaterialu_vydejky2")
                    .HasColumnType("blob");

                entity.Property(e => e.Skladnaradi)
                    .HasColumnName("skladnaradi")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladnaradiPohyb)
                    .HasColumnName("skladnaradi_pohyb")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladnaradiReaddata)
                    .HasColumnName("skladnaradi_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladoveInventury).HasColumnType("blob");

                entity.Property(e => e.SkladoveInventuryPolozky).HasColumnType("blob");

                entity.Property(e => e.SkladoveInventurySoupisy).HasColumnType("blob");

                entity.Property(e => e.SkladovePozice).HasColumnType("blob");

                entity.Property(e => e.SkladovePoziceReadData).HasColumnType("blob");

                entity.Property(e => e.Skladskupiny)
                    .HasColumnName("skladskupiny")
                    .HasColumnType("blob");

                entity.Property(e => e.SortSettings)
                    .HasColumnName("sort_settings")
                    .HasColumnType("blob");

                entity.Property(e => e.SpravaZaznamu)
                    .HasColumnName("sprava_zaznamu")
                    .HasColumnType("blob");

                entity.Property(e => e.StrojGroup).HasColumnType("blob");

                entity.Property(e => e.Stroje)
                    .HasColumnName("stroje")
                    .HasColumnType("blob");

                entity.Property(e => e.TechPostup)
                    .HasColumnName("tech_postup")
                    .HasColumnType("blob");

                entity.Property(e => e.TechPostupPolozky)
                    .HasColumnName("tech_postup_polozky")
                    .HasColumnType("blob");

                entity.Property(e => e.TouchTerminal)
                    .HasColumnName("touchTerminal")
                    .HasColumnType("blob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Worker)
                    .HasColumnName("worker")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<ColumnsBackup>(entity =>
            {
                entity.ToTable("columns_backup");

                entity.HasComment("Rozložení sloupcù dbgridu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgUlAdresyView)
                    .HasColumnName("agUlAdresyView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlOperaceView)
                    .HasColumnName("agUlOperaceView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlSarzeView)
                    .HasColumnName("agUlSarzeView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlSkladView)
                    .HasColumnName("agUlSkladView")
                    .HasColumnType("blob");

                entity.Property(e => e.AgUlZakazkyView)
                    .HasColumnName("agUlZakazkyView")
                    .HasColumnType("blob");

                entity.Property(e => e.ApplicationSetting)
                    .HasColumnName("application_setting")
                    .HasColumnType("blob");

                entity.Property(e => e.CidlaReaddata)
                    .HasColumnName("cidla_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.Cnc)
                    .HasColumnName("cnc")
                    .HasColumnType("blob");

                entity.Property(e => e.Cncgroup)
                    .HasColumnName("CNCGroup")
                    .HasColumnType("blob");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasColumnType("blob");

                entity.Property(e => e.CustomerOrder)
                    .HasColumnName("customer_order")
                    .HasColumnType("blob");

                entity.Property(e => e.CustomerOsoby)
                    .HasColumnName("customer_osoby")
                    .HasColumnType("blob");

                entity.Property(e => e.CustomerUdalosti)
                    .HasColumnName("customer_udalosti")
                    .HasColumnType("blob");

                entity.Property(e => e.DataColection)
                    .HasColumnName("data_colection")
                    .HasColumnType("blob");

                entity.Property(e => e.Dochazka)
                    .HasColumnName("dochazka")
                    .HasColumnType("blob");

                entity.Property(e => e.Dodacilist1)
                    .HasColumnName("dodacilist1")
                    .HasColumnType("blob");

                entity.Property(e => e.Dodacilist2)
                    .HasColumnName("dodacilist2")
                    .HasColumnType("blob");

                entity.Property(e => e.GrafickyPrehled)
                    .HasColumnName("graficky_prehled")
                    .HasColumnType("blob");

                entity.Property(e => e.HromadnyPohybNar)
                    .HasColumnName("hromadnyPohybNar")
                    .HasColumnType("blob");

                entity.Property(e => e.HromadnyVydej)
                    .HasColumnName("hromadnyVydej")
                    .HasColumnType("blob");

                entity.Property(e => e.KdatuOrder)
                    .HasColumnName("KDatuOrder")
                    .HasColumnType("blob");

                entity.Property(e => e.KdatuOrderWork)
                    .HasColumnName("KDatuOrderWork")
                    .HasColumnType("blob");

                entity.Property(e => e.Materialy)
                    .HasColumnName("materialy")
                    .HasColumnType("blob");

                entity.Property(e => e.NaradiReader)
                    .HasColumnName("naradi_reader")
                    .HasColumnType("blob");

                entity.Property(e => e.Objednavky)
                    .HasColumnName("objednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPolozky)
                    .HasColumnName("objednavky_polozky")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPolozkyNaradi)
                    .HasColumnName("objednavky_polozkyNaradi")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPrijate)
                    .HasColumnName("objednavky_prijate")
                    .HasColumnType("blob");

                entity.Property(e => e.ObjednavkyPrijatePolozky)
                    .HasColumnName("objednavky_prijate_polozky")
                    .HasColumnType("blob");

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasColumnType("blob");

                entity.Property(e => e.OperationGroup)
                    .HasColumnName("operation_group")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage1)
                    .HasColumnName("order_page1")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage10)
                    .HasColumnName("order_page10")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage11)
                    .HasColumnName("order_page11")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage12)
                    .HasColumnName("order_page12")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage13)
                    .HasColumnName("order_page13")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage2)
                    .HasColumnName("order_page2")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage3)
                    .HasColumnName("order_page3")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage4)
                    .HasColumnName("order_page4")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage5)
                    .HasColumnName("order_page5")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage6)
                    .HasColumnName("order_page6")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage7)
                    .HasColumnName("order_page7")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage8)
                    .HasColumnName("order_page8")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderPage9)
                    .HasColumnName("order_page9")
                    .HasColumnType("blob");

                entity.Property(e => e.Orderstavy)
                    .HasColumnName("orderstavy")
                    .HasColumnType("blob");

                entity.Property(e => e.OrderworkPlan)
                    .HasColumnName("orderwork_plan")
                    .HasColumnType("blob");

                entity.Property(e => e.Pausal)
                    .HasColumnName("pausal")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatBlokace)
                    .HasColumnName("PPMatBlokace")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatObjednavky)
                    .HasColumnName("PPMatObjednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatPblokace)
                    .HasColumnName("PPMatPBlokace")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatPobjednavky)
                    .HasColumnName("PPMatPObjednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatPvyroba)
                    .HasColumnName("PPMatPVyroba")
                    .HasColumnType("blob");

                entity.Property(e => e.PpmatVyroba)
                    .HasColumnName("PPMatVyroba")
                    .HasColumnType("blob");

                entity.Property(e => e.PpskladBlokace)
                    .HasColumnName("PPSkladBlokace")
                    .HasColumnType("blob");

                entity.Property(e => e.PpskladObjednavky)
                    .HasColumnName("PPSkladObjednavky")
                    .HasColumnType("blob");

                entity.Property(e => e.PpskladVyroba)
                    .HasColumnName("PPSkladVyroba")
                    .HasColumnType("blob");

                entity.Property(e => e.Readdata)
                    .HasColumnName("readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.Repairtype)
                    .HasColumnName("repairtype")
                    .HasColumnType("blob");

                entity.Property(e => e.Skladformy)
                    .HasColumnName("skladformy")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladformyPohyb)
                    .HasColumnName("skladformy_pohyb")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladformyReaddata)
                    .HasColumnName("skladformy_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.Skladmaterialu)
                    .HasColumnName("skladmaterialu")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuPrijemky1)
                    .HasColumnName("skladmaterialu_prijemky1")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuPrijemky2)
                    .HasColumnName("skladmaterialu_prijemky2")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuReaddata)
                    .HasColumnName("skladmaterialu_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuVydejky1)
                    .HasColumnName("skladmaterialu_vydejky1")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladmaterialuVydejky2)
                    .HasColumnName("skladmaterialu_vydejky2")
                    .HasColumnType("blob");

                entity.Property(e => e.Skladnaradi)
                    .HasColumnName("skladnaradi")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladnaradiPohyb)
                    .HasColumnName("skladnaradi_pohyb")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladnaradiReaddata)
                    .HasColumnName("skladnaradi_readdata")
                    .HasColumnType("blob");

                entity.Property(e => e.SkladoveInventury).HasColumnType("blob");

                entity.Property(e => e.SkladoveInventuryPolozky).HasColumnType("blob");

                entity.Property(e => e.SkladoveInventurySoupisy).HasColumnType("blob");

                entity.Property(e => e.SkladovePozice).HasColumnType("blob");

                entity.Property(e => e.SkladovePoziceReadData).HasColumnType("blob");

                entity.Property(e => e.Skladskupiny)
                    .HasColumnName("skladskupiny")
                    .HasColumnType("blob");

                entity.Property(e => e.SortSettings)
                    .HasColumnName("sort_settings")
                    .HasColumnType("blob");

                entity.Property(e => e.SpravaZaznamu)
                    .HasColumnName("sprava_zaznamu")
                    .HasColumnType("blob");

                entity.Property(e => e.StrojGroup).HasColumnType("blob");

                entity.Property(e => e.Stroje)
                    .HasColumnName("stroje")
                    .HasColumnType("blob");

                entity.Property(e => e.TechPostup)
                    .HasColumnName("tech_postup")
                    .HasColumnType("blob");

                entity.Property(e => e.TechPostupPolozky)
                    .HasColumnName("tech_postup_polozky")
                    .HasColumnType("blob");

                entity.Property(e => e.TouchTerminal)
                    .HasColumnName("touchTerminal")
                    .HasColumnType("blob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Worker)
                    .HasColumnName("worker")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<ColumnsCaption>(entity =>
            {
                entity.HasKey(e => new { e.FormName, e.GridName, e.FieldName, e.LanguageCode })
                    .HasName("PRIMARY");

                entity.ToTable("columns_caption");

                entity.HasIndex(e => e.LanguageCode)
                    .HasName("languageCode");

                entity.HasIndex(e => new { e.FormName, e.GridName, e.LanguageCode })
                    .HasName("Identification");

                entity.Property(e => e.FormName)
                    .HasColumnName("formName")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.GridName)
                    .HasColumnName("gridName")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FieldName)
                    .HasColumnName("fieldName")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("languageCode")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ColumnCaption)
                    .IsRequired()
                    .HasColumnName("columnCaption")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ColumnCaptionUser)
                    .IsRequired()
                    .HasColumnName("columnCaptionUser")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ColumnHint)
                    .IsRequired()
                    .HasColumnName("columnHint")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<ColumnsLog>(entity =>
            {
                entity.ToTable("columns_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualCaption)
                    .HasColumnName("actual_caption")
                    .HasColumnType("varchar(80)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DatumZmeny)
                    .HasColumnName("datum_zmeny")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OriginalCaption)
                    .HasColumnName("original_caption")
                    .HasColumnType("varchar(80)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.QryName)
                    .HasColumnName("qry_name")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.ToTable("config");

                entity.HasComment("Tabulka dochazky zamestnancu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DochazkaAutobreak)
                    .IsRequired()
                    .HasColumnName("dochazka_autobreak")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DochazkaAutobreakPodmina)
                    .IsRequired()
                    .HasColumnName("dochazka_autobreak_podmina")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DochazkaFormat)
                    .IsRequired()
                    .HasColumnName("dochazka_format")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PriceCalculate)
                    .IsRequired()
                    .HasColumnName("price_calculate")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasComment("Zakaznici");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Doprava)
                    .HasName("doprava");

                entity.HasIndex(e => e.EmailOdesilat)
                    .HasName("email_odesilat");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.GdprZbyva)
                    .HasName("gdpr_zbyva");

                entity.HasIndex(e => e.Ico)
                    .HasName("ico");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Platba)
                    .HasName("platba");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("adress")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Banka)
                    .IsRequired()
                    .HasColumnName("banka")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BarvaPlanu)
                    .HasColumnName("barvaPlanu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dic)
                    .IsRequired()
                    .HasColumnName("dic")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'CZ'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodFirma)
                    .IsRequired()
                    .HasColumnName("dod_firma")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodMesto)
                    .IsRequired()
                    .HasColumnName("dod_mesto")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodOddeleni)
                    .IsRequired()
                    .HasColumnName("dod_oddeleni")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodOsoba)
                    .IsRequired()
                    .HasColumnName("dod_osoba")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodPsc)
                    .IsRequired()
                    .HasColumnName("dod_psc")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodStat)
                    .IsRequired()
                    .HasColumnName("dod_stat")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Doprava)
                    .IsRequired()
                    .HasColumnName("doprava")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Dorucenifaktury)
                    .IsRequired()
                    .HasColumnName("dorucenifaktury")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EmailOdesilat)
                    .HasColumnName("email_odesilat")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakAdress)
                    .IsRequired()
                    .HasColumnName("fak_adress")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakEmail)
                    .IsRequired()
                    .HasColumnName("fak_email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakFirma)
                    .IsRequired()
                    .HasColumnName("fak_firma")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakMesto)
                    .IsRequired()
                    .HasColumnName("fak_mesto")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakOddeleni)
                    .IsRequired()
                    .HasColumnName("fak_oddeleni")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakOsoba)
                    .IsRequired()
                    .HasColumnName("fak_osoba")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakPhone)
                    .IsRequired()
                    .HasColumnName("fak_phone")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakPsc)
                    .IsRequired()
                    .HasColumnName("fak_psc")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakStat)
                    .IsRequired()
                    .HasColumnName("fak_stat")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("fax")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Forma)
                    .IsRequired()
                    .HasColumnName("forma")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.GdprAnonymizovano)
                    .HasColumnName("gdpr_anonymizovano")
                    .HasColumnType("int(5)");

                entity.Property(e => e.GdprZbyva)
                    .HasColumnName("gdpr_zbyva")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Icdph)
                    .IsRequired()
                    .HasColumnName("icdph")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Ico)
                    .IsRequired()
                    .HasColumnName("ico")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oblast)
                    .HasColumnName("oblast")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Osoba)
                    .IsRequired()
                    .HasColumnName("osoba")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Platba)
                    .IsRequired()
                    .HasColumnName("platba")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrimaDodaciAdresa)
                    .HasColumnName("prima_dodaci_adresa")
                    .HasColumnType("int(5)");

                entity.Property(e => e.SplatnostDni)
                    .HasColumnName("splatnost_dni")
                    .HasColumnType("int(4)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Ucet)
                    .IsRequired()
                    .HasColumnName("ucet")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Web)
                    .IsRequired()
                    .HasColumnName("web")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CustomerAdresy>(entity =>
            {
                entity.ToTable("customer_adresy");

                entity.HasComment("Dodací adresy pro zákazníky");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.CustomerIdAddressId)
                    .HasName("customer_id_address_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerIdAddressId)
                    .HasColumnName("customer_id_address_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DodEmail)
                    .IsRequired()
                    .HasColumnName("dod_email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodFax)
                    .IsRequired()
                    .HasColumnName("dod_fax")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodMesto)
                    .IsRequired()
                    .HasColumnName("dod_mesto")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodMobil)
                    .IsRequired()
                    .HasColumnName("dod_mobil")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodNote)
                    .IsRequired()
                    .HasColumnName("dod_note")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodOsoba)
                    .IsRequired()
                    .HasColumnName("dod_osoba")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodPsc)
                    .IsRequired()
                    .HasColumnName("dod_psc")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodTelefon)
                    .IsRequired()
                    .HasColumnName("dod_telefon")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodUlice)
                    .IsRequired()
                    .HasColumnName("dod_ulice")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<CustomerOsoby>(entity =>
            {
                entity.ToTable("customer_osoby");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => new { e.Jmeno, e.Prijmeni, e.Telefon, e.Email })
                    .HasName("slozeny_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(45)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExterniId)
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Hierarchie)
                    .HasColumnName("hierarchie")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jmeno)
                    .HasColumnName("jmeno")
                    .HasColumnType("varchar(45)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(250)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Prijmeni)
                    .HasColumnName("prijmeni")
                    .HasColumnType("varchar(45)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("varchar(45)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vychozi)
                    .HasColumnName("vychozi")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CustomerUdalosti>(entity =>
            {
                entity.ToTable("customer_udalosti");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.Datum)
                    .HasName("datum");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(500)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Predmet)
                    .HasColumnName("predmet")
                    .HasColumnType("varchar(45)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CustomerUdalostiTypy>(entity =>
            {
                entity.ToTable("customer_udalosti_typy");

                entity.HasIndex(e => new { e.Nazev, e.Popis })
                    .HasName("slozeny_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(45)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.ToTable("datum");

                entity.HasComment("Tiskova tabulka dochazky");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datum1)
                    .HasColumnName("datum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Pc)
                    .IsRequired()
                    .HasColumnName("pc")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dochazka>(entity =>
            {
                entity.ToTable("dochazka");

                entity.HasComment("Tabulka dochazky zamestnancu");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Absence)
                    .HasColumnName("absence")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CasVypoctu)
                    .HasColumnName("cas_vypoctu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dovolena)
                    .HasColumnName("dovolena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Fond)
                    .HasColumnName("fond")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nahrvolno)
                    .HasColumnName("nahrvolno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nemoc)
                    .HasColumnName("nemoc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Neodpracovano)
                    .HasColumnName("neodpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NeplacVolno)
                    .HasColumnName("neplac_volno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nocni)
                    .HasColumnName("nocni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Ocr)
                    .HasColumnName("ocr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Odpracovano)
                    .HasColumnName("odpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ostatni)
                    .HasColumnName("ostatni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OstatniKorekce)
                    .HasColumnName("ostatni_korekce")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OstatniNahr)
                    .HasColumnName("ostatni_nahr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Placeno)
                    .HasColumnName("placeno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Placvolno)
                    .HasColumnName("placvolno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prescas)
                    .HasColumnName("prescas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prestavka)
                    .HasColumnName("prestavka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Propustka)
                    .HasColumnName("propustka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prostoj)
                    .HasColumnName("prostoj")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RealOdprac)
                    .HasColumnName("real_odprac")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaldoPrescas)
                    .HasColumnName("saldo_prescas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Smena)
                    .IsRequired()
                    .HasColumnName("smena")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Svatek)
                    .HasColumnName("svatek")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SvatekNahr)
                    .HasColumnName("svatek_nahr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypVypoctu)
                    .HasColumnName("typ_vypoctu")
                    .HasColumnType("int(2)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Verze)
                    .IsRequired()
                    .HasColumnName("verze")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vikend)
                    .HasColumnName("vikend")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DochazkaMirror>(entity =>
            {
                entity.ToTable("dochazka_mirror");

                entity.HasComment("Tabulka pro ukladani dochazky zamestnancu");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Absence)
                    .HasColumnName("absence")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CasVypoctu)
                    .HasColumnName("cas_vypoctu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dovolena)
                    .HasColumnName("dovolena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Fond)
                    .HasColumnName("fond")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nahrvolno)
                    .HasColumnName("nahrvolno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nemoc)
                    .HasColumnName("nemoc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Neodpracovano)
                    .HasColumnName("neodpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NeplacVolno)
                    .HasColumnName("neplac_volno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nocni)
                    .HasColumnName("nocni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Ocr)
                    .HasColumnName("ocr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Odpracovano)
                    .HasColumnName("odpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ostatni)
                    .HasColumnName("ostatni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OstatniKorekce)
                    .HasColumnName("ostatni_korekce")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OstatniNahr)
                    .HasColumnName("ostatni_nahr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Placeno)
                    .HasColumnName("placeno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Placvolno)
                    .HasColumnName("placvolno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prescas)
                    .HasColumnName("prescas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prestavka)
                    .HasColumnName("prestavka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Propustka)
                    .HasColumnName("propustka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prostoj)
                    .HasColumnName("prostoj")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RealOdprac)
                    .HasColumnName("real_odprac")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaldoPrescas)
                    .HasColumnName("saldo_prescas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Smena)
                    .IsRequired()
                    .HasColumnName("smena")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Svatek)
                    .HasColumnName("svatek")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SvatekNahr)
                    .HasColumnName("svatek_nahr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypVypoctu)
                    .HasColumnName("typ_vypoctu")
                    .HasColumnType("int(2)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Verze)
                    .IsRequired()
                    .HasColumnName("verze")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vikend)
                    .HasColumnName("vikend")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DochazkaNote>(entity =>
            {
                entity.ToTable("dochazka_note");

                entity.HasComment("Poznámka docházky za období");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(300)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DodaciListy>(entity =>
            {
                entity.ToTable("dodaci_listy");

                entity.HasComment("Tabulka dadacích listù");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.UserCode)
                    .HasName("userCode");

                entity.HasIndex(e => e.Vystaveno)
                    .HasName("vystaveno");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BalikyObjem)
                    .HasColumnName("balikyObjem")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.BalikyPocet)
                    .HasColumnName("balikyPocet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CisloFaktury)
                    .IsRequired()
                    .HasColumnName("cisloFaktury")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dodaciadresa)
                    .HasColumnName("dodaciadresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExterniId)
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.HmotnostCelkem)
                    .HasColumnName("hmotnostCelkem")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.KurzDatum)
                    .HasColumnName("kurzDatum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.KurzHodnota)
                    .HasColumnName("kurzHodnota")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavDl)
                    .HasColumnName("stavDL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasColumnName("userCode")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vystaveno)
                    .HasColumnName("vystaveno")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ZpusobDopravy)
                    .IsRequired()
                    .HasColumnName("zpusobDopravy")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<DodaciListyPolozky>(entity =>
            {
                entity.ToTable("dodaci_listy_polozky");

                entity.HasComment("Tabulka položek dodacích listù");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.DodaciListId)
                    .HasName("dodaci_list_id");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.PolozkaPrijateObjednavkyId)
                    .HasName("polozka_prijate_objednavky_id");

                entity.HasIndex(e => e.PrevodMatId)
                    .HasName("prevod_mat_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Zpracovano)
                    .HasName("zpracovano");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodaciAdresa)
                    .HasColumnName("dodaciAdresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DodaciListId)
                    .HasColumnName("dodaci_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExterniId)
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.HmotnostPolozky)
                    .HasColumnName("hmotnostPolozky")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.Ine)
                    .HasColumnName("ine")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.IneCheck)
                    .HasColumnName("ineCheck")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Intrastatcode)
                    .IsRequired()
                    .HasColumnName("intrastatcode")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Kusu)
                    .HasColumnName("kusu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialId)
                    .IsRequired()
                    .HasColumnName("material_id")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PolozkaPrijateObjednavkyId)
                    .HasColumnName("polozka_prijate_objednavky_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrevodMatId)
                    .HasColumnName("prevod_mat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PripravaPredlohy)
                    .HasColumnName("pripravaPredlohy")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.PripravaPredlohyCheck)
                    .HasColumnName("pripravaPredlohyCheck")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PripravaVyroby)
                    .HasColumnName("pripravaVyroby")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.PripravaVyrobyCheck)
                    .HasColumnName("pripravaVyrobyCheck")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SerialId)
                    .HasColumnName("serial_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.VydejId)
                    .HasColumnName("vydej_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zpracovano)
                    .HasColumnName("zpracovano")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<DodaciListyZauctovano>(entity =>
            {
                entity.ToTable("dodaci_listy_zauctovano");

                entity.HasComment("Tabulka zauctovani dodacich listu");

                entity.HasIndex(e => e.DodaciListId)
                    .HasName("dodaci_list_id");

                entity.HasIndex(e => e.Doklad)
                    .HasName("doklad");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DodaciListId)
                    .HasColumnName("dodaci_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Doklad)
                    .HasColumnName("doklad")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Faktury>(entity =>
            {
                entity.ToTable("faktury");

                entity.HasComment("Faktury k zakázkám");

                entity.HasIndex(e => e.Cislo)
                    .HasName("cislo");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CastkaDph)
                    .HasColumnName("castka_dph")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Cislo)
                    .IsRequired()
                    .HasColumnName("cislo")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DatumPlatby)
                    .HasColumnName("datum_platby")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Popis)
                    .IsRequired()
                    .HasColumnName("popis")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SazbaDph)
                    .HasColumnName("sazba_dph")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UseZaklad)
                    .HasColumnName("use_zaklad")
                    .HasColumnType("int(5)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<FormCaptionHook>(entity =>
            {
                entity.ToTable("form_caption_hook");

                entity.HasIndex(e => e.ComponentName)
                    .HasName("ComponentName");

                entity.HasIndex(e => e.ComponentProperty)
                    .HasName("ComponentProperty");

                entity.HasIndex(e => e.ComponentType)
                    .HasName("ComponentType");

                entity.HasIndex(e => e.FormName)
                    .HasName("FormName");

                entity.HasIndex(e => e.Language)
                    .HasName("Language");

                entity.HasIndex(e => e.Value)
                    .HasName("Value");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComponentName)
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ComponentProperty)
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ComponentType)
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FormName)
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Language)
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<FormySkupina>(entity =>
            {
                entity.ToTable("formy_skupina");

                entity.HasComment("Skupiny forem");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GdprFields>(entity =>
            {
                entity.ToTable("gdpr_fields");

                entity.HasComment("Tabulka GDPR položek");

                entity.HasIndex(e => e.FieldName)
                    .HasName("field_name");

                entity.HasIndex(e => e.TableName)
                    .HasName("table_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(150)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Selected)
                    .HasColumnName("selected")
                    .HasColumnType("int(5)");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<GdprLogs>(entity =>
            {
                entity.ToTable("gdpr_logs");

                entity.HasComment("Tabulka GDPR logù");

                entity.HasIndex(e => e.FieldName)
                    .HasName("field_name");

                entity.HasIndex(e => e.TableName)
                    .HasName("table_name");

                entity.HasIndex(e => e.TimeStamp)
                    .HasName("time_stamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(150)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Newvalue)
                    .HasColumnName("newvalue")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oldvalue)
                    .HasColumnName("oldvalue")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<GdprSettings>(entity =>
            {
                entity.ToTable("gdpr_settings");

                entity.HasComment("Tabulka nastavení pro GDPR");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Aktivni)
                    .HasColumnName("aktivni")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DnyKeepAuditlog)
                    .HasColumnName("dny_keep_auditlog")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.DnyKeepOtherlogs)
                    .HasColumnName("dny_keep_otherlogs")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.DnyKeepPrintlog)
                    .HasColumnName("dny_keep_printlog")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.DnyKeepSystemlog)
                    .HasColumnName("dny_keep_systemlog")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.DnyKeepZakaznik)
                    .HasColumnName("dny_keep_zakaznik")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.DnyKeepZamestnanec)
                    .HasColumnName("dny_keep_zamestnanec")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.HesloJineNezUser)
                    .HasColumnName("heslo_jine_nez_user")
                    .HasColumnType("int(5)");

                entity.Property(e => e.HesloMinDelka)
                    .HasColumnName("heslo_min_delka")
                    .HasColumnType("int(5)");

                entity.Property(e => e.HesloVyzadovatMinDelku)
                    .HasColumnName("heslo_vyzadovat_min_delku")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ZablokPrihlas)
                    .HasColumnName("zablok_prihlas")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ZablokPrihlasMail)
                    .HasColumnName("zablok_prihlas_mail")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ZablokPrihlasPassword)
                    .IsRequired()
                    .HasColumnName("zablok_prihlas_password")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZablokPrihlasPocet)
                    .HasColumnName("zablok_prihlas_pocet")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ZablokPrihlasServer)
                    .IsRequired()
                    .HasColumnName("zablok_prihlas_server")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZablokPrihlasUser)
                    .IsRequired()
                    .HasColumnName("zablok_prihlas_user")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<GlobalSettings>(entity =>
            {
                entity.ToTable("global_settings");

                entity.HasComment("Tabulka nastaveni");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AktualniStavNovy)
                    .HasColumnName("aktualni_stav_novy")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CasDefSkladGroupDily)
                    .IsRequired()
                    .HasColumnName("CAS_DEF_SKLAD_GROUP_DILY")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CasKlon)
                    .HasColumnName("cas_klon")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CazerSkladId)
                    .HasColumnName("cazer_sklad_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CazerSkladPct)
                    .HasColumnName("cazer_sklad_pct")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CazerSkladPctMontaz)
                    .HasColumnName("cazer_sklad_pct_montaz")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CazerSkladPctSprava)
                    .HasColumnName("cazer_sklad_pct_sprava")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CiziMena)
                    .HasColumnName("CIZI_MENA")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.CncCenaDefault)
                    .HasColumnName("cnc_cena_default")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CreateDirOrder)
                    .HasColumnName("create_dir_order")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CreateDirOrderPath)
                    .IsRequired()
                    .HasColumnName("create_dir_order_path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CreateSubdirOrder)
                    .HasColumnName("create_subdir_order")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CreateSubdirOrderAddName)
                    .HasColumnName("create_subdir_order_add_name")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CreateSubdirOrderPath)
                    .IsRequired()
                    .HasColumnName("create_subdir_order_path")
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DefPayFak)
                    .HasColumnName("def_pay_fak")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DefaultMena)
                    .IsRequired()
                    .HasColumnName("DEFAULT_MENA")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DefaultUnit)
                    .HasColumnName("default_unit")
                    .HasColumnType("int(4)");

                entity.Property(e => e.DefaultniMarze)
                    .HasColumnName("defaultni_marze")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DelitDochazku)
                    .HasColumnName("delit_dochazku")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DlCastecneVydaneDoPodzakazky)
                    .HasColumnName("DL_CASTECNE_VYDANE_DO_PODZAKAZKY")
                    .HasColumnType("int(1)");

                entity.Property(e => e.DlCheckOrderBaridInCode)
                    .HasColumnName("DL_CHECK_ORDER_BARID_IN_CODE")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DlPocitatMnozstvi)
                    .HasColumnName("dl_pocitat_mnozstvi")
                    .HasColumnType("int(1)");

                entity.Property(e => e.DlPocitatMnozstviFrom)
                    .HasColumnName("dl_pocitat_mnozstvi_from")
                    .HasColumnType("int(1)");

                entity.Property(e => e.DlVytvorenoZakazkyStav)
                    .HasColumnName("dl_vytvoreno_zakazky_stav")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.DlVytvoritVydejku)
                    .HasColumnName("dl_vytvorit_vydejku")
                    .HasColumnType("int(1)");

                entity.Property(e => e.DlZauctovanoZakazkyStav)
                    .HasColumnName("dl_zauctovano_zakazky_stav")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.DochAbsenceBarId)
                    .IsRequired()
                    .HasColumnName("doch_absence_bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DochBreakBarId)
                    .IsRequired()
                    .HasColumnName("doch_break_bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DochBreakRound)
                    .HasColumnName("doch_break_round")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DochNeukBack)
                    .HasColumnName("doch_neuk_back")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'30'");

                entity.Property(e => e.DochNoComm)
                    .HasColumnName("doch_no_comm")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DochSpecPrescas)
                    .HasColumnName("doch_spec_prescas")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DochazkaRozpoznavatSmeny)
                    .HasColumnName("dochazka_rozpoznavat_smeny")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DochazkaSumyVeDnech)
                    .HasColumnName("dochazka_sumy_ve_dnech")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DochazkaTyp)
                    .HasColumnName("dochazka_typ")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DochazkaZaokrouhlovatNa)
                    .HasColumnName("dochazka_zaokrouhlovat_na")
                    .HasColumnType("int(10)");

                entity.Property(e => e.EdtSmrFromOrd)
                    .HasColumnName("edt_smr_from_ord")
                    .HasColumnType("int(2)");

                entity.Property(e => e.EfektivitaOrderWork)
                    .HasColumnName("efektivita_order_work")
                    .HasColumnType("int(2)");

                entity.Property(e => e.FakturaZakazkyStav1)
                    .HasColumnName("faktura_zakazky_stav_1")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.FakturaZakazkyStav2)
                    .HasColumnName("faktura_zakazky_stav_2")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Filterreplacecomma)
                    .HasColumnName("filterreplacecomma")
                    .HasColumnType("int(1)");

                entity.Property(e => e.FrExportdir)
                    .IsRequired()
                    .HasColumnName("fr_exportdir")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FrSavestyl)
                    .HasColumnName("fr_savestyl")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GrafickyprehledRefresh)
                    .HasColumnName("grafickyprehled_refresh")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ImportExt)
                    .HasColumnName("import_ext")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ImportExtCaption)
                    .IsRequired()
                    .HasColumnName("import_ext_caption")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ImportExtDl)
                    .HasColumnName("import_ext_dl")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ImportExtDlCaption)
                    .IsRequired()
                    .HasColumnName("import_ext_dl_caption")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ImportExtDlExec)
                    .IsRequired()
                    .HasColumnName("import_ext_dl_exec")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ImportExtDlParams)
                    .IsRequired()
                    .HasColumnName("import_ext_dl_params")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ImportExtExec)
                    .IsRequired()
                    .HasColumnName("import_ext_exec")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ImportExtParams)
                    .IsRequired()
                    .HasColumnName("import_ext_params")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.InitdirDokument)
                    .IsRequired()
                    .HasColumnName("initdir_dokument")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.InitdirPrijemka)
                    .IsRequired()
                    .HasColumnName("initdir_prijemka")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.InitdirSkladmatedit)
                    .IsRequired()
                    .HasColumnName("initdir_skladmatedit")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.KoeficientyDleSkupin)
                    .HasColumnName("koeficienty_dle_skupin")
                    .HasColumnType("int(1)");

                entity.Property(e => e.KomentarDoPredpokladmat)
                    .HasColumnName("komentar_do_predpokladmat")
                    .HasColumnType("int(10)");

                entity.Property(e => e.KontrolaMnozstvi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.KontrolaMnozstviNesmiPrekrocitZakazku)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.KontrolaMnozstviOperaceHodnota).HasColumnType("decimal(8,0)");

                entity.Property(e => e.KontrolaMnozstviOperacePrekroceni).HasColumnType("int(8)");

                entity.Property(e => e.KontrolaMnozstviOperaceTyp).HasColumnType("int(8)");

                entity.Property(e => e.LckTimeUse)
                    .HasColumnName("lck_time_use")
                    .HasColumnType("int(2)");

                entity.Property(e => e.LimitZaznamu)
                    .HasColumnName("limit_zaznamu")
                    .HasColumnType("int(2)");

                entity.Property(e => e.LimitZaznamuPocet)
                    .HasColumnName("limit_zaznamu_pocet")
                    .HasColumnType("int(7)");

                entity.Property(e => e.MainFormButtonsShow)
                    .HasColumnName("main_form_buttons_show")
                    .HasColumnType("int(1)");

                entity.Property(e => e.MenaZkratka)
                    .IsRequired()
                    .HasColumnName("MENA_ZKRATKA")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.MoneyVychoziStavId)
                    .HasColumnName("money_vychozi_stav_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.NaskladnenoZakazkyStav)
                    .HasColumnName("naskladneno_zakazky_stav")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.NazevprijemkyDleSouboru)
                    .HasColumnName("nazevprijemky_dle_souboru")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Newcolumnselector)
                    .HasColumnName("newcolumnselector")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Newsqllike)
                    .HasColumnName("newsqllike")
                    .HasColumnType("int(1)");

                entity.Property(e => e.NovaUkolMzda)
                    .HasColumnName("nova_ukol_mzda")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ObjednavkyNeseskupovatMaterial)
                    .HasColumnName("OBJEDNAVKY_NESESKUPOVAT_MATERIAL")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ObjednavkyPrebiratZakazku)
                    .HasColumnName("OBJEDNAVKY_PREBIRAT_ZAKAZKU")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ObjednavkyPrijateEnabled)
                    .HasColumnName("objednavky_prijate_enabled")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ObjednavkySubdodavkyCena)
                    .HasColumnName("objednavky_subdodavky_cena")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ObjednavkySubdodavkyDatum)
                    .HasColumnName("objednavky_subdodavky_datum")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OcrBarId)
                    .IsRequired()
                    .HasColumnName("ocr_bar_id")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("'3993'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OnePrijmForObj)
                    .HasColumnName("one_prijm_for_obj")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OperationPctUp)
                    .HasColumnName("operation_pct_up")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationUsercodeEnabled)
                    .HasColumnName("operation_usercode_enabled")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrdInsNonsklad)
                    .HasColumnName("ord_ins_nonsklad")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdInsNonskladTyp)
                    .HasColumnName("ORD_INS_NONSKLAD_TYP")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OrdIqFiltrRd)
                    .HasColumnName("ord_iq_filtr_rd")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdOnlyWorkDayLeft)
                    .HasColumnName("ord_only_work_day_left")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdShowKoop)
                    .HasColumnName("ord_show_koop")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdSumUprice)
                    .HasColumnName("ord_sum_uprice")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OrdUspora)
                    .HasColumnName("ord_uspora")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrderButtonSaveRecalculate)
                    .HasColumnName("ORDER_BUTTON_SAVE_RECALCULATE")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderCiselnavolitelna1Popis)
                    .IsRequired()
                    .HasColumnName("order_ciselnavolitelna1_popis")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderCiselnavolitelna2Popis)
                    .IsRequired()
                    .HasColumnName("order_ciselnavolitelna2_popis")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderCiselnavolitelna3Popis)
                    .IsRequired()
                    .HasColumnName("order_ciselnavolitelna3_popis")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderCiselnavolitelna4Popis)
                    .IsRequired()
                    .HasColumnName("order_ciselnavolitelna4_popis")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderCiselnavolitelna5Popis)
                    .IsRequired()
                    .HasColumnName("order_ciselnavolitelna5_popis")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderCiselnavolitelna6Popis)
                    .IsRequired()
                    .HasColumnName("order_ciselnavolitelna6_popis")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderDokoncenoProcentKusy)
                    .HasColumnName("order_dokonceno_procent_kusy")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderEditCalc)
                    .HasColumnName("orderEditCalc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderEditCalcFunctionName)
                    .IsRequired()
                    .HasColumnName("orderEditCalcFunctionName")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderEditCalcScript)
                    .IsRequired()
                    .HasColumnName("orderEditCalcScript")
                    .HasColumnType("varchar(4096)")
                    .HasDefaultValueSql("'begin end.'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderGridCenyCasy)
                    .HasColumnName("order_gridCenyCasy")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderKlonAllOperationPlanned)
                    .HasColumnName("order_klon_all_operation_planned")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderKlonText)
                    .IsRequired()
                    .HasColumnName("order_klon_text")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'KLON'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderPodzakazkaSufixFromDefault)
                    .HasColumnName("ORDER_PODZAKAZKA_SUFIX_FROM_DEFAULT")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderPrijemFinalVyrobek)
                    .HasColumnName("order_prijem_final_vyrobek")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderRozdelDefskupinastavu)
                    .IsRequired()
                    .HasColumnName("order_rozdel_defskupinastavu")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderSablonaCasMontaze)
                    .HasColumnName("ORDER_SABLONA_CAS_MONTAZE")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderSablonaKomentarObchodni)
                    .HasColumnName("ORDER_SABLONA_KOMENTAR_OBCHODNI")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderSablonaObjednavky)
                    .HasColumnName("order_sablona_objednavky")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OrderSablonaRozmery)
                    .HasColumnName("ORDER_SABLONA_ROZMERY")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderSablonaTypZakazky)
                    .HasColumnName("ORDER_SABLONA_TYP_ZAKAZKY")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderSablonaVolitelnePolozky)
                    .HasColumnName("ORDER_SABLONA_VOLITELNE_POLOZKY")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderSubdodavkaPrebiratPocetMj)
                    .HasColumnName("order_subdodavka_prebirat_pocet_mj")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderWorkEditCalc)
                    .HasColumnName("orderWorkEditCalc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderWorkEditCalcFunctionName)
                    .IsRequired()
                    .HasColumnName("orderWorkEditCalcFunctionName")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderWorkEditCalcScript)
                    .IsRequired()
                    .HasColumnName("orderWorkEditCalcScript")
                    .HasColumnType("varchar(4096)")
                    .HasDefaultValueSql("'begin end.'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderWorkPripravaVypocet)
                    .HasColumnName("order_work_priprava_vypocet")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Ordercallintranet)
                    .HasColumnName("ordercallintranet")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrdercallintranetUrl)
                    .IsRequired()
                    .HasColumnName("ordercallintranet_url")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrdereditTypVypoctuVisible)
                    .HasColumnName("orderedit_typ_vypoctu_visible")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Orderstavdirectorychange)
                    .HasColumnName("orderstavdirectorychange")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Orderstavdirectorychangeactive)
                    .HasColumnName("orderstavdirectorychangeactive")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Orderstavdirectorychangepath)
                    .IsRequired()
                    .HasColumnName("orderstavdirectorychangepath")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderworkDeleteUsed)
                    .HasColumnName("orderwork_delete_used")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OrderworkNeprepocitavatPoradi)
                    .HasColumnName("orderwork_neprepocitavat_poradi")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OrderworkNewPoradiEnabled)
                    .HasColumnName("orderwork_new_poradi_enabled")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderworkNovePoradi)
                    .HasColumnName("orderwork_nove_poradi")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OwVicenasobneOnlyFirst)
                    .HasColumnName("ow_vicenasobne_only_first")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OwVicenasobnePoradi)
                    .HasColumnName("ow_vicenasobne_poradi")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PlacVolnoBarId)
                    .IsRequired()
                    .HasColumnName("plac_volno_bar_id")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("'-1'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PriceCalculate)
                    .HasColumnName("price_calculate")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.PrijmNochEditPrice)
                    .HasColumnName("prijm_noch_edit_price")
                    .HasColumnType("int(2)");

                entity.Property(e => e.PrijmSilCtecka)
                    .HasColumnName("prijm_sil_ctecka")
                    .HasColumnType("int(2)");

                entity.Property(e => e.PrintPodpis)
                    .IsRequired()
                    .HasColumnName("print_podpis")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintworkerSkupinyChange)
                    .HasColumnName("PRINTWORKER_SKUPINY_CHANGE")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ProbihaKlon)
                    .HasColumnName("probiha_klon")
                    .HasColumnType("int(5)");

                entity.Property(e => e.RightPanelShowPozice)
                    .HasColumnName("right_panel_show_pozice")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SkladMaterialCenaCelkemTyp)
                    .HasColumnName("sklad_material_cena_celkem_typ")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SkladMaterialDodavateleShow)
                    .HasColumnName("sklad_material_dodavatele_show")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SkladMaterialInventuryShow)
                    .HasColumnName("sklad_material_inventury_show")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SkladMaterialVratkaPohyb)
                    .HasColumnName("SKLAD_MATERIAL_VRATKA_POHYB")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SkladRozpadMaterialuShow)
                    .HasColumnName("sklad_rozpad_materialu_show")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Skladpouzitvychozipohyby)
                    .HasColumnName("skladpouzitvychozipohyby")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SkladpouzitvychozipohybyPrijemka)
                    .HasColumnName("skladpouzitvychozipohyby_prijemka")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SkladpouzitvychozipohybyVydejka)
                    .HasColumnName("skladpouzitvychozipohyby_vydejka")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SlozkaFotky)
                    .IsRequired()
                    .HasColumnName("slozka_fotky")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SlozkaMoney)
                    .IsRequired()
                    .HasColumnName("slozka_money")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavZasobDoMinusu)
                    .HasColumnName("stav_zasob_do_minusu")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TypVypoctuCeny)
                    .HasColumnName("typ_vypoctu_ceny")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'4'");

                entity.Property(e => e.UkonyKomentarUkonu)
                    .HasColumnName("ukony_komentar_ukonu")
                    .HasColumnType("int(10)");

                entity.Property(e => e.UrlIntranet)
                    .IsRequired()
                    .HasColumnName("url_intranet")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UrlPrefixImage)
                    .IsRequired()
                    .HasColumnName("url_prefix_image")
                    .HasColumnType("varchar(2048)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UseDph)
                    .HasColumnName("use_dph")
                    .HasColumnType("int(5)");

                entity.Property(e => e.UseFastreport)
                    .HasColumnName("use_fastreport")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UseImportmoney)
                    .HasColumnName("use_importmoney")
                    .HasColumnType("int(10)");

                entity.Property(e => e.UseSkladovePozice)
                    .HasColumnName("useSkladovePozice")
                    .HasColumnType("int(1)");

                entity.Property(e => e.UseSkladoveSkupinyBatchOut)
                    .HasColumnName("useSkladoveSkupinyBatchOut")
                    .HasColumnType("int(1)");

                entity.Property(e => e.UseStavyDokladu)
                    .HasColumnName("useStavyDokladu")
                    .HasColumnType("int(1)");

                entity.Property(e => e.UsersColumns)
                    .HasColumnName("users_columns")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Usetisktable)
                    .HasColumnName("usetisktable")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VyberPrijemky)
                    .HasColumnName("vyber_prijemky")
                    .HasColumnType("int(10)");

                entity.Property(e => e.VychoziJazyk)
                    .IsRequired()
                    .HasColumnName("vychozi_jazyk")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'NTV'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VychoziStavZakazky)
                    .HasColumnName("vychozi_stav_zakazky")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VychoziTypCenyUkonu)
                    .HasColumnName("vychozi_typ_ceny_ukonu")
                    .HasColumnType("int(10)");

                entity.Property(e => e.VyskladnovatSPevnouCenou)
                    .HasColumnName("vyskladnovat_s_pevnou_cenou")
                    .HasColumnType("int(10)");

                entity.Property(e => e.WcPauzaBarid)
                    .IsRequired()
                    .HasColumnName("wc_pauza_barid")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WcPauzaLimit)
                    .HasColumnName("wc_pauza_limit")
                    .HasColumnType("int(10)");

                entity.Property(e => e.WebServicePinAuth).HasColumnName("WebService_PIN_Auth");

                entity.Property(e => e.WorkerKoeficientDefault)
                    .HasColumnName("worker_koeficient_default")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.WorkerMzdaDefault)
                    .HasColumnName("worker_mzda_default")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.WorkerUseKoeficient2)
                    .HasColumnName("worker_use_koeficient2")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ZakBezMarze)
                    .HasColumnName("zak_bez_marze")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ZakazkyKodNazev)
                    .HasColumnName("zakazky_kod_nazev")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ZauctovanoZakazkyStav)
                    .HasColumnName("zauctovano_zakazky_stav")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ZobrazitCelySklad)
                    .HasColumnName("zobrazit_cely_sklad")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ZobrazovatDetailAdres)
                    .HasColumnName("zobrazovat_detail_adres")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ZobrazovatZbyvajiciCasReaddata)
                    .HasColumnName("zobrazovat_zbyvajici_cas_readdata")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<Hnizda>(entity =>
            {
                entity.ToTable("hnizda");

                entity.HasIndex(e => new { e.Cislo, e.Jmeno })
                    .HasName("second");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cislo)
                    .HasColumnName("cislo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jmeno)
                    .IsRequired()
                    .HasColumnName("jmeno")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<HnizdaLogins>(entity =>
            {
                entity.ToTable("hnizda_logins");

                entity.HasIndex(e => new { e.IdHnizdo, e.IdWorker })
                    .HasName("worker_hnizdo");

                entity.HasIndex(e => new { e.IdWorker, e.Prihlaseni, e.Odhlaseni })
                    .HasName("worker_date");

                entity.HasIndex(e => new { e.IdHnizdo, e.IdWorker, e.Prihlaseni, e.Odhlaseni })
                    .HasName("hnizdo_worker_date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdHnizdo)
                    .HasColumnName("id_hnizdo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdWorker)
                    .HasColumnName("id_worker")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Odhlaseni)
                    .HasColumnName("odhlaseni")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Prihlaseni)
                    .HasColumnName("prihlaseni")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<InetFilters>(entity =>
            {
                entity.ToTable("inet_filters");

                entity.HasIndex(e => e.IdCategory)
                    .HasName("id_category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOperationGroup)
                    .HasColumnName("id_operation_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Values)
                    .HasColumnName("values")
                    .HasColumnType("text")
                    .HasCollation("utf8_czech_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Jednotky>(entity =>
            {
                entity.ToTable("jednotky");

                entity.HasComment("Seznam jednotek");

                entity.HasIndex(e => e.Nazev)
                    .HasName("nazev");

                entity.HasIndex(e => e.Poradi)
                    .HasName("poradi");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<Kraticka>(entity =>
            {
                entity.ToTable("kraticka");

                entity.HasComment("Prevodova tabulka kraticky");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.DelkaMax)
                    .HasColumnName("delka_max")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DelkaMin)
                    .HasColumnName("delka_min")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.Norma)
                    .HasColumnName("norma")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.PrurezMax)
                    .HasColumnName("prurez_max")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrurezMin)
                    .HasColumnName("prurez_min")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Kurz>(entity =>
            {
                entity.ToTable("kurz");

                entity.HasComment("Tabulka zmen kurzu cizi meny");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.Zkratka)
                    .HasName("zkratka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Kurz1)
                    .HasColumnName("kurz")
                    .HasColumnType("decimal(11,3)");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("log");

                entity.HasComment("Tabulka pro logovani prace s Vyronem");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => e.Keyword1)
                    .HasName("keyword1");

                entity.HasIndex(e => e.Keyword2)
                    .HasName("keyword2");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.HasIndex(e => e.Udalost)
                    .HasName("udalost");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.HasIndex(e => e.Verzevyron)
                    .HasName("verzevyron");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Keyword1)
                    .IsRequired()
                    .HasColumnName("keyword1")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Keyword2)
                    .IsRequired()
                    .HasColumnName("keyword2")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Typ)
                    .IsRequired()
                    .HasColumnName("typ")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Udalost)
                    .IsRequired()
                    .HasColumnName("udalost")
                    .HasColumnType("varchar(75)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(75)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Verzevyron)
                    .IsRequired()
                    .HasColumnName("verzevyron")
                    .HasColumnType("varchar(75)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("material");

                entity.HasComment("Material k zakázkám");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.ReaddataId)
                    .HasName("readdata_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Worker)
                    .HasName("worker");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CenaCelkem)
                    .HasColumnName("cena_celkem")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaCelkemNakup)
                    .HasColumnName("cena_celkem_nakup")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaJednotka)
                    .HasColumnName("cena_jednotka")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaJednotkaNakup)
                    .HasColumnName("cena_jednotka_nakup")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.ChangePrice)
                    .HasColumnName("change_price")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Jednotka)
                    .HasColumnName("jednotka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastNakupCena)
                    .HasColumnName("last_nakup_cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(9,3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PohybVazenaCena)
                    .HasColumnName("pohyb_vazena_cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.ReaddataId)
                    .HasColumnName("readdata_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VazenaCena)
                    .HasColumnName("vazena_cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Worker)
                    .IsRequired()
                    .HasColumnName("worker")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'NEZADANO'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<MaterialPredpokladany>(entity =>
            {
                entity.ToTable("material_predpokladany");

                entity.HasComment("Pøedpokladaný materiál k zakázkám");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.Objednavka)
                    .HasName("objednavka");

                entity.HasIndex(e => e.ObjednavkaId)
                    .HasName("objednavka_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Poradi)
                    .HasName("poradi");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CenaCelkem)
                    .HasColumnName("cena_celkem")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaJednotka)
                    .HasColumnName("cena_jednotka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.DateFinish)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.DatePriprava)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Jednotka)
                    .HasColumnName("jednotka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Objednavka)
                    .IsRequired()
                    .HasColumnName("objednavka")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ObjednavkaId)
                    .HasColumnName("objednavka_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Par1)
                    .HasColumnName("par1")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Par2)
                    .HasColumnName("par2")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Par3)
                    .HasColumnName("par3")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Par4)
                    .HasColumnName("par4")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Par5)
                    .HasColumnName("par5")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Par6)
                    .HasColumnName("par6")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.ParTyp)
                    .HasColumnName("par_typ")
                    .HasColumnType("bigint(50) unsigned");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vyteznost)
                    .HasColumnName("vyteznost")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<Materialy>(entity =>
            {
                entity.ToTable("materialy");

                entity.HasComment("Materiály a hustoty");

                entity.HasIndex(e => e.Nazev)
                    .HasName("nazev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Hustota)
                    .HasColumnName("hustota")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<NabidkaPolozky>(entity =>
            {
                entity.ToTable("nabidka_polozky");

                entity.HasComment("Polozky nabidky zakazky");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaCelkem)
                    .HasColumnName("cena_celkem")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaNakup)
                    .HasColumnName("cena_nakup")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Cislo)
                    .HasColumnName("cislo")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Dph)
                    .HasColumnName("dph")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'19'");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(25)");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sleva)
                    .HasColumnName("sleva")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<NaradiSkupina>(entity =>
            {
                entity.ToTable("naradi_skupina");

                entity.HasComment("Stavy zakazek");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NaradiType)
                    .HasColumnName("naradiType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("notifications");

                entity.HasComment("Tabulka notifikací k odeslání");

                entity.HasIndex(e => e.NotificationType)
                    .HasName("notification_type");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NotificationType)
                    .HasColumnName("notification_type")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Recipient)
                    .HasColumnName("recipient")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(5)");

                entity.Property(e => e.StatusText)
                    .HasColumnName("status_text")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsProcessed)
                    .HasColumnName("ts_processed")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Objednavky>(entity =>
            {
                entity.ToTable("objednavky");

                entity.HasComment("Tabulka objednavek");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.Dodani)
                    .HasName("dodani");

                entity.HasIndex(e => e.Doklad)
                    .HasName("doklad");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Splatno)
                    .HasName("splatno");

                entity.HasIndex(e => e.StavDokladu)
                    .HasName("StavDokladu");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Vykryto)
                    .HasName("vykryto");

                entity.HasIndex(e => e.VykrytoDate)
                    .HasName("vykryto_date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dodani)
                    .HasColumnName("dodani")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Doklad)
                    .IsRequired()
                    .HasColumnName("doklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Doklad2)
                    .IsRequired()
                    .HasColumnName("doklad2")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DopravaId)
                    .HasColumnName("doprava_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ExterniId)
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Splatno)
                    .HasColumnName("splatno")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.StavDokladu)
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vykryto)
                    .HasColumnName("vykryto")
                    .HasColumnType("int(4)");

                entity.Property(e => e.VykrytoDate)
                    .HasColumnName("vykryto_date")
                    .HasColumnType("date");

                entity.Property(e => e.Vystaveno)
                    .HasColumnName("vystaveno")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");
            });

            modelBuilder.Entity<ObjednavkyPolozky>(entity =>
            {
                entity.ToTable("objednavky_polozky");

                entity.HasComment("Tabulka položek objednávek");

                entity.HasIndex(e => e.BezVazby)
                    .HasName("bez_vazby");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.FormaId)
                    .HasName("forma_id");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.NaradiId)
                    .HasName("naradi_id");

                entity.HasIndex(e => e.ObjednavkaId)
                    .HasName("objednavka_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.SubdodavkaId)
                    .HasName("subdodavka_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Vykryto)
                    .HasName("vykryto");

                entity.HasIndex(e => e.VykrytoDate)
                    .HasName("vykryto_date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BezVazby)
                    .HasColumnName("bez_vazby")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DodatDo)
                    .HasColumnName("dodat_do")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ExterniId)
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FormaId)
                    .HasColumnName("forma_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kusu)
                    .HasColumnName("kusu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NaradiId)
                    .HasColumnName("naradi_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ObjednavkaId)
                    .HasColumnName("objednavka_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.SubdodavkaId)
                    .HasColumnName("subdodavka_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Vykryto)
                    .HasColumnName("vykryto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VykrytoBezVazby)
                    .HasColumnName("vykryto_bez_vazby")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.VykrytoDate)
                    .HasColumnName("vykryto_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ObjednavkyPrijate>(entity =>
            {
                entity.ToTable("objednavky_prijate");

                entity.HasComment("Tabulka prijatych objednavek");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dodat)
                    .HasColumnName("dodat")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavDokladu)
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vystaveno)
                    .HasColumnName("vystaveno")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");
            });

            modelBuilder.Entity<ObjednavkyPrijatePolozky>(entity =>
            {
                entity.ToTable("objednavky_prijate_polozky");

                entity.HasComment("Tabulka položek pøijatých objednávek");

                entity.HasIndex(e => e.ObjednavkaId)
                    .HasName("objednavka_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kusu)
                    .HasColumnName("kusu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ObjednavkaId)
                    .HasColumnName("objednavka_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PotvrzenaCena)
                    .HasColumnName("potvrzena_cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.PotvrzenaCenaJednotka)
                    .HasColumnName("potvrzena_cena_jednotka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.PotvrzeneDatum)
                    .HasColumnName("potvrzene_datum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.PozadoveneDatum)
                    .HasColumnName("pozadovene_datum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Pozice)
                    .IsRequired()
                    .HasColumnName("pozice")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.ToTable("operation");

                entity.HasComment("Operace");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("id_employee");

                entity.HasIndex(e => e.MachineName)
                    .HasName("machine_name");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OperacePredchazejiciFix)
                    .HasName("operace_predchazejici_fix");

                entity.HasIndex(e => e.OperacePredchazejiciId)
                    .HasName("operace_predchazejici_id");

                entity.HasIndex(e => e.OrderstavId)
                    .HasName("orderstav_id");

                entity.HasIndex(e => e.Priprava)
                    .HasName("priprava");

                entity.HasIndex(e => e.PripravaCas)
                    .HasName("pripravaCas");

                entity.HasIndex(e => e.PripravaInterval)
                    .HasName("pripravaInterval");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.UkolovaMzda)
                    .HasName("ukolova_mzda");

                entity.HasIndex(e => e.UserCode)
                    .HasName("userCode");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AutoWritte)
                    .HasColumnName("auto_writte")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CenaFaktura)
                    .HasColumnName("cena_faktura")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaMjOdmeny)
                    .HasColumnName("cena_mj_odmeny")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaMjOperace)
                    .HasColumnName("cena_mj_operace")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaMzdovePolozky)
                    .HasColumnName("cena_mzdove_polozky")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaRezie)
                    .HasColumnName("cena_rezie")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CncId)
                    .HasColumnName("cnc_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCnc)
                    .HasColumnName("is_cnc")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsDochazka)
                    .HasColumnName("is_dochazka")
                    .HasColumnType("int(1)");

                entity.Property(e => e.KoeficientMzdy)
                    .HasColumnName("koeficient_mzdy")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasColumnName("machine_name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.MaxminZaDen)
                    .HasColumnName("maxmin_za_den")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OpenDoor)
                    .HasColumnName("open_door")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperacePredchazejiciCas)
                    .HasColumnName("operace_predchazejici_cas")
                    .HasColumnType("int(12)");

                entity.Property(e => e.OperacePredchazejiciFix)
                    .HasColumnName("operace_predchazejici_fix")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OperacePredchazejiciId)
                    .HasColumnName("operace_predchazejici_id")
                    .HasColumnType("int(12)");

                entity.Property(e => e.OrderstavId)
                    .HasColumnName("orderstav_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.PlanovanoMin)
                    .HasColumnName("planovano_min")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priprava)
                    .HasColumnName("priprava")
                    .HasColumnType("int(2)");

                entity.Property(e => e.PripravaCas)
                    .HasColumnName("pripravaCas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PripravaInterval)
                    .HasColumnName("pripravaInterval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resource_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SkladSkupinaId)
                    .HasColumnName("sklad_skupina_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TakePhoto)
                    .HasColumnName("take_photo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UkolovaMzda)
                    .HasColumnName("ukolova_mzda")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Unitcount)
                    .HasColumnName("unitcount")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasColumnName("userCode")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<OperationDefault>(entity =>
            {
                entity.ToTable("operation_default");

                entity.HasIndex(e => e.Name)
                    .HasName("Second");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PausalId)
                    .HasColumnName("pausal_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<OperationGroup>(entity =>
            {
                entity.ToTable("operation_group");

                entity.HasComment("Skupiny operaci");

                entity.HasIndex(e => e.Cislo)
                    .HasName("cislo");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Zkratka)
                    .HasName("zkratka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cislo)
                    .IsRequired()
                    .HasColumnName("cislo")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<OrderCalcList>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("order_calc_list");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderId")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zdroj)
                    .IsRequired()
                    .HasColumnName("zdroj")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<OrderFilter>(entity =>
            {
                entity.ToTable("order_filter");

                entity.HasComment("Tabulka uložených filtrù zakázek");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cislo)
                    .HasColumnName("cislo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DokonceniDo)
                    .HasColumnName("dokonceni_do")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DokonceniOd)
                    .HasColumnName("dokonceni_od")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PosouvatDokonceni)
                    .IsRequired()
                    .HasColumnName("posouvat_dokonceni")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PosouvatZadano)
                    .IsRequired()
                    .HasColumnName("posouvat_zadano")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PosouvatZmenustavu)
                    .IsRequired()
                    .HasColumnName("posouvat_zmenustavu")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Stavy)
                    .IsRequired()
                    .HasColumnName("stavy")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TextovePolozky)
                    .IsRequired()
                    .HasColumnName("textove_polozky")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Typy)
                    .IsRequired()
                    .HasColumnName("typy")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Ulozeno)
                    .HasColumnName("ulozeno")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.UseDokonceni)
                    .IsRequired()
                    .HasColumnName("use_dokonceni")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UseZadano)
                    .IsRequired()
                    .HasColumnName("use_zadano")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UseZmenastavu)
                    .IsRequired()
                    .HasColumnName("use_zmenastavu")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZadanoDo)
                    .HasColumnName("zadano_do")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ZadanoOd)
                    .HasColumnName("zadano_od")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Zmenastavu)
                    .IsRequired()
                    .HasColumnName("zmenastavu")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZmenastavuDo)
                    .HasColumnName("zmenastavu_do")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ZmenastavuOd)
                    .HasColumnName("zmenastavu_od")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");
            });

            modelBuilder.Entity<OrderPriorityFont>(entity =>
            {
                entity.ToTable("order_priority_font");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bold)
                    .HasColumnName("bold")
                    .HasColumnType("int(3)");

                entity.Property(e => e.ColorBrush)
                    .HasColumnName("color_brush")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ColorPen)
                    .HasColumnName("color_pen")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Crossline)
                    .HasColumnName("crossline")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Italic)
                    .HasColumnName("italic")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Pismo)
                    .IsRequired()
                    .HasColumnName("pismo")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrioritaId)
                    .HasColumnName("priorita_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.Underline)
                    .HasColumnName("underline")
                    .HasColumnType("int(3)");
            });

            modelBuilder.Entity<OrderStav>(entity =>
            {
                entity.ToTable("order_stav");

                entity.HasComment("Stavy zakazek");

                entity.HasIndex(e => e.BlokaceMat)
                    .HasName("blokace_mat");

                entity.HasIndex(e => e.ChangeOperationId)
                    .HasName("change_operation_id");

                entity.HasIndex(e => e.FinalStatus)
                    .HasName("FinalStatus");

                entity.HasIndex(e => e.GroupName)
                    .HasName("group_name");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.PocitatPlan)
                    .HasName("pocitat_plan");

                entity.HasIndex(e => e.Poradi)
                    .HasName("poradi");

                entity.HasIndex(e => e.Prepocitavat)
                    .HasName("prepocitavat");

                entity.HasIndex(e => e.StavVyroba)
                    .HasName("stav_vyroba");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarevneOznaceni)
                    .HasColumnName("barevne_oznaceni")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Barva)
                    .HasColumnName("barva")
                    .HasColumnType("int(10)");

                entity.Property(e => e.BlokaceMat)
                    .HasColumnName("blokace_mat")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ChangeOperationId)
                    .HasColumnName("change_operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Cislo)
                    .IsRequired()
                    .HasColumnName("cislo")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FinalStatus).HasColumnType("int(1)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.InPrint)
                    .HasColumnName("in_print")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PocitatPlan)
                    .HasColumnName("pocitat_plan")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prepocitavat)
                    .HasColumnName("prepocitavat")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StavVyroba)
                    .HasColumnName("stav_vyroba")
                    .HasColumnType("int(10)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<OrderUrovne>(entity =>
            {
                entity.ToTable("order_urovne");

                entity.HasComment("Popisy úrovní zakázek");

                entity.HasIndex(e => e.Nazev)
                    .HasName("Nazev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.BarvaFontu)
                    .IsRequired()
                    .HasColumnName("barva_fontu")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BarvaPozadi)
                    .IsRequired()
                    .HasColumnName("barva_pozadi")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.GlyphId)
                    .HasColumnName("glyph_id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StylFontu)
                    .IsRequired()
                    .HasColumnName("styl_fontu")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<OrderWork>(entity =>
            {
                entity.ToTable("order_work");

                entity.HasComment("Tabulka normovanych operaci k jednotlivym zakazkam");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.FinishReq)
                    .HasName("finish_req");

                entity.HasIndex(e => e.Forma1Id)
                    .HasName("forma1_id");

                entity.HasIndex(e => e.Id)
                    .HasName("id");

                entity.HasIndex(e => e.OperacePredchazejiciAdded)
                    .HasName("operace_predchazejici_added");

                entity.HasIndex(e => e.OperacePredchazejiciId)
                    .HasName("operace_predchazejici_id");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Poradi)
                    .HasName("poradi");

                entity.HasIndex(e => e.PoradiTechpostup)
                    .HasName("poradi_techpostup");

                entity.HasIndex(e => e.Priorita)
                    .HasName("priorita");

                entity.HasIndex(e => e.Priznaky)
                    .HasName("priznaky");

                entity.HasIndex(e => e.RealTime)
                    .HasName("real_time");

                entity.HasIndex(e => e.StartReq)
                    .HasName("start_req");

                entity.HasIndex(e => e.TsCalculated)
                    .HasName("ts_Calculated");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastCalculated)
                    .HasName("ts_lastCalculated");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.UserTime)
                    .HasName("user_time");

                entity.HasIndex(e => e.VyplnenoUkolovaMzda)
                    .HasName("vyplneno_ukolova_mzda");

                entity.HasIndex(e => new { e.OrderId, e.OperationId })
                    .HasName("slozenyIndex1");

                entity.HasIndex(e => new { e.OrderId, e.UserTime })
                    .HasName("slozeny1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FinishReq)
                    .HasColumnName("finish_req")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Forma1Id)
                    .HasColumnName("forma1_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Forma1MaterialCyklus)
                    .HasColumnName("forma1_material_cyklus")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Forma1MnozstviCyklus)
                    .HasColumnName("forma1_mnozstvi_cyklus")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.KoeficientVyroby)
                    .HasColumnName("koeficient_vyroby")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Odpracovano)
                    .HasColumnName("odpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpCenaFaktura)
                    .HasColumnName("op_cena_faktura")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpCenaMj)
                    .HasColumnName("op_cena_mj")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpCenaMjOdmeny)
                    .HasColumnName("op_cena_mj_odmeny")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpCenaRezie)
                    .HasColumnName("op_cena_rezie")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpStrojCena)
                    .HasColumnName("op_stroj_cena")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpStrojId)
                    .HasColumnName("op_stroj_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpUkolovaMzda)
                    .HasColumnName("op_ukolova_mzda")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpUnitPrice)
                    .HasColumnName("op_unit_price")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OperacePredchazejiciAdded)
                    .HasColumnName("operace_predchazejici_added")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OperacePredchazejiciCas)
                    .HasColumnName("operace_predchazejici_cas")
                    .HasColumnType("int(12)");

                entity.Property(e => e.OperacePredchazejiciFix)
                    .HasColumnName("operace_predchazejici_fix")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OperacePredchazejiciId)
                    .HasColumnName("operace_predchazejici_id")
                    .HasColumnType("int(12)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PlanKalendar)
                    .HasColumnName("plan_kalendar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(5)");

                entity.Property(e => e.PoradiTechpostup)
                    .HasColumnName("poradi_techpostup")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priorita)
                    .HasColumnName("priorita")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priprava)
                    .HasColumnName("priprava")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PripravaCas)
                    .HasColumnName("pripravaCas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PripravaInterval)
                    .HasColumnName("pripravaInterval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PripravaKoeficient)
                    .HasColumnName("pripravaKoeficient")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priznaky)
                    .HasColumnName("priznaky")
                    .HasColumnType("int(4)");

                entity.Property(e => e.RealPrice)
                    .HasColumnName("real_price")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.RealTime)
                    .HasColumnName("real_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartReq)
                    .HasColumnName("start_req")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TsCalculated)
                    .HasColumnName("ts_Calculated")
                    .HasColumnType("int(1)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastCalculated)
                    .HasColumnName("ts_lastCalculated")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TypVypoctu)
                    .HasColumnName("typ_vypoctu")
                    .HasColumnType("int(1)");

                entity.Property(e => e.UkolovaMzda)
                    .HasColumnName("ukolova_mzda")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Units)
                    .HasColumnName("units")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.UserPrice)
                    .HasColumnName("user_price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.UserTime)
                    .HasColumnName("user_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserTimeKsSecond)
                    .HasColumnName("user_time_ks_second")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VyplnenoUkolovaMzda)
                    .HasColumnName("vyplneno_ukolova_mzda")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Vyrobenocelkem)
                    .HasColumnName("vyrobenocelkem")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.ZmetkuCelkem)
                    .HasColumnName("zmetku_celkem")
                    .HasColumnType("decimal(11,3)");
            });

            modelBuilder.Entity<OrderWorkPlan>(entity =>
            {
                entity.ToTable("order_work_plan");

                entity.HasComment("Uspora èasu");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PlanTime)
                    .HasColumnName("plan_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Packages>(entity =>
            {
                entity.ToTable("packages");

                entity.HasIndex(e => e.Id)
                    .HasName("id_unique");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BarId)
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Expedice)
                    .HasColumnName("expedice")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpediceBar)
                    .HasColumnName("expedice_bar")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Hmotnost)
                    .HasColumnName("hmotnost")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Hnizdo)
                    .HasColumnName("hnizdo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Odeslan)
                    .HasColumnName("odeslan")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ReaddataId)
                    .HasColumnName("readdata_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SouborExp)
                    .HasColumnName("soubor_exp")
                    .HasColumnType("varchar(120)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SpeditionId)
                    .HasColumnName("spedition_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tisk)
                    .HasColumnName("tisk")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VytistenoDne)
                    .HasColumnName("vytisteno_dne")
                    .HasColumnType("datetime");

                entity.Property(e => e.Vytvoren)
                    .HasColumnName("vytvoren")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zabalen)
                    .HasColumnName("zabalen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Pausal>(entity =>
            {
                entity.ToTable("pausal");

                entity.HasComment("Pausalni operace");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<PlanGroupSmeny>(entity =>
            {
                entity.HasKey(e => new { e.IdStandardniSmena, e.IdSmena, e.IdDen, e.MistoPrace, e.TypSmeny, e.IdPlanSmenaSkupina, e.IdPlanSmena, e.IdMistoPrace, e.IdTypSmeny, e.IdPracovniSkupina })
                    .HasName("PRIMARY");

                entity.ToTable("plan_group_smeny");

                entity.HasComment("Plán místo práce");

                entity.Property(e => e.IdStandardniSmena)
                    .HasColumnName("id_standardni_smena")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSmena)
                    .HasColumnName("id_smena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdDen)
                    .HasColumnName("id_den")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MistoPrace)
                    .HasColumnName("misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypSmeny)
                    .HasColumnName("typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanSmenaSkupina)
                    .HasColumnName("id_plan_smena_skupina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanSmena)
                    .HasColumnName("id_plan_smena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPracovniSkupina)
                    .HasColumnName("id_pracovni_skupina")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanMistoPrace>(entity =>
            {
                entity.HasKey(e => e.IdMistoPrace)
                    .HasName("PRIMARY");

                entity.ToTable("plan_misto_prace");

                entity.HasComment("Plán místo práce");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaMitPlan)
                    .HasColumnName("ma_mit_plan")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Popis)
                    .IsRequired()
                    .HasColumnName("popis")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<PlanNaDen>(entity =>
            {
                entity.HasKey(e => e.IdPlanDen)
                    .HasName("PRIMARY");

                entity.ToTable("plan_na_den");

                entity.HasComment("Plán na den");

                entity.HasIndex(e => new { e.IdWorker, e.IdMistoPrace, e.IdTypSmeny })
                    .HasName("slozeny index");

                entity.Property(e => e.IdPlanDen)
                    .HasColumnName("id_plan_den")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DenVKalendari)
                    .HasColumnName("den_v_kalendari")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdWorker)
                    .HasColumnName("id_worker")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerKapacitaDen)
                    .HasColumnName("worker_kapacita_den")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.WorkerStav)
                    .HasColumnName("worker_stav")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanSmena>(entity =>
            {
                entity.HasKey(e => new { e.IdPlanSmena, e.IdTypProvoz, e.IdTypSmeny, e.IdMistoPrace })
                    .HasName("PRIMARY");

                entity.ToTable("plan_smena");

                entity.HasComment("Plán místo práce");

                entity.Property(e => e.IdPlanSmena)
                    .HasColumnName("id_plan_smena")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdTypProvoz)
                    .HasColumnName("id_typ_provoz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanSmenaNaDen>(entity =>
            {
                entity.HasKey(e => new { e.IdPlanSmenaNaDen, e.IdPlanSmena, e.IdTypProvoz, e.IdTypSmeny, e.IdMistoPrace })
                    .HasName("PRIMARY");

                entity.ToTable("plan_smena_na_den");

                entity.HasComment("Plán na den");

                entity.Property(e => e.IdPlanSmenaNaDen)
                    .HasColumnName("id_plan_smena_na_den")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdPlanSmena)
                    .HasColumnName("id_plan_smena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypProvoz)
                    .HasColumnName("id_typ_provoz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DenVKalendari)
                    .HasColumnName("den_v_kalendari")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.KapacitaNaDen)
                    .HasColumnName("kapacita_na_den")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.KapacitaNaplnena)
                    .HasColumnName("kapacita_naplnena")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanSmenaSkupina>(entity =>
            {
                entity.HasKey(e => new { e.IdPlanSmenaSkupina, e.IdPlanSmena, e.IdMistoPrace, e.IdTypSmeny, e.IdPracovniSkupina })
                    .HasName("PRIMARY");

                entity.ToTable("plan_smena_skupina");

                entity.HasComment("Plán smìn skupiny");

                entity.Property(e => e.IdPlanSmenaSkupina)
                    .HasColumnName("id_plan_smena_skupina")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdPlanSmena)
                    .HasColumnName("id_plan_smena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPracovniSkupina)
                    .HasColumnName("id_pracovni_skupina")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanStandardniSmena>(entity =>
            {
                entity.HasKey(e => new { e.IdStandardniSmena, e.DenVTydnu, e.IdPlanSmenaSkupina, e.IdPlanSmena, e.IdMistoPrace, e.IdTypSmeny, e.IdPracovniSkupina })
                    .HasName("PRIMARY");

                entity.ToTable("plan_standardni_smena");

                entity.HasComment("èíselník plán standardních smìn");

                entity.Property(e => e.IdStandardniSmena)
                    .HasColumnName("id_standardni_smena")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DenVTydnu)
                    .HasColumnName("den_v_tydnu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanSmenaSkupina)
                    .HasColumnName("id_plan_smena_skupina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanSmena)
                    .HasColumnName("id_plan_smena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypSmeny)
                    .HasColumnName("id_typ_smeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPracovniSkupina)
                    .HasColumnName("id_pracovni_skupina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FondHodin)
                    .HasColumnName("fond_hodin")
                    .HasColumnType("decimal(5,2)");
            });

            modelBuilder.Entity<PlanWorker>(entity =>
            {
                entity.HasKey(e => e.IdWorker)
                    .HasName("PRIMARY");

                entity.ToTable("plan_worker");

                entity.HasComment("Plán worker");

                entity.Property(e => e.IdWorker)
                    .HasColumnName("id_worker")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dovolena)
                    .HasColumnName("dovolena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Prescas)
                    .HasColumnName("prescas")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanWorkerSkupina>(entity =>
            {
                entity.HasKey(e => e.IdWorkerSkupina)
                    .HasName("PRIMARY");

                entity.ToTable("plan_worker_skupina");

                entity.HasComment("Plán místo práce");

                entity.Property(e => e.IdWorkerSkupina)
                    .HasColumnName("id_worker_skupina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaMitPlan)
                    .HasColumnName("ma_mit_plan")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Popis)
                    .IsRequired()
                    .HasColumnName("popis")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Pozice>(entity =>
            {
                entity.ToTable("pozice");

                entity.HasComment("Pozice materialu");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.Pozice1)
                    .HasName("pozice");

                entity.HasIndex(e => e.SkladId)
                    .HasName("sklad_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Pozice1)
                    .IsRequired()
                    .HasColumnName("pozice")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SkladId)
                    .HasColumnName("sklad_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ProhlidkyStroje>(entity =>
            {
                entity.ToTable("prohlidky_stroje");

                entity.HasComment("Sevisni prohlidny jednotlivych stroju");

                entity.HasIndex(e => e.StrojId)
                    .HasName("stroj_id");

                entity.HasIndex(e => e.TypId)
                    .HasName("typ_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavHodin)
                    .HasColumnName("stav_hodin")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StrojId)
                    .HasColumnName("stroj_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StrojTyp)
                    .HasColumnName("stroj_typ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypId)
                    .HasColumnName("typ_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PruvList>(entity =>
            {
                entity.ToTable("pruv_list");

                entity.HasComment("pruvodni list zakazek");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(9,3)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Rucnizmena)
                    .HasColumnName("rucnizmena")
                    .HasColumnType("int(5)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Zmetku)
                    .HasColumnName("zmetku")
                    .HasColumnType("decimal(9,3)");
            });

            modelBuilder.Entity<Readdata>(entity =>
            {
                entity.ToTable("readdata");

                entity.HasComment("Nactena data prace zamestnancu");

                entity.HasIndex(e => e.Calculated)
                    .HasName("calculated");

                entity.HasIndex(e => e.CalculatedMachine)
                    .HasName("calculated_machine");

                entity.HasIndex(e => e.CalculatedOrderwork)
                    .HasName("calculated_orderwork");

                entity.HasIndex(e => e.CenyAdded)
                    .HasName("ceny_added");

                entity.HasIndex(e => e.DodaciListPolozkaId)
                    .HasName("dodaci_list_polozka_id");

                entity.HasIndex(e => e.Exportovano)
                    .HasName("exportovano");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.FakturaDoklad)
                    .HasName("faktura_doklad");

                entity.HasIndex(e => e.FakturaId)
                    .HasName("faktura_id");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.OperationId)
                    .HasName("UK_readdata_operation_id")
                    .IsUnique();

                entity.HasIndex(e => e.OrderGroupId)
                    .HasName("order_group_id");

                entity.HasIndex(e => e.OrderworkId)
                    .HasName("orderwork_id");

                entity.HasIndex(e => e.PoradiOperace)
                    .HasName("poradi_operace");

                entity.HasIndex(e => e.RepairType)
                    .HasName("repair_type");

                entity.HasIndex(e => e.SerialId)
                    .HasName("serial_id");

                entity.HasIndex(e => e.SerialIdStr)
                    .HasName("serial_id_str");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.TypUkonMzdy)
                    .HasName("typ_ukon_mzdy");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("UK_readdata_worker_id")
                    .IsUnique();

                entity.HasIndex(e => e.WorkerId2)
                    .HasName("worker_id2");

                entity.HasIndex(e => new { e.OrderId, e.OperationId })
                    .HasName("slozenyIndex1");

                entity.HasIndex(e => new { e.OrderId, e.Start })
                    .HasName("slozenyIndexOperIdStart");

                entity.HasIndex(e => new { e.WorkerId, e.WorkerId2 })
                    .HasName("worker_id12");

                entity.HasIndex(e => new { e.OrderId, e.Finish, e.Id, e.Start })
                    .HasName("slozenyIndex3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AddedPrice)
                    .HasColumnName("added_price")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Calculated)
                    .HasColumnName("calculated")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CalculatedKalendar)
                    .HasColumnName("calculated_kalendar")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CalculatedMachine)
                    .HasColumnName("calculated_machine")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CalculatedOrderwork)
                    .HasColumnName("calculated_orderwork")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CenaCnc)
                    .HasColumnName("cena_cnc")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaMj)
                    .HasColumnName("cena_MJ")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.CenaOperation)
                    .HasColumnName("cena_operation")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaStroj)
                    .HasColumnName("cena_stroj")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaWorker)
                    .HasColumnName("cena_worker")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaWorker2)
                    .HasColumnName("cena_worker2")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenyAdded)
                    .HasColumnName("ceny_added")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DodaciListPolozkaId)
                    .HasColumnName("dodaci_list_polozka_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Exportovano)
                    .HasColumnName("exportovano")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ExterniId)
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakturaDoklad)
                    .HasColumnName("faktura_doklad")
                    .HasColumnType("varchar(150)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakturaId)
                    .HasColumnName("faktura_id")
                    .HasColumnType("int(15)");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Hnizdo)
                    .HasColumnName("hnizdo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KusyZapocteno)
                    .HasColumnName("kusy_zapocteno")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Naklady)
                    .HasColumnName("naklady")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.NakladyOperation)
                    .HasColumnName("naklady_operation")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.NakladyOrder)
                    .HasColumnName("naklady_order")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.NakladyVstup)
                    .HasColumnName("naklady_vstup")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.NakladyWorker)
                    .HasColumnName("naklady_worker")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderGroupId)
                    .HasColumnName("order_group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderworkId)
                    .HasColumnName("orderwork_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PhotoCount)
                    .HasColumnName("photo_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PoradiOperace)
                    .HasColumnName("poradi_operace")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Prepocitano)
                    .HasColumnName("prepocitano")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Priorita)
                    .HasColumnName("priorita")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepairType)
                    .HasColumnName("repair_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sarze)
                    .IsRequired()
                    .HasColumnName("sarze")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SerialId)
                    .HasColumnName("serial_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SerialIdStr)
                    .HasColumnName("serial_id_str")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TerminalIp)
                    .IsRequired()
                    .HasColumnName("terminal_ip")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TypUkonMzdy)
                    .HasColumnName("typ_ukon_mzdy")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TypVypoctu)
                    .HasColumnName("typ_vypoctu")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UkonMzda)
                    .HasColumnName("ukon_mzda")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.UkonovaMzda)
                    .HasColumnName("ukonova_mzda")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.UmFondOdpis)
                    .HasColumnName("um_fond_odpis")
                    .HasColumnType("int(15)");

                entity.Property(e => e.UmFondZbyva)
                    .HasColumnName("um_fond_zbyva")
                    .HasColumnType("int(15)");

                entity.Property(e => e.UmUznano)
                    .HasColumnName("um_uznano")
                    .HasColumnType("int(15)");

                entity.Property(e => e.UmUznanoDatum)
                    .HasColumnName("um_uznano_datum")
                    .HasColumnType("datetime");

                entity.Property(e => e.UmUznanoUser)
                    .HasColumnName("um_uznano_user")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Volitelna1)
                    .HasColumnName("volitelna1")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Volitelna2)
                    .HasColumnName("volitelna2")
                    .HasColumnType("decimal(7,2)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId2)
                    .HasColumnName("worker_id2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zamceno)
                    .HasColumnName("zamceno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZamcenoCas)
                    .HasColumnName("zamceno_cas")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ZamcenoIdUser)
                    .HasColumnName("zamceno_id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zmetku)
                    .HasColumnName("zmetku")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<ReaddataCeny>(entity =>
            {
                entity.ToTable("readdata_ceny");

                entity.HasIndex(e => e.Added)
                    .HasName("added");

                entity.HasIndex(e => e.Calculated)
                    .HasName("calculated");

                entity.HasIndex(e => e.IdReaddata)
                    .HasName("id_readdata");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.HasIndex(e => e.WorkerId2)
                    .HasName("worker_id2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Added)
                    .HasColumnName("added")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Calculated)
                    .HasColumnName("calculated")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CenaCnc)
                    .HasColumnName("cena_cnc")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaOperation)
                    .HasColumnName("cena_operation")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaOperationMj)
                    .HasColumnName("cena_operation_mj")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaOwOperation)
                    .HasColumnName("cena_ow_operation")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaOwOperationMj)
                    .HasColumnName("cena_ow_operation_mj")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaStroj)
                    .HasColumnName("cena_stroj")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaWorker)
                    .HasColumnName("cena_worker")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaWorker2)
                    .HasColumnName("cena_worker2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaWorker2Faktura)
                    .HasColumnName("cena_worker2_faktura")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaWorker2Naklad)
                    .HasColumnName("cena_worker2_naklad")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaWorkerFaktura)
                    .HasColumnName("cena_worker_faktura")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaWorkerNaklad)
                    .HasColumnName("cena_worker_naklad")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.IdReaddata)
                    .HasColumnName("id_readdata")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Mzda)
                    .HasColumnName("mzda")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.MzdaHod)
                    .HasColumnName("mzda_hod")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.MzdaUkol)
                    .HasColumnName("mzda_ukol")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Naklad)
                    .HasColumnName("naklad")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Odvody)
                    .HasColumnName("odvody")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.OpCenaMj)
                    .HasColumnName("op_cena_mj")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpCenaMjOdmena)
                    .HasColumnName("op_cena_mj_odmena")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OpCenaRezie)
                    .HasColumnName("op_cena_rezie")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.OpUkolMzda)
                    .HasColumnName("op_ukol_mzda")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'-1'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OwCenaRezie)
                    .HasColumnName("ow_cena_rezie")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OwUkolovaMzda)
                    .HasColumnName("ow_ukolova_mzda")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.OwUnitPrice)
                    .HasColumnName("ow_unit_price")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Rezie)
                    .HasColumnName("rezie")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.TsCalculated)
                    .HasColumnName("ts_calculated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.TsChanged)
                    .HasColumnName("ts_changed")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TypVypoctu)
                    .HasColumnName("typ_vypoctu")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Verze)
                    .IsRequired()
                    .HasColumnName("verze")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Worker2KoefSkutNakl)
                    .HasColumnName("worker2_koef_skut_nakl")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Worker2PriceSat)
                    .HasColumnName("worker2_price_sat")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Worker2PriceSun)
                    .HasColumnName("worker2_price_sun")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId2)
                    .HasColumnName("worker_id2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerKoefSkutNakl)
                    .HasColumnName("worker_koef_skut_nakl")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.WorkerPriceSat)
                    .HasColumnName("worker_price_sat")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.WorkerPriceSun)
                    .HasColumnName("worker_price_sun")
                    .HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<ReaddataFoto>(entity =>
            {
                entity.ToTable("readdata_foto");

                entity.HasComment("Tabulka odkazu na snimky");

                entity.HasIndex(e => e.ReaddataId)
                    .HasName("readdata_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.FotoPath)
                    .IsRequired()
                    .HasColumnName("foto_path")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ReaddataId)
                    .HasColumnName("readdata_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.ToTable("reader");

                entity.HasComment("???");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RefOperationCnc>(entity =>
            {
                entity.ToTable("ref_operation_cnc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncId)
                    .HasColumnName("cnc_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RefOperationWorker>(entity =>
            {
                entity.ToTable("ref_operation_worker");

                entity.HasIndex(e => e.OperationCena)
                    .HasName("operation_cena");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.WorkerCena)
                    .HasName("worker_cena");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationCena)
                    .HasColumnName("operation_cena")
                    .HasColumnType("float(15,3)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerCena)
                    .HasColumnName("worker_cena")
                    .HasColumnType("float(15,3)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RefUserOrderstav>(entity =>
            {
                entity.ToTable("ref_user_orderstav");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderStav)
                    .HasColumnName("order_stav")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RefUserOrdertyp>(entity =>
            {
                entity.ToTable("ref_user_ordertyp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderTyp)
                    .HasColumnName("order_typ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RefWorkerCnc>(entity =>
            {
                entity.ToTable("ref_worker_cnc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncId)
                    .HasColumnName("cnc_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Registrace>(entity =>
            {
                entity.HasKey(e => e.Hwnumber)
                    .HasName("PRIMARY");

                entity.ToTable("registrace");

                entity.HasComment("registrace");

                entity.HasIndex(e => e.Id)
                    .HasName("id");

                entity.Property(e => e.Hwnumber)
                    .HasColumnName("hwnumber")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Cnt)
                    .HasColumnName("cnt")
                    .HasColumnType("blob");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RepairType>(entity =>
            {
                entity.ToTable("repair_type");

                entity.HasComment("Typy oprav");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SablonyOperationGroup>(entity =>
            {
                entity.ToTable("sablony_operation_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SablonySkladGroup>(entity =>
            {
                entity.ToTable("sablony_sklad_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Schedulerresource>(entity =>
            {
                entity.HasKey(e => e.ResourceId)
                    .HasName("PRIMARY");

                entity.ToTable("schedulerresource");

                entity.HasComment("Jednotky planovaciho kalendare");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("ResourceID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CtFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'17:00:00'");

                entity.Property(e => e.CtStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'08:00:00'");

                entity.Property(e => e.Fond).HasColumnType("decimal(11,3)");

                entity.Property(e => e.NeFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.NeStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PaFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'17:00:00'");

                entity.Property(e => e.PaStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'08:00:00'");

                entity.Property(e => e.PoFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'17:00:00'");

                entity.Property(e => e.PoStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'08:00:00'");

                entity.Property(e => e.ResourceColor).HasColumnType("int(11)");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SoFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.SoStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.StFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'17:00:00'");

                entity.Property(e => e.StStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'08:00:00'");

                entity.Property(e => e.UtFinish)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'17:00:00'");

                entity.Property(e => e.UtStart)
                    .HasColumnType("time")
                    .HasDefaultValueSql("'08:00:00'");
            });

            modelBuilder.Entity<Schedulertable>(entity =>
            {
                entity.ToTable("schedulertable");

                entity.HasComment("Planovaci kalendar");

                entity.HasIndex(e => e.OperationId)
                    .HasName("operation_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Caption)
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CasNaKus)
                    .HasColumnName("cas_na_kus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventType).HasColumnType("int(11)");

                entity.Property(e => e.Finish)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 00:00:00'");

                entity.Property(e => e.LabelColor).HasColumnType("int(11)");

                entity.Property(e => e.LabelColor2).HasColumnType("int(11)");

                entity.Property(e => e.LabelColor3).HasColumnType("int(11)");

                entity.Property(e => e.LabelColor4).HasColumnType("int(11)");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(25)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Message)
                    .HasColumnType("longtext")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OdpracCas)
                    .HasColumnName("odprac_cas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("varchar(10)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Options).HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PlanCas)
                    .HasColumnName("plan_cas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanKs)
                    .HasColumnName("plan_ks")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.ReaddataId)
                    .HasColumnName("readdata_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("ResourceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 00:00:00'");

                entity.Property(e => e.State).HasColumnType("int(11)");

                entity.Property(e => e.TypKolize)
                    .HasColumnName("typ_kolize")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vyteznost)
                    .HasColumnName("vyteznost")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("varchar(10)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zaplanovano)
                    .HasColumnName("zaplanovano")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Script>(entity =>
            {
                entity.ToTable("script");

                entity.HasComment("Tabulka skriptù pro customizaci programu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Events)
                    .HasColumnName("events")
                    .HasColumnType("longtext")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SerialCode>(entity =>
            {
                entity.ToTable("serial_code");

                entity.HasComment("Seriova cisla");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oznaceni)
                    .IsRequired()
                    .HasColumnName("oznaceni")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Radek)
                    .HasColumnName("radek")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ServisTyp>(entity =>
            {
                entity.ToTable("servis_typ");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgendaId)
                    .HasColumnName("agenda_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<ServisTypRefStroje>(entity =>
            {
                entity.HasKey(e => new { e.StrojId, e.StrojTyp, e.TypId })
                    .HasName("PRIMARY");

                entity.ToTable("servis_typ_ref_stroje");

                entity.HasIndex(e => e.Id)
                    .HasName("id");

                entity.HasIndex(e => e.StrojId)
                    .HasName("stroj_id");

                entity.HasIndex(e => e.StrojTyp)
                    .HasName("stroj_typ");

                entity.Property(e => e.StrojId)
                    .HasColumnName("stroj_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StrojTyp)
                    .HasColumnName("stroj_typ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypId)
                    .HasColumnName("typ_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ServisIntervalCas)
                    .HasColumnName("servis_interval_cas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServisIntervalMj)
                    .HasColumnName("servis_interval_mj")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServisIntervalObdobi)
                    .HasColumnName("servis_interval_obdobi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServisIntervalObdobiTyp)
                    .HasColumnName("servis_interval_obdobi_typ")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ServisIntervalTyp)
                    .HasColumnName("servis_interval_typ")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ServisOperationId)
                    .HasColumnName("servis_operation_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");
            });

            modelBuilder.Entity<SkladFormy>(entity =>
            {
                entity.ToTable("sklad_formy");

                entity.HasComment("Sklad forem");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.DodavatelId)
                    .HasName("dodavatel_id");

                entity.HasIndex(e => e.Nakup)
                    .HasName("nakup");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Servis)
                    .HasName("servis");

                entity.HasIndex(e => e.Stav)
                    .HasName("stav");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArticleNumber)
                    .IsRequired()
                    .HasColumnName("articleNumber")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasColumnName("customer")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DelayServisDate)
                    .HasColumnName("delay_servis_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DelayServisTime)
                    .HasColumnName("delay_servis_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DodavatelId)
                    .HasColumnName("dodavatel_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Hmotnost)
                    .HasColumnName("hmotnost")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.LastFinish)
                    .HasColumnName("last_finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MaterialCyklus)
                    .HasColumnName("material_cyklus")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialCyklusUnit)
                    .HasColumnName("material_cyklus_unit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MnozstviCyklus)
                    .HasColumnName("mnozstvi_cyklus")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MnozstviInit)
                    .HasColumnName("mnozstvi_init")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nakup)
                    .HasColumnName("nakup")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Objednano)
                    .HasColumnName("objednano")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Odpracovano)
                    .HasColumnName("odpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pocatecnistav)
                    .HasColumnName("pocatecnistav")
                    .HasColumnType("int(5)");

                entity.Property(e => e.PocetCyklu)
                    .HasColumnName("pocet_cyklu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PocetCykluUpozorneni)
                    .HasColumnName("pocet_cyklu_upozorneni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasColumnName("rating")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Servis)
                    .HasColumnName("servis")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Skupina)
                    .IsRequired()
                    .HasColumnName("skupina")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(5)");

                entity.Property(e => e.TerminZaruky)
                    .HasColumnName("termin_zaruky")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Userindex)
                    .IsRequired()
                    .HasColumnName("userindex")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VyrobniC)
                    .IsRequired()
                    .HasColumnName("vyrobni_c")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZbytkyCyklus)
                    .HasColumnName("zbytky_cyklus")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.ZbytkyCyklusUnit)
                    .HasColumnName("zbytky_cyklus_unit")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladFormyPohyb>(entity =>
            {
                entity.ToTable("sklad_formy_pohyb");

                entity.HasComment("Typy pohyby naradi z a do skladu");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.TypPohybu)
                    .HasName("typ_pohybu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TypPohybu)
                    .HasColumnName("typ_pohybu")
                    .HasColumnType("int(5)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladFormyReaddata>(entity =>
            {
                entity.ToTable("sklad_formy_readdata");

                entity.HasComment("Nactena data skladu forem");

                entity.HasIndex(e => e.Calculated)
                    .HasName("calculated");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.FormaId)
                    .HasName("forma_id");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Calculated)
                    .HasColumnName("calculated")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.FormaId)
                    .HasColumnName("forma_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsActual)
                    .HasColumnName("isActual")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PohybId)
                    .HasColumnName("pohyb_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PolozkaObjednavkyId)
                    .HasColumnName("polozka_objednavky_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.StavSkladu)
                    .HasColumnName("stav_skladu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladInventura>(entity =>
            {
                entity.ToTable("sklad_inventura");

                entity.HasComment("Tabulka skladových inventur");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DatumEvidenciStav)
                    .HasColumnName("datum_evidenci_stav")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.DatumInventura)
                    .HasColumnName("datum_inventura")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.DatumUzavreni)
                    .HasColumnName("datum_uzavreni")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.IdPrijemka)
                    .HasColumnName("id_prijemka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypInventura)
                    .HasColumnName("id_typ_inventura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypPrijemka)
                    .HasColumnName("id_typ_prijemka")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdTypVydejka)
                    .HasColumnName("id_typ_vydejka")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.IdVydejka)
                    .HasColumnName("id_vydejka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InventuraDoklad)
                    .IsRequired()
                    .HasColumnName("inventura_doklad")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.InventuraNazev)
                    .IsRequired()
                    .HasColumnName("inventura_nazev")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poznamka)
                    .IsRequired()
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SkladFilterList)
                    .IsRequired()
                    .HasColumnName("sklad_filter_list")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SkupinaFilterList)
                    .IsRequired()
                    .HasColumnName("skupina_filter_list")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypSkladFilter)
                    .HasColumnName("typ_sklad_filter")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladInventuraPolozky>(entity =>
            {
                entity.ToTable("sklad_inventura_polozky");

                entity.HasComment("Tabulka úkolové mzdy");

                entity.HasIndex(e => e.IdInventura)
                    .HasName("id_inventura");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdInventura)
                    .HasColumnName("id_inventura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<SkladInventuraSoupisy>(entity =>
            {
                entity.ToTable("sklad_inventura_soupisy");

                entity.HasComment("Tabulka úkolové mzdy");

                entity.HasIndex(e => e.IdInventura)
                    .HasName("id_inventura");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CenaMj)
                    .HasColumnName("cenaMJ")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.IdInventura)
                    .HasColumnName("id_inventura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<SkladMaterial>(entity =>
            {
                entity.ToTable("sklad_material");

                entity.HasComment("Sklad materiálu");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Count)
                    .HasName("count");

                entity.HasIndex(e => e.DodavatelId)
                    .HasName("dodavatel_id");

                entity.HasIndex(e => e.IdMoneyAgenda)
                    .HasName("id_moneyAgenda");

                entity.HasIndex(e => e.IdPohoda)
                    .HasName("id_pohoda");

                entity.HasIndex(e => e.MaterialFromId)
                    .HasName("material_from_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Price)
                    .HasName("price");

                entity.HasIndex(e => e.SkladId)
                    .HasName("sklad_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.TvarId)
                    .HasName("tvar_id");

                entity.HasIndex(e => e.TypMat)
                    .HasName("typ_mat");

                entity.HasIndex(e => e.ZbytkyMaterialId)
                    .HasName("zbytky_material_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AvgPrice)
                    .HasColumnName("avg_price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Blokovano)
                    .HasColumnName("blokovano")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CoefUnit1)
                    .HasColumnName("coef_unit1")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit10)
                    .HasColumnName("coef_unit10")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit11)
                    .HasColumnName("coef_unit11")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit12)
                    .HasColumnName("coef_unit12")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit13)
                    .HasColumnName("coef_unit13")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit14)
                    .HasColumnName("coef_unit14")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit15)
                    .HasColumnName("coef_unit15")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit16)
                    .HasColumnName("coef_unit16")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit17)
                    .HasColumnName("coef_unit17")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit18)
                    .HasColumnName("coef_unit18")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit19)
                    .HasColumnName("coef_unit19")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit2)
                    .HasColumnName("coef_unit2")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit20)
                    .HasColumnName("coef_unit20")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit21)
                    .HasColumnName("coef_unit21")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit22)
                    .HasColumnName("coef_unit22")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit3)
                    .HasColumnName("coef_unit3")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit4)
                    .HasColumnName("coef_unit4")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit5)
                    .HasColumnName("coef_unit5")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit6)
                    .HasColumnName("coef_unit6")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit7)
                    .HasColumnName("coef_unit7")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit8)
                    .HasColumnName("coef_unit8")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUnit9)
                    .HasColumnName("coef_unit9")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUser1)
                    .HasColumnName("coef_user1")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUser1Name)
                    .IsRequired()
                    .HasColumnName("coef_user1_name")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CoefUser2)
                    .HasColumnName("coef_user2")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.CoefUser2Name)
                    .IsRequired()
                    .HasColumnName("coef_user2_name")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountInit)
                    .HasColumnName("count_init")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad10)
                    .HasColumnName("count_sklad10")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad11)
                    .HasColumnName("count_sklad11")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad12)
                    .HasColumnName("count_sklad12")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad13)
                    .HasColumnName("count_sklad13")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad14)
                    .HasColumnName("count_sklad14")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad15)
                    .HasColumnName("count_sklad15")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad16)
                    .HasColumnName("count_sklad16")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad17)
                    .HasColumnName("count_sklad17")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad18)
                    .HasColumnName("count_sklad18")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad19)
                    .HasColumnName("count_sklad19")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad2)
                    .HasColumnName("count_sklad2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad20)
                    .HasColumnName("count_sklad20")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad3)
                    .HasColumnName("count_sklad3")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad4)
                    .HasColumnName("count_sklad4")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad5)
                    .HasColumnName("count_sklad5")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad6)
                    .HasColumnName("count_sklad6")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad7)
                    .HasColumnName("count_sklad7")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad8)
                    .HasColumnName("count_sklad8")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CountSklad9)
                    .HasColumnName("count_sklad9")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Delka)
                    .HasColumnName("delka")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.DilNa)
                    .HasColumnName("dil_na")
                    .HasColumnType("varchar(300)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DodavatelId)
                    .HasColumnName("dodavatel_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("ean")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Hmotnost)
                    .HasColumnName("hmotnost")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.HodnotaVazenaCena)
                    .HasColumnName("hodnota_vazena_cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.IdMoneyAgenda)
                    .HasColumnName("id_moneyAgenda")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPohoda)
                    .IsRequired()
                    .HasColumnName("id_pohoda")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Koeficient)
                    .HasColumnName("koeficient")
                    .HasColumnType("decimal(15,2)")
                    .HasDefaultValueSql("'1.00'");

                entity.Property(e => e.LimitCount)
                    .HasColumnName("limit_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Marze)
                    .HasColumnName("marze")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialFromId)
                    .HasColumnName("material_from_id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(1024)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Objednano)
                    .HasColumnName("objednano")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Planovano)
                    .HasColumnName("planovano")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Rozmer1)
                    .HasColumnName("rozmer1")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Rozmer2)
                    .HasColumnName("rozmer2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Rozmer3)
                    .HasColumnName("rozmer3")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.SablonaId)
                    .IsRequired()
                    .HasColumnName("sablona_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SecondUnit)
                    .HasColumnName("second_unit")
                    .HasColumnType("int(5)");

                entity.Property(e => e.SellPrice)
                    .HasColumnName("sell_price")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.SkladId)
                    .HasColumnName("sklad_id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.Skryta)
                    .HasColumnName("skryta")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Text1)
                    .IsRequired()
                    .HasColumnName("text1")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Text2)
                    .IsRequired()
                    .HasColumnName("text2")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tvar)
                    .HasColumnName("tvar")
                    .HasColumnType("char(4)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TvarId)
                    .HasColumnName("tvar_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.TypMat)
                    .HasColumnName("typ_mat")
                    .HasColumnType("int(16)");

                entity.Property(e => e.Umisteni1)
                    .IsRequired()
                    .HasColumnName("umisteni1")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Unirec)
                    .HasColumnName("unirec")
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("int(5)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VazenaCena)
                    .HasColumnName("vazena_cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Vykres)
                    .IsRequired()
                    .HasColumnName("vykres")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZbytkyKoeficient)
                    .HasColumnName("zbytky_koeficient")
                    .HasColumnType("decimal(15,4)");

                entity.Property(e => e.ZbytkyMaterialId)
                    .HasColumnName("zbytky_material_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladMaterialDoc>(entity =>
            {
                entity.ToTable("sklad_material_doc");

                entity.HasComment("Tabulka dokumentù skladových karet");

                entity.HasIndex(e => e.DefaultDocument)
                    .HasName("defaultDocument");

                entity.HasIndex(e => e.ExternalListIdRecord)
                    .HasName("external_list_id_record");

                entity.HasIndex(e => e.ExternalListType)
                    .HasName("external_list_type");

                entity.HasIndex(e => e.IsFile)
                    .HasName("isFile");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.Path)
                    .HasName("path");

                entity.HasIndex(e => e.ZobrazitNahled)
                    .HasName("zobrazitNahled");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefaultDocument)
                    .HasColumnName("defaultDocument")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ExternalListIdRecord)
                    .HasColumnName("external_list_id_record")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExternalListType)
                    .IsRequired()
                    .HasColumnName("external_list_type")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IsFile)
                    .HasColumnName("isFile")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZobrazitNahled)
                    .HasColumnName("zobrazitNahled")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<SkladMaterialDodavatele>(entity =>
            {
                entity.ToTable("sklad_material_dodavatele");

                entity.HasComment("sklad_material_dodavatele");

                entity.HasIndex(e => e.DodavatelId)
                    .HasName("dodavatel_id");

                entity.HasIndex(e => e.KodObjednaci)
                    .HasName("kod_objednaci");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Cena1)
                    .HasColumnName("cena1")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Cena2)
                    .HasColumnName("cena2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.DodavatelId)
                    .HasColumnName("dodavatel_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KodObjednaci)
                    .IsRequired()
                    .HasColumnName("kod_objednaci")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LimitMnozstvi1)
                    .HasColumnName("limit_mnozstvi1")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.LimitMnozstvi2)
                    .HasColumnName("limit_mnozstvi2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Poznamka)
                    .IsRequired()
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TextObjednaci)
                    .IsRequired()
                    .HasColumnName("text_objednaci")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladMaterialPohyb>(entity =>
            {
                entity.ToTable("sklad_material_pohyb");

                entity.HasComment("Typy pohybu materialu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aktivni)
                    .HasColumnName("aktivni")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DoSkladuId)
                    .HasColumnName("do_skladu_id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZeSkladuId)
                    .HasColumnName("ze_skladu_id")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<SkladMaterialPozice>(entity =>
            {
                entity.ToTable("sklad_material_pozice");

                entity.HasComment("Skladové pozice");

                entity.HasIndex(e => e.DatumPrijem)
                    .HasName("datum_prijem");

                entity.HasIndex(e => e.DatumVydej)
                    .HasName("datum_vydej");

                entity.HasIndex(e => e.Full)
                    .HasName("full");

                entity.HasIndex(e => e.Note)
                    .HasName("note");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.HasIndex(e => e.PoziceBarId)
                    .HasName("pozice_bar_id");

                entity.HasIndex(e => e.PoziceN1)
                    .HasName("pozice_n1");

                entity.HasIndex(e => e.PoziceN2)
                    .HasName("pozice_n2");

                entity.HasIndex(e => e.PoziceN3)
                    .HasName("pozice_n3");

                entity.HasIndex(e => e.PoziceN4)
                    .HasName("pozice_n4");

                entity.HasIndex(e => e.SkladId)
                    .HasName("sklad_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.DatumPrijem)
                    .HasColumnName("datum_prijem")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DatumVydej)
                    .HasColumnName("datum_vydej")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Full)
                    .HasColumnName("full")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PoziceBarId)
                    .IsRequired()
                    .HasColumnName("pozice_bar_id")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'----'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PoziceN1)
                    .HasColumnName("pozice_n1")
                    .HasColumnType("int(8)");

                entity.Property(e => e.PoziceN2)
                    .HasColumnName("pozice_n2")
                    .HasColumnType("int(8)");

                entity.Property(e => e.PoziceN3)
                    .HasColumnName("pozice_n3")
                    .HasColumnType("int(8)");

                entity.Property(e => e.PoziceN4)
                    .HasColumnName("pozice_n4")
                    .HasColumnType("int(8)");

                entity.Property(e => e.SkladId)
                    .HasColumnName("sklad_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladMaterialPoziceReaddata>(entity =>
            {
                entity.ToTable("sklad_material_pozice_readdata");

                entity.HasComment("Skladové pozice naètená data");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.Mnozstvi)
                    .HasName("mnozstvi");

                entity.HasIndex(e => e.Pohyb)
                    .HasName("pohyb");

                entity.HasIndex(e => e.PohybDatetime)
                    .HasName("pohyb_datetime");

                entity.HasIndex(e => e.PohybDatetimeOut)
                    .HasName("pohyb_datetime_out");

                entity.HasIndex(e => e.PohybGroupId)
                    .HasName("pohyb_group_id");

                entity.HasIndex(e => e.PohybTyp)
                    .HasName("pohyb_typ");

                entity.HasIndex(e => e.PoziceId)
                    .HasName("pozice_id");

                entity.HasIndex(e => e.PoziceIdSub)
                    .HasName("pozice_id_sub");

                entity.HasIndex(e => e.SkladReaddataId)
                    .HasName("sklad_readdata_id");

                entity.HasIndex(e => e.Vaha)
                    .HasName("vaha");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(20)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PaletaId)
                    .HasColumnName("paleta_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pohyb)
                    .HasColumnName("pohyb")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.PohybDatetime)
                    .HasColumnName("pohyb_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PohybDatetimeOut)
                    .HasColumnName("pohyb_datetime_out")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PohybGroupId)
                    .HasColumnName("pohyb_group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PohybTyp)
                    .HasColumnName("pohyb_typ")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PoziceId)
                    .HasColumnName("pozice_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.PoziceIdSub)
                    .HasColumnName("pozice_id_sub")
                    .HasColumnType("int(20)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sarze)
                    .IsRequired()
                    .HasColumnName("sarze")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SkladReaddataId)
                    .HasColumnName("sklad_readdata_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserIdIn)
                    .HasColumnName("user_id_in")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserIdOut)
                    .HasColumnName("user_id_out")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vaha)
                    .HasColumnName("vaha")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<SkladMaterialPrijemky>(entity =>
            {
                entity.ToTable("sklad_material_prijemky");

                entity.HasComment("SKLAD_MATERIAL_PRIJEMKY zakazek");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.DodaciListPrijaty)
                    .HasName("dodaciListPrijaty");

                entity.HasIndex(e => e.Doklad)
                    .HasName("doklad");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.FakturaPrijata)
                    .HasName("fakturaPrijata");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.StavDokladu)
                    .HasName("StavDokladu");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaCelkem)
                    .HasColumnName("cena_celkem")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CustomerIco)
                    .IsRequired()
                    .HasColumnName("customer_ico")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DodaciListPrijaty)
                    .IsRequired()
                    .HasColumnName("dodaciListPrijaty")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Doklad)
                    .IsRequired()
                    .HasColumnName("doklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExportPoradi)
                    .HasColumnName("export_poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakturaPrijata)
                    .IsRequired()
                    .HasColumnName("fakturaPrijata")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakturaPrijataDatum)
                    .HasColumnName("fakturaPrijataDatum")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'-1'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oznaceni)
                    .IsRequired()
                    .HasColumnName("oznaceni")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Path2)
                    .IsRequired()
                    .HasColumnName("path2")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PohybId)
                    .HasColumnName("pohyb_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.PrijatyDoklad)
                    .IsRequired()
                    .HasColumnName("prijaty_doklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.RozpusteneNaklady)
                    .HasColumnName("rozpustene_naklady")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.StavDokladu)
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(2)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladMaterialPrijemkyTypy>(entity =>
            {
                entity.ToTable("sklad_material_prijemky_typy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSkladPohyb)
                    .HasColumnName("id_sklad_pohyb")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZkratkaExport)
                    .IsRequired()
                    .HasColumnName("zkratka_export")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladMaterialReaddata>(entity =>
            {
                entity.ToTable("sklad_material_readdata");

                entity.HasComment("Naètená data ze skladu materiálu");

                entity.HasIndex(e => e.Calculated)
                    .HasName("calculated");

                entity.HasIndex(e => e.Cislo)
                    .HasName("cislo");

                entity.HasIndex(e => e.Count)
                    .HasName("count");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.LastNakupCena)
                    .HasName("last_nakup_cena");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.PohybId)
                    .HasName("pohyb_id");

                entity.HasIndex(e => e.PolozkaObjednavkyId)
                    .HasName("polozka_objednavky_id");

                entity.HasIndex(e => e.PrijemId)
                    .HasName("prijem_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.VazenaCena)
                    .HasName("vazena_cena");

                entity.HasIndex(e => e.VydejId)
                    .HasName("vydej_id");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.HasIndex(e => e.ZdrojOrderId)
                    .HasName("zdroj_order_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Added)
                    .HasColumnName("added")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Calculated)
                    .HasColumnName("calculated")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.Cislo)
                    .HasColumnName("cislo")
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Count2)
                    .HasColumnName("count2")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DelkaPrirezu)
                    .HasColumnName("delka_prirezu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Exported)
                    .HasColumnName("exported")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ExportvydejkaId)
                    .HasColumnName("exportvydejka_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.ExtDl)
                    .HasColumnName("ExtDL")
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExtObj)
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LastNakupCena)
                    .HasColumnName("last_nakup_cena")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PohybId)
                    .HasColumnName("pohyb_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PohybVazenaCena)
                    .HasColumnName("pohyb_vazena_cena")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.PolozkaDodlistId)
                    .HasColumnName("polozka_dodlist_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PolozkaObjednavkyId)
                    .HasColumnName("polozka_objednavky_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrevodNasklad)
                    .HasColumnName("prevod_nasklad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrijemId)
                    .HasColumnName("prijem_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Prorez)
                    .HasColumnName("prorez")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.RozpusteneNaklady)
                    .HasColumnName("rozpustene_naklady")
                    .HasColumnType("decimal(15,5)");

                entity.Property(e => e.Sarze)
                    .IsRequired()
                    .HasColumnName("sarze")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavSkladu)
                    .HasColumnName("stav_skladu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Ulozeno)
                    .HasColumnName("ulozeno")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Unirec)
                    .HasColumnName("unirec")
                    .HasColumnType("varchar(256)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VazenaCena)
                    .HasColumnName("vazena_cena")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.VydejId)
                    .HasColumnName("vydej_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZbytkovyMaterial)
                    .HasColumnName("zbytkovy_material")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.ZdrojOrderId)
                    .IsRequired()
                    .HasColumnName("zdroj_order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladMaterialTvar>(entity =>
            {
                entity.ToTable("sklad_material_tvar");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladMaterialVydejky>(entity =>
            {
                entity.ToTable("sklad_material_vydejky");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.DodaciListVydany)
                    .HasName("dodaciListVydany");

                entity.HasIndex(e => e.Doklad)
                    .HasName("doklad");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.FakturaVydana)
                    .HasName("fakturaVydana");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CenaCelkem)
                    .HasColumnName("cena_celkem")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CustomerIco)
                    .IsRequired()
                    .HasColumnName("customer_ico")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DodaciListVydany)
                    .IsRequired()
                    .HasColumnName("dodaciListVydany")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Doklad)
                    .IsRequired()
                    .HasColumnName("doklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExportPoradi)
                    .HasColumnName("export_poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakturaVydana)
                    .IsRequired()
                    .HasColumnName("fakturaVydana")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FakturaVydanaDatum)
                    .HasColumnName("fakturaVydanaDatum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'-1'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oznaceni)
                    .IsRequired()
                    .HasColumnName("oznaceni")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Path2)
                    .IsRequired()
                    .HasColumnName("path2")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PohybId)
                    .HasColumnName("pohyb_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.PrijatyDoklad)
                    .IsRequired()
                    .HasColumnName("prijaty_doklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavDokladu)
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(2)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladMaterialVydejkyTypy>(entity =>
            {
                entity.ToTable("sklad_material_vydejky_typy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DokladAutocreate)
                    .HasColumnName("doklad_autocreate")
                    .HasColumnType("int(2)");

                entity.Property(e => e.IdSkladPohyb)
                    .HasColumnName("id_sklad_pohyb")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZkratkaExport)
                    .IsRequired()
                    .HasColumnName("zkratka_export")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladNaradi>(entity =>
            {
                entity.ToTable("sklad_naradi");

                entity.HasComment("Sklad drobného náøadí");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.DodavatelId)
                    .HasName("dodavatel_id");

                entity.HasIndex(e => e.Nakup)
                    .HasName("nakup");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Servis)
                    .HasName("servis");

                entity.HasIndex(e => e.Stav)
                    .HasName("stav");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.DelayServisDate)
                    .HasColumnName("delay_servis_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DelayServisTime)
                    .HasColumnName("delay_servis_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DodavatelId)
                    .HasColumnName("dodavatel_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(4)");

                entity.Property(e => e.LastFinish)
                    .HasColumnName("last_finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MnozstviInit)
                    .HasColumnName("mnozstvi_init")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MnozstviLimit)
                    .HasColumnName("mnozstvi_limit")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Nakup)
                    .HasColumnName("nakup")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Objednano)
                    .HasColumnName("objednano")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Odpracovano)
                    .HasColumnName("odpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pocatecnistav)
                    .HasColumnName("pocatecnistav")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Servis)
                    .HasColumnName("servis")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Skupina)
                    .IsRequired()
                    .HasColumnName("skupina")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(5)");

                entity.Property(e => e.StavKarty)
                    .HasColumnName("stavKarty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerminZaruky)
                    .HasColumnName("termin_zaruky")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.TypNaradi)
                    .HasColumnName("typ_naradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UkonceniInterval)
                    .HasColumnName("ukonceni_interval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VyrobniC)
                    .IsRequired()
                    .HasColumnName("vyrobni_c")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZarukaDelka)
                    .HasColumnName("zarukaDelka")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladNaradiPohyb>(entity =>
            {
                entity.ToTable("sklad_naradi_pohyb");

                entity.HasComment("Typy pohyby naradi z a do skladu");

                entity.HasIndex(e => e.AutoWrite)
                    .HasName("AutoWrite");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.NaradiType)
                    .HasName("naradiType");

                entity.HasIndex(e => e.StavChange)
                    .HasName("stavChange");

                entity.HasIndex(e => e.StavId)
                    .HasName("stavId");

                entity.HasIndex(e => e.TypPohybu)
                    .HasName("typ_pohybu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoWrite)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NaradiType)
                    .HasColumnName("naradiType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.StavChange)
                    .HasColumnName("stavChange")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StavId)
                    .HasColumnName("stavId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TypPohybu)
                    .HasColumnName("typ_pohybu")
                    .HasColumnType("int(5)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladNaradiReaddata>(entity =>
            {
                entity.ToTable("sklad_naradi_readdata");

                entity.HasComment("Nactena data skladu drobneho naradi");

                entity.HasIndex(e => e.Calculated)
                    .HasName("calculated");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.NaradiId)
                    .HasName("naradi_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Calculated)
                    .HasColumnName("calculated")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.IsActual)
                    .HasColumnName("isActual")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NaradiId)
                    .HasColumnName("naradi_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PohybId)
                    .HasColumnName("pohyb_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PolozkaObjednavkyId)
                    .HasColumnName("polozka_objednavky_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.StavSkladu)
                    .HasColumnName("stav_skladu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkladNaradiStav>(entity =>
            {
                entity.ToTable("sklad_naradi_stav");

                entity.HasComment("Tabulka stavù karet náøadí");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.GroupId)
                    .HasName("groupId");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Note)
                    .HasName("note");

                entity.HasIndex(e => e.Poradi)
                    .HasName("poradi");

                entity.HasIndex(e => e.Tabulka)
                    .HasName("tabulka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ChangeItemCount)
                    .HasColumnName("changeItemCount")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tabulka)
                    .IsRequired()
                    .HasColumnName("tabulka")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SkladSkupiny>(entity =>
            {
                entity.ToTable("sklad_skupiny");

                entity.HasComment("Stavy zakazek");

                entity.HasIndex(e => e.ExterniId)
                    .HasName("externi_id");

                entity.HasIndex(e => e.IdPohoda)
                    .HasName("id_pohoda");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OperationIdBatchout)
                    .HasName("operation_id_batchout");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExterniId)
                    .IsRequired()
                    .HasColumnName("externi_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IdPohoda)
                    .IsRequired()
                    .HasColumnName("id_pohoda")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperationIdBatchout)
                    .HasColumnName("operation_id_batchout")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SkladyMaterialu>(entity =>
            {
                entity.ToTable("sklady_materialu");

                entity.HasComment("Sklady materialu");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<SpLog>(entity =>
            {
                entity.ToTable("sp_log");

                entity.HasComment("Tabulka logování uložených procedur");

                entity.HasIndex(e => e.Level)
                    .HasName("level");

                entity.HasIndex(e => e.Message)
                    .HasName("message");

                entity.HasIndex(e => e.TimeStamp)
                    .HasName("time_stamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("varchar(20)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("varchar(512)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SpName)
                    .HasColumnName("sp_name")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SpSettings>(entity =>
            {
                entity.ToTable("sp_settings");

                entity.HasComment("Tabulka nastavení uložených procedur");

                entity.HasIndex(e => e.SpName)
                    .HasName("sp_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("int(5)");

                entity.Property(e => e.LockedTimestamp)
                    .HasColumnName("locked_timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LogLevel)
                    .HasColumnName("log_level")
                    .HasColumnType("varchar(20)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SpAlias)
                    .HasColumnName("sp_alias")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SpName)
                    .HasColumnName("sp_name")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<Stavydokladu>(entity =>
            {
                entity.ToTable("stavydokladu");

                entity.HasComment("Tabulka stavù dokladù");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.GroupId)
                    .HasName("groupId");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Note)
                    .HasName("note");

                entity.HasIndex(e => e.Poradi)
                    .HasName("poradi");

                entity.HasIndex(e => e.Tabulka)
                    .HasName("tabulka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 23:59:59'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tabulka)
                    .IsRequired()
                    .HasColumnName("tabulka")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StrojGroup>(entity =>
            {
                entity.ToTable("stroj_group");

                entity.HasComment("Skupiny CNC stroju");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Stroje>(entity =>
            {
                entity.ToTable("stroje");

                entity.HasComment("Databaze stroju");

                entity.HasIndex(e => e.CenaHodina)
                    .HasName("cena_hodina");

                entity.HasIndex(e => e.DatumNakup)
                    .HasName("datum_nakup");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Odpracovano)
                    .HasName("odpracovano");

                entity.HasIndex(e => e.Servis)
                    .HasName("servis");

                entity.HasIndex(e => e.ServisDelay)
                    .HasName("servis_delay");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CenaHodina)
                    .HasColumnName("cena_hodina")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.DatumNakup)
                    .HasColumnName("datum_nakup")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Odpracovano)
                    .HasColumnName("odpracovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Servis)
                    .HasColumnName("servis")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ServisDelay)
                    .HasColumnName("servis_delay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerminZaruky)
                    .HasColumnName("termin_zaruky")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Subdodavky>(entity =>
            {
                entity.ToTable("subdodavky");

                entity.HasComment("Subdodavky zakazek");

                entity.HasIndex(e => e.Cislo)
                    .HasName("cislo");

                entity.HasIndex(e => e.DatumDodani)
                    .HasName("datum_dodani");

                entity.HasIndex(e => e.DodavatelId)
                    .HasName("dodavatelId");

                entity.HasIndex(e => e.DodavatelName)
                    .HasName("dodavatelName");

                entity.HasIndex(e => e.IdPohoda)
                    .HasName("id_pohoda");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.PredpDatumDodani)
                    .HasName("predp_datum_dodani");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CenaCelkem)
                    .HasColumnName("cena_celkem")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CenaJednotka)
                    .HasColumnName("cena_jednotka")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Cislo)
                    .HasColumnName("cislo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreateFak)
                    .HasColumnName("Create_fak")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DatumDodani)
                    .HasColumnName("Datum_dodani")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DatumRealizace)
                    .HasColumnName("datum_realizace")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DatumVytvoreni)
                    .HasColumnName("datum_vytvoreni")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DodavatelId)
                    .HasColumnName("dodavatelId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DodavatelName)
                    .IsRequired()
                    .HasColumnName("dodavatelName")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Doklad)
                    .IsRequired()
                    .HasColumnName("doklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DokladMoney)
                    .IsRequired()
                    .HasColumnName("dokladMoney")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IdPohoda)
                    .IsRequired()
                    .HasColumnName("id_pohoda")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Jednotka)
                    .HasColumnName("jednotka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Planovana)
                    .HasColumnName("planovana")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PredpDatumDodani)
                    .HasColumnName("Predp_datum_dodani")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserPrice)
                    .HasColumnName("user_price")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<SwTerm>(entity =>
            {
                entity.ToTable("sw_term");

                entity.HasComment("Tabulka s ip adresama na kterych je spusteny sw terminal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<SwtermRozdel>(entity =>
            {
                entity.ToTable("swterm_rozdel");

                entity.HasComment("SW terminal rozdeleni ukonu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Cas)
                    .HasColumnName("cas")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Procent)
                    .HasColumnName("procent")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UkonMzda)
                    .HasColumnName("ukon_mzda")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<System>(entity =>
            {
                entity.ToTable("system");

                entity.HasComment("Systemova tabulka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.LastBackup)
                    .HasColumnName("last_backup")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LastOptimize)
                    .HasColumnName("last_optimize")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LastRepair)
                    .HasColumnName("last_repair")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LimitSmtTerm)
                    .HasColumnName("limit_smt_term")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LimitSwTerm)
                    .HasColumnName("limit_sw_term")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LimitVmtTerm)
                    .HasColumnName("limit_vmt_term")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProgramId)
                    .IsRequired()
                    .HasColumnName("program_id")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'PRACANT'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TableVersion)
                    .IsRequired()
                    .HasColumnName("table_version")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UpgradeLocktables)
                    .HasColumnName("upgrade_locktables")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<TechPostup>(entity =>
            {
                entity.ToTable("tech_postup");

                entity.HasComment("Tabulka technologickych postupu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CasJednotky)
                    .HasColumnName("cas_jednotky")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<TechPostupPolozky>(entity =>
            {
                entity.ToTable("tech_postup_polozky");

                entity.HasComment("Tabulka polozek technologickych postupu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mnozstvi)
                    .HasColumnName("mnozstvi")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PostupId)
                    .HasColumnName("postup_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.ToTable("temp");

                entity.HasComment("Pomocná tabulka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue)
                    .HasColumnName("int_value")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue10)
                    .HasColumnName("int_value10")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue11)
                    .HasColumnName("int_value11")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue12)
                    .HasColumnName("int_value12")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue13)
                    .HasColumnName("int_value13")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue14)
                    .HasColumnName("int_value14")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue15)
                    .HasColumnName("int_value15")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue16)
                    .HasColumnName("int_value16")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue17)
                    .HasColumnName("int_value17")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue18)
                    .HasColumnName("int_value18")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue2)
                    .HasColumnName("int_value2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue3)
                    .HasColumnName("int_value3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue4)
                    .HasColumnName("int_value4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue5)
                    .HasColumnName("int_value5")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue6)
                    .HasColumnName("int_value6")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue7)
                    .HasColumnName("int_value7")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue8)
                    .HasColumnName("int_value8")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntValue9)
                    .HasColumnName("int_value9")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Temp2>(entity =>
            {
                entity.ToTable("temp2");

                entity.HasComment("Pomocná tabulka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.S1)
                    .IsRequired()
                    .HasColumnName("s1")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S10)
                    .IsRequired()
                    .HasColumnName("s10")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S11)
                    .IsRequired()
                    .HasColumnName("s11")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S12)
                    .IsRequired()
                    .HasColumnName("s12")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S13)
                    .IsRequired()
                    .HasColumnName("s13")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S14)
                    .IsRequired()
                    .HasColumnName("s14")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S15)
                    .IsRequired()
                    .HasColumnName("s15")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S16)
                    .IsRequired()
                    .HasColumnName("s16")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S17)
                    .IsRequired()
                    .HasColumnName("s17")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S18)
                    .IsRequired()
                    .HasColumnName("s18")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S19)
                    .IsRequired()
                    .HasColumnName("s19")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S2)
                    .IsRequired()
                    .HasColumnName("s2")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S20)
                    .IsRequired()
                    .HasColumnName("s20")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S21)
                    .IsRequired()
                    .HasColumnName("s21")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S22)
                    .IsRequired()
                    .HasColumnName("s22")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S23)
                    .IsRequired()
                    .HasColumnName("s23")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S24)
                    .IsRequired()
                    .HasColumnName("s24")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S25)
                    .IsRequired()
                    .HasColumnName("s25")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S26)
                    .IsRequired()
                    .HasColumnName("s26")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S27)
                    .IsRequired()
                    .HasColumnName("s27")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S28)
                    .IsRequired()
                    .HasColumnName("s28")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S29)
                    .IsRequired()
                    .HasColumnName("s29")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S3)
                    .IsRequired()
                    .HasColumnName("s3")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S30)
                    .IsRequired()
                    .HasColumnName("s30")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S31)
                    .IsRequired()
                    .HasColumnName("s31")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S32)
                    .IsRequired()
                    .HasColumnName("s32")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S33)
                    .IsRequired()
                    .HasColumnName("s33")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S34)
                    .IsRequired()
                    .HasColumnName("s34")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S35)
                    .IsRequired()
                    .HasColumnName("s35")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S36)
                    .IsRequired()
                    .HasColumnName("s36")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S37)
                    .IsRequired()
                    .HasColumnName("s37")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S38)
                    .IsRequired()
                    .HasColumnName("s38")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S39)
                    .IsRequired()
                    .HasColumnName("s39")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S4)
                    .IsRequired()
                    .HasColumnName("s4")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S40)
                    .IsRequired()
                    .HasColumnName("s40")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S5)
                    .IsRequired()
                    .HasColumnName("s5")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S6)
                    .IsRequired()
                    .HasColumnName("s6")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S7)
                    .IsRequired()
                    .HasColumnName("s7")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S8)
                    .IsRequired()
                    .HasColumnName("s8")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.S9)
                    .IsRequired()
                    .HasColumnName("s9")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.ToTable("terminal");

                entity.HasIndex(e => e.Apikey)
                    .HasName("APIkey");

                entity.HasIndex(e => e.Hashcode)
                    .HasName("HASHcode");

                entity.HasIndex(e => e.Ip)
                    .HasName("ip_UNIQUE");

                entity.HasIndex(e => e.SerialNumber)
                    .HasName("serialNumber");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apikey)
                    .IsRequired()
                    .HasColumnName("APIkey")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BasicConfiguration)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FullConfiguration).HasColumnType("blob");

                entity.Property(e => e.Hashcode)
                    .IsRequired()
                    .HasColumnName("HASHcode")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(15)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PovolitPrijemky)
                    .HasColumnName("povolit_prijemky")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.PovolitVydejky)
                    .HasColumnName("povolit_vydejky")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TerminalName)
                    .IsRequired()
                    .HasColumnName("terminalName")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TypTerminalu)
                    .HasColumnName("typ_terminalu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VytvaretZakazku)
                    .HasColumnName("vytvaret_zakazku")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TiskFormulare>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Idhlavicka })
                    .HasName("PRIMARY");

                entity.ToTable("tisk_formulare");

                entity.HasComment("Formuláøe tiskových sestav");

                entity.HasIndex(e => e.Stav)
                    .HasName("stav");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idhlavicka)
                    .HasColumnName("idhlavicka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cesta)
                    .IsRequired()
                    .HasColumnName("cesta")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Kmen)
                    .HasColumnName("kmen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Typ)
                    .IsRequired()
                    .HasColumnName("typ")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'N'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<TiskHlavicka>(entity =>
            {
                entity.ToTable("tisk_hlavicka");

                entity.HasComment("Hlavièky tiskových sestav");

                entity.HasIndex(e => e.Stav)
                    .HasName("stav");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nadpis)
                    .IsRequired()
                    .HasColumnName("nadpis")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Slozka)
                    .IsRequired()
                    .HasColumnName("slozka")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<TiskHlavickaNazvy>(entity =>
            {
                entity.HasKey(e => e.Slozka)
                    .HasName("PRIMARY");

                entity.ToTable("tisk_hlavicka_nazvy");

                entity.HasComment("Pøeklad pro lidi názvù adresáøù tiskù");

                entity.Property(e => e.Slozka)
                    .HasColumnName("slozka")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NazevCz)
                    .IsRequired()
                    .HasColumnName("nazev_cz")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NazevEn)
                    .IsRequired()
                    .HasColumnName("nazev_en")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<TiskPrava>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TiskId })
                    .HasName("PRIMARY");

                entity.ToTable("tisk_prava");

                entity.HasComment("Práva tiskových sestav");

                entity.HasIndex(e => e.Stav)
                    .HasName("stav");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TiskId)
                    .HasColumnName("tisk_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Obecne)
                    .IsRequired()
                    .HasColumnName("obecne")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ProfeseId)
                    .HasColumnName("profese_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stav)
                    .HasColumnName("stav")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TypBaleni>(entity =>
            {
                entity.HasKey(e => e.IdTypbaleni)
                    .HasName("PRIMARY");

                entity.ToTable("typ_baleni");

                entity.Property(e => e.IdTypbaleni)
                    .HasColumnName("id_typbaleni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kod)
                    .HasColumnName("kod")
                    .HasColumnType("varchar(3)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TypDopravy)
                    .HasColumnName("typ_dopravy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vychozi)
                    .HasColumnName("vychozi")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TypZasilky>(entity =>
            {
                entity.HasKey(e => e.IdTypdopravy)
                    .HasName("PRIMARY");

                entity.ToTable("typ_zasilky");

                entity.Property(e => e.IdTypdopravy)
                    .HasColumnName("id_typdopravy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdDoprava)
                    .HasColumnName("id_doprava")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vychozi)
                    .HasColumnName("vychozi")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UkolmzdaTyp>(entity =>
            {
                entity.ToTable("ukolmzda_typ");

                entity.HasComment("Tabulka úkolové mzdy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallExternal)
                    .HasColumnName("call_external")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OhP)
                    .HasColumnName("oh_p")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OjP)
                    .HasColumnName("oj_p")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PhP)
                    .HasColumnName("ph_p")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PjP)
                    .HasColumnName("pj_p")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Popis)
                    .IsRequired()
                    .HasColumnName("popis")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poradi)
                    .HasColumnName("poradi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Readonly)
                    .HasColumnName("readonly")
                    .HasColumnType("int(1)");

                entity.Property(e => e.StP)
                    .HasColumnName("st_p")
                    .HasColumnType("int(1)");

                entity.Property(e => e.TypVypoctu)
                    .HasColumnName("typ_vypoctu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Vzorec)
                    .IsRequired()
                    .HasColumnName("vzorec")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.WP)
                    .HasColumnName("w_p")
                    .HasColumnType("int(1)");

                entity.Property(e => e.WkP)
                    .HasColumnName("wk_p")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<Ukoly>(entity =>
            {
                entity.ToTable("ukoly");

                entity.HasIndex(e => e.ResitelId)
                    .HasName("resitel_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OpakovaniId)
                    .HasColumnName("opakovani_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpakovaniInterval)
                    .HasColumnName("opakovani_interval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpakovaniParam1)
                    .IsRequired()
                    .HasColumnName("opakovani_param1")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PodminkaId)
                    .HasColumnName("podminka_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PodminkaParam1)
                    .IsRequired()
                    .HasColumnName("podminka_param1")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PodminkaParam2)
                    .IsRequired()
                    .HasColumnName("podminka_param2")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PodminkaParam3)
                    .IsRequired()
                    .HasColumnName("podminka_param3")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Popis)
                    .HasColumnName("popis")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Reakce)
                    .HasColumnName("reakce")
                    .HasColumnType("varchar(255)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ResitelId)
                    .HasColumnName("resitel_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StavId)
                    .HasColumnName("stav_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Termin)
                    .HasColumnName("termin")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 00:00:00'");

                entity.Property(e => e.ZadavatelId)
                    .HasColumnName("zadavatel_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zmena)
                    .HasColumnName("zmena")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 00:00:00'");
            });

            modelBuilder.Entity<UkolyOpakovani>(entity =>
            {
                entity.ToTable("ukoly_opakovani");

                entity.HasIndex(e => e.Nazev)
                    .HasName("nazev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<UkolyPodminky>(entity =>
            {
                entity.ToTable("ukoly_podminky");

                entity.HasIndex(e => e.Kod)
                    .HasName("kod");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("kod")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<UkolyStavy>(entity =>
            {
                entity.ToTable("ukoly_stavy");

                entity.HasIndex(e => e.Aktivni)
                    .HasName("aktivni");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aktivni)
                    .IsRequired()
                    .HasColumnName("aktivni")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<UserPrintSettings>(entity =>
            {
                entity.ToTable("user_print_settings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrinterName)
                    .HasColumnName("printer_name")
                    .HasColumnType("varchar(70)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsName)
                    .HasColumnName("ts_name")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.ToTable("user_settings");

                entity.HasComment("Tabulka nastaveni");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AktivmiZakazkyHromadneBlokace)
                    .HasColumnName("aktivmi_zakazky_hromadne_blokace")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AutoAktDateOrd)
                    .HasColumnName("auto_akt_date_ord")
                    .HasColumnType("int(2)");

                entity.Property(e => e.AutoAktDateOrdAfter)
                    .HasColumnName("auto_akt_date_ord_after")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoAktDateOrdBefore)
                    .HasColumnName("auto_akt_date_ord_before")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoAktDateSklad)
                    .HasColumnName("auto_akt_date_sklad")
                    .HasColumnType("int(2)");

                entity.Property(e => e.AutoNeukoncenePrichody)
                    .IsRequired()
                    .HasColumnName("auto_neukoncene_prichody")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.AutoSelectGroup)
                    .IsRequired()
                    .HasColumnName("auto_select_group")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.AutoSelectGroupSklad)
                    .IsRequired()
                    .HasColumnName("auto_select_group_sklad")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.AutoSelectLastPredpmat)
                    .IsRequired()
                    .HasColumnName("auto_select_last_predpmat")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BarFormat)
                    .IsRequired()
                    .HasColumnName("bar_format")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Barvy)
                    .IsRequired()
                    .HasColumnName("barvy")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BtnCalc)
                    .IsRequired()
                    .HasColumnName("btn_calc")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BtnImport)
                    .IsRequired()
                    .HasColumnName("btn_import")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BtnStavyzak)
                    .IsRequired()
                    .HasColumnName("btn_stavyzak")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CasKlon)
                    .HasColumnName("cas_klon")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ChkMater)
                    .HasColumnName("chk_mater")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ColorPasiveActive)
                    .IsRequired()
                    .HasColumnName("color_pasive_active")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ColorizeGridCell)
                    .HasColumnName("colorize_grid_cell")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CorderAutorefresh)
                    .HasColumnName("corder_autorefresh")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorderAutorefreshInterval)
                    .HasColumnName("corder_autorefresh_interval")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10000'");

                entity.Property(e => e.CorderPredpokladanyCasZdroj)
                    .HasColumnName("corder_predpokladany_cas_zdroj")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CteckaAutocheck)
                    .IsRequired()
                    .HasColumnName("ctecka_autocheck")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaDatabit)
                    .IsRequired()
                    .HasColumnName("ctecka_databit")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaLaser)
                    .IsRequired()
                    .HasColumnName("ctecka_laser")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaPort)
                    .IsRequired()
                    .HasColumnName("ctecka_port")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaPrijemkaAutocheck)
                    .HasColumnName("ctecka_prijemka_autocheck")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CteckaPrijemkaPort)
                    .IsRequired()
                    .HasColumnName("ctecka_prijemka_port")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaRizeniToku)
                    .IsRequired()
                    .HasColumnName("ctecka_rizeni_toku")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaSkladMs5145)
                    .HasColumnName("ctecka_sklad_ms5145")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CteckaStopbit)
                    .IsRequired()
                    .HasColumnName("ctecka_stopbit")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CteckaVydejkaAutocheck)
                    .HasColumnName("ctecka_vydejka_autocheck")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CteckaVydejkaPort)
                    .IsRequired()
                    .HasColumnName("ctecka_vydejka_port")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DashboardShow)
                    .HasColumnName("dashboard_show")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DesOddelovac)
                    .IsRequired()
                    .HasColumnName("des_oddelovac")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExcelExportCesta)
                    .IsRequired()
                    .HasColumnName("excel_export_cesta")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExcelExportOtevrit)
                    .HasColumnName("excel_export_otevrit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExcelExportVarianta)
                    .HasColumnName("excel_export_varianta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FinAktDateOrd)
                    .HasColumnName("fin_akt_date_ord")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.FinAktDateSklad)
                    .HasColumnName("fin_akt_date_sklad")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.FormatHodin)
                    .IsRequired()
                    .HasColumnName("format_hodin")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.GrafPrehledZakBoot1)
                    .HasColumnName("graf_prehled_zak_boot1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrafPrehledZakBoot2)
                    .HasColumnName("graf_prehled_zak_boot2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrafPrehledZakLeft)
                    .HasColumnName("graf_prehled_zak_left")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KontrolaKonecObdobiMin)
                    .HasColumnName("kontrola_konec_obdobi_min")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'15'");

                entity.Property(e => e.LastSelectedKusu)
                    .IsRequired()
                    .HasColumnName("last_selected_kusu")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LastSelectedOrderwork)
                    .IsRequired()
                    .HasColumnName("last_selected_orderwork")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LastSelectedOrderworkGroup)
                    .IsRequired()
                    .HasColumnName("last_selected_orderwork_group")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LastSelectedPredmatGroup)
                    .IsRequired()
                    .HasColumnName("last_selected_predmat_group")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LastSelectedPredmatId)
                    .IsRequired()
                    .HasColumnName("last_selected_predmat_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperacePrekrocenyCasBarva)
                    .HasColumnName("operace_prekroceny_cas_barva")
                    .HasColumnType("int(16)");

                entity.Property(e => e.OperacePrekrocenyCasPrebarvit)
                    .HasColumnName("operace_prekroceny_cas_prebarvit")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OperaceTop5Days)
                    .HasColumnName("operace_top5_days")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'7'");

                entity.Property(e => e.OrdBoldMaster)
                    .HasColumnName("ord_bold_master")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdChkmaterVzdy)
                    .HasColumnName("ord_chkmater_vzdy")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdColorMaster)
                    .HasColumnName("ord_color_master")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.OrdSablonaSett)
                    .IsRequired()
                    .HasColumnName("ord_sablona_sett")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'1111111111'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrdShowBtntoday)
                    .HasColumnName("ord_show_btntoday")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrdTemplName)
                    .HasColumnName("ord_templ_name")
                    .HasColumnType("int(2)");

                entity.Property(e => e.OrderAutoQueryRefreshListBack)
                    .HasColumnName("order_auto_query_refresh_list_back")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderFinishNull)
                    .HasColumnName("order_finish_null")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderRada)
                    .HasColumnName("order_rada")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.OrderSettings)
                    .HasColumnName("order_settings")
                    .HasColumnType("int(1)");

                entity.Property(e => e.OrderStavyrazeni)
                    .IsRequired()
                    .HasColumnName("order_stavyrazeni")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.OrderUserfiltr)
                    .IsRequired()
                    .HasColumnName("order_userfiltr")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'DRAWING'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OwDefPoradi)
                    .HasColumnName("ow_def_poradi")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Popisgrafprehled)
                    .HasColumnName("popisgrafprehled")
                    .HasColumnType("int(10)");

                entity.Property(e => e.PopupDatumy)
                    .IsRequired()
                    .HasColumnName("popup_datumy")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintAll)
                    .IsRequired()
                    .HasColumnName("print_all")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintBarcodeUse)
                    .IsRequired()
                    .HasColumnName("print_barcode_use")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintBrothersUse)
                    .IsRequired()
                    .HasColumnName("print_brothers_use")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintCopyes)
                    .IsRequired()
                    .HasColumnName("print_copyes")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintDefault)
                    .IsRequired()
                    .HasColumnName("print_default")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintDefaultBrothers)
                    .IsRequired()
                    .HasColumnName("print_default_brothers")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintDoc)
                    .HasColumnName("print_doc")
                    .HasColumnType("int(2)");

                entity.Property(e => e.PrintOffsetX)
                    .IsRequired()
                    .HasColumnName("print_offset_x")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintOffsetY)
                    .IsRequired()
                    .HasColumnName("print_offset_y")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintPodpis)
                    .IsRequired()
                    .HasColumnName("print_podpis")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrintSavepozice)
                    .IsRequired()
                    .HasColumnName("print_savepozice")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PrnAdvVykYisk)
                    .HasColumnName("prn_adv_vyk_yisk")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ProskrtavaciZnak)
                    .IsRequired()
                    .HasColumnName("proskrtavaci_znak")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ProskrtavatDochazku)
                    .IsRequired()
                    .HasColumnName("proskrtavat_dochazku")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Rezerva)
                    .IsRequired()
                    .HasColumnName("rezerva")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.RychlaMys)
                    .HasColumnName("rychla_mys")
                    .HasColumnType("int(2)");

                entity.Property(e => e.SberdatOdprac)
                    .IsRequired()
                    .HasColumnName("sberdat_odprac")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SelectGroupOper)
                    .IsRequired()
                    .HasColumnName("select_group_oper")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SelectGroupSklad)
                    .IsRequired()
                    .HasColumnName("select_group_sklad")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ShowDatacolToppan)
                    .IsRequired()
                    .HasColumnName("show_datacol_toppan")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SkladDetail1)
                    .HasColumnName("sklad_detail_1")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SkladDetail2)
                    .HasColumnName("sklad_detail_2")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SkladDetail3)
                    .HasColumnName("sklad_detail_3")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SkladHeightDet1)
                    .HasColumnName("sklad_height_det_1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.SkladHeightDet2)
                    .HasColumnName("sklad_height_det_2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.SkladHeightDet3)
                    .HasColumnName("sklad_height_det_3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.SkladPravyPanel)
                    .HasColumnName("sklad_pravy_panel")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SkladPravyPanelWidth)
                    .HasColumnName("sklad_pravy_panel_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'390'");

                entity.Property(e => e.SkladPrehledWidth)
                    .HasColumnName("sklad_prehled_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'340'");

                entity.Property(e => e.StartAktDateOrd)
                    .HasColumnName("start_akt_date_ord")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.StartAktDateSklad)
                    .HasColumnName("start_akt_date_sklad")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Styly)
                    .IsRequired()
                    .HasColumnName("styly")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UseAktDateOrd)
                    .HasColumnName("use_akt_date_ord")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UseAktDateSklad)
                    .HasColumnName("use_akt_date_sklad")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UseChkOwTime)
                    .HasColumnName("use_chk_ow_time")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UseClipboard)
                    .HasColumnName("use_clipboard")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UseDefOrderstav)
                    .HasColumnName("use_def_orderstav")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UseDefOrdertyp)
                    .HasColumnName("use_def_ordertyp")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("userEmail")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.UserLanguage)
                    .IsRequired()
                    .HasColumnName("user_language")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'NTV'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserNosOrder)
                    .HasColumnName("userNOS_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserPhone)
                    .IsRequired()
                    .HasColumnName("userPhone")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserRealName)
                    .IsRequired()
                    .HasColumnName("userRealName")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.VariantaAutoposun)
                    .HasColumnName("varianta_autoposun")
                    .HasColumnType("int(2)");

                entity.Property(e => e.VyberTisku)
                    .IsRequired()
                    .HasColumnName("vyber_tisku")
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZakDetail1)
                    .HasColumnName("zak_detail_1")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakDetail2)
                    .HasColumnName("zak_detail_2")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakDetail3)
                    .HasColumnName("zak_detail_3")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakDetail4)
                    .HasColumnName("zak_detail_4")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakDetail5)
                    .HasColumnName("zak_detail_5")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakDetail6)
                    .HasColumnName("zak_detail_6")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakHeightDet1)
                    .HasColumnName("zak_height_det_1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.ZakHeightDet2)
                    .HasColumnName("zak_height_det_2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.ZakHeightDet3)
                    .HasColumnName("zak_height_det_3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.ZakHeightDet4)
                    .HasColumnName("zak_height_det_4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.ZakHeightDet5)
                    .HasColumnName("zak_height_det_5")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.ZakHeightDet6)
                    .HasColumnName("zak_height_det_6")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'26'");

                entity.Property(e => e.ZakMaterialPredPrehledPravyPanel)
                    .HasColumnName("zak_material_pred_prehled_pravy_panel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakMaterialPrehledPravyPanel)
                    .HasColumnName("zak_material_prehled_pravy_panel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ZakMaterialPrehledWidth)
                    .HasColumnName("zak_material_prehled_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'340'");

                entity.Property(e => e.ZakPredMaterialPrehledWidth)
                    .HasColumnName("zak_pred_material_prehled_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'340'");

                entity.Property(e => e.ZakazkaTimeout)
                    .IsRequired()
                    .HasColumnName("zakazka_timeout")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ZmenaNaStav)
                    .IsRequired()
                    .HasColumnName("zmena_na_stav")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'Vyrobená'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Userlist>(entity =>
            {
                entity.HasKey(e => e.ComputerId)
                    .HasName("PRIMARY");

                entity.ToTable("userlist");

                entity.HasComment("Pøihlášení uživatelé");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.Property(e => e.ComputerId)
                    .HasColumnName("computerId")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasColumnName("computerName")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("lastActivity")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LoginTime)
                    .HasColumnName("loginTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasComment("Uzivatele s pravem prihlaseni k aplikaci");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Acess)
                    .HasColumnName("acess")
                    .HasColumnType("int(2)");

                entity.Property(e => e.GdprGroup)
                    .HasColumnName("gdpr_group")
                    .HasColumnType("int(5)");

                entity.Property(e => e.LoginCounter)
                    .HasColumnName("login_counter")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Mistr)
                    .IsRequired()
                    .HasColumnName("mistr")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Password2)
                    .IsRequired()
                    .HasColumnName("password2")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Password2change)
                    .HasColumnName("password2change")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1899-12-30 00:00:00'");

                entity.Property(e => e.PristupSmReaddata)
                    .HasColumnName("pristup_sm_readdata")
                    .HasColumnType("int(5)");

                entity.Property(e => e.PristupZakazky)
                    .HasColumnName("pristup_zakazky")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Prv01)
                    .HasColumnName("prv_01")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv02)
                    .HasColumnName("prv_02")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv03)
                    .HasColumnName("prv_03")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv04)
                    .HasColumnName("prv_04")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv05)
                    .HasColumnName("prv_05")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv06)
                    .HasColumnName("prv_06")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv07)
                    .HasColumnName("prv_07")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv08)
                    .HasColumnName("prv_08")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv09)
                    .HasColumnName("prv_09")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv10)
                    .HasColumnName("prv_10")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv11)
                    .HasColumnName("prv_11")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv12)
                    .HasColumnName("prv_12")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv13)
                    .HasColumnName("prv_13")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv14)
                    .HasColumnName("prv_14")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv15)
                    .HasColumnName("prv_15")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Prv16)
                    .HasColumnName("prv_16")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set01)
                    .HasColumnName("set_01")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set02)
                    .HasColumnName("set_02")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set03)
                    .HasColumnName("set_03")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set04)
                    .HasColumnName("set_04")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set05)
                    .HasColumnName("set_05")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set06)
                    .HasColumnName("set_06")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set07)
                    .HasColumnName("set_07")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set08)
                    .HasColumnName("set_08")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set09)
                    .HasColumnName("set_09")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set10)
                    .HasColumnName("set_10")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set11)
                    .HasColumnName("set_11")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set12)
                    .HasColumnName("set_12")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set13)
                    .HasColumnName("set_13")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set14)
                    .HasColumnName("set_14")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set15)
                    .HasColumnName("set_15")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Set16)
                    .HasColumnName("set_16")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("'1152921504606846975'");

                entity.Property(e => e.Stavy)
                    .IsRequired()
                    .HasColumnName("stavy")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UseWorkerId)
                    .HasColumnName("use_worker_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VedouciSkupiny)
                    .IsRequired()
                    .HasColumnName("vedouci_skupiny")
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<UzamceneObdobi>(entity =>
            {
                entity.ToTable("uzamcene_obdobi");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DatumKonecObdobi)
                    .HasColumnName("datumKonecObdobi")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DatumUzamceni)
                    .HasColumnName("datumUzamceni")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<UzavreniZakazek>(entity =>
            {
                entity.ToTable("uzavreni_zakazek");

                entity.HasComment("Uzavreni zakazek");

                entity.HasIndex(e => e.OrderIdFrom)
                    .HasName("order_id_from");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KeDni)
                    .HasColumnName("ke_dni")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Kusu)
                    .HasColumnName("kusu")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderIdFrom)
                    .IsRequired()
                    .HasColumnName("order_id_from")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OrderIdTo)
                    .IsRequired()
                    .HasColumnName("order_id_to")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Prevedeno)
                    .HasColumnName("prevedeno")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<VyrobniCalc>(entity =>
            {
                entity.ToTable("vyrobni_calc");

                entity.HasComment("Vyrobni kalkulacka");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<VyrobniCalcMaterial>(entity =>
            {
                entity.ToTable("vyrobni_calc_material");

                entity.HasComment("Vyrobni kalkulacka materialy");

                entity.HasIndex(e => e.CalcId)
                    .HasName("calc_id");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("material_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CalcId)
                    .HasColumnName("calc_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mnoz)
                    .HasColumnName("mnoz")
                    .HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("worker");

                entity.HasComment("Zamìstnanci");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.BarId)
                    .HasName("bar_id");

                entity.HasIndex(e => e.Finish)
                    .HasName("finish");

                entity.HasIndex(e => e.GdprZbyva)
                    .HasName("gdpr_zbyva");

                entity.HasIndex(e => e.GroupName)
                    .HasName("group_name");

                entity.HasIndex(e => e.IdMistoPrace)
                    .HasName("id_misto_prace");

                entity.HasIndex(e => e.IdNadrizeny)
                    .HasName("id_nadrizeny");

                entity.HasIndex(e => e.IdPracovniSkupina)
                    .HasName("id_pracovni_skupina");

                entity.HasIndex(e => e.IdProfese)
                    .HasName("id_profese");

                entity.HasIndex(e => e.IdRidiciStruktura)
                    .HasName("id_ridici_struktura");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Pozice)
                    .HasName("pozice");

                entity.HasIndex(e => e.Start)
                    .HasName("start");

                entity.HasIndex(e => e.TsCreated)
                    .HasName("ts_created");

                entity.HasIndex(e => e.TsLastChange)
                    .HasName("ts_lastChange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BarId)
                    .IsRequired()
                    .HasColumnName("bar_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.BezCasu)
                    .HasColumnName("bezCasu")
                    .HasColumnType("int(1)");

                entity.Property(e => e.BusyStart)
                    .HasColumnName("busyStart")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Card)
                    .IsRequired()
                    .HasColumnName("card")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CardDmr)
                    .IsRequired()
                    .HasColumnName("card_dmr")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CenaFakturace)
                    .HasColumnName("cena_fakturace")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Cnc)
                    .HasColumnName("cnc")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CncEndOperationId)
                    .HasColumnName("cnc_end_operation_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncGroup)
                    .HasColumnName("cnc_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationAlarm)
                    .HasColumnName("cnc_operation_alarm")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationBusy)
                    .HasColumnName("cnc_operation_busy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationFeed)
                    .HasColumnName("cnc_operation_feed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationIdle)
                    .HasColumnName("cnc_operation_idle")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationKonec)
                    .HasColumnName("cnc_operation_konec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationKontrola)
                    .HasColumnName("cnc_operation_kontrola")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationNedefinovano)
                    .HasColumnName("cnc_operation_nedefinovano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationOdevzdaniks)
                    .HasColumnName("cnc_operation_odevzdaniks")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationPrihlaseni)
                    .HasColumnName("cnc_operation_prihlaseni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationServis)
                    .HasColumnName("cnc_operation_servis")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationSing)
                    .HasColumnName("cnc_operation_sing")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationUdrzba)
                    .HasColumnName("cnc_operation_udrzba")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncOperationWaitkontrola)
                    .HasColumnName("cnc_operation_waitkontrola")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncServisDatum)
                    .HasColumnName("cnc_servis_datum")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1899-12-30'");

                entity.Property(e => e.CncServisInterval)
                    .HasColumnName("cnc_servis_interval")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.CncServisIntervalUnit)
                    .HasColumnName("cnc_servis_interval_unit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CncStartOperationId)
                    .HasColumnName("cnc_start_operation_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.DostupneSmeny)
                    .IsRequired()
                    .HasColumnName("dostupne_smeny")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("'ALL'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Finish)
                    .HasColumnName("finish")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.GdprAnonymizovano)
                    .HasColumnName("gdpr_anonymizovano")
                    .HasColumnType("int(5)");

                entity.Property(e => e.GdprZbyva)
                    .HasColumnName("gdpr_zbyva")
                    .HasColumnType("int(5)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IdMistoPrace)
                    .HasColumnName("id_misto_prace")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdNadrizeny)
                    .HasColumnName("id_nadrizeny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPracovniSkupina)
                    .HasColumnName("id_pracovni_skupina")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProfese)
                    .HasColumnName("id_profese")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRidiciStruktura)
                    .HasColumnName("id_ridici_struktura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KoefSkutNakl)
                    .HasColumnName("koef_skut_nakl")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.KoefUkolMzdy)
                    .HasColumnName("koef_ukol_mzdy")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.KoefUkolMzdy2)
                    .HasColumnName("koef_ukol_mzdy2")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.KoefUkolMzdy2Type)
                    .HasColumnName("koef_ukol_mzdy2_type")
                    .HasColumnType("int(1)");

                entity.Property(e => e.KoefUkolMzdyType)
                    .HasColumnName("koef_ukol_mzdy_type")
                    .HasColumnType("int(1)");

                entity.Property(e => e.LastCycle)
                    .HasColumnName("lastCycle")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MistoPrace)
                    .IsRequired()
                    .HasColumnName("misto_prace")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PouzeDochazka)
                    .HasColumnName("pouzeDochazka")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Pozice)
                    .IsRequired()
                    .HasColumnName("pozice")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PriceMzda)
                    .HasColumnName("price_mzda")
                    .HasColumnType("decimal(15,3)");

                entity.Property(e => e.PricePrescas)
                    .HasColumnName("price_prescas")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.PriceSat)
                    .HasColumnName("price_sat")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.PriceSatKoef)
                    .HasColumnName("price_sat_koef")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.PriceSun)
                    .HasColumnName("price_sun")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.PriceSunKoef)
                    .HasColumnName("price_sun_koef")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("'1.000'");

                entity.Property(e => e.Prihlaseni)
                    .IsRequired()
                    .HasColumnName("prihlaseni")
                    .HasColumnType("enum('bar_id','user_pin')")
                    .HasDefaultValueSql("'bar_id'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Priorita)
                    .HasColumnName("priorita")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profese)
                    .IsRequired()
                    .HasColumnName("profese")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Smena)
                    .IsRequired()
                    .HasColumnName("smena")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.StavCnc)
                    .IsRequired()
                    .HasColumnName("stavCnc")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasColumnName("telefon")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.TsCreated)
                    .HasColumnName("ts_created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsLastChange)
                    .HasColumnName("ts_lastChange")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(5)");

                entity.Property(e => e.UseCenaFakturace)
                    .HasColumnName("use_cena_fakturace")
                    .HasColumnType("int(3)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SYSTEM'")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserPin)
                    .HasColumnName("user_pin")
                    .HasColumnType("bigint(16) unsigned");

                entity.Property(e => e.Workerprice)
                    .HasColumnName("workerprice")
                    .HasColumnType("decimal(15,2)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Worker)
                    .HasPrincipalKey<Readdata>(p => p.WorkerId)
                    .HasForeignKey<Worker>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_worker_id");
            });

            modelBuilder.Entity<WorkerCidla>(entity =>
            {
                entity.ToTable("worker_cidla");

                entity.HasComment("Tabulka pøístupù pro zamìstnance na èidlech");

                entity.HasIndex(e => new { e.IdCidlo, e.IdWorker })
                    .HasName("identifikace")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCidlo)
                    .HasColumnName("idCidlo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.IdWorker)
                    .HasColumnName("idWorker")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Prava).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkerProskoleni>(entity =>
            {
                entity.ToTable("worker_proskoleni");

                entity.HasComment("WORKER_PROSKOLENI");

                entity.HasIndex(e => e.IdTypProskoleni)
                    .HasName("id_typ_proskoleni");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DokumentyCesta)
                    .HasColumnName("dokumenty_cesta")
                    .HasColumnType("varchar(300)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IdTypProskoleni)
                    .HasColumnName("id_typ_proskoleni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlatiDo)
                    .HasColumnName("plati_do")
                    .HasColumnType("date");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(300)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ProbehloDne)
                    .HasColumnName("probehlo_dne")
                    .HasColumnType("date");

                entity.Property(e => e.Uroven)
                    .HasColumnName("uroven")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<WorkerProskoleniDruh>(entity =>
            {
                entity.ToTable("worker_proskoleni_druh");

                entity.HasComment("Druhy proškolení");

                entity.HasIndex(e => e.Druh)
                    .HasName("druh");

                entity.HasIndex(e => e.Nazev)
                    .HasName("nazev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Druh)
                    .HasColumnName("druh")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(300)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Zkratka)
                    .IsRequired()
                    .HasColumnName("zkratka")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<WorkerProskoleniReaddata>(entity =>
            {
                entity.ToTable("worker_proskoleni_readdata");

                entity.HasComment("Uložená data o proškolení");

                entity.HasIndex(e => e.ProskoleniDatum)
                    .HasName("proskoleni_datum");

                entity.HasIndex(e => e.ProskoleniId)
                    .HasName("proskoleni_id");

                entity.HasIndex(e => e.ProskoleniTyp)
                    .HasName("proskoleni_typ");

                entity.HasIndex(e => e.ProskoleniUroven)
                    .HasName("proskoleni_uroven");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Editovano)
                    .HasColumnName("editovano")
                    .HasColumnType("datetime");

                entity.Property(e => e.Poznamka)
                    .IsRequired()
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ProskoleniDatum)
                    .HasColumnName("proskoleni_datum")
                    .HasColumnType("date");

                entity.Property(e => e.ProskoleniDatumNasledujici)
                    .HasColumnName("proskoleni_datum_nasledujici")
                    .HasColumnType("date");

                entity.Property(e => e.ProskoleniId)
                    .HasColumnName("proskoleni_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProskoleniTyp)
                    .HasColumnName("proskoleni_typ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProskoleniUroven)
                    .HasColumnName("proskoleni_uroven")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uzivatel)
                    .IsRequired()
                    .HasColumnName("uzivatel")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Vlozeno)
                    .HasColumnName("vlozeno")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkerProskoleniTyp>(entity =>
            {
                entity.ToTable("worker_proskoleni_typ");

                entity.HasComment("Typy proškolení a poèet úrovní");

                entity.HasIndex(e => e.Nazev)
                    .HasName("nazev");

                entity.HasIndex(e => e.ProskoleniDruh)
                    .HasName("proskoleni_druh");

                entity.HasIndex(e => e.SkolitelEmail)
                    .HasName("skolitel_email");

                entity.HasIndex(e => e.WorkerId)
                    .HasName("worker_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DokumentyCesta)
                    .IsRequired()
                    .HasColumnName("dokumenty_cesta")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.IntervalJednotka)
                    .HasColumnName("interval_jednotka")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PocetUrovni)
                    .HasColumnName("pocet_urovni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Postupne)
                    .HasColumnName("postupne")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Poznamka)
                    .IsRequired()
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ProskoleniDruh)
                    .HasColumnName("proskoleni_druh")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProskoleniInterval)
                    .HasColumnName("proskoleni_interval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SkolitelEmail)
                    .IsRequired()
                    .HasColumnName("skolitel_email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SkolitelInfo)
                    .HasColumnName("skolitel_info")
                    .HasColumnType("int(2)");

                entity.Property(e => e.SkolitelNazev)
                    .IsRequired()
                    .HasColumnName("skolitel_nazev")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkerSmeny>(entity =>
            {
                entity.ToTable("worker_smeny");

                entity.HasComment("Tabulka smen");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AutoBreakDochazka)
                    .HasColumnName("auto_break_dochazka")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AutoBreakIf)
                    .HasColumnName("auto_break_if")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AutoBreakRepeat)
                    .HasColumnName("auto_break_repeat")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AutoDelPrescasIfless)
                    .HasColumnName("auto_del_prescas_ifless")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CtDoba)
                    .HasColumnName("ct_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.CtKonec)
                    .HasColumnName("ct_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.CtZacatek)
                    .HasColumnName("ct_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.IgnoreBeforeWork)
                    .HasColumnName("ignore_before_work")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Nazev)
                    .IsRequired()
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NeDoba)
                    .HasColumnName("ne_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.NeKonec)
                    .HasColumnName("ne_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.NeZacatek)
                    .HasColumnName("ne_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PaDoba)
                    .HasColumnName("pa_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.PaKonec)
                    .HasColumnName("pa_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PaZacatek)
                    .HasColumnName("pa_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PenalizaceIfMin)
                    .HasColumnName("penalizace_if_min")
                    .HasColumnType("int(5)");

                entity.Property(e => e.PenalizaceMinut)
                    .HasColumnName("penalizace_minut")
                    .HasColumnType("int(5)");

                entity.Property(e => e.PoDoba)
                    .HasColumnName("po_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.PoKonec)
                    .HasColumnName("po_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PoZacatek)
                    .HasColumnName("po_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Prestavka1do)
                    .HasColumnName("prestavka1do")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Prestavka1od)
                    .HasColumnName("prestavka1od")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Prestavka2do)
                    .HasColumnName("prestavka2do")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Prestavka2od)
                    .HasColumnName("prestavka2od")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Prestavka3do)
                    .HasColumnName("prestavka3do")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Prestavka3od)
                    .HasColumnName("prestavka3od")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.RoudWorkFinish)
                    .HasColumnName("roud_work_finish")
                    .HasColumnType("int(5)");

                entity.Property(e => e.RoudWorkStart)
                    .HasColumnName("roud_work_start")
                    .HasColumnType("int(5)");

                entity.Property(e => e.SoDoba)
                    .HasColumnName("so_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.SoKonec)
                    .HasColumnName("so_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.SoZacatek)
                    .HasColumnName("so_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.StDoba)
                    .HasColumnName("st_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.StKonec)
                    .HasColumnName("st_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.StZacatek)
                    .HasColumnName("st_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.UpravitZacatek)
                    .HasColumnName("upravit_zacatek")
                    .HasColumnType("int(2)");

                entity.Property(e => e.UsePenalizace)
                    .HasColumnName("use_penalizace")
                    .HasColumnType("int(5)");

                entity.Property(e => e.UtDoba)
                    .HasColumnName("ut_doba")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.UtKonec)
                    .HasColumnName("ut_konec")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.UtZacatek)
                    .HasColumnName("ut_zacatek")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<ZakazkyObjednavky>(entity =>
            {
                entity.ToTable("zakazky_objednavky");

                entity.HasComment("Plneni prijatych objednavek");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.PolozkaPrijateObjednavkyId)
                    .HasName("polozka_prijate_objednavky_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.PolozkaPrijateObjednavkyId)
                    .HasColumnName("polozka_prijate_objednavky_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<ZpusobDopravy>(entity =>
            {
                entity.ToTable("zpusob_dopravy");

                entity.HasIndex(e => e.Platby)
                    .HasName("platby");

                entity.HasIndex(e => e.Typ)
                    .HasName("typ");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Formular)
                    .HasColumnName("formular")
                    .HasColumnType("varchar(100)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.MaxHmotnost)
                    .HasColumnName("maxHmotnost")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazev)
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Platby)
                    .HasColumnName("platby")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(200)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<ZpusobPlatby>(entity =>
            {
                entity.ToTable("zpusob_platby");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Castka)
                    .HasColumnName("castka")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Nazev)
                    .HasColumnName("nazev")
                    .HasColumnType("varchar(50)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Poznamka)
                    .HasColumnName("poznamka")
                    .HasColumnType("varchar(250)")
                    .HasCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasColumnType("int(5)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
