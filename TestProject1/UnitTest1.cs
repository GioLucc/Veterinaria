using Entidades;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Recepcionista<Mascota> recepcionista = new Recepcionista<Mascota>();

            recepcionista.Alta(Mascota);
        }
    }
}