﻿#pragma checksum "..\..\..\View\IllusionaryBagUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FA37B0D9B30020885E25DFBE14B6F4B"
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
    /// IllusionaryBagUserControl
    /// </summary>
    public partial class IllusionaryBagUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\View\IllusionaryBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image illusionaryBagIcon;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\IllusionaryBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox illusionaryAmountInput;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\IllusionaryBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image illusionaryEnchantedClothIcon;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\IllusionaryBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image illusionaryBoltIcon;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\IllusionaryBagUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image illusionaryClothIcon;
        
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
            System.Uri resourceLocater = new System.Uri("/TailoringBagsRawMaterials;component/view/illusionarybagusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\IllusionaryBagUserControl.xaml"
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
            this.illusionaryBagIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.illusionaryAmountInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\View\IllusionaryBagUserControl.xaml"
            this.illusionaryAmountInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.illusionaryAmountInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.illusionaryEnchantedClothIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.illusionaryBoltIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.illusionaryClothIcon = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

