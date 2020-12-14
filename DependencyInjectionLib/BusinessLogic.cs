using System;
using DependencyInjectionLib.Utilities;

namespace DependencyInjectionLib
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess) // 1. Pass to constructor
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData() 
        {

            _logger.Log("Starting processing of data");
            Console.WriteLine("Processing data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing data");

        }

    }
}
