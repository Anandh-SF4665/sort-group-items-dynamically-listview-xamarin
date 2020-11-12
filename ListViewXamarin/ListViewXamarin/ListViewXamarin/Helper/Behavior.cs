using Syncfusion.DataSource;
using Syncfusion.DataSource.Extensions;
using Syncfusion.GridCommon.ScrollAxis;
using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields
        SfListView ListView;
        Button SortButton;
        #endregion

        #region Overrided
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor() { PropertyName = "ContactType" });

            SortButton = bindable.FindByName<Button>("sortButton");
            SortButton.Clicked += SortButton_Clicked;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            SortButton.Clicked -= SortButton_Clicked;
            ListView = null;
            SortButton = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Call back
        private void SortButton_Clicked(object sender, EventArgs e)
        {
            ListView.DataSource.SortDescriptors.Add(new SortDescriptor()
            {
                PropertyName = "ContactName",
                Direction = ListSortDirection.Ascending,
            });
            ListView.DataSource.Refresh();
        }
        #endregion
    }
}