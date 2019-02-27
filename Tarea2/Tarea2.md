# Unidad 2: Clases y Objetos

## 2.1 Declaración de clases: atributos, métodos, encapsulamiento.

Una clase es un tipo de refencia definido por el usuario que define objetos. Define sus estados, comportamientos e identidad.
Una estructura es un tipo de valor, su sintaxis y utilidad es muy similir al de una clase, es ideal para datos pequeños y una clase para datos complejos.

Metodos asdlk

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
Los constructores son métodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado. Los constructores tienen el mismo nombre que la clase y, normalmente, inicializan los miembros de datos del nuevo objeto.

Un constructor que no toma ningún parámetro se denomina constructor predeterminado. Los constructores predeterminados se invocan cada vez que se crea una instancia de un objeto mediante el operador new y no se proporciona ningún argumento a new.

Los constructores para los tipos struct son similares a los constructores de clases, pero los tipos structs no pueden contener un constructor predeterminado explícito porque el compilador proporciona uno automáticamente. Este constructor inicializa cada campo del tipo struct con los valores predeterminados. 

Un constructor se puede declarar como estático mediante la palabra clave static. Se llama automáticamente a los constructores estáticos de forma inmediata antes de que se tenga acceso a cualquier campo estático, y, generalmente, se utilizan para inicializar los miembros de clase estáticos. 

En una clase derivada, si no se llama explícitamente al constructor de la clase base mediante la palabra clave base, se llamará implícitamente al constructor predeterminado, si existe alguno. 

## 2.6 Sobrecarga de métodos.

## 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.



