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
    
    public partial class PersonExternalIdentifier
    {
        public int BridgeID { get; set; }
        public int PersonID { get; set; }
        public int ExternalIdentifierSystemID { get; set; }
        public string PersonExternalIdentifier1 { get; set; }
        public string PersonExternalIdentifierURI { get; set; }
    
        public virtual ExternalIdentifierSystem ExternalIdentifierSystem { get; set; }
        public virtual Person Person { get; set; }
    }
}
