using MSharp;
using Domain;

public class AdminPage : RootPage
{
    public AdminPage()
    {
        Roles(AppRole.Admin);

        Set(PageSettings.AdminLeftMenu, "AdminMenu");

        OnStart(x => x.Go<Admin.SettingsPage>().RunServerSide());
    }
}
