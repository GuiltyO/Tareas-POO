using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.ComTypes;


namespace Proyecto5n6
{
    [Serializable()]
    public class ProductoDB : IOException 
    {
        
        public string ruteXml = Directory.GetCurrentDirectory()+@"\listaProductos.xml";
        //public static string ruteBinary = Directory.GetCurrentDirectory()+@"\Products.dat";
        private List<Producto> listaProductos = new List<Producto>();
        //private List<Producto> Products = new List<Producto>();
        private List<Producto> Products = new List<Producto>();

        private const string dir = @"C:\Users\lol\Documents\GitHub\Tareas-POO\Proyecto5n6";
        private const string path = dir + @"\Products.dat";

        //Stream stream = File.Open("Products.dat",FileMode.Create);

          //  BinaryFormatter bf = new BinaryFormatter();

        public List<Producto> GetList()
        {
            return listaProductos;
        }

        public List<Producto> GetListBin()
        {
            return Products;
        }

        public void Serializa()
        {
            try
           {
               if(File.Exists(ruteXml))
             {
               DeserializeXml();
             } 
             else 
             {
              listaProductos.Add(new Producto("00","Papas",10,01,10));
              listaProductos.Add(new Producto("01","Galletas",16,01,5));
              listaProductos.Add(new Producto("03","Leche",40,02,6));
              listaProductos.Add(new Producto("04","Queso",15,02,3));
              listaProductos.Add(new Producto("05","Jamon",30,03,3));
              listaProductos.Add(new Producto("06","Salchicha",50,03,8));
              }
            }
           catch(DirectoryNotFoundException)
           {
               MessageBox.Show(dir + " not found.","Directory not found");
           }

           
           try
           {
               if(!Directory.Exists(dir))
              {
                Directory.CreateDirectory(dir);
              } 
              else 
              {
                Products.Add(new Producto("00","Papas",10,01,10));
                Products.Add(new Producto("01","Galletas",16,01,5));
                Products.Add(new Producto("03","Leche",40,02,6));
                Products.Add(new Producto("04","Queso",15,02,3));
                Products.Add(new Producto("05","Jamon",30,03,3));
                Products.Add(new Producto("06","Salchicha",50,03,8));
              }
           }
           catch(DirectoryNotFoundException)
           {
               MessageBox.Show(dir + " not found.","Directory not found");
           }

            SerializeXml();
            SaveProducts(Products);
            listaProductos = null;
            Products = null;
            DeserializeXml();
            GetProducts();

        }


        public void DeserializeXml()
        {
            try
            {
                using (FileStream fs = File.OpenRead(ruteXml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
                listaProductos = (List<Producto>)serializer.Deserialize(fs);
            }
            }
            catch(FileNotFoundException){}
            
        }

        public void SerializeXml()
        {
            try
            {
                using (TextWriter fs = new StreamWriter(ruteXml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
                serializer.Serialize(fs, listaProductos);
            }
            }
            catch(FileNotFoundException){}
        }

            public static List<Producto> GetProducts()
            {
                try
                {
                if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
                }
                catch(DirectoryNotFoundException)
                {
                    Message.Show(dir + "not found.", "Directory not found");
                }

                BinaryReader binaryIn = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

                List<Producto> products = new List<Producto>();
                while(binaryIn.PeekChar() != -1)
              {
                Producto product = new Producto();
                product.codigo = binaryIn.ReadString();
                product.descripcion = binaryIn.ReadString();
                product.precio = binaryIn.ReadDecimal();
                product.departamento = binaryIn.ReadInt32();
                product.likes = binaryIn.ReadInt32();
                products.Add(product);
              }

              binaryIn.Close();
              return products;
            }

            public static void SaveProducts(List<Producto> products)
            {
                BinaryWriter binaryOut = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

                foreach(Producto product in products)
            {
                binaryOut.Write(product.codigo);
                binaryOut.Write(product.descripcion);
                binaryOut.Write(product.precio);
                binaryOut.Write(product.departamento);
                binaryOut.Write(product.likes);
            }

            binaryOut.Close();
            }
  }

        //Mio 
        /* 
         public static void SerializeBinary(List<Producto> products)
        {

            
            
            BinaryWriter binaryOut = new BinaryWriter(new FileStream(ruteBinary, FileMode.Create, FileAccess.Write));

            foreach(Producto produ in products)
            {
                binaryOut.Write(produ.codigo);
                binaryOut.Write(produ.descripcion);
                binaryOut.Write(produ.precio);
                binaryOut.Write(produ.departamento);
                binaryOut.Write(produ.likes);
            }

            binaryOut.Close();
        }

         public static List<Producto> DeserializeBinary()
        {
            BinaryReader binaryIn = new BinaryReader(new FileStream(ruteBinary, FileMode.OpenOrCreate, FileAccess.Read));

            List<Producto> Products = new List<Producto>();
            while(binaryIn.PeekChar() != -1)
            {
                Producto product = new Producto();
                product.codigo = binaryIn.ReadString();
                product.descripcion = binaryIn.ReadString();
                product.precio = binaryIn.ReadDecimal();
                product.departamento = binaryIn.ReadInt32();
                product.likes = binaryIn.ReadInt32();
                Products.Add(product);
            }

            binaryIn.Close();
            return Products;
        }*/



        //Derek
        /* public void SerializeBinary()
        {
            stream = File.Open("Products.dat",FileMode.Open);
            bf = new BinaryFormatter();

            bf.Serialize(stream, Products);
            stream.Close();
        }*/

        /* public void DeserializeBinary()
        {
            stream = File.Open("Products.dat",FileMode.Open);
            bf = new BinaryFormatter();

            Products = (List<Producto>)bf.Deserialize(stream);
            stream.Close();
        }*/
    
}
