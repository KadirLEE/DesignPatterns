using System;

namespace ComputerInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportControl reportControl = new ReportControl();
            reportControl.GetInfo = new GetGPUInfo();
            reportControl.ComponentReport();

            reportControl.GetInfo = new GetCPUInfo();
            reportControl.ComponentReport();

            reportControl.GetInfo = new GetHDDInfo();
            reportControl.ComponentReport();
        }

        interface IGetInfo
        {
            void GetInfo();
        }

        class GetGPUInfo : IGetInfo
        {
            public void GetInfo()
            {
                Console.WriteLine("GPU: NVIDIA GeForce 1080i\n");
            }
        }

        class GetCPUInfo : IGetInfo
        {
            public void GetInfo()
            {
                Console.WriteLine("CPU: Intel CORE i9-7980xe\n");
            }
        }

        class GetHDDInfo : IGetInfo
        {
            public void GetInfo()
            {
                Console.WriteLine("HDD: Toshiba 6TB");
            }
        }

        class ReportControl
        {
            private IGetInfo getInfo;

            public IGetInfo GetInfo
            {
                get { return getInfo; }
                set { getInfo = value; }
            }

            public void ComponentReport()
            {
                getInfo.GetInfo();
            }
        }
    }
}