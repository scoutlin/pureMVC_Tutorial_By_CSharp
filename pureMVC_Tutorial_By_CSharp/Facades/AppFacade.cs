using System;

using PureMVC.Interfaces;
using PureMVC.Patterns;

using pureMVC_Tutorial_By_CSharp.Controller;

namespace pureMVC_Tutorial_By_CSharp.Facades
{
    public class AppFacade : Facade, IFacade
    {
        public new static IFacade Instance
        {
            get
            {
                if (m_instance == null)
                {
                    lock (m_staticSyncRoot)
                    {
                        if (m_instance == null)
                        {
                            m_instance = new AppFacade();
                        }
                    }
                }

                return m_instance;
            }
        }

        /// <summary>
        /// RegistCommand
        /// </summary>
        /// <param name="app"></param>
        public void Init()
        {
            RegisterCommand(CommandNames.Init, typeof(InitCommand));
        }

        public void Start(Object app)
        {
            SendNotification(CommandNames.Init, app);
        }
    }
}
