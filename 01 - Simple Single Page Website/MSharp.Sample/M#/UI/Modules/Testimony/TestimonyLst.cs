using MSharp;

namespace Modules
{
    class TestimonyLst : ListModule<Domain.Testimony>
    {
        /*M#:w[6]T-Prop:Markup-Type:ListModule-Do not hard code IMG tag directly. Instead define your image as an M# Button with ImageUrl property set.*/public TestimonyLst()
        {
            WrapInForm(false);
            SortingStatement("item.DisplayOrder");
            RenderMode(ListRenderMode.List);


            Markup(@"<img src='@item.Image' />
<p>@item.Content</p>
<strong>@item.Name</strong>
<span>@item.Position</span>
");
            Footer("<ul></ul>");
        }
    }
}
