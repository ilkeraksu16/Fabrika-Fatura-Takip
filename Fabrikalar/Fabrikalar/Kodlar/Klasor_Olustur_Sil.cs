using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Fabrikalar.Kodlar
{
    class Klasor_Olustur_Sil
    {
        public void klasor_olustur(string klasor_adi,string path)
        {
           
            Directory.CreateDirectory(path+klasor_adi);
        }

        public void klasor_sil(string path,string klasor_adi)
        {
            Directory.Delete(path + klasor_adi);
        }

        public bool klasor_varmi(string path, string klasor_adi)
        {
            if (File.Exists(@path + "\\" + klasor_adi))
            {
                return true;
            }
            else
                return false;
        }
        
    }
}
