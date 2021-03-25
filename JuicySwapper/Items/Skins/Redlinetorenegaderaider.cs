﻿using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;
using System.Globalization;

namespace JuicySwapper.Items.Skins
{
    public partial class Redlinetorenegaderaider : Form
    {
        bool enabled = Settings.Default.RrenegadeEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Renegade Raider";

        public Redlinetorenegaderaider()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ActiveControl = ActionButton;
            Text = placeholder;

            if (enabled)
                ActionButton.Image = Resources.RevertBtn;
            else
                ActionButton.Image = Resources.ConvertBtn;
        }

        string Body = "8C 0A 00 05 1A 88 05 18 00 00 00 00 00 00 00 00 00 03 99 20 00 80 14 0A 40 00 00 00 98 06 D8 06 70 01 48 08 08 00 09 28 09 04 40 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 53 74 72 65 65 74 52 61 63 65 72 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 55 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 72 5F 30 31 46 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 2E 5F 43 00 87 53 6B 69 6E 73 42 6C 61 63 6B 2F 4D 61 74 65 72 69 61 6C 45 44 5F 5F 00 A0 2E 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 1E 43 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 00 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 F3 D2 67 A6 31 53 28 E5 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 F2 FF A9 CB 15 A0 3E 86 10 A5 9A FB 41 59 2C 63 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B AA A3 DD 43 39 4F 9F 6F 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 14 0A 12 00 15 01 01 FF FF FF FF FF FF FF FF 26 4B 14 CB 2C B4 C2 C3 F2 CE A0 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 04 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 B2 C8 95 96 92 92 9A 91 92 92 41 00 30 87 87 87 87 87 37 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 87 87 42 79 7A F8 F8 F8 F8 D0 79 90 F9 F8 F8 F8 F8 D0 48 87 82 01 79 F8 90 7C F8 F8 F8 90 3D 48 60 87 2F 7C 90 82 01 79 C8 87 8E 8C 44 91 25 87 87 24 87 87 8C 23 87 87 4E 87 8A 87 87 4D 49 24 32 7A F8 CF 20 20 28 79 20 32 20 40 87 29 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 20 32 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 5D 23 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 5A 00 30 00 42 00 18 00 11 00 46 00 60 00 F3 00 12 01 18 00 57 00 68 00 1F 01 67 00 21 00 8A 00 2C 00 B9 02 B7 02 42 00 23 00 89 00 19 00 15 00 C6 00 70 01 F3 03 22 00 26 00 39 01 51 00 71 00 58 04 2C 00 44 00 B9 00 1D 00 19 00 15 00 0C 00 50 01 35 00 5B 00 26 00 64 00 51 01 1A 00 23 01 15 00 1A 02 1D 00 13 00 23 02 60 00 32 01 15 00 60 00 6A 00 40 00 A5 01 7E 01";
        string Body1 = "8C 06 00 04 D5 88 04 D3 00 00 00 00 00 00 00 00 00 03 8C 20 00 80 14 0A 40 00 00 00 98 06 D8 06 70 01 48 08 08 00 09 28 09 04 40 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 42 6F 64 79 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 53 74 72 65 65 74 52 61 63 65 72 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 55 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 72 5F 30 31 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 5F 43 00 87 53 6B 69 6E 73 2F 54 56 5F 32 30 2F 4D 61 74 65 72 69 61 6C 45 44 54 56 32 30 00 A0 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 1E 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 3A 3A 00 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 46 6C 61 67 49 6E 64 65 78 00 11 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 F3 D2 67 A6 31 53 28 E5 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 F2 FF A9 CB 15 A0 3E 86 10 A5 9A FB 41 59 2C 63 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B AA A3 DD 43 39 4F 9F 6F 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 14 0A 12 15 01 01 FF FF FF FF FF FF FF FF 00 26 4B 14 FF CB 2C B4 C2 C3 F2 CE A0 0B 00 04 00 00 03 06 06 08 02 04 04 81 02 01 02 04 03 01 02 02 01 01 00 02 80 05 01 08 00 00 00 01 00 00 00 00 00 00 00 00 00 7C 5C 03 03 02 02 06 01 02 02 D9 D3 83 D3 C9 FF E1 38 3D D0 DB F8 FE FD 3D DC FF FC F8 FF CF E2 CC D7 C9 38 FD FD DB 01 CB CB CB 43 DE DF DD CB D2 F5 38 1F C8 C8 CC F5 C8 D2 C8 D8 CF EB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 EC DC E8 D8 CA D2 E0 DF D3 D2 FA C7 38 3B D3 DC D9 D8 EB F7 E7 CB D3 15 05 85 15 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 E5 DC 1E 94 E7 D4 F5 1B 00 00 56 08 0A 00 09 0E 08 0B 1A 00 0F 00 17 0F 07 00 02 1F 10 1E 24 00 01 0A 0D 0E 10 15 0A 0E 20 09 09 20 04 0C 01 05 01 0D 04 1C 0D 03 0E 0C 19 08 1B 0D 21 05 0B 2E 08 1A 08 0D 07 0B 1D 16 27 2E 16 0F 13 05 09 09 0A 05 08 14 2A 00 0F 00 00 08 08 08 00 04 32 02 08 00 00 2F 02 03 40 0C 16 08 33 16 0D 44 00 44 06 54 00 01 2D 11 01 5B 23 13 02 0F 13 0D 1A 01 04 05 07 05 00 01 04 01 04 06 08 03 02 00 FF 05 06 0E 01 21 3E 16 58 67 02 6C 22 8A 98 83 95 4C 06 01 02 1D B0 62 3F 20 03 89 B4 00 80 50 0A C6 05 17 36 14 E9 A4 E0 0B 24 04 62 C5 A2 78 80 00 C7 0E 04 0A 46";

        string Head = "8C 02 04 A6 F2 04 00 91 40 08 00 7F 17 00 20 00 80 5A 08 00 00 40 00 00 00 EC 04 00 00 30 05 00 00 60 01 00 00 90 06 00 00 B8 06 00 00 48 07 00 00 70 07 30 00 1F 11 37 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 48 61 74 73 2F 4D 61 74 65 72 69 61 6C 0F 00 FF 06 5F 46 5F 53 74 72 65 65 74 52 61 63 65 72 42 6C 61 63 6B 00 4E 24 39 00 F1 2E 04 50 00 F1 2F 05 50 00 FF 0A 65 73 68 2F 46 65 6D 61 6C 65 5F 4F 75 74 6C 61 6E 64 65 72 5F 30 36 00 43 1C 31 00 F1 2E 01 45 00 21 42 76 00 6A 43 68 61 72 61 63 74 65 72 73 0B 00 34 50 61 72 74 84 00 23 43 50 5F B6 00 88 43 6F 6D 6D 61 6E 64 6F D6 00 D2 00 71 44 00 36 50 6C 61 79 65 72 B6 00 0F 11 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 46 5F 4D 45 44 5F 48 49 53 5F 52 61 6D 69 72 65 7A 5F 18 00 33 5F 30 31 E9 00 F0 05 1F 00 FF 00 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 9A 5E 73 00 F1 2E 13 27 00 4F 0A 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 15 00 08 46 6F 72 74 6E 69 74 65 C0 00 0F 03 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 72 00 0F 14 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 74 61 63 68 53 6F 63 6B 65 74 4E 3C 00 55 0C 42 79 74 65 20 00 91 11 B7 01 26 54 79 70 65 00 05 49 00 F1 1D 0B BD 01 57 16 43 75 73 74 6F 6D 3F 00 13 48 61 74 8B 00 B1 13 18 00 00 57 00 22 00 1E 15 00 00 0C 00 40 E7 02 18 4F 76 65 72 72 69 64 65 35 00 2A 1F 44 65 66 61 75 6C 74 5F 5F 29 00 D0 56 00 F1 1C 05 21 00 00 53 00 23 00 0E 45 16 00 22 48 61 C2 00 A1 15 10 00 0A 5F 48 65 6C 6D 65 74 00 11 45 45 01 20 2B 00 02 47 65 CA 02 D2 00 17 13 00 78 3A 3A 42 6F 74 68 00 13 19 00 00 64 00 10 58 00 F1 18 00 15 00 27 3A 3A 48 61 74 00 0F 3D 00 4F 01 50 65 72 6D 69 74 74 65 64 00 03 68 61 74 00 07 91 00 54 0B 49 6E 74 93 01 C1 15 03 01 E5 46 6C 61 67 73 17 00 C7 49 6E 64 65 78 00 11 17 00 03 73 00 0C C8 01 50 4F 00 27 04 4E 6F 6E 65 00 0E 30 02 50 16 00 41 10 2F 00 40 3F 00 0F 04 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C C6 02 B6 00 12 53 6F 66 74 3D 00 75 0E 53 74 72 75 10 00 10 2B 05 02 64 C1 32 05 0F C1 71 CD 10 6B DD C4 E7 95 07 1C 6E C6 50 D6 57 D1 CA F0 36 5E 8A DB CA FF 64 F3 0B 99 1F 7E 3B E6 B2 E6 67 4D 08 CA 4F 53 4F 69 8A 98 4B 98 87 3C 16 18 10 50 6E 45 CA 77 97 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 3F 22 4A 27 0D 1C AC 20 E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 4E 08 CE B4 90 F6 5E 1A 79 E7 D0 07 5F 28 61 BD D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 79 F1 D0 49 02 33 24 9A AD B2 19 90 1E 32 09 A2 50 A4 A4 0C EB 52 E3 58 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 A4 06 F0 81 F2 1D 00 91 F5 11 00 00 00 01 9C 00 12 00 40 48 00 F1 FF 99 40 48 00 40 10 00 F1 00 99 31 77 48 00 31 39 10 00 31 10 08 00 40 28 00 40 88 00 40 38 00 40 88 00 FA 92 8D 45 0F 5A 69 32 87 0B 00 B1 71 04 80 00 F0 C1 F1 01 BC F0 89 44 04 04 03 02 B9 00 F2 06 00 D9 F6 02 01 02 08 02 04 82 03 03 03 02 33 00 71 03 22 00 00 10 00 83 80 05 01 66 00 09 01 00 00 00 00 00 00 00";
        string Head1 = "8C 02 04 A6 F2 04 00 91 40 08 00 7F 17 00 20 00 80 5A 08 00 00 40 00 00 00 EC 04 00 00 30 05 00 00 60 01 00 00 90 06 00 00 B8 06 00 00 48 07 00 00 70 07 30 00 FF 2B 37 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 48 61 74 73 2F 4D 61 74 65 72 69 61 6C 73 2F 46 65 6D 61 6C 65 5F 43 6F 6D 6D 61 6E 64 6F 5F 30 37 5F 56 30 31 00 4E 24 39 00 F1 2E 04 50 00 F1 2F 05 50 00 E3 65 73 68 4B 00 F4 38 00 00 43 1B 31 00 F1 2E 01 44 00 22 00 42 76 00 6A 43 68 61 72 61 63 74 65 72 73 0B 00 34 50 61 72 74 84 00 68 43 50 5F 48 61 74 5F 46 3D 00 DD 53 74 72 65 65 74 52 61 63 65 72 00 71 44 00 36 50 6C 61 79 65 72 B6 00 0F 0F 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 46 5F 4D 45 44 5F 41 53 4E 5F 53 61 72 61 68 5F 16 00 13 5F 30 31 E7 00 F1 65 06 1F 00 FF 02 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 00 00 9A 5C 73 00 F1 2E 11 25 00 4F 0E 5F 43 00 00 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 15 00 08 46 6F 72 74 6E 69 74 65 C0 00 0F 03 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 74 00 0F 14 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 74 61 63 68 53 6F 63 6B 65 74 4E 3C 00 55 0C 42 79 74 65 20 00 51 11 0B 01 00 B7 01 26 54 79 70 65 00 05 49 00 F1 1D 0B BD 01 57 16 43 75 73 74 6F 6D 3F 00 13 48 61 74 8B 00 B1 13 18 00 00 57 00 22 00 1E 15 00 00 0C 00 40 E7 02 18 4F 76 65 72 72 69 64 65 35 00 2A 1F 44 65 66 61 75 6C 74 5F 5F 29 00 D0 56 00 F1 1C 05 21 00 00 53 00 23 00 0E 45 60 00 22 48 61 C2 00 A1 15 10 00 0A 5F 48 65 6C 6D 65 74 00 11 45 45 01 20 8B 00 D8 47 65 6E 64 65 72 00 17 13 00 78 3A 3A 42 6F 74 68 00 13 19 00 00 B7 00 10 58 00 F1 18 00 15 00 27 3A 3A 48 61 74 00 0F 3D 00 4F 01 50 65 72 6D 69 74 74 65 64 00 03 68 61 74 00 07 91 00 54 0B 49 6E 74 93 01 C1 15 03 01 E5 46 6C 61 67 73 17 00 C7 49 6E 64 65 78 00 11 17 00 03 73 00 0C C8 01 50 4F 00 27 04 4E 6F 6E 65 00 0E 30 02 50 16 00 41 10 2F 00 40 3F 00 0F 04 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C C8 02 B6 00 12 53 6F 66 74 3D 00 75 0E 53 74 72 75 10 00 10 2B 05 02 64 C1 32 05 0F C1 71 CD 10 6B DD C4 E7 95 07 1C 6E C6 50 D6 57 D1 CA F0 36 5E 8A DB CA FF 64 F3 0B 99 1F 7E 3B E6 B2 E6 67 4D 08 CA 4F 53 4F 69 8A 98 4B 98 87 3C 16 18 10 50 6E 45 CA 77 97 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 3F 22 4A 27 0D 1C AC 20 E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 4E 08 CE B4 90 F6 5E 1A 79 E7 D0 07 5F 28 61 BD D4 6B D6 C3 94 98 52 6B 60 C2 C8 7C CC 8E B3 43 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 79 F1 D0 49 02 33 24 9A AD B2 19 90 1E 32 09 A2 50 A4 A4 0C EB 52 E3 58 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 A4 06 F0 81 F2 1D 00 91 F5 11 00 00 00 01 9C 00 12 00 40 48 00 F1 FF 99 40 48 00 40 10 00 F1 00 99 31 77 48 00 31 39 10 00 31 10 08 00 40 28 00 40 88 00 40 38 00 40 88 00 FA 92 8D 45 0F 5A 69 32 87 0B 00 B1 71 04 80 00 F0 C1 F1 01 BC F0 89 44 04 04 03 02 B9 00 F2 06 00 D9 F6 02 01 02 08 02 04 82 03 03 03 02 33 00 71 03 22 00 00 10 00 83 80 05 01 66 00 09 01 00 00 00 00 00 00 00";

        string Hat = "8C 0A 00 05 CD 88 05 CB 04 00 00 00 00 00 00 00 00 03 FD 00 20 00 80 1C 0C 40 00 00 00 68 08 A8 08 B0 01 58 0A 80 0A 10 0B 38 0B 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 47 53 6B 69 6E 2F 46 5F 4D 65 64 5F 48 49 53 53 74 72 65 65 74 52 61 63 65 72 42 6C 61 63 6B 00 62 2E 49 50 61 72 74 73 2F 46 65 6D 61 6C 2F 4D 65 64 75 6D 2F 48 65 61 73 2F 43 50 5F 5F 46 00 8D 50 6C 61 79 65 72 42 6F 64 69 65 73 53 6F 6C 64 69 65 5F 43 6F 6D 6D 61 6E 64 6F 2F 4D 61 74 65 72 69 61 6C 45 44 30 31 00 AC 2E 46 60 2F 5F 50 6F 6E 79 74 61 69 6C 00 7D 2E 64 52 61 6D 69 72 65 7A 65 73 68 00 7E 2E 71 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 9A 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 68 54 61 72 67 65 74 73 00 05 15 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 63 61 70 48 61 74 00 0B 0F 48 61 69 74 12 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 0F 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 88 B6 F8 35 CC 14 56 69 9E A2 C0 A8 EF 44 CA D8 B0 D0 85 FF 6F 8A 25 8E 12 F1 21 E4 DE AA CC 9D 00 C2 8A 9D F8 DF D7 9A ED B7 D0 9E 88 4E A4 B7 DF 37 5E 8A 52 AA 37 A2 3C EC 73 B8 D0 6E 95 B0 59 FF E3 D7 12 D7 9E 8C 69 8A 98 4B 98 87 3C 16 18 10 50 6E 45 CA 77 97 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 2E 2D D1 32 8F 63 D4 00 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 17 DF E4 09 17 45 18 8F 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 1C 0C 58 00 18 06 01 FF FF FF FF FF FF FF FF 74 49 16 F6 7B 9A 9D 1C 6F 0E A9 0B 00 00 04 00 01 01 02 08 01 05 03 22 02 24 17 23 09 02 04 02 04 02 04 03 02 02 01 0A 00 05 06 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 03 00 00 00 00 00 00 00 00 00 D7 C0 96 96 92 92 92 92 92 5A 87 87 53 87 89 87 36 7D F8 F8 E0 69 F9 F8 D0 87 8F 87 87 7C F8 F8 F8 D8 79 E0 F9 D8 87 8C 8C 8E 25 62 7A 90 7E 3E 26 28 40 87 7A 90 87 2A 7A 90 30 84 01 7A F8 F9 F8 60 38 40 79 50 20 87 84 01 79 F0 F1 F0 F0 38 28 57 7B D8 82 01 79 D8 81 01 87 87 81 01 79 F8 C0 87 87 8E 44 91 25 87 87 24 87 87 8C 87 87 87 4E 8F 87 33 79 B8 87 87 4F 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 29 3B AD 38 64 20 69 29 70 4C 7A 7D 98 FF 57 2F 50 41 40 87 92 87 21 22 60 7D 5D 23 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 B3 99 59 59 99 59 7D 60 B9 99 B9 59 B9 30 60 87 9C C1 38 22 D9 6E 00 30 00 0B 00 17 00 3B 00 48 00 49 00 64 00 09 00 50 00 4B 00 43 00 AF 00 37 01 C5 00 6F 00 B1 00 42 00 21 00 9A 00 8F 00 AE 00 80 01 AD 00 3B 00 83 00 AD 00 96 02 62 00 7F 00 67 00 B1 02 8B 00 1F 00 66 00 80 00 80 00 73 00 27 00 15 00 C0 00 4B 00 22 00 49 00 B9 04 50 01 31 00 92 00 19 00 20 05 15 00 0C 00 26 03 35 00 57 00 22 00 60 00 26 01 1A 00 F8 00 15 00 E9 01 1D 00 13 00 1E 02 10 00 4A 01 B7 03 0A 00 20 01 80 06 11 00 6E 01 2A 00 14 00 A0 01 2B 01 17 00 EF 01 5F 02 65 00 2F 00 3F 00 F5 02 EB 05 D1 00 4E 00 10 00 6F 08 47 0A 08 00 10 00 48 00 10 00 87 0A 48 00 08 00 28 00 88 00 10 00";
        string Hat1 = "8C 06 00 05 AC 88 05 AA 04 00 00 00 00 00 00 00 00 04 09 00 20 00 80 1C 0C 40 00 00 00 68 08 A8 08 B0 01 58 0A 80 0A 10 0B 38 0B 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 47 53 6B 69 6E 2F 46 5F 4D 65 64 5F 41 53 4E 5F 53 61 72 61 68 62 2E 49 50 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 53 74 72 65 65 74 52 61 63 65 72 00 8D 50 6C 61 79 42 6F 64 69 65 73 53 6F 6C 64 69 65 5F 43 6F 6D 6D 61 6E 64 6F 42 6C 61 63 6B 2F 4D 61 74 65 72 31 61 6C 45 44 30 31 00 AC 2E 60 69 5F 50 6F 6E 79 74 61 69 6C 00 7D 45 44 32 2E 00 64 65 73 68 65 73 2F 31 00 00 00 7E 2E 00 00 71 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 00 00 9A 5F 43 13 2F 53 63 72 69 70 74 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 70 68 54 61 72 67 65 74 73 00 05 15 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 63 61 70 48 61 74 00 0B 0F 00 0F 48 61 74 12 0B 49 6E 74 15 46 6C 61 67 73 49 6E 64 65 78 00 11 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 4D 65 73 68 00 0F 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 88 B6 F8 35 CC 14 56 69 9E A2 C0 A8 EF 44 CA D8 B0 D0 85 FF 6F 8A 25 8E 12 F1 21 E4 DE AA CC 9D 00 C2 8A 9D F8 DF D7 9A ED B7 D0 9E 88 4E A4 B7 DF 37 5E 8A 52 AA 37 A2 3C EC 73 B8 D0 6E 95 B0 59 FF E3 D7 12 D7 9E 8C 69 8A 98 4B 98 87 3C 16 18 10 50 6E 45 CA 77 97 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 2E 2D D1 32 8F 63 D4 00 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 17 DF E4 09 17 45 18 8F 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 1C 0C 58 00 18 06 01 FF FF FF FF FF FF FF FF 00 74 49 16 FF F6 7B 9A 9D 1C 6F 0E A9 0B 00 04 00 00 01 02 08 01 05 03 00 22 02 24 17 23 0C 00 04 09 02 04 02 04 02 04 03 02 02 0A 00 05 01 80 05 01 08 00 00 00 00 00 03 00 00 00 00 00 00 00 00 00 A5 58 03 03 02 02 02 02 02 02 DC E3 D3 FF ED 3D DB C8 FD E5 38 A4 E1 38 41 CB FF 83 F4 D7 CB CC D8 EB CF FE D0 FF F5 38 3D D0 D0 D4 D0 21 9C C8 FF 62 DC 38 F8 D6 38 FE D3 38 FF E1 38 FF FF D8 38 EC CE 03 DB 01 CB CB DF D3 D1 38 DF C8 CC F5 C8 D2 C8 D8 CF DB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 D2 E0 CD D7 13 D0 DD D0 EF D1 EC DF F9 C3 38 3B E3 D3 DC D9 D8 03 CB E8 F7 E7 CB D3 D2 05 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 D5 E5 17 15 E8 15 05 15 95 C8 15 55 D9 CB 15 D8 D7 50 40 53 00 00 6C 08 03 0F 03 00 00 00 01 01 0C 01 03 0B 00 1F 16 07 09 0A 09 02 07 06 18 14 01 1A 1E 0A 04 0A 00 07 0C 0E 06 08 0B 08 00 28 0D 08 07 0A 01 21 2F 09 0A 01 28 0D 04 20 0D 0F 0A 08 1E 04 00 0D 28 05 0B 21 0B 12 2E 02 18 25 34 16 12 0C 18 13 0F 17 17 0E 07 07 22 09 06 08 19 30 00 08 00 0F 00 00 08 08 08 0C 04 04 08 00 00 04 1E 00 00 3E 03 03 0E 13 02 28 17 11 2B 17 0D 00 01 03 03 06 0B 00 01 7C 15 08 1E 34 03 02 51 00 51 0E 5E 05 09 02 0F 2B 0F 12 05 07 05 00 00 02 02 01 02 04 03 04 06 0B 02 02 00 FF 05 06 02 08 00 01 20 40 50 31 31 CD 0C 0A 2E AF EA D8 B6 42 04 22 98 0C C4 0F 8C 02 70 1E 02 10 18 20 00 42 20 40 90 88 03 20 E8 74 4B 85 44 08 41 0A 28 3F 84 40 88 32 11 A4 5D 85 61 3F 18 05 9E 8A 78 40";


        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Redline"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.RrenegadeEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(SwapOffsets[1], SwapPath[0], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            bool Swap3 = HexResearcher.Convert(SwapOffsets[1], SwapPath[0], Hat, Hat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat added";

            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\nConverted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.RrenegadeEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(SwapOffsets[1], SwapPath[0], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            bool Swap3 = HexResearcher.Revert(SwapOffsets[1], SwapPath[0], Hat, Hat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat removed";

            ActionButton.Image = Resources.ConvertBtn;
            LogBox.Text += "\nReverted!";
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();

            if (!File.Exists(SwapPath[0]))
            {
                Message FortnitePathExp = new Message(Resources.pakfileerror);
                FortnitePathExp.ShowDialog();
                return;
            }
            if (enabled)
                RevertBytes.RunWorkerAsync();
            else
                ConvertBytes.RunWorkerAsync();
        }

        private void ConvertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConvertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void RevertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RevertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }
    }
}