﻿#pragma checksum "..\..\altaRegistro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B11CAEBEBC419DCDBF99340948A4CD192B0B1B64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using VengaComoNo;


namespace VengaComoNo {
    
    
    /// <summary>
    /// altaRegistro
    /// </summary>
    public partial class altaRegistro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFecha;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMonto;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidad;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAgregar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btBuscar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSalir;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\altaRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdProd;
        
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
            System.Uri resourceLocater = new System.Uri("/VengaComoNo;component/altaregistro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\altaRegistro.xaml"
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
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtFecha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtMonto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\altaRegistro.xaml"
            this.btAgregar.Click += new System.Windows.RoutedEventHandler(this.btAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\altaRegistro.xaml"
            this.btBuscar.Click += new System.Windows.RoutedEventHandler(this.btBuscar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btSalir = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\altaRegistro.xaml"
            this.btSalir.Click += new System.Windows.RoutedEventHandler(this.btSalir_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txtIdProd = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

