using System;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variable
            int hasil;

            static void Cetakhasil(string hasil)
            {
                Console.WriteLine(hasil);
            }

            // membuat objek dari class calculator
            Calculator calculator = new Calculator();

            // panggil method penjumlah
            hasil = calculator.penjumlahan(10, 2);
            Cetakhasil(" hasil penjumlahan : " + hasil);

            // panggil method penjumlahan dengan 3 parameter ( overload method )
            hasil = calculator.penjumlahan(10, 2, 3);
            Cetakhasil(" hasil penjumlahan overload : " + hasil);

            // panggil method pengurangan
            hasil = calculator.pengurangan(7, 2);
            Cetakhasil(" hasil pengurangan : " + hasil);

            // panggil langsung static method langsung dari nama classnya
            hasil = Calculator.perkalian(5, 2);
            Cetakhasil(" hasil perkalian : " + hasil);
            Console.ReadKey();
        }
    }
}
