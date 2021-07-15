using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using Ionic.Zip;
using AndroidAppUninstaller.Class;
using System.Linq;

namespace AndroidAppUninstaller.Forms
{
    public partial class uxMain : Form
    {
        private List<string> arrayApks = new List<string>();

        public uxMain()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(WinAPI.CreateRoundRectRgn(0,0, Width, Height, 25, 25));
        }

        private void uxMain_Load(object sender, EventArgs e)
        {

        }

        private void showStatusMessage(string message)
        {
            uxListBoxStatus.Items.Add(message);
        }

        public void executeCMD(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private void uxButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uxButtonClose_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("adb"))
                {
                    if (process != null)
                        process.Kill();
                }
            }
            catch { }
            Environment.Exit(0);
        }

        private void uxTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uxCheckedListBoxApp.Items.Clear();
                foreach (string str in arrayApks)
                {
                    if (str.ToLower().Contains(uxTextBoxSearch.Text.ToLower()))
                        uxCheckedListBoxApp.Items.Add(str);
                }
            } 
            catch { }
        }

        private void uxComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDeviceStatus();
        }

        private void checkDeviceStatus()
        {
            try
            {
                arrayApks.Clear();
                uxCheckedListBoxApp.Items.Clear();

                showStatusMessage("Checking device.");
                executeCMD("adb shell getprop ro.build.version.release > check.tmp");
                string androidV;
                string filename = "check.tmp";
                bool phone = false;
                if (File.Exists(filename))
                {
                    androidV = File.ReadAllText(filename);
                    if (androidV.Any(char.IsDigit))
                        phone = true;

                    if (phone)
                    {
                        showStatusMessage("Connected to smartphone!");
                        File.Delete(filename);
                        var arrayApksUni = new List<int>();
                        if (uxComboBox.Text == "User App")
                        {
                            executeCMD("adb shell pm list packages -3 > APKNS.tmp");
                            filename = "APKNS.tmp";
                        }
                        else if (uxComboBox.Text == "System App")
                        {
                            executeCMD("adb shell pm list packages -s > APKS.tmp");
                            filename = "APKS.tmp";
                        }

                        if (File.Exists(filename))
                        {
                            foreach (string line in File.ReadLines(filename))
                            {
                                if (line.Contains("package:"))
                                {
                                    arrayApks.Add(line.Substring(8));
                                }
                            }
                            File.Delete(filename);
                            foreach (string str in arrayApks)
                            {
                                uxCheckedListBoxApp.Items.Add(str);
                                uxCheckedListBoxApp.CheckOnClick = true;
                            }
                        }
                        else
                        {
                            File.Delete(filename);
                            showStatusMessage("Unable to get APK List!");
                        }
                    }
                    else
                    {
                        File.Delete(filename);
                        showStatusMessage("Connect the smarthphone!");
                    }

                }
            } 
            catch
            {
                MessageBox.Show("Unable to check device status! try again!");
                return;
            }
        }

        private void checkFiles(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                foreach (var process in Process.GetProcessesByName("adb"))
                {
                    if (process != null)
                        process.Kill();
                }

                if (!File.Exists("adb.exe") && !File.Exists("AdbWinUsbApi.dll") && !File.Exists("AdbWinApi.dll"))
                {
                    if (MessageBox.Show("You need to download SDK!\nPress OK to download.\nWait until status is ready.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Application.DoEvents();
                        showStatusMessage("Downloading SDK...");
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://dl.google.com/android/repository/platform-tools-latest-windows.zip?authuser=2", "sdkplatformtool.zip");
                            showStatusMessage("SDK tool downloaded");
                            showStatusMessage("Unzipping SDK!");
                            using (ZipFile zip = ZipFile.Read("sdkplatformtool.zip"))
                            {
                                zip.ExtractAll(Path.GetDirectoryName(Application.ExecutablePath));
                                Application.DoEvents();
                            }

                            Application.DoEvents();
                            showStatusMessage("SDK downloaded!");
                            showStatusMessage("Getting things ready...");
                            executeCMD("move platform-tools\\adb.exe \"%cd%\"");
                            executeCMD("move platform-tools\\AdbWinUsbApi.dll \"%cd%\"");
                            executeCMD("move platform-tools\\AdbWinApi.dll \"%cd%\"");
                            File.Delete("sdkplatformtool.zip");
                            executeCMD("rmdir /Q /S platform-tools");
                            showStatusMessage("Everything is ready!");
                            Thread.Sleep(1500);
                            checkDeviceStatus();
                            Application.DoEvents();

                            foreach (var process in Process.GetProcessesByName("adb"))
                            {
                                if (process != null)
                                    process.Kill();
                            }
                        }
                    }
                }

                uxComboBox.Text = "User App";
                uxComboBox_SelectedIndexChanged(sender, e);
            } 
            catch
            {
                MessageBox.Show("Unable to donwload SDK. Exting!!!");
                Environment.Exit(0);
            }
        }

        private void uxMain_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            checkFiles(sender, e);
        }

        private void uxButtonUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxCheckedListBoxApp.CheckedItems.Count > 0)
                {
                    string param = "";
                    if (uxComboBox.Text == "User App")
                    {
                        param = "adb uninstall ";
                    }
                    else if (uxComboBox.Text == "System App")
                    {
                        param = "adb shell pm uninstall -k --user 0 ";
                    }

                    foreach (Object list in uxCheckedListBoxApp.CheckedItems)
                    {
                        showStatusMessage("Uninstalling " + list);
                        executeCMD(param + list);
                        showStatusMessage(list + " uninstalled!");
                    }
                    checkDeviceStatus();
                }
                else
                {
                    showStatusMessage("Select an APP from list!");
                    return;
                }
            } 
            catch
            {
                showStatusMessage("Unlable to uninstall!");
                return;
            }
        }

        private void uxCheckBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (uxComboBox.Text == "System App")
            {
                showStatusMessage("Yu cannot select all System Apps!");
                for (int i = 0; i < uxCheckedListBoxApp.Items.Count; i++)
                    uxCheckedListBoxApp.SetItemCheckState(i, CheckState.Unchecked);

                return;
            }

            if (uxCheckBoxSelectAll.Checked)
            {
                for (int i = 0; i < uxCheckedListBoxApp.Items.Count; i++)
                    uxCheckedListBoxApp.SetItemCheckState(i, CheckState.Checked);

                return;
            }
            else
            {
                for (int i = 0; i < uxCheckedListBoxApp.Items.Count; i++)
                    uxCheckedListBoxApp.SetItemCheckState(i, CheckState.Unchecked);

                return;
            }
        }

        private void uxButtonAbout_Click(object sender, EventArgs e)
        {
            uxAboutBox box = null;
            if (box == null)
            {
                box = new uxAboutBox();
                box.ShowDialog();
            }
        }
    }
}
