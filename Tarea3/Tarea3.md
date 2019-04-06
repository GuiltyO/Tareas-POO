## 1.  Define: Clase Base, Clase Derivada.
   Clase base en POO es una clase creada con la finalidad de heredar sus propiedades y metodos a clases derivadas para el eficiente
   rehuso de codigo. 
   Clase derivada es una clase que deriva todas las propiedades y metodos de una clase base, pueden existir varias clases derivadas de      una clase padre.

## 2.  Haz un diagrama UML donde se muestre la relación de herencia entre las  clases Figura, Recangulo y Circulo como vimos en clase.
      
   ![Herencia](https://i.imgur.com/MvACY9k.png)
      
      
## 3.  Indica cuales son las clases base y las derivadas.
   Dentro del diagrama, la clase padre Figura hereda sus propiedades, area y perimetro, y metodos, CalcularArea y
   CalcularPerimetro, a las clases derivadas, Rectangulo y Circulo, ya que cualquier figura posee esas caracteristicas.

## 4. ¿Que es herencia simple y herencia múltiple? ¿En c# se puede hacer herencia múltiple?
     
   Herencia simple es la herencia de una clase padre a una clase derivada, herencia multiple permite la capacidad de 
   heredar distintas clases padres a una sola clase derivada, obteniendo las propiedades y metodos de todas las clases padres.
     
   En c# no existe como tal algun metodo o alguna manera de realizar la herencia multiple, pero existen las interfaces, que 
   permiten implementar propiedades y metodos como lo haria una clase padre, sin la necesidad de realizar una herencia.

## 5. Escribe el programa de Figura como vimos en clase, donde agregues varios tipos de figuras a una lista y recorre la lista llamando a un metodo de las figuras, además :
```csharp
using System;
using System.Collections.Generic;

namespace Figura
{
    class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    
    abstract class Figura
    {
        public Vector2d position;
        public string fill ,border;

        
        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        
        public Figura(Vector2d pos)
        {
            position= pos;
            fill= "white";
            border= "black";
        }

        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio, Color fill):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
     }
    }
 
    class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2d pos, Color fill):base(pos)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
     }
    }

   class Cuadrado : Figura
   {
    public Cuadrado(Vector2d pos, Color fill):base(pos)
     {
         
     }
     public Cuadrado ():base()
     {
        
     }

    public override void Dibuja()
    {
        Console.WriteLine("Dibuja un Cuadrado en {0} de color {1}",position, fill);
    }
   }

   public class Color
    {
        public enum Name{red,blue,white,green,black,pink,yellow,none}
        public int R,G,B,I;
        public Color.Name colorName;
        public Color(int r, int g, int b, int i=1)
        {
            R=r;
            G=g;
            B=b;
            I=i;
            this.colorName = Color.Name.none;
        }

        public Color(Color.Name name)
        {
            colorName=name;
            if (colorName==Color.Name.red)
            {
              R=255;
              G=0;
              B=0;
              I=1;
            }
            else if (name ==Color.Name.blue)
            {
                R=0;
                G=0;
                B=255;
                I=1;
            }
            else if (name ==Color.Name.green)
            {
                R=0;
                G=255;
                B=0;
                I=1;
            }
            else if (name ==Color.Name.pink) 
            {
                R=255;
                G=192;
                B=203;
                I=1;
            }
            else if (name ==Color.Name.yellow)
            {
                R=255;
                G=255;
                B=00;
                I=1;
            }
            else if (name ==Color.Name.white)
            {
                R=255;
                G=255;
                B=255;
                I=1;
            }
            else if (name ==Color.Name.black)
            {
                R=0;
                G=0;
                B=0;
                I=1;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2d(200,200), new Color(255,0,0) ));
            figuras.Add(new Cuadrado(new Vector2d(100,100), new Color (Color.Name.red)));

            foreach(Figura f in figuras)
            f.Dibuja();
            
           
        }
    }
}
```
 # 5.1 Se sobrecarguen los constructores y se acceda a los constructores de la clase base 
 ```csharp
 class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2d pos, Color fill):base(pos)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }
```

 # 5.2 Explica para que nos sirve la palabra base
 La palabra *base* es utilizada para utilizar datos correspondientes de una clase base o padre, por ejemplo, el constructor de
 una clase derivada puede inicializar sus valores utilizando los valores por defecto de su clase padre.

 # 5.3  Haz el método Dibuja() que sea virtual y redefinelo en solo una de las clases derivadas.  
 ```csharp
    class Figura
    {
        public Vector2d position;
        public string fill ,border;

        
        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        
        public Figura(Vector2d pos)
        {
            position= pos;
            fill= "white";
            border= "black";
        }

        public virtual void Dibuja();
    }
```
```csharp
class Cuadrado : Figura
   {
    public Cuadrado(Vector2d pos, Color fill):base(pos)
     {
         
     }
     public Cuadrado ():base()
     {
        
     }

    public override void Dibuja()
    {
        Console.WriteLine("Dibuja un Cuadrado en {0} de color {1}",position, fill);
    }
   }
```
