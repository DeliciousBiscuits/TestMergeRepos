﻿#pragma checksum "C:\TestMergeRepos\StartFinanceMaster\InstaRichie\Views\DashBoardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14022ED7C7E08FE076A6139A5619C7FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartFinance.Views
{
    partial class DashBoardPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class DashBoardPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IDashBoardPage_Bindings
        {
            private global::StartFinance.Views.DashBoardPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj26;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj27;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj28;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj26Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj27Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj28Click;

            // Static fields for each binding's enabled/disabled state

            public DashBoardPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 95 && columnNumber == 31)
                {
                    this.obj26.Click -= obj26Click;
                }
                else if (lineNumber == 96 && columnNumber == 31)
                {
                    this.obj27.Click -= obj27Click;
                }
                else if (lineNumber == 97 && columnNumber == 31)
                {
                    this.obj28.Click -= obj28Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 26: // Views\DashBoardPage.xaml line 95
                        this.obj26 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj26Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoSettings();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj26Click;
                        break;
                    case 27: // Views\DashBoardPage.xaml line 96
                        this.obj27 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj27Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoPrivacy();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj27Click;
                        break;
                    case 28: // Views\DashBoardPage.xaml line 97
                        this.obj28 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj28Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoAbout();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj28Click;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IDashBoardPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::StartFinance.Views.DashBoardPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StartFinance.Views.DashBoardPage obj, int phase)
            {
                if (obj != null)
                {
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\DashBoardPage.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // Views\DashBoardPage.xaml line 33
                {
                    this.ViewModel = (global::StartFinance.ViewModels.MainPageViewModel)(target);
                }
                break;
            case 4: // Views\DashBoardPage.xaml line 49
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 5: // Views\DashBoardPage.xaml line 50
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // Views\DashBoardPage.xaml line 66
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7: // Views\DashBoardPage.xaml line 76
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8: // Views\DashBoardPage.xaml line 89
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 9: // Views\DashBoardPage.xaml line 113
                {
                    this.TopThreeCols = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 10: // Views\DashBoardPage.xaml line 114
                {
                    this.TopFourCols = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 11: // Views\DashBoardPage.xaml line 118
                {
                    this.SecondCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 12: // Views\DashBoardPage.xaml line 121
                {
                    this.DashTop = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13: // Views\DashBoardPage.xaml line 161
                {
                    this.CreditGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14: // Views\DashBoardPage.xaml line 177
                {
                    this.ReportGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 15: // Views\DashBoardPage.xaml line 190
                {
                    this.WishList = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16: // Views\DashBoardPage.xaml line 194
                {
                    this.Assetme = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 17: // Views\DashBoardPage.xaml line 182
                {
                    this.MonthlyData = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\DashBoardPage.xaml line 166
                {
                    this.CreditRatio = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Views\DashBoardPage.xaml line 169
                {
                    this.RatioReportTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // Views\DashBoardPage.xaml line 138
                {
                    this.Debts = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // Views\DashBoardPage.xaml line 143
                {
                    this.DebtChart = (global::CrossPieCharts.UWP.PieCharts.PieChart)(target);
                }
                break;
            case 22: // Views\DashBoardPage.xaml line 149
                {
                    this.CenterValue = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // Views\DashBoardPage.xaml line 131
                {
                    this.FullTotal = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // Views\DashBoardPage.xaml line 126
                {
                    this.AccountTotal = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // Views\DashBoardPage.xaml line 128
                {
                    this.Assets = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\DashBoardPage.xaml line 17
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    DashBoardPage_obj1_Bindings bindings = new DashBoardPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

