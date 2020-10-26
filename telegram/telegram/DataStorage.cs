
using System.IO;
using System;

namespace telegram
{
    public class DataStorage
    {
        public static string readFileStore(string path)
        {
            StreamReader stream_res = new StreamReader(path); 
            string text = stream_res.ReadToEnd(); 
            Console.WriteLine(text);
            return (text);
        }
        public string links_part1 = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/c_sharp.txt");
        public string links_part2 = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/sql_links.txt");
        public string links_part3 = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/web_links.txt");
        
        
    }
}