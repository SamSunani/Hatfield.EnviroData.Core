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
    
    public partial class ModelAffiliation
    {
        public int BridgeID { get; set; }
        public int ModelID { get; set; }
        public int AffiliationID { get; set; }
        public bool IsPrimary { get; set; }
        public string RoleDescription { get; set; }
    
        public virtual Affiliation Affiliation { get; set; }
        public virtual Model Model { get; set; }
    }
}