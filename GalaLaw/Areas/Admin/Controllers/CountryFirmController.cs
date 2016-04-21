using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GalaLaw.Areas.Admin.Models;
using DAL.Models;
using BLL;
using System.IO;

namespace GalaLaw.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CountryFirmController : Controller
    {
        GalaDBEntities db = new GalaDBEntities();
        // GET: Admin/CountryFirm
        public ActionResult Index()
        {
            CountryModel CM = new CountryModel();
            ViewBag.Countries = CM.Countries.Select(c => new SelectListItem { Text = c.CountryName, Value = c.CountryName }).ToList();
        
          
            return View(new FirmModel());
        }
        [HttpPost]
      [ValidateInput(false)]
        public ActionResult Index(FirmModel model)
        {
            model.Insert(model);
            return RedirectToAction("Firms");
        }

       
        [HttpGet]
        public ActionResult Insert()
        {
            return View(new Country());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Insert(Country model, HttpPostedFileBase ImageUpload )
        {
            CountryModel CM = new CountryModel();           
                model.Flag = ImageUload(ImageUpload, "~/Images/flags"); 

            CM.Insert(model);
            return RedirectToAction("Firms");
        }

        public ActionResult Firms()
        {
            ViewBag.Members = ManageTeam.GetAllTeam().OrderBy(c=>c.FName).Select(c => new SelectListItem { Text = c.FName + " " + c.LName, Value = c.Id.ToString() }).ToList();
           ViewBag.Countries = ManageCountry.GetAllCountry().Select(c => new SelectListItem { Text = c.CountryName, Value = c.Id.ToString() }).ToList();
            return View(new FirmModel());
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            FirmModel Fm = new FirmModel();
            Fm.Delete(id);

            var L = db.CMFRelation.Where(c => c.FID == id).ToList();
            foreach (var item in L)
            {
                ManageCMFRelation.DeleteCMFRelation(item);
            }           

            return RedirectToAction("Firms");
        }

        public ActionResult Details(int id)
        {
            FirmModel FM = new FirmModel();
            FM.loadFirmById(id);
            return View(FM);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            CountryModel CM = new CountryModel();
            ViewBag.Countries = CM.Countries.Select(c => new SelectListItem { Text = c.CountryName, Value = c.CountryName }).ToList();//get list of country
            FirmModel FM = new FirmModel();
            FM.loadFirmById(id);
            return View(FM);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(FirmModel model)
        {
            model.update(model);
            return RedirectToAction("Firms");
        }
        [HttpPost] 
        public ActionResult Relationship(FirmModel model)
        {
            CMFRelation cmr = new CMFRelation();
            cmr.CID = Convert.ToInt32(model.CID);
            cmr.FID = model.FID;
            cmr.MID = model.MID;

           ManageCMFRelation.AddCMFRelation(cmr);

            return RedirectToAction("Firms");
        }
        [HttpGet]
        public ActionResult RemoveTeamfromCountry(int id)
        {
            CMFRelation CMF = new CMFRelation();
            CMF = ManageCMFRelation.GetById(id);
            ManageCMFRelation.DeleteCMFRelation(CMF);

            return RedirectToAction("Firms");
        }
        [HttpPost]
        public ActionResult AddFCRelation(FirmModel model)
        {
            model.AddFCRelation(model);
            return RedirectToAction("Firms");
        }


        //upload image
        public string ImageUload(HttpPostedFileBase File, string url)
        {
            var validImageTypes = new string[]
            {
                "image/gif",
                "image/jpeg",
                "image/jpg",
                "image/pjpeg",
                "image/png"
            };

            if (File == null || File.ContentLength == 0)
            {
                ModelState.AddModelError("ImageUpload", "This field is required");
            }
            else if (!validImageTypes.Contains(File.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.");
            }

            if (ModelState.IsValid)
            {
                if (File != null && File.ContentLength > 0)
                {
                    var uploadDir = url;
                    var imagePath = Path.Combine(Server.MapPath(uploadDir), File.FileName);
                    var imageUrl = Path.Combine(uploadDir, File.FileName);
                    File.SaveAs(imagePath);
                    return File.FileName;
                }
            }
            return "noimg.jpg";



        }

    }
}