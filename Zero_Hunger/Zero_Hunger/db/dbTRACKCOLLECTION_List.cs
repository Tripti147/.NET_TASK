//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero_Hunger.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbTRACKCOLLECTION_List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbTRACKCOLLECTION_List()
        {
            this.dbDISTRIBUTION_List = new HashSet<dbDISTRIBUTION_List>();
            this.dbFOODITEM_List = new HashSet<dbFOODITEM_List>();
            this.dbRESTAURENT_List = new HashSet<dbRESTAURENT_List>();
        }
    
        public int COLLECTREQUEST_ID { get; set; }
        public Nullable<int> NGO_ID { get; set; }
        public Nullable<int> RESTAURENT_ID { get; set; }
        public Nullable<int> FOOD_ID { get; set; }
        public Nullable<int> EMPLOYEE_ID { get; set; }
        public Nullable<int> DISTRIBUTION_ID { get; set; }
        public string STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbDISTRIBUTION_List> dbDISTRIBUTION_List { get; set; }
        public virtual dbDISTRIBUTION_List dbDISTRIBUTION_List1 { get; set; }
        public virtual dbEMPLOYEE_List dbEMPLOYEE_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbFOODITEM_List> dbFOODITEM_List { get; set; }
        public virtual dbFOODITEM_List dbFOODITEM_List1 { get; set; }
        public virtual dbNGO_List dbNGO_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbRESTAURENT_List> dbRESTAURENT_List { get; set; }
        public virtual dbRESTAURENT_List dbRESTAURENT_List1 { get; set; }
    }
}
