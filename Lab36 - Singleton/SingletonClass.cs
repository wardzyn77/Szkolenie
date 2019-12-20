using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36___Singleton
{
    public  class SingletonClass
    {
        private static SingletonClass instance;
        private SingletonClass ()
        {
            Console.WriteLine("Tworze Singleton");
        }
        public static SingletonClass Instance
        {
            get
            {
                if (instance ==null)
                {
                    instance = new SingletonClass();
                }
                return instance;
            }
        }
    }
}
