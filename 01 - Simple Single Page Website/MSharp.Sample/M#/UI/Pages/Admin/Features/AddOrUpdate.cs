using MSharp;

namespace Admin.Features
{
    class AddOrUpdatePage : SubPage<Admin.FeaturesPage>
    {
        public AddOrUpdatePage()
        {
            Add<Modules.FeatureFrm>();
        }
    }
}