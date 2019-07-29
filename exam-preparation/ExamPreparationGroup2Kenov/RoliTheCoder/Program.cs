using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
    class Event
    {
        public string ID { get; set; }
        public string EventName { get; set; }
        public List<string> Participants = new List<string>();
    }
    //class Participants
    //{
    //    public string ParticipantName { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var events = new List<Event>();

            CreateEvent(input, events);

            Print(events);
        }

        public static void Print(List<Event> events)
        {
            foreach (var eventName in events.OrderByDescending(x => x.Participants.Count).ThenBy(x => x.EventName))
            {
                Console.WriteLine($"{eventName.EventName} - {eventName.Participants.Count}");
                foreach (var participant in eventName.Participants.OrderBy(n => n))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }

        public static List<Event> CreateEvent(string[] input, List<Event> events)
        {
            while (input[0] != "Time")
            {
                var newEvent = new Event();
                var participants = new List<string>();

                var eventID = input[0];
                var eventName = input[1];

                if (eventName[0] != '#')
                {
                    input = Console.ReadLine().Split(' ');
                    continue;
                }

                eventName = eventName.Remove(0, 1);
                

                if (events.Any(x => x.ID == eventID))
                {
                    var currentEvent = events.Find(x => x.ID == eventID);

                    if (currentEvent.EventName != eventName)
                    {
                        input = Console.ReadLine().Split(' ');
                        continue;
                    }
                    else
                    {
                        var currentParticipants = events.Find(x => x.ID == eventID).Participants.ToList();
                        for (int i = 2; i < input.Length; i++)
                        {
                            if (currentParticipants.Contains(input[i]))
                            {
                                continue;
                            }
                            events.Find(x => x.ID == eventID).Participants.Add(input[i]);
                        }

                        input = Console.ReadLine().Split(' ');
                    }
                }
                else
                {
                    for (int i = 2; i < input.Length; i++)
                    {
                        participants.Add(input[i]);
                    }

                    newEvent.ID = eventID;
                    newEvent.EventName = eventName;
                    newEvent.Participants = participants;

                    events.Add(newEvent);

                    input = Console.ReadLine().Split(' ');
                }
            }

            return events;
        }
    }
}
