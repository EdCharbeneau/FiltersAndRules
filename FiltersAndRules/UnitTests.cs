using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FiltersAndRules.Model;
using System.Diagnostics;

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
                        .Where(post => post.IsPublished &&
                                    post.PostedOn <= today);
        }

        [Fact]
        public void CanGetFeaturedArticles()
        {
            DateTime today = DateTime.Parse("Thu, 06 Jun 2013 00:00:00 GMT");
            DateTime cutoffDate = today.AddDays(-1);
            DateTime featuredAuthorCutoffDate = today.AddDays(-7);
            string featuredAuthor = "Nick Harrison";

            IQueryable<Post> posts = GetFeaturedArticles(today, cutoffDate, featuredAuthor, featuredAuthorCutoffDate);

            posts.Count().Should().Be(2);
        }

        public IQueryable<Post> GetFeaturedArticles(DateTime today, DateTime cutoffDate, string featuredAuthor, DateTime featuredAuthorCutoffDate)
        {
            //Recent featured author posts
            var postRepository = new PostRepository();

            IQueryable<Post> posts = postRepository.GetAll()
                 .Where(post => post.IsPublished && post.PostedOn <= today && (post.PostedOn >= cutoffDate || post.Author == featuredAuthor && post.PostedOn >= featuredAuthorCutoffDate));

            return posts;
        }
    }
}
