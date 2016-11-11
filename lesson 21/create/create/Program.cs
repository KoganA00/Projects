using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CreateSvgFile
{
    public static void Main()
    {

        string path = @"C:\Users\User\Desktop\lesson 21\doc.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>Wow</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='1500' height='600'>\n";
        
        for (int g = 0; g <= 20; g++)
        {
            String ys = (g*20+50).ToString();
            String fill = (g*10).ToString();
            for (int i = 0; i < 50; i++)
            {
                
                String xs = (i * 20 + 70).ToString();
                String f=(i*15).ToString();
                String rs = "9"; 
                String ws = "4";
                svg += "<circle cx='" + xs + "' cy='" + ys + "' r='" + rs + "' stroke='blue' stroke-width='" + ws + "' fill='rgb("+fill+ ","+f+",60)' />\n";
            };
           
        }
        svg += "</svg>";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
        
    }
}