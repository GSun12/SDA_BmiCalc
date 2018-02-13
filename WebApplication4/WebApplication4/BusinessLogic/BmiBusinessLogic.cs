using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.BusinessLogic
{
    public class BmiBusinessLogic
    {
        public void CountBmi(BmiForm inputModel)
        {

            inputModel.Result = (double)inputModel.Weight / (inputModel.Height * inputModel.Height) * 0.0001;
        }

        public string CheckBmi(double bmi)
        {
            if (CheckTime())
                return bmi < 18.5 ? "NotGood" : bmi > 25 ? "Bad" : "Ok";
            return "ToLate";
        }

        private bool CheckTime()
            => DateTime.Now.Hour < 22;

    }
}