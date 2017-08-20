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
		public ICommand ButtonCommand { get; }
		public List<string> ModeList { get; }
		private List<Point> ModeWindowSize { get; }
		public List<string> ModeUri { get; }
		private int modeIndex;
		public int ModeIndex {
			get => modeIndex;
			set {
				modeIndex = value;
				NotifyPropertyChanged(nameof(ModeIndex));
				WindowWidth = (int)ModeWindowSize[modeIndex].X;
				NotifyPropertyChanged(nameof(WindowWidth));
				WindowHeight = (int)ModeWindowSize[modeIndex].Y;
				NotifyPropertyChanged(nameof(WindowHeight));
			}
		}
		public List<string> OptionModeList { get; }
		public int OptionModeIndex { get; set; }
		public int WindowWidth { get; set; }
		public int WindowHeight { get; set; }
		private void ButtonAction() {
			// 中略
		}
		// コンストラクタ
		public MainViewModel() {
			ButtonCommand = new CommandBase(ButtonAction);
			ModeList = new List<string> { "SSキャプチャモード", "オプション" };
			OptionModeList = new List<string> { "環境設定", "その他設定" };
			ModeUri = new List<string> { @"..\View\SSCapturePage.xaml", @"..\View\OptionPage1.xaml" };
			ModeWindowSize = new List<Point> { new Point(200, 400), new Point(400, 800) };
			ModeIndex = 0;
			OptionModeIndex = 0;
		}
	}
}
