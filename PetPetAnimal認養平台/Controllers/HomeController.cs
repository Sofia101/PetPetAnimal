using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetPetAnimal認養平台.Models;
using System.IO;
using Service;
using Service.Repository;
using PagedList;

namespace PetPetAnimal認養平台.Controllers
{
    public class HomeController : Controller
    {

        private AddAdoptInfoRepo _Repo = new AddAdoptInfoRepo();
        public HomeController()
        {

        }

        //會員首頁
        public ActionResult Index(int ?page)
        {
          List<MemberViewAdoptList> model=  _Repo.MemberGetAdoptInfo();
          int currentPageIndex = page.HasValue ? page.Value - 1 : 1;
          foreach (var i in model)       
          {
              if (i.CoverPhotoByte != null)
              {
                  byte[] photoByte = i.CoverPhotoByte;
                  i.Base64Photo = Convert.ToBase64String(photoByte);
              }
              else { i.Base64Photo = ""; }
             
          }
          IPagedList<MemberViewAdoptList> returnModel=model.ToPagedList(currentPageIndex, 9);
          return View(returnModel);
        }

        //認養明細(瀏覽)
        public ActionResult ViewAdoptInfo(int AnimalID) 
        {
            MemberViewAdoptDetailViewModel model = new MemberViewAdoptDetailViewModel();
            model = _Repo.MemberGetAdoptDetail(AnimalID);

            if (model.CoverPhotoByte != null)
            {

                byte[] photoByte = model.CoverPhotoByte;
                model.Base64Photo = Convert.ToBase64String(photoByte);
            }
            else 
            {
                model.Base64Photo = "";
            }
            return View(model);
        }

        //新增首頁
        public ActionResult AddAdoptInfo(AddAdoptInfoViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult AddAdopt(AddAdoptInfoViewModel model) 
        {
            
            try
            {
                //檔案處理封面照片           
                if (model.CoverPhoto != null)
                {
                    model.PhotoExtension = Path.GetExtension(model.CoverPhoto.FileName);
                    
                    using (BinaryReader reader = new BinaryReader(model.CoverPhoto.InputStream))
                    {
                        model.CoverPhotoByte = reader.ReadBytes(model.CoverPhoto.ContentLength);                  
                    }
                }

                //動物資料儲存
                bool IsSuccess = _Repo.AddAdoptInfo(model);
                if (IsSuccess) { ViewBag.Message = "新增成功!"; }
                else { ViewBag.Message = "新增失敗!"; }
                //照片集處理與儲存
                // List<string> PicturesResult = new List<string>();
                //if (model.Pictures.Count() > 0) 
                //{
                //    foreach (var i in model.Pictures)
                //    {
                //        using (BinaryReader reader = new BinaryReader(i.InputStream))
                //        {
                //            model.PicturesByte.Add(reader.ReadBytes(i.ContentLength));
                //            //PicturesResult.Add( System.Text.Encoding.UTF8.GetString(byteData));
                //        }
                //    }
                //}
                ////照片集儲存
            }
            catch (Exception ex) 
            {

                ViewBag.Message = "新增失敗!原因:"+ex.Message;
            }
  
            return View("AddAdoptInfo",model);
        }

        /// <summary>
        /// 修改認養資料(畫面編輯)
        /// </summary>
        /// <returns></returns>
        public ActionResult ModifyAdoptInfo(MemberViewAdoptDetailViewModel modeViewl) 
        {
            ModifyAdoptInfoViewModel model = new ModifyAdoptInfoViewModel();
            try
            {
                 model = _Repo.ModifyAdoptDetail(modeViewl.AnimalID);
                 if (model.CoverPhotoByte != null)
                 {

                     byte[] photoByte = model.CoverPhotoByte;
                     model.Base64Photo = Convert.ToBase64String(photoByte);
                 }
                 else 
                 {
                     model.Base64Photo = "";
                 }
            }
            catch (Exception ex) { throw ex; }

            return View(model);
        }

        /// <summary>
        /// 修改認養資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ModifyAdoptInfoSend( ModifyAdoptInfoViewModel model)
        {
            try {
                //檔案處理封面照片           
                if (model.CoverPhoto != null)
                {
                    model.PhotoExtension = Path.GetExtension(model.CoverPhoto.FileName);

                    using (BinaryReader reader = new BinaryReader(model.CoverPhoto.InputStream))
                    {
                        model.CoverPhotoByte = reader.ReadBytes(model.CoverPhoto.ContentLength);
                    }
                }

               bool IsSuccess= _Repo.ModifyAdoptInfo(model);

               if (IsSuccess) { ViewBag.Message = "修改成功!"; }
               else { ViewBag.Message = "修改失敗!"; }
            }
            catch (Exception ex) { ViewBag.Message = "修改失敗!原因:" + ex.Message; }

            return View("ModifyAdoptInfo",model);
        }

        [HttpPost]
        public ActionResult DeleteAdoptInfo(int AnimalID) 
        {
            JsonResult result = new JsonResult();
            try {
                
                bool IsSuccess = _Repo.DeleteAdoptInfo(AnimalID);
                if (IsSuccess) { result.Data = "刪除成功!"; }
                else { result.Data = "刪除失敗!"; }
            }
            catch (Exception ex) 
            {
                result.Data = "刪除失敗!原因:"+ex.Message;
            }
            return result;
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}