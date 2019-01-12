# Topshelf
Fork from https://github.com/Topshelf/Topshelf <br>
Builder net45<br>

## Example
```c#
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
```
