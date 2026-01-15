/************************************************************************
   AvalonDock

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at https://opensource.org/licenses/MS-PL
 ************************************************************************/

using System.Windows;

namespace TestApp
{ 
	
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
	    public static int Start()
	    {
		    var app = new App();
		    app.InitializeComponent();
		    return app.Run();
	    }

        static App()
        {
	        AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AddLibrary(typeof(AvalonDock.DockingManager).Assembly);
        }
    }
}
