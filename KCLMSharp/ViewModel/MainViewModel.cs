using KCLMSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace KCLMSharp.ViewModel {
	class MainViewModel : ViewModelBase {
		#region 共通
		// ウィンドウサイズ
		public int WindowWidth { get; set; }
		public int WindowHeight { get; set; }
		// 各モードの一覧
		public List<string> ModeList { get; }
		// 各モードのウィンドウサイズ
		private List<Point> ModeWindowSize { get; }
		// 各モードのファイルパス
		public List<string> ModeUri { get; }
		// 現在選択されているモードのインデックス
		private int modeIndex;
		public int ModeIndex {
			get => modeIndex;
			set {
				modeIndex = value;
				NotifyPropertyChanged(nameof(ModeIndex));
				ResizeWindowSize();
			}
		}
		// その他
		public ICommand ButtonCommand { get; }
		#endregion

		#region SSキャプチャモード(SSCapturePage)

		#endregion

		#region オプション全般
		public List<string> OptionModeList { get; }
		private int optionModeIndex;
		public int OptionModeIndex {
			get => optionModeIndex;
			set {
				if (ModeIndex != Constant.ModeCount)
					return;
				optionModeIndex = value;
				NotifyPropertyChanged(nameof(OptionModeIndex));
				ResizeWindowSize();
			}
		}
		#endregion

		#region オプション - 環境設定(OptionPage1)

		#endregion

		private void ResizeWindowSize() {
			if (ModeIndex != Constant.ModeCount) {
				WindowWidth = (int)ModeWindowSize[modeIndex].X;
				NotifyPropertyChanged(nameof(WindowWidth));
				WindowHeight = (int)ModeWindowSize[modeIndex].Y;
				NotifyPropertyChanged(nameof(WindowHeight));
			}
			else {
				WindowWidth = (int)ModeWindowSize[Constant.ModeCount + optionModeIndex].X;
				NotifyPropertyChanged(nameof(WindowWidth));
				WindowHeight = (int)ModeWindowSize[Constant.ModeCount + optionModeIndex].Y;
				NotifyPropertyChanged(nameof(WindowHeight));
			}
		}
		private void ButtonAction() {
			// 中略
		}
		// コンストラクタ
		public MainViewModel() {
			ButtonCommand = new CommandBase(ButtonAction);
			ModeList = new List<string> {
				"SSキャプチャモード",
				"艦娘一覧モード",
				"攻略編成モード",
				"その他一覧作成モード",
				"オプション",
			};
			OptionModeList = new List<string> {
				"環境設定",
				"キャプチャ・作成設定",
				"動画キャプチャ設定",
				"Twitter設定",
				"その他設定",
			};
			ModeUri = new List<string> {
				@"..\View\SSCapturePage.xaml",
				@"..\View\KammusuListPage.xaml",
				@"..\View\FleetFormPage.xaml",
				@"..\View\OtherListPage.xaml",
				@"..\View\OptionPage1.xaml",
				@"..\View\OptionPage2.xaml",
				@"..\View\OptionPage3.xaml",
				@"..\View\OptionPage4.xaml",
				@"..\View\OptionPage5.xaml",
			};
			ModeWindowSize = new List<Point> {
				new Point(200, 400),
				new Point(200, 350),
				new Point(400, 400),
				new Point(200, 350),
				new Point(400, 800),
				new Point(400, 700),
				new Point(400, 600),
				new Point(400, 100),
				new Point(400, 100),
			};
			ModeIndex = 0;
			OptionModeIndex = 0;
		}
	}
}
