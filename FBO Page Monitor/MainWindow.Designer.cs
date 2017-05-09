namespace FBO_Page_Monitor
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.minimizeButton = new System.Windows.Forms.Button();
      this.updatesButton = new System.Windows.Forms.Button();
      this.startMonitoringButton = new System.Windows.Forms.Button();
      this.urlLabel = new System.Windows.Forms.Label();
      this.rfpNameLabel = new System.Windows.Forms.Label();
      this.knownUpdatesLabel = new System.Windows.Forms.Label();
      this.rfpName = new System.Windows.Forms.Label();
      this.urlInput = new System.Windows.Forms.TextBox();
      this.knownUpdatesInput = new System.Windows.Forms.NumericUpDown();
      this.output = new System.Windows.Forms.TextBox();
      this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.knownUpdatesInput)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.Controls.Add(this.minimizeButton, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.updatesButton, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.startMonitoringButton, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.urlLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.rfpNameLabel, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.knownUpdatesLabel, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.rfpName, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.urlInput, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.knownUpdatesInput, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.output, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 261);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // minimizeButton
      // 
      this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.minimizeButton.Location = new System.Drawing.Point(3, 235);
      this.minimizeButton.Name = "minimizeButton";
      this.minimizeButton.Size = new System.Drawing.Size(75, 23);
      this.minimizeButton.TabIndex = 0;
      this.minimizeButton.Text = "Minimize";
      this.minimizeButton.UseVisualStyleBackColor = true;
      // 
      // updatesButton
      // 
      this.updatesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.updatesButton.AutoSize = true;
      this.updatesButton.Location = new System.Drawing.Point(671, 235);
      this.updatesButton.Name = "updatesButton";
      this.updatesButton.Size = new System.Drawing.Size(77, 23);
      this.updatesButton.TabIndex = 1;
      this.updatesButton.Text = "Get Updates";
      this.updatesButton.UseVisualStyleBackColor = true;
      this.updatesButton.Click += new System.EventHandler(this.updatesButton_Click);
      // 
      // startMonitoringButton
      // 
      this.startMonitoringButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.startMonitoringButton.AutoSize = true;
      this.startMonitoringButton.Enabled = false;
      this.startMonitoringButton.Location = new System.Drawing.Point(790, 235);
      this.startMonitoringButton.Name = "startMonitoringButton";
      this.startMonitoringButton.Size = new System.Drawing.Size(91, 23);
      this.startMonitoringButton.TabIndex = 2;
      this.startMonitoringButton.Text = "Start Monitoring";
      this.startMonitoringButton.UseVisualStyleBackColor = true;
      this.startMonitoringButton.Click += new System.EventHandler(this.startMonitoringButton_Click);
      // 
      // urlLabel
      // 
      this.urlLabel.AutoSize = true;
      this.urlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.urlLabel.Location = new System.Drawing.Point(3, 0);
      this.urlLabel.Name = "urlLabel";
      this.urlLabel.Size = new System.Drawing.Size(215, 26);
      this.urlLabel.TabIndex = 3;
      this.urlLabel.Text = "FBO URL:";
      this.urlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // rfpNameLabel
      // 
      this.rfpNameLabel.AutoSize = true;
      this.rfpNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rfpNameLabel.Location = new System.Drawing.Point(3, 26);
      this.rfpNameLabel.Name = "rfpNameLabel";
      this.rfpNameLabel.Size = new System.Drawing.Size(215, 26);
      this.rfpNameLabel.TabIndex = 4;
      this.rfpNameLabel.Text = "RFP Name:";
      this.rfpNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // knownUpdatesLabel
      // 
      this.knownUpdatesLabel.AutoSize = true;
      this.knownUpdatesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.knownUpdatesLabel.Location = new System.Drawing.Point(3, 52);
      this.knownUpdatesLabel.Name = "knownUpdatesLabel";
      this.knownUpdatesLabel.Size = new System.Drawing.Size(215, 26);
      this.knownUpdatesLabel.TabIndex = 5;
      this.knownUpdatesLabel.Text = "Known Updates:";
      this.knownUpdatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // rfpName
      // 
      this.rfpName.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.rfpName, 2);
      this.rfpName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rfpName.Location = new System.Drawing.Point(224, 26);
      this.rfpName.Name = "rfpName";
      this.rfpName.Size = new System.Drawing.Size(657, 26);
      this.rfpName.TabIndex = 6;
      this.rfpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // urlInput
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.urlInput, 2);
      this.urlInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.urlInput.Location = new System.Drawing.Point(224, 3);
      this.urlInput.Name = "urlInput";
      this.urlInput.Size = new System.Drawing.Size(657, 20);
      this.urlInput.TabIndex = 7;
      this.urlInput.TextChanged += new System.EventHandler(this.urlInput_TextChanged);
      // 
      // knownUpdatesInput
      // 
      this.knownUpdatesInput.Location = new System.Drawing.Point(224, 55);
      this.knownUpdatesInput.Name = "knownUpdatesInput";
      this.knownUpdatesInput.Size = new System.Drawing.Size(120, 20);
      this.knownUpdatesInput.TabIndex = 8;
      this.knownUpdatesInput.ValueChanged += new System.EventHandler(this.knownUpdatesInput_ValueChanged);
      // 
      // output
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.output, 3);
      this.output.Dock = System.Windows.Forms.DockStyle.Fill;
      this.output.Location = new System.Drawing.Point(3, 81);
      this.output.Multiline = true;
      this.output.Name = "output";
      this.output.ReadOnly = true;
      this.output.Size = new System.Drawing.Size(878, 124);
      this.output.TabIndex = 9;
      // 
      // notificationIcon
      // 
      this.notificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
      this.notificationIcon.Visible = true;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 261);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainWindow";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FBO Page Monitor";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.knownUpdatesInput)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button minimizeButton;
    private System.Windows.Forms.Button updatesButton;
    private System.Windows.Forms.Button startMonitoringButton;
    private System.Windows.Forms.Label urlLabel;
    private System.Windows.Forms.Label rfpNameLabel;
    private System.Windows.Forms.Label knownUpdatesLabel;
    private System.Windows.Forms.Label rfpName;
    private System.Windows.Forms.TextBox urlInput;
    private System.Windows.Forms.NumericUpDown knownUpdatesInput;
    private System.Windows.Forms.TextBox output;
    private System.Windows.Forms.NotifyIcon notificationIcon;
  }
}

