namespace EventOrganizer.Domain.Models
{
    public class TagToEvent
    {

        public TagToEvent()
        {
            Keyword = string.Empty;
            EventModel = new EventModel();
            EventTag = new EventTag();
        }

        public TagToEvent(string keyword, EventModel eventModel, EventTag eventTag)
        {
            Keyword = keyword;
            EventModel = eventModel;
            EventTag = eventTag;
        }

        public int EventId { get; set; }

        public virtual EventModel EventModel { get; set; }

        public string Keyword { get; set; }

        public virtual EventTag EventTag { get; set; }
    }
}
