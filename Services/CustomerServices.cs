using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcService.Protos;
using Grpc.Core;

namespace GrpcService.Services
{
    public class CustomerServices : Customer.CustomerBase

    {
        private readonly ILogger<CustomerServices> _logger;
        public CustomerServices(ILogger<CustomerServices> logger)
        {
            _logger = logger;

        }
        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();
            if (request.UserId == 1)
            {
                output.FirstName = "Ritwik";
                output.LastName = "Ghosh";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Kunal";
                output.LastName = "Ghosh";

            }
            else
            {
                output.FirstName = "John";
                output.LastName = "Doe";
            }
            return Task.FromResult(output);
        }
    }
}
