﻿#pragma checksum "..\..\..\App.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "23CE853059D58827E81497C1024A6B7FE60A05864B6D8FC646A11EC8B486934E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Ninject;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using SteppPlanChecker;
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


namespace SteppPlanChecker {
    
    
    /// <summary>
    /// App
    /// </summary>
    public partial class App : Prism.Ninject.PrismApplication {
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main() {
            SplashScreen splashScreen = new SplashScreen("resources/esapixsplash.jpg");
            splashScreen.Show(true);
            SteppPlanChecker.App app = new SteppPlanChecker.App();
            app.Run();
        }
    }
}

