/*
Copyright © 2022-2021 Fabian Müller/ Paitorocxon

*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Reflection;
using Cosmos.System;
using Cosmos.System.ScanMaps;
using Cosmos.Core.IOGroup;
using Cosmos.HAL.Drivers;
using Cosmos.System.FileSystem.Listing;
using System.Linq;
using System.Dynamic;
using System.ComponentModel;
using System.Globalization;
using System.ComponentModel.Design;

namespace ASyncInput
{
    class Input
    {

        public Scanmaps.Scanmap_EN_US ReadKey()
        {
            ushort PORT = 96;
            var IOPB = new Cosmos.Core.IOPortRead(PORT).Byte;
            return (Scanmaps.Scanmap_EN_US) IOPB;
        }


    }

    


    class Scanmaps
    {
        public enum Scanmap_EN_US:byte
        {
            NONE = 0,
             ESC = 1,
             _1 = 2,
             _2 = 3,
             _3 = 4,
             _4 = 5,
             _5 = 6,
             _6 = 7,
             _7 = 8,
             _8 = 9,
             _9 = 10,
             _0 = 11,
             MINUS = 12,
             EQUAL = 13,
             BACKSPACE = 14,
             TAB = 15,
             Q = 16,
             W = 17,
             E = 18,
             R = 19,
             T = 20,
             Y = 21,
             U = 22,
             I = 23,
             O = 24,
             P = 25,
             OPENING_SQUARE_BRAKET = 26,
             CLOSING_SQUARE_BRAKET = 27,
             ENTER = 28,
             CTRL = 29,
             A = 30,
             S = 31,
             D = 32,
             F = 33,
             G = 34,
             H = 35,
             J = 36,
             K = 37,
             L = 38,
             SEMOCOLON = 39,
             APOSTROPHE = 40,
             BACK_QUOTE = 41,
             L_SHIFT = 42,
             BACKSLASH = 43,
             Z = 44,
             X = 45,
             C = 46,
             V = 47,
             B = 48,
             N = 49,
             M = 50,
             COMMA = 51,
             DOT = 52,
             SLASH = 53,
             R_SHIFT = 54,
             PRINT_SCREEN = 55,
             ALT = 56,
             SPACE = 57,
             CAPS = 58,
             F1 = 59,
             F2 = 60,
             F3 = 61,
             F4 = 62,
             F5 = 63,
             F6 = 64,
             F7 = 65,
             F8 = 66,
             F9 = 67,
             F10 = 68,
             NUM = 69,
             SCROLL = 70,
             HOME = 71,
             UP = 72,
             PAGE_UP = 73,
             NUMPAD_MINUS = 74,
             LEFT = 75,
             CENTER = 76,
             RIGHT = 77,
             NUMPAD_PLUS = 78,
             END = 79,
             DOWN = 80,
             PAGE_DOWN = 81,
             INSERT = 82,
             DELETE = 83,
             F11 = 87,
             F12 = 88
        }


        public const byte NONE= 0;
        public const byte ESC= 1;
        public const byte _1= 2;
        public const byte _2= 3;
        public const byte _3= 4;
        public const byte _4= 5;
        public const byte _5= 6;
        public const byte _6= 7;
        public const byte _7= 8;
        public const byte _8= 9;
        public const byte _9= 10;
        public const byte _0= 11;
        public const byte MINUS= 12;
        public const byte EQUAL= 13;
        public const byte BACKSPACE= 14;
        public const byte TAB= 15;
        public const byte Q= 16;
        public const byte W= 17;
        public const byte E= 18;
        public const byte R= 19;
        public const byte T= 20;
        public const byte Y= 21;
        public const byte U= 22;
        public const byte I= 23;
        public const byte O= 24;
        public const byte P= 25;
        public const byte OPENING_SQUARE_BRAKET= 26;
        public const byte CLOSING_SQUARE_BRAKET= 27;
        public const byte ENTER= 28;
        public const byte CTRL= 29;
        public const byte A= 30;
        public const byte S= 31;
        public const byte D= 32;
        public const byte F= 33;
        public const byte G= 34;
        public const byte H= 35;
        public const byte J= 36;
        public const byte K= 37;
        public const byte L= 38;
        public const byte SEMOCOLON= 39;
        public const byte APOSTROPHE= 40;
        public const byte BACK_QUOTE= 41;
        public const byte L_SHIFT= 42;
        public const byte BACKSLASH= 43;
        public const byte Z= 44;
        public const byte X= 45;
        public const byte C= 46;
        public const byte V= 47;
        public const byte B= 48;
        public const byte N= 49;
        public const byte M= 50;
        public const byte COMMA= 51;
        public const byte DOT= 52;
        public const byte SLASH= 53;
        public const byte R_SHIFT= 54;
        public const byte PRINT_SCREEN= 55;
        public const byte ALT= 56;
        public const byte SPACE= 57;
        public const byte CAPS= 58;
        public const byte F1= 59;
        public const byte F2= 60;
        public const byte F3= 61;
        public const byte F4= 62;
        public const byte F5= 63;
        public const byte F6= 64;
        public const byte F7= 65;
        public const byte F8= 66;
        public const byte F9= 67;
        public const byte F10 = 68;
        public const byte NUM= 69;
        public const byte SCROLL= 70;
        public const byte HOME= 71;
        public const byte UP= 72;
        public const byte PAGE_UP= 73;
        public const byte NUMPAD_MINUS= 74;
        public const byte LEFT= 75;
        public const byte CENTER= 76;
        public const byte RIGHT= 77;
        public const byte NUMPAD_PLUS= 78;
        public const byte END= 79;
        public const byte DOWN= 80;
        public const byte PAGE_DOWN= 81;
        public const byte INSERT= 82;
        public const byte DELETE = 83;
        public const byte F11 = 87;
        public const byte F12 = 88;
    }


}
