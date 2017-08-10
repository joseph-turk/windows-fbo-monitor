using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace FBO_Page_Monitor
{
  public partial class MainWindow : Form
  {
    private string urlString;
    private string rfpNameString;
    HtmlNodeCollection listOfUpdates;
    private int countOfUpdates;
    private int knownUpdatesNumber;
    private string updateMessage;
    private Timer updateCheckTimer;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void urlInput_TextChanged(object sender, EventArgs e)
    {
      urlString = urlInput.Text;
    }

    private void knownUpdatesInput_ValueChanged(object sender, EventArgs e)
    {
      knownUpdatesNumber = Convert.ToInt32(knownUpdatesInput.Value);
    }

    private void updatesButton_Click(object sender, EventArgs e)
    {
      HtmlWeb web = new HtmlWeb();
      HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(urlString);

      // Get RFP Name
      rfpNameString = htmlDoc.DocumentNode.SelectSingleNode("//h2").InnerText;
      rfpName.Text = rfpNameString;

      // Get List of Updates
      listOfUpdates = htmlDoc.DocumentNode.SelectNodes("//ul[contains(@id, 'sb_related_notices')]/li");
      countOfUpdates = listOfUpdates.Count;

      // Set Known Updates Input Value
      knownUpdatesInput.Value = countOfUpdates;
      knownUpdatesNumber = Convert.ToInt32(knownUpdatesInput.Value);

      // Enable Monitoring Button
      startMonitoringButton.Enabled = true;

      // Change Text of Updates Button
      updatesButton.Text = "Acknowledge All Updates";
    }

    private void startMonitoringButton_Click(object sender, EventArgs e)
    {
      checkForUpdates();
    }

    public void checkForUpdates()
    {
      var checkTime = DateTime.Now;

      if (countOfUpdates > knownUpdatesNumber)
      {
        updateMessage += listOfUpdates.Last().InnerText;

        output.Text = "There have been updates since you last checked.\r\n\r\nLatest Update:\r\n" + updateMessage;
        showNotification(updateMessage);
      }
      else
      {
        updateMessage = "Last Check for FBO Updates:\r\n";
        updateMessage += checkTime.ToShortDateString() + " (" + checkTime.ToShortTimeString() + ")\r\n\r\n";
        updateMessage += "There were no updates since you last checked.";

                //output.Text = updateMessage;
                output.Text = Application.ProductVersion;
      }

      InitTimer();
    }

    public void InitTimer()
    {
      updateCheckTimer = new Timer();
      updateCheckTimer.Tick += new EventHandler(updateCheckTimer_Tick);
      updateCheckTimer.Interval = 900000;
      updateCheckTimer.Start();
    }

    private void updateCheckTimer_Tick(object sender, EventArgs e)
    {
      checkForUpdates();
    }

    public void showNotification(string message)
    {
      notificationIcon.BalloonTipTitle = rfpNameString + " Updated!";
      notificationIcon.BalloonTipText = message;
      notificationIcon.ShowBalloonTip(30000);
    }

    private void minimizeButton_Click(object sender, EventArgs e)
    {
      Hide();
      notificationIcon.Visible = true;
    }

    private void notificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      Show();
    }
  }
}
