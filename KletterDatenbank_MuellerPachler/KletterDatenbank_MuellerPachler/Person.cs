//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KletterDatenbank_MuellerPachler
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.ZOT_Durchstiegsliste = new HashSet<ZOT_Durchstiegsliste>();
            this.ZOT_Wunschliste = new HashSet<ZOT_Wunschliste>();
        }
    
        public int ID_Person { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public System.DateTime Geburtsdatum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZOT_Durchstiegsliste> ZOT_Durchstiegsliste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZOT_Wunschliste> ZOT_Wunschliste { get; set; }
    }
}
