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
    
    public partial class TransectResultValueAnnotation
    {
        public int BridgeID { get; set; }
        public long ValueID { get; set; }
        public int AnnotationID { get; set; }
    
        public virtual Annotation Annotation { get; set; }
        public virtual TransectResultValue TransectResultValue { get; set; }
    }
}
