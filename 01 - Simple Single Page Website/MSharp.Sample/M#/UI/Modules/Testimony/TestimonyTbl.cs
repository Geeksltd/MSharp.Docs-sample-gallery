using MSharp;

namespace Modules
{
    class TestimonyTbl : ListModule<Domain.Testimony>
    {
        public TestimonyTbl()
        {
            // TODO: Configure me ...!
            HeaderText("Testimonies");
            
            Search(GeneralSearch.AllFields).Label("Find:");
            // ...
            
            Column(x => x.Image);
            Column(x => x.Name);
            Column(x => x.Position);
            Column(x => x.Content);
            Column(x => x.DisplayOrder);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                .HeaderText("Actions")
                .OnClick(x => x.Go <Admin.Testimonies.AddOrUpdatePage>().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Remove)
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Testimony?")
                .CssClass("btn-danger")
                .OnClick(x => {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Testimony").Icon(FA.Plus)
                .OnClick(x => x.Go <Admin.Testimonies.AddOrUpdatePage>());
        }
    }
}