using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICreator> creators = new List<ICreator>();
            creators.Add(new LinkedinCreator());
            creators.Add(new GoogleCreator());
            foreach (var item in creators)
            {
                IAutenticacao aut = item.CreateInstance();
                aut.Autenticar();
            }            
        }
    }
}
