using MSharp;
using System.Data.SqlClient;

namespace Modules
{
    class SlideLst : ListModule<Domain.Slide>
    {
        /*M#:w[7]T-Prop:Markup-Type:ListModule-Do not hard code IMG tag directly. Instead define your image as an M# Button with ImageUrl property set.*//*M#:w[7]T-Prop:Markup-Type:ListModule-Do not use '<A>' directly in the code. Instead create a Button and reference it here using [#BUTTONS(ButtonName)#].*/public SlideLst()
        {
            
            WrapInForm(false);
            SortingStatement("item.DisplayOrder");
            RenderMode(ListRenderMode.List);
            //MarkupWrapper("<div class='slideshow'>[#MODULE#]</div>");

            Markup(@"<img src='@item.Image' />
<div class='info'><div>

<span>@item.Title</span>
<span>@item.Description</span>
<a href='@item.LinkUrl'>@item.LinkText</a>

</div></div>");

        }
    }
}
