using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class BloggRepos
    {
        public bool CreateBlogPost(string text, string category)
        {
            using (var db = new SupenEntities())
            {
                var bp = new Blogg();
                bp.BloggId = Guid.NewGuid();
                bp.Category = category;
                bp.Text = text;
                db.Blogg.Add(bp);
                db.SaveChanges();
            }
            return true;
        }
    }
}
