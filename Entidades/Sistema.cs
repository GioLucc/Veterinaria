using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        public static List<Usuario> usuarios;
        public static List<Mascota> mascotas;
        public static int idCliente = 0;
        public static short idUsuarios = 0;

        static Sistema()
        {
            usuarios = new List<Usuario>();
            mascotas = new List<Mascota>();
            HardCodearUsuarios();
            HardCodearMascotas();
        }

        private static void HardCodearMascotas()
        {
            mascotas.Add(new Mascota("Felino", "Europeo", 44, 'H', "Parasitos", "Mew", "Giovanni", Sistema.GenerarId(),Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Perro", "Labrador", 15.5f, 'M', "Ninguna", "Max", "Juan", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Gato", "Siames", 5.2f, 'H', "Gripe felina", "Luna", "Maria", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Perro", "Bulldog", 18.0f, 'H', "Ninguna", "Rocky", "Jose", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Gato", "Persa", 7.8f, 'M', "Parasitos", "Grisu", "Ana", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Perro", "Chihuahua", 2.3f, 'H', "Alergia", "Toby", "Luis", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Gato", "Egipcio", 6.5f, 'M', "Ninguna", "Cleo", "Lucia", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Perro", "Poodle", 8.0f, 'M', "Dolor de estomago", "Lucky", "Pedro", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Gato", "Bengala", 4.9f, 'H', "Ninguna", "Tigre", "Sofia", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Perro", "Schnauzer", 13.7f, 'H', "Ninguna", "Duke", "Carla", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Labrador", 20, 'H', "Ninguna", "Rufus", "Maria", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Felino", "Siames", 8, 'M', "Gripe felina", "Whiskers", "Carlos", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Ave", "Perico", 0.3f, 'H', "Ninguna", "Polly", "Andrea", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Roedor", "Hamster", 0.2f, 'M', "Mordedura", "Nibbles", "David", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Bulldog", 15, 'M', "Dolor de espalda", "Brutus", "Sophie", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Felino", "Persa", 5, 'H', "Alergias", "Oliver", "Emily", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Ave", "Canario", 0.1f, 'H', "Ninguna", "Tweety", "Rachel", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Roedor", "Cobaya", 0.5f, 'M', "Gripe", "Oreo", "Jenny", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Chihuahua", 2, 'M', "Problemas dentales", "Taco", "Juan", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Felino", "Bengala", 6, 'H', "Otitis", "Simba", "Alex", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Ave", "Loro", 0.4f, 'M', "Ninguna", "Squawkers", "Tiffany", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Roedor", "Rata", 0.3f, 'H', "Ninguna", "Squeakers", "Kevin", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Pug", 8, 'H', "Dolor de articulaciones", "Pugsley", "Linda", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Felino", "Egipcio", 4, 'M', "Asma", "Nefertiti", "Isabella", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Labrador", 22, 'H', "Ninguna", "Rocky", "Laura", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Felino", "Siames", 6, 'M', "Alergias", "Simba", "Juan", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Ave", "Canario", 0.5f, 'M', "Ninguna", "Tweety", "Maria", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Chihuahua", 3, 'H', "Fractura", "Lucky", "Alejandro", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Felino", "Persa", 8, 'H', "Ninguna", "Garfield", "Fernanda", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Canino", "Pug", 10, 'M', "Obesidad", "Buddy", "Pedro", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            mascotas.Add(new Mascota("Ave", "Perico", 1, 'M', "Ninguna", "Paco", "Sofia", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));

        }
        private static void HardCodearUsuarios()
        {
            usuarios.Add(new Usuario(Sistema.GenerarIdCliente(), "Alejandro", "Heidenreich", 17636215, 57, "0nimdaPetShop", "WtTK*Qv%nauSUDo2M0^F", true,Jerarquia.Administrador,true));
            usuarios.Add(new Usuario(Sistema.GenerarIdCliente(), "Carlos", "Arnauti", 5636215, 78, "01nimdaPetShop", "D75MUx8KiN@%5Yo6AMK6", true, Jerarquia.Administrador, true));
            usuarios.Add(new Usuario(Sistema.GenerarIdCliente(), "Giovanni", "Lucchetta", 44756215, 30, "pepito", "jose", true, Jerarquia.Trabajador, true));
            usuarios.Add(new Usuario(Sistema.GenerarIdCliente(), "Stefano", "Alessandro", 54336211, 59, "03nimdaPetShop", "K!cca29o9f80p6%WGp$#", true, Jerarquia.Trabajador, true));
            usuarios.Add(new Usuario(Sistema.GenerarIdCliente(), "Alberto", "Saenz", 44756215, 30, "pepe123", "pepe123", false, Jerarquia.Cliente, true));
            usuarios.Add(new Usuario(Sistema.GenerarIdCliente(), "Alfonso", "Margel", 54336211, 59, "pepe1234", "pepe1234", false, Jerarquia.Cliente, true));
        }

        public static Usuario? ValidarUsuario(string nombreDeusuario, string contraseniaDeUsuario)
        {
            //clase  elemento lista
            foreach (Usuario item in usuarios)
            {
                if (nombreDeusuario == item.NombreUsuario && contraseniaDeUsuario == item.ContraseniaUsuario)
                {
                    return item;
                }
            }

            return null;
        }

        public static DateTime GenerarFechaNacimientoAleatoria()
        {
            Random random = new Random();
            DateTime fechaInicial = new DateTime(1999, 1, 1);
            int rangoDias = (DateTime.Today - fechaInicial).Days;
            DateTime fechaAleatoria = fechaInicial.AddDays(random.Next(rangoDias));
            return fechaAleatoria;
        }

        public static int GenerarId()
        {
            return idCliente++;
        }        
        public static short GenerarIdCliente()
        {
            return idUsuarios++;
        }
    }

    
}
