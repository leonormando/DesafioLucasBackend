using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioLucasBackend.Model
{
    public static class DataManager
    {
        public static List<ChartModel> lista { get; set; }
        public static List<ChartModel> GetData()
        {
            var r = new Random();
            if (lista == null)
            {
                lista = new List<ChartModel>();

                lista.Add(new ChartModel { Data = { r.Next(1, 40), r.Next(1, 40), r.Next(1, 40), r.Next(1, 40), r.Next(1, 40) }, Label = "Sensor1" });
                lista.Add(new ChartModel { Data = { r.Next(1, 40), r.Next(1, 40), r.Next(1, 40), r.Next(1, 40), r.Next(1, 40) }, Label = "Sensor2" });
                lista.Add(new ChartModel { Data = { r.Next(1, 40), r.Next(1, 40), r.Next(1, 40), r.Next(1, 40), r.Next(1, 40) }, Label = "Sensor3" });
            }
            else
            {
                lista[0].Data[0] += r.Next(1, 5);
                lista[0].Data[1] += r.Next(1, 5);
                lista[0].Data[2] += r.Next(1, 5);
                lista[0].Data[3] += r.Next(1, 5);
                lista[0].Data[4] += r.Next(1, 5);

                lista[1].Data[0] += r.Next(1, 5);
                lista[1].Data[1] += r.Next(1, 5);
                lista[1].Data[2] += r.Next(1, 5);
                lista[1].Data[3] += r.Next(1, 5);
                lista[1].Data[4] += r.Next(1, 5);

                lista[2].Data[0] += r.Next(1, 5);
                lista[2].Data[1] += r.Next(1, 5);
                lista[2].Data[2] += r.Next(1, 5);
                lista[2].Data[3] += r.Next(1, 5);
                lista[2].Data[4] += r.Next(1, 5);


            }
            return lista;
        }
    }
}
