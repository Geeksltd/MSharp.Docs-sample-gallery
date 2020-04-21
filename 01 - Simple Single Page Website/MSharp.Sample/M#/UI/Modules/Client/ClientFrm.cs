using MSharp;

namespace Modules
{
    class ClientFrm : FormModule<Domain.Client>
    {
        public ClientFrm()
        {
            // TODO: Configure me ...!
            HeaderText("Client details");
            
            Field(x => x.Name);
            Field(x => x.Image);
            
            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());
            
            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.Go<Admin.ClientsPage>();
            });
        }
    }
}