using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Spire.Pdf;
using Spire.Pdf.Widget;
using Spire.Pdf.Fields;
using Spire.Pdf.HtmlConverter;
using System.Drawing;

namespace Relief_System
{
    class TextPrint:Program
    {
        public static void relwrite()
        {
            path = @"C:\Users\Public\Documents\RadianLabs\ReliefText\TeacherID-" + al5[relindex] + "_Date-" + date + "_Relief.html";
            Console.WriteLine(path);
            sw = new StreamWriter(path);
            reltext = "<!doctype html><html><head><style>th{text-align: center;background-color: aqua;}td{text-align: center;}</style><meta charset='utf-8'><title>Relief</title></head><body><b><font face='Century Gothic'><h2 align=center>"+textname+"</h2><table align=center border='1' width ='400px' cellspacing='0' cellpadding='5'><tr><th>Period</th><th>Class</th></tr><tr><td>One</td><td>"+relprinter[0]+"</td></tr><tr><td>Two</td><td>" + relprinter[1] + "</td></tr><tr><td>Three</td><td>" + relprinter[2] + "</td></tr><tr><td>Four</td><td>" + relprinter[3] + "</td></tr><tr><td>Five</td><td>" + relprinter[4] + "</td></tr><tr><td>Six</td><td>" + relprinter[5] + "</td></tr><tr><td>Seven</td><td>" + relprinter[6] + "</td></tr><tr><td>Eight</td><td>" + relprinter[7] + "</td></tr></table></font></b></body></html>";
            sw.WriteLine(reltext);
            sw.Flush();
            sw.Close();
        }
        public static void convertpdf()
        {
            PdfDocument pdfd = new PdfDocument();
            PdfPageSettings settings = new PdfPageSettings();
            PdfHtmlLayoutFormat htmll = new PdfHtmlLayoutFormat();
            settings.Size = new SizeF(1000, 1000);
            settings.Margins = new Spire.Pdf.Graphics.PdfMargins(20);
            htmll.IsWaiting = true;
            Thread thread = new Thread(()=>
            { pdfd.LoadFromHTML(path, false, false, false, settings, htmll); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            pdfd.SaveToFile(@"C:\Users\Public\Documents\RadianLabs\ReliefText\TeacherID-"+al5[relindex]+"_Date-" + date + "_Relief.pdf");
            pdfd.Close();
            //System.Diagnostics.Process.Start(@"C:\Users\Public\Documents\RadianLabs\ReliefText\TeacherID-1003_Date-" + date + "_Relief.pdf");
        }
        public static void reliefprint()
        {
            try
            {
                using (pd)
                {
                    pd.ShowDialog();
                    info = new ProcessStartInfo()
                    {
                        Verb = "print",
                        CreateNoWindow = true,
                        FileName = @"C:\Users\Public\Documents\RadianLabs\ReliefText\TeacherID-"+al5[relindex]+"_Date-" + date + "_Relief.pdf",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    pp.StartInfo = info;
                    pp.Start();
                    pp.WaitForInputIdle();
                    Thread.Sleep(3000);
                    if (false == pp.CloseMainWindow())
                    {
                        pp.Kill();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
