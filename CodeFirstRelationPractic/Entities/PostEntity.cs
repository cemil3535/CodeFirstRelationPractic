namespace CodeFirstRelationPractic.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Context { get; set; }

        public int UserId { get; set; }

        public UserEntity User { get; set; }
    }
}
