using MSharp;

namespace Modules
{
    class FeatureLst : ListModule<Domain.Feature>
    {
        public FeatureLst()
        {
            WrapInForm(false);

            RenderMode(ListRenderMode.List);

            //MarkupWrapper("<div class='features'>[#MODULE#]</div>");

            Markup(@"<div>
    <h2>@item.Title</h2>
<p>@item.Description</p>
</div>");
        }
    }
}