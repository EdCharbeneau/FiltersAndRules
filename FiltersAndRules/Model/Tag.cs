using System.Collections.Generic;

namespace FiltersAndRules.Model
{
    public class Tag
    {
        public virtual string Name { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual string Description { get; set; }

        public virtual IList<Post> Posts { get; set; }

        public bool IsPublished { get; set; }
    }
}