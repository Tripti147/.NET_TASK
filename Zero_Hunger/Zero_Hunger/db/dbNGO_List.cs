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
    using System.ComponentModel.DataAnnotations;

    public partial class dbNGO_List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbNGO_List()
        {
            this.dbDISTRIBUTION_List = new HashSet<dbDISTRIBUTION_List>();
            this.dbEMPLOYEE_List = new HashSet<dbEMPLOYEE_List>();
            this.dbTRACKCOLLECTION_List = new HashSet<dbTRACKCOLLECTION_List>();
            this.NGO_RESTAURENT = new HashSet<NGO_RESTAURENT>();
        }
    
        public int NGO_ID { get; set; }

        [Required(ErrorMessage = "Required")]
        public string NGO_NAME { get; set; }

        [Required(ErrorMessage = "Required")]
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbDISTRIBUTION_List> dbDISTRIBUTION_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbEMPLOYEE_List> dbEMPLOYEE_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbTRACKCOLLECTION_List> dbTRACKCOLLECTION_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGO_RESTAURENT> NGO_RESTAURENT { get; set; }
        public string RESTAURENT_NAME { get; internal set; }

        internal static object Where(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}