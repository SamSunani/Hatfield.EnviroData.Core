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
    
    public partial class DerivationEquation
    {
        public DerivationEquation()
        {
            this.Results = new HashSet<Result>();
        }
    
        public int DerivationEquationID { get; set; }
        public string DerivationEquation1 { get; set; }
    
        public virtual ICollection<Result> Results { get; set; }
    }
}
