namespace EventOrganizer.Domain.Models
{
    public class EventTag
    {
        public EventTag()
        {
            Keyword = string.Empty;
            EventModels = new List<EventModel>();
            TagToEvents = new List<TagToEvent>();
        }

        public EventTag(string keyword, ICollection<EventModel> eventModels, ICollection<TagToEvent> tagToEvents)
        {
            Keyword = keyword;
            EventModels = eventModels;
            TagToEvents = tagToEvents;
        }

        public string Keyword { get; set; }

        public virtual ICollection<EventModel> EventModels { get; set; }

        public virtual ICollection<TagToEvent> TagToEvents { get; set; }
    }
}
