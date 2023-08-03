using UtilityLibrary.Interfaces;
using Microsoft.Extensions.Logging;

namespace UtilityLibrary.Classes
{
    public class UtilityLibrary : IUtilityLibrary
    {
        /// <summary>
        /// Class UtilityLibrary: Starting point of the utilitylibrary application. The application will provide
        /// the client with a simple api to use for multiple services. The client can inject required services.
        /// </summary>
        private ILogger? _loggerServiceToUse;
        public UtilityLibrary() { }
        public void InjectLoggingService(ILogger _loggingServiceToUse)
        {
            this._loggerServiceToUse = _loggingServiceToUse;
        }
    }
}
