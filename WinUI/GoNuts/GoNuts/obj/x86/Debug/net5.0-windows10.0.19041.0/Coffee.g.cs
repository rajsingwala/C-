﻿#pragma checksum "E:\C#\WinUI\GoNuts\GoNuts\Coffee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C8452737719A760803BEE105ACA0C71ADF0F753AFA4771BBB1E3D95EE129373"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace GoNuts
{
    partial class Coffee : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Coffee.xaml line 74
                {
                    this.coffee = target.As<Microsoft.UI.Xaml.Controls.TextBlock>();
                }
                break;
            case 3: // Coffee.xaml line 58
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element3 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element3).Click += this.Cream_Click;
                }
                break;
            case 4: // Coffee.xaml line 59
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element4 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element4).Click += this.Cream_Click;
                }
                break;
            case 5: // Coffee.xaml line 60
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element5 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element5).Click += this.Cream_Click;
                }
                break;
            case 6: // Coffee.xaml line 49
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element6 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element6).Click += this.Sweetner_Click;
                }
                break;
            case 7: // Coffee.xaml line 50
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element7 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element7).Click += this.Sweetner_Click;
                }
                break;
            case 8: // Coffee.xaml line 40
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element8 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element8).Click += this.Roast_Click;
                }
                break;
            case 9: // Coffee.xaml line 41
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element9 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element9).Click += this.Roast_Click;
                }
                break;
            case 10: // Coffee.xaml line 42
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element10 = target.As<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>();
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element10).Click += this.Roast_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

