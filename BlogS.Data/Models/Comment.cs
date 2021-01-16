using System;
using System.Collections.Generic;
using System.Text;

namespace BlogS.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public ApplicationUser Author { get; set; }
    //    public string Title { get; set; }
        public string Content { get; set; }
        public Comment Parent { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
  //      public bool Published { get; set; }
    //    public bool Approved { get; set; }
      //  public ApplicationUser Approver { get; set; }
        //public virtual IEnumerable<Comment> Posts { get; set; }
    }
}
