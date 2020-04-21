using MSharp;

namespace Admin
{
    class FeaturesPage : SubPage<AdminPage>
    {
        public FeaturesPage()
        {
            Add<Modules.FeatureTbl>();
        }
    }
}