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
    
    public partial class SuggestMedia
    {
        public int SuggestMediaID { get; set; }
        public string Title { get; set; }
        public Nullable<int> UpVotes { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public int IceUserID { get; set; }
        public int RequestTranslationID { get; set; }
    
        public virtual IceUser IceUser { get; set; }
        public virtual RequestTranslation RequestTranslation { get; set; }
    }
}
