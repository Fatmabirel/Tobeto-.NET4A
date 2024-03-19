using System;

public class Kisi
{
    private string ad;
    private int yas;

    public Kisi(string ad, int yas)
    {
        this.ad = ad;
        this.yas = yas;
    }

    public void BilgileriGoster()
    {
        Console.WriteLine("Ad: " + ad);
        Console.WriteLine("Yaş: " + yas);
    }

    public void YasArttir()
    {
        yas++;
    }

    public void AdDegistir(string yeniAd)
    {
        ad = yeniAd;
    }
}
