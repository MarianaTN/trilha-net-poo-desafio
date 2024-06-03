using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"Instalando o aplicativo {app} no Samsung.");
        }
    }
}
