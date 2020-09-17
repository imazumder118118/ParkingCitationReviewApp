using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ParkingCitationReviews.Business;
using ParkingCitationReviews.Business.Interfaces;
using ParkingCitationReviews.DataAccess;
using ParkingCitationReviewApp.Model;
using Microsoft.EntityFrameworkCore;
using ParkingCitationReviewApp.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace ParkingCitationReviewApp.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        //private readonly ConnectionStringClass _db;
        private readonly IWebHostEnvironment _he;
        private readonly ParkingReviewDBContext _db;
        private readonly IConfiguration _configuration;
        private readonly recaptcha recaptchaSettings;

        private readonly IParkingCitationReviewsTasks pcrTasks;

        [BindProperty]
        public ParkingCitationReviewApp.Models.CitationReviewRequest  ObjCitationReview { get;set;}

          [BindProperty]
          public int SelectReviewReasonIndex { get; set; }
           //public List<int> checklist { get; set; }


        public IndexModel(ParkingReviewDBContext db, IParkingCitationReviewsTasks pcrTasks,IWebHostEnvironment he, IConfiguration configuration, IOptions<recaptcha> settings)
        {
            _db = db;
            _he = he;
            _configuration = configuration;
            this.pcrTasks = pcrTasks;
            recaptchaSettings = settings.Value;
        }
        [BindProperty]
        public IEnumerable<ParkingCitationReviewApp.Models.ReviewReasonIndex> displaydata { get; set; }
        [BindProperty]
        public Dictionary<string,string> statesDictory { get; set; }

        public Dictionary<string,string> streetDictionary { get; set; }

        [BindProperty]
        public IFormFile UploadFiles { get; set; }
        
        




        public void OnGet()
        {
            displaydata =  _db.ReviewReasonIndex.ToList();
            statesDictory = this.pcrTasks.GetStatesList();
            
            //streetDictionary = this.pcrTasks.GetStreetTypeList();


        }
        public IActionResult OnPost()
        {
            //if(!String.IsNullOrEmpty(Request.Form["SelectReviewReasonIndex"].ToString()))
            //ObjCitationReview.ReasonId = Convert.ToDecimal(Request.Form["SelectReviewReasonIndex"].ToString());
            ObjCitationReview.VehicleMakeId = Convert.ToDecimal(1);
            ObjCitationReview.DeterminationId = Convert.ToDecimal(1);
            if(!IsReCaptchValid())
            {
                ModelState.AddModelError(string.Empty, "Please check the checkbox, Captcha verification failed.");
            }
            var CheckIfCitationExists = _db.CitationReviewRequest.Any(x => x.CitationNumber == ObjCitationReview.CitationNumber);
            if (CheckIfCitationExists)
            {
                ModelState.AddModelError(string.Empty,"Citation No already exists in our database . It has to be unique to process further.");
               
            }
                       
            if (ModelState.IsValid)
            {
                //TempData["Data"] = ObjCitationReview.RecipientAddressState;





                try
                {
                    //var entry = _db.Add(new CitationReview());
                    //entry.CurrentValues.SetValues(objCitationReview);
                    //_db.SaveChangesAsync();

                    //DefaultValues list //
                    //objCitationReview.VehicleMakeID = Convert.ToInt32(1);
                    //check for citation no exists already in the db or not .If exists send a message to the user .
                    

                        if (UploadFiles != null)
                        {

                            var ServerPath = _configuration.GetSection("MySettings").GetSection("ServerPath").Value;
                            var uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UploadFiles.FileName);
                            //DIT-TASK01-DV\ApplicationFiles\Parking
                            //var FileUpload = Path.Combine(ServerPath, "Files", uniqueFileName).Replace("\"", string.Empty).Replace("'", string.Empty);
                            var FileUpload = Path.Combine(ServerPath, uniqueFileName).Replace("\"", string.Empty).Replace("'", string.Empty);
                            //var FileUpload = Path.Combine(ServerPath, "Files", Path.GetFileName(UploadFiles.FileName)).Replace("\"", string.Empty).Replace("'", string.Empty); ;
                            using (var fs = new FileStream(FileUpload, FileMode.Create))
                            {
                                UploadFiles.CopyTo(fs);
                                ObjCitationReview.DocumentPath = FileUpload;
                            }
                        }

                        _db.CitationReviewRequest.Add(ObjCitationReview);

                        _db.SaveChanges();
                   
                }
                catch (Exception ex)
                {
                    string msg = ex.StackTrace;
                    throw;
                }
                return RedirectToPage("./Index");
            }
            else
            {
                OnGet();
                //displaydata = _db.ReviewReasonIndex.ToList();
                //statesDictory = this.pcrTasks.GetStatesList();
                //streetDictionary = this.pcrTasks.GetStreetTypeList();

            }
            //_db.CitationReview.Add(objCitationReview);

            return Page();
        }

        public bool IsReCaptchValid()
        {
            var result = false;
            var captchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = _configuration.GetSection("recaptcha").GetSection("SecretKey").Value;
            var apiUrl = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, captchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    JsonDocument jdoc = JsonDocument.Parse(stream.ReadToEnd());
                    var root = jdoc.RootElement;
                    result =Convert.ToBoolean(root.GetProperty("success").ToString());
                    //var  result = info[0];
                    //result = (isSuccess) ? true : false;
                }
            }
            return result;
        }

        //[BindProperty]
        //public StudentVM StudentVM { get; set; }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    var entry = _context.Add(new Student());
        //    entry.CurrentValues.SetValues(StudentVM);
        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("./Index");
        //}
    }
}
