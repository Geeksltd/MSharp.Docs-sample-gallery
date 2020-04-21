using MSharp;

namespace Admin
{
    class ClientsPage : SubPage<AdminPage>
    {
        public ClientsPage()
        {
            Add<Modules.ClientTbl>();
        }
    }
}
