using System;
using System.Collections.Generic;

namespace EventManager.Domain
{
    public class Event
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Subscriber> Subscribers { get; set; }

        public List<Resource> Resources { get; set; }
    }
}
