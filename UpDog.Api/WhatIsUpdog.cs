using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace UpDog.Api.Api
{
    public static class WhatIsUpdog
    {
        private const string _responseMessage = "Not much, dog. what's up with you?";

        [FunctionName("what-is-updog")]
        // ReSharper disable once UnusedMember.Global
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = null)] HttpRequest request)
        {
            return new OkObjectResult(_responseMessage);
        }
    }
}
