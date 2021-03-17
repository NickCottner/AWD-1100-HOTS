using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Password
    {
        private string _raw;
        private string _hash;

        public Password()
        {

        }

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
        }
        public string GetRaw()
        {
            return _raw;
        }
        public string GetHash()
        {
            return _hash;
        }
        public string CrackPassword(string hash)
        {
            return hash;
        }
    }
}
