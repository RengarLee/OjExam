//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OjExam.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KnowPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KnowPoint()
        {
            this.Problem = new HashSet<Problem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public int CourserId { get; set; }
        public string Status { get; set; }
        public short DelFlag { get; set; }
    
        public virtual Courser Courser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problem { get; set; }
    }
}