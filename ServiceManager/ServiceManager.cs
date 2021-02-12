
using ServiceProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProject.ServiceManager
{
    class ServiceManager : ISingletonService,IScopedService,ITransientService
    {
        Guid _id;

        public ServiceManager()
        {
            _id = Guid.NewGuid();
        }

        public Guid guid()
        {
            return _id;
        }
    }
}
