using System;
using System.Collections.Generic;
using System.Text;

using PureMVC.Interfaces;
using PureMVC.Patterns;

using pureMVC_Tutorial_By_CSharp.Model;
using pureMVC_Tutorial_By_CSharp.View;

namespace pureMVC_Tutorial_By_CSharp.Controller
{
    public class InitCommand : SimpleCommand, ICommand
    {
        public override void Execute(INotification notification)
        {
            //base.Execute(notification);
            Facade.RegisterProxy(new TxtReaderProxy());

            Form1 form1 = (Form1)notification.Body;
            Facade.RegisterMediator(new FormMediator(form1));
        }
    }
}
