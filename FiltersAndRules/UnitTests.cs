using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FiltersAndRules.Model;
using System.Diagnostics;
using FiltersAndRules.Filters;
using System.Linq.Expressions;
using PredicateExtensions;
using static FiltersAndRules.Filters.PostFilters;

namespace FiltersAndRules
{
    public class UnitTests
    {

        [Fact]
        public void CanGetPublishedArticles()
        {
            var postRepository = new PostRepository();
            DateTime today = DateTime.Parse("Thu, 06 Jun 2013 00:00:00 GMT");

            IQueryable<Post> posts = GetPublishedArticles(today);

            posts.Count().Should().Be(15);
        }

        private static IQueryable<Post> GetPublishedArticles(DateTime today)
        {
            var postRepository = new PostRepository();
            return postRepository.GetAll()
                        .ArePublished()
                        .PostedOnOrBefore(today);
        }

        [Fact]
        public void CanGetFeaturedArticles()
        {
            DateTime today = DateTime.Parse("Thu, 06 Jun 2013 00:00:00 GMT");
            DateTime cutoffDate = today.AddDays(-1);
            DateTime featuredAuthorCutoffDate = today.AddDays(-7);
            string[] featuredAuthors = { "Nick Harrison", "Edward Charbeneau" };

            IQueryable<Post> posts = GetFeaturedArticles(today, cutoffDate, featuredAuthors, featuredAuthorCutoffDate);

            posts.Count().Should().Be(3);
        }

        public IQueryable<Post> GetFeaturedArticles(DateTime today, DateTime cutoffDate, string[] featuredAuthors, DateTime featuredAuthorCutoffDate)
        {
            //Recent featured author posts
            var postRepository = new PostRepository();

            IQueryable<Post> posts = postRepository.GetAll()
                .ArePublished()
                .PostedOnOrBefore(today)
                .Where(
                    PostedOnOrAfter(cutoffDate)
                    .Or(FeaturedAuthorsPostedOnOrAfter(featuredAuthors,featuredAuthorCutoffDate))
                    );

            return posts;
        }



    }
}
