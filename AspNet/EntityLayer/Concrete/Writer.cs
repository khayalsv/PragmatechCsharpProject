using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public List<Blog> Blogs { get; set; }


        public virtual ICollection<Message2> WriterSender { get; set; }
        public virtual ICollection<Message2> WriterReceiver { get; set; }

    }
}
