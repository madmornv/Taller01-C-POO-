using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1POO__ejercicio_
{
                            /*Ejercicio 1: Sistema de Gestión de Personas (Abstracción y Encapsulamiento)
                        Una empresa necesita un sistema para gestionar información de personas.
                        Implementa una clase Persona con los siguientes atributos privados:
                        • Nombre (cadena de texto).
                        • Edad (entero).
                        • Documento (cadena de texto).
                        Implementa métodos MostrarDatos(), que debe imprimir los datos de la persona en
                        consola, y EsMayorDeEdad(), que devuelva true si la persona tiene 18 años o más
                        y false en caso contrario.
                        Para garantizar la seguridad de los datos, encapsula los atributos y usa
                        propiedades con validación para evitar que se ingrese una edad negativa.
                        En el Main(), crea una instancia de Persona, asigna valores a sus atributos e
                        imprime los datos en pantalla usando el método MostrarDatos().*/



    /*class Persona (abstracción)
        {

            //encapsulamiento

            // atributos privados 
            private string nombre;
            private int edad;
            private string documento;

            // propiedades -> controlan el acceso a los atributos privados
            public string Nombre
            {
                get { return nombre; } //leer
                set { nombre = value; } //asignar
            }

            public int Edad
            {
                get { return edad; }
                set
                {
                    if (value >= 0) //validación
                        edad = value;
                    else
                        Console.WriteLine("La edad no puede ser negativa.");
                }
            }

            public string Documento
            {
                get { return documento; }
                set { documento = value; }
            }


            
            // método mostrar datos
            public void MostrarDatos()
            {
                Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Documento: {Documento}");
            }

            // comprobar si es mayor de edad true or false
            public bool EsMayorDeEdad()
            {
                return Edad >= 18;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                //------- objeto 1 -------
                Persona persona1 = new Persona(); //se usa new para crear un objeto
                persona1.Nombre = "Sabrina";      //se asigna valor con propiedad
                persona1.Edad = 4;
                persona1.Documento = "123456789";
                persona1.MostrarDatos();
                Console.WriteLine("¿Es mayor de edad? " + persona1.EsMayorDeEdad());

                Console.WriteLine("--------------------------------");

                //------- objeto 2-------
                Persona persona2 = new Persona(); 
                persona2.Nombre = "Zeus";         
                persona2.Edad = 20;
                persona2.Documento = "987654321";
                persona2.MostrarDatos();
                Console.WriteLine("¿Es mayor de edad? " + persona2.EsMayorDeEdad());

                Console.ReadLine();
            }
        }*/





    //-------------------------------------------------------------------------------------------------------------------------------------

                                /*Ejercicio 2: Cuenta Bancaria (Encapsulamiento y Validaciones)
                             Desarrolla una clase CuentaBancaria para representar una cuenta de banco. La
                             cuenta debe tener los siguientes atributos privados:
                             • Titular (nombre del dueño de la cuenta).
                             • Saldo (cantidad de dinero disponible).
                             • NumeroCuenta (número identificador de la cuenta).
                             Debe implementar los siguientes métodos:

                             • Depositar(decimal cantidad): Aumenta el saldo en la cantidad ingresada.
                             • Retirar(decimal cantidad): Disminuye el saldo, pero no permite que este sea
                             menor a cero.
                             • MostrarSaldo(): Imprime en consola el saldo actual.
                             En el Main(), crea una cuenta bancaria, realiza depósitos y retiros, e imprime el
                             saldo para verificar que el encapsulamiento y las validaciones funcionan
                             correctamente. */



    /* class CuentaBancaria   // Clase (abstracción)
    {
        // -------- Encapsulamiento --------
        private string titular;        // dueño de la cuenta
        private decimal saldo;         // dinero disponible
        private string numeroCuenta;   // identificador

        // Propiedades -> control acceso a los atributos
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            private set
            {
                if (value >= 0)        // validación: no saldo negativo
                    saldo = value;
            }
        }

        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

         //Métodos 
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)   // solo se deposita #positivo
            {
                Saldo += cantidad;
                Console.WriteLine($"Depósito exitoso: +{cantidad}. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("El depósito debe ser mayor a 0.");
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)   // nodeja sacar más de lo que hay
            {
                Saldo -= cantidad;
                Console.WriteLine($"Retiro exitoso: -{cantidad}. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes o cantidad inválida.");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo actual: {Saldo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // -------- Crear objeto cuenta --------
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.Titular = "Ana Gómez";
            cuenta.NumeroCuenta = "ABC123";

            // probar operaciones
            cuenta.Depositar(500);      // aumenta saldo
            cuenta.Retirar(200);        // resta saldo
            cuenta.Retirar(400);        // no debe permitir
            cuenta.MostrarSaldo();      // ver saldo final

            Console.ReadLine();
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

                                /*Ejercicio 3: Sistema de Vehículos (Herencia y Polimorfismo)
                            Una concesionaria de vehículos necesita un sistema que organice la información de
                            los vehículos en venta.
                            1. Crea una clase base Vehiculo con las propiedades:
                            o Marca (ejemplo: Toyota, Honda, BMW).
                            o Modelo (ejemplo: Corolla, Civic, X5).
                            o Año (año de fabricación).
                            o Precio (precio del vehículo).
                            2. Crea dos clases que hereden de Vehiculo:
                            o Automovil, con la propiedad adicional CantidadPuertas.
                            o Motocicleta, con la propiedad adicional Cilindraje.
                            3. Implementa un método MostrarInfo() en la clase Vehiculo y sobrescríbelo en
                            Automovil y Motocicleta para que muestren su información específica.
                            4. En el Main(), crea instancias de cada tipo de vehículo y usa polimorfismo
                            para mostrar su información.*/



    /* // Clase(PADRE) → HERENCIA
     class Vehiculo
     {
         // Propiedades comunes de los vehículos
         public string Marca { get; set; }
         public string Modelo { get; set; }
         public int Año { get; set; }
         public decimal Precio { get; set; }

         // Método virtual →deja POLIMORFISMO
         public virtual void MostrarInfo()
         {
             Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Precio: {Precio}");
         }
     }

     // Clase hija
     class Automovil : Vehiculo
     {
         // Propiedad solo de los autos
         public int CantidadPuertas { get; set; }

         // Sobrescribir el método MostrarInfo → POLIMORFISMO
         public override void MostrarInfo()
         {
             Console.WriteLine($"[Automóvil] Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Precio: {Precio}, Puertas: {CantidadPuertas}");
         }
     }

     // Clase hija
     class Motocicleta : Vehiculo
     {
         // Propiedad solo de las motos
         public int Cilindraje { get; set; }

         // Sobrescribimos el método MostrarInfo → POLIMORFISMO
         public override void MostrarInfo()
         {
             Console.WriteLine($"[Motocicleta] Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Precio: {Precio}, Cilindraje: {Cilindraje}cc");
         }
     }

     class Program
     {
         static void Main(string[] args)
         {
             // Creamos objetos (INSTANCIAS) de Automovil y Motocicleta
             Automovil auto = new Automovil()
             {
                 Marca = "Toyota",
                 Modelo = "Corolla",
                 Año = 2022,
                 Precio = 75000000,
                 CantidadPuertas = 4
             };

             Motocicleta moto1 = new Motocicleta()
             {
                 Marca = "Yamaha",
                 Modelo = "R3",
                 Año = 2023,
                 Precio = 28000000,
                 Cilindraje = 321
             };

             Motocicleta moto2 = new Motocicleta()

             {
                 Marca = "Honda",
                 Modelo = "CBR500R",
                 Año = 2023,
                 Precio = 35000000,
                 Cilindraje = 471
             };


         // Lista POLIMÓRFICA (contiene Vehiculos, pero guarda autos y motos)
         List<Vehiculo> listaVehiculos = new List<Vehiculo>();
             listaVehiculos.Add(auto);
             listaVehiculos.Add(moto1);
             listaVehiculos.Add(moto2);

             // Recorremos y aplicamos polimorfismo
             Console.WriteLine("=== Información de Vehículos ===");
             foreach (Vehiculo v in listaVehiculos)
             {
                 v.MostrarInfo(); // Aquí se aplica polimorfismo (ejecuta el método correcto según el objeto)
             }

             Console.ReadLine(); // Pausa consola
         }
     }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

                            /*Ejercicio 4: Tienda en Línea (Encapsulamiento y Herencia)
                            Desarrolla un sistema básico para gestionar productos en una tienda en línea.
                            1. Crea una clase Producto con los atributos:
                        o Nombre.
                        o Precio.
                        o Stock (cantidad disponible).
                        2. Crea dos clases que hereden de Producto:
                        o Electronico, con un atributo adicional GarantiaMeses.
                            o Ropa, con un atributo adicional Talla.
                            3. Implementa un método AplicarDescuento() en Producto, y sobrescríbelo en
                            Electronico (10% de descuento) y Ropa(20% de descuento).
                        4. En el Main(), crea instancias de cada tipo de producto, aplica los descuentos
                        y muestra la información con el precio final.*/


    /*// Clase base
    public class Producto
    {
        // Encapsulamiento con propiedades
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Producto(string nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        // Método aplicar descuento
        public virtual void AplicarDescuento()
        {
            Console.WriteLine($"{Nombre} no tiene descuento especial. Precio: {Precio:C}");
        }

        // Mostrar info general
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: {Precio:C}, Stock: {Stock}");
        }
    }

    // clase hija
    public class Electronico : Producto
    {
        public int GarantiaMeses { get; set; }

        public Electronico(string nombre, double precio, int stock, int garantiaMeses)
            : base(nombre, precio, stock)
        {
            GarantiaMeses = garantiaMeses;
        }

        // Sobrescribir el método de descuento → 10%
        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.10; // restar el 10%
            Console.WriteLine($"{Nombre} (Electrónico) con descuento aplicado. Nuevo precio: {Precio:C}");
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Electrónico: {Nombre}, Precio: {Precio:C}, Stock: {Stock}, Garantía: {GarantiaMeses} meses");
        }
    }

    //Clase hija
    public class Ropa : Producto
    {
        public string Talla { get; set; }

        public Ropa(string nombre, double precio, int stock, string talla)
            : base(nombre, precio, stock)
        {
            Talla = talla;
        }

        // Sobrescribir el método de descuento → 20%
        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.20; // restar el 20%
            Console.WriteLine($"{Nombre} (Ropa) con descuento aplicado. Nuevo precio: {Precio:C}");
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Ropa: {Nombre}, Precio: {Precio:C}, Stock: {Stock}, Talla: {Talla}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos (new)
            Electronico laptop = new Electronico("Laptop HP", 3000, 5, 24);
            Ropa camiseta = new Ropa("Camiseta Nike", 100, 20, "M");

            // Mostrar info inicial
            laptop.MostrarInfo();
            camiseta.MostrarInfo();

            Console.WriteLine("\n--- Aplicando Descuentos ---");

            // Aplicar polimorfismo → cada objeto aplica su propio descuento
            Producto[] productos = { laptop, camiseta };
            foreach (var producto in productos)
            {
                producto.AplicarDescuento();
                producto.MostrarInfo();
            }
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------


                            /* Ejercicio 5: Gestión de Empleados(Herencia y Polimorfismo)

                         Una empresa necesita calcular los salarios de sus empleados según su modalidad
                         de trabajo.
                         1. Crea una clase Empleado con:
                         o Nombre.
                         o SalarioBase.
                         o Un método CalcularSalario().
                         2. Crea dos clases que hereden de Empleado:
                         o EmpleadoTiempoCompleto, donde CalcularSalario() devuelve
                         SalarioBase.
                         o EmpleadoPorHoras, que tiene la propiedad HorasTrabajadas y calcula
                         el salario multiplicando HorasTrabajadas* SalarioBase.

                         3. En el Main(), crea instancias de cada tipo de empleado y muestra sus
                         salarios.*/




    /* // Clase base
     public class Empleado
     {
         public string Nombre { get; set; }
         public double SalarioBase { get; set; }

         // Constructor
         public Empleado(string nombre, double salarioBase)
         {
             Nombre = nombre;
             SalarioBase = salarioBase;
         }

         // Método calcular salario
         public virtual double CalcularSalario()
         {
             return SalarioBase; // por defecto
         }

         // Mostrar info
         public virtual void MostrarInfo()
         {
             Console.WriteLine($"Empleado: {Nombre}, Salario: {CalcularSalario()}");
         }
     }

     // Clase hija
     public class EmpleadoTiempoCompleto : Empleado
     {
         public EmpleadoTiempoCompleto(string nombre, double salarioBase)
             : base(nombre, salarioBase)
         {
         }

         // El salario es el base
         public override double CalcularSalario()
         {
             return SalarioBase;
         }

         public override void MostrarInfo()
         {
             Console.WriteLine($"[Tiempo Completo] {Nombre}, Salario: {CalcularSalario()}");
         }
     }

     // Clase hija
     public class EmpleadoPorHoras : Empleado
     {
         public int HorasTrabajadas { get; set; }

         public EmpleadoPorHoras(string nombre, double salarioPorHora, int horasTrabajadas)
             : base(nombre, salarioPorHora)
         {
             HorasTrabajadas = horasTrabajadas;
         }

         // Calculo del salaraio
         public override double CalcularSalario()
         {
             return HorasTrabajadas * SalarioBase;
         }

         public override void MostrarInfo()
         {
             Console.WriteLine($"[Por Horas] {Nombre}, Horas: {HorasTrabajadas}, Salario: {CalcularSalario()}");
         }
     }

     class Program
     {
         static void Main(string[] args)
         {
             // Crear empleados
             EmpleadoTiempoCompleto empleado1 = new EmpleadoTiempoCompleto("Zeus Zapata", 2000);
             EmpleadoPorHoras empleado2 = new EmpleadoPorHoras("Maria Cano", 50, 80);

             // Guardar en arreglo para usar polimorfismo
             Empleado[] empleados = { empleado1, empleado2 };

             //  Array --Mostrar información
             foreach (var emp in empleados)
             {
                 emp.MostrarInfo();
             }
         }
     } */

    //------------------------------------------------------------------------------------------------------------------------------------




                            /*  Ejercicio 6: Sistema de Facturación(Abstracción y Polimorfismo)
                          Implementa un sistema que maneje diferentes tipos de facturas.
                          1. Crea una clase base Factura con atributos:
                          o NumeroFactura.
                          o Cliente.
                          o Total.
                          o Método GenerarFactura(), que se sobrescribirá.
                          2. Crea dos clases:
                          o FacturaElectronica, que sobrescribe GenerarFactura() para mostrar
                          un mensaje de "Factura enviada por correo electrónico".
                          o FacturaFisica, que sobrescribe GenerarFactura() para mostrar un
                          mensaje de "Factura impresa".

                          3. En el Main(), crea una lista de facturas de distintos tipos y recórrela para
                          mostrar su información.*/





    /* // Clase base abstracta (no se puede instanciar directamente)
     abstract class Factura
     {
         public int NumeroFactura { get; set; }
         public string Cliente { get; set; }
         public double Total { get; set; }

         // Método abstracto (obliga a las clases hijas a implementarlo)
         public abstract void GenerarFactura();

         // Método común a todas las facturas
         public void MostrarInfo()
         {
             Console.WriteLine($"Factura #{NumeroFactura} - Cliente: {Cliente} - Total: ${Total}");
         }
     }

     // Clase hija
     class FacturaElectronica : Factura
     {
         public override void GenerarFactura()
         {
             Console.WriteLine("Factura enviada por correo electrónico ");
         }
     }

     // Clase hija
     class FacturaFisica : Factura
     {
         public override void GenerarFactura()
         {
             Console.WriteLine("Factura impresa ");
         }
     }

     class Program
     {
         static void Main(string[] args)
         {
             // Lista polimórfica de facturas
             List<Factura> facturas = new List<Factura>
         {
             new FacturaElectronica { NumeroFactura = 101, Cliente = "Juan Pérez", Total = 250.75 },
             new FacturaFisica { NumeroFactura = 102, Cliente = "Ana López", Total = 480.00 },
             new FacturaElectronica { NumeroFactura = 103, Cliente = "Carlos Gómez", Total = 99.99 }
         };

             // Recorrer y aplicar polimorfismo
             foreach (var factura in facturas)
             {
                 factura.MostrarInfo();    // método de la clase base
                 factura.GenerarFactura(); // polimorfismo (cada clase hija ejecuta lo suyo)
                 Console.WriteLine("-----------------------------");
             }
         }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------


                            /*  Ejercicio 7: Sistema de Publicaciones(Herencia, Polimorfismo y
                        Encapsulamiento)
                        Se requiere un sistema para gestionar publicaciones en una red social.
                        1. Crea una clase Publicacion con atributos:
                        o Autor.
                        o Contenido.
                        o FechaPublicacion.
                        2. Crea tres clases que hereden de Publicacion:
                        o PublicacionTexto, sin atributos adicionales.
                        o PublicacionImagen, con UrlImagen.
                        o PublicacionVideo, con UrlVideo y Duracion.
                        3. Sobrescribe MostrarPublicacion() en cada subclase para que muestre
                        información diferente según el tipo de publicación.

                        4. En el Main(), crea una lista de publicaciones de diferentes tipos y muestra su
                        contenido.*/




    /*abstract class Publicacion
    {
        public string Autor { get; set; }          
        public string Contenido { get; set; }      
        public string FechaPublicacion { get; set; } 

        // Método abstracto
        public abstract void MostrarPublicacion();
    }

    // Publicación de solo texto
    class PublicacionTexto : Publicacion
    {
        public override void MostrarPublicacion()
        {
            Console.WriteLine($" Texto de {Autor} - {FechaPublicacion}");
            Console.WriteLine($"Contenido: {Contenido}");
        }
    }

    // Publicación con imagen
    class PublicacionImagen : Publicacion
    {
        public string UrlImagen { get; set; } 

        public override void MostrarPublicacion()
        {
            Console.WriteLine($" Imagen de {Autor} - {FechaPublicacion}");
            Console.WriteLine($"Contenido: {Contenido}");
            Console.WriteLine($"Imagen: {UrlImagen}");
        }
    }

    // Publicación con video
    class PublicacionVideo : Publicacion
    {
        public string UrlVideo { get; set; }  
        public int Duracion { get; set; }    

        public override void MostrarPublicacion()
        {
            Console.WriteLine($" Video de {Autor} - {FechaPublicacion}");
            Console.WriteLine($"Contenido: {Contenido}");
            Console.WriteLine($"Video: {UrlVideo} (Duración: {Duracion} seg)");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Lista que guarda publicaciones de distintos tipos
            List<Publicacion> publicaciones = new List<Publicacion>
            {
                new PublicacionTexto { Autor = "Juan", Contenido = "¡Hola a todos!", FechaPublicacion = "18-08-2025" },
                new PublicacionImagen { Autor = "Ana", Contenido = "Miren esta foto ", FechaPublicacion = "2025-08-18A", UrlImagen = "imagen.com/foto1.jpg" },
                new PublicacionVideo { Autor = "Carlos", Contenido = "Mi nuevo vlog ", FechaPublicacion = "Hoy", UrlVideo = "video.com/vlog1.mp4", Duracion = 120 }
            };

            // Recorremos la lista y mostramos cada publicación
            foreach (var pub in publicaciones)
            {
                pub.MostrarPublicacion(); // Cada tipo usa su propia versión (pub)
                Console.WriteLine("-----------------------------");
            }
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------


                                   /* Ejercicio 8: Sistema de Reservas de Hotel(Abstracción y Polimorfismo con
                        Interfaces)
                        Un hotel necesita manejar sus reservas de manera estructurada.
                        1. Crea una interfaz IReservable con métodos Reservar() y CancelarReserva().
                        2. Implementa la interfaz en dos clases:
                        o HabitacionHotel, que muestra mensajes específicos al reservar o
                        cancelar.
                        o SalonEventos, que implementa la reserva de salones para eventos.
                        3. En el Main(), crea instancias de ambas clases, haz reservas y cancélalas
                        usando polimorfismo con la interfaz.*/



    
   /* // Definimos la interfaz
    // Obliga a las clases que la implementen a tener estos métodos
    interface IReservable
    {
        void Reservar();        // Método para hacer la reserva
        void CancelarReserva(); // Método para cancelar la reserva
    }

    
    class HabitacionHotel : IReservable
    {
        public string NumeroHabitacion { get; set; }

        public HabitacionHotel(string numeroHabitacion)
        {
            NumeroHabitacion = numeroHabitacion;
        }

        // Implementación del método de la interfaz
        public void Reservar()
        {
            Console.WriteLine($"Habitación {NumeroHabitacion} reservada con éxito.");
        }

        public void CancelarReserva()
        {
            Console.WriteLine($"Reserva de la habitación {NumeroHabitacion} cancelada.");
        }
    }

    
    class SalonEventos : IReservable
    {
        public string NombreSalon { get; set; }

        public SalonEventos(string nombreSalon)
        {
            NombreSalon = nombreSalon;
        }

        // Implementación del método de la interfaz
        public void Reservar()
        {
            Console.WriteLine($"Salón {NombreSalon} reservado para el evento.");
        }

        public void CancelarReserva()
        {
            Console.WriteLine($"Reserva del salón {NombreSalon} cancelada.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Se crea una lista de "cosas reservables"
            // Usamos la interfaz como tipo -> polimorfismo
            List<IReservable> reservas = new List<IReservable>();

            // Creamos instancias de cada clase
            IReservable habitacion = new HabitacionHotel("101");
            IReservable salon = new SalonEventos("Prado");

            // Agregamos las reservas a la lista
            reservas.Add(habitacion);
            reservas.Add(salon);

            // Recorremos la lista y hacemos reservas
            Console.WriteLine("=== Reservando ===");
            foreach (IReservable r in reservas)
            {
                r.Reservar(); // Aquí se llama al método correspondiente según la clase
            }

            // Recorremos la lista y cancelamos las reservas
            Console.WriteLine("\n=== Cancelando ===");
            foreach (IReservable r in reservas)
            {
                r.CancelarReserva();
            }
        }
    }*/



}
