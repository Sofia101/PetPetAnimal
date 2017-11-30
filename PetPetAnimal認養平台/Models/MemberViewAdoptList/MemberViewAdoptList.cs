using PetPetAnimal認養平台.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetPetAnimal認養平台.Models
{
    public class MemberViewAdoptList
    {

        public MemberViewAdoptList(AnimalInfo item) 
        {
            this.Name = item.Name;
            this.Type = item.Type;
            if (item.Photo != null)
            {
                this.CoverPhotoByte = item.Photo;
            }
           
            this.UpdateIsOpen = Convert.ToBoolean(item.IsOpen);
            this.CityLocation = item.CityLocation;
            this.CoverHeader = item.Header;
            this.CoverIntro = item.ShortIntro;
            this.PhotoExt = item.PhotoExt;
            this.AnimalID = item.AnimalID;
            this.CreateDate = item.CreateDate.Value;
        }

        /// <summary>
        /// 名子
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 動物種類
        /// </summary>
        public virtual string Type { get; set; }
        /// <summary>
        /// 封面照片儲存格式
        /// </summary>
        public virtual byte[] CoverPhotoByte { get; set; }
        /// <summary>
        /// 封面照片base64格式
        /// </summary>
        public virtual string Base64Photo { get; set; }
        /// <summary>
        /// 封面照片副檔名
        /// </summary>
        public virtual string PhotoExt { get; set; }
        /// <summary>
        /// 是否開放認養
        /// </summary>
        public bool UpdateIsOpen { get; set; }
        /// <summary>
        ///聯絡地點縣市
        /// </summary>
        public virtual string CityLocation { get; set; }
        /// <summary>
        ///封面標題
        /// </summary>
        public virtual string CoverHeader { get; set; }
        /// <summary>
        ///封面敘述
        /// </summary>
        public virtual string CoverIntro { get; set; }
        /// <summary>
        /// 認養動物流水碼
        /// </summary>
        public virtual int AnimalID { get; set; }

        /// <summary>
        /// 發布日期
        /// </summary>
        public virtual DateTime CreateDate { get; set; }
    }
}