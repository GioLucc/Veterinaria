using Entidades.Archivos_y_Serializadores;
using Entidades.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Turno;
using System.Net.Http;

namespace Entidades
{
    public static class Sistema
    {
        
        public static List<Usuario> usuario;
        public static List<Veterinario> veterinarios;
        public static List<Veterinario> vetsDB;
        public static List<Mascota> AnimalDomesticos;
        public static List<Turno> turnos;
        public static List <String> urgenciasMedicas;
        public static List<PrecioItem> listaPrecios = new List<PrecioItem>();
        public static Dictionary<string, List<string>> assetsDelSistema;        
        public static int idCliente = 1;
        public static short idUsuarios = 0;
        public static Dictionary<string, List<string>> malestaresPorGravedad = new Dictionary<String, List<string>>();


        static Sistema()
        {
            Administrador admin = new Administrador();
            usuario = new List<Usuario>();
            vetsDB = new List<Veterinario>();
            veterinarios = new List<Veterinario>();
            urgenciasMedicas = new List<String>();
            turnos = new List<Turno>();
            AnimalDomesticos = new List<Mascota>();
            VeterinarioDAO alta = new VeterinarioDAO();
            HardcodearListaPreciosConsulta(listaPrecios);
            HardCodearAnimalDomesticos();
            HardCodearUrgenciasMedicas();
            HardCodearTurnos();
            EstablecerAssetsDelSistema();
            //veterinarioAux = alta.TraerVeterinarios();
            SerializadoraXML<Dictionary<string, List<string>>> serializadora = new SerializadoraXML<Dictionary<string, List<string>>>();
            //serializadora.Escribir("path", Sistema.malestaresPorGravedad);
            malestaresPorGravedad = serializadora.LeerMalestar("a");

            //foreach (Mascota item in Sistema.AnimalDomesticos)
            //{
            //    MascotaDAO.Agregar(item);
            //}

            //foreach (Usuario user in usuario)
            //{
            //    if (user is Veterinario)
            //    {
            //        Veterinario veterinario = new Veterinario(user.Id,user.Nombre,user.Apellido,user.Dni,user.Edad,user.NombreUsuario,user.ContraseniaUsuario,user.Activo,user.Sueldo,user.);


            //    }

            //}

            //foreach (Veterinario item in vetsDB)
            //{
            //    alta.AgregarVeterinario(item);
            //}

            veterinarios = alta.TraerVeterinarios();

            if (veterinarios.Count < 1)
            {
                HardCodearUsuarios();

                foreach (Veterinario item in vetsDB)
                {
                    alta.AgregarVeterinario(item);

                }

            }

        }



        #region Hardcodeos

        private static void HardcodearListaPreciosConsulta(List<PrecioItem> listaPrecios)
        {
            List<PrecioItem> listaPrecios1 = new List<PrecioItem>
            {
                new PrecioItem { Descripcion = "Consulta general", Precio = 1500.00m },
                new PrecioItem { Descripcion = "Vacunación", Precio = 800.00m },
                new PrecioItem { Descripcion = "Desparasitación", Precio = 500.00m },
                new PrecioItem { Descripcion = "Cirugía", Precio = 5000.00m },
                new PrecioItem { Descripcion = "Radiografía", Precio = 2000.00m },
                new PrecioItem { Descripcion = "Análisis de sangre", Precio = 1200.00m },
                new PrecioItem { Descripcion = "Esterilización", Precio = 3500.00m },
                new PrecioItem { Descripcion = "Limpieza dental", Precio = 900.00m },
                new PrecioItem { Descripcion = "Ecografía", Precio = 1800.00m },
                new PrecioItem { Descripcion = "Tratamiento de piel", Precio = 2500.00m },
                new PrecioItem { Descripcion = "Control de embarazo", Precio = 1800.00m },
                new PrecioItem { Descripcion = "Odontología", Precio = 1500.00m },
                new PrecioItem { Descripcion = "Baño y peluquería", Precio = 700.00m },
                new PrecioItem { Descripcion = "Examen de oídos", Precio = 600.00m },
                new PrecioItem { Descripcion = "Control de presión arterial", Precio = 1200.00m },
                new PrecioItem { Descripcion = "Tratamiento de ojos", Precio = 2000.00m },
                new PrecioItem { Descripcion = "Control de diabetes", Precio = 1500.00m },
                new PrecioItem { Descripcion = "Desparasitación interna", Precio = 400.00m },
                new PrecioItem { Descripcion = "Terapia física", Precio = 3000.00m },
                new PrecioItem { Descripcion = "Corte de uñas", Precio = 400.00m },
                new PrecioItem { Descripcion = "Inyección antipulgas", Precio = 600.00m },
                new PrecioItem { Descripcion = "Inyección antiparasitaria", Precio = 800.00m },
                new PrecioItem { Descripcion = "Inyección antirrábica", Precio = 500.00m },
                new PrecioItem { Descripcion = "Inyección antiviral", Precio = 700.00m },
                new PrecioItem { Descripcion = "Inyección antialérgica", Precio = 1000.00m },
                new PrecioItem { Descripcion = "Inyección antiinflamatoria", Precio = 900.00m },
                new PrecioItem { Descripcion = "Inyección antibiótica", Precio = 1200.00m },
                new PrecioItem { Descripcion = "Inyección antidiarreica", Precio = 800.00m },
                new PrecioItem { Descripcion = "Inyección antifúngica", Precio = 1100.00m },
                new PrecioItem { Descripcion = "Inyección anticonceptiva", Precio = 1000.00m },
                new PrecioItem { Descripcion = "Inyección antihistamínica", Precio = 850.00m },
                new PrecioItem { Descripcion = "Inyección antiparasitaria interna", Precio = 900.00m },
                new PrecioItem { Descripcion = "Inyección antiinflamatoria muscular", Precio = 1200.00m },
                new PrecioItem { Descripcion = "Inyección antiviral respiratoria", Precio = 1100.00m },
                new PrecioItem { Descripcion = "Inyección anticonceptiva hormonal", Precio = 1500.00m },
                new PrecioItem { Descripcion = "Inyección antiparasitaria externa", Precio = 700.00m },
                new PrecioItem { Descripcion = "Inyección antialérgica nasal", Precio = 1000.00m },
                new PrecioItem { Descripcion = "Inyección antifúngica cutánea", Precio = 950.00m },
                new PrecioItem { Descripcion = "Inyección antiparasitaria intestinal", Precio = 800.00m },
                new PrecioItem { Descripcion = "Inyección antidiarreica viral", Precio = 900.00m }
            };

            Sistema.listaPrecios = listaPrecios1;
        }

        private static void HardCodearAnimalDomesticos()
        {
            AnimalDomesticos.Add(new Mascota("Felino", "Europeo", 44, 'H', "Mew", "Lucchetta", Sistema.GenerarId(),Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Perro", "Labrador", 15.5f, 'M', "Max", "Juan", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Gato", "Siames", 5.2f, 'H', "Luna", "Maria", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Perro", "Bulldog", 18.0f, 'H', "Rocky", "Jose", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Gato", "Persa", 7.8f, 'M', "Grisu", "Ana", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Perro", "Chihuahua", 2.3f, 'H', "Toby", "Luis", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Gato", "Egipcio", 6.5f, 'M', "Cleo", "Lucia", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Perro", "Poodle", 8.0f, 'M', "Lucky", "Pedro", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Gato", "Bengala", 4.9f, 'H', "Tigre", "Sofia", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Perro", "Schnauzer", 13.7f, 'H', "Duke", "Carla", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Labrador", 20, 'H', "Rufus", "Maria", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Felino", "Siames", 8, 'M', "Whiskers", "Carlos", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Ave", "Perico", 0.3f, 'H', "Polly", "Andrea", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Roedor", "Hamster", 0.2f, 'M', "Nibbles", "David", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Bulldog", 15, 'M', "Brutus", "Sophie", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Felino", "Persa", 5, 'H', "Oliver", "Emily", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Ave", "Canario", 0.1f, 'H',  "Tweety", "Rachel", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Roedor", "Cobaya", 0.5f, 'M',  "Oreo", "Jenny", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Chihuahua", 2, 'M',  "Taco", "Juan", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Felino", "Bengala", 6, 'H',  "Simba", "Alex", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Ave", "Loro", 0.4f, 'M',  "Squawkers", "Tiffany", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Roedor", "Rata", 0.3f, 'H',  "Squeakers", "Kevin", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Pug", 8, 'H',  "Pugsley", "Linda", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Felino", "Egipcio", 4, 'M',  "Nefertiti", "Isabella", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Labrador", 22, 'H',  "Rocky", "Laura", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Felino", "Siames", 6, 'M',  "Simba", "Juan", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Ave", "Canario", 0.5f, 'M',  "Tweety", "Maria", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Chihuahua", 3, 'H',  "Lucky", "Alejandro", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Felino", "Persa", 8, 'H',  "Garfield", "Fernanda", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Canino", "Pug", 10, 'M',  "Buddy", "Pedro", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));
            AnimalDomesticos.Add(new Mascota("Ave", "Perico", 1, 'M',  "Paco", "Sofia", Sistema.GenerarId(), Sistema.GenerarFechaNacimientoAleatoria()));


        }
        private static void HardCodearUrgenciasMedicas()
        {
            urgenciasMedicas.Add("Caida larga distancia");
            urgenciasMedicas.Add("Sangrado Masivo");
            urgenciasMedicas.Add("Colapso");
            urgenciasMedicas.Add("Envenenamiento");
            urgenciasMedicas.Add("Ingestión de Veneno");
            urgenciasMedicas.Add("Complicaciones Quirurgicas");
            urgenciasMedicas.Add("Atropellamiento");

            
        }
        private static void HardCodearUsuarios()
        {
            usuario.Add(new Administrador(Sistema.GenerarIdCliente(), "Alejandro", "Heidenreich", 17636215, 57, "nimdaPetShop0", "WtTK*Qv%nauSUDo2M0^F",true, 120000,"giolucarna@gmail.com"));
            usuario.Add(new Recepcionista(Sistema.GenerarIdCliente(), "Carlos", "Arnauti", 5636215, 78, "1", "1", true,120000));
            vetsDB.Add(new Veterinario(Sistema.GenerarIdCliente(), "Giovanni", "Lucchetta", 44756215, 30, "2", "2",  true, 80000,"Cirujano",false));
            vetsDB.Add(new Veterinario(Sistema.GenerarIdCliente(), "Stefano", "Alessandro", 54336211, 59, "03nimdaPetShop", "K!cca29o9f80p6%WGp$#", true, 80000, "Guardia Urgencias", false));
            vetsDB.Add(new Veterinario(Sistema.GenerarIdCliente(), "Alberto", "Saenz", 44756215, 30, "pepe123", "pepe123", true, 80000,"Guardia",true));
            vetsDB.Add(new Veterinario(Sistema.GenerarIdCliente(), "Alfonso", "Margel", 54336211, 59, "1", "1",  true, 80000, "Guardia", true));
            vetsDB.Add(new Veterinario(Sistema.GenerarIdCliente(), "Alfonso", "Margel", 54336211, 59, "pepe1234", "pepe1234", true, 80000, "Guardia", true));
            vetsDB.Add(new Veterinario(Sistema.GenerarIdCliente(), "Alfonso", "Margel", 54336211, 59, "pepe1234", "pepe1234", true, 80000, "Guardia", true));
        }
        private static void HardCodearTurnos()
        {
            Turno turno1 = new Turno(
                DateTime.Now,
                new Mascota("Perro", "Labrador", 15.5f, 'M', "Max", "Pérez", 1, new DateTime(2018, 5, 10)),
                new Veterinario(1, "Juan", "Gómez", 12345678, 35, "juang", "123456",  true, 2500.50f, "Caninos", true),
                "Vómitos",
                Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.Atendido
            ); ;
            turnos.Add(turno1);

            Turno turno2 = new Turno(
                DateTime.Now.AddDays(1),
                new Mascota("Gato", "Siames", 4.2f, 'F', "Luna", "González", 2, new DateTime(2019, 8, 15)),
                new Veterinario(2, "Ana", "López", 23456789, 28, "anal", "987654", true, 2300.75f, "Felinos", true),
                "Fiebre",
                Turno.PrioridadAtencion.Media, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno2);

            Turno turno3 = new Turno(
            DateTime.Now.AddDays(2),
            new Mascota("Gato", "Persa", 3.8f, 'M', "Simba", "Rodríguez", 3, new DateTime(2020, 10, 20)),
            new Veterinario(3, "María", "Martínez", 34567890, 32, "mariam", "abcdef", true, 2200.50f, "Felinos", true),
            "Diarrea",
            Turno.PrioridadAtencion.Media, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno3);

            Turno turno4 = new Turno(
                DateTime.Now.AddDays(3),
                new Mascota("Perro", "Bulldog", 18.7f, 'M', "Rocky", "Gutiérrez", 4, new DateTime(2017, 4, 8)),
                new Veterinario(4, "Carlos", "López", 45678901, 40, "carlosl", "qwerty",  true, 2800.75f, "Caninos", true),
                "Cojera",
                Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno4);

            Turno turno5 = new Turno(
            DateTime.Now,
            new Mascota("Gato", "Siamés", 10.2f, 'F', "Luna", "González", 2, new DateTime(2019, 8, 20)),
            new Veterinario(2, "María", "López", 98765432, 28, "marial", "654321",  true, 2000.75f, "Felinos", true),
            "Diarrea",
            Turno.PrioridadAtencion.Normal, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno5);

            Turno turno6 = new Turno(
                DateTime.Now,
                new Mascota("Perro", "Bulldog", 18.9f, 'M', "Rocky", "Rodríguez", 3, new DateTime(2016, 3, 5)),
                new Veterinario(3, "Pedro", "Martínez", 56789123, 42, "pedrom", "987654", true, 3000.25f, "Caninos", true),
                "Fiebre",
                Turno.PrioridadAtencion.Normal, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno6);

            Turno turno7 = new Turno(
            DateTime.Now,
            new Mascota("Gato", "Persa", 5.7f, 'M', "Simba", "López", 4, new DateTime(2020, 11, 15)),
            new Veterinario(4, "Ana", "Hernández", 11223344, 31, "anah", "abcdefgh", true, 2200.0f, "Felinos", true),
            "Ojos llorosos",
            Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.Atendido
        );
            turnos.Add(turno7);

            Turno turno8 = new Turno(
                DateTime.Now,
                new Mascota("Perro", "Golden Retriever", 22.1f, 'F', "Bella", "Fernández", 5, new DateTime(2017, 7, 25)),
                new Veterinario(5, "Carlos", "Sánchez", 99887766, 37, "carloss", "p@ssw0rd",  true, 2800.50f, "Caninos", true),
                "Herida en pata",
                Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno8);

            Turno turno9 = new Turno(
                DateTime.Now,
                new Mascota("Gato", "Maine Coon", 8.5f, 'F', "Lola", "Torres", 16, new DateTime(2022, 1, 12)),
                new Veterinario(16, "Isabel", "Cruz", 65432109, 29, "isabelc", "password",  true, 2100.0f, "Felinos", true),
                "Pérdida de apetito",
                Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.Atendido
            );
            turnos.Add(turno9);

            
            Turno turno10 = new Turno(
                DateTime.Now,
                new Mascota("Perro", "Bulldog Francés", 12.8f, 'M', "Rocko", "Vargas", 17, new DateTime(2015, 9, 8)),
                new Veterinario(17, "Fernanda", "Rojas", 98765432, 34, "fernandar", "abcd1234",  true, 3200.25f, "Caninos", true),
                "Problemas respiratorios",
                Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.SinVeterinario
            );
            HistorialMedico asd1 = new HistorialMedico(DateTime.Now, "Parasitos", "Beso en la frente", turno10.NombreVet);
            turno10.Mascota.HistoriaClinica.Add(asd1);
            turnos.Add(turno10);

            Turno turno11 = new Turno(
                DateTime.Now,
                new Mascota("Gato", "Bengalí", 6.3f, 'F', "Mia", "García", 28, new DateTime(2021, 4, 3)),
                new Veterinario(28, "Ricardo", "Pérez", 11223344, 32, "ricardop", "qwerty", true, 1900.0f, "Felinos", true),
                "Picazón en la piel",
                Turno.PrioridadAtencion.Media, Turno.EstadoDeTurno.SinVeterinario
                
            );

            HistorialMedico asd = new HistorialMedico(DateTime.Now, "Parasitos","Beso en la frente", turno11.NombreVet);
            HistorialMedico asd2 = new HistorialMedico(DateTime.Now, "Dolor de panza","Buscapina", turno11.NombreVet);
            HistorialMedico asd3 = new HistorialMedico(DateTime.Now, "Pata rota", "Enyesado", turno11.NombreVet);
            HistorialMedico asd4 = new HistorialMedico(DateTime.Now, "Atropellamiento","Operación\nEnyesado ", turno11.NombreVet);
            HistorialMedico asd5 = new HistorialMedico(DateTime.Now, "Fiebre alta","Medicamentos", turno11.NombreVet);
            turno11.Mascota.HistoriaClinica.Add(asd);
            turno11.Mascota.HistoriaClinica.Add(asd2);
            turno11.Mascota.HistoriaClinica.Add(asd3);
            turno11.Mascota.HistoriaClinica.Add(asd4);
            turno11.Mascota.HistoriaClinica.Add(asd5);
            turnos.Add(turno11);

            AnimalDomesticos.Add(turno11.Mascota);

        }
        private static void EstablecerAssetsDelSistema()
        {
            List<string> listaImagenes = new List<string>();
            listaImagenes.Add("E:\\C# UTNFra\\CSharp-UTNFra\\Veterinaria\\Assets\\admin.png");
            //assetsDelSistema["Imagenes"] =
        }


        #endregion

        public static Usuario ValidarUsuario(string nombreDeusuario, string contraseniaDeUsuario)
        {
            //clase  elemento lista
            foreach (Usuario item in usuario)
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
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaNacimientoRecibida = fechaNacimiento;
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual < fechaNacimientoRecibida.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }
        public static short GenerarIdCliente()
        {
            return idUsuarios++;
        }

        private static void EnviarCorreoElectronico(string usuario)
        {
            string destinatario = usuario; // Aquí debes establecer la dirección de correo del destinatario
            string asunto = "Intentos de inicio de sesión excedidos";
            string cuerpo = "Se han excedido los intentos de inicio de sesión para el administrador: " + usuario;

            // Configurar el cliente SMTP
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new NetworkCredential("giovanni1399@hotmail.com", "");

            // Crear el mensaje de correo
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("correo-emisor");
            mensaje.To.Add(destinatario);
            mensaje.Subject = asunto;
            mensaje.Body = cuerpo;

            // Enviar el correo electrónico
            clienteSmtp.Send(mensaje);
        }
    }

    
}
