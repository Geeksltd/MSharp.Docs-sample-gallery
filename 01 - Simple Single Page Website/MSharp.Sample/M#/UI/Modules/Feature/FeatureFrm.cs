using MSharp;

namespace Modules
{
    class FeatureFrm : FormModule<Domain.Feature>
    {
        public FeatureFrm()
        {
            // TODO: Configure me ...!
            HeaderText("Feature details");
            
            Field(x => x.Title);
            Field(x => x.Description);
            
            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());
            
            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.Go<Admin.FeaturesPage>();
            });
        }
    }
}