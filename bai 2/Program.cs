using System;
using System.IO;

class Program
{
    static void Main()
    {
        string username = "abcdxyznmasad:)))";
        string password = "31072019";
        string time = "24/05/2024";

        
        string content;
        using (StringWriter sw = new StringWriter())
        {
            sw.WriteLine("Ten tai khoan: " + username);
            sw.WriteLine("Mat khau: " + password);
            sw.WriteLine("Ngay luu: " + time);

            
            content = sw.ToString();
        }

        
        using (StringReader sr = new StringReader(content))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
    


