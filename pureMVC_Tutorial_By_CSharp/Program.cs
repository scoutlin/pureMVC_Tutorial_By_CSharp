using System;
using System.Collections.Generic;
using System.Windows.Forms;

using pureMVC_Tutorial_By_CSharp.Facades;

namespace pureMVC_Tutorial_By_CSharp
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 form1 = new Form1();

            AppFacade appFacade = (AppFacade)AppFacade.Instance;
            appFacade.Init();
            appFacade.Start(form1);

            Application.Run(form1);
        }
    }
}
