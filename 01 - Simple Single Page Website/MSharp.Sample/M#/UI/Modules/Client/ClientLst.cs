using MSharp;

namespace Modules
{
    class ClientLst : ListModule<Domain.Client>
    {
        /*M#:w[6]T-Prop:Markup-Type:ListModule-Hardcoding in-line style is forbidden. Set a Css class instead.*/public ClientLst()
        {
            WrapInForm(false);

            RenderMode(ListRenderMode.List);

            //MarkupWrapper("<div class='features'>[#MODULE#]</div>");

            Markup(@"<span title='@item.Name' style='background-image:url(@item.Image)'></span>");
        }
    }
}
