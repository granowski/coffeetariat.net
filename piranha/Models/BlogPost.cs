using Piranha.AttributeBuilder;
using Piranha.Models;

namespace blog.Models
{
    [PostType(Title = "Blog post")]
    public class BlogPost : Post<BlogPost>
    {
        /// <summary>
        /// Gets/sets the hero.
        /// </summary>
        [Region]
        public Regions.Hero Hero { get; set; }
    }
}