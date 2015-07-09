using FiltersAndRules.Model;
using System;
using System.Linq;
using System.Linq.Expressions;
using PredicateExtensions;

namespace FiltersAndRules.Filters
{
    public static class PostFilters
    {
        public static Expression<Func<Post, bool>> PostedOnOrAfter(DateTime cutoffDate)
        {
            return post => post.PostedOn >= cutoffDate;
        }

        public static Expression<Func<Post, bool>> WithFeaturedAuthor(string featuredAuthor)
        {
            return post => post.Author == featuredAuthor;
        }

        public static Expression<Func<Post, bool>> FeaturedAuthorPostedOnOrAfter(string featuredAuthor, DateTime featuredAuthorCutoffDate)
        {
            return WithFeaturedAuthor(featuredAuthor).And(PostedOnOrAfter(featuredAuthorCutoffDate));
        }

        public static Expression<Func<Post, bool>> FeaturedAuthorsPostedOnOrAfter(string[] featuredAuthorNames, DateTime featuredAuthorCutoffDate)
        {
            var rule = PredicateExtensions.PredicateExtensions.Begin<Post>();
            foreach (var authorName in featuredAuthorNames)
            {
                rule = rule.Or(FeaturedAuthorPostedOnOrAfter(authorName, featuredAuthorCutoffDate));
            }
            return rule;
        }

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
