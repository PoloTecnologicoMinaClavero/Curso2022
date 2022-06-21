using Billetera.Version2;

namespace Billetera
{
    public interface IBilletera
    {
        int BilletesDe10 { get; set; }
        int BilletesDe100 { get; set; }
        int BilletesDe1000 { get; set; }
        int BilletesDe20 { get; set; }
        int BilletesDe200 { get; set; }
        int BilletesDe50 { get; set; }
        int BilletesDe500 { get; set; }

        IBilletera Combinar(IBilletera b);
        decimal Total();
    }
}