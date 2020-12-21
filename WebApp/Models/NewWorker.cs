using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class INewWorker
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string[] Image { get; set; }
    }
}
