using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing;

public class ControladorImpresion : IDisposable
   {
    
       #region Atributos
       
       private int m_currentPageIndex;
       private IList<Stream> m_streams;
       
       #endregion
       
       #region Métodos privados
       
       private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
       {
           //Routine to provide to the report renderer, in order to save an image for each page of the report.
           Stream stream = new FileStream(@"..\..\" + name + "." + fileNameExtension, FileMode.Create);
           m_streams.Add(stream);                   
           return stream;
       }
       
       private void Export(LocalReport report)
       {
           //Export the given report as an EMF (Enhanced Metafile) file.
           string deviceInfo =
             "<DeviceInfo>" +
             "  <OutputFormat>EMF</OutputFormat>" +
             "  <PageWidth>5in</PageWidth>" +
             "  <PageHeight>5in</PageHeight>" +
             "  <MarginTop>0in</MarginTop>" +
             "  <MarginLeft>0in</MarginLeft>" +
             "  <MarginRight>0in</MarginRight>" +
             "  <MarginBottom>0in</MarginBottom>" +
             "</DeviceInfo>";
           Warning[] warnings;
           m_streams = new List<Stream>();
           report.Render("Image", deviceInfo, CreateStream, out warnings);
           foreach (Stream stream in m_streams)
           { stream.Position = 0; }

           
       }
       
       private void PrintPage(object sender, PrintPageEventArgs ev)
       {
           //Handler for PrintPageEvents
           Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
           ev.Graphics.DrawImage(pageImage, ev.PageBounds);
           m_currentPageIndex++;
           ev.HasMorePages = (m_currentPageIndex<m_streams.Count);
       }
    
       private void Print()
       {
           //
           PrintDocument printDoc;
    
           String printerName = ImpresoraPredeterminada();
           if (m_streams == null || m_streams.Count == 0)
           { return; }
    
           printDoc = new PrintDocument();
           printDoc.PrinterSettings.PrinterName = printerName;
           if (!printDoc.PrinterSettings.IsValid)
           {
               string msg = String.Format("Can't find printer \"{0}\".", printerName);
               MessageBox.Show(msg, "Print Error");
               return;
           }
           printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                     printDoc.Print();
        
       }
       
       private string ImpresoraPredeterminada()
       {
           //
    
           for(Int32 i = 0 ; i<PrinterSettings.InstalledPrinters.Count ; i++)
           {
               PrinterSettings a = new PrinterSettings();
               a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
               if (a.IsDefaultPrinter)
               { return PrinterSettings.InstalledPrinters[i].ToString(); }
           }
           return "";
       }
    
       #endregion
       
       #region Métodos públicos
       
       public void Imprimir(LocalReport argReporte)
       {
           //
           Export(argReporte);
           m_currentPageIndex = 0;
           Print();
           Dispose();
           
       }
       
       #endregion
    
      #region Soporte para implementación de interfaces
      
      #region IDisposable
      
      public void Dispose()
      {
          if (m_streams != null)
          {
              foreach (Stream stream in m_streams)
              {  stream.Close(); }
              m_streams = null;
          }
      }
      
      #endregion
      
      #endregion
   
  }