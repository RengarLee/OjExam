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
    
    public partial class Problem
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public string Answer { get; set; }
        public int KnowPointId { get; set; }
        public string Status { get; set; }
        public string Rank { get; set; }
        public short DelFlag { get; set; }
    
        public virtual KnowPoint KnowPointSet { get; set; }
    }
}
