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



## 2.5 Constructores y destructores: declaración, uso y aplicaciones.
Constructores son metodos pertenecientes a una clase creados cuando se crea un objeto. Su principal funcion es inicializar los datos de un objeto. Se le llama constructor predeterminado a un constructor sin ningun tipo de parametro. 

Los constructores tipo struct inicializa cada campo tipo struct con valores por defecto, no pueden contener constructures predeterminados. Se declaran con la palabra reservada *static*. Una clase que no tiene un constructor predeterminado, la clase derivada debe realizar una llama explicita a un constructor base utilizando la palabra reservada *base*.

Los destructures son utilizados para destruir instancias de clases, solo pueden utlizarlos las clases, solo puede existir uno dentro de cada clase, no pueden heredar, no pueden ser llamados. Su principal utilidad viene de la capacidad de liberar recursos y optimizar procesos.


## 2.6 Sobrecarga de métodos.

## 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.



