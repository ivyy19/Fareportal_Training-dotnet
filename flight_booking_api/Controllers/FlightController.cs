using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Common;

using Microsoft.AspNetCore.Mvc;
using flightmvc.Models;

namespace flightmvc.Controllers
{
    public class FlightController:Controller{
        private readonly Ace52024Context db;

        public FlightController(Ace52024Context _db)
        {
            db=_db;
        }

        //getting list of flights

       [HttpGet]

        public async Task<ActionResult> Show()
        {
            List<FlightsIvy>flights =[..db.FlightsIvies.Where(x=>true)];
            
                HttpClient client= new HttpClient();
                 client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("http://localhost:5214/api/Flight");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var response = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    flights = JsonConvert.DeserializeObject<List<FlightsIvy>>(response);
                

                }
                //returning the employee list to view  
                return View(flights);
        }

        
        public ActionResult Add()
            {
                return View();



            }

            [HttpPost]

            public async Task<ActionResult> Add(FlightsIvy flight)
            {
                 FlightsIvy f = new FlightsIvy();
                 db.FlightsIvies.Add(flight);
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(flight), 
              Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:5214/api/Flight", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    f = JsonConvert.DeserializeObject<FlightsIvy>(apiResponse);
                }
            }
            return RedirectToAction("Show");
           
    }

        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Show");
            }
            FlightsIvy f = new FlightsIvy();
             FlightsIvy flight =db.FlightsIvies.Where(x=>x.FlightId==id).SingleOrDefault();
            TempData["flightid"]=id;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5214/api/Flight" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    f = JsonConvert.DeserializeObject<FlightsIvy>(apiResponse);
                }
            }
            //TempData["flightid"]=id;
            return View(flight);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id,FlightsIvy e)
        {
            if(id!=e.FlightId)
            {
                return BadRequest();
            }
            if(ModelState.IsValid)
            {
                
            
            FlightsIvy e1 = new FlightsIvy();
            e.FlightId=Convert.ToInt32(TempData["flightid"]);
            db.FlightsIvies.Update(e);
           

            using (var httpClient = new HttpClient())
            {
                
                int fid = Convert.ToInt32(TempData["flightid"]);;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(e1)
         , Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:5214/api/Flight" + fid, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    e1 = JsonConvert.DeserializeObject<FlightsIvy>(apiResponse);
                }
            }
             //db.FlightsIvies.Update(e1);
               db.SaveChanges();
            return RedirectToAction("Show");
        }
        return View(e);
        }
        public ActionResult Details(int id)
        {
            FlightsIvy flight =db.FlightsIvies.Where(x=>x.FlightId==id).SingleOrDefault();
            TempData["flightid"]=id;
            return View(flight);
        }
        

    
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            FlightsIvy flight =db.FlightsIvies.Where(x=>x.FlightId==id).SingleOrDefault();
            TempData["flightid"]=id;
           // TempData["flightid"] = id;
            FlightsIvy e = new FlightsIvy();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5214/api/Flight" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<FlightsIvy>(apiResponse);
                }
            }
            return View(flight);
        }


        [HttpPost]
       // [ActionName("DeleteEmployee")]
        public async Task<ActionResult> Delete(FlightsIvy e)
        {
            int flightid = Convert.ToInt32(TempData["flightid"]);
            e.FlightId=Convert.ToInt32(TempData["flightid"]);
            db.FlightsIvies.Remove(e);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:5214/api/Flight" + flightid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            db.SaveChanges();

            return RedirectToAction("BookIndex");
        }
    }
}