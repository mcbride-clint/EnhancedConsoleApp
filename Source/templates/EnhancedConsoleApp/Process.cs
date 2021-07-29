using System;
using Microsoft.Extensions.Logging;

namespace EnhancedConsoleApp
{
    /// <summary>
    /// Contains the logic of the Application
    /// </summary>
    public class Process
    {
        private readonly ILogger<Process> _logger;

        /// <summary>
        /// Constructor that will allow for dependencies to be injected.
        /// </summary>
        /// <param name="logger"></param>
        public Process(ILogger<Process> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Entry point to Application Logic
        /// </summary>
        public void Execute()
        {
            _logger.LogInformation("Process running at: {time}", DateTimeOffset.Now);
        }
    }
}
