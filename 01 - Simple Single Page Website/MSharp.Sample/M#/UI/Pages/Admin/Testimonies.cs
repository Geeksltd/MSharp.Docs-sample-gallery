using MSharp;

namespace Admin
{
    class TestimoniesPage : SubPage<AdminPage>
    {
        public TestimoniesPage()
        {
            Add<Modules.TestimonyTbl>();
        }
    }
}