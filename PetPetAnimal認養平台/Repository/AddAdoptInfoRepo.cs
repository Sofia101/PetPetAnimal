using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPetAnimal認養平台.Models;
using PetPetAnimal認養平台.Entity;

namespace Service.Repository
{
    public class AddAdoptInfoRepo 
    {
        /// <summary>
        /// 新增認養資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddAdoptInfo( AddAdoptInfoViewModel model)
        {
            bool IsSuccess;
            try {
                PetPetAnimalEntities _ctx = new PetPetAnimalEntities();
                AnimalInfo AddItem = new AnimalInfo();
                AddItem.Age = model.AgeAndUnit;
                AddItem.CityLocation = model.CityLocation;
                AddItem.Contacter = model.Contacter;
                AddItem.ContacterEmail = model.ContacterEmail;
                AddItem.ContacterPhone = model.ContacterPhone;
                AddItem.Gender = (int)model.Gender;
                AddItem.Header = model.CoverHeader;
                AddItem.Height = model.Height;
                AddItem.Intro = model.Introduction;
                AddItem.IsSpay = model.IsSpay;
                AddItem.Length = model.Length;
                AddItem.Name = model.Name;
                AddItem.Personality = model.Personality;
                AddItem.Photo = model.CoverPhotoByte;
                AddItem.ShortIntro = model.CoverIntro;
                AddItem.SpecialNeed = model.SpecialNeed;
                AddItem.Unit = model.Unit;
                AddItem.Weight = model.Weight;
                AddItem.IsOpen = model.UpdateIsOpen;
                AddItem.Type = model.Type;
                AddItem.PhotoExt = model.PhotoExtension;
                AddItem.CreateDate = DateTime.Now.Date;
                _ctx.AnimalInfo.Add(AddItem);
                IsSuccess= _ctx.SaveChanges()>0;
               
                
            }
            catch(Exception ex){
                IsSuccess = false;
            }
            return IsSuccess;
        }

        //會員首頁取得動物清單
        public List<MemberViewAdoptList> MemberGetAdoptInfo()
        {
            List<MemberViewAdoptList> returnList = new List<MemberViewAdoptList>();
            try
            {
                PetPetAnimalEntities _ctx = new PetPetAnimalEntities();
                List<AnimalInfo> query= _ctx.AnimalInfo.ToList();
                returnList = query.Select(x => new MemberViewAdoptList(x)).ToList();
            }
            catch (Exception ex)
            {
                return returnList;
            }
            return returnList;
        }
        //會員取得認養動物瀏覽明細
        public MemberViewAdoptDetailViewModel MemberGetAdoptDetail(int AnimalID)
        {
            MemberViewAdoptDetailViewModel returnItem= new MemberViewAdoptDetailViewModel();
            try
            {
                PetPetAnimalEntities _ctx = new PetPetAnimalEntities();
                AnimalInfo query = _ctx.AnimalInfo.Where(x => x.AnimalID == AnimalID).FirstOrDefault();
                returnItem = new MemberViewAdoptDetailViewModel(query);
            }
            catch (Exception ex)
            {
                return returnItem;
            }
            return returnItem;
        }


        //會員取得認養動物修改明細
        public ModifyAdoptInfoViewModel  ModifyAdoptDetail(int AnimalID)
        {
            ModifyAdoptInfoViewModel returnItem = new ModifyAdoptInfoViewModel();
            try
            {
                PetPetAnimalEntities _ctx = new PetPetAnimalEntities();
                AnimalInfo query = _ctx.AnimalInfo.Where(x => x.AnimalID == AnimalID).FirstOrDefault();
                returnItem = new ModifyAdoptInfoViewModel(query);
            }
            catch (Exception ex)
            {
                return returnItem;
            }
            return returnItem;
        }

        /// <summary>
        /// 修改認養資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ModifyAdoptInfo(ModifyAdoptInfoViewModel model)
        {
            bool IsSuccess;
            try
            {
                PetPetAnimalEntities _ctx = new PetPetAnimalEntities();

                var animal = _ctx.AnimalInfo.Where(x => x.AnimalID == model.AnimalID).FirstOrDefault();

                animal.Age = model.AgeAndUnit;
                animal.CityLocation = model.CityLocation;
                animal.Contacter = model.Contacter;
                animal.ContacterEmail = model.ContacterEmail;
                animal.ContacterPhone = model.ContacterPhone;
                animal.Gender = (int)model.Gender;
                animal.Header = model.CoverHeader;
                animal.Height = model.Height;
                animal.Intro = model.Introduction;
                animal.IsSpay = model.IsSpay;
                animal.Length = model.Length;
                animal.Name = model.Name;
                animal.Personality = model.Personality;
                if (model.CoverPhotoByte != null) 
                {
                animal.Photo = model.CoverPhotoByte;
                animal.PhotoExt = model.PhotoExtension;
                }
                
                animal.ShortIntro = model.CoverIntro;
                animal.SpecialNeed = model.SpecialNeed;
                animal.Unit = model.Unit;
                animal.Weight = model.Weight;
                animal.IsOpen = model.UpdateIsOpen;
                animal.Type = model.Type;
              
               
                IsSuccess = _ctx.SaveChanges() > 0;


            }
            catch (Exception ex)
            {
                IsSuccess = false;
            }
            return IsSuccess;
        }
        /// <summary>
        /// 刪除認養資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteAdoptInfo(int AnimalID)
        {
            bool IsSuccess;
            try
            {
                PetPetAnimalEntities _ctx = new PetPetAnimalEntities();

                var animal = _ctx.AnimalInfo.Where(x => x.AnimalID == AnimalID).FirstOrDefault();

                _ctx.AnimalInfo.Remove(animal);

                IsSuccess = _ctx.SaveChanges() > 0;


            }
            catch (Exception ex)
            {
                IsSuccess = false;
            }
            return IsSuccess;
        }

    }
}
