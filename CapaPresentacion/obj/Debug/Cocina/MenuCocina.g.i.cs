﻿#pragma checksum "..\..\..\Cocina\MenuCocina.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF0A1F96DFC44404CA6A3B7ED46C18230CD5BB8BA23FA09C67EC1EF9B464BACE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CapaPresentacion.Cocina;
using FontAwesome.Sharp;
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


namespace CapaPresentacion.Cocina {
    
    
    /// <summary>
    /// MenuCocina
    /// </summary>
    public partial class MenuCocina : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizarWin;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbBienvenidaUsuario;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategoriaPanelCocina;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategoriaPanelGarzon;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbNombreUsuarioMenu;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbRolUsuarioMenu;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\Cocina\MenuCocina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrarSesion;
        
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
            System.Uri resourceLocater = new System.Uri("/CapaPresentacion;component/cocina/menucocina.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Cocina\MenuCocina.xaml"
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
            
            #line 10 "..\..\..\Cocina\MenuCocina.xaml"
            ((CapaPresentacion.Cocina.MenuCocina)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMinimizarWin = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Cocina\MenuCocina.xaml"
            this.btnMinimizarWin.Click += new System.Windows.RoutedEventHandler(this.btnMinimizarWin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbBienvenidaUsuario = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnCategoriaPanelCocina = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\..\Cocina\MenuCocina.xaml"
            this.btnCategoriaPanelCocina.Click += new System.Windows.RoutedEventHandler(this.btnCategoriaPanelCocina_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCategoriaPanelGarzon = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\Cocina\MenuCocina.xaml"
            this.btnCategoriaPanelGarzon.Click += new System.Windows.RoutedEventHandler(this.btnCategoriaPanelGarzon_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbNombreUsuarioMenu = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbRolUsuarioMenu = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.btnCerrarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 236 "..\..\..\Cocina\MenuCocina.xaml"
            this.btnCerrarSesion.Click += new System.Windows.RoutedEventHandler(this.btnCerrarSesion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
