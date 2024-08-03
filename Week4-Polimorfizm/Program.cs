using System;

class Program
{
    static void Main()
    {
        Kare kare = new(20, 20);
        Console.WriteLine("__________________");
        Dikdortgen dikdörtgen = new(10, 20);
        Console.WriteLine("__________________");
        DıkUcgen dıkUcgen = new(50, 20);

    }
}

class Sekil
{
    public decimal _genislik { get; set; }
    public decimal _yukseklik { get; set; }
    public decimal _alan { get; set; }

    public Sekil(decimal genislik,decimal yukseklik)
    {
        _genislik = genislik;
        _yukseklik = yukseklik;
        
    }


}

class Kare:Sekil
{
    public Kare(decimal yukseklik, decimal genislik) : base(yukseklik, genislik)
    {
        this._alan = (genislik * yukseklik);
        Console.WriteLine($"Karenin Ölçüleri;\nGenislik: {genislik}\nYükseklik {yukseklik}\nKarenin Alanı:{_alan}");
    }
}

class Dikdortgen:Sekil
{
    public Dikdortgen(decimal yukseklik, decimal genislik) : base(yukseklik, genislik)
    {
        this._alan = (genislik * yukseklik);
        Console.WriteLine($"Dikdörtgen Ölçüleri\nGenislik: {genislik}\nYükseklik {yukseklik}\nDikdörtgenin:{_alan}");
    }
}

class DıkUcgen:Sekil
{
    public DıkUcgen(decimal yukseklik,decimal genislik) :base(yukseklik,genislik)
    {
    
        this._alan = (genislik * yukseklik) / 2;
        Console.WriteLine($"Dik Üçgenin Ölçüleri\nGenislik: {genislik}\nYükseklik {yukseklik}\nDik Üçgenin Alanı:{_alan}" );
    }
}
