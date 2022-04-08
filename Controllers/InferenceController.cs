using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrashUtahProject.Models;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrashUtahProject.Controllers
{
    public class InferenceController : Controller
    {

        private InferenceSession _session;

        public InferenceController(InferenceSession session)
        {
            _session = session;
        }

        [HttpGet]
        public IActionResult Prediction()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Prediction(CrashData data)
        {
            if (data.day_Monday == 1.0)
            {
                data.day_Saturday = 0;
                data.day_Sunday = 0;
                data.day_Tuesday = 0;
            }
            else if (data.day_Tuesday == 1.0)
            {
                data.day_Saturday = 0;
                data.day_Sunday = 0;
                data.day_Monday = 0;
            }
            else if (data.day_Saturday == 1.0)
            {
                data.day_Monday = 0;
                data.day_Sunday = 0;
                data.day_Tuesday = 0;
            }
            else
            {
                data.day_Monday = 0;
                data.day_Saturday = 0;
                data.day_Tuesday = 0;
            }


            if (data.time_frame_5am_9am == 1.0)
            {

                data.time_frame_9am_12pm = 0;

            }
            else
            {
                data.time_frame_9am_12pm = 1;
            }
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Predictions { PredictedValue = score.First() };
            result.Dispose();
            return View("PredictedValue", prediction);
        }
    }
}