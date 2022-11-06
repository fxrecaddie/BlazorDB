using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDatabase.Shared
{
    [Serializable]
    public class Person
    {
    
        public string  Id { get; set; }

    
        public string Name { get; set; }

     
        public string SurName { get; set; }

    }
}
