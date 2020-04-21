using MSharp;

namespace Modules
{
    class Contact : GenericModule
    {
        /*M#:w[6]T-Prop:Markup-Type:GenericModule-There is too much custom code here. Refactor it, break it down, move logic to Model project, etc.*//*M#:w[6]T-Prop:Markup-Type:GenericModule-Do not use '<A>' directly in the code. Instead create a Button and reference it here using [#BUTTONS(ButtonName)#].*/public Contact()
        {
            IsInUse()
            .IsViewComponent()
            .WrapInForm(false)
            
            .Markup(@"
                <div id='map' data-lat='51.402899' data-long='-0.196441'></div>
                <div class='info'>
                    <div>
                        <address>6 Sutton Park Rd, Sutton, Greater London, SM1 2GD, United Kingdom</address>
                        <a href='tel:+44 203 507 0033'>+44 203 507 0033</a>
                        <a href='mailto:hello@geeks.ltd.uk'>hello@geeks.ltd.uk</a>
                        <ul>
                            <li><a target='_blank' class='icon-linkedin' href='http://www.linkedin.com/company/geeks-ltd'></a></li>
                            <li><a target='_blank' class='icon-twitter' href='https://twitter.com/GeeksLtd'></a></li>
                            <li><a target='_blank' class='icon-facebook' href='https://www.facebook.com/geeksltd'></a></li>
                        </ul>
                    <div>
                </div>
            ");
        }
    }
}
