namespace App5.Models
{
    public class Activity
    {
        public string Description { get; set; }
        public int UserId { get; set; }

        public string ImageUrl
        {
            get { return $"http://lorempixel.com/100/100/people/{UserId}"; }
        }
    }
}
