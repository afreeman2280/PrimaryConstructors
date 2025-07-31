using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors;

public class DIBefore
{
    private readonly ILogger<DIBefore> _logger;
    
    public DIBefore(ILogger<DIBefore> logger)
    {
        _logger = logger;
    }

}

public class DIAfter(ILogger<DIAfter> logger)
{
    private readonly ILogger<DIAfter> _logger = logger;


    //public void LogMessage(string message)
    //{
    //    _logger.LogInformation(message);
    //}
}