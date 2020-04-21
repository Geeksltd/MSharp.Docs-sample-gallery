using MSharp;
using Domain;

namespace Modules
{
    public class AdminMenu : MenuModule
    {
        public AdminMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            WrapInForm(false);
            AjaxRedirect();
            IsViewComponent();
            RootCssClass("sidebar-menu");
            UlCssClass("nav flex-column");
            Using("Olive.Security");


            Item("General settings")
                .OnClick(x => x.Go<Admin.Settings.GeneralPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Admin.Settings.AdministratorsPage>());

            Item("Content blocks")
                .OnClick(x => x.Go<Admin.Settings.ContentBlocksPage>());

            Item("Slides")
                .OnClick(x => x.Go<Admin.SlidesPage>());

            Item("Features")
                .OnClick(x => x.Go<Admin.FeaturesPage>());

            Item("Clients")
                .OnClick(x => x.Go<Admin.ClientsPage>());

            Item("Testimonies")
                .OnClick(x => x.Go<Admin.TestimoniesPage>());
        }
    }
}