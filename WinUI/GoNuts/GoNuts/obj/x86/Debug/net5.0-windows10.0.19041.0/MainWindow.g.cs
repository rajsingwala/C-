﻿#pragma checksum "E:\C#\WinUI\GoNuts\GoNuts\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4D984B6D7A5F43B88704D20B3F158A8ABE269A2A40BFB2CFF987A0D2AE305CE"
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
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
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
            case 2: // MainWindow.xaml line 99
                {
                    this.MyFrame = target.As<Microsoft.UI.Xaml.Controls.Frame>();
                }
                break;
            case 3: // MainWindow.xaml line 49
                {
                    this.donutBtn = target.As<Microsoft.UI.Xaml.Controls.Button>();
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.donutBtn).Click += this.donutBtn_Click;
                }
                break;
            case 4: // MainWindow.xaml line 59
                {
                    this.coffeeBtn = target.As<Microsoft.UI.Xaml.Controls.Button>();
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.coffeeBtn).Click += this.coffeeBtn_Click;
                }
                break;
            case 5: // MainWindow.xaml line 70
                {
                    this.schBtn = target.As<Microsoft.UI.Xaml.Controls.Button>();
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.schBtn).Click += this.schBtn_Click;
                }
                break;
            case 6: // MainWindow.xaml line 81
                {
                    this.comBtn = target.As<Microsoft.UI.Xaml.Controls.Button>();
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.comBtn).Click += this.comBtn_Click;
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

