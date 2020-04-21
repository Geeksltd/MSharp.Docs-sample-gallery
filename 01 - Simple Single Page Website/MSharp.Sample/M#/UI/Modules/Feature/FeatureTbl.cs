using MSharp;

namespace Modules
{
    class FeatureTbl : ListModule<Domain.Feature>
    {
        public FeatureTbl()
        {
            // TODO: Configure me ...!
            HeaderText("Features");
            
            Search(GeneralSearch.AllFields).Label("Find:");
            // ...
            
            Column(x => x.Title);
            Column(x => x.Description);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[18]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go <Admin.Features.AddOrUpdatePage> ().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Remove)
                .OnClick(x => {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Feature").Icon(FA.Plus)
                /*M#:w[27]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go <Admin.Features.AddOrUpdatePage> ());
        }
    }
}
