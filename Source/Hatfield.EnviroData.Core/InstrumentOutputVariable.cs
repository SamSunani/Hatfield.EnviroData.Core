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
    
    public partial class InstrumentOutputVariable
    {
        public InstrumentOutputVariable()
        {
            this.CalibrationActions = new HashSet<CalibrationAction>();
            this.DataloggerFileColumns = new HashSet<DataloggerFileColumn>();
        }
    
        public int InstrumentOutputVariableID { get; set; }
        public int ModelID { get; set; }
        public int VariableID { get; set; }
        public int InstrumentMethodID { get; set; }
        public string InstrumentResolution { get; set; }
        public string InstrumentAccuracy { get; set; }
        public int InstrumentRawOutputUnitsID { get; set; }
    
        public virtual ICollection<CalibrationAction> CalibrationActions { get; set; }
        public virtual ICollection<DataloggerFileColumn> DataloggerFileColumns { get; set; }
        public virtual EquipmentModel EquipmentModel { get; set; }
        public virtual Method Method { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Variable Variable { get; set; }
    }
}
