using Sistema_Gestion.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Data;

namespace pruebas
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para DatosTest y se pretende que
    ///contenga todas las pruebas unitarias DatosTest.
    ///</summary>
    [TestClass()]
    public class DatosTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de ver_ramos_rut
        ///</summary>
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\alex\\Mis documentos\\Visual Studio 2008\\Projects\\Sistema_Gestion\\Sistema_Gestion", "/")]
        [UrlToTest("http://localhost:1444/")]
        public void ver_ramos_rutTest()
        {
            Datos target = new Datos(); // TODO: Inicializar en un valor adecuado
            string rut = string.Empty; // TODO: Inicializar en un valor adecuado
            DataSet expected = null; // TODO: Inicializar en un valor adecuado
            DataSet actual;
            actual = target.ver_ramos_rut(rut);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Autenctificacion
        ///</summary>
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\alex\\Mis documentos\\Visual Studio 2008\\Projects\\Sistema_Gestion\\Sistema_Gestion", "/")]
        [UrlToTest("http://localhost:1444/")]
        public void AutenctificacionTest()
        {
            Datos target = new Datos(); // TODO: Inicializar en un valor adecuado
            target.Autenctificacion();
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de Constructor Datos
        ///</summary>
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\alex\\Mis documentos\\Visual Studio 2008\\Projects\\Sistema_Gestion\\Sistema_Gestion", "/")]
        [UrlToTest("http://localhost:1444/")]
        public void DatosConstructorTest()
        {
            Datos target = new Datos();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }
    }
}
