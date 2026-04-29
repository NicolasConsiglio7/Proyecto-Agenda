using LogicaAccesoDatos.Repositorios;
using LogicaAccesoDatos.Seed;
using LogicaAplicacion.CU.CUsuario;
using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.IRepositorios;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepositorioUsuario repo = new RepositorioUsuario();

            DatosDePrueba.Cargar(repo);

            ILoginUsuario loginCU = new CULogin(repo);

            Console.WriteLine("=== LOGIN ===");

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            try
            {
                var usuario = loginCU.Ejecutar(email, password);

                Console.WriteLine("");
                Console.WriteLine("Login exitoso");
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("Rol: " + usuario.Rol);
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();

        }
    }
}