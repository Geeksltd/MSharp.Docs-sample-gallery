using MSharp;

namespace Admin.Testimonies
{
    class AddOrUpdatePage : SubPage<Admin.TestimoniesPage>
    {
        public AddOrUpdatePage()
        {
            Add<Modules.TestimonyFrm>();
        }
    }
}
