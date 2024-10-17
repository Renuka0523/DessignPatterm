using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProgram
{
    internal class Singleton
    {
        //Decleare private static field
        private static Singleton instance;

        private static ConnectionMultiplexer conn;

        //private constructor
        private Singleton() 
        {
            conn = ConnectionMultiplexer.Connect("localhost");
        }

        //GetInstance method which will be accessed from the outside scope
        //will return instance always when involked
        //if first time call create instance

        public static Singleton GetInstance() 
        {
            if (instance == null)
            {
                instance = new Singleton();
            }    
            return instance;
        }
        public IDatabase GetDatabaseObject()
        {
            return conn.GetDatabase();
        }
            
    }
}
