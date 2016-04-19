namespace WebApp.Models
{
    public class Session
    {
        public int Id { get; set; }

        public int SessionId { get; set; }
        public string Title { get; set; }

        public string DescriptionShort { get; set; }

        public string Description { get; set; }

        public Tenant Tenant { get; set; }


    }
}