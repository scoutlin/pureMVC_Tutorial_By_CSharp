using System;
using System.Collections.Generic;
using System.Text;

using PureMVC.Interfaces;
using PureMVC.Patterns;

using pureMVC_Tutorial_By_CSharp.Facades;
using System.IO;

namespace pureMVC_Tutorial_By_CSharp.Model
{
    class TxtReaderProxy : Proxy, IProxy
    {
        public new const string NAME = "TxtReaderProxy";

        public TxtReaderProxy() : base(NAME)
        {
            
        }

        public void ReadTxt(string path)
        {
            string content = string.Empty;

            try
            {
                content = File.ReadAllText(path);
            }
            catch(Exception ex)
            {
                SendNotification(NotificationNames.ShowTextContent, ex.ToString(), "string");
            }

            if (content != string.Empty)
            {
                SendNotification(NotificationNames.ShowTextContent, content, "string");
            }
        }
    }
}
