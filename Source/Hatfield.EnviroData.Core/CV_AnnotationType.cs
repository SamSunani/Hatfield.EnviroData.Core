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
    
    public partial class CV_AnnotationType
    {
        public CV_AnnotationType()
        {
            this.Annotations = new HashSet<Annotation>();
        }
    
        public string Term { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public string Category { get; set; }
        public string SourceVocabularyURI { get; set; }
    
        public virtual ICollection<Annotation> Annotations { get; set; }
    }
}
