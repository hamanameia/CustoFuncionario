using CustoFuncionarioApp.Models;

namespace Testes
{
    public class Calcula
    {
        [Fact]
        public void Custo()
        {
            var SalarioBase = 100;
            var Beneficio = 200;
            var Desconto = 25;

            Assert.Equal(275, CustoFuncionarioApp.Controllers.FuncionarioController.CalcularTeste(SalarioBase,Desconto,Beneficio));

        }
    }
}