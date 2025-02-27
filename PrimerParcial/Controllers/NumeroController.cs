using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Models;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Calcular()
        {
            return View("NumeroView");
        }

        public IActionResult NumRand(NumeroModel ObjNumero)
        {
            if (ObjNumero.Num1 > ObjNumero.Num2)
            {
                ObjNumero.Resultado = "El Numero Minimo no puede ser mayor al Numero Maximo";
                return View("NumeroView", ObjNumero);
            }
            else
            {
                Random NumRand = new Random();
                ObjNumero.Num3 = NumRand.Next(ObjNumero.Num1, ObjNumero.Num2 + 1);
                ObjNumero.Resultado = "El numero al azar es: " + ObjNumero.Num3;
                return View("NumeroView", ObjNumero);

            }
        }
    }
}
