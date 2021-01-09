﻿using JuicySwapper.IO;
using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI.Items.Skins
{
    public partial class RenegadeRaider : Form
    {
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Renegade Raider (Checkered)";
        public RenegadeRaider()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Text = placeholder;
            label1.Text = placeholder;

            if (Settings.Default.RenegadeRaiderEnabled == true)
                convertButton.Text = "Revert";
            else
                convertButton.Text = "Convert";
        }

        string Body = "Skins/TV_19/MaterialED_Cmmando_TV19";
        string Body1 = "Skins/TV_21/MaterialED_Cmmando_TV21";
        string GenderOffset = "/HID_013ommando_F";
        string Invalid = "Specializs/HSU";
        string Invalid1 = "Specializs/HFF";

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();

            if (!File.Exists(SwapPath[0]))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RichTextBoxInfo.Clear();
            RichTextBoxInfo.Text += "[LOG] Starting...";

            if (convertButton.Text == "Convert")
            {
                if (SwapUtilities.CheckIfCanSwap("AssaultTrooper"))
                    return;

                bool Swap1 = Researcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.RenegadeRaiderEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                }

                Researcher.GetOffset(0, SwapPath[0], GenderOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap2 = Researcher.Convert(Offset_current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
                convertButton.Text = "Revert";
            }
            else
            {
                bool Swap1 = Researcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
                if (Swap1)
                {
                    Settings.Default.RenegadeRaiderEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 removed";
                }

                Researcher.GetOffset(0, SwapPath[0], GenderOffset);

                long Offset_current = Settings.Default.current_offset;
                bool Swap2 = Researcher.Revert(Offset_current, SwapPath[0], Invalid, Invalid1, 0, 0, false, false);
                if (Swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");
                convertButton.Text = "Convert";
            }
        }
    }
}
