using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace pureMVC_Tutorial_By_CSharp.Model.DataObject
{
    public class ReadTxtFileDO
    {
        public ReadTxtFileDO()
        {

        }

        public string ReadTxt(string path)
        {
            string content = string.Empty;

            try
            {
                content = File.ReadAllText(path);

            }
            catch (Exception ex)
            {
                content = ex.ToString();
            }

            return content;
        }
    }
}
