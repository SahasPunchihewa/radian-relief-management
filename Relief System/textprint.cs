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
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;


namespace Relief_System
{
    class TextPrint:Program
    {

        public static void pdfsettings()
        {
            path = @"C:\Users\Public\Documents\RadianLabs\ReliefText\TeacherID-" + al5[relindex] + "_Date-" + date + "_Relief.pdf";
            PdfUnitConvertor uc = new PdfUnitConvertor(); ;
            PdfMargins marg = new PdfMargins(); ;
            PdfPageBase page;
            PdfDocument pdfd;
            float y = 10;
            PdfBrush bru;
            PdfTrueTypeFont fon;
            PdfStringFormat format;
            pdfd = new PdfDocument();
            marg.Top = uc.ConvertUnits(2.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            marg.Bottom = marg.Top;
            marg.Left = uc.ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            marg.Right = marg.Left;
            page = pdfd.Pages.Add(PdfPageSize.A4, marg);
            bru = PdfBrushes.Black;
            fon = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            format = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString(textname, fon, bru, page.Canvas.ClientSize.Width / 2, y, format);
            y = y + fon.MeasureString(textname, format).Height;
            y = y + 5;
            String[] pdfdata= {"Period;Class", "One;"+ relprinter[0] +"", "Two;" + relprinter[1] + "", "Three;" + relprinter[2] + "", "Four;" + relprinter[3] + "", "Five;" + relprinter[4] + "", "Six;" + relprinter[5] + "", "Seven;" + relprinter[6] + "", "Eight;" + relprinter[7] + "" };
            String[][] dataSource= new String[pdfdata.Length][];
            for (i = 0; i < pdfdata.Length; i++)
            {
                dataSource[i] = pdfdata[i].Split(';');
            }
            PdfTable pdftable = new PdfTable();
            pdftable.Style.CellPadding = 2;
            pdftable.Style.HeaderSource = PdfHeaderSource.Rows;
            pdftable.Style.HeaderRowCount = 1;
            pdftable.Style.ShowHeader = true;
            pdftable.DataSource = dataSource;
            PdfLayoutResult pdfresult = pdftable.Draw(page, new PointF(0, y));
            PdfBrush bru2 = PdfBrushes.Gray;
            PdfTrueTypeFont fon2 = new PdfTrueTypeFont(new Font("Arial", 9f));
            page.Canvas.DrawString(String.Format("{0}", pdfdata.Length - 1), fon2, bru2, 5, y);
            try
            {
                pdfd.SaveToFile(path);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            pdfd.Close();
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
