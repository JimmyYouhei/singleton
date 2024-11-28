using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        // Private constructor to prevent instantiation from outside
        private Singleton() { }

        // Public method to provide access to the single instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
