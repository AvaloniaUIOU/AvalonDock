﻿using System.Windows;

namespace AvalonDock.MVVMTestApp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		static App()
		{
			AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AutoEnable();
		}
	}
}
