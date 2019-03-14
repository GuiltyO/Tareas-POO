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