﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmptyConsole.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShuHuaDbEntities : DbContext
    {
        public ShuHuaDbEntities()
            : base("name=ShuHuaDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AreaTable> AreaTable { get; set; }
        public DbSet<ArticleTable> ArticleTable { get; set; }
        public DbSet<ArticleTypeTable> ArticleTypeTable { get; set; }
        public DbSet<AttendanceTable> AttendanceTable { get; set; }
        public DbSet<AttentionTable> AttentionTable { get; set; }
        public DbSet<AuditionActivityTable> AuditionActivityTable { get; set; }
        public DbSet<AuditionRecordTable> AuditionRecordTable { get; set; }
        public DbSet<BalanceRecordTable> BalanceRecordTable { get; set; }
        public DbSet<BankCardTransferTable> BankCardTransferTable { get; set; }
        public DbSet<BannerTable> BannerTable { get; set; }
        public DbSet<ChangeClassSnapshot> ChangeClassSnapshot { get; set; }
        public DbSet<ChangeClassTable> ChangeClassTable { get; set; }
        public DbSet<ChannelTable> ChannelTable { get; set; }
        public DbSet<ChannelTypeTable> ChannelTypeTable { get; set; }
        public DbSet<ChatStatusTable> ChatStatusTable { get; set; }
        public DbSet<ChatTable> ChatTable { get; set; }
        public DbSet<Class_Time_Teacher_ChangeTable> Class_Time_Teacher_ChangeTable { get; set; }
        public DbSet<Class_Time_TeacherTable> Class_Time_TeacherTable { get; set; }
        public DbSet<Class_TimeTable> Class_TimeTable { get; set; }
        public DbSet<ClassRelationTable> ClassRelationTable { get; set; }
        public DbSet<ClassRoomTable> ClassRoomTable { get; set; }
        public DbSet<ClassTable> ClassTable { get; set; }
        public DbSet<CollectTable> CollectTable { get; set; }
        public DbSet<CommentTable> CommentTable { get; set; }
        public DbSet<CompusAreaTable> CompusAreaTable { get; set; }
        public DbSet<CompusTable> CompusTable { get; set; }
        public DbSet<ConfigTable> ConfigTable { get; set; }
        public DbSet<ConsultFollowTable> ConsultFollowTable { get; set; }
        public DbSet<ConsultLogTable> ConsultLogTable { get; set; }
        public DbSet<ConsultTable> ConsultTable { get; set; }
        public DbSet<ConsultTransferTable> ConsultTransferTable { get; set; }
        public DbSet<Course_TypeTable> Course_TypeTable { get; set; }
        public DbSet<CourseActiveTable> CourseActiveTable { get; set; }
        public DbSet<CoursePriceTable> CoursePriceTable { get; set; }
        public DbSet<CourseTable> CourseTable { get; set; }
        public DbSet<CoursewareAdjunctTable> CoursewareAdjunctTable { get; set; }
        public DbSet<CoursewareDecipheringTable> CoursewareDecipheringTable { get; set; }
        public DbSet<CoursewareTable> CoursewareTable { get; set; }
        public DbSet<CurrentSchoolTable> CurrentSchoolTable { get; set; }
        public DbSet<DepartmentTable> DepartmentTable { get; set; }
        public DbSet<FriendApplyTable> FriendApplyTable { get; set; }
        public DbSet<FriendRelationTable> FriendRelationTable { get; set; }
        public DbSet<JobTable> JobTable { get; set; }
        public DbSet<LeaveRecordTable> LeaveRecordTable { get; set; }
        public DbSet<MakeUpClassTable> MakeUpClassTable { get; set; }
        public DbSet<MaterialOrderTable> MaterialOrderTable { get; set; }
        public DbSet<MaterialTable> MaterialTable { get; set; }
        public DbSet<MessageStatusTable> MessageStatusTable { get; set; }
        public DbSet<MessageTable> MessageTable { get; set; }
        public DbSet<NotifyTable> NotifyTable { get; set; }
        public DbSet<OrderTable> OrderTable { get; set; }
        public DbSet<PayTable> PayTable { get; set; }
        public DbSet<PrivateMessageTable> PrivateMessageTable { get; set; }
        public DbSet<ProductUserActiveTable> ProductUserActiveTable { get; set; }
        public DbSet<ProductUserTable> ProductUserTable { get; set; }
        public DbSet<ReaderTable> ReaderTable { get; set; }
        public DbSet<RecruitAddressTable> RecruitAddressTable { get; set; }
        public DbSet<RefundSnapShot> RefundSnapShot { get; set; }
        public DbSet<RefundTable> RefundTable { get; set; }
        public DbSet<RepaymentTable> RepaymentTable { get; set; }
        public DbSet<Role_ItemTable> Role_ItemTable { get; set; }
        public DbSet<Role_ModuleTable> Role_ModuleTable { get; set; }
        public DbSet<Role_PermissionTable> Role_PermissionTable { get; set; }
        public DbSet<RoleTable> RoleTable { get; set; }
        public DbSet<SignUpOrder_Edit_Table> SignUpOrder_Edit_Table { get; set; }
        public DbSet<SignUpOrderOffTable> SignUpOrderOffTable { get; set; }
        public DbSet<SignUpOrderTable> SignUpOrderTable { get; set; }
        public DbSet<Staff_ImportRecordTable> Staff_ImportRecordTable { get; set; }
        public DbSet<StaffActiveTable> StaffActiveTable { get; set; }
        public DbSet<StaffCompusTable> StaffCompusTable { get; set; }
        public DbSet<StaffMsgStatusTable> StaffMsgStatusTable { get; set; }
        public DbSet<StaffMsgTable> StaffMsgTable { get; set; }
        public DbSet<StaffTable> StaffTable { get; set; }
        public DbSet<StaffTask> StaffTask { get; set; }
        public DbSet<StatisticsTable> StatisticsTable { get; set; }
        public DbSet<StudentCourseImport> StudentCourseImport { get; set; }
        public DbSet<StudentCourseTable> StudentCourseTable { get; set; }
        public DbSet<StudentTable> StudentTable { get; set; }
        public DbSet<StuffTable> StuffTable { get; set; }
        public DbSet<SuspendTable> SuspendTable { get; set; }
        public DbSet<ThumbsUpTable> ThumbsUpTable { get; set; }
        public DbSet<UserCollectTable> UserCollectTable { get; set; }
        public DbSet<UserConsultQuestionTable> UserConsultQuestionTable { get; set; }
        public DbSet<UserMessageAcceptTable> UserMessageAcceptTable { get; set; }
        public DbSet<UserMessagePushTable> UserMessagePushTable { get; set; }
        public DbSet<UserTable> UserTable { get; set; }
        public DbSet<WebSetTable> WebSetTable { get; set; }
        public DbSet<WorkEvaluateTable> WorkEvaluateTable { get; set; }
        public DbSet<WorkTable> WorkTable { get; set; }
        public DbSet<WorkTagMapTable> WorkTagMapTable { get; set; }
        public DbSet<WorkTagTable> WorkTagTable { get; set; }
        public DbSet<Area_UpdateTable> Area_UpdateTable { get; set; }
        public DbSet<ConsultDeleteTable> ConsultDeleteTable { get; set; }
        public DbSet<Courseware_OpinionTable> Courseware_OpinionTable { get; set; }
        public DbSet<Material_ImportRecord> Material_ImportRecord { get; set; }
        public DbSet<Role_Permission_ImportTable> Role_Permission_ImportTable { get; set; }
        public DbSet<TempPermission> TempPermission { get; set; }
    }
}
