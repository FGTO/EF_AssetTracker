using System;
using ConsoleApp;

namespace EF_AssetTracker.Domain
{
    public class Office
    {
        public Office(string name)
        {
            Name = name;
        }

        public string Name {get; set;}
         public string OfficeID {get; set;}
    }   
}
