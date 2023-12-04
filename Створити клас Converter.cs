using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    // Конструктор класу Converter
    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    // Метод для конвертації гривні в інші валюти
    public double UahToUsd(double amountInUah)
    {
        return amountInUah / usdRate;
    }

    public double UahToEur(double amountInUah)
    {
        return amountInUah / eurRate;
    }

    public double UahToPln(double amountInUah)
    {
        return amountInUah / plnRate;
    }

    // Метод для конвертації інших валют в гривню
    public double UsdToUah(double amountInUsd)
    {
        return amountInUsd * usdRate;
    }

    public double EurToUah(double amountInEur)
    {
        return amountInEur * eurRate;
    }

    public double PlnToUah(double amountInPln)
    {
        return amountInPln * plnRate;
    }
}

class Program
{
    static void Main()
    {
        // Ініціалізуємо об'єкт Converter з курсами валют
        Converter converter = new Converter(26.5, 31.2, 7.8);

        // Конвертація гривні в інші валюти
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} гривень = {converter.UahToUsd(amountInUah):0.00} доларів");
        Console.WriteLine($"{amountInUah} гривень = {converter.UahToEur(amountInUah):0.00} євро");
        Console.WriteLine($"{amountInUah} гривень = {converter.UahToPln(amountInUah):0.00} злотих");

        // Конвертація інших валют в гривню
        double amountInUsd = 50;
        double amountInEur = 40;
        double amountInPln = 120;
        Console.WriteLine($"{amountInUsd} доларів = {converter.UsdToUah(amountInUsd):0.00} гривень");
        Console.WriteLine($"{amountInEur} євро = {converter.EurToUah(amountInEur):0.00} гривень");
        Console.WriteLine($"{amountInPln} злотих = {converter.PlnToUah(amountInPln):0.00} гривень");

        Console.ReadLine(); // Затримка, щоб консольне вікно не закрилося відразу
    }
}
