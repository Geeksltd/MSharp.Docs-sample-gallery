using MSharp;

namespace Admin.Clients
{
    class AddOrUpdatePage : SubPage<Admin.ClientsPage>
    {
        public AddOrUpdatePage()
        {
            Add<Modules.ClientFrm>();
        }
    }
}
