using Fiorello_PB101.Models;
using Fiorello_PB101.ViewModels.Blog;
using Fiorello_PB101.ViewModels.Expert;

namespace Fiorello_PB101.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public IEnumerable<BlogVM> Blogs { get; set; }
        public IEnumerable<ExpertVM> Experts { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
