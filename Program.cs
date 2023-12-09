// See https://aka.ms/new-console-template for more information
using AESCryptoTool;
using System.Buffers.Text;
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("***** AES Crypto Tool *****");
Console.WriteLine("AES Crypto Tool");
Console.WriteLine("Github: https://github.com/01hanybakir10/AESCryptoTool");
Console.WriteLine("Copyright (c) 2007-2023 - CodeZEN");
Console.WriteLine();

while (true)
{
    Console.WriteLine("1. Encrypt string");
    Console.WriteLine("2. Decrypt string ");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
    Console.Write("Enter your choice : ");
    string? choice = Console.ReadLine();

    runTool rt = new();

    switch (choice)
    {
        case "1":
            rt.EncryptString();
            break;
        case "2":
            rt.DecryptString();
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

}

public class runTool
{
    public string EncryptString()
    {
        CryptoHelper ch = new();

        Console.Write("Enter string to encrypt : ");
        string? plaintStr = Console.ReadLine();
        Console.WriteLine("===============================");
        string? encStr = ch.AESencrypt(plaintStr, "", "");
        Console.WriteLine(encStr);
        Console.WriteLine("===============================");
        return encStr;
    }
    public string DecryptString()
    {
        CryptoHelper ch = new();

        Console.Write("Enter string to decrypt : ");
        string? decStr = Console.ReadLine();
        Console.WriteLine("===============================");
        string? encStr = ch.AESdecrypt(decStr, "", "");
        Console.WriteLine(encStr);
        Console.WriteLine("===============================");

        return encStr;
    }
}

