﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QRLibrary
{
    internal class Tables
    {
        static int[,] _maximumAmountofInformation = new int[4, 40]
        {
            {152, 272, 440, 640, 864, 1088, 1248, 1552, 1856, 2192, 2592, 2960, 3424, 3688, 4184, 4712, 5176, 5768, 6360, 6888, 7456, 8048, 8752, 9392, 10208, 10960, 11744, 12248, 13048, 13880, 14744, 15640, 16568, 17528, 18448, 19472, 20528, 21616, 22496, 23648},
            {128, 224, 352, 512, 688, 864, 992, 1232, 1456, 1728, 2032, 2320, 2672, 2920, 3320, 3624, 4056, 4504, 5016, 5352, 5712, 6256, 6880, 7312, 8000, 8496, 9024, 9544, 10136, 10984, 11640, 12328, 13048, 13800, 14496, 15312, 15936, 16816, 17728, 18672},
            {104, 176, 272, 384, 496, 608, 704, 880, 1056, 1232, 1440, 1648, 1952, 2088, 2360, 2600, 2936, 3176, 3560, 3880, 4096, 4544, 4912, 5312, 5744, 6032, 6464, 6968, 7288, 7880, 8264, 8920, 9368, 9848, 10288, 10832, 11408, 12016, 12656, 13328},
            {72, 128, 208, 288, 368, 480, 528, 688, 800, 976, 1120, 1264, 1440, 1576, 1784, 2024, 2264, 2504, 2728, 3080, 3248, 3536, 3712, 4112, 4304, 4768, 5024, 5288, 5608, 5960, 6344, 6760, 7208, 7688, 7888, 8432, 8768, 9136, 9776, 10208 }
        };

        internal static int[,] MaximumAmountofInformation { get =>_maximumAmountofInformation;}

        static int[,] _numberofInformationBlocks = new int[4, 40]
        {
            {1, 1, 1, 1, 1, 2, 2, 2, 2, 4, 4, 4, 4, 4, 6, 6, 6, 6, 7, 8, 8, 9, 9, 10, 12, 12, 12, 13, 14, 15, 16, 17, 18, 19, 19, 20, 21, 22, 24, 25},
            {1, 1, 1, 2, 2, 4, 4, 4, 5, 5, 5, 8, 9, 9, 10, 10, 11, 13, 14, 16, 17, 17, 18, 20, 21, 23, 25, 26, 28, 29, 31, 33, 35, 37, 38, 40, 43, 45, 47, 49},
            {1, 1, 2, 2, 4, 4, 6, 6, 8, 8, 8, 10, 12, 16, 12, 17, 16, 18, 21, 20, 23, 23, 25, 27, 29, 34, 34, 35, 38, 40, 43, 45, 48, 51, 53, 56, 59, 62, 65, 68},
            {1, 1, 2, 4, 4, 4, 5, 6, 8, 8, 11, 11, 16, 16, 18, 16, 19, 21, 25, 25, 25, 34, 30, 32, 35, 37, 40, 42, 45, 48, 51, 54, 57, 60, 63, 66, 70, 74, 77, 81}
        };

        internal static int[,] NumberofInformationBlocks { get => _numberofInformationBlocks; }

        static int[,] _numberofCorrectionBytesperBlock = new int[4, 40]
        {
            {7, 10, 15, 20, 26, 18, 20, 24, 30, 18, 20, 24, 26, 30, 22, 24, 28, 30, 28, 28, 28, 28, 30, 30, 26, 28, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30},
            {10, 16, 26, 18, 24, 16, 18, 22, 22, 26, 30, 22, 22, 24, 24, 28, 28, 26, 26, 26, 26, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28},
            {13, 22, 18, 26, 18, 24, 18, 22, 20, 24, 28, 26, 24, 20, 30, 24, 28, 28, 26, 30, 28, 30, 30, 30, 30, 28, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30},
            {17, 28, 22, 16, 22, 28, 26, 26, 24, 28, 24, 28, 22, 24, 24, 30, 28, 28, 26, 28, 30, 24, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30}
        };

        internal static int[,] NumberofCorrectionBytesperBlock { get => _numberofCorrectionBytesperBlock; }

        static Dictionary<int,int[]> _generatingpolynomials = new Dictionary<int, int[]>
        {
            {7, new int[] { 87, 229, 146, 149, 238, 102, 21} },
            {10, new int[] { 251, 67, 46, 61, 118, 70, 64, 94, 32, 45 } },
            {13, new int[] { 74, 152, 176, 100, 86, 100, 106, 104, 130, 218, 206, 140, 78 } },
            {15, new int[] { 8, 183, 61, 91, 202, 37, 51, 58, 58, 237, 140, 124, 5, 99, 105 } },
            {16, new int[] { 120, 104, 107, 109, 102, 161, 76, 3, 91, 191, 147, 169, 182, 194, 225, 120 } },
            {17, new int[] { 43, 139, 206, 78, 43, 239, 123, 206, 214, 147, 24, 99, 150, 39, 243, 163, 136 } },
            {18, new int[] { 215, 234, 158, 94, 184, 97, 118, 170, 79, 187, 152, 148, 252, 179, 5, 98, 96, 153 } },
            {20, new int[] { 17, 60, 79, 50, 61, 163, 26, 187, 202, 180, 221, 225, 83, 239, 156, 164, 212, 212, 188, 190 } },
            {22, new int[] { 210, 171, 247, 242, 93, 230, 14, 109, 221, 53, 200, 74, 8, 172, 98, 80, 219, 134, 160, 105, 165, 231 } },
            {24, new int[] { 229, 121, 135, 48, 211, 117, 251, 126, 159, 180, 169, 152, 192, 226, 228, 218, 111, 0, 117, 232, 87, 96, 227, 21 } },
            {26, new int[] { 173, 125, 158, 2, 103, 182, 118, 17, 145, 201, 111, 28, 165, 53, 161, 21, 245, 142, 13, 102, 48, 227, 153, 145, 218, 70 } },
            {28, new int[] { 168, 223, 200, 104, 224, 234, 108, 180, 110, 190, 195, 147, 205, 27, 232, 201, 21, 43, 245, 87, 42, 195, 212, 119, 242, 37, 9, 123 } },
            {30, new int[] { 41, 173, 145, 152, 216, 31, 179, 182, 50, 48, 110, 86, 239, 96, 222, 125, 42, 173, 226, 193, 224, 130, 156, 37, 251, 216, 238, 40, 192, 180 } },
        };

        internal static Dictionary<int, int[]> GeneratingPolynomials { get => _generatingpolynomials; }

        static Dictionary<int, int[]> _alignmentpatterns = new Dictionary<int, int[]>
        {
            {1, new int[] {14} },
            {2, new int[] {18} },
            {3, new int[] {22} },
            {4, new int[] {26} },
            {5, new int[] {30} },
            {6, new int[] {34} },
            {7, new int[] {6, 22, 38} },
            {8, new int[] {6, 24, 42} },
            {9, new int[] {6, 26, 46} },
            {10, new int[] {6, 28, 50} },
            {11, new int[] {6, 30, 54} },
            {12, new int[] {6, 32, 58} },
            {13, new int[] {6, 34, 62} },
            {14, new int[] {6, 26, 46, 66} },
            {15, new int[] {6, 26, 48, 70} },
            {16, new int[] {6, 26, 50, 74} },
            {17, new int[] {6, 30, 54, 78} },
            {18, new int[] {6, 30, 56, 82} },
            {19, new int[] {6, 30, 58, 86} },
            {20, new int[] { 6, 34, 62, 90 } },
            {21, new int[] { 6, 28, 50, 72, 94 } },
            {22, new int[] { 6, 26, 50, 74, 98 } },
            {23, new int[] { 6, 30, 54, 78, 102 } },
            {24, new int[] { 6, 28, 54, 80, 106 } },
            {25, new int[] { 6, 32, 58, 84, 110 } },
            {26, new int[] { 6, 30, 58, 86, 114 } },
            {27, new int[] { 6, 34, 62, 90, 118 } },
            {28, new int[] { 6, 26, 50, 74, 98, 122 } },
            {29, new int[] { 6, 30, 54, 78, 102, 126 } },
            {30, new int[] { 6, 26, 52, 78, 104, 130 } },
            {31, new int[] { 6, 30, 56, 82, 108, 134 } },
            {32, new int[] { 6, 34, 60, 86, 112, 138 } },
            {33, new int[] { 6, 30, 58, 86, 114, 142 } },
            {34, new int[] { 6, 34, 62, 90, 118, 146 } },
            {35, new int[] { 6, 30, 54, 78, 102, 126, 150 } },
            {36, new int[] { 6, 24, 50, 76, 102, 128, 154 } },
            {37, new int[] { 6, 28, 54, 80, 106, 132, 158 } },
            {38, new int[] { 6, 32, 58, 84, 110, 136, 162 } },
            {39, new int[] { 6, 26, 54, 82, 110, 138, 166 } },
            {40, new int[] { 6, 30, 58, 86, 114, 142, 170 } },
        };

        internal static Dictionary<int, int[]> AlignmentPatterns { get => _alignmentpatterns; }

        static Dictionary<int, string[]> _versioncodes = new Dictionary<int, string[]>
        {
            {7, new string[] { "000010", "011110", "100110" } },
            {8, new string[] { "010001", "011100", "111000" } },
            {9, new string[] { "110111", "011000", "000100" } },
            {10, new string[] { "101001", "111110", "000000" } },
            {11, new string[] { "001111", "111010", "111100" } },
            {12, new string[] { "001101", "100100", "011010" } },
            {13, new string[] { "101011", "100000", "100110" } },
            {14, new string[] { "110101", "000110", "100010" } },
            {15, new string[] { "010011", "000010", "011110" } },
            {16, new string[] { "011100", "010001", "011100" } },
            {17, new string[] { "111010", "010101", "100000" } },
            {18, new string[] { "100100", "110011", "100100" } },
            {19, new string[] { "000010", "110111", "011000" } },
            {20, new string[] { "000000", "101001", "111110" } },
            {21, new string[] { "100110", "101101", "000010" } },
            {22, new string[] { "111000", "001011", "000110" } },
            {23, new string[] { "011110", "001111", "111010" } },
            {24, new string[] { "001101", "001101", "100100" } },
            {25, new string[] { "101011", "001001", "011000" } },
            {26, new string[] { "110101", "101111", "011100" } },
            {27, new string[] { "010011", "101011", "100000" } },
            {28, new string[] { "010001", "110101", "000110" } },
            {29, new string[] { "110111", "110001", "111010" } },
            {30, new string[] { "101001", "010111", "111110" } },
            {31, new string[] { "001111", "010011", "000010" } },
            {32, new string[] { "101000", "011000", "101101" } },
            {33, new string[] { "001110", "011100", "010001" } },
            {34, new string[] { "010000", "111010", "010101" } },
            {35, new string[] { "110110", "111110", "101001" } },
            {36, new string[] { "110100", "100000", "001111" } },
            {37, new string[] { "010010", "100100", "110011" } },
            {38, new string[] { "001100", "000010", "110111" } },
            {39, new string[] { "101010", "000110", "001011" } },
            {40, new string[] { "111001", "000100", "010101" } },

        };

        internal static Dictionary<int, string[]> VersionCodes { get => _versioncodes; }

        static string[,] _maskcodes = new string[4, 8]
        {
            {"111011111000100", "111001011110011", "111110110101010", "111100010011101", "110011000101111", "110001100011000", "110110001000001", "110100101110110"},
            {"101010000010010", "101000100100101", "101111001111100", "101101101001011", "100010111111001", "100000011001110", "100111110010111", "100101010100000"},
            {"011010101011111", "011000001101000", "011111100110001", "011101000000110", "010010010110100", "010000110000011", "010111011011010", "010101111101101"},
            {"001011010001001", "001001110111110", "001110011100111", "001100111010000", "000011101100010", "000001001010101", "000110100001100", "000100000111011"}
        };

        internal static string[,] MaskCodes { get =>_maskcodes; }
    }
}
