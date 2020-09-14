using System;

namespace UpDog.Api.Api
{
    public class WhoAndWhen
    {
        public string Who { get; }

        public DateTime When { get; }

        public WhoAndWhen(string who, DateTime when)
        {
            Who = who;
            When = when;
        }
    }
}
