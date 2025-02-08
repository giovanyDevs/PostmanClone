namespace PostmanClone.UI.FormUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            HttpRequestPanel = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            RequestHeader = new Label();
            BodyRequestTextBox = new TextBox();
            HttpHeadersRequestTextBox = new TextBox();
            StartLineRequestTextBox = new TextBox();
            HttpResponsePanel = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ResponseHeader = new Label();
            BodyResponseTextBox = new TextBox();
            HttpHeadersResponseTextBox = new TextBox();
            StartLineResponseTextBox = new TextBox();
            MainPanel = new Panel();
            StatusSystemToolStrip = new ToolStrip();
            SystemStatusToolStripLabel = new ToolStripLabel();
            StatusSystemPanel = new Panel();
            SystemControlPanel = new Panel();
            SystemControlMenuStrip = new MenuStrip();
            RequestControlPanel = new Panel();
            HTTPVerbsCombo = new ComboBox();
            label1 = new Label();
            StartRequestButton = new Button();
            UrlRequestTextBox = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            HttpRequestPanel.SuspendLayout();
            HttpResponsePanel.SuspendLayout();
            MainPanel.SuspendLayout();
            StatusSystemToolStrip.SuspendLayout();
            StatusSystemPanel.SuspendLayout();
            SystemControlPanel.SuspendLayout();
            RequestControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // HttpRequestPanel
            // 
            HttpRequestPanel.BackColor = Color.WhiteSmoke;
            HttpRequestPanel.BorderStyle = BorderStyle.FixedSingle;
            HttpRequestPanel.Controls.Add(label5);
            HttpRequestPanel.Controls.Add(label4);
            HttpRequestPanel.Controls.Add(label3);
            HttpRequestPanel.Controls.Add(RequestHeader);
            HttpRequestPanel.Controls.Add(BodyRequestTextBox);
            HttpRequestPanel.Controls.Add(HttpHeadersRequestTextBox);
            HttpRequestPanel.Controls.Add(StartLineRequestTextBox);
            HttpRequestPanel.Dock = DockStyle.Left;
            HttpRequestPanel.Location = new Point(0, 0);
            HttpRequestPanel.Name = "HttpRequestPanel";
            HttpRequestPanel.Size = new Size(725, 769);
            HttpRequestPanel.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(20, 395);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 5;
            label5.Text = "Body:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(20, 194);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "HTTP headers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "StartLine:";
            // 
            // RequestHeader
            // 
            RequestHeader.AutoSize = true;
            RequestHeader.Location = new Point(20, 94);
            RequestHeader.Name = "RequestHeader";
            RequestHeader.Size = new Size(99, 32);
            RequestHeader.TabIndex = 0;
            RequestHeader.Text = "Request";
            // 
            // BodyRequestTextBox
            // 
            BodyRequestTextBox.Font = new Font("Segoe UI", 9F);
            BodyRequestTextBox.Location = new Point(20, 413);
            BodyRequestTextBox.Multiline = true;
            BodyRequestTextBox.Name = "BodyRequestTextBox";
            BodyRequestTextBox.ScrollBars = ScrollBars.Both;
            BodyRequestTextBox.Size = new Size(673, 308);
            BodyRequestTextBox.TabIndex = 6;
            // 
            // HttpHeadersRequestTextBox
            // 
            HttpHeadersRequestTextBox.Font = new Font("Segoe UI", 9F);
            HttpHeadersRequestTextBox.Location = new Point(20, 212);
            HttpHeadersRequestTextBox.Multiline = true;
            HttpHeadersRequestTextBox.Name = "HttpHeadersRequestTextBox";
            HttpHeadersRequestTextBox.ScrollBars = ScrollBars.Both;
            HttpHeadersRequestTextBox.Size = new Size(673, 172);
            HttpHeadersRequestTextBox.TabIndex = 4;
            // 
            // StartLineRequestTextBox
            // 
            StartLineRequestTextBox.Font = new Font("Segoe UI", 9F);
            StartLineRequestTextBox.Location = new Point(20, 158);
            StartLineRequestTextBox.Name = "StartLineRequestTextBox";
            StartLineRequestTextBox.Size = new Size(673, 23);
            StartLineRequestTextBox.TabIndex = 2;
            // 
            // HttpResponsePanel
            // 
            HttpResponsePanel.BackColor = Color.WhiteSmoke;
            HttpResponsePanel.BorderStyle = BorderStyle.FixedSingle;
            HttpResponsePanel.Controls.Add(label8);
            HttpResponsePanel.Controls.Add(label7);
            HttpResponsePanel.Controls.Add(label6);
            HttpResponsePanel.Controls.Add(ResponseHeader);
            HttpResponsePanel.Controls.Add(BodyResponseTextBox);
            HttpResponsePanel.Controls.Add(HttpHeadersResponseTextBox);
            HttpResponsePanel.Controls.Add(StartLineResponseTextBox);
            HttpResponsePanel.Dock = DockStyle.Right;
            HttpResponsePanel.Location = new Point(700, 0);
            HttpResponsePanel.Name = "HttpResponsePanel";
            HttpResponsePanel.Size = new Size(753, 769);
            HttpResponsePanel.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(59, 140);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 1;
            label8.Text = "StartLine:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(59, 194);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 3;
            label7.Text = "HTTP headers:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(59, 395);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Body:";
            // 
            // ResponseHeader
            // 
            ResponseHeader.AutoSize = true;
            ResponseHeader.Location = new Point(59, 94);
            ResponseHeader.Name = "ResponseHeader";
            ResponseHeader.Size = new Size(115, 32);
            ResponseHeader.TabIndex = 0;
            ResponseHeader.Text = "Response";
            // 
            // BodyResponseTextBox
            // 
            BodyResponseTextBox.BackColor = SystemColors.Window;
            BodyResponseTextBox.Font = new Font("Segoe UI", 9F);
            BodyResponseTextBox.Location = new Point(59, 413);
            BodyResponseTextBox.Multiline = true;
            BodyResponseTextBox.Name = "BodyResponseTextBox";
            BodyResponseTextBox.ReadOnly = true;
            BodyResponseTextBox.ScrollBars = ScrollBars.Both;
            BodyResponseTextBox.Size = new Size(673, 308);
            BodyResponseTextBox.TabIndex = 6;
            // 
            // HttpHeadersResponseTextBox
            // 
            HttpHeadersResponseTextBox.BackColor = SystemColors.Window;
            HttpHeadersResponseTextBox.Font = new Font("Segoe UI", 9F);
            HttpHeadersResponseTextBox.Location = new Point(59, 212);
            HttpHeadersResponseTextBox.Multiline = true;
            HttpHeadersResponseTextBox.Name = "HttpHeadersResponseTextBox";
            HttpHeadersResponseTextBox.ReadOnly = true;
            HttpHeadersResponseTextBox.ScrollBars = ScrollBars.Both;
            HttpHeadersResponseTextBox.Size = new Size(673, 172);
            HttpHeadersResponseTextBox.TabIndex = 4;
            // 
            // StartLineResponseTextBox
            // 
            StartLineResponseTextBox.BackColor = SystemColors.Window;
            StartLineResponseTextBox.Font = new Font("Segoe UI", 9F);
            StartLineResponseTextBox.Location = new Point(59, 158);
            StartLineResponseTextBox.Name = "StartLineResponseTextBox";
            StartLineResponseTextBox.ReadOnly = true;
            StartLineResponseTextBox.Size = new Size(673, 23);
            StartLineResponseTextBox.TabIndex = 2;
            // 
            // MainPanel
            // 
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(HttpRequestPanel);
            MainPanel.Controls.Add(HttpResponsePanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1455, 771);
            MainPanel.TabIndex = 0;
            // 
            // StatusSystemToolStrip
            // 
            StatusSystemToolStrip.BackColor = Color.DarkGray;
            StatusSystemToolStrip.Dock = DockStyle.Fill;
            StatusSystemToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            StatusSystemToolStrip.Items.AddRange(new ToolStripItem[] { SystemStatusToolStripLabel });
            StatusSystemToolStrip.Location = new Point(0, 0);
            StatusSystemToolStrip.Name = "StatusSystemToolStrip";
            StatusSystemToolStrip.Size = new Size(1453, 28);
            StatusSystemToolStrip.TabIndex = 0;
            StatusSystemToolStrip.Text = "toolStrip1";
            // 
            // SystemStatusToolStripLabel
            // 
            SystemStatusToolStripLabel.BackColor = Color.White;
            SystemStatusToolStripLabel.Font = new Font("Segoe UI", 12F);
            SystemStatusToolStripLabel.ForeColor = SystemColors.ControlLightLight;
            SystemStatusToolStripLabel.Name = "SystemStatusToolStripLabel";
            SystemStatusToolStripLabel.Size = new Size(102, 25);
            SystemStatusToolStripLabel.Text = "Status: Ready";
            // 
            // StatusSystemPanel
            // 
            StatusSystemPanel.BorderStyle = BorderStyle.FixedSingle;
            StatusSystemPanel.Controls.Add(StatusSystemToolStrip);
            StatusSystemPanel.Dock = DockStyle.Bottom;
            StatusSystemPanel.Location = new Point(0, 741);
            StatusSystemPanel.Name = "StatusSystemPanel";
            StatusSystemPanel.Size = new Size(1455, 30);
            StatusSystemPanel.TabIndex = 1;
            // 
            // SystemControlPanel
            // 
            SystemControlPanel.BorderStyle = BorderStyle.FixedSingle;
            SystemControlPanel.Controls.Add(SystemControlMenuStrip);
            SystemControlPanel.Dock = DockStyle.Top;
            SystemControlPanel.Location = new Point(0, 0);
            SystemControlPanel.Name = "SystemControlPanel";
            SystemControlPanel.Size = new Size(1455, 31);
            SystemControlPanel.TabIndex = 1;
            // 
            // SystemControlMenuStrip
            // 
            SystemControlMenuStrip.BackColor = Color.DarkGray;
            SystemControlMenuStrip.Dock = DockStyle.Fill;
            SystemControlMenuStrip.Location = new Point(0, 0);
            SystemControlMenuStrip.Name = "SystemControlMenuStrip";
            SystemControlMenuStrip.Size = new Size(1453, 29);
            SystemControlMenuStrip.TabIndex = 0;
            SystemControlMenuStrip.Text = "menuStrip1";
            // 
            // RequestControlPanel
            // 
            RequestControlPanel.BackColor = Color.DarkGray;
            RequestControlPanel.BorderStyle = BorderStyle.FixedSingle;
            RequestControlPanel.Controls.Add(HTTPVerbsCombo);
            RequestControlPanel.Controls.Add(label1);
            RequestControlPanel.Controls.Add(StartRequestButton);
            RequestControlPanel.Controls.Add(UrlRequestTextBox);
            RequestControlPanel.Dock = DockStyle.Top;
            RequestControlPanel.Location = new Point(0, 31);
            RequestControlPanel.Name = "RequestControlPanel";
            RequestControlPanel.Size = new Size(1455, 38);
            RequestControlPanel.TabIndex = 0;
            // 
            // HTTPVerbsCombo
            // 
            HTTPVerbsCombo.BackColor = Color.WhiteSmoke;
            HTTPVerbsCombo.Font = new Font("Segoe UI", 9F);
            HTTPVerbsCombo.FormattingEnabled = true;
            HTTPVerbsCombo.Items.AddRange(new object[] { "GET", "POST" });
            HTTPVerbsCombo.Location = new Point(1036, 5);
            HTTPVerbsCombo.Name = "HTTPVerbsCombo";
            HTTPVerbsCombo.Size = new Size(111, 23);
            HTTPVerbsCombo.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "API URL:";
            // 
            // StartRequestButton
            // 
            StartRequestButton.Font = new Font("Segoe UI", 9F);
            StartRequestButton.Location = new Point(939, 5);
            StartRequestButton.Name = "StartRequestButton";
            StartRequestButton.Size = new Size(91, 23);
            StartRequestButton.TabIndex = 2;
            StartRequestButton.Text = "Start Request";
            StartRequestButton.UseVisualStyleBackColor = true;
            StartRequestButton.Click += StartRequestButton_Click;
            // 
            // UrlRequestTextBox
            // 
            UrlRequestTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            UrlRequestTextBox.Font = new Font("Segoe UI", 9F);
            UrlRequestTextBox.Location = new Point(73, 5);
            UrlRequestTextBox.Name = "UrlRequestTextBox";
            UrlRequestTextBox.Size = new Size(845, 23);
            UrlRequestTextBox.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1455, 771);
            Controls.Add(RequestControlPanel);
            Controls.Add(SystemControlPanel);
            Controls.Add(StatusSystemPanel);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = SystemControlMenuStrip;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Clone Postman 1.0";
            Load += Dashboard_Load;
            HttpRequestPanel.ResumeLayout(false);
            HttpRequestPanel.PerformLayout();
            HttpResponsePanel.ResumeLayout(false);
            HttpResponsePanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            StatusSystemToolStrip.ResumeLayout(false);
            StatusSystemToolStrip.PerformLayout();
            StatusSystemPanel.ResumeLayout(false);
            StatusSystemPanel.PerformLayout();
            SystemControlPanel.ResumeLayout(false);
            SystemControlPanel.PerformLayout();
            RequestControlPanel.ResumeLayout(false);
            RequestControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HttpRequestPanel;
        private Panel HttpResponsePanel;
        private Panel MainPanel;
        private ToolStrip StatusSystemToolStrip;
        private Panel StatusSystemPanel;
        private Label RequestHeader;
        private Label ResponseHeader;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel SystemControlPanel;
        private Label label8;
        private Label label7;
        private Label label6;
        private MenuStrip SystemControlMenuStrip;
        private Panel RequestControlPanel;
        private Button StartRequestButton;
        private Label label1;
        private ToolStripLabel SystemStatusToolStripLabel;
        private ErrorProvider ErrorProvider;
        private ComboBox HTTPVerbsCombo;
        internal TextBox StartLineRequestTextBox;
        internal TextBox HttpHeadersRequestTextBox;
        internal TextBox BodyRequestTextBox;
        internal TextBox BodyResponseTextBox;
        internal TextBox HttpHeadersResponseTextBox;
        internal TextBox StartLineResponseTextBox;
        internal TextBox UrlRequestTextBox;
    }
}
