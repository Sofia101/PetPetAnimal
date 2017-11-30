//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetPetAnimal認養平台.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnimalInfo
    {
        public AnimalInfo()
        {
            this.Pictures = new HashSet<Pictures>();
        }
    
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Gender { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoExt{ get; set; }
        public string Age { get; set; }
        public string Header { get; set; }
        public string ShortIntro { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<bool> IsSpay { get; set; }
        public string Personality { get; set; }
        public string Intro { get; set; }
        public string SpecialNeed { get; set; }
        public string Unit { get; set; }
        public string CityLocation { get; set; }
        public string Contacter { get; set; }
        public string ContacterPhone { get; set; }
        public string ContacterEmail { get; set; }
        public Nullable<bool> IsOpen { get; set; }
        public string Type { get; set; }
        public Nullable<DateTime >CreateDate { get; set; }

        public virtual ICollection<Pictures> Pictures { get; set; }
    }
}
