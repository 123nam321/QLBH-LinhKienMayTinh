// Updated by XamlIntelliSenseFileGenerator 3/27/2023 7:15:40 PM
<<<<<<< HEAD
#pragma checksum "..\..\qlLinhKien.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0FAAF99946F50E081923B8CDA8BF245D5C15A6911BAC55DA25B1A8EA2F6D4F29"
=======
﻿#pragma checksum "..\..\qlLinhKien.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6102E420886BC52EFCB747A1427EF243F0D85CE"
>>>>>>> 281bd656cb501d59eb0fc36fa410162871e4991f
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using wpfLKMT;


namespace wpfLKMT
{


    /// <summary>
    /// qlLinhKien
    /// </summary>
    public partial class qlLinhKien : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {


#line 11 "..\..\qlLinhKien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wpfLKMT;component/qllinhkien.xaml", System.UriKind.Relative);

#line 1 "..\..\qlLinhKien.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\qlLinhKien.xaml"
                    ((wpfLKMT.qlLinhKien)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
                    return;
                case 3:
                    this.txtMaLinhKien = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.txtTenLinhKien = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.cmbMaLoai = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 6:
                    this.txtGiaBan = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.checkActive = ((System.Windows.Controls.CheckBox)(target));
                    return;
                case 8:
                    this.cmbHSX = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 9:
                    this.txtTimKiemMaLK = ((System.Windows.Controls.TextBox)(target));

#line 60 "..\..\qlLinhKien.xaml"
                    this.txtTimKiemMaLK.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtTimKiemMaLK_TextChanged);

#line default
#line hidden
                    return;
                case 10:
                    this.btnThem = ((System.Windows.Controls.Button)(target));

#line 66 "..\..\qlLinhKien.xaml"
                    this.btnThem.Click += new System.Windows.RoutedEventHandler(this.btnThem_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.btnSua = ((System.Windows.Controls.Button)(target));

#line 67 "..\..\qlLinhKien.xaml"
                    this.btnSua.Click += new System.Windows.RoutedEventHandler(this.btnSua_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.btnLamMoi = ((System.Windows.Controls.Button)(target));

#line 68 "..\..\qlLinhKien.xaml"
                    this.btnLamMoi.Click += new System.Windows.RoutedEventHandler(this.BtnLamMoi_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.dgDanhSachLK = ((System.Windows.Controls.DataGrid)(target));

#line 73 "..\..\qlLinhKien.xaml"
                    this.dgDanhSachLK.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgDanhSachLK_SelectionChanged);

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
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 14:

#line 85 "..\..\qlLinhKien.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnXoa_Click);

#line default
#line hidden
                    break;
            }
        }
    }
}

