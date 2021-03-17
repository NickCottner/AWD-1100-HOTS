using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Computer
    {
        private string _name;
        private string _IpAddress;
        private int[] _services = { 20, 21, 23, 25, 53, 80, 123, 389, 443 };

        public Computer(string name, string IpAddress, int[] services)
        {
            _name = name;
            _IpAddress = IpAddress;
            _services = services;
            
        }
        public string GetName()
        {
            return _name;
        }
        public string GetIpAddress()
        {
            return _IpAddress;
        }
        public int[] GetServices()
        {
            return _services;
        }
        public string ScanIpAddress()
        {
            return _IpAddress;
        }
        public string ShowComputer()
        {
            return _name;
        }
    }
}
