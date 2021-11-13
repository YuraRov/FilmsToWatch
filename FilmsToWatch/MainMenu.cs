﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace FilmsToWatch
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            using (var stream = File.Open("D:\\Maun_folder\\CourseWork\\Films.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            int a = Convert.ToInt32(reader.GetDouble(0));
                            string b = reader.GetString(1);
                            string c = reader.GetString(2);
                            string d = reader.GetString(3);
                            string e = reader.GetString(4);
                            int f = Convert.ToInt32(reader.GetDouble(5));
                            string g = reader.GetString(6);
                            DateTime h = reader.GetDateTime(7);
                            string i = reader.GetString(8);
                            ulong j = Convert.ToUInt64(reader.GetDouble(9));
                        }
                    } while (reader.NextResult());
                }
            }
        }

        private void ShowProgram()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    Hide();
                    WindowState = FormWindowState.Minimized;
                    break;
                case FormWindowState.Minimized:
                    ShowProgram();
                    break;
                default:
                    ShowProgram();
                    break;
            }
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            trayIcon.Dispose();
            Application.ExitThread();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowProgram();
        }
    }
}
