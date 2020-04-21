using MSharp;

namespace Modules
{
    class ClientTbl : ListModule<Domain.Client>
    {
        public ClientTbl()
        {
            // TODO: Configure me ...!
            HeaderText("Clients");
            
            Search(GeneralSearch.AllFields).Label("Find:");
            // ...
            
            Column(x => x.Name);
            Column(x => x.Image);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[18]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go <Admin.Clients.AddOrUpdatePage> ().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Remove)
                .OnClick(x => {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Client").Icon(FA.Plus)
                /*M#:w[27]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go <Admin.Clients.AddOrUpdatePage> ());
        }
    }
}
