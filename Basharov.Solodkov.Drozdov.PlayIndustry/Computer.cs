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
    
    public partial class Computer
    {
        public int IdComputer { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> IdPlayRoom { get; set; }
        public Nullable<int> IdCustomer { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual PlayRoom PlayRoom { get; set; }
    }
}
