using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace Fabrikalar.Kodlar
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel (string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];

        }

        public void Hucreye_yaz(int satir, int sutun, string icerik)
        {
            ws.Cells[satir, sutun].Value2 = icerik;
        }

        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            
          try
            {
                wb.SaveAs(path);
            }
            catch
            {

            }
                
       
        }
        public void Close()
        {
            wb.Close();
        }
        public bool excel_varmi(string path, string klasor_adi)
        {
            if (File.Exists(@path + "\\" + klasor_adi))
            {
                return true;
            }
            else
                return false;
        }

        public void excel_sil(string path, string klasor_adi)
        {
            string yol = path + "\\" + klasor_adi;
            if(File.Exists(yol))
            {
                File.Delete(yol);
            }
            //Directory.Delete(@path +"\\"+ klasor_adi+"\\",true);
            //Directory.Delete(@"C:\\Users\\İlker\\Documents\\Lokanta\\2018-Ağustos\\Juventus.xlsx",true);
        }
    }
}
