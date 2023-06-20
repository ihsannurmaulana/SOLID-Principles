namespace SRPandOCP
{
    internal class Program
    {
        public class Vehicle
        {
            public string Nama { get; set; }
            public string Tipe { get; set; }
            public DateTime TahunProduksi { get; set; }
        }


        //Penggunaan SRP yang salah
        public class OrderVehicle : Vehicle
        {
            public double Harga { get; set; }
            public double Tax { get; set; }
            public double ShippingCost { get; set; }
            public double OrderPrice()
            {
                return (Harga * Tax) + ShippingCost;
            }

            public void SaveInvoiceOrder(OrderVehicle ord)
            {
                Console.WriteLine($"Nama Mobil: {Nama}");
                Console.WriteLine($"Tipe: {Tipe}");
                Console.WriteLine($"Tahun Produksi: {TahunProduksi}");
                Console.WriteLine($"Harga Barang: {ord.OrderPrice()}");
            }

        }

        //Penggunaan SRP Yang Benar
        public class OrderVehicles : Vehicle
        {
            public double Harga { get; set; }
            public double Tax { get; set; }
            public double ShippingCost { get; set; }
            public double OrderPrice()
            {
                return (Harga * Tax) + ShippingCost;
            }
        }

        public class OrderRepository
        {
            public void SaveInvoiceOrder(OrderVehicles ord)
            {
                Console.WriteLine($"Nama Mobil: {ord.Nama}");
                Console.WriteLine($"Tipe: {ord.Tipe}");
                Console.WriteLine($"Tahun Produksi: {ord.TahunProduksi}");
                Console.WriteLine($"Harga Barang: {ord.OrderPrice()}");
            }
        }

        //OCP 
        public abstract class AVehicleSound
        {
            public abstract void Sound();
    }

    public class Ferarri : AVehicleSound
    {
        public override void Sound()
        {
            Console.WriteLine("Bruuuuummm");
        }
    }

    public class Avanza : AVehicleSound
    {
        public override void Sound()
        {
            Console.WriteLine("Breeeeemmmm");
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
}