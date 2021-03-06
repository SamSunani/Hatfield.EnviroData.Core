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
    
    public partial class Annotation
    {
        public Annotation()
        {
            this.ActionAnnotations = new HashSet<ActionAnnotation>();
            this.CategoricalResultValueAnnotations = new HashSet<CategoricalResultValueAnnotation>();
            this.EquipmentAnnotations = new HashSet<EquipmentAnnotation>();
            this.MethodAnnotations = new HashSet<MethodAnnotation>();
            this.PointCoverageResultValueAnnotations = new HashSet<PointCoverageResultValueAnnotation>();
            this.ProfileResultValueAnnotations = new HashSet<ProfileResultValueAnnotation>();
            this.RelatedAnnotations = new HashSet<RelatedAnnotation>();
            this.RelatedAnnotations1 = new HashSet<RelatedAnnotation>();
            this.ResultAnnotations = new HashSet<ResultAnnotation>();
            this.MeasurementResultValueAnnotations = new HashSet<MeasurementResultValueAnnotation>();
            this.SamplingFeatureAnnotations = new HashSet<SamplingFeatureAnnotation>();
            this.SectionResultValueAnnotations = new HashSet<SectionResultValueAnnotation>();
            this.SpectraResultValueAnnotations = new HashSet<SpectraResultValueAnnotation>();
            this.TimeSeriesResultValueAnnotations = new HashSet<TimeSeriesResultValueAnnotation>();
            this.TrajectoryResultValueAnnotations = new HashSet<TrajectoryResultValueAnnotation>();
            this.TransectResultValueAnnotations = new HashSet<TransectResultValueAnnotation>();
        }
    
        public int AnnotationID { get; set; }
        public string AnnotationTypeCV { get; set; }
        public string AnnotationCode { get; set; }
        public string AnnotationText { get; set; }
        public Nullable<System.DateTime> AnnotationDateTime { get; set; }
        public Nullable<int> AnnotationUTCOffset { get; set; }
        public string AnnotationLink { get; set; }
        public Nullable<int> AnnotatorID { get; set; }
        public Nullable<int> CitationID { get; set; }
    
        public virtual ICollection<ActionAnnotation> ActionAnnotations { get; set; }
        public virtual Citation Citation { get; set; }
        public virtual CV_AnnotationType CV_AnnotationType { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<CategoricalResultValueAnnotation> CategoricalResultValueAnnotations { get; set; }
        public virtual ICollection<EquipmentAnnotation> EquipmentAnnotations { get; set; }
        public virtual ICollection<MethodAnnotation> MethodAnnotations { get; set; }
        public virtual ICollection<PointCoverageResultValueAnnotation> PointCoverageResultValueAnnotations { get; set; }
        public virtual ICollection<ProfileResultValueAnnotation> ProfileResultValueAnnotations { get; set; }
        public virtual ICollection<RelatedAnnotation> RelatedAnnotations { get; set; }
        public virtual ICollection<RelatedAnnotation> RelatedAnnotations1 { get; set; }
        public virtual ICollection<ResultAnnotation> ResultAnnotations { get; set; }
        public virtual ICollection<MeasurementResultValueAnnotation> MeasurementResultValueAnnotations { get; set; }
        public virtual ICollection<SamplingFeatureAnnotation> SamplingFeatureAnnotations { get; set; }
        public virtual ICollection<SectionResultValueAnnotation> SectionResultValueAnnotations { get; set; }
        public virtual ICollection<SpectraResultValueAnnotation> SpectraResultValueAnnotations { get; set; }
        public virtual ICollection<TimeSeriesResultValueAnnotation> TimeSeriesResultValueAnnotations { get; set; }
        public virtual ICollection<TrajectoryResultValueAnnotation> TrajectoryResultValueAnnotations { get; set; }
        public virtual ICollection<TransectResultValueAnnotation> TransectResultValueAnnotations { get; set; }
    }
}
