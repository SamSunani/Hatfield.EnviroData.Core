//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatfield.EnviroData.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class CalibrationStandard
    {
        public int BridgeID { get; set; }
        public int ActionID { get; set; }
        public int ReferenceMaterialID { get; set; }
    
        public virtual CalibrationAction CalibrationAction { get; set; }
        public virtual ReferenceMaterial ReferenceMaterial { get; set; }
    }
}
