using MSharp;

class HomePage : RootPage
{
    public HomePage()
    {
        Route("/");
        Layout(Layouts.Default);
        BrowserTitle("MSharp Sample Application");
        Set(PageSettings.MainNav, "MainMenu");
        Add<Modules.SlideLst>();
        Add<Modules.FeatureLst>();
        Add<Modules.About>();
        Add<Modules.ClientLst>();
        Add<Modules.TestimonyLst>();
        Add<Modules.Contact>();
        Set(PageSettings.MainFooter, "Footer");
        //MarkupTemplate("[#1#][#2#]<p class='about'>Lorem ipsum dolor sit amet, pro no argumentum complectitur, ad eros honestatis eam, case veritus dissentiunt mei an. Vis cu perpetua vituperatoribus, eam constituam voluptatibus ea. Modus antiopam eu vis, ne per congue eloquentiam, te pri eloquentiam referrentur. Est ea soluta salutandi, discere fabellas aliquando ea vis, eum ex nemore reprimique theophrastus. Verterem pericula ea vim, pro erant rationibus conclusionemque an, ex graecis copiosae quaerendum nam. Sed in minim tantas.</p>[#3#][#4#]");
    }
}