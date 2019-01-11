using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace YinYueTai_Downloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomInitializeComponent();
        }

        private VideoSearchResult videoSearchResult; // 搜索结果
        private List<VideoInfo> videoInfos = new List<VideoInfo>(); // 视频信息集合
        private VideoInfo videoInfo; // 当前视频信息
        private Data data; // 当前视频数据
        private PageInfo pageInfo; // 分页信息

        private int currentPageIndex = 1; // 当前页码

        private string videoUrl, imageUrl; // 资源的URL
        private string videoFilePath, imageFilePath; // 保存在本地的路径
        private string videoFileName, imageFileName; // 保存在本地的路径
        private string videoFileExt, imageFileExt; // 文件扩展名

        private WebClient imageClient = new WebClient(); // 图片下载客户端
        private WebClient videoClient = new WebClient(); // 视频下载客户端

        private void CustomInitializeComponent()
        {
            toolTip1.SetToolTip(btnVideoOpen, "使用默认视频播放器打开视频");
            toolTip1.SetToolTip(btnImageOpen, "使用默认图片查看器打开视频");
            toolTip1.SetToolTip(lblImagePercentage, "双击打开所在文件夹");
            toolTip1.SetToolTip(lblVideoPercentage, "双击打开所在文件夹");
            toolTip1.SetToolTip(progressBar1, "双击打开所在文件夹");
            toolTip1.SetToolTip(progressBar2, "双击打开所在文件夹");
            treeView1.Nodes[0].Expand();
        }

        // 搜索按钮点击事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 隐藏信息面板
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            VideoSearch(1);
        }

        // 下一页按钮点击事件
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            VideoSearch(currentPageIndex + 1);
        }

        // 上一页按钮点击事件
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            VideoSearch(currentPageIndex - 1);
        }

        // 搜索视频
        private void VideoSearch(int pageIndex, int pageSize=10)
        {
            string key = tboxKeyword.Text;
            try
            {
                // 搜索视频
                Cursor.Current = Cursors.WaitCursor;
                videoSearchResult = Action.SearchVideo(key, pageIndex, pageSize).Result;
                Cursor.Current = Cursors.Default;

                pageInfo = videoSearchResult.PageInfo;
                currentPageIndex = pageInfo.PageNum;
                string totalInfoText = "共 {0} 条搜索结果";
                lblTotalInfo.Text = String.Format(totalInfoText, pageInfo.TotalCount);
                string pageInfoText = "第 {0} / {1} 页";
                lblPageInfo.Text = String.Format(pageInfoText, currentPageIndex, pageInfo.PageCount);
                // 分页判断
                if (currentPageIndex > 1)
                {
                    btnPrevPage.Enabled = true;
                }
                else btnPrevPage.Enabled = false;

                if (pageInfo.PageCount > currentPageIndex)
                {
                    btnNextPage.Enabled = true;
                }
                else btnNextPage.Enabled = false;

                // 清空列表
                lboxVideoList.Items.Clear();
                // 重新填充
                foreach (var item in videoSearchResult.Videos.Data)
                {
                    lboxVideoList.Items.Add(item.Title);
                    videoInfos.Add(null);
                }
                // 默认选中第一个
                lboxVideoList.SelectedIndex = 0;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("网络连接超时，请重试！");
            }
            catch (Exception)
            {
                currentPageIndex = 0;
                string pageInfoText = "第 {0} / {1} 页";
                lblPageInfo.Text = String.Format(pageInfoText, 0, 0);
                lblTotalInfo.Text = "未找到相关视频";
                // 清空列表
                lboxVideoList.Items.Clear();
                panel2.Visible = true;
                MessageBox.Show("未找到相关视频，请更换关键词！");
            }
        }

        // 自绘 Item，使其视觉效果更好
        private void ListBoxGroupRange_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        // 设置 ItemHeight
        private void ListBoxGroupRange_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 4 * e.ItemHeight;
        }


        // 选中搜索结果列表事件
        private void lboxVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabPage1)
            {
                tabControl1.SelectTab(tabPage1);
            }
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            var itemIndex = lboxVideoList.SelectedIndex;
            data = videoSearchResult.Videos.Data[itemIndex]; // 视频数据
            var videoId = data.Id;
            pboxHeadImage.ImageLocation = "http:" + data.HeadImg; // 设置封面图片

            label1.Text = "歌手姓名：" + data.artists.First().Name;
            label2.Text = "视频时长：" + data.Duration;
            label3.Text = "上传时间：" + data.PubDate;
            label4.Text = "总播放量：" + data.Value;

            // 配置好下视频信息后可见
            if (!label1.Visible)
            {
                label1.Visible = label2.Visible = label3.Visible = label4.Visible = true;
            }
            
            // 获取图片下载所需信息
            var url = "http:" + data.HeadImg;
            var fileName = data.Title;
            var extension = url.Split('?').First().Split('.').Last();
            fileName += '.' + extension;

            imageUrl = url;
            imageFileName = fileName;
            imageFileExt = extension;

            try
            {
                // 增加判断避免重复发送请求
                if (videoInfos[itemIndex] == null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    videoInfos[itemIndex] = Action.GetVideoInfo(videoId).Result;
                    Cursor.Current = Cursors.Default;
                }
                videoInfo = videoInfos[itemIndex];

                // 设置清晰度列表
                cbboxResolution.Items.Clear();
                foreach (var item in videoInfo.VideoUrlModels)
                {
                    var resolution = item.QualityLevelName;
                    cbboxResolution.Items.Add(resolution);
                }
                cbboxResolution.SelectedItem = videoInfo.VideoUrlModels.First().QualityLevelName;

                // 配置好下载数据后可见
                if (!btnImageDownload.Visible)
                {
                    btnImageDownload.Visible = btnVideoDownload.Visible =
                    btnVideoPlay.Visible = cbboxResolution.Visible = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("网络连接超时，请重试！");
            }
        }

        // 选中清晰度事件
        private void cbboxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取视频下载所需的信息
            var itemIndex = cbboxResolution.SelectedIndex;
            var url = videoInfo.VideoUrlModels[itemIndex].VideoUrl;
            var fileName = data.Title;
            var extension = url.Split('?').First().Split('.').Last();
            fileName += '.' + extension;

            videoFileName = fileName;
            videoFileExt = extension;
            videoUrl = url;
        }

        // 执行视频下载
        private void DownloadVideo()
        {
            progressBar1.Visible = lblVideoPercentage.Visible = true;
            try
            {
                videoClient.DownloadFileCompleted += video_DownloadFileCompleted;
                videoClient.DownloadProgressChanged += video_DownloadProgressChanged;
                videoClient.DownloadFileAsync(new Uri(videoUrl), videoFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        // 执行图片下载
        private void DownloadImage()
        {
            progressBar2.Visible = lblImagePercentage.Visible = true;
            try
            {
                imageClient.DownloadFileCompleted += image_DownloadFileCompleted;
                imageClient.DownloadProgressChanged += image_DownloadProgressChanged;
                imageClient.DownloadFileAsync(new Uri(imageUrl), imageFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }


        // 视频下载完成事件
        private void video_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnVideoOpen.Visible = true;
        }

        // 图片下载完成事件
        private void image_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnImageOpen.Visible = true;
        }

        // 视频下载状态改变事件，设置进度条
        private void video_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)e.TotalBytesToReceive;
            progressBar1.Value = (int)e.BytesReceived;
            lblVideoPercentage.Text = e.ProgressPercentage + "%";
        }

        // 图片下载状态改变事件，设置进度条
        private void image_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = (int)e.TotalBytesToReceive;
            progressBar2.Value = (int)e.BytesReceived;
            lblImagePercentage.Text = e.ProgressPercentage + "%";
        }

        // 下载视频按钮点击事件
        private void btnVideoDownload_Click(object sender, EventArgs e)
        {

            // 设置文件类型
            saveFileDialog.Filter = "视频文件|*." + videoFileExt;

            // 设置默认文件类型显示顺序 
            saveFileDialog.FilterIndex = 1;

            // 设置对话框是否记忆上次打开的目录 
            saveFileDialog.RestoreDirectory = true;

            // 设置默认的文件名
            saveFileDialog.FileName = videoFileName;

            // 设置默认的文件扩展名
            saveFileDialog.DefaultExt = videoFileExt;

            // 点击保存按钮后执行视频下载
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoFilePath = saveFileDialog.FileName.ToString(); // 获得文件路径
                DownloadVideo(); // 下载视频
            }
        }

        // 下载图片按钮点击事件
        private void btnImageDownload_Click(object sender, EventArgs e)
        {
            // 设置文件类型
            saveFileDialog.Filter = "图片文件|*." + imageFileExt;

            // 设置默认文件类型显示顺序 
            saveFileDialog.FilterIndex = 1;

            // 设置对话框是否记忆上次打开的目录 
            saveFileDialog.RestoreDirectory = true;

            // 设置默认的文件名
            saveFileDialog.FileName = imageFileName;

            // 设置默认的文件扩展名
            saveFileDialog.DefaultExt = imageFileExt;

            // 点击保存按钮后执行图片下载
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = saveFileDialog.FileName.ToString(); // 获得文件路径
                DownloadImage(); // 下载图片
            }
        }

        // 播放视频按钮点击事件
        private void btnVideoPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = videoUrl;
            if (tabControl1.SelectedTab != tabPage2)
            {
                tabControl1.SelectTab(tabPage2);
            }
        }

        // 打开视频按钮点击事件
        private void btnVideoOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(videoFilePath);
        }

        // 打开图片按钮点击事件
        private void btnImageOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(imageFilePath);
        }

        // 视频下载进度条点击事件
        private void progressBar1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(videoFilePath.Replace(videoFileName, ""));
        }

        // 视频下载进度文字点击事件
        private void lblVideoPercentage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(videoFilePath.Replace(videoFileName, ""));
        }

        // 图片下载进度条点击事件
        private void progressBar2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(imageFilePath.Replace(imageFileName, ""));
        }

        // 图片下载进度文字点击事件
        private void lblImagePercentage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(imageFilePath.Replace(imageFileName, ""));
        }

        // 选中基本信息选项卡页面事件
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        // treeView 展开前事件
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // 只允许同时展开一个子结点，其他自动收缩
            foreach (TreeNode item in treeView1.Nodes)
            {
                if (item.IsExpanded)
                {
                    item.Collapse();
                }
            }
        }

        // 菜单栏关于软件单击事件
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        // 菜单栏使用帮助单击事件
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpBox().ShowDialog();
        }

        // 菜单栏退出单击事件
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            Application.Exit();
        }

        // 菜单栏隐藏到托盘单击事件
        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            Visible = false;
            notifyIcon1.ShowBalloonTip(2000, "最小化到托盘", "程序已经缩小到托盘，双击打开程序。", ToolTipIcon.Info);
        }

        // 通知栏图标双击恢复窗口事件
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Visible = true;
            WindowState = FormWindowState.Normal;
        }

        // 通知栏图标右键菜单退出事件
        private void hideExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Close();
            Dispose();
            Application.Exit();
        }
    }
}
