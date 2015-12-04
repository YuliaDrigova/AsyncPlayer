using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Parser
    {
        public string Parse(string fileName)
        {
            string[] result = fileName.Split('.');
            return result[result.Length - 2];
        }
    }
}
