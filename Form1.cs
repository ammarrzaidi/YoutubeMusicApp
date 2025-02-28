using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;  // Correct namespace
using Microsoft.Web.WebView2.Core;      // Required for WebView2 initialization

namespace YoutubeMusic
{
    public partial class Form1 : Form
    {
        private WebView2 webView;

        public Form1()
        {
            InitializeComponent();
             this.Text = "Youtube Music";
             this.Icon = new Icon("youtube_music_icon_NBU_icon.ico");

            InitializeWebView();
        }

        private void InitializeWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(webView);
            webView.Source = new Uri("https://music.youtube.com/");
            webView.EnsureCoreWebView2Async(); // Required initialization
        }
    }
}