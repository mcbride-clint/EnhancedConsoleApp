namespace EnhancedConsoleApp
{
    using System;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// sdf.
    /// </summary>
    public class Worker
    {
        private readonly ILogger<Worker> _logger;

        /// <summary>
        /// sdff.
        /// </summary>
        /// <param name="logger">sdf.</param>
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// sdf.
        /// </summary>
        public void Execute()
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        }
    }
}
