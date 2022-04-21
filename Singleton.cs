using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronSingleton
{
        public class Singleton
        {
            private static Singleton _instance = null;
            public string mensaje = "";
            protected Singleton()
            {
            mensaje = "Hola Mundo";
            }

            public static Singleton Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new Singleton();

                    return _instance;
                }
            }

        }
    
}
