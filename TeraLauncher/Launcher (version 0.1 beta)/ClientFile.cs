using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Launcher__version_0._1_beta_
{
    class ClientFile
    {
        public String Name, Hash;

        public ClientFile(string name, string hash)
        {
            this.Name = name;
            this.Hash = hash;
        }
    }
}
