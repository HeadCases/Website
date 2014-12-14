using Headcases.Models;
using Headcases.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Headcases.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Predict(Conditions conditions)
        {
            Result res = new Result();
            using (var client = new WebClient())
            {
                ScoreData scoreData = new ScoreData()
                {
                    FeatureVector = conditions,
                    GlobalParameters =
                        new Dictionary<string, string>()
                        {
                        }
                };

                ScoreRequest scoreRequest = new ScoreRequest()
                {
                    Id = "score00001",
                    Instance = scoreData
                };

                const string apiKey = "9NtL9b0fER7FDub0kOC+TTpXX0mwOzgZPQ51P8b8E30C+8B/pI6T5xOtAUuQvZlROrnuejCNLvMhDL3BA3fytg=="; // Replace this with the API key for the web service
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + apiKey);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(scoreRequest);
                try
                {
                    var vals = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(client.UploadString("https://ussouthcentral.services.azureml.net/workspaces/ca8deb48055a434a88228b6f40e36866/services/493e73bb94264df7991a36231eb5375a/score", "POST", json));
                    
                    res.Survived = vals[vals.Length - 2].ToString().ToUpper() == "SURVIVED";
                    res.Probability = decimal.Parse(vals[vals.Length - 1]);
                    
                }
                catch (Exception ex)
                {
                    res.Error = true;
                    res.Message = ex.Message;
                }
            }
            return PartialView("_Result", res);
        }
    }
}