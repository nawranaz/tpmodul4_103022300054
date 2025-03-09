﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    private static readonly Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static string GetKodePos(string kelurahan)
    {
        return tabelKodePos.TryGetValue(kelurahan, out string kodePos) ? kodePos : "Kode pos tidak ditemukan";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + KodePos.GetKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Mengger: " + KodePos.GetKodePos("Mengger"));
        Console.WriteLine("Kode Pos Wates: " + KodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos Cijaura: " + KodePos.GetKodePos("Cijaura"));
        Console.WriteLine("Kode Pos Jatisari: " + KodePos.GetKodePos("Jatisari"));
        Console.WriteLine("Kode Pos Margasari: " + KodePos.GetKodePos("Margasari"));
        Console.WriteLine("Kode Pos Sekejati: " + KodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos Kebonwaru: " + KodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode Pos Maleer: " + KodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode Pos Samoja: " + KodePos.GetKodePos("Samoja"));
        Console.WriteLine("Kode Pos ngarang: " + KodePos.GetKodePos("ngarang"));
    }
}
