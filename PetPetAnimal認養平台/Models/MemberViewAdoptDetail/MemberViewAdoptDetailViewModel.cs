using Domain;
using PetPetAnimal認養平台.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetPetAnimal認養平台.Models
{
    public class MemberViewAdoptDetailViewModel
    {
        public MemberViewAdoptDetailViewModel(AnimalInfo item) 
        {
            this.AgeAndUnit = item.Age;
            this.AnimalID = item.AnimalID;
            this.CityLocation = item.CityLocation;
            this.Contacter = item.Contacter;
            this.ContacterEmail = item.ContacterEmail;
            this.ContacterPhone = item.ContacterPhone;
            this.CoverHeader = item.Header;
            this.CoverIntro = item.ShortIntro;
            this.CoverPhotoByte = item.Photo;
            this.Gender = (GenderType)item.Gender.Value;
            this.Height = item.Height;
            this.Introduction = item.Intro;
            this.IsOpen = item.IsOpen.Value;
            this.IsSpay = item.IsSpay;
            this.Length = item.Length;
            this.Name = item.Name;
            this.Personality = item.Personality;
            this.PhotoExtension = item.PhotoExt;
            this.SpecialNeed = item.SpecialNeed;
            this.Type = item.Type;
            this.Unit = item.Unit;
            this.Weight = item.Weight;
        }
        public MemberViewAdoptDetailViewModel()
        { }

        /// <summary>
        /// 認養動物流水碼
        /// </summary>
        public virtual int AnimalID { get; set; }

        /// <summary>
        /// 封面照片base64格式
        /// </summary>
        public virtual string Base64Photo { get; set; }
        /// <summary>
        /// 封面照片儲存格式
        /// </summary>
        public virtual byte[] CoverPhotoByte { get; set; }
        /// <summary>
        /// 名子
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 動物種類
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// 照片附檔名
        /// </summary>
        public virtual string PhotoExtension { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public virtual GenderType Gender { get; set; }

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
        public virtual int? Length { get; set; }
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
        /// 是否開放認養
        /// </summary>
        public bool IsOpen { get; set; }
    }
}