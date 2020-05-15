# How to remove a thousand separators in the numeric text field in Xamarin.Forms DataForm (SfDataForm)

You can disabled the thousand seperators for numeric editor in Xamarin.Forms [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started?) by using [EnableGroupSeparator](https://help.syncfusion.com/xamarin/numeric-entry/number-formatting?_ga=2.17119792.843378045.1589170218-1204678185.1570168583#set-enablegroupseparator) property.

Refer to the [online user guide documentation](https://help.syncfusion.com/xamarin/dataform/working-with-dataform?_ga=2.17994672.843378045.1589170218-1204678185.1570168583#auto-generating-dataformitems-for-the-data-field) for customize the editor in DataForm using  [AutoGeneratingDataFormItem](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.SfDataForm~AutoGeneratingDataFormItem_EV.html?) event.  

You can also refer to the following article.

https://www.syncfusion.com/kb/11527/how-to-remove-a-thousand-separators-in-the-numeric-text-field-in-xamarin-forms-dataform

**C#**

Set the **EnableGroupSeparator** property into false inside the **AutoGeneratingDataFormItem** event.

``` xml
public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
        }
        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.Name == "BirthYear")
                {
                    (e.DataFormItem as DataFormNumericItem).EnableGroupSeparator = false;
                }
            }
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            dataForm.AutoGeneratingDataFormItem -= DataForm_AutoGeneratingDataFormItem;
        }
  }
  ```
