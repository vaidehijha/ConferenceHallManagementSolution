using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.EmpDetDbModels;

namespace DAL_ConferenceHallManagement.DbContexts;

public partial class EmpdetContext : DbContext
{
    public EmpdetContext()
    {
    }

    public EmpdetContext(DbContextOptions<EmpdetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdUser> AdUsers { get; set; }

    public virtual DbSet<Adu> Adus { get; set; }

    public virtual DbSet<Aduer1> Aduer1s { get; set; }

    public virtual DbSet<ArcEmpKycAck> ArcEmpKycAcks { get; set; }

    public virtual DbSet<BloodDonorEmp> BloodDonorEmps { get; set; }

    public virtual DbSet<CarPassDetail> CarPassDetails { get; set; }

    public virtual DbSet<CarPassDetails20190422> CarPassDetails20190422s { get; set; }

    public virtual DbSet<CcRhqList> CcRhqLists { get; set; }

    public virtual DbSet<Ccemp> Ccemps { get; set; }

    public virtual DbSet<CcempList> CcempLists { get; set; }

    public virtual DbSet<CcposocoempList> CcposocoempLists { get; set; }

    public virtual DbSet<Covid19> Covid19s { get; set; }

    public virtual DbSet<Datacrit> Datacrits { get; set; }

    public virtual DbSet<Datadirect> Datadirects { get; set; }

    public virtual DbSet<Datahindi> Datahindis { get; set; }

    public virtual DbSet<Datastatus> Datastatuses { get; set; }

    public virtual DbSet<Datastatuslog> Datastatuslogs { get; set; }

    public virtual DbSet<Datum> Data { get; set; }

    public virtual DbSet<DiaryBoD> DiaryBoDs { get; set; }

    public virtual DbSet<DiaryConsLocation> DiaryConsLocations { get; set; }

    public virtual DbSet<DiaryDepartment> DiaryDepartments { get; set; }

    public virtual DbSet<DiaryDepartmentsMaster> DiaryDepartmentsMasters { get; set; }

    public virtual DbSet<DiaryEr1Location> DiaryEr1Locations { get; set; }

    public virtual DbSet<DiaryEr2Location> DiaryEr2Locations { get; set; }

    public virtual DbSet<DiaryFaxNo> DiaryFaxNos { get; set; }

    public virtual DbSet<DiaryGenerated> DiaryGenerateds { get; set; }

    public virtual DbSet<DiaryGradeOrder> DiaryGradeOrders { get; set; }

    public virtual DbSet<DiaryNeNwIcLocation> DiaryNeNwIcLocations { get; set; }

    public virtual DbSet<DiaryNerLocation> DiaryNerLocations { get; set; }

    public virtual DbSet<DiaryNr1Location> DiaryNr1Locations { get; set; }

    public virtual DbSet<DiaryNr2Location> DiaryNr2Locations { get; set; }

    public virtual DbSet<DiaryNr3Location> DiaryNr3Locations { get; set; }

    public virtual DbSet<DiaryOdishaLocation> DiaryOdishaLocations { get; set; }

    public virtual DbSet<DiaryOtherEmployee> DiaryOtherEmployees { get; set; }

    public virtual DbSet<DiaryPowerTelLocation> DiaryPowerTelLocations { get; set; }

    public virtual DbSet<DiaryRegion> DiaryRegions { get; set; }

    public virtual DbSet<DiarySpecialService> DiarySpecialServices { get; set; }

    public virtual DbSet<DiarySpecialServiceDetail> DiarySpecialServiceDetails { get; set; }

    public virtual DbSet<DiarySr1Location> DiarySr1Locations { get; set; }

    public virtual DbSet<DiarySr2Location> DiarySr2Locations { get; set; }

    public virtual DbSet<DiaryWnHvdcIcLocation> DiaryWnHvdcIcLocations { get; set; }

    public virtual DbSet<DiaryWr1Location> DiaryWr1Locations { get; set; }

    public virtual DbSet<DiaryWr2Location> DiaryWr2Locations { get; set; }

    public virtual DbSet<DistrictList> DistrictLists { get; set; }

    public virtual DbSet<DreamsExtUser> DreamsExtUsers { get; set; }

    public virtual DbSet<EetempList> EetempLists { get; set; }

    public virtual DbSet<ElmahError> ElmahErrors { get; set; }

    public virtual DbSet<EmpEpfo> EmpEpfos { get; set; }

    public virtual DbSet<EmpEpfoAck> EmpEpfoAcks { get; set; }

    public virtual DbSet<EmpEpfoAck2019> EmpEpfoAck2019s { get; set; }

    public virtual DbSet<EmpExperience> EmpExperiences { get; set; }

    public virtual DbSet<EmpFamily> EmpFamilies { get; set; }

    public virtual DbSet<EmpInformation> EmpInformations { get; set; }

    public virtual DbSet<EmpKycAck> EmpKycAcks { get; set; }

    public virtual DbSet<EmpKycAck2018> EmpKycAck2018s { get; set; }

    public virtual DbSet<EmpKycAck2019> EmpKycAck2019s { get; set; }

    public virtual DbSet<EmpListCc> EmpListCcs { get; set; }

    public virtual DbSet<EmpPran> EmpPrans { get; set; }

    public virtual DbSet<EmpQualification> EmpQualifications { get; set; }

    public virtual DbSet<Emptree> Emptrees { get; set; }

    public virtual DbSet<EofficeNodalOfcrDetail> EofficeNodalOfcrDetails { get; set; }

    public virtual DbSet<EpfoEsign> EpfoEsigns { get; set; }

    public virtual DbSet<Er1rhqempList> Er1rhqempLists { get; set; }

    public virtual DbSet<Er2rhqempList> Er2rhqempLists { get; set; }

    public virtual DbSet<Erpname> Erpnames { get; set; }

    public virtual DbSet<ExEmpDetail> ExEmpDetails { get; set; }

    public virtual DbSet<ExEmpDetailLog> ExEmpDetailLogs { get; set; }

    public virtual DbSet<ExEmpFeedback> ExEmpFeedbacks { get; set; }

    public virtual DbSet<ExUserLogIn> ExUserLogIns { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Findatum> Findata { get; set; }

    public virtual DbSet<GradeList> GradeLists { get; set; }

    public virtual DbSet<HindiData2016> HindiData2016s { get; set; }

    public virtual DbSet<HindiData2017> HindiData2017s { get; set; }

    public virtual DbSet<HindiData2019> HindiData2019s { get; set; }

    public virtual DbSet<HindiData2020> HindiData2020s { get; set; }

    public virtual DbSet<HindiData2021> HindiData2021s { get; set; }

    public virtual DbSet<HindiData2022> HindiData2022s { get; set; }

    public virtual DbSet<HindiData2023> HindiData2023s { get; set; }

    public virtual DbSet<HindiData2024> HindiData2024s { get; set; }

    public virtual DbSet<HindiDatum> HindiData { get; set; }

    public virtual DbSet<HindiTblDept> HindiTblDepts { get; set; }

    public virtual DbSet<HindiTblDesignation> HindiTblDesignations { get; set; }

    public virtual DbSet<HindiTblLocation> HindiTblLocations { get; set; }

    public virtual DbSet<HindiTblRegion> HindiTblRegions { get; set; }

    public virtual DbSet<Hr> Hrs { get; set; }

    public virtual DbSet<HrEmpDatum> HrEmpData { get; set; }

    public virtual DbSet<IgradeOrder> IgradeOrders { get; set; }

    public virtual DbSet<ItcoordList> ItcoordLists { get; set; }

    public virtual DbSet<LangaugeList> LangaugeLists { get; set; }

    public virtual DbSet<LocationList> LocationLists { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogDreamsExtUser> LogDreamsExtUsers { get; set; }

    public virtual DbSet<Logdatacrit> Logdatacrits { get; set; }

    public virtual DbSet<Logdatadirect> Logdatadirects { get; set; }

    public virtual DbSet<LoginDetail> LoginDetails { get; set; }

    public virtual DbSet<MasterHindi> MasterHindis { get; set; }

    public virtual DbSet<MasterLanguage> MasterLanguages { get; set; }

    public virtual DbSet<MasterTable> MasterTables { get; set; }

    public virtual DbSet<MaterialList> MaterialLists { get; set; }

    public virtual DbSet<NerempList> NerempLists { get; set; }

    public virtual DbSet<NlocationList> NlocationLists { get; set; }

    public virtual DbSet<Nr2rhqempList> Nr2rhqempLists { get; set; }

    public virtual DbSet<Nr3rhqempList> Nr3rhqempLists { get; set; }

    public virtual DbSet<NrempList> NrempLists { get; set; }

    public virtual DbSet<NrldcempList> NrldcempLists { get; set; }

    public virtual DbSet<OdishaLocation> OdishaLocations { get; set; }

    public virtual DbSet<PolicyPerceptionSurvey> PolicyPerceptionSurveys { get; set; }

    public virtual DbSet<PwdReset> PwdResets { get; set; }

    public virtual DbSet<PwdResetComplete> PwdResetCompletes { get; set; }

    public virtual DbSet<RecttRegionMaster> RecttRegionMasters { get; set; }

    public virtual DbSet<RegItCoord> RegItCoords { get; set; }

    public virtual DbSet<RegionsList> RegionsLists { get; set; }

    public virtual DbSet<RelBloodDonation> RelBloodDonations { get; set; }

    public virtual DbSet<SelfRorvooffr> SelfRorvooffrs { get; set; }

    public virtual DbSet<Sr1rhqempList> Sr1rhqempLists { get; set; }

    public virtual DbSet<Sr2rhqempList> Sr2rhqempLists { get; set; }

    public virtual DbSet<Srdatum> Srdata { get; set; }

    public virtual DbSet<StateList> StateLists { get; set; }

    public virtual DbSet<StatesByRegion> StatesByRegions { get; set; }

    public virtual DbSet<SupportUserResetPassLog> SupportUserResetPassLogs { get; set; }

    public virtual DbSet<SupportUserResetPassPermission> SupportUserResetPassPermissions { get; set; }

    public virtual DbSet<TmpIds1> TmpIds1s { get; set; }

    public virtual DbSet<Totp> Totps { get; set; }

    public virtual DbSet<TotpChangeLog> TotpChangeLogs { get; set; }

    public virtual DbSet<Training> Trainings { get; set; }

    public virtual DbSet<TransferDataFinal> TransferDataFinals { get; set; }

    public virtual DbSet<UserDet> UserDets { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    public virtual DbSet<VActiveUserDetailsWith8DigitEmpNo> VActiveUserDetailsWith8DigitEmpNos { get; set; }

    public virtual DbSet<VActiveUserdetail> VActiveUserdetails { get; set; }

    public virtual DbSet<VActiveUsersForVaartum> VActiveUsersForVaarta { get; set; }

    public virtual DbSet<VAllUserDetailsWith8DigitEmpNo> VAllUserDetailsWith8DigitEmpNos { get; set; }

    public virtual DbSet<VAttdView> VAttdViews { get; set; }

    public virtual DbSet<VCcRhqList> VCcRhqLists { get; set; }

    public virtual DbSet<VDreamsUser> VDreamsUsers { get; set; }

    public virtual DbSet<VE1> VE1s { get; set; }

    public virtual DbSet<VGetUserDetail> VGetUserDetails { get; set; }

    public virtual DbSet<VHindiDatum> VHindiData { get; set; }

    public virtual DbSet<VItcoordinator> VItcoordinators { get; set; }

    public virtual DbSet<VQlikReportingHierarchy> VQlikReportingHierarchies { get; set; }

    public virtual DbSet<VRtiUserList> VRtiUserLists { get; set; }

    public virtual DbSet<VSupportUserAdmin> VSupportUserAdmins { get; set; }

    public virtual DbSet<VSupportUserPasswordChangeLog> VSupportUserPasswordChangeLogs { get; set; }

    public virtual DbSet<VTttt> VTttts { get; set; }

    public virtual DbSet<VUserDetail> VUserDetails { get; set; }

    public virtual DbSet<VYe> VYes { get; set; }

    public virtual DbSet<VactiveEmployee> VactiveEmployees { get; set; }

    public virtual DbSet<VallEmployee> VallEmployees { get; set; }

    public virtual DbSet<VallEmployee1> VallEmployees1 { get; set; }

    public virtual DbSet<VcDetail> VcDetails { get; set; }

    public virtual DbSet<VcarDetail> VcarDetails { get; set; }

    public virtual DbSet<VendorTraining> VendorTrainings { get; set; }

    public virtual DbSet<VexEmployee> VexEmployees { get; set; }

    public virtual DbSet<VigSize> VigSizes { get; set; }

    public virtual DbSet<VigTshirtElegibleEmployee> VigTshirtElegibleEmployees { get; set; }

    public virtual DbSet<Wr1rhqempList> Wr1rhqempLists { get; set; }

    public virtual DbSet<Wr2rhqempList> Wr2rhqempLists { get; set; }

    public virtual DbSet<WsQuery> WsQueries { get; set; }

    public virtual DbSet<X12121212> X12121212s { get; set; }

    public virtual DbSet<X2> X2s { get; set; }

    public virtual DbSet<X25> X25s { get; set; }

    public virtual DbSet<X9009> X9009s { get; set; }

    public virtual DbSet<XEmpEpfo> XEmpEpfos { get; set; }

    public virtual DbSet<XEmpEpfo2018> XEmpEpfo2018s { get; set; }

    public virtual DbSet<XEmpEpfo2019> XEmpEpfo2019s { get; set; }

    public virtual DbSet<Z1> Z1s { get; set; }

    public virtual DbSet<Z2> Z2s { get; set; }

    public virtual DbSet<Z33> Z33s { get; set; }

    public virtual DbSet<Z9090> Z9090s { get; set; }

    public virtual DbSet<ZEmpUanMemDatum> ZEmpUanMemData { get; set; }
       

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AD_Users");

            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Dn)
                .HasMaxLength(300)
                .HasColumnName("DN");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ou1)
                .HasMaxLength(100)
                .HasColumnName("OU1");
            entity.Property(e => e.Ou2)
                .HasMaxLength(200)
                .HasColumnName("OU2");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Sam)
                .HasMaxLength(200)
                .HasColumnName("SAM");
            entity.Property(e => e.SurName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Upn)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("UPN");
        });

        modelBuilder.Entity<Adu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ADU");

            entity.Property(e => e.Dn)
                .HasMaxLength(300)
                .HasColumnName("DN");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Ou1)
                .HasMaxLength(100)
                .HasColumnName("OU1");
            entity.Property(e => e.Ou2)
                .HasMaxLength(200)
                .HasColumnName("OU2");
            entity.Property(e => e.Sam)
                .HasMaxLength(200)
                .HasColumnName("SAM");
            entity.Property(e => e.SurName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Upn)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("UPN");
        });

        modelBuilder.Entity<Aduer1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ADUER1");

            entity.Property(e => e.Dn)
                .HasMaxLength(300)
                .HasColumnName("DN");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Ot)
                .HasMaxLength(200)
                .HasColumnName("OT");
            entity.Property(e => e.Ou1)
                .HasMaxLength(100)
                .HasColumnName("OU1");
            entity.Property(e => e.Ou2)
                .HasMaxLength(200)
                .HasColumnName("OU2");
            entity.Property(e => e.Sam)
                .HasMaxLength(200)
                .HasColumnName("SAM");
            entity.Property(e => e.SurName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Upn)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("UPN");
        });

        modelBuilder.Entity<ArcEmpKycAck>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK_Emp_Kyc_Ack");

            entity.ToTable("Arc_Emp_Kyc_Ack");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.EmpNameInAadhar).HasMaxLength(500);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<BloodDonorEmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BloodDonorEmp");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deptt)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Disease)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LandLineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastDonationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNo");
        });

        modelBuilder.Entity<CarPassDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AlterNateNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alterNateNo");
            entity.Property(e => e.DateOfIssue).HasColumnType("datetime");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EMPNo");
            entity.Property(e => e.EmporNonEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPorNonEmp");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(0)
                .HasColumnName("isDeleted");
            entity.Property(e => e.MakeVehicle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameofPassHolder)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PassSno).HasColumnName("PassSNo");
            entity.Property(e => e.ReferencedEmpno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferencedEMPNO");
            entity.Property(e => e.RegNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegNo1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNO");
            entity.Property(e => e.VehicleType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CarPassDetails20190422>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CarPassDetails_2019_04_22");

            entity.Property(e => e.AlterNateNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alterNateNo");
            entity.Property(e => e.DateOfIssue).HasColumnType("datetime");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EMPNo");
            entity.Property(e => e.EmporNonEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPorNonEmp");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MakeVehicle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameofPassHolder)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PassSno).HasColumnName("PassSNo");
            entity.Property(e => e.ReferencedEmpno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferencedEMPNO");
            entity.Property(e => e.RegNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegNo1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNO");
            entity.Property(e => e.VehicleType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CcRhqList>(entity =>
        {
            entity.HasKey(e => new { e.RegionId, e.LocationId });

            entity.ToTable("CcRhqList");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Ccemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CCEMP");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<CcempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CCEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<CcposocoempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CCPOSOCOEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Covid19>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Covid19");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InsertedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Datacrit>(entity =>
        {
            entity.HasKey(e => e.Empno);

            entity.ToTable("DATACRIT");

            entity.HasIndex(e => new { e.Bloodgroup, e.Dob }, "IX_DC_BGDob3342");

            entity.HasIndex(e => new { e.Sex, e.Dob, e.Mars }, "IX_DC_SDME");

            entity.HasIndex(e => e.Dob, "IX_DataCrit_EmpName_Hi_Ed_ER");

            entity.HasIndex(e => e.Sex, "IX_DataCrit_Sex");

            entity.HasIndex(e => e.Empname, "IX_EMPDET_DataCrit_EName");

            entity.HasIndex(e => e.Dob, "Ix_DataCrit_1");

            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Block).HasColumnName("BLOCK");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.EmpStatus).HasDefaultValue(1);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Insertedon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("insertedon");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsHradmin)
                .HasDefaultValue(false)
                .HasColumnName("IsHRAdmin");
            entity.Property(e => e.IsIntranetAdmin).HasDefaultValue(false);
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.PassChangedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ResidenceAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("flick");
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Datadirect>(entity =>
        {
            entity.HasKey(e => e.Empno);

            entity.ToTable("DATADIRECT");

            entity.HasIndex(e => e.Officeraxno, "IX_024");

            entity.HasIndex(e => e.Cellno, "IX_DataDirect_001");

            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.ContactDetailsEpms)
                .HasDefaultValue(false)
                .HasColumnName("ContactDetailsEPMS");
            entity.Property(e => e.ContactDetailsUpdated).HasDefaultValue(false);
            entity.Property(e => e.Empimgguid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(20)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<Datahindi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DATAHINDI");

            entity.Property(e => e.Empno)
                .HasMaxLength(255)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Hindidepart)
                .HasMaxLength(255)
                .HasColumnName("HINDIDEPART");
            entity.Property(e => e.Hindidesign)
                .HasMaxLength(255)
                .HasColumnName("HINDIDESIGN");
            entity.Property(e => e.Hindilevel)
                .HasMaxLength(255)
                .HasColumnName("HINDILEVEL");
            entity.Property(e => e.Hindilocation)
                .HasMaxLength(255)
                .HasColumnName("HINDILOCATION");
            entity.Property(e => e.Hindiname)
                .HasMaxLength(255)
                .HasColumnName("HINDINAME");
            entity.Property(e => e.Hindiregion)
                .HasMaxLength(255)
                .HasColumnName("HINDIREGION");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Datastatus>(entity =>
        {
            entity.HasKey(e => e.Empno);

            entity.ToTable("DATASTATUS");

            entity.HasIndex(e => e.TotpSecret, "DS_ToTp").IsUnique();

            entity.HasIndex(e => new { e.Active, e.Department }, "IX_00010");

            entity.HasIndex(e => e.Active, "IX_0002024_001");

            entity.HasIndex(e => new { e.Active, e.Empno }, "IX_0002024_002");

            entity.HasIndex(e => e.Active, "IX_1487");

            entity.HasIndex(e => new { e.Active, e.Empno }, "IX_1489");

            entity.HasIndex(e => e.Active, "IX_1522");

            entity.HasIndex(e => new { e.Department, e.Active }, "IX_202405_08");

            entity.HasIndex(e => e.Active, "IX_2024_001");

            entity.HasIndex(e => e.Active, "IX_2024_002");

            entity.HasIndex(e => e.Active, "IX_2024_003");

            entity.HasIndex(e => new { e.Active, e.Empno }, "IX_2024_004");

            entity.HasIndex(e => new { e.Grade, e.Active }, "IX_2024_005");

            entity.HasIndex(e => e.Active, "IX_2025_03_23_01");

            entity.HasIndex(e => e.Active, "IX_2025_03_23_02");

            entity.HasIndex(e => new { e.Active, e.IsO365user }, "IX_3342");

            entity.HasIndex(e => new { e.Region, e.Active }, "IX_DS_001");

            entity.HasIndex(e => e.Active, "IX_DS_24_0011");

            entity.HasIndex(e => new { e.Active, e.Empno }, "IX_DS_24_0022");

            entity.HasIndex(e => new { e.Active, e.Designation, e.Grade, e.Department }, "IX_DS_ADGD");

            entity.HasIndex(e => new { e.Active, e.Location, e.Department }, "IX_DS_ALD");

            entity.HasIndex(e => new { e.Active, e.Location }, "IX_DS_ALDRD");

            entity.HasIndex(e => new { e.Active, e.Reviewingoffr }, "IX_DS_ARO");

            entity.HasIndex(e => new { e.Active, e.Grade }, "IX_DS_A_G");

            entity.HasIndex(e => new { e.Active, e.Location }, "IX_DS_A_L_Re");

            entity.HasIndex(e => new { e.Active, e.Region }, "IX_DS_A_R");

            entity.HasIndex(e => new { e.Active, e.Reportingoffr }, "IX_DS_A_RO");

            entity.HasIndex(e => new { e.Department, e.Active }, "IX_DS_D00142");

            entity.HasIndex(e => new { e.Grade, e.Department, e.Active }, "IX_DS_G1212");

            entity.HasIndex(e => new { e.Grade, e.Active, e.Designation }, "IX_DS_G_A_D_P_R_L_D");

            entity.HasIndex(e => new { e.Grade, e.Active }, "IX_DS_G_A_D_P_R_L_De");

            entity.HasIndex(e => new { e.Grade, e.Department, e.Active, e.Designation }, "IX_DS_G_D_A");

            entity.HasIndex(e => new { e.Grade, e.Location, e.Active }, "IX_DS_G_L_A");

            entity.HasIndex(e => e.Active, "IX_DS_uiyi8y87t8g8g");

            entity.HasIndex(e => new { e.Region, e.Location, e.Active }, "IX_DatStatus_Region_Location_Active");

            entity.HasIndex(e => e.Active, "IX_DataSatus_002");

            entity.HasIndex(e => new { e.Location, e.Active }, "IX_DataStatus_Location_Active");

            entity.HasIndex(e => new { e.Location, e.Active, e.Department }, "IX_DataStatus_Location_Active_Department");

            entity.HasIndex(e => new { e.Location, e.Department, e.Active }, "IX_DataStatus_Location_Department_Active");

            entity.HasIndex(e => new { e.Active, e.Department }, "IX_EmpDet_DS_Active_Department");

            entity.HasIndex(e => e.Active, "IX_Emp_09090");

            entity.HasIndex(e => e.Active, "Ix_DS_Act_Des");

            entity.HasIndex(e => e.Active, "Ix_DataStatus_1");

            entity.HasIndex(e => e.Active, "missing_index_15");

            entity.HasIndex(e => new { e.Grade, e.Active }, "missing_index_22");

            entity.HasIndex(e => new { e.Active, e.Empno }, "missing_index_4");

            entity.HasIndex(e => new { e.Department, e.Active }, "missing_index_56");

            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.AadharNumber).HasMaxLength(50);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Basicpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BASICPAY");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.DefaultLanguage).HasDefaultValue(1);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Oldlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDLOCATION");
            entity.Property(e => e.Oldregion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDREGION");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Perspay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PERSPAY");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.Railwaystation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RAILWAYSTATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Responsibilities)
                .HasColumnType("text")
                .HasColumnName("RESPONSIBILITIES");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Salaryaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYACCOUNT");
            entity.Property(e => e.Salarybank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYBANK");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(replace(concat(newid(),newid(),newid(),newid(),newid()),'-',''))")
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.Transferredto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANSFERREDTO");
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updby)
                .HasMaxLength(50)
                .HasColumnName("UPDBY");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPDFROM");
        });

        modelBuilder.Entity<Datastatuslog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DATASTATUSLog");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.EpmsReportingOffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRADE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.ReportingDateFrom).HasColumnType("datetime");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(20);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updby)
                .HasMaxLength(50)
                .HasColumnName("UPDBY");
        });

        modelBuilder.Entity<Datum>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PK_DATACRIT1");

            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Block).HasColumnName("BLOCK");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.Insertedon).HasColumnName("insertedon");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.PassChangedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ResidenceAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DiaryBoD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_BoDs");

            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.DesignationHi).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameHi).HasMaxLength(200);
            entity.Property(e => e.OffAddress).HasMaxLength(500);
            entity.Property(e => e.OffPhone).HasMaxLength(500);
            entity.Property(e => e.ResAddress).HasMaxLength(500);
            entity.Property(e => e.ResAddressHi).HasMaxLength(500);
            entity.Property(e => e.ResPhone).HasMaxLength(500);
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryConsLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_ConsLocations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Departments");

            entity.Property(e => e.DepartmentNameEn).HasMaxLength(200);
            entity.Property(e => e.DepartmentNameHi).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryDepartmentsMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_DepartmentsMaster");

            entity.Property(e => e.DepartmentNameEn).HasMaxLength(200);
            entity.Property(e => e.DepartmentNameHi).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryEr1Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Er1Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryEr2Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Er2Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryFaxNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_FaxNos");

            entity.Property(e => e.DepartmentEn).HasMaxLength(200);
            entity.Property(e => e.DepartmentHi).HasMaxLength(200);
            entity.Property(e => e.FaxNo).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryGenerated>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Generated");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Regions).HasMaxLength(200);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<DiaryGradeOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_GradeOrder");

            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryNeNwIcLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_NeNwIcLocations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryNerLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_NerLocations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryNr1Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Nr1Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryNr2Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Nr2Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryNr3Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Nr3Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryOdishaLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_OdishaLocations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(1);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc)
                .HasMaxLength(500)
                .HasDefaultValue("");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasDefaultValue("60002236");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryOtherEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_OtherEmployees");

            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.SuperEmpNo).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryPowerTelLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_PowerTelLocations");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Regions");

            entity.Property(e => e.RegionNameEn).HasMaxLength(500);
            entity.Property(e => e.RegionNameHi).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiarySpecialService>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_SpecialServices");

            entity.Property(e => e.SpecialServiceNameEn).HasMaxLength(200);
            entity.Property(e => e.SpecialServiceNameHi).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiarySpecialServiceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_SpecialServiceDetails");

            entity.Property(e => e.InterCom).HasMaxLength(200);
            entity.Property(e => e.ServiceNameEn).HasMaxLength(200);
            entity.Property(e => e.ServiceNameHi).HasMaxLength(200);
            entity.Property(e => e.Telephone).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiarySr1Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Sr1Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiarySr2Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Sr2Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryWnHvdcIcLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_WnHvdcIcLocations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryWr1Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Wr1Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DiaryWr2Location>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Diary_Wr2Locations");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpLocation).HasMaxLength(500);
            entity.Property(e => e.LocationNameEn).HasMaxLength(500);
            entity.Property(e => e.LocationNameHi).HasMaxLength(500);
            entity.Property(e => e.Misc).HasMaxLength(500);
            entity.Property(e => e.StdCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DistrictList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DistrictList");

            entity.Property(e => e.DistrictNameEn).HasMaxLength(100);
            entity.Property(e => e.DistrictNameHi).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DreamsExtUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dreams_ExtUser");

            entity.Property(e => e.CellNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Department).HasMaxLength(200);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InsertedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.Region).HasMaxLength(200);
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EetempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EETEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<ElmahError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ELMAH_Error");

            entity.Property(e => e.AllXml).HasColumnType("ntext");
            entity.Property(e => e.Application).HasMaxLength(60);
            entity.Property(e => e.Host).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            entity.Property(e => e.Source).HasMaxLength(60);
            entity.Property(e => e.TimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpEpfo>(entity =>
        {
            entity.HasKey(e => e.EmpNo);

            entity.ToTable("Emp_Epfo");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.DateofBirth).HasMaxLength(100);
            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.Eps)
                .HasMaxLength(100)
                .HasColumnName("EPS");
            entity.Property(e => e.FatherName).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MembershipDate).HasMaxLength(100);
            entity.Property(e => e.Uan)
                .HasMaxLength(100)
                .HasColumnName("UAN");
        });

        modelBuilder.Entity<EmpEpfoAck>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK_Emp_Epfo_Ack_");

            entity.ToTable("Emp_Epfo_Ack");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpEpfoAck2019>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK_Emp_Epfo_Ack");

            entity.ToTable("Emp_Epfo_Ack_2019");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpExperience>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmpExperience");

            entity.Property(e => e.Action).HasMaxLength(500);
            entity.Property(e => e.Company).HasMaxLength(255);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Desg).HasMaxLength(255);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Level).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Region).HasMaxLength(255);
        });

        modelBuilder.Entity<EmpFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmpFamily");

            entity.Property(e => e.Birthdate).HasMaxLength(255);
            entity.Property(e => e.Challenged).HasMaxLength(255);
            entity.Property(e => e.Dependent).HasMaxLength(255);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Ltcdependent)
                .HasMaxLength(255)
                .HasColumnName("LTCDependent");
            entity.Property(e => e.MedicalDependent).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<EmpInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmpInformation");

            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CELLNO");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PGEMAIL");
        });

        modelBuilder.Entity<EmpKycAck>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK_19Emp_Kyc_Ack_");

            entity.ToTable("Emp_Kyc_Ack");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.EmpNameInAadhar).HasMaxLength(500);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpKycAck2018>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK_1Emp_Kyc_Ack");

            entity.ToTable("Emp_Kyc_Ack_2018");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.EmpNameInAadhar).HasMaxLength(500);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpKycAck2019>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK_19Emp_Kyc_Ack");

            entity.ToTable("Emp_Kyc_Ack_2019");

            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.EmpNameInAadhar).HasMaxLength(500);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpListCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmpListCC");

            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CELLNO");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PGEMAIL");
        });

        modelBuilder.Entity<EmpPran>(entity =>
        {
            entity.HasKey(e => e.EmpNo);

            entity.ToTable("EmpPran");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Pran)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpQualification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmpQualification");

            entity.Property(e => e.Branch).HasMaxLength(255);
            entity.Property(e => e.Course).HasMaxLength(255);
            entity.Property(e => e.Division).HasMaxLength(255);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Institute).HasMaxLength(500);
            entity.Property(e => e.Percentage).HasMaxLength(255);
            entity.Property(e => e.University).HasMaxLength(255);
            entity.Property(e => e.Year).HasMaxLength(255);
        });

        modelBuilder.Entity<Emptree>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMPTREE");

            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRADE");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REVIEWINGOFFR");
        });

        modelBuilder.Entity<EofficeNodalOfcrDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EOFFICE_NODAL_OFCR_DETAILS");

            entity.Property(e => e.EmpId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("EMP_ID");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<EpfoEsign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Epfo_ESign");

            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Er1rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ER1RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Er2rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ER2RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Erpname>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ERPName");

            entity.Property(e => e.Department)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Ename)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ErpnameDate)
                .HasColumnType("datetime")
                .HasColumnName("ERPNameDate");
            entity.Property(e => e.Grade)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.MobNo)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("mobNo");
            entity.Property(e => e.NameSuggestion)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExEmpDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExEmpDetail");

            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.CellNo).HasMaxLength(50);
            entity.Property(e => e.CurrentAddress).HasMaxLength(500);
            entity.Property(e => e.CurrentCity).HasMaxLength(50);
            entity.Property(e => e.CurrentState).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpName).HasMaxLength(500);
            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(500);
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.RegisteredFrom).HasMaxLength(50);
            entity.Property(e => e.ResidencePhoneNo).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.SpouseBloodGroup).HasMaxLength(50);
            entity.Property(e => e.SpouseGender).HasMaxLength(50);
            entity.Property(e => e.SpouseName).HasMaxLength(50);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<ExEmpDetailLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExEmpDetailLog");

            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.CellNo).HasMaxLength(50);
            entity.Property(e => e.CurrentAddress).HasMaxLength(500);
            entity.Property(e => e.CurrentCity).HasMaxLength(50);
            entity.Property(e => e.CurrentState).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpName).HasMaxLength(500);
            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LoggedBy).HasMaxLength(10);
            entity.Property(e => e.LoggedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Password).HasMaxLength(500);
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.RegisteredFrom).HasMaxLength(50);
            entity.Property(e => e.ResidencePhoneNo).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.SpouseBloodGroup).HasMaxLength(50);
            entity.Property(e => e.SpouseGender).HasMaxLength(50);
            entity.Property(e => e.SpouseName).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<ExEmpFeedback>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExEmpFeedback");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ExUserLogIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExUserLogIn");

            entity.Property(e => e.AppRelativeCurrentExecutionFilePath).HasMaxLength(500);
            entity.Property(e => e.ApplicationPath).HasMaxLength(500);
            entity.Property(e => e.ContentEncoding).HasMaxLength(500);
            entity.Property(e => e.CurrentExecutionFilePath).HasMaxLength(500);
            entity.Property(e => e.EmpNo).HasMaxLength(5);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.HttpMethod).HasMaxLength(10);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Path).HasMaxLength(500);
            entity.Property(e => e.PathInfo).HasMaxLength(500);
            entity.Property(e => e.PhysicalApplicationPath).HasMaxLength(500);
            entity.Property(e => e.PhysicalPath).HasMaxLength(500);
            entity.Property(e => e.RawUrl).HasMaxLength(500);
            entity.Property(e => e.RequestType).HasMaxLength(500);
            entity.Property(e => e.SessionId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Url).HasMaxLength(500);
            entity.Property(e => e.UrlReferrer).HasMaxLength(500);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserHostAddress).HasMaxLength(50);
            entity.Property(e => e.UserHostName).HasMaxLength(50);
            entity.Property(e => e.WebBrowser).HasMaxLength(500);
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.ToTable("feedback");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FeedbackDetails).HasMaxLength(4000);
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(100)
                .HasColumnName("updatedFrom");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("updatedOn");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(10)
                .HasColumnName("updatedby");
        });

        modelBuilder.Entity<Findatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FINDATA");

            entity.Property(e => e.Col010)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.EmpName)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("EMP_NAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Grade)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("GRADE");
            entity.Property(e => e.Id)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Incrratepercent)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("INCRRATEPERCENT");
            entity.Property(e => e.Posting)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("POSTING");
            entity.Property(e => e.Region)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Scalemax)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("SCALEMAX");
            entity.Property(e => e.Scalemin)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("SCALEMIN");
        });

        modelBuilder.Entity<GradeList>(entity =>
        {
            entity.HasKey(e => e.Grade);

            entity.ToTable("GradeList");

            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HindiData2016>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2016");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2017");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2019>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2019");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2020");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2021");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2022");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2023");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.Parangat).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiData2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HindiData_2024");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.Parangat).HasMaxLength(200);
            entity.Property(e => e.ParangatYesNo).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.Parangat).HasMaxLength(200);
            entity.Property(e => e.ParangatYesNo).HasMaxLength(10);
            entity.Property(e => e.SubmissionFinYear)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.WorkingKnowledgePercent).HasMaxLength(100);
        });

        modelBuilder.Entity<HindiTblDept>(entity =>
        {
            entity.HasKey(e => e.Dept);

            entity.ToTable("hindi_tblDept");

            entity.Property(e => e.Dept).HasMaxLength(50);
            entity.Property(e => e.DeptHindi).HasMaxLength(50);
        });

        modelBuilder.Entity<HindiTblDesignation>(entity =>
        {
            entity.HasKey(e => e.Desg);

            entity.ToTable("hindi_tblDesignation");

            entity.Property(e => e.Desg)
                .HasMaxLength(50)
                .HasColumnName("desg");
            entity.Property(e => e.DesgHindi)
                .HasMaxLength(50)
                .HasColumnName("desgHindi");
        });

        modelBuilder.Entity<HindiTblLocation>(entity =>
        {
            entity.HasKey(e => e.Location);

            entity.ToTable("hindi_tblLocation");

            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasColumnName("location");
            entity.Property(e => e.LocationHindi)
                .HasMaxLength(50)
                .HasColumnName("locationHindi");
        });

        modelBuilder.Entity<HindiTblRegion>(entity =>
        {
            entity.HasKey(e => e.Region);

            entity.ToTable("hindi_tblRegion");

            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.RegionHindi).HasMaxLength(50);
        });

        modelBuilder.Entity<Hr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR");

            entity.Property(e => e.AdminPassword).HasMaxLength(50);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(50)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrEmpDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName).HasMaxLength(100);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IgradeOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IGradeOrder");

            entity.Property(e => e.Grade)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ItcoordList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITCoordList");

            entity.Property(e => e.EmpNo).HasMaxLength(10);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ss)
                .HasMaxLength(50)
                .HasColumnName("SS");
        });

        modelBuilder.Entity<LangaugeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LangaugeList");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
        });

        modelBuilder.Entity<LocationList>(entity =>
        {
            entity.HasKey(e => new { e.LocationName, e.RegionName }).HasName("PK_LocationList_1");

            entity.ToTable("LocationList");

            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.RegionName).HasMaxLength(40);
            entity.Property(e => e.LocationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationNameHi).HasMaxLength(50);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Log");

            entity.Property(e => e.Exception).IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Logger)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.Thread)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogDreamsExtUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Log_Dreams_ExtUser");

            entity.Property(e => e.CellNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Department).HasMaxLength(200);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InsertedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.LogInsertedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LogInsertedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Region).HasMaxLength(200);
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Logdatacrit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGDATACRIT");

            entity.Property(e => e.Block).HasColumnName("BLOCK");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.ChangedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.PassChangedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ResidenceAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Logdatadirect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGDATADIRECT");

            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.ChangedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ContactDetailsEpms).HasColumnName("ContactDetailsEPMS");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(20)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<LoginDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmpNo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidatedThrough)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MasterHindi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MasterHindi");

            entity.Property(e => e.TextEn).HasMaxLength(200);
            entity.Property(e => e.TextHi).HasMaxLength(200);
        });

        modelBuilder.Entity<MasterLanguage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MasterLanguage");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LanguageEn).HasMaxLength(200);
            entity.Property(e => e.LanguageHi).HasMaxLength(200);
        });

        modelBuilder.Entity<MasterTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MasterTable");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Sorder).HasColumnName("SOrder");
            entity.Property(e => e.TextEnglish).HasMaxLength(200);
            entity.Property(e => e.TextHindi).HasMaxLength(200);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MaterialList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Material_list");

            entity.Property(e => e.Empno)
                .HasMaxLength(255)
                .HasColumnName("empno");
            entity.Property(e => e.Len).HasColumnName("len");
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<NerempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NEREmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<NlocationList>(entity =>
        {
            entity.HasKey(e => new { e.LocationName, e.RegionName }).HasName("PK_NLocationList_1");

            entity.ToTable("NLocationList");

            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.RegionName).HasMaxLength(40);
            entity.Property(e => e.LocationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationNameHi).HasMaxLength(50);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
        });

        modelBuilder.Entity<Nr2rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NR2RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Nr3rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NR3RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<NrempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NREmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<NrldcempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NRLDCEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<OdishaLocation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicyPerceptionSurvey>(entity =>
        {
            entity.HasKey(e => e.EmpNo);

            entity.ToTable("PolicyPerceptionSurvey");

            entity.HasIndex(e => e.Id, "UK_PolicyPerceptionSurvey").IsUnique();

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status).HasDefaultValue(1);
        });

        modelBuilder.Entity<PwdReset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pwd_Reset");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<PwdResetComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pwd_Reset_Complete");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.Otp).HasMaxLength(20);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<RecttRegionMaster>(entity =>
        {
            entity.HasKey(e => e.RegionCode);

            entity.ToTable("Rectt_RegionMaster");

            entity.Property(e => e.RegionCode).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Region).HasMaxLength(50);
        });

        modelBuilder.Entity<RegItCoord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REG_IT_COORD");

            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<RegionsList>(entity =>
        {
            entity.HasKey(e => new { e.RegionId, e.RegionName });

            entity.ToTable("RegionsList");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(40);
            entity.Property(e => e.RegionNameHi).HasMaxLength(50);
            entity.Property(e => e.RegionValue).HasMaxLength(40);
        });

        modelBuilder.Entity<RelBloodDonation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RelBloodDonation");

            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empdeptt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EMPDeptt");
            entity.Property(e => e.Empmob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPMob");
            entity.Property(e => e.Empname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EMPName");
            entity.Property(e => e.Empno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.RelAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RelBloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RelDisease)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RelDob)
                .HasColumnType("smalldatetime")
                .HasColumnName("RelDOB");
            entity.Property(e => e.RelLandLineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RelLastDonationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RelMobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RelativeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNo");
        });

        modelBuilder.Entity<SelfRorvooffr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SelfRORVOOFFR");

            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRADE");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REVIEWINGOFFR");
        });

        modelBuilder.Entity<Sr1rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SR1RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Sr2rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SR2RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Srdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SRData");

            entity.Property(e => e.EmpNo).HasMaxLength(200);
            entity.Property(e => e.Hometown)
                .HasMaxLength(500)
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<StateList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StateList");

            entity.Property(e => e.StateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("StateID");
            entity.Property(e => e.StateNameEn).HasMaxLength(50);
            entity.Property(e => e.StatenameHi).HasMaxLength(100);
        });

        modelBuilder.Entity<StatesByRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StatesByRegion");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<SupportUserResetPassLog>(entity =>
        {
            entity.ToTable("SupportUserResetPass_Log");

            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<SupportUserResetPassPermission>(entity =>
        {
            entity.ToTable("SupportUserResetPass_Permission");

            entity.Property(e => e.AuthorisedUserEmpno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AuthorisedUser_empno");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<TmpIds1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ids1");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Processid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("processid");
        });

        modelBuilder.Entity<Totp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TOtp");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
        });

        modelBuilder.Entity<TotpChangeLog>(entity =>
        {
            entity.ToTable("TotpChangeLog");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TrainingRegion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TrainingType).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TransferDataFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransferDataFinal");

            entity.Property(e => e.Block).HasColumnName("BLOCK");
            entity.Property(e => e.CoutersigningOfficer).HasMaxLength(255);
            entity.Property(e => e.DataCamefromRegion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Dept).HasMaxLength(255);
            entity.Property(e => e.DeptFrom).HasMaxLength(255);
            entity.Property(e => e.DeptTo).HasMaxLength(255);
            entity.Property(e => e.Designation).HasMaxLength(255);
            entity.Property(e => e.DojDept)
                .HasColumnType("datetime")
                .HasColumnName("DOJ_Dept");
            entity.Property(e => e.DojPlace)
                .HasColumnType("datetime")
                .HasColumnName("DOJ_Place");
            entity.Property(e => e.DojRegion)
                .HasColumnType("datetime")
                .HasColumnName("DOJ_Region");
            entity.Property(e => e.EmpDesg).HasMaxLength(255);
            entity.Property(e => e.EmpLevel).HasMaxLength(255);
            entity.Property(e => e.Empname).HasMaxLength(255);
            entity.Property(e => e.Empno)
                .HasMaxLength(255)
                .HasColumnName("empno");
            entity.Property(e => e.Hierarchy1).HasMaxLength(255);
            entity.Property(e => e.Hierarchy2).HasMaxLength(255);
            entity.Property(e => e.JxDept).HasMaxLength(255);
            entity.Property(e => e.JxLocn).HasMaxLength(255);
            entity.Property(e => e.JxOrderDate).HasColumnType("datetime");
            entity.Property(e => e.JxOrderNo).HasMaxLength(255);
            entity.Property(e => e.JxRegn).HasMaxLength(255);
            entity.Property(e => e.JxWefDate).HasColumnType("datetime");
            entity.Property(e => e.Level)
                .HasMaxLength(255)
                .HasColumnName("level");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LocnFrom).HasMaxLength(255);
            entity.Property(e => e.LocnTo).HasMaxLength(255);
            entity.Property(e => e.OldReportingOfficer)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.RegnFrom).HasMaxLength(255);
            entity.Property(e => e.RegnTo).HasMaxLength(255);
            entity.Property(e => e.RepDtFrm).HasColumnType("datetime");
            entity.Property(e => e.ReportingOfficer).HasMaxLength(255);
            entity.Property(e => e.ReviewingOfficer).HasMaxLength(255);
            entity.Property(e => e.RxOrderDate).HasColumnType("datetime");
            entity.Property(e => e.RxOrderNo).HasMaxLength(255);
            entity.Property(e => e.RxwefDate).HasColumnType("datetime");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("sno");
            entity.Property(e => e.TxAuthority).HasMaxLength(255);
            entity.Property(e => e.TxOrderDate).HasColumnType("datetime");
            entity.Property(e => e.TxOrderNo).HasMaxLength(255);
            entity.Property(e => e.TxStatus).HasMaxLength(255);
            entity.Property(e => e.TxwefDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UserDet");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Block).HasColumnName("BLOCK");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Expr2)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Posting)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("POSTING");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Scalemax)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("SCALEMAX");
            entity.Property(e => e.Scalemin)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("SCALEMIN");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UserDetail");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VActiveUserDetailsWith8DigitEmpNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vActiveUserDetailsWith8DigitEmpNo");

            entity.Property(e => e.AadharNumber)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Basicpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BASICPAY");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empimgguid).HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Oldlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDLOCATION");
            entity.Property(e => e.Oldregion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDREGION");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Perspay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PERSPAY");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Railwaystation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RAILWAYSTATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Responsibilities)
                .HasColumnType("text")
                .HasColumnName("RESPONSIBILITIES");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Salaryaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYACCOUNT");
            entity.Property(e => e.Salarybank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYBANK");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.Transferredto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANSFERREDTO");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<VActiveUserdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vActiveUserdetails");

            entity.Property(e => e.AadharNumber)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Basicpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BASICPAY");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empimgguid).HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Oldlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDLOCATION");
            entity.Property(e => e.Oldregion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDREGION");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Perspay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PERSPAY");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Railwaystation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RAILWAYSTATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Responsibilities)
                .HasColumnType("text")
                .HasColumnName("RESPONSIBILITIES");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Salaryaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYACCOUNT");
            entity.Property(e => e.Salarybank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYBANK");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.Transferredto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANSFERREDTO");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<VActiveUsersForVaartum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vActiveUsersForVaarta");

            entity.Property(e => e.AadharNumber)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Basicpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BASICPAY");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Expr1).HasMaxLength(10);
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Oldlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDLOCATION");
            entity.Property(e => e.Oldregion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDREGION");
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.Perspay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PERSPAY");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Railwaystation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RAILWAYSTATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.ReportingEmail).HasMaxLength(50);
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Responsibilities)
                .HasColumnType("text")
                .HasColumnName("RESPONSIBILITIES");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Salaryaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYACCOUNT");
            entity.Property(e => e.Salarybank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYBANK");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Transferredto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANSFERREDTO");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<VAllUserDetailsWith8DigitEmpNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAllUserDetailsWith8DigitEmpNo");

            entity.Property(e => e.AadharNumber).HasMaxLength(50);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Basicpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BASICPAY");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empimgguid).HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Oldlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDLOCATION");
            entity.Property(e => e.Oldregion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDREGION");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Perspay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PERSPAY");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Railwaystation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RAILWAYSTATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Responsibilities)
                .HasColumnType("text")
                .HasColumnName("RESPONSIBILITIES");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Salaryaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYACCOUNT");
            entity.Property(e => e.Salarybank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYBANK");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.Transferredto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANSFERREDTO");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<VAttdView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAttdView");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCcRhqList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vCcRhqList");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.LocationNameHi).HasMaxLength(50);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(40);
            entity.Property(e => e.RegionNameHi).HasMaxLength(50);
            entity.Property(e => e.RegionValue).HasMaxLength(40);
        });

        modelBuilder.Entity<VDreamsUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vDreamsUser");

            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(200)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(200)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(200)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Region)
                .HasMaxLength(200)
                .HasColumnName("REGION");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<VE1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vE1");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
        });

        modelBuilder.Entity<VGetUserDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vGetUserDetails");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.ContactDetailsEpms).HasColumnName("ContactDetailsEPMS");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Updat)
                .HasColumnType("datetime")
                .HasColumnName("UPDAT");
            entity.Property(e => e.Updfrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDFROM");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VHindiDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vHindiData");

            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.LatestCourseName).HasMaxLength(200);
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Message).HasMaxLength(800);
            entity.Property(e => e.MotherLanguage).HasMaxLength(50);
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Parangat).HasMaxLength(200);
            entity.Property(e => e.ParangatYesNo).HasMaxLength(10);
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.SubmissionFinYear)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.WorkingKnowledgePercent).HasMaxLength(100);
        });

        modelBuilder.Entity<VItcoordinator>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vITCoordinators");

            entity.Property(e => e.CellNo).HasMaxLength(50);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Ss)
                .HasMaxLength(50)
                .HasColumnName("SS");
        });

        modelBuilder.Entity<VQlikReportingHierarchy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vQlikReportingHierarchy");

            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
        });

        modelBuilder.Entity<VRtiUserList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vRtiUserList");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
        });

        modelBuilder.Entity<VSupportUserAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vSupportUserAdmin");

            entity.Property(e => e.AuthorisedUserEmpno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AuthorisedUser_empno");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VSupportUserPasswordChangeLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vSupportUserPasswordChangeLog");

            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.EightDigitEmpNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<VTttt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vTTTT");

            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
        });

        modelBuilder.Entity<VUserDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vUserDetails");

            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTINGOFFR");
        });

        modelBuilder.Entity<VYe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vYes");

            entity.Property(e => e.Email).HasMaxLength(2000);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<VactiveEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VActiveEmployees");

            entity.Property(e => e.AadharNumber)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.Empimgguid).HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.ResidenceAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VallEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VAllEmployee");

            entity.Property(e => e.AadharNumber).HasMaxLength(50);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Basicpay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BASICPAY");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CounterSigningOffr).HasMaxLength(10);
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpStatusChangedBy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empimgguid).HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.EpmsPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epmsPass");
            entity.Property(e => e.EpmsReportingOffr).HasMaxLength(10);
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hometown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOMETOWN");
            entity.Property(e => e.Ipphone).HasColumnName("IPPhone");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsHradmin).HasColumnName("IsHRAdmin");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Lanid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LANID");
            entity.Property(e => e.Lefton)
                .HasColumnType("smalldatetime")
                .HasColumnName("LEFTON");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Officeseat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OFFICESEAT");
            entity.Property(e => e.Oldlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDLOCATION");
            entity.Property(e => e.Oldregion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OLDREGION");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ou)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OU");
            entity.Property(e => e.PassChangedAt).HasColumnType("smalldatetime");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Perspay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PERSPAY");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Railwaystation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RAILWAYSTATION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.ReportingDateTo).HasColumnType("datetime");
            entity.Property(e => e.ReportingDatefrom).HasColumnType("datetime");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencecity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIDENCECITY");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Responsibilities)
                .HasColumnType("text")
                .HasColumnName("RESPONSIBILITIES");
            entity.Property(e => e.ReviewingOffr2).HasMaxLength(10);
            entity.Property(e => e.ReviewingOffr3).HasMaxLength(10);
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Salaryaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYACCOUNT");
            entity.Property(e => e.Salarybank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALARYBANK");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SECTION");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.Transferredto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANSFERREDTO");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<VallEmployee1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VAllEmployees");

            entity.Property(e => e.AadharNumber).HasMaxLength(50);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddOrg)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.CurState).HasMaxLength(200);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DoReg).HasColumnName("DoREG");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.Empimgguid).HasColumnName("EMPIMGGUID");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.ExitDate).HasColumnName("Exit_Date");
            entity.Property(e => e.ExitReason)
                .HasMaxLength(50)
                .HasColumnName("Exit_Reason");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.IsExServiceMan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Is_Ex_Service_Man");
            entity.Property(e => e.IsO365user).HasColumnName("IsO365User");
            entity.Property(e => e.JobDisc)
                .HasMaxLength(50)
                .HasColumnName("Job_Disc");
            entity.Property(e => e.Location)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Ltadet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTADET");
            entity.Property(e => e.MainDisc)
                .HasMaxLength(50)
                .HasColumnName("Main_Disc");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.O365license)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O365License");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.OrgGrp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgUnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.PersonalArea)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.PwdCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pwd_Categ");
            entity.Property(e => e.PwdSubCateg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pwd_SubCateg");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Residenceaddress)
                .HasMaxLength(500)
                .HasColumnName("RESIDENCEADDRESS");
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOtpSecret");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VcDetail>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("VC_Details");

            entity.Property(e => e.EmpId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("EMP_ID");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.VcId)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("VC_ID");
        });

        modelBuilder.Entity<VcarDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VCarDetails");

            entity.Property(e => e.AlterNateNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alterNateNo");
            entity.Property(e => e.DateOfIssue).HasColumnType("datetime");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EMPNo");
            entity.Property(e => e.EmporNonEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPorNonEmp");
            entity.Property(e => e.Expr1)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Expr3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MakeVehicle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameofPassHolder)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PassSno).HasColumnName("PassSNo");
            entity.Property(e => e.ReferencedEmpno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferencedEMPNO");
            entity.Property(e => e.RegNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegNo1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNO");
            entity.Property(e => e.VehicleType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VendorTraining>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrainingRegion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TrainingType).HasMaxLength(500);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<VexEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VExEmployees");

            entity.Property(e => e.AadharNumber).HasMaxLength(50);
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Doeg)
                .HasColumnType("datetime")
                .HasColumnName("DOEG");
            entity.Property(e => e.Emode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.EmpPass).HasMaxLength(500);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officephoneno)
                .HasMaxLength(60)
                .HasColumnName("OFFICEPHONENO");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pdoeg).HasColumnName("PDoeg");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.PhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Previousgrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREVIOUSGRADE");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.ResidenceAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Residencephoneno)
                .HasMaxLength(60)
                .HasColumnName("RESIDENCEPHONENO");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.SeparationCause).HasMaxLength(2);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VigSize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VigSize");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Size)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VigTshirtElegibleEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VigTShirtElegibleEmployee");

            entity.Property(e => e.EmployeeNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Wr1rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WR1RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<Wr2rhqempList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WR2RHQEmpList");

            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOODGROUP");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .HasColumnName("CELLNO");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.EmpNameHi).HasMaxLength(200);
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Empno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Empstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPSTATE");
            entity.Property(e => e.Extemail)
                .HasMaxLength(50)
                .HasColumnName("EXTEMAIL");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mars)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARS");
            entity.Property(e => e.Officeraxno)
                .HasMaxLength(20)
                .HasColumnName("OFFICERAXNO");
            entity.Property(e => e.Pgemail)
                .HasMaxLength(50)
                .HasColumnName("PGEMAIL");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POSITION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Reportingoffr)
                .HasMaxLength(10)
                .HasColumnName("REPORTINGOFFR");
            entity.Property(e => e.Reviewingoffr)
                .HasMaxLength(10)
                .HasColumnName("REVIEWINGOFFR");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<WsQuery>(entity =>
        {
            entity.ToTable("WsQuery");

            entity.Property(e => e.Query)
                .HasMaxLength(4000)
                .HasColumnName("query");
            entity.Property(e => e.QueryOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<X12121212>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X12121212");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<X2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X2");

            entity.Property(e => e.Empno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<X25>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X25");

            entity.Property(e => e.CellNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExtEmail)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PgEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<X9009>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X9009");

            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<XEmpEpfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X_Emp_Epfo");

            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Eps)
                .HasMaxLength(100)
                .HasColumnName("EPS");
            entity.Property(e => e.FatherName).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Uan)
                .HasMaxLength(100)
                .HasColumnName("UAN");
        });

        modelBuilder.Entity<XEmpEpfo2018>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X_Emp_Epfo_2018");

            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Eps)
                .HasMaxLength(100)
                .HasColumnName("EPS");
            entity.Property(e => e.FatherName).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Uan)
                .HasMaxLength(100)
                .HasColumnName("UAN");
        });

        modelBuilder.Entity<XEmpEpfo2019>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("X_Emp_Epfo_2019");

            entity.Property(e => e.EmpName).HasMaxLength(200);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Eps)
                .HasMaxLength(100)
                .HasColumnName("EPS");
            entity.Property(e => e.FatherName).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Uan)
                .HasMaxLength(100)
                .HasColumnName("UAN");
        });

        modelBuilder.Entity<Z1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z1");

            entity.Property(e => e.Email).HasMaxLength(2000);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<Z2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z2");

            entity.Property(e => e.Empno)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Z33>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z33");

            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Z9090>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z9090");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Pran)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRAN");
        });

        modelBuilder.Entity<ZEmpUanMemDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z_EmpUanMemData");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MemberId).HasMaxLength(255);
            entity.Property(e => e.Uan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UAN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
