using MSharp;

namespace Modules
{
    class Footer : GenericModule
    {
        /*M#:w[6]T-Prop:Markup-Type:GenericModule-Do not use '<A>' directly in the code. Instead create a Button and reference it here using [#BUTTONS(ButtonName)#].*/public Footer()
        {
            IsInUse()
            .IsViewComponent()
            .WrapInForm(false)
            .Markup(@"
            <small>
				Designed & Developed by
				<a target='_blank' href='https://geeks.ltd.uk'>Geeks Ltd.</a>
                &copy; @(LocalTime.Now.Year) All rights reserved.
            </small>

            <span title='Back to top' class='icon-chevron-up'></span>
            ");
        }
    }
}
