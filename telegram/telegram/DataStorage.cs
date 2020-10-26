
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
        public string links_c_sharp = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/c_sharp.txt");
        public string links_sql = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/sql_links.txt");
        public string links_web = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/web_links.txt");
        public string links_patterns = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/patterns.txt");
        public string links_subd = readFileStore(@"/home/orhan/Desktop/Telegramm/telegram/subd.txt");
    }
}