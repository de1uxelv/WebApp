using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.Interfaces;
using WebApp.Models;

namespace WebApp.Data.Mocks
{
    public class MockWorker : Interfaces.INewWorker
    {


        public IEnumerable<Interfaces.INewWorker> newWorker => new List<Interfaces.INewWorker> { };

    }
}
