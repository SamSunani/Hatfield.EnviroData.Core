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
    
    public partial class RelatedEquipment
    {
        public int RelationID { get; set; }
        public int EquipmentID { get; set; }
        public string RelationshipTypeCV { get; set; }
        public int RelatedEquipmentID { get; set; }
        public System.DateTime RelationshipStartDateTime { get; set; }
        public int RelationshipStartDateTimeUTCOffset { get; set; }
        public Nullable<System.DateTime> RelationshipEndDateTime { get; set; }
        public Nullable<int> RelationshipEndDateTimeUTCOffset { get; set; }
    
        public virtual CV_RelationshipType CV_RelationshipType { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual Equipment Equipment1 { get; set; }
    }
}
