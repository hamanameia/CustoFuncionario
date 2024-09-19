using Microsoft.AspNetCore.Mvc;
using CustoFuncionarioApp.Models;

namespace CustoFuncionarioApp.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(Funcionario f)
        {
            var CustoTotal = (f.SalarioBase + f.Beneficio) - f.Desconto;

            ViewData["Custo"] = CustoTotal;

            return View("Index");
        }

        public static decimal CalcularTeste(decimal Salario, decimal Desconto, decimal Beneficio)
        {
            var CustoTotal = (Salario + Beneficio) - Desconto;

            return CustoTotal;

        }

    }
}
