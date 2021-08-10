using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public static class Memoria
{
    public static List<int> Notas()
    {
        using (Stream stream = File.Open("Datos.list", FileMode.OpenOrCreate))
        {
            var formato = new BinaryFormatter();
            if (stream.Length != 0)
            {
                return (List<int>)formato.Deserialize(stream);
            }
            else
            {
                return new List<int>();
            }
        }
    }
    public static void Cambiador(List<int> notitas)
    {
        using (Stream stream = File.Open("Datos.list", FileMode.Create))
        {
            BinaryFormatter formato = new BinaryFormatter();
            formato.Serialize(stream, notitas);
        }
    }

}