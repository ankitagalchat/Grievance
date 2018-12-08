namespace Griveance.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class GRContext : DbContext
	{
		public GRContext()
			: base("name=GRContext")
		{
		}

		public virtual DbSet<tbl_class> tbl_class { get; set; }
		public virtual DbSet<tbl_complaintdetails> tbl_complaintdetails { get; set; }
		public virtual DbSet<tbl_courses> tbl_courses { get; set; }
		public virtual DbSet<tbl_grievance_list> tbl_grievance_list { get; set; }
		public virtual DbSet<tbl_member> tbl_member { get; set; }
		public virtual DbSet<tbl_rpt> tbl_rpt { get; set; }									   
		public virtual DbSet<tbl_emailsettings> tbl_emailsettings { get; set; }
		public virtual DbSet<tbl_faculty> tbl_faculty { get; set; }
		public virtual DbSet<tbl_parent> tbl_parent { get; set; }
		public virtual DbSet<tbl_postgriev> tbl_postgriev { get; set; }
		public virtual DbSet<tbl_staff> tbl_staff { get; set; }
		public virtual DbSet<tbl_student> tbl_student { get; set; }
		public virtual DbSet<tbl_test> tbl_test { get; set; }
		public virtual DbSet<tbl_user> tbl_user { get; set; }								     

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{ 

		}
	}
}