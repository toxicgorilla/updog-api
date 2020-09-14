using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace UpDog.Api.Api
{
    public static class WhatIsUpdog
    {
        [FunctionName("what-is-updog")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest request)
        {
            const string responseMessage = "Not much, dog. what's up with you?";

            return new OkObjectResult(responseMessage);
        }
    }
}
