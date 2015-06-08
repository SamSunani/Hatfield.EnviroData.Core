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
    
    public partial class TrajectoryResultValue
    {
        public TrajectoryResultValue()
        {
            this.TrajectoryResultValueAnnotations = new HashSet<TrajectoryResultValueAnnotation>();
        }
    
        public long ValueID { get; set; }
        public long ResultID { get; set; }
        public double DataValue { get; set; }
        public System.DateTime ValueDateTime { get; set; }
        public int ValueDateTimeUTCOffset { get; set; }
        public double XLocation { get; set; }
        public int XLocationUnitsID { get; set; }
        public double YLocation { get; set; }
        public int YLocationUnitsID { get; set; }
        public double ZLocation { get; set; }
        public int ZLocationUnitsID { get; set; }
        public double TrajectoryDistance { get; set; }
        public double TrajectoryDistanceAggregationInterval { get; set; }
        public int TrajectoryDistanceUnitsID { get; set; }
        public string CensorCodeCV { get; set; }
        public string QualityCodeCV { get; set; }
        public double TimeAggregationInterval { get; set; }
        public int TimeAggregationIntervalUnitsID { get; set; }
    
        public virtual CV_CensorCode CV_CensorCode { get; set; }
        public virtual CV_QualityCode CV_QualityCode { get; set; }
        public virtual TrajectoryResult TrajectoryResult { get; set; }
        public virtual ICollection<TrajectoryResultValueAnnotation> TrajectoryResultValueAnnotations { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual Unit Unit2 { get; set; }
        public virtual Unit Unit3 { get; set; }
        public virtual Unit Unit4 { get; set; }
    }
}
