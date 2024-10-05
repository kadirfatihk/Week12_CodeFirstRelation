namespace Week12_CodeFirstRelation.Entities
{
    public class PostEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }


        // Relational Property
        public UserEntity User { get; set; }    // Bir yorumun sadece bir tane sahibi olabilir. (Bire bir)
    }
}
