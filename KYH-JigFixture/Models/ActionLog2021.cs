//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KYH_JigFixture.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActionLog2021
    {
        public int LogID { get; set; }
        public string UserID { get; set; }
        public string DeptID { get; set; }
        public short FunctionID { get; set; }
        public string ActionType { get; set; }
        public System.DateTime ActionTime { get; set; }
        public string TableName { get; set; }
        public string TableKey { get; set; }
        public string Description { get; set; }
    }
}