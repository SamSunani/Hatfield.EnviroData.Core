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
    
    public partial class ReferenceMaterial
    {
        public ReferenceMaterial()
        {
            this.CalibrationStandards = new HashSet<CalibrationStandard>();
            this.ReferenceMaterialExternalIdentifiers = new HashSet<ReferenceMaterialExternalIdentifier>();
            this.ReferenceMaterialValues = new HashSet<ReferenceMaterialValue>();
        }
    
        public int ReferenceMaterialID { get; set; }
        public string ReferenceMaterialMediumCV { get; set; }
        public int ReferenceMaterialOrganizationID { get; set; }
        public string ReferenceMaterialCode { get; set; }
        public string ReferenceMaterialLotCode { get; set; }
        public Nullable<System.DateTime> ReferenceMaterialPurchaseDate { get; set; }
        public Nullable<System.DateTime> ReferenceMaterialExpirationDate { get; set; }
        public string ReferenceMaterialCertificateLink { get; set; }
        public Nullable<int> SamplingFeatureID { get; set; }
    
        public virtual ICollection<CalibrationStandard> CalibrationStandards { get; set; }
        public virtual CV_ReferenceMaterialMedium CV_ReferenceMaterialMedium { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<ReferenceMaterialExternalIdentifier> ReferenceMaterialExternalIdentifiers { get; set; }
        public virtual SamplingFeature SamplingFeature { get; set; }
        public virtual ICollection<ReferenceMaterialValue> ReferenceMaterialValues { get; set; }
    }
}
