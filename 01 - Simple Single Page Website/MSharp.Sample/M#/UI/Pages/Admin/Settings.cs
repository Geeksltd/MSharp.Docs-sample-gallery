using MSharp;
using Domain;

namespace Admin
{
    public class SettingsPage : SubPage<AdminPage>
    {
        public SettingsPage()
        {
            

            OnStart(x => x.Go<Settings.GeneralPage>().RunServerSide());
        }
    }
}