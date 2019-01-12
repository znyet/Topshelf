using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<Test>();
                x.RunAsLocalSystem();
                x.OnException(e => { });
            });
        }
    }

    class Test : ServiceControl
    {

        public bool Start(HostControl hostControl)
        {
            Console.WriteLine("start");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            Console.WriteLine("stop");
            return true;
        }
    }

}




//demo install -servicename Stuff -description "Topshelf Service"
//demo uninstall -servicename Stuff
//demo -help


//[HKEY_CLASSES_ROOT\Directory\Background\shell\OpenCmdHere]
//@="在此处打开命令行窗口"
//[HKEY_CLASSES_ROOT\Directory\Background\shell\OpenCmdHere\command]
//@="PowerShell -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/k, pushd,%V' -Verb RunAs\""