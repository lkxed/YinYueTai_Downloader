namespace YinYueTai_Downloader
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("视频搜索（关键字）");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("基本分页（无跳转）");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("基本缓存（对象集合）");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("视频信息（歌手、封面、播放量···）");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("视频下载（单线程）");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("封面下载（单线程）");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("在线播放（内嵌WMP）");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("本地播放（类型默认播放器）");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("下载内容所在文件夹（无定位）");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("最小化到托盘（通知、恢复、退出）");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("已实现功能    ", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("内存缓存（DataSet）");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("历史记录（浏览、播放、下载）");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("视频处理（转码、分割）");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("多线程下载");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("待实现功能    ", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("图片缩放与清晰度不一致");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("网络请求错误（与网络环境有关）");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("已知问题   ", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37});
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalInfo = new System.Windows.Forms.Label();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.lboxVideoList = new System.Windows.Forms.ListBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.tboxKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImageOpen = new System.Windows.Forms.Label();
            this.btnVideoOpen = new System.Windows.Forms.Label();
            this.lblImagePercentage = new System.Windows.Forms.Label();
            this.lblVideoPercentage = new System.Windows.Forms.Label();
            this.cbboxResolution = new System.Windows.Forms.ComboBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.btnImageDownload = new System.Windows.Forms.Button();
            this.btnVideoDownload = new System.Windows.Forms.Button();
            this.pboxHeadImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeadImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label5.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label5.Location = new System.Drawing.Point(90, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(506, 64);
            label5.TabIndex = 0;
            label5.Text = "音 悦 台 视 频 下 载 器";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalInfo);
            this.panel1.Controls.Add(this.lblPageInfo);
            this.panel1.Controls.Add(this.lboxVideoList);
            this.panel1.Controls.Add(this.btnNextPage);
            this.panel1.Controls.Add(this.btnPrevPage);
            this.panel1.Controls.Add(this.tboxKeyword);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 562);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalInfo
            // 
            this.lblTotalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInfo.Location = new System.Drawing.Point(5, 35);
            this.lblTotalInfo.Name = "lblTotalInfo";
            this.lblTotalInfo.Size = new System.Drawing.Size(171, 28);
            this.lblTotalInfo.TabIndex = 6;
            this.lblTotalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageInfo.Location = new System.Drawing.Point(11, 503);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(159, 24);
            this.lblPageInfo.TabIndex = 5;
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxVideoList
            // 
            this.lboxVideoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxVideoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxVideoList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lboxVideoList.Font = new System.Drawing.Font("新宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxVideoList.FormattingEnabled = true;
            this.lboxVideoList.ItemHeight = 18;
            this.lboxVideoList.Location = new System.Drawing.Point(3, 63);
            this.lboxVideoList.Margin = new System.Windows.Forms.Padding(0);
            this.lboxVideoList.Name = "lboxVideoList";
            this.lboxVideoList.Size = new System.Drawing.Size(173, 440);
            this.lboxVideoList.TabIndex = 1;
            this.lboxVideoList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxGroupRange_DrawItem);
            this.lboxVideoList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListBoxGroupRange_MeasureItem);
            this.lboxVideoList.SelectedIndexChanged += new System.EventHandler(this.lboxVideoList_SelectedIndexChanged);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Enabled = false;
            this.btnNextPage.Location = new System.Drawing.Point(95, 530);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Enabled = false;
            this.btnPrevPage.Location = new System.Drawing.Point(13, 530);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 23);
            this.btnPrevPage.TabIndex = 3;
            this.btnPrevPage.Text = "上一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // tboxKeyword
            // 
            this.tboxKeyword.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxKeyword.Location = new System.Drawing.Point(5, 4);
            this.tboxKeyword.Name = "tboxKeyword";
            this.tboxKeyword.Size = new System.Drawing.Size(128, 26);
            this.tboxKeyword.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(137, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视频播放";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 6);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(776, 539);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnImageOpen);
            this.tabPage1.Controls.Add(this.btnVideoOpen);
            this.tabPage1.Controls.Add(this.lblImagePercentage);
            this.tabPage1.Controls.Add(this.lblVideoPercentage);
            this.tabPage1.Controls.Add(this.cbboxResolution);
            this.tabPage1.Controls.Add(this.progressBar2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btnVideoPlay);
            this.tabPage1.Controls.Add(this.btnImageDownload);
            this.tabPage1.Controls.Add(this.btnVideoDownload);
            this.tabPage1.Controls.Add(this.pboxHeadImage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(label5);
            this.panel2.Location = new System.Drawing.Point(59, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 527);
            this.panel2.TabIndex = 28;
            // 
            // treeView1
            // 
            this.treeView1.Indent = 33;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(90, 106);
            this.treeView1.Name = "treeView1";
            treeNode20.Name = "节点3";
            treeNode20.Text = "视频搜索（关键字）";
            treeNode21.Name = "节点11";
            treeNode21.Text = "基本分页（无跳转）";
            treeNode22.Name = "节点12";
            treeNode22.Text = "基本缓存（对象集合）";
            treeNode23.Name = "节点5";
            treeNode23.Text = "视频信息（歌手、封面、播放量···）";
            treeNode24.Name = "节点6";
            treeNode24.Text = "视频下载（单线程）";
            treeNode25.Name = "节点7";
            treeNode25.Text = "封面下载（单线程）";
            treeNode26.Name = "节点8";
            treeNode26.Text = "在线播放（内嵌WMP）";
            treeNode27.Name = "节点9";
            treeNode27.Text = "本地播放（类型默认播放器）";
            treeNode28.Name = "节点10";
            treeNode28.Text = "下载内容所在文件夹（无定位）";
            treeNode29.Name = "节点0";
            treeNode29.Text = "最小化到托盘（通知、恢复、退出）";
            treeNode30.Name = "节点0";
            treeNode30.NodeFont = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold);
            treeNode30.Text = "已实现功能    ";
            treeNode31.Name = "节点13";
            treeNode31.Text = "内存缓存（DataSet）";
            treeNode32.Name = "节点15";
            treeNode32.Text = "历史记录（浏览、播放、下载）";
            treeNode33.Name = "节点16";
            treeNode33.Text = "视频处理（转码、分割）";
            treeNode34.Name = "节点1";
            treeNode34.Text = "多线程下载";
            treeNode35.Name = "节点1";
            treeNode35.NodeFont = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold);
            treeNode35.Text = "待实现功能    ";
            treeNode36.Name = "节点17";
            treeNode36.Text = "图片缩放与清晰度不一致";
            treeNode37.Name = "节点18";
            treeNode37.Text = "网络请求错误（与网络环境有关）";
            treeNode38.Name = "节点2";
            treeNode38.NodeFont = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode38.Text = "已知问题   ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode35,
            treeNode38});
            this.treeView1.Size = new System.Drawing.Size(506, 404);
            this.treeView1.TabIndex = 1;
            this.treeView1.TabStop = false;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 27;
            this.label4.Visible = false;
            // 
            // btnImageOpen
            // 
            this.btnImageOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImageOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImageOpen.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImageOpen.Location = new System.Drawing.Point(689, 450);
            this.btnImageOpen.Name = "btnImageOpen";
            this.btnImageOpen.Size = new System.Drawing.Size(41, 20);
            this.btnImageOpen.TabIndex = 26;
            this.btnImageOpen.Text = "打开";
            this.btnImageOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImageOpen.Visible = false;
            this.btnImageOpen.Click += new System.EventHandler(this.btnImageOpen_Click);
            // 
            // btnVideoOpen
            // 
            this.btnVideoOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVideoOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVideoOpen.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVideoOpen.Location = new System.Drawing.Point(689, 419);
            this.btnVideoOpen.Name = "btnVideoOpen";
            this.btnVideoOpen.Size = new System.Drawing.Size(41, 20);
            this.btnVideoOpen.TabIndex = 25;
            this.btnVideoOpen.Text = "打开";
            this.btnVideoOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVideoOpen.Visible = false;
            this.btnVideoOpen.Click += new System.EventHandler(this.btnVideoOpen_Click);
            // 
            // lblImagePercentage
            // 
            this.lblImagePercentage.AutoSize = true;
            this.lblImagePercentage.Location = new System.Drawing.Point(602, 455);
            this.lblImagePercentage.Margin = new System.Windows.Forms.Padding(0);
            this.lblImagePercentage.Name = "lblImagePercentage";
            this.lblImagePercentage.Size = new System.Drawing.Size(0, 12);
            this.lblImagePercentage.TabIndex = 22;
            this.lblImagePercentage.Visible = false;
            this.lblImagePercentage.Click += new System.EventHandler(this.lblImagePercentage_Click);
            // 
            // lblVideoPercentage
            // 
            this.lblVideoPercentage.AutoSize = true;
            this.lblVideoPercentage.Location = new System.Drawing.Point(602, 423);
            this.lblVideoPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.lblVideoPercentage.Name = "lblVideoPercentage";
            this.lblVideoPercentage.Size = new System.Drawing.Size(0, 12);
            this.lblVideoPercentage.TabIndex = 21;
            this.lblVideoPercentage.Visible = false;
            this.lblVideoPercentage.Click += new System.EventHandler(this.lblVideoPercentage_Click);
            // 
            // cbboxResolution
            // 
            this.cbboxResolution.FormattingEnabled = true;
            this.cbboxResolution.Location = new System.Drawing.Point(423, 419);
            this.cbboxResolution.Name = "cbboxResolution";
            this.cbboxResolution.Size = new System.Drawing.Size(47, 20);
            this.cbboxResolution.TabIndex = 24;
            this.cbboxResolution.Visible = false;
            this.cbboxResolution.SelectedIndexChanged += new System.EventHandler(this.cbboxResolution_SelectedIndexChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(566, 450);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(117, 20);
            this.progressBar2.TabIndex = 20;
            this.progressBar2.Visible = false;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(566, 419);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 20);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(485, 481);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(75, 20);
            this.btnVideoPlay.TabIndex = 18;
            this.btnVideoPlay.Text = "在线播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Visible = false;
            this.btnVideoPlay.Click += new System.EventHandler(this.btnVideoPlay_Click);
            // 
            // btnImageDownload
            // 
            this.btnImageDownload.Location = new System.Drawing.Point(485, 450);
            this.btnImageDownload.Name = "btnImageDownload";
            this.btnImageDownload.Size = new System.Drawing.Size(75, 20);
            this.btnImageDownload.TabIndex = 17;
            this.btnImageDownload.Text = "下载封面";
            this.btnImageDownload.UseVisualStyleBackColor = true;
            this.btnImageDownload.Visible = false;
            this.btnImageDownload.Click += new System.EventHandler(this.btnImageDownload_Click);
            // 
            // btnVideoDownload
            // 
            this.btnVideoDownload.Location = new System.Drawing.Point(485, 419);
            this.btnVideoDownload.Name = "btnVideoDownload";
            this.btnVideoDownload.Size = new System.Drawing.Size(75, 20);
            this.btnVideoDownload.TabIndex = 16;
            this.btnVideoDownload.Text = "下载视频";
            this.btnVideoDownload.UseVisualStyleBackColor = true;
            this.btnVideoDownload.Visible = false;
            this.btnVideoDownload.Click += new System.EventHandler(this.btnVideoDownload_Click);
            // 
            // pboxHeadImage
            // 
            this.pboxHeadImage.Location = new System.Drawing.Point(59, 29);
            this.pboxHeadImage.Name = "pboxHeadImage";
            this.pboxHeadImage.Size = new System.Drawing.Size(671, 360);
            this.pboxHeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxHeadImage.TabIndex = 15;
            this.pboxHeadImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 14;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 13;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 12;
            this.label1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(200, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 562);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hideToolStripMenuItem.Text = "隐藏到托盘";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.helpToolStripMenuItem.Text = "使用帮助";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "关于软件";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "音悦台视频下载器";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // hideExitToolStripMenuItem
            // 
            this.hideExitToolStripMenuItem.Name = "hideExitToolStripMenuItem";
            this.hideExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hideExitToolStripMenuItem.Text = "退出";
            this.hideExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音悦台视频下载器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeadImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.ListBox lboxVideoList;
        private System.Windows.Forms.TabPage tabPage2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.Button btnImageDownload;
        private System.Windows.Forms.Button btnVideoDownload;
        private System.Windows.Forms.PictureBox pboxHeadImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblImagePercentage;
        private System.Windows.Forms.Label lblVideoPercentage;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox cbboxResolution;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Label lblTotalInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label btnVideoOpen;
        private System.Windows.Forms.Label btnImageOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hideExitToolStripMenuItem;
    }
}

