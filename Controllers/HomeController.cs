using CrashUtahProject.Models;
using CrashUtahProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrashUtahProject.Controllers
{
    public class HomeController : Controller
    {

        private IAccidentRepository repo { get; set; }

        public HomeController(IAccidentRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Data(string searchByYear, string searchByCity, string searchByCounty, string searchBySeverity, string searchBydui, string searchBywork_zone_related, string searchBypedestrian_involved, string searchBybicyclist_involved, string searchBymotorcycle_involved, string searchByintersection_related, string searchBywild_animal_related, string searchByoverturn_rollover, string searchBycommercial_motor_veh_involved, string searchByteenage_driver_involved, string searchByolder_driver_involved, string searchBynight_dark_condition, string searchBysingle_vehicle, string searchBydistracted_driving, string searchBydrowsy_driving, string searchByroadway_departure, string searchByunrestrained, string searchByimproper_restraint, string searchBydomestic_animal_related, int pageNum = 1)
        {
            int pageSize = 25;

            if (searchByCity == null)
            {
                var x = new AccidentsViewModel
                {
                    Accidents = repo.Accidents
                    .OrderBy(x => x.crash_id)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                    PageInfo = new PageInfo
                    {
                        TotalNumAccidents = repo.Accidents.Count(),
                        AccidentsPerPage = pageSize,
                        CurrentPage = pageNum
                    }
                };

                

                return View(x);
            }
            else
            {
                var x = new AccidentsViewModel
                {
                    Accidents = repo.Accidents.Take(252500),

                    PageInfo = new PageInfo
                    {
                        TotalNumAccidents = repo.Accidents.Count(),
                        AccidentsPerPage = pageSize,
                        CurrentPage = pageNum
                    }
                };

                if (searchByYear != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.crash_datetime.Contains(searchByYear));
                }

                if (searchByCity != "all") {
                    x.Accidents = x.Accidents.Where(x => x.city == searchByCity);
                }

                if (searchByCounty != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.county_name == searchByCounty);
                }

                if (searchBySeverity != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.crash_severity_id.ToString() == searchBySeverity);
                }

                if (searchBydui != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.dui == searchBydui);
                }

                if (searchBywork_zone_related != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.work_zone_related == searchBywork_zone_related);
                }

                if (searchBypedestrian_involved != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.pedestrian_involved == searchBypedestrian_involved);
                }

                if (searchBybicyclist_involved != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.bicyclist_involved == searchBybicyclist_involved);
                }

                if (searchBymotorcycle_involved != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.motorcycle_involved == searchBymotorcycle_involved);
                }

                if (searchByimproper_restraint != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.improper_restraint == searchByimproper_restraint);
                }

                if (searchByunrestrained != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.unrestrained == searchByunrestrained);
                }

                if (searchByintersection_related != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.intersection_related == searchByintersection_related);
                }

                if (searchBywild_animal_related != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.wild_animal_related == searchBywild_animal_related);
                }

                if (searchBydomestic_animal_related != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.domestic_animal_related == searchBydomestic_animal_related);
                }

                if (searchByoverturn_rollover != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.overturn_rollover == searchByoverturn_rollover);
                }

                if (searchBycommercial_motor_veh_involved != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.commercial_motor_veh_involved == searchBycommercial_motor_veh_involved);
                }

                if (searchByteenage_driver_involved != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.teenage_driver_involved == searchByteenage_driver_involved);
                }

                if (searchByolder_driver_involved != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.older_driver_involved == searchByolder_driver_involved);
                }

                if (searchBynight_dark_condition != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.night_dark_condition == searchBynight_dark_condition);
                }

                if (searchBysingle_vehicle != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.single_vehicle == searchBysingle_vehicle);
                }

                if (searchBydistracted_driving != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.distracted_driving == searchBydistracted_driving);
                }

                if (searchBydrowsy_driving != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.drowsy_driving == searchBydrowsy_driving);
                }

                if (searchByroadway_departure != "all")
                {
                    x.Accidents = x.Accidents.Where(x => x.roadway_departure == searchByroadway_departure);
                }

                return View(x);
            }

            
        }

        public IActionResult Crash(double id)
        {
            var x = repo.Accidents
                .FirstOrDefault(x => x.crash_id == id);

            return View(x);
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateAccident()
        {
            return View("Editor");
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateAccident(Accident a)
        {

            if (ModelState.IsValid)
            {
                a.crash_id = (repo.Accidents.Max(x => x.crash_id)) + 1;
                repo.CreateAccident(a);
                return RedirectToAction("Data");

            }
            else
            {
                return View("Editor", a);
            }

        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int crash_id)
        {
            var accident = repo.Accidents.Single(x => x.crash_id == crash_id);
            return View("Editor", accident);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Accident accident)
        {
            repo.SaveAccident(accident);
            return RedirectToAction("Data");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int crash_id)
        {
            var accident = repo.Accidents.FirstOrDefault(x => x.crash_id == crash_id);

            return View(accident);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Delete(Accident accident)
        {
            repo.DeleteAccident(accident);

            return RedirectToAction("Data");
        }

        public IActionResult Analysis()
        {
            return View();
        }
    }
}

