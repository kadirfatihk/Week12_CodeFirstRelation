namespace Week12_CodeFirstRelation.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }


        // Relational Property
        public List<PostEntity> Posts { get; set; }   // Bir kullanıcının birden çok yorumu olabilir. (Bire Çok)
    }
}
