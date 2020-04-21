using MSharp;

namespace Modules
{
    class TestimonyFrm : FormModule<Domain.Testimony>
    {
        public TestimonyFrm()
        {
            // TODO: Configure me ...!
            HeaderText("Testimony details");
            
            Field(x => x.Image);
            Field(x => x.Name);
            Field(x => x.Position);
            Field(x => x.Content);
            Field(x => x.DisplayOrder);
            
            Button("Cancel").OnClick(x => x.Go<Admin.TestimoniesPage>());
            
            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.Go<Admin.TestimoniesPage>();
            });
        }
    }
}