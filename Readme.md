<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653389/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2209)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Synchronize the WPF Data Grid with the ICollectionView

This example demonstrates how to bind the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) to an [ICollectionView](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.icollectionview) and perform data shaping operations at the data source level.

This project contains the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) and [ListView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.listview) bound to the same [ICollectionView](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.icollectionview) source:

![image](https://user-images.githubusercontent.com/65009440/210560694-f844d1aa-09b7-4131-8991-6bdd7dcc6d5a.png)

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))

## Documentation

* [Bind the WPF Data Grid to ICollectionView](https://docs.devexpress.com/WPF/11124/controls-and-libraries/data-grid/bind-to-data/bind-to-icollectionview)
* [DataViewBase.IsSynchronizedWithCurrentItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.IsSynchronizedWithCurrentItem)
* [WPF Data Grid: Bind to Data](https://docs.devexpress.com/WPF/7352/controls-and-libraries/data-grid/bind-to-data)

## More Examples

* [Bind the WPF Data Grid to Data](https://github.com/DevExpress-Examples/how-to-bind-wpf-grid-to-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=synchronize-wpf-data-grid-with-icollectionview&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=synchronize-wpf-data-grid-with-icollectionview&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
