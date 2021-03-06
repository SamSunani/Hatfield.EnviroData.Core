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
    
    public partial class CV_CensorCode
    {
        public CV_CensorCode()
        {
            this.MeasurementResults = new HashSet<MeasurementResult>();
            this.PointCoverageResultValues = new HashSet<PointCoverageResultValue>();
            this.ProfileResultValues = new HashSet<ProfileResultValue>();
            this.SectionResultValues = new HashSet<SectionResultValue>();
            this.SpectraResultValues = new HashSet<SpectraResultValue>();
            this.TimeSeriesResultValues = new HashSet<TimeSeriesResultValue>();
            this.TrajectoryResultValues = new HashSet<TrajectoryResultValue>();
            this.TransectResultValues = new HashSet<TransectResultValue>();
        }
    
        public string Term { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public string Category { get; set; }
        public string SourceVocabularyURI { get; set; }
    
        public virtual ICollection<MeasurementResult> MeasurementResults { get; set; }
        public virtual ICollection<PointCoverageResultValue> PointCoverageResultValues { get; set; }
        public virtual ICollection<ProfileResultValue> ProfileResultValues { get; set; }
        public virtual ICollection<SectionResultValue> SectionResultValues { get; set; }
        public virtual ICollection<SpectraResultValue> SpectraResultValues { get; set; }
        public virtual ICollection<TimeSeriesResultValue> TimeSeriesResultValues { get; set; }
        public virtual ICollection<TrajectoryResultValue> TrajectoryResultValues { get; set; }
        public virtual ICollection<TransectResultValue> TransectResultValues { get; set; }
    }
}
