﻿#pragma checksum "..\..\QuestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4F3C856324A143E16714AEEE478BBE4786819A105653FE7A944D6D3E4868D9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using QuestTxt;
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


namespace QuestTxt {
    
    
    /// <summary>
    /// QuestWindow
    /// </summary>
    public partial class QuestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Main;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_FirstOption;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SecondOption;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ThirdOption;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Menu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_riddle;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\QuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_submitRiddle;
        
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
            System.Uri resourceLocater = new System.Uri("/QuestTxt;component/questwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QuestWindow.xaml"
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
            
            #line 8 "..\..\QuestWindow.xaml"
            ((QuestTxt.QuestWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_Main = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.button_FirstOption = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\QuestWindow.xaml"
            this.button_FirstOption.Click += new System.Windows.RoutedEventHandler(this.button_FirstOption_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_SecondOption = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\QuestWindow.xaml"
            this.button_SecondOption.Click += new System.Windows.RoutedEventHandler(this.button_SecondOption_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_ThirdOption = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\QuestWindow.xaml"
            this.button_ThirdOption.Click += new System.Windows.RoutedEventHandler(this.button_ThirdOption_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_Menu = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\QuestWindow.xaml"
            this.button_Menu.Click += new System.Windows.RoutedEventHandler(this.button_Menu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_riddle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.button_submitRiddle = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\QuestWindow.xaml"
            this.button_submitRiddle.Click += new System.Windows.RoutedEventHandler(this.button_submitRiddle_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
