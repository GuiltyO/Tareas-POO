## 1. Considera el siguiente fragmento de programa:
```csharp
using System;

class A

    {

    public int a;

    public A()

        {

        a = 10;

        }

    public _______ string Display()

      {

      return a.ToString();

      }

    }

class B:A

   {

   public int b;

   public B():base()

   {

    b = 15;

   }

 

public override string Display()
{
      {
      return b.ToString();
      }
    }
}

 

}

 class Program

  {

   public static void Main()

   {

  A objA = new A();

  B objB = new B();

  Console.WriteLine(objA.Display()); ////  (1 )

  Console. WriteLine(objB.Display()); ////  ( 2)

  }

  }
```
## 1.1. ¿Qué valores imprimen las lineas (1) y (2) ?
Ambos imprimen 10

## 1.2.  Redefine el método Display en el espacio indicado,

una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?

10 y 15

## 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
*Virtual*

## 2. Considera el siguiente fragmento de programa:
```csharp
using System;
using System.Collections.Generic;

public class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

   public virtual void Afina(){}

   public string Display()

      { 

       return nombre;

      }

   }


public class Bajista: Musico

  {

    public string instrumento;

    public Bajista (string n, string i):base(n)
    {
        nombre = n;
        instrumento = i;
    }

    public Bajista(string n):base(n)
    {}

    public override void Afina()
     {
         Console.WriteLine($"{nombre} afina su {instrumento}");
     }

 }
 
public class Guitarrista : Musico

     {

     public string instrumento;

     public Guitarrista(string n, string i):base(n)
     {
        nombre = n;
        instrumento = i;
     }

     public Guitarrista(string n):base(n)
     {}

     public override void Afina()
     {
         Console.WriteLine($"{nombre} afina su {instrumento}");
     }

     }

 

class Program

 {

  public static void Main()

   {

  Musico musico = new Musico("Django"); 

  Bajista b = new Bajista("Flea","Bajo");

  Guitarrista g = new Guitarrista("Santana","Guitarra");

  List<Musico> musicosList = new List<Musico>();

  musicosList.Add(b);

  musicosList.Add(g);

 

  foreach ( Musico musicos in musicosList)
  {
      musicos.Afina();
  }


 // (m as IAfina).Afina()

 Console.ReadKey();

 }
}
```

## 2.1. Completa el programa.

## 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
(A) el metodo es *abstract* cuando la clase no lo es, no se pueden generar metodos abstractos si la clase no es marcada
como *abstract*.

## 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
Afina(); debe ser implementado en ambas clases derivadas por ser metodos de tipo *abstract* 

## 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
Por ser una clase *abstract*, no puede implementarse codigo en metodos abstractos al menos que sean en clases derivadas,
al derivar el metodo abstracto debe de implementarse codigo como cualquier otro metodo.

## 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
Tendria que ser implementado en todas las clases derivadas.

## 3. Implementa el programa utilizando interfaces en lugar de herencia.
