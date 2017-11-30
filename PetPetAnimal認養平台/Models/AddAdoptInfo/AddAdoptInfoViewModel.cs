using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  PetPetAnimal認養平台;
using Domain;

namespace PetPetAnimal認養平台.Models
{
    public class AddAdoptInfoViewModel
    {
        /// <summary>
        /// 名子
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 動物種類
        /// </summary>
        public virtual string Type { get; set; }
        /// <summary>
        /// 封面照片
        /// </summary>
        public virtual HttpPostedFileBase CoverPhoto { get; set; }
        /// <summary>
        /// 封面照片儲存格式
        /// </summary>
        public virtual byte[] CoverPhotoByte { get; set; }
        /// <summary>
        /// 照片附檔名
        /// </summary>
        public virtual string PhotoExtension { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public virtual GenderType Gender { get; set; }
        /// <summary>
        /// 年齡
        /// </summary>
        public virtual string Age { get; set; }
        /// <summary>
        /// 年齡加單位
        /// </summary>
        public virtual string AgeAndUnit { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public virtual int? Weight { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        public virtual int? Height { get; set; }
        /// <summary>
        /// 身長
        /// </summary>
        public virtual int? Length{ get; set; }
        /// <summary>
        /// 是否結紮
        /// </summary>
        public virtual bool? IsSpay { get; set; }
        /// <summary>
        ///個性特質
        /// </summary>
        public virtual string Personality { get; set; }
        /// <summary>
        ///詳細介紹
        /// </summary>
        public virtual string Introduction { get; set; }
        /// <summary>
        ///特殊照顧需求
        /// </summary>
        public virtual string SpecialNeed { get; set; }
        /// <summary>
        ///封面標題
        /// </summary>
        public virtual string CoverHeader { get; set; }
        /// <summary>
        ///封面敘述
        /// </summary>
        public virtual string CoverIntro { get; set; }
        /// <summary>
        ///機構(或個人)
        /// </summary>
        public virtual string Unit { get; set; }
        /// <summary>
        ///聯絡人
        /// </summary>
        public virtual string Contacter { get; set; }
        /// <summary>
        ///聯絡地點縣市
        /// </summary>
        public virtual string CityLocation { get; set; }
        /// <summary>
        ///聯絡電話
        /// </summary>
        public virtual string ContacterPhone { get; set; }
        /// <summary>
        ///聯絡email
        /// </summary>
        public virtual string ContacterEmail { get; set; }
        /// <summary>
        /// 照片集
        /// </summary>
        public IEnumerable<HttpPostedFileBase> Pictures { get; set; }
        /// <summary>
        /// 照片集儲存格是
        /// </summary>
        public List<byte[]> PicturesByte { get; set; }

        /// <summary>
        /// 是否開放認養
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// 是否開放認養
        /// </summary>
        public bool UpdateIsOpen { get; set; }
    }
}