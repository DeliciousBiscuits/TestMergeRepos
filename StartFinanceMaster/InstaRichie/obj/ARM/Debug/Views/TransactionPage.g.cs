﻿#pragma checksum "C:\TestMergeRepos\StartFinanceMaster\InstaRichie\Views\TransactionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8FA1CCBB2C228364490F32CB3E66571E"
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
    partial class TransactionPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TransactionPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITransactionPage_Bindings
        {
            private global::StartFinance.Views.TransactionPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj24;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj25;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj26;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj24Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj25Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj26Click;

            // Static fields for each binding's enabled/disabled state

            public TransactionPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 88 && columnNumber == 31)
                {
                    this.obj24.Click -= obj24Click;
                }
                else if (lineNumber == 89 && columnNumber == 31)
                {
                    this.obj25.Click -= obj25Click;
                }
                else if (lineNumber == 90 && columnNumber == 31)
                {
                    this.obj26.Click -= obj26Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 24: // Views\TransactionPage.xaml line 88
                        this.obj24 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj24Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoSettings();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj24Click;
                        break;
                    case 25: // Views\TransactionPage.xaml line 89
                        this.obj25 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj25Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoPrivacy();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj25Click;
                        break;
                    case 26: // Views\TransactionPage.xaml line 90
                        this.obj26 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj26Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoAbout();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj26Click;
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

            // ITransactionPage_Bindings

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
                    this.dataRoot = (global::StartFinance.Views.TransactionPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StartFinance.Views.TransactionPage obj, int phase)
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
            case 1: // Views\TransactionPage.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // Views\TransactionPage.xaml line 32
                {
                    this.ViewModel = (global::StartFinance.ViewModels.MainPageViewModel)(target);
                }
                break;
            case 4: // Views\TransactionPage.xaml line 51
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 5: // Views\TransactionPage.xaml line 52
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // Views\TransactionPage.xaml line 61
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7: // Views\TransactionPage.xaml line 70
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8: // Views\TransactionPage.xaml line 82
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 9: // Views\TransactionPage.xaml line 95
                {
                    this.pageFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 10: // Views\TransactionPage.xaml line 105
                {
                    this.InternFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 11: // Views\TransactionPage.xaml line 117
                {
                    this.pagecontent = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.pagecontent).SelectionChanged += this.Pivot_SelectionChanged;
                }
                break;
            case 12: // Views\TransactionPage.xaml line 136
                {
                    this.FromAccountsSel = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 13: // Views\TransactionPage.xaml line 137
                {
                    this.ToAccountSel = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 14: // Views\TransactionPage.xaml line 138
                {
                    this.TranDateStamp = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 15: // Views\TransactionPage.xaml line 139
                {
                    this.TransferMoney = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // Views\TransactionPage.xaml line 140
                {
                    this.TDesc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // Views\TransactionPage.xaml line 122
                {
                    this.AccountsListSel = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 18: // Views\TransactionPage.xaml line 123
                {
                    this.DateStamp = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 19: // Views\TransactionPage.xaml line 124
                {
                    this.IncExpSelect = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 20: // Views\TransactionPage.xaml line 128
                {
                    this.MoneyIn = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21: // Views\TransactionPage.xaml line 129
                {
                    this.Desc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 22: // Views\TransactionPage.xaml line 111
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element22 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element22).Click += this.Transfer_Click;
                }
                break;
            case 23: // Views\TransactionPage.xaml line 101
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element23 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element23).Click += this.AddData;
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
            case 1: // Views\TransactionPage.xaml line 17
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TransactionPage_obj1_Bindings bindings = new TransactionPage_obj1_Bindings();
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

