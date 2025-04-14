using System;
using System.Collections.Generic;
using System.IO;

public static class FileHandler
{
    public static List<string> ReadAll(string path)
    {
        List<string> result = new List<string>();

        string line = "";
        using (StreamReader sr = new StreamReader(path))
        {
            while ((line = sr.ReadLine()) != null)
            {
                result.Add(line);
            }
        }


        return result;
    }

    public static void Write(string text, string path, bool append = true)
    {
        using (StreamWriter sw = new StreamWriter(path, append))
        {
            sw.WriteLine(text);
        }
    }
}