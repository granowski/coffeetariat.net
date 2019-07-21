using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;

namespace blog.Models.Regions
{
    public class Hero
    {
        [Field(Title = "Primary image")]
        public ImageField PrimaryImage { get; set; }

        [Field]
        public HtmlField Ingress { get; set; }
    }
}