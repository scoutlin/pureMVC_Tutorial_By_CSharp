using System;
using System.Collections.Generic;
using System.Text;

using PureMVC.Interfaces;
using PureMVC.Patterns;

using pureMVC_Tutorial_By_CSharp.Model;
using pureMVC_Tutorial_By_CSharp.Facades;

namespace pureMVC_Tutorial_By_CSharp.View
{
    class FormMediator : Mediator, IMediator
    {
        public new const string NAME = "FormMediator";

        private Form1 form;
        private TxtReaderProxy txtReaderProxy;

        public FormMediator(Form1 form) : base(NAME, form)
        {
            this.form = form;
            form.EventHandler_button1_Click += EventHandler_button1_Click;
        }

        public override void OnRegister()
        {
            base.OnRegister();
            txtReaderProxy = (TxtReaderProxy)Facade.RetrieveProxy(TxtReaderProxy.NAME);
        }

        void EventHandler_button1_Click(object sender, EventArgs e)
        {
            txtReaderProxy.ReadTxt(form.GetTextBox_Path.Text);
        }

        public override IList<string> ListNotificationInterests()
        {
            IList<string> list = new List<string>();

            list.Add(NotificationNames.ShowTextContent);

            return list;
        }

        public override void HandleNotification(INotification notification)
        {
            switch(notification.Name)
            {
                case NotificationNames.ShowTextContent:
                    {
                        form.GetRichTextBox_Content.Text = string.Empty;
                        switch(notification.Type)
                        {
                            default:
                                {

                                }
                                break;

                            case "string":
                                {
                                    form.GetRichTextBox_Content.Text = (string)notification.Body;
                                }
                                break;
                        }                     
                    }
                    break;
            }
        }
    }
}
