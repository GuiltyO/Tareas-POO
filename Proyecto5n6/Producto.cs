using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System.Xml;

namespace Proyecto5n6
{
    [Serializable()]
    public class Producto: ISerializable
    {
        public string codigo {get; set;}
        public string descripcion {get; set;}
        public decimal precio {get; set;}
        public int departamento {get; set;}
        public int likes {get; set;}

        public Producto(string codigo, string descripcion, decimal precio, int departamento, int likes)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.departamento = departamento;
            this.likes = likes;
        }

        public Producto()
        {

        }

        public override string ToString()
        {
            return String.Format($"Codigo: {codigo} Desc: {descripcion} Precio: {precio} Departamento: {departamento} Likes: {likes}");
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Codigo", codigo);
            info.AddValue("Descripcion", descripcion);
            info.AddValue("Precio", precio);
            info.AddValue("Departamento", departamento);
            info.AddValue("Likes", likes);
        }
        //Deserialize
        public Producto(SerializationInfo info, StreamingContext context)
        {
            codigo = (string)info.GetValue("Codigo", typeof(string));
            descripcion = (string)info.GetValue("Descripcion", typeof(string));
            precio = (decimal)info.GetValue("Precio", typeof(decimal));
            departamento = (int)info.GetValue("Departamento", typeof(int));
            likes = (int)info.GetValue("Likes", typeof(int));
        }

    }
}
