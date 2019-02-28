# Unidad 2: Clases y Objetos

## 2.1 Declaración de clases: atributos, métodos, encapsulamiento.

Una clase es un tipo de refencia definido por el usuario que define objetos. Define sus estados, comportamientos e identidad.
Una estructura es un tipo de valor, su sintaxis y utilidad es muy similir al de una clase, es ideal para datos pequeños y una clase para datos complejos.

Los metodos son una serie de instrucciones realizadas cuando el metodo es invocado, solo pueden ser accedidos por la clase donde son creados almenos que tengan modificadores de acceso publicos el metodo y la clase.

El encapsulamiento es un concepto basico de la programacion orientada a objetos, limita los niveles de acceso de alguna clase o estructura para evitar errores dentro del sistema o acceso no deseado.

## 2.2 Instanciación de una clase.
La palabra *new* es una palabra reservada dentro de C# que reserva memoria para la inicializacion de instancias.

Puede ser utlizado para crear objetos, invocar estructuras o reemplazar miembros de una clase derivada.

## 2.3 Referencia al objeto actual
La palabra clave this hace referencia a la instancia actual de la clase. 

```csharp 
using System;

namespace Tarea2
{
    class Automovil
    {
        private int numeroLlantas;
        private int capacidadPersonas;
        private int capacidadCarga;

        public int NumeroLlantas
        {
            get { return numeroLlantas;}
            set { numeroLlantas = value;}
        }

        public int CapacidadPersonas
        {
            get { return capacidadPersonas;}
            set { capacidadPersonas = value;}
        }

        public int CapacidadCarga
        {
            get { return capacidadCarga;}
            set { capacidadCarga = value;}
        }

        public Automovil(int numeroLlantas, int capacidadPersonas, int Carga)
        {
            this.numeroLlantas = numeroLlantas;
            this.capacidadPersonas = capacidadPersonas;
            capacidadCarga = Carga;
        }  

    }

    class Program
    {
        static void Main()
        {
            
        }
    }
}
```

## 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.


Los parámetros declarados para un método sin in, ref o out se pasan al método llamado por valor. Ese valor se puede cambiar en el método, pero el cambio se perderá cuando se devuelva el control al procedimiento que ha realizado la llamada. Si usa palabras clave de parámetros de método en la declaración del parámetro, puede modificar este comportamiento.
Palabras clave para declarar parametros en metodos.
params especifica que este parámetro puede tomar un número variable de argumentos.
in especifica que este parámetro se pasa por referencia, pero solo se lee mediante el método llamado.
ref especifica que este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.
out especifica que este parámetro se pasa por referencia y se escribe mediante el método llamado.

La palabra reservada *params*, puede especificar un parámetro de método que toma un número variable de argumentos.
Puede enviar una lista separada por comas de argumentos del tipo especificado en la declaración de parámetro o una matriz de argumentos del tipo especificado. También puede no enviar ningún argumento. Si no envía ningún argumento, la longitud de la lista params es cero.

La palabra reservada *out*, como un modificador de parámetro le permite pasar un argumento a un método mediante una referencia en lugar de mediante un valor.

La palabra clave ref indica un valor que se ha pasado mediante referencia. Refiriendonos a metodos se utiliza para pasar argumentos a un metodo mediante referencia y para devolver un valor mediante referencia.

## 2.5 Constructores y destructores: declaración, uso y aplicaciones.
Constructores son metodos pertenecientes a una clase creados cuando se crea un objeto. Su principal funcion es inicializar los datos de un objeto. Se le llama constructor predeterminado a un constructor sin ningun tipo de parametro. 

Los constructores tipo struct inicializa cada campo tipo struct con valores por defecto, no pueden contener constructures predeterminados. Se declaran con la palabra reservada *static*. Una clase que no tiene un constructor predeterminado, la clase derivada debe realizar una llama explicita a un constructor base utilizando la palabra reservada *base*.

Los destructures son utilizados para destruir instancias de clases, solo pueden utlizarlos las clases, solo puede existir uno dentro de cada clase, no pueden heredar, no pueden ser llamados. Su principal utilidad viene de la capacidad de liberar recursos y optimizar procesos.


## 2.6 Sobrecarga de métodos.

## 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.
```csharp
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{

    class Dado
    {
        private int valor; 
        private string color;

       
        public Dado()
        {

        }

        public Dado(int valor, string color)
        {
            this.valor = valor;
            this.color = color;
        }

        public void Imprime()
        {
            Console.WriteLine("Dado con valor {0} y color {1} es el mayor de los dados.", valor, color);
        }

        static public void Imprime(Dado a, Dado b)
        {
            Console.WriteLine("Dado con valor {0} y color {1} es igual a dado con valor {2} y color {3}.", a.valor, a.color, b.valor, b.color);
        }

        public static bool operator == (Dado a, Dado b)
        {
            return (a.valor == b.valor);
        }

        public static bool operator != (Dado a, Dado b)
        {
            return (a.valor != b.valor);
        }

        public static bool operator > (Dado a, Dado b)
        {
            return (a.valor > b.valor);
        }

        public static bool operator < (Dado a, Dado b)
        {
            return (a.valor < b.valor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dado> Dados = new List<Dado>();
            Dados.Add(new Dado(2, "azul"));
            Dados.Add(new Dado(2, "rojo"));
            Dados.Add(new Dado(1, "verde"));

            if (Dados[0] > Dados[1] & Dados[0] > Dados[1])
            {
                Dados[0].Imprime();
            }

            else if (Dados[0] == Dados[1])
            {
                Dado.Imprime(Dados[0], Dados[1]);
            }

            else if (Dados[0] == Dados[2])
            {
                Dado.Imprime(Dados[0], Dados[2]);
            }

            else if (Dados[1] > Dados[0] & Dados[1] > Dados[2])
            {
                Dados[1].Imprime();
            }

            else if (Dados[1] == Dados[0])
            {
                Dado.Imprime(Dados[1], Dados[0]);
            }

            else if (Dados[1] == Dados[2])
            {
                Dado.Imprime(Dados[1], Dados[2]);
            }

            else if (Dados[2] > Dados[0] & Dados[2] > Dados[1])
            {
                Dados[2].Imprime();
            }

            else if (Dados[2] == Dados[0])
            {
                Dado.Imprime(Dados[2], Dados[0]);
            }

            else if (Dados[2] == Dados[1])
            {
                Dado.Imprime(Dados[2], Dados[1]);
            }

            Console.ReadKey();
        }
    }
}
```



