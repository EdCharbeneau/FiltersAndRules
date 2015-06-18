using FiltersAndRules.Model;
using System;
using System.Linq;

namespace FiltersAndRules.Filters
{
    public static class PostFilters
    {
        public static IQueryable<Post> ArePublished(this IQueryable<Post> posts)
        {
            return posts.Where(post => post.IsPublished);
        }

        public static IQueryable<Post> PostedOnOrBefore(this IQueryable<Post> posts, DateTime datePosted)
        {
            return posts.Where(post => post.PostedOn <= datePosted);
        }
    }

}
