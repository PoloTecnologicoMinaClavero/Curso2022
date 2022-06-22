using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Billetera: IBilletera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            var total =
                BilletesDe10 * 10m +
                BilletesDe20 * 20m +
                BilletesDe50 * 50m +
                BilletesDe100 * 100m +
                BilletesDe200 * 200m +
                BilletesDe500 * 500m +
                BilletesDe1000 * 1000m;

            return total;
        }

        public IBilletera Combinar(IBilletera b)
        {
            var nueva = new Billetera();

            // Combinamos
            nueva.BilletesDe10 = BilletesDe10 + b.BilletesDe10;
            nueva.BilletesDe20 = BilletesDe20 + b.BilletesDe20;
            nueva.BilletesDe50 = BilletesDe50 + b.BilletesDe50;
            nueva.BilletesDe100 = BilletesDe100 + b.BilletesDe100;
            nueva.BilletesDe200 = BilletesDe200 + b.BilletesDe200;
            nueva.BilletesDe500 = BilletesDe500 + b.BilletesDe500;
            nueva.BilletesDe1000 = BilletesDe1000 + b.BilletesDe1000;

            // Vaciamos esta billetera
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;

            // Vaciamos la segunda billetera
            b.BilletesDe10 = 0;
            b.BilletesDe20 = 0;
            b.BilletesDe50 = 0;
            b.BilletesDe100 = 0;
            b.BilletesDe200 = 0;
            b.BilletesDe500 = 0;
            b.BilletesDe1000 = 0;

            return nueva;
        }

    }
}
