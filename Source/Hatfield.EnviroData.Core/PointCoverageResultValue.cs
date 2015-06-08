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
    
    public partial class PointCoverageResultValue
    {
        public PointCoverageResultValue()
        {
            this.PointCoverageResultValueAnnotations = new HashSet<PointCoverageResultValueAnnotation>();
        }
    
        public long ValueID { get; set; }
        public long ResultID { get; set; }
        public long DataValue { get; set; }
        public System.DateTime ValueDateTime { get; set; }
        public int ValueDateTimeUTCOffset { get; set; }
        public double XLocation { get; set; }
        public int XLocationUnitsID { get; set; }
        public double YLocation { get; set; }
        public int YLocationUnitsID { get; set; }
        public string CensorCodeCV { get; set; }
        public string QualityCodeCV { get; set; }
    
        public virtual CV_CensorCode CV_CensorCode { get; set; }
        public virtual CV_QualityCode CV_QualityCode { get; set; }
        public virtual PointCoverageResult PointCoverageResult { get; set; }
        public virtual ICollection<PointCoverageResultValueAnnotation> PointCoverageResultValueAnnotations { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
    }
}
