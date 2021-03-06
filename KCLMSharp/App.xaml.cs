﻿using KCLMSharp.View;
using KCLMSharp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KCLMSharp {
	/// <summary>
	/// App.xaml の相互作用ロジック
	/// </summary>
	public partial class App : Application {
		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
			// メイン画面を作成して表示する
			var mv = new MainView();
			var mvm = new MainViewModel();
			mv.DataContext = mvm;
			mv.Show();
		}
	}
}
