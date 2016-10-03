﻿using System;
using System.IO;

namespace Tibia.Utilities
{
    public static class Constants
    {
        public static string DefaultClientPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Tibia\\Tibia.exe");

        public const string RsaKeyOld = "124710459426827943004376449897985582167801707960697037164044904862948569380850421396904597686953877022394604239428185498284169068581802277612081027966724336319448537811441719076484340922854929273517308661370727105382899118999403808045846444647284499123164879035103627004668521005328367415259939915284902061793";
        public const string RsaKeyCurrent = "132127743205872284062295099082293384952776326496165507967876361843343953435544496682053323833394351797728954155097012103928360786959821132214473291575712138800495033169914814069637740318278150290733684032524174782740134357629699062987023311132821016569775488792221429527047321331896351555606801473202394175817";
        public const string RsaKeyOpenTibia = "109120132967399429278860960508995541528237502902798129123468757937266291492576446330739696001110603907230888610072655818825358503429057592827629436413108566029093628212635953836686562675849720620786279431090218017681061521755056710823876476444260558147179707119674283982419152118103759076030616683978566631413";

        public static byte[] LoginServerArrayPre8000 = new byte[5] { 0x57, 0x33, 0xC0, 0xB9, 0x70 };
        public static byte[] LoginServerArrayPre10110 = new byte[5] { 0x6B, 0xF6, 0x70, 0x8D, 0x96 };
        public static byte[] LoginServerArrayCurrent = new byte[12] { 0xB8, 0xAB, 0xAA, 0xAA, 0x2A, 0xF7, 0xEE, 0xBE, 0x55, 0x55, 0x55, 0x05 };
        public static byte LoginServerStartOffsetPre8000 = 0x09;
        public static byte LoginServerStartOffsetPre10110 = 0x05;
        public static byte LoginServerStartOffsetCurrent = 0x04;
    }
}