//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TotalStaffingSolutions.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timesheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Timesheet()
        {
            this.Timesheet_summaries = new HashSet<Timesheet_summaries>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Customer_id { get; set; }
        public Nullable<int> Organization_id { get; set; }
        public Nullable<System.DateTime> Start_date { get; set; }
        public Nullable<System.DateTime> End_date { get; set; }
        public Nullable<int> Total_employees { get; set; }
        public Nullable<double> Total_hours { get; set; }
        public Nullable<bool> Submit_by_client { get; set; }
        public string Uuid { get; set; }
        public string Signature { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
        public string Note { get; set; }
        public string Po_number { get; set; }
        public Nullable<bool> Sent { get; set; }
        public Nullable<bool> For_internal_employee { get; set; }
        public Nullable<int> Status_id { get; set; }
        public string Customer_Id_Generic { get; set; }
        public string Created_By { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Timesheet_summaries> Timesheet_summaries { get; set; }
        public virtual TimeSheetStatu TimeSheetStatu { get; set; }
    }
}
