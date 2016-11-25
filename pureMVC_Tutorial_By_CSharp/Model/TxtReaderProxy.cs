using System;

using PureMVC.Interfaces;
using PureMVC.Patterns;

using pureMVC_Tutorial_By_CSharp.Facades;
using System.IO;

using pureMVC_Tutorial_By_CSharp.Model.DataObject;

namespace pureMVC_Tutorial_By_CSharp.Model
{
    class TxtReaderProxy : Proxy, IProxy
    {
        public new const string NAME = "TxtReaderProxy";

        public TxtReaderProxy() : base(NAME, new ReadTxtFileDO())
        {
            //This Module no need to initial
        }

        public override void OnRegister()
        {
            //This Module no need to initial
        }

        public void ReadTxt(string path)
        {
            bool hasException = false;

            string txtContent = ((ReadTxtFileDO)Data).ReadTxt(path);

            try
            {
                txtContent = File.ReadAllText(path);
            }
            catch(Exception ex)
            {
                hasException = true;
                txtContent = ex.ToString();
            }

            if (hasException == false)
            {
                SendNotification(NotificationNames.ShowTextContent, txtContent, "string");
            }
            else
            {
                SendNotification(NotificationNames.ShowTextContent, txtContent, "string");
            }
        }
    }
}
