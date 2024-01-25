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

namespace flightmvc
{
    public class CustomerController: Controller{
        private readonly Ace52024Context db;

        public CustomerController(Ace52024Context _db)
        {
            db=_db;
        }

        public async Task<ActionResult> CustomIndex()
        {
            List<CustomerIvy> customers =[..db.CustomerIvies.Where(x=>true)];
            HttpClient client= new HttpClient();
                 client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("http://localhost:5214/api/Customer");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var response = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    customers = JsonConvert.DeserializeObject<List<CustomerIvy>>(response);
                

                }
            return View(customers);
        }

        
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
       

        public async Task<ActionResult> Create(CustomerIvy customer)
        {
        // {
        //     if(ModelState.IsValid)
        //     {
        //         db.CustomerIvies.Add(customer);
        //         db.SaveChanges();
        //         return RedirectToAction("BookIndex","Booking");
        //     }
        //     return View(customer);
             CustomerIvy c = new CustomerIvy();
                 db.CustomerIvies.Add(customer);
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), 
              Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:5214/api/Customer", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    c = JsonConvert.DeserializeObject<CustomerIvy>(apiResponse);
                }
            }
            return RedirectToAction("CustomIndex");
           
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("CustomIndex");
            }
            CustomerIvy c=new CustomerIvy();

            CustomerIvy customer =db.CustomerIvies.Where(x=>x.CustomerId==id).SingleOrDefault();
            TempData["custid"]=id;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5214/api/Customer" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    c = JsonConvert.DeserializeObject<CustomerIvy>(apiResponse);
                }
            }
            return View(customer);

            
        }

        [HttpPost]
       

        public async Task<IActionResult> Edit(int id,CustomerIvy customer)
             {
                if(id!=customer.CustomerId)
                {
                    return BadRequest();
                }
            

            if(ModelState.IsValid)
            {
                CustomerIvy c =new CustomerIvy();
            customer.CustomerId=Convert.ToInt32(TempData["custid"]);
                db.CustomerIvies.Update(customer);

                using (var httpClient = new HttpClient())
            {
                
                int cid = Convert.ToInt32(TempData["custid"]);;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(c)
         , Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:5214/api/Customer" + cid, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    c = JsonConvert.DeserializeObject<CustomerIvy>(apiResponse);
                }
            }
                

                db.SaveChanges();
                return RedirectToAction("CustomIndex");
            }
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            CustomerIvy customer =db.CustomerIvies.Where(x=>x.CustomerId==id).SingleOrDefault();
            TempData["custid"]=id;
            return View(customer);
        }

        [HttpPost]

        public async Task<IActionResult> Details(CustomerIvy customer)
        {
            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            CustomerIvy customer =db.CustomerIvies.Where(x=>x.CustomerId==id).SingleOrDefault();
            TempData["custid"]=id;
            CustomerIvy c = new CustomerIvy();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5214/api/Customer" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    c = JsonConvert.DeserializeObject<CustomerIvy>(apiResponse);
                }
            }
            return View(customer);

        }

        [HttpPost]
       
        public async Task<IActionResult> Delete(int id,CustomerIvy customer)

        {
            int custid=Convert.ToInt32(TempData["custid"]);
          customer.CustomerId=Convert.ToInt32(TempData["custid"]);
          db.CustomerIvies.Remove(customer);
           using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:5214/api/Customer" + customer))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
          db.SaveChanges();
          return RedirectToAction("CustomIndex");
        }



    }
}