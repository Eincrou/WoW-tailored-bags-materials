﻿#pragma checksum "..\..\..\View\HexweaveBagUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49BEA128AAA6CC981A220828968DFAD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TailoringBagsRawMaterials.ViewModel;


namespace TailoringBagsRawMaterials.View {
    
    
    /// <summary>
    /// HexweaveBagUserControl
    /// </summary>
    public partial class HexweaveBagUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\View\HexweaveBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hexweaveBagIcon;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\HexweaveBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hexweaveAmountInput;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\HexweaveBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hexweaveBoltIcon;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\HexweaveBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hexweaveClothIcon;
        
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
            System.Uri resourceLocater = new System.Uri("/TailoringBagsRawMaterials;component/view/hexweavebagusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\HexweaveBagUserControl.xaml"
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
            this.hexweaveBagIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.hexweaveAmountInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\View\HexweaveBagUserControl.xaml"
            this.hexweaveAmountInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.hexweaveAmountInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.hexweaveBoltIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.hexweaveClothIcon = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

