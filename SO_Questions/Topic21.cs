using System;

namespace DotNet_store
{
    class Topic21
    {
        public void Entry()
        {
            Topic21_Logger logger = new Topic21_Logger();
            logger.Log(1, "Log message");
            logger.LogWithExplicit((ExplicitEventId)"1", "Log message");
            try
            {
                logger.LogWithExplicit((ExplicitEventId)"throw", "Log message");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    class Topic21_Logger
    {
        public void Log(EventId eventId, string message)
        {
            Console.WriteLine($"{eventId.Id}:{message}");
        }

        public void LogWithExplicit(ExplicitEventId eventId, string message)
        {
            Console.WriteLine($"{eventId.Id}:{message}");
        }
    }

    struct EventId //check https://github.com/aspnet/Logging/blob/master/src/Microsoft.Extensions.Logging.Abstractions/EventId.cs
    {
        public static implicit operator EventId(int id)
        {
            return new EventId(id);
        }

        public int Id { get; set; }
        public EventId(int id)
        {
            this.Id = id;
        }
    }

    struct ExplicitEventId
    {
        /// <summary>
        /// Use explicit when all values can not be converted implicitly
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator ExplicitEventId(string id)
        {
            if (Int32.TryParse(id, out int intId))
            {
                return new ExplicitEventId(intId);
            }

            throw new ArgumentException($"Argument can not be converted", $"{id}");

        }

        public int Id { get; set; }
        public ExplicitEventId(int id)
        {
            this.Id = id;
        }
    }
}
