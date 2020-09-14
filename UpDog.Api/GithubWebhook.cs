//using System;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;

//namespace UpDog.Api.Api
//{
//    public static class GithubWebhook
//    {
//        [FunctionName("github-webhook")]
//        // ReSharper disable once UnusedMember.Global
//        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = null)] HttpRequest request,
//            [Queue("github-events"), StorageAccount("AzureWebJobsStorage")] ICollector<GitHubEvent> queue)
//        {
//            var githubEvent = new GitHubEvent(request.Host.Host, DateTime.UtcNow);
//            queue.Add(githubEvent);

//            return new OkObjectResult("done");
//        }
//    }
//}
