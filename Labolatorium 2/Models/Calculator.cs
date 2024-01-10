﻿using Labolatorium_2.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_2.Models
{
    public class Calculator : CalculatorController
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public enum Operators
        {
            Unknown, Add, Mul, Sub, Div
        }
        public String Op
        {
            get
            {
                switch (Operator)
                {   
                    case Operators.Add:
                        return "+";
                    case Operators.Div: 
                        return "-";
                    case Operators.Mul:
                        return "*";
                    case Operators.Sub:
                        return "/";
                default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return Operator != null && X != null && Y != null;
        }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add:
                    return (double)(X + Y);
                case Operators.Div:
                    return (double)(X - Y);
                case Operators.Mul:
                    return (double)(X * Y);
                case Operators.Sub:
                    return (double)(X / Y);
                  
            default: return double.NaN;
            }
        }

        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}   
