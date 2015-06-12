using System;
using System.Collections.Generic;

namespace FiltersAndRules.Model
{
    public class Post
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public string ContentEncoded { get; set; }

        public virtual string ShortDescription { get; set; }

        public virtual string Description { get; set; }

        public virtual string Meta { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual bool IsPublished { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        public string Category { get; set; }

        public virtual IList<Tag> Tags { get; set; }

        public string Author { get; set; }

    }
}
