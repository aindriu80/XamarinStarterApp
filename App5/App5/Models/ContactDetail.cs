namespace App5.Models
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }

        public string FullName
        {
            get { return $"{FirstName}{LastName}"; }
        }
    }
}
