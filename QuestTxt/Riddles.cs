//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuestTxt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Riddles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Riddles()
        {
            this.Levels = new HashSet<Levels>();
        }
    
        public int riddleID { get; set; }
        public string correctAnswer { get; set; }
        public Nullable<int> nextLevelID { get; set; }
        public Nullable<int> failureNextLevelID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Levels> Levels { get; set; }
        public virtual Levels Levels1 { get; set; }
    }
}
