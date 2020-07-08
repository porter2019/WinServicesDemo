using Microsoft.Owin.Hosting;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace LitService
{
    public partial class LitService : ServiceBase
    {
        Logger log = LogManager.GetCurrentClassLogger();
        IDisposable apiserver = null;

        public LitService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            StartWebAPI();
        }

        protected override void OnStop()
        {
            StopWebAPI();
        }

        void StartWebAPI()
        {
            string port = ConfigurationManager.AppSettings["APIPort"];
            var serveruri = "http://+:" + port + "/";
            apiserver = WebApp.Start<Startup>(url: serveruri);
            log.Info($"服务已启动，Web API端口:{port}");
        }

        void StopWebAPI()
        {
            if (apiserver != null) apiserver.Dispose();
            log.Info("服务已停止");
        }

    }
}
