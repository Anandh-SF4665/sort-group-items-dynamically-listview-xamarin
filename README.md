# sort-group-items-dynamically-listview-xamarin
How to sort the group items dynamically in  Xamarin.Forms ListView (SfListView)

## Sample

```xaml
<StackLayout>
    <Button x:Name="sortButton" Text="Sort the items" HeightRequest="50"/>
    <syncfusion:SfListView x:Name="listView" ItemSize="60" ItemsSource="{Binding ContactsInfo}" IsScrollBarVisible="False">
        <syncfusion:SfListView.ItemTemplate >
            <DataTemplate>
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
        <syncfusion:SfListView.GroupHeaderTemplate>
            <DataTemplate>
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </syncfusion:SfListView.GroupHeaderTemplate>
    </syncfusion:SfListView>
</StackLayout>

C#:
private void SortButton_Clicked(object sender, EventArgs e)
{
    ListView.DataSource.SortDescriptors.Add(new SortDescriptor()
    {
        PropertyName = "ContactName",
        Direction = ListSortDirection.Ascending,
    });
    ListView.DataSource.Refresh();
}
```
