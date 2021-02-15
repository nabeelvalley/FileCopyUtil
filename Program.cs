using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FileCopyUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = Directory.GetCurrentDirectory();
            string path = Path.Join("config.json");
            
            System.Console.WriteLine($"Read Config file from: {path}");

            var config = ReadConfigFile(path);

            config.ForEach(c => {
                System.Console.WriteLine($"Start Copying File: {c.From} to {c.To}");
                File.Copy(c.From, c.To, true);
                System.Console.WriteLine($"Done Copying File: {c.From} to {c.To}");
            });        

            Console.ReadLine();
        }

        static List<CopyConfig> ReadConfigFile(string path)
        {
            var file = File.ReadAllText("./config.json");
            return JsonSerializer.Deserialize<List<CopyConfig>>(file);
        }
    }
}
