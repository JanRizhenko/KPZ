using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticator
{
    public sealed class Authenticator
    {
        private static readonly Authenticator _instance = new Authenticator();
        private Authenticator() { }

        public static Authenticator Instance => _instance;

        public void Authenticate(string user)
        {
            Console.WriteLine($"Authenticating user: {user}");
        }
    }

}
