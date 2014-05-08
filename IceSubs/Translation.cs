//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IceSubs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Translation
    {
        public Translation()
        {
            this.Comments = new HashSet<Comment>();
            this.TranslationLines = new HashSet<TranslationLine>();
            this.Media = new HashSet<Medium>();
        }
    
        public int TranslationID { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public int IceUserID { get; set; }
        public int MediaID { get; set; }
        public int LanguageID { get; set; }
        public Nullable<int> RatingsID { get; set; }
        public Nullable<int> Downloads { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual IceUser IceUser { get; set; }
        public virtual Language Language { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual ICollection<TranslationLine> TranslationLines { get; set; }
        public virtual ICollection<Medium> Media { get; set; }
    }
}
