﻿#pragma checksum "..\..\fenster_k_bearbeiten.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40E7AC5AD61B4C8CF55F1AA1E9A30CF608CD857B110A7B2F0B85D32EC0FA9ACF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektNeu;
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


namespace ProjektNeu {
    
    
    /// <summary>
    /// fenster_k_bearbeiten
    /// </summary>
    public partial class fenster_k_bearbeiten : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\fenster_k_bearbeiten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_aendern;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\fenster_k_bearbeiten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_löschen;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\fenster_k_bearbeiten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_brief_erst;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\fenster_k_bearbeiten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG_kunde;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjektNeu;component/fenster_k_bearbeiten.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\fenster_k_bearbeiten.xaml"
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
            this.BT_aendern = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\fenster_k_bearbeiten.xaml"
            this.BT_aendern.Click += new System.Windows.RoutedEventHandler(this.BT_aendern_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BT_löschen = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\fenster_k_bearbeiten.xaml"
            this.BT_löschen.Click += new System.Windows.RoutedEventHandler(this.BT_löschen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BT_brief_erst = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\fenster_k_bearbeiten.xaml"
            this.BT_brief_erst.Click += new System.Windows.RoutedEventHandler(this.BT_brief_erst_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DG_kunde = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
