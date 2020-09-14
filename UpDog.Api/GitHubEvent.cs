using System;

namespace UpDog.Api.Api
{
    public class GitHubEvent
    {
        public string Who { get; }

        public DateTime When { get; }

        public GitHubEvent(string who, DateTime when)
        {
            Who = who;
            When = when;
        }
    }
}
