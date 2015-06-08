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
    
    public partial class Equipment
    {
        public Equipment()
        {
            this.CalibrationReferenceEquipments = new HashSet<CalibrationReferenceEquipment>();
            this.EquipmentUseds = new HashSet<EquipmentUsed>();
            this.EquipmentAnnotations = new HashSet<EquipmentAnnotation>();
            this.RelatedEquipments = new HashSet<RelatedEquipment>();
            this.RelatedEquipments1 = new HashSet<RelatedEquipment>();
        }
    
        public int EquipmentID { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentTypeCV { get; set; }
        public int EquipmentModelID { get; set; }
        public string EquipmentSerialNumber { get; set; }
        public int EquipmentOwnerID { get; set; }
        public int EquipmentVendorID { get; set; }
        public System.DateTime EquipmentPurchaseDate { get; set; }
        public string EquipmentPurchaseOrderNumber { get; set; }
        public string EquipmentDescription { get; set; }
        public string EquipmentDocumentationLink { get; set; }
    
        public virtual ICollection<CalibrationReferenceEquipment> CalibrationReferenceEquipments { get; set; }
        public virtual CV_EquipmentType CV_EquipmentType { get; set; }
        public virtual EquipmentModel EquipmentModel { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EquipmentUsed> EquipmentUseds { get; set; }
        public virtual ICollection<EquipmentAnnotation> EquipmentAnnotations { get; set; }
        public virtual ICollection<RelatedEquipment> RelatedEquipments { get; set; }
        public virtual ICollection<RelatedEquipment> RelatedEquipments1 { get; set; }
    }
}
