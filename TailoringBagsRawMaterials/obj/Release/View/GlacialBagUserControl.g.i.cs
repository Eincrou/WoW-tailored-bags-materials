﻿#pragma checksum "..\..\..\View\GlacialBagUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8883909DA5E4C02048A2F03AC528D1C0"
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
    /// GlacialBagUserControl
    /// </summary>
    public partial class GlacialBagUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image glacialBagIcon;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox glacialAmountInput;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image glacialEnchantedClothOneIcon;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image glacialEnchantedClothTwoIcon;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image glacialImbuedIcon;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image glacialBoltIcon;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\GlacialBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image glacialClothIcon;
        
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
            System.Uri resourceLocater = new System.Uri("/TailoringBagsRawMaterials;component/view/glacialbagusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\GlacialBagUserControl.xaml"
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
            this.glacialBagIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.glacialAmountInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\View\GlacialBagUserControl.xaml"
            this.glacialAmountInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.glacialAmountInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.glacialEnchantedClothOneIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.glacialEnchantedClothTwoIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.glacialImbuedIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.glacialBoltIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.glacialClothIcon = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

