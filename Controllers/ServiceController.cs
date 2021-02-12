using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly ITransientService _transientService;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService;
        private readonly ISingletonService _singletonService2;

        public ServiceController(ITransientService transientService,
                                 ITransientService transientService2,
                                 IScopedService scopedService,
                                 IScopedService scopedService2,
                                 ISingletonService singletonService,
                                 ISingletonService singletonService2)
        {
            _transientService = transientService;
            _transientService2 = transientService2;
            _scopedService = scopedService;
            _scopedService2 = scopedService2;
            _singletonService = singletonService;
            _singletonService2 = singletonService2;
        }

        [HttpGet]
        public string Get()
        {
            string result = $"Transient : {_transientService.guid()} {Environment.NewLine}" +
                            $"Transient2 : {_transientService2.guid()} {Environment.NewLine}" +
                            $"Scoped : {_scopedService.guid()} {Environment.NewLine}" +
                            $"Scoped2 : {_scopedService2.guid()} {Environment.NewLine}" +
                            $"Singleton : {_singletonService.guid()} {Environment.NewLine}" +
                            $"Singleton2 : {_singletonService2.guid()} {Environment.NewLine}";

            return result;
        }
    }
}
