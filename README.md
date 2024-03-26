# **Veterinaria**

Aplicacion para un sistema de Veterinaria desarrollada por Giovanni Lucchetta. Si desea ver las consigas de este trabaja puede ingresar al [Enunciado](https://docs.google.com/document/d/1goHCF5AzQE_yP2rqEd3bpyyg3FjWshRw0BmN7tP6upo/edit?usp=sharing).

## Sobre mi:
Hola, soy Giovanni Lucchetta estudiante en Tecnico Universitario en Programacion (UTN-FRA). Disfrute mucho este trabajo, fue un desafio tener que entender e investigar como plantear el funcionamiento de la administracion de una Veterinaria, con esto aprendi las diferentes posturas para resolver un mismo problema utilizando todos los conceptos de la Programación Orientada a Objetos.

## **Resumen**
Al correr la apliacion se presenta con una venta para realizar el **Log In**. 

![](ImagenesReadme/Login.png)

En el cual se le pedira al usuario ingresar su **Nombre de Usuario** y **Contraseña**. El _Nombre de Usuario_ debera ser unico y no repetirse con los demas usuarios, y la _Contraseña_ debera tener un largo de por lo menos ocho digitos, contener una minuscula, una mayuscula, un numero y un simbolo.

Esta ventana consta con tres botones:
* **Entrar** : Verificando los campos ingresados, ingresara al **Menu Principal** de la apliacion, caso contrario informara un mensaje con el _error_
* **Icono Admin** _(Autocompletar)_ : Autocompleta los campos _Usuario_ y _Contraseña_ con datos validos para el facil acceso.
* **Ojo** _(Ocultar)_ : Alterna la visibilidad del campo _Contraseña_.
* **Salir** _(Salir)_ : Cerrara la ventanta y terminara con la aplicacion.

### **Menu Principal**
El programa cuenta con 3 tipos de usuarios diferentes que tienen acceso al programa.
Siendo estos:

* Administrador
* Recepcionista
* Veterinario

### **Feature general menues**:

* Display de Nombre de usuario, cargo dentro del programa, dia y horario.

* Todas los perfiles cuentan con botón para cambiar el tema, ya sea tema claro o oscuro, este cambia el estilo de la aplicación en cada una de sus pestañas persistiendo esta configuración en un archivo Json.

* Boton Desloguarse para poder cambiar de usuario o perfil si es requerido.

* Boton salir para salir de la aplicación.

### **Menu Principal Administrador**
![](ImagenesReadme/MenuAdministrador.PNG)

El administrador tiene la responsabilidad de:

* Crear los empleados en el sistema.
* Modificar cualquier dato que este posea en el sistema.
* Darles una baja LOGICA del sistema, sin quitarlos completamente.
* Cambiar de base de datos entre SQL Server y Firebase.


### **Menu Principal Recepcionista**
![](ImagenesReadme/MenuRecepcionista.PNG)

El rol "mas importante" lo tiene el recepcionista en cierto sentido, esto es porque es el encargado de que poder crear los turnos dentro de la entidad.


* **Nuevo Turno**:
  Para crear un nuevo turno debemos seleccionár la fecha, para esto tendremos un selector de 
  calendario desde el dia de la fecha.
  
![](ImagenesReadme/NuevoTurno.PNG)

  Luego de haber seleccionado la fecha se da paso a la selección de Mascota, si esta se 
  encuentra dentro del sistema entonces se podra ubicar con su identificación la cual, el dueño 
  deberá saber, o el nombre de la mascota y apellido del dueño.

  En caso de que esta mascota no exista hay un botón que permite darla de alta y luego volver a esta misma ventana.

![](ImagenesReadme/SeleccionarMascotas.PNG)

  Luego se pasa a detallar el malestar de la mascota y hay dos posibilidades.

  **Dicho Malestar no está registrado en el sistema**
  
  Si el malestar no fue ingresado previamente se deberá seleccionár la urgencia para que los veterinarios puedan identificar las urgencias y luego se haga una auto-asignación, o que el veterinario tome una 
  consulta y la atienda. guardara en un archivo para que luego con solo ingresar ese malestar, se auto asigne su 
  importancia y de **"estar disponible"** un medico calificado **(segun su especialidad registrada en el sistema)** para tratar dicho malestar.

  **Dicho Malestar está registrado en el sistema**

  Si el malestar fue ingresado previamente y es de prioridad **"Alta" o "Urgente"** se auto asigna su importancia y de **"estar disponible"** un medico calificado **(segun su especialidad registrada en el   
  sistema)** para tratar dicho malestar se le asgina automaticamente, de no haber un medico disponible quedará en la lista hasta que un medico la tome.

* **Asignar Veterinario**:
  El recepcionista tambien podrá asignar los turnos creados previamente a los medicos que no esten atendiendo actualmente.

![](ImagenesReadme/AsignarTurno.PNG)

  Mediante la selección de ambas listas, se selecciona un turno que no tenga un veterinario asignado, y un veterinario disponible y listo para atender.
  Una vez asignado el veterinario al turno, este desaparecerá de la lista y dicho veterinario verá sus turnos asignados.
  
### **Menu Principal Veterinario**
![](ImagenesReadme/MenuVeterinario.PNG)

* **Atender**
  El veterinario si no esta atendiendo, entonces figura en el sistema como libre, como aparece en el distintivo de arriba a la derecha, ese es su estado.

  Dentro de esta sección el medicó podrá encontrar los turnos que se les ha asignado, asi como tambien turnos de categoria Urgente que el puede atender si así decidiera.

  ##**Simulacro de atención**: 
![](ImagenesReadme/TurnoUrgente.PNG)
  Una vez seleccionada la mascota a atender, el estado del medico pasará a ocupado o **Atendiendo**.
![](ImagenesReadme/AtencionMascota.PNG)
  
    * A este le saldran multiples cuadros de información de visitas previas con información adicional que el medico haya dejado acerca de este.
    * En el cuadro de nueva observación podra detallar el tratamiento aplicado para dicha visita.

  Ya habiendo detallado la observación esta se guardará en el registro de dicha mascota.
![](ImagenesReadme/Atendida.PNG)

  Luego se desplegarán 2 botones, uno que mostrará los precios que se le agregarán al ticket que el dueño de la mascota deberá pagar.
  En esta se podrán seleccionar los tratamientos que se les fueron aplicados y se irá sumando al valor para generar el ticket final.
  Tambien se puede volver a mostrar el historial para revisar las visitas previas y alternar con la tabla de precios.
![](ImagenesReadme/ListaPrecios.PNG)

  Una vez generado el ticket el medico vuelve a estar Libre para poder seguir atendiendo.

  

  




  





