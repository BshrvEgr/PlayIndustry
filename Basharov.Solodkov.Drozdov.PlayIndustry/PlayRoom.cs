//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Basharov.Solodkov.Drozdov.PlayIndustry
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlayRoom()
        {
            this.Computer = new HashSet<Computer>();
        }
    
        public int IdRoom { get; set; }
        public Nullable<int> CountComputers { get; set; }
        public Nullable<int> FreeComputers { get; set; }
        public Nullable<int> BusyComputers { get; set; }
        public Nullable<int> IdPlayBuild { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Computer> Computer { get; set; }
        public virtual PlayBuilds PlayBuilds { get; set; }
    }
}