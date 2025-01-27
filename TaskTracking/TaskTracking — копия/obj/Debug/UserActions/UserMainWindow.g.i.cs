﻿#pragma checksum "..\..\..\UserActions\UserMainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63DA357838FE3986170FF25CD6DED6C56A4322874887F6E7D7AFC2135B682DD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TaskTracking.UserActions;


namespace TaskTracking.UserActions {
    
    
    /// <summary>
    /// UserMainWindow
    /// </summary>
    public partial class UserMainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 28 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock backlogTextBlock;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox notInWorkListBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox inWorkListBox;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox readyListBox;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox cancelListBox;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\UserActions\UserMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createTaskButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TaskTracking;component/useractions/usermainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserActions\UserMainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 31 "..\..\..\UserActions\UserMainWindow.xaml"
            this.listBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\UserActions\UserMainWindow.xaml"
            this.searchTextBox.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.backlogTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.notInWorkListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.inWorkListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.readyListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.cancelListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            this.createTaskButton = ((System.Windows.Controls.Button)(target));
            
            #line 226 "..\..\..\UserActions\UserMainWindow.xaml"
            this.createTaskButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 84 "..\..\..\UserActions\UserMainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 122 "..\..\..\UserActions\UserMainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 159 "..\..\..\UserActions\UserMainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 197 "..\..\..\UserActions\UserMainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

