using MSharp;

namespace Modules
{
    class About : GenericModule
    {
        /*M#:w[6]T-Prop:Markup-Type:GenericModule-There is too much custom code here. Refactor it, break it down, move logic to Model project, etc.*/public About()
        {
            WrapInForm(false)
                .IsInUse()
                .IsViewComponent()
               .Markup(@"
           <p class='about'>
                Lorem ipsum dolor sit amet, pro no argumentum complectitur, ad eros honestatis eam, 
                case veritus dissentiunt mei an. Vis cu perpetua vituperatoribus, eam constituam voluptatibus ea. 
                Modus antiopam eu vis, ne per congue eloquentiam, te pri eloquentiam referrentur. Est ea soluta 
                salutandi, discere fabellas aliquando ea vis, eum ex nemore reprimique theophrastus. Verterem 
                pericula ea vim, pro erant rationibus conclusionemque an, ex graecis copiosae quaerendum nam. 
                Sed in minim tantas.
            </p>");
        }
    }
}
