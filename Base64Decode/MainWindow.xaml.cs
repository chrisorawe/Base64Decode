using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Base64Decode
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			string inputText = textBox.Text;

			if (inputText != "")
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();

				saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				saveFileDialog.Filter = "Pdf Files|*.pdf";
				saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");

				if (saveFileDialog.ShowDialog() == true)
				{
					File.WriteAllBytes(saveFileDialog.FileName, Convert.FromBase64String(inputText));
					textBox.Text = "";
				}
			}
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			textBox.Text = "";
		}
	}
}
