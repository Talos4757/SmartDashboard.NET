// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.avcodec
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv.cpp
{
  public class avcodec : Object
  {
    public const int LIBAVCODEC_VERSION_MAJOR = 52;
    public const int LIBAVCODEC_VERSION_MINOR = 72;
    public const int LIBAVCODEC_VERSION_MICRO = 2;
    internal static int __\u003C\u003ELIBAVCODEC_VERSION_INT;
    internal static string __\u003C\u003ELIBAVCODEC_VERSION;
    internal static int __\u003C\u003ELIBAVCODEC_BUILD;
    internal static string __\u003C\u003ELIBAVCODEC_IDENT;
    public const long AV_NOPTS_VALUE = -9223372036854775808L;
    public const int AV_TIME_BASE = 1000000;
    internal static object __\u003C\u003EAV_TIME_BASE_Q;
    public const int CODEC_ID_NONE = 0;
    public const int CODEC_ID_MPEG1VIDEO = 1;
    public const int CODEC_ID_MPEG2VIDEO = 2;
    public const int CODEC_ID_MPEG2VIDEO_XVMC = 3;
    public const int CODEC_ID_H261 = 4;
    public const int CODEC_ID_H263 = 5;
    public const int CODEC_ID_RV10 = 6;
    public const int CODEC_ID_RV20 = 7;
    public const int CODEC_ID_MJPEG = 8;
    public const int CODEC_ID_MJPEGB = 9;
    public const int CODEC_ID_LJPEG = 10;
    public const int CODEC_ID_SP5X = 11;
    public const int CODEC_ID_JPEGLS = 12;
    public const int CODEC_ID_MPEG4 = 13;
    public const int CODEC_ID_RAWVIDEO = 14;
    public const int CODEC_ID_MSMPEG4V1 = 15;
    public const int CODEC_ID_MSMPEG4V2 = 16;
    public const int CODEC_ID_MSMPEG4V3 = 17;
    public const int CODEC_ID_WMV1 = 18;
    public const int CODEC_ID_WMV2 = 19;
    public const int CODEC_ID_H263P = 20;
    public const int CODEC_ID_H263I = 21;
    public const int CODEC_ID_FLV1 = 22;
    public const int CODEC_ID_SVQ1 = 23;
    public const int CODEC_ID_SVQ3 = 24;
    public const int CODEC_ID_DVVIDEO = 25;
    public const int CODEC_ID_HUFFYUV = 26;
    public const int CODEC_ID_CYUV = 27;
    public const int CODEC_ID_H264 = 28;
    public const int CODEC_ID_INDEO3 = 29;
    public const int CODEC_ID_VP3 = 30;
    public const int CODEC_ID_THEORA = 31;
    public const int CODEC_ID_ASV1 = 32;
    public const int CODEC_ID_ASV2 = 33;
    public const int CODEC_ID_FFV1 = 34;
    public const int CODEC_ID_4XM = 35;
    public const int CODEC_ID_VCR1 = 36;
    public const int CODEC_ID_CLJR = 37;
    public const int CODEC_ID_MDEC = 38;
    public const int CODEC_ID_ROQ = 39;
    public const int CODEC_ID_INTERPLAY_VIDEO = 40;
    public const int CODEC_ID_XAN_WC3 = 41;
    public const int CODEC_ID_XAN_WC4 = 42;
    public const int CODEC_ID_RPZA = 43;
    public const int CODEC_ID_CINEPAK = 44;
    public const int CODEC_ID_WS_VQA = 45;
    public const int CODEC_ID_MSRLE = 46;
    public const int CODEC_ID_MSVIDEO1 = 47;
    public const int CODEC_ID_IDCIN = 48;
    public const int CODEC_ID_8BPS = 49;
    public const int CODEC_ID_SMC = 50;
    public const int CODEC_ID_FLIC = 51;
    public const int CODEC_ID_TRUEMOTION1 = 52;
    public const int CODEC_ID_VMDVIDEO = 53;
    public const int CODEC_ID_MSZH = 54;
    public const int CODEC_ID_ZLIB = 55;
    public const int CODEC_ID_QTRLE = 56;
    public const int CODEC_ID_SNOW = 57;
    public const int CODEC_ID_TSCC = 58;
    public const int CODEC_ID_ULTI = 59;
    public const int CODEC_ID_QDRAW = 60;
    public const int CODEC_ID_VIXL = 61;
    public const int CODEC_ID_QPEG = 62;
    public const int CODEC_ID_XVID = 63;
    public const int CODEC_ID_PNG = 64;
    public const int CODEC_ID_PPM = 65;
    public const int CODEC_ID_PBM = 66;
    public const int CODEC_ID_PGM = 67;
    public const int CODEC_ID_PGMYUV = 68;
    public const int CODEC_ID_PAM = 69;
    public const int CODEC_ID_FFVHUFF = 70;
    public const int CODEC_ID_RV30 = 71;
    public const int CODEC_ID_RV40 = 72;
    public const int CODEC_ID_VC1 = 73;
    public const int CODEC_ID_WMV3 = 74;
    public const int CODEC_ID_LOCO = 75;
    public const int CODEC_ID_WNV1 = 76;
    public const int CODEC_ID_AASC = 77;
    public const int CODEC_ID_INDEO2 = 78;
    public const int CODEC_ID_FRAPS = 79;
    public const int CODEC_ID_TRUEMOTION2 = 80;
    public const int CODEC_ID_BMP = 81;
    public const int CODEC_ID_CSCD = 82;
    public const int CODEC_ID_MMVIDEO = 83;
    public const int CODEC_ID_ZMBV = 84;
    public const int CODEC_ID_AVS = 85;
    public const int CODEC_ID_SMACKVIDEO = 86;
    public const int CODEC_ID_NUV = 87;
    public const int CODEC_ID_KMVC = 88;
    public const int CODEC_ID_FLASHSV = 89;
    public const int CODEC_ID_CAVS = 90;
    public const int CODEC_ID_JPEG2000 = 91;
    public const int CODEC_ID_VMNC = 92;
    public const int CODEC_ID_VP5 = 93;
    public const int CODEC_ID_VP6 = 94;
    public const int CODEC_ID_VP6F = 95;
    public const int CODEC_ID_TARGA = 96;
    public const int CODEC_ID_DSICINVIDEO = 97;
    public const int CODEC_ID_TIERTEXSEQVIDEO = 98;
    public const int CODEC_ID_TIFF = 99;
    public const int CODEC_ID_GIF = 100;
    public const int CODEC_ID_FFH264 = 101;
    public const int CODEC_ID_DXA = 102;
    public const int CODEC_ID_DNXHD = 103;
    public const int CODEC_ID_THP = 104;
    public const int CODEC_ID_SGI = 105;
    public const int CODEC_ID_C93 = 106;
    public const int CODEC_ID_BETHSOFTVID = 107;
    public const int CODEC_ID_PTX = 108;
    public const int CODEC_ID_TXD = 109;
    public const int CODEC_ID_VP6A = 110;
    public const int CODEC_ID_AMV = 111;
    public const int CODEC_ID_VB = 112;
    public const int CODEC_ID_PCX = 113;
    public const int CODEC_ID_SUNRAST = 114;
    public const int CODEC_ID_INDEO4 = 115;
    public const int CODEC_ID_INDEO5 = 116;
    public const int CODEC_ID_MIMIC = 117;
    public const int CODEC_ID_RL2 = 118;
    public const int CODEC_ID_8SVX_EXP = 119;
    public const int CODEC_ID_8SVX_FIB = 120;
    public const int CODEC_ID_ESCAPE124 = 121;
    public const int CODEC_ID_DIRAC = 122;
    public const int CODEC_ID_BFI = 123;
    public const int CODEC_ID_CMV = 124;
    public const int CODEC_ID_MOTIONPIXELS = 125;
    public const int CODEC_ID_TGV = 126;
    public const int CODEC_ID_TGQ = 127;
    public const int CODEC_ID_TQI = 128;
    public const int CODEC_ID_AURA = 129;
    public const int CODEC_ID_AURA2 = 130;
    public const int CODEC_ID_V210X = 131;
    public const int CODEC_ID_TMV = 132;
    public const int CODEC_ID_V210 = 133;
    public const int CODEC_ID_DPX = 134;
    public const int CODEC_ID_MAD = 135;
    public const int CODEC_ID_FRWU = 136;
    public const int CODEC_ID_FLASHSV2 = 137;
    public const int CODEC_ID_CDGRAPHICS = 138;
    public const int CODEC_ID_R210 = 139;
    public const int CODEC_ID_ANM = 140;
    public const int CODEC_ID_BINKVIDEO = 141;
    public const int CODEC_ID_IFF_ILBM = 142;
    public const int CODEC_ID_IFF_BYTERUN1 = 143;
    public const int CODEC_ID_KGV1 = 144;
    public const int CODEC_ID_YOP = 145;
    public const int CODEC_ID_VP8 = 146;
    public const int CODEC_ID_PCM_S16LE = 65536;
    public const int CODEC_ID_PCM_S16BE = 65537;
    public const int CODEC_ID_PCM_U16LE = 65538;
    public const int CODEC_ID_PCM_U16BE = 65539;
    public const int CODEC_ID_PCM_S8 = 65540;
    public const int CODEC_ID_PCM_U8 = 65541;
    public const int CODEC_ID_PCM_MULAW = 65542;
    public const int CODEC_ID_PCM_ALAW = 65543;
    public const int CODEC_ID_PCM_S32LE = 65544;
    public const int CODEC_ID_PCM_S32BE = 65545;
    public const int CODEC_ID_PCM_U32LE = 65546;
    public const int CODEC_ID_PCM_U32BE = 65547;
    public const int CODEC_ID_PCM_S24LE = 65548;
    public const int CODEC_ID_PCM_S24BE = 65549;
    public const int CODEC_ID_PCM_U24LE = 65550;
    public const int CODEC_ID_PCM_U24BE = 65551;
    public const int CODEC_ID_PCM_S24DAUD = 65552;
    public const int CODEC_ID_PCM_ZORK = 65553;
    public const int CODEC_ID_PCM_S16LE_PLANAR = 65554;
    public const int CODEC_ID_PCM_DVD = 65555;
    public const int CODEC_ID_PCM_F32BE = 65556;
    public const int CODEC_ID_PCM_F32LE = 65557;
    public const int CODEC_ID_PCM_F64BE = 65558;
    public const int CODEC_ID_PCM_F64LE = 65559;
    public const int CODEC_ID_PCM_BLURAY = 65560;
    public const int CODEC_ID_ADPCM_IMA_QT = 69632;
    public const int CODEC_ID_ADPCM_IMA_WAV = 69633;
    public const int CODEC_ID_ADPCM_IMA_DK3 = 69634;
    public const int CODEC_ID_ADPCM_IMA_DK4 = 69635;
    public const int CODEC_ID_ADPCM_IMA_WS = 69636;
    public const int CODEC_ID_ADPCM_IMA_SMJPEG = 69637;
    public const int CODEC_ID_ADPCM_MS = 69638;
    public const int CODEC_ID_ADPCM_4XM = 69639;
    public const int CODEC_ID_ADPCM_XA = 69640;
    public const int CODEC_ID_ADPCM_ADX = 69641;
    public const int CODEC_ID_ADPCM_EA = 69642;
    public const int CODEC_ID_ADPCM_G726 = 69643;
    public const int CODEC_ID_ADPCM_CT = 69644;
    public const int CODEC_ID_ADPCM_SWF = 69645;
    public const int CODEC_ID_ADPCM_YAMAHA = 69646;
    public const int CODEC_ID_ADPCM_SBPRO_4 = 69647;
    public const int CODEC_ID_ADPCM_SBPRO_3 = 69648;
    public const int CODEC_ID_ADPCM_SBPRO_2 = 69649;
    public const int CODEC_ID_ADPCM_THP = 69650;
    public const int CODEC_ID_ADPCM_IMA_AMV = 69651;
    public const int CODEC_ID_ADPCM_EA_R1 = 69652;
    public const int CODEC_ID_ADPCM_EA_R3 = 69653;
    public const int CODEC_ID_ADPCM_EA_R2 = 69654;
    public const int CODEC_ID_ADPCM_IMA_EA_SEAD = 69655;
    public const int CODEC_ID_ADPCM_IMA_EA_EACS = 69656;
    public const int CODEC_ID_ADPCM_EA_XAS = 69657;
    public const int CODEC_ID_ADPCM_EA_MAXIS_XA = 69658;
    public const int CODEC_ID_ADPCM_IMA_ISS = 69659;
    public const int CODEC_ID_AMR_NB = 73728;
    public const int CODEC_ID_AMR_WB = 73729;
    public const int CODEC_ID_RA_144 = 77824;
    public const int CODEC_ID_RA_288 = 77825;
    public const int CODEC_ID_ROQ_DPCM = 81920;
    public const int CODEC_ID_INTERPLAY_DPCM = 81921;
    public const int CODEC_ID_XAN_DPCM = 81922;
    public const int CODEC_ID_SOL_DPCM = 81923;
    public const int CODEC_ID_MP2 = 86016;
    public const int CODEC_ID_MP3 = 86017;
    public const int CODEC_ID_AAC = 86018;
    public const int CODEC_ID_AC3 = 86019;
    public const int CODEC_ID_DTS = 86020;
    public const int CODEC_ID_VORBIS = 86021;
    public const int CODEC_ID_DVAUDIO = 86022;
    public const int CODEC_ID_WMAV1 = 86023;
    public const int CODEC_ID_WMAV2 = 86024;
    public const int CODEC_ID_MACE3 = 86025;
    public const int CODEC_ID_MACE6 = 86026;
    public const int CODEC_ID_VMDAUDIO = 86028;
    public const int CODEC_ID_SONIC = 86029;
    public const int CODEC_ID_SONIC_LS = 86030;
    public const int CODEC_ID_FLAC = 86031;
    public const int CODEC_ID_MP3ADU = 86032;
    public const int CODEC_ID_MP3ON4 = 86033;
    public const int CODEC_ID_SHORTEN = 86034;
    public const int CODEC_ID_ALAC = 86035;
    public const int CODEC_ID_WESTWOOD_SND1 = 86036;
    public const int CODEC_ID_GSM = 86037;
    public const int CODEC_ID_QDM2 = 86038;
    public const int CODEC_ID_COOK = 86039;
    public const int CODEC_ID_TRUESPEECH = 86040;
    public const int CODEC_ID_TTA = 86041;
    public const int CODEC_ID_SMACKAUDIO = 86042;
    public const int CODEC_ID_QCELP = 86043;
    public const int CODEC_ID_WAVPACK = 86044;
    public const int CODEC_ID_DSICINAUDIO = 86045;
    public const int CODEC_ID_IMC = 86046;
    public const int CODEC_ID_MUSEPACK7 = 86047;
    public const int CODEC_ID_MLP = 86048;
    public const int CODEC_ID_GSM_MS = 86049;
    public const int CODEC_ID_ATRAC3 = 86050;
    public const int CODEC_ID_VOXWARE = 86051;
    public const int CODEC_ID_APE = 86052;
    public const int CODEC_ID_NELLYMOSER = 86053;
    public const int CODEC_ID_MUSEPACK8 = 86054;
    public const int CODEC_ID_SPEEX = 86055;
    public const int CODEC_ID_WMAVOICE = 86056;
    public const int CODEC_ID_WMAPRO = 86057;
    public const int CODEC_ID_WMALOSSLESS = 86058;
    public const int CODEC_ID_ATRAC3P = 86059;
    public const int CODEC_ID_EAC3 = 86060;
    public const int CODEC_ID_SIPR = 86061;
    public const int CODEC_ID_MP1 = 86062;
    public const int CODEC_ID_TWINVQ = 86063;
    public const int CODEC_ID_TRUEHD = 86064;
    public const int CODEC_ID_MP4ALS = 86065;
    public const int CODEC_ID_ATRAC1 = 86066;
    public const int CODEC_ID_BINKAUDIO_RDFT = 86067;
    public const int CODEC_ID_BINKAUDIO_DCT = 86068;
    public const int CODEC_ID_DVD_SUBTITLE = 94208;
    public const int CODEC_ID_DVB_SUBTITLE = 94209;
    public const int CODEC_ID_TEXT = 94210;
    public const int CODEC_ID_XSUB = 94211;
    public const int CODEC_ID_SSA = 94212;
    public const int CODEC_ID_MOV_TEXT = 94213;
    public const int CODEC_ID_HDMV_PGS_SUBTITLE = 94214;
    public const int CODEC_ID_DVB_TELETEXT = 94215;
    public const int CODEC_ID_TTF = 98304;
    public const int CODEC_ID_PROBE = 102400;
    public const int CODEC_ID_MPEG2TS = 131072;
    public const int CODEC_TYPE_UNKNOWN = -1;
    public const int CODEC_TYPE_VIDEO = 0;
    public const int CODEC_TYPE_AUDIO = 1;
    public const int CODEC_TYPE_DATA = 2;
    public const int CODEC_TYPE_SUBTITLE = 3;
    public const int CODEC_TYPE_ATTACHMENT = 4;
    public const int CODEC_TYPE_NB = 5;
    public const int SAMPLE_FMT_NONE = -1;
    public const int SAMPLE_FMT_U8 = 0;
    public const int SAMPLE_FMT_S16 = 1;
    public const int SAMPLE_FMT_S32 = 2;
    public const int SAMPLE_FMT_FLT = 3;
    public const int SAMPLE_FMT_DBL = 4;
    public const int SAMPLE_FMT_NB = 5;
    public const int CH_FRONT_LEFT = 1;
    public const int CH_FRONT_RIGHT = 2;
    public const int CH_FRONT_CENTER = 4;
    public const int CH_LOW_FREQUENCY = 8;
    public const int CH_BACK_LEFT = 16;
    public const int CH_BACK_RIGHT = 32;
    public const int CH_FRONT_LEFT_OF_CENTER = 64;
    public const int CH_FRONT_RIGHT_OF_CENTER = 128;
    public const int CH_BACK_CENTER = 256;
    public const int CH_SIDE_LEFT = 512;
    public const int CH_SIDE_RIGHT = 1024;
    public const int CH_TOP_CENTER = 2048;
    public const int CH_TOP_FRONT_LEFT = 4096;
    public const int CH_TOP_FRONT_CENTER = 8192;
    public const int CH_TOP_FRONT_RIGHT = 16384;
    public const int CH_TOP_BACK_LEFT = 32768;
    public const int CH_TOP_BACK_CENTER = 65536;
    public const int CH_TOP_BACK_RIGHT = 131072;
    public const int CH_STEREO_LEFT = 536870912;
    public const int CH_STEREO_RIGHT = 1073741824;
    public const long CH_LAYOUT_NATIVE = -9223372036854775808L;
    public const int CH_LAYOUT_MONO = 4;
    public const int CH_LAYOUT_STEREO = 3;
    public const int CH_LAYOUT_2_1 = 259;
    public const int CH_LAYOUT_SURROUND = 7;
    public const int CH_LAYOUT_4POINT0 = 263;
    public const int CH_LAYOUT_2_2 = 1539;
    public const int CH_LAYOUT_QUAD = 51;
    public const int CH_LAYOUT_5POINT0 = 1543;
    public const int CH_LAYOUT_5POINT1 = 1551;
    public const int CH_LAYOUT_5POINT0_BACK = 55;
    public const int CH_LAYOUT_5POINT1_BACK = 63;
    public const int CH_LAYOUT_7POINT0 = 1591;
    public const int CH_LAYOUT_7POINT1 = 1599;
    public const int CH_LAYOUT_7POINT1_WIDE = 255;
    public const int CH_LAYOUT_STEREO_DOWNMIX = 1610612736;
    public const int AVCODEC_MAX_AUDIO_FRAME_SIZE = 192000;
    public const int FF_INPUT_BUFFER_PADDING_SIZE = 8;
    public const int FF_MIN_BUFFER_SIZE = 16384;
    public const int ME_ZERO = 1;
    public const int ME_FULL = 2;
    public const int ME_LOG = 3;
    public const int ME_PHODS = 4;
    public const int ME_EPZS = 5;
    public const int ME_X1 = 6;
    public const int ME_HEX = 7;
    public const int ME_UMH = 8;
    public const int ME_ITER = 9;
    public const int ME_TESA = 10;
    public const int AVDISCARD_NONE = -16;
    public const int AVDISCARD_DEFAULT = 0;
    public const int AVDISCARD_NONREF = 8;
    public const int AVDISCARD_BIDIR = 16;
    public const int AVDISCARD_NONKEY = 32;
    public const int AVDISCARD_ALL = 48;
    public const int AVCOL_PRI_BT709 = 1;
    public const int AVCOL_PRI_UNSPECIFIED = 2;
    public const int AVCOL_PRI_BT470M = 4;
    public const int AVCOL_PRI_BT470BG = 5;
    public const int AVCOL_PRI_SMPTE170M = 6;
    public const int AVCOL_PRI_SMPTE240M = 7;
    public const int AVCOL_PRI_FILM = 8;
    public const int AVCOL_PRI_NB = 9;
    public const int AVCOL_TRC_BT709 = 1;
    public const int AVCOL_TRC_UNSPECIFIED = 2;
    public const int AVCOL_TRC_GAMMA22 = 4;
    public const int AVCOL_TRC_GAMMA28 = 5;
    public const int AVCOL_TRC_NB = 6;
    public const int AVCOL_SPC_RGB = 0;
    public const int AVCOL_SPC_BT709 = 1;
    public const int AVCOL_SPC_UNSPECIFIED = 2;
    public const int AVCOL_SPC_FCC = 4;
    public const int AVCOL_SPC_BT470BG = 5;
    public const int AVCOL_SPC_SMPTE170M = 6;
    public const int AVCOL_SPC_SMPTE240M = 7;
    public const int AVCOL_SPC_NB = 8;
    public const int AVCOL_RANGE_UNSPECIFIED = 0;
    public const int AVCOL_RANGE_MPEG = 1;
    public const int AVCOL_RANGE_JPEG = 2;
    public const int AVCOL_RANGE_NB = 3;
    public const int AVCHROMA_LOC_UNSPECIFIED = 0;
    public const int AVCHROMA_LOC_LEFT = 1;
    public const int AVCHROMA_LOC_CENTER = 2;
    public const int AVCHROMA_LOC_TOPLEFT = 3;
    public const int AVCHROMA_LOC_TOP = 4;
    public const int AVCHROMA_LOC_BOTTOMLEFT = 5;
    public const int AVCHROMA_LOC_BOTTOM = 6;
    public const int AVCHROMA_LOC_NB = 7;
    public const int FF_MAX_B_FRAMES = 16;
    public const int CODEC_FLAG_QSCALE = 2;
    public const int CODEC_FLAG_4MV = 4;
    public const int CODEC_FLAG_QPEL = 16;
    public const int CODEC_FLAG_GMC = 32;
    public const int CODEC_FLAG_MV0 = 64;
    public const int CODEC_FLAG_PART = 128;
    public const int CODEC_FLAG_INPUT_PRESERVED = 256;
    public const int CODEC_FLAG_PASS1 = 512;
    public const int CODEC_FLAG_PASS2 = 1024;
    public const int CODEC_FLAG_EXTERN_HUFF = 4096;
    public const int CODEC_FLAG_GRAY = 8192;
    public const int CODEC_FLAG_EMU_EDGE = 16384;
    public const int CODEC_FLAG_PSNR = 32768;
    public const int CODEC_FLAG_TRUNCATED = 65536;
    public const int CODEC_FLAG_NORMALIZE_AQP = 131072;
    public const int CODEC_FLAG_INTERLACED_DCT = 262144;
    public const int CODEC_FLAG_LOW_DELAY = 524288;
    public const int CODEC_FLAG_ALT_SCAN = 1048576;
    public const int CODEC_FLAG_GLOBAL_HEADER = 4194304;
    public const int CODEC_FLAG_BITEXACT = 8388608;
    public const int CODEC_FLAG_AC_PRED = 16777216;
    public const int CODEC_FLAG_H263P_UMV = 33554432;
    public const int CODEC_FLAG_CBP_RD = 67108864;
    public const int CODEC_FLAG_QP_RD = 134217728;
    public const int CODEC_FLAG_H263P_AIV = 8;
    public const int CODEC_FLAG_OBMC = 1;
    public const int CODEC_FLAG_LOOP_FILTER = 2048;
    public const int CODEC_FLAG_H263P_SLICE_STRUCT = 268435456;
    public const int CODEC_FLAG_INTERLACED_ME = 536870912;
    public const int CODEC_FLAG_SVCD_SCAN_OFFSET = 1073741824;
    public const int CODEC_FLAG_CLOSED_GOP = -2147483648;
    public const int CODEC_FLAG2_FAST = 1;
    public const int CODEC_FLAG2_STRICT_GOP = 2;
    public const int CODEC_FLAG2_NO_OUTPUT = 4;
    public const int CODEC_FLAG2_LOCAL_HEADER = 8;
    public const int CODEC_FLAG2_BPYRAMID = 16;
    public const int CODEC_FLAG2_WPRED = 32;
    public const int CODEC_FLAG2_MIXED_REFS = 64;
    public const int CODEC_FLAG2_8X8DCT = 128;
    public const int CODEC_FLAG2_FASTPSKIP = 256;
    public const int CODEC_FLAG2_AUD = 512;
    public const int CODEC_FLAG2_BRDO = 1024;
    public const int CODEC_FLAG2_INTRA_VLC = 2048;
    public const int CODEC_FLAG2_MEMC_ONLY = 4096;
    public const int CODEC_FLAG2_DROP_FRAME_TIMECODE = 8192;
    public const int CODEC_FLAG2_SKIP_RD = 16384;
    public const int CODEC_FLAG2_CHUNKS = 32768;
    public const int CODEC_FLAG2_NON_LINEAR_QUANT = 65536;
    public const int CODEC_FLAG2_BIT_RESERVOIR = 131072;
    public const int CODEC_FLAG2_MBTREE = 262144;
    public const int CODEC_FLAG2_PSY = 524288;
    public const int CODEC_FLAG2_SSIM = 1048576;
    public const int CODEC_CAP_DRAW_HORIZ_BAND = 1;
    public const int CODEC_CAP_DR1 = 2;
    public const int CODEC_CAP_PARSE_ONLY = 4;
    public const int CODEC_CAP_TRUNCATED = 8;
    public const int CODEC_CAP_HWACCEL = 16;
    public const int CODEC_CAP_DELAY = 32;
    public const int CODEC_CAP_SMALL_LAST_FRAME = 64;
    public const int CODEC_CAP_HWACCEL_VDPAU = 128;
    public const int CODEC_CAP_SUBFRAMES = 256;
    public const int CODEC_CAP_EXPERIMENTAL = 512;
    public const int MB_TYPE_INTRA4x4 = 1;
    public const int MB_TYPE_INTRA16x16 = 2;
    public const int MB_TYPE_INTRA_PCM = 4;
    public const int MB_TYPE_16x16 = 8;
    public const int MB_TYPE_16x8 = 16;
    public const int MB_TYPE_8x16 = 32;
    public const int MB_TYPE_8x8 = 64;
    public const int MB_TYPE_INTERLACED = 128;
    public const int MB_TYPE_DIRECT2 = 256;
    public const int MB_TYPE_ACPRED = 512;
    public const int MB_TYPE_GMC = 1024;
    public const int MB_TYPE_SKIP = 2048;
    public const int MB_TYPE_P0L0 = 4096;
    public const int MB_TYPE_P1L0 = 8192;
    public const int MB_TYPE_P0L1 = 16384;
    public const int MB_TYPE_P1L1 = 32768;
    public const int MB_TYPE_L0 = 12288;
    public const int MB_TYPE_L1 = 49152;
    public const int MB_TYPE_L0L1 = 61440;
    public const int MB_TYPE_QUANT = 65536;
    public const int MB_TYPE_CBP = 131072;
    public const int FF_QSCALE_TYPE_MPEG1 = 0;
    public const int FF_QSCALE_TYPE_MPEG2 = 1;
    public const int FF_QSCALE_TYPE_H264 = 2;
    public const int FF_QSCALE_TYPE_VP56 = 3;
    public const int FF_BUFFER_TYPE_INTERNAL = 1;
    public const int FF_BUFFER_TYPE_USER = 2;
    public const int FF_BUFFER_TYPE_SHARED = 4;
    public const int FF_BUFFER_TYPE_COPY = 8;
    public const int FF_I_TYPE = 1;
    public const int FF_P_TYPE = 2;
    public const int FF_B_TYPE = 3;
    public const int FF_S_TYPE = 4;
    public const int FF_SI_TYPE = 5;
    public const int FF_SP_TYPE = 6;
    public const int FF_BI_TYPE = 7;
    public const int FF_BUFFER_HINTS_VALID = 1;
    public const int FF_BUFFER_HINTS_READABLE = 2;
    public const int FF_BUFFER_HINTS_PRESERVE = 4;
    public const int FF_BUFFER_HINTS_REUSABLE = 8;
    public const int AV_PKT_FLAG_KEY = 1;
    public const int PKT_FLAG_KEY = 1;
    public const int SUBTITLE_NONE = 0;
    public const int SUBTITLE_BITMAP = 1;
    public const int SUBTITLE_TEXT = 2;
    public const int SUBTITLE_ASS = 3;
    public const int FF_LOSS_RESOLUTION = 1;
    public const int FF_LOSS_DEPTH = 2;
    public const int FF_LOSS_COLORSPACE = 4;
    public const int FF_LOSS_ALPHA = 8;
    public const int FF_LOSS_COLORQUANT = 16;
    public const int FF_LOSS_CHROMA = 32;
    public const int FF_ALPHA_TRANSP = 1;
    public const int FF_ALPHA_SEMI_TRANSP = 2;
    public const int AV_LOCK_CREATE = 0;
    public const int AV_LOCK_OBTAIN = 1;
    public const int AV_LOCK_RELEASE = 2;
    public const int AV_LOCK_DESTROY = 3;
    public const int FF_OPT_TYPE_FLAGS = 0;
    public const int FF_OPT_TYPE_INT = 1;
    public const int FF_OPT_TYPE_INT64 = 2;
    public const int FF_OPT_TYPE_DOUBLE = 3;
    public const int FF_OPT_TYPE_FLOAT = 4;
    public const int FF_OPT_TYPE_STRING = 5;
    public const int FF_OPT_TYPE_RATIONAL = 6;
    public const int FF_OPT_TYPE_BINARY = 7;
    public const int FF_OPT_TYPE_CONST = 128;
    public const int DFT_R2C = 0;
    public const int IDFT_C2R = 1;
    public const int IDFT_R2C = 2;
    public const int DFT_C2R = 3;
    public const int DCT_II = 0;
    public const int DCT_III = 1;
    public const int DCT_I = 2;
    public const int DST_I = 3;
    public const int FF_VDPAU_STATE_USED_FOR_RENDER = 1;
    public const int FF_VDPAU_STATE_USED_FOR_REFERENCE = 2;
    public const int AV_XVMC_STATE_DISPLAY_PENDING = 1;
    public const int AV_XVMC_STATE_PREDICTION = 2;
    public const int AV_XVMC_STATE_OSD_SOURCE = 4;
    public const int AV_XVMC_ID = 499585472;
    static IntPtr __\u003Cjniptr\u003Eav_destruct_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eav_init_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_new_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_shrink_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_dup_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_free_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_audio_resample_init\u0028IIIIIIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u005BS\u005BSI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eaudio_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_resample_init\u0028IIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u005BS\u005BS\u005BIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_resample_compensate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavpicture_alloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavpicture_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavpicture_fill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavpicture_layout\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavpicture_get_size\u0028III\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_chroma_sub_sample\u0028I\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_pix_fmt_name\u0028I\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_set_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_pix_fmt_to_codec_tag\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_pix_fmt_loss\u0028III\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_find_best_pix_fmt\u0028JII\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_pix_fmt_string\u0028\u005BBII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eimg_get_alpha_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavpicture_deinterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_codec_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_version\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_init\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_find_encoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_find_encoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_find_decoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_find_decoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_string\u0028\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_context_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_context_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_alloc_context2\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_copy_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_frame_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_alloc_frame\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_get_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_release_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_reget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_get_edge_width\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_align_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_align_dimensions2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_check_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_get_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_thread_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_thread_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_execute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_execute2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BS\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_decode_video2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_decode_subtitle2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u005BS\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILjava\u002Fnio\u002FShortBuffer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_encode_video\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_encode_subtitle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavcodec_register_all\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_flush_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavcodec_default_free_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_get_pict_type_char\u0028I\u0029C;
    static IntPtr __\u003Cjniptr\u003Eav_get_bits_per_sample\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_get_bits_per_sample_format\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_parser_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_register_codec_parser\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_parser_init\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_parser_parse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIJJJ\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_parser_change\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_parser_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_register_bitstream_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_bitstream_filter_init\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_bitstream_filter_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_bitstream_filter_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_bitstream_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_fast_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_fast_malloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_picture_copy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_picture_crop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_picture_pad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIIIIII\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_xiphlacing\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_parse_video_frame_size\u0028\u005BI\u005BILjava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_parse_video_frame_rate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLjava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_log_missing_feature\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_log_ask_for_sample\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_register_hwaccel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_hwaccel_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_lockmgr_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Cb\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_find_opt\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_set_string3\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_set_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_set_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_set_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_get_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003Eav_get_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_get_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_get_string\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_next_option\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_opt_show\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_opt_set_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_opt_set_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_fft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_fft_permute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_fft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_fft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_mdct_init\u0028IID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_mdct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_rdft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_rdft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_dct_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_dct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u0029V;

    [Modifiers]
    public static int LIBAVCODEC_VERSION_INT
    {
      [HideFromJava] get
      {
        return avcodec.__\u003C\u003ELIBAVCODEC_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBAVCODEC_VERSION
    {
      [HideFromJava] get
      {
        return avcodec.__\u003C\u003ELIBAVCODEC_VERSION;
      }
    }

    [Modifiers]
    public static int LIBAVCODEC_BUILD
    {
      [HideFromJava] get
      {
        return avcodec.__\u003C\u003ELIBAVCODEC_BUILD;
      }
    }

    [Modifiers]
    public static string LIBAVCODEC_IDENT
    {
      [HideFromJava] get
      {
        return avcodec.__\u003C\u003ELIBAVCODEC_IDENT;
      }
    }

    [Modifiers]
    public static object AV_TIME_BASE_Q
    {
      [HideFromJava] get
      {
        return avcodec.__\u003C\u003EAV_TIME_BASE_Q;
      }
    }

    [LineNumberTable((ushort) 85)]
    static avcodec()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<avutil>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 232, (byte) 168, (byte) 233})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public avcodec()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void avcodec_init()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_init\u0028\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_init\u0028\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_init", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_init\u0028\u0029V)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_register_all()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_register_all\u0028\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_register_all\u0028\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_register_all", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_register_all\u0028\u0029V)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_find_decoder(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_find_decoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_find_decoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_find_decoder", "(I)Lcom/googlecode/javacv/cpp/avcodec$AVCodec;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_find_decoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_open(object avcc, object avc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_open", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVCodec;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_alloc_frame()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_alloc_frame\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_alloc_frame\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_alloc_frame", "()Lcom/googlecode/javacv/cpp/avcodec$AVFrame;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_alloc_frame\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avpicture_get_size(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavpicture_get_size\u0028III\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavpicture_get_size\u0028III\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avpicture_get_size", "(III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eavpicture_get_size\u0028III\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avpicture_fill(object avp, object bp, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavpicture_fill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavpicture_fill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avpicture_fill", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;Lcom/googlecode/javacpp/BytePointer;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eavpicture_fill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_close(object avcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_close", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_free_packet(object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_free_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_free_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_free_packet", "(Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_free_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_decode_video2(object avcc, object avf, int[] iarr, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_decode_video2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_decode_video2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_decode_video2", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVFrame;[ILcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_decode_video2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avpicture_deinterlace(object avp1, object avp2, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavpicture_deinterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavpicture_deinterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avpicture_deinterlace", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;Lcom/googlecode/javacv/cpp/avcodec$AVPicture;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eavpicture_deinterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_find_encoder(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_find_encoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_find_encoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_find_encoder", "(I)Lcom/googlecode/javacv/cpp/avcodec$AVCodec;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_find_encoder\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_init_packet(object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_init_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_init_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_init_packet", "(Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_init_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_encode_video(object avcc, object bp, int i, object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_encode_video\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_encode_video\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_encode_video", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/BytePointer;ILcom/googlecode/javacv/cpp/avcodec$AVFrame;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_encode_video\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_destruct_packet(object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_destruct_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_destruct_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_destruct_packet", "(Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_destruct_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_new_packet(object avp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_new_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_new_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_new_packet", "(Lcom/googlecode/javacv/cpp/avcodec$AVPacket;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_new_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_shrink_packet(object avp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_shrink_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_shrink_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_shrink_packet", "(Lcom/googlecode/javacv/cpp/avcodec$AVPacket;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_shrink_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_dup_packet(object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_dup_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_dup_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_dup_packet", "(Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_dup_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_audio_resample_init(int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_audio_resample_init\u0028IIIIIIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_audio_resample_init\u0028IIIIIIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_audio_resample_init", "(IIIIIIIIID)Lcom/googlecode/javacv/cpp/avcodec$ReSampleContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        int num8 = i5;
        int num9 = i6;
        int num10 = i7;
        int num11 = i8;
        int num12 = i9;
        double num13 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, int, int, int, int, int, double)>) avcodec.__\u003Cjniptr\u003Eav_audio_resample_init\u0028IIIIIIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B)((double) num2, (int) num3, num4, num5, num6, num7, num8, num9, num10, num11, (IntPtr) num12, (IntPtr) num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int audio_resample(object rsc, short[] sarr1, short[] sarr2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u005BS\u005BSI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u005BS\u005BSI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "audio_resample", "(Lcom/googlecode/javacv/cpp/avcodec$ReSampleContext;[S[SI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rsc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) sarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) sarr2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u005BS\u005BSI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int audio_resample(object rsc, ShortBuffer sb1, ShortBuffer sb2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "audio_resample", "(Lcom/googlecode/javacv/cpp/avcodec$ReSampleContext;Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rsc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) sb1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) sb2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eaudio_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void audio_resample_close(object rsc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eaudio_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eaudio_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "audio_resample_close", "(Lcom/googlecode/javacv/cpp/avcodec$ReSampleContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rsc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eaudio_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024ReSampleContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_resample_init(int i1, int i2, int i3, int i4, int i5, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_resample_init\u0028IIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_resample_init\u0028IIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_resample_init", "(IIIIID)Lcom/googlecode/javacv/cpp/avcodec$AVResampleContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        int num8 = i5;
        double num9 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, int, double)>) avcodec.__\u003Cjniptr\u003Eav_resample_init\u0028IIIIID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B)((double) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_resample(object avrc, short[] sarr1, short[] sarr2, int[] iarr, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u005BS\u005BS\u005BIIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u005BS\u005BS\u005BIIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_resample", "(Lcom/googlecode/javacv/cpp/avcodec$AVResampleContext;[S[S[IIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avrc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) sarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) sarr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num8 = i1;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u005BS\u005BS\u005BIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_resample(object avrc, ShortBuffer sb1, ShortBuffer sb2, int[] iarr, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BIIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BIIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_resample", "(Lcom/googlecode/javacv/cpp/avcodec$AVResampleContext;Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;[IIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avrc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) sb1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) sb2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num8 = i1;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eav_resample\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BLjava\u002Fnio\u002FShortBuffer\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_resample_compensate(object avrc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_resample_compensate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BII\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_resample_compensate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BII\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_resample_compensate", "(Lcom/googlecode/javacv/cpp/avcodec$AVResampleContext;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avrc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_resample_compensate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_resample_close(object avrc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_resample_close", "(Lcom/googlecode/javacv/cpp/avcodec$AVResampleContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avrc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_resample_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVResampleContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avpicture_alloc(object avp, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavpicture_alloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavpicture_alloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avpicture_alloc", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eavpicture_alloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avpicture_free(object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavpicture_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavpicture_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avpicture_free", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavpicture_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avpicture_layout(object avp, int i1, int i2, int i3, object bp, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavpicture_layout\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavpicture_layout\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avpicture_layout", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;IIILcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavpicture_layout\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, (int) num4, num5, num6, (IntPtr) num7, num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_get_chroma_sub_sample(int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_chroma_sub_sample\u0028I\u005BI\u005BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_chroma_sub_sample\u0028I\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_chroma_sub_sample", "(I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_chroma_sub_sample\u0028I\u005BI\u005BI\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string avcodec_get_pix_fmt_name(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_pix_fmt_name\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_pix_fmt_name\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_pix_fmt_name", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_pix_fmt_name\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_set_dimensions(object avcc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_set_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BII\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_set_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BII\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_set_dimensions", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_set_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_pix_fmt_to_codec_tag(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_pix_fmt_to_codec_tag\u0028I\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_pix_fmt_to_codec_tag\u0028I\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_pix_fmt_to_codec_tag", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_pix_fmt_to_codec_tag\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_get_pix_fmt_loss(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_pix_fmt_loss\u0028III\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_pix_fmt_loss\u0028III\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_pix_fmt_loss", "(III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_pix_fmt_loss\u0028III\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_find_best_pix_fmt(long l, int i1, int i2, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_find_best_pix_fmt\u0028JII\u005BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_find_best_pix_fmt\u0028JII\u005BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_find_best_pix_fmt", "(JII[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        long num4 = l;
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, long, int, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_find_best_pix_fmt\u0028JII\u005BI\u0029I)(num2, (int) num3, (int) num4, (long) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_pix_fmt_string(byte[] barr, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_pix_fmt_string\u0028\u005BBII\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_pix_fmt_string\u0028\u005BBII\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_pix_fmt_string", "([BII)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_pix_fmt_string\u0028\u005BBII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int img_get_alpha_info(object avp, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eimg_get_alpha_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eimg_get_alpha_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "img_get_alpha_info", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eimg_get_alpha_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_codec_next(object avc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_codec_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_codec_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_codec_next", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodec;)Lcom/googlecode/javacv/cpp/avcodec$AVCodec;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_codec_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_version\u0028\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_version\u0028\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_version\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string avcodec_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string avcodec_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_register(object avc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_register", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodec;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_find_encoder_by_name(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_find_encoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_find_encoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_find_encoder_by_name", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avcodec$AVCodec;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_find_encoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_find_decoder_by_name(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_find_decoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_find_decoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_find_decoder_by_name", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avcodec$AVCodec;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_find_decoder_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodec\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_string(byte[] barr, int i1, object avcc, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_string\u0028\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_string\u0028\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_string", "([BILcom/googlecode/javacv/cpp/avcodec$AVCodecContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_string\u0028\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_get_context_defaults(object avcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_context_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_context_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_context_defaults", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_context_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_get_context_defaults2(object avcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_context_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_context_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_context_defaults2", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_context_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_alloc_context()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_alloc_context", "()Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object avcodec_alloc_context2(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_alloc_context2\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_alloc_context2\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_alloc_context2", "(I)Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_alloc_context2\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_copy_context(object avcc1, object avcc2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_copy_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_copy_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_copy_context", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avcc2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_copy_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_get_frame_defaults(object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_frame_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_frame_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_frame_defaults", "(Lcom/googlecode/javacv/cpp/avcodec$AVFrame;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_frame_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_default_get_buffer(object avcc, object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_get_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_get_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_get_buffer", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVFrame;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_get_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_default_release_buffer(object avcc, object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_release_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_release_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_release_buffer", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVFrame;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_release_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_default_reget_buffer(object avcc, object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_reget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_reget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_reget_buffer", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVFrame;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_reget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVFrame\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_get_edge_width()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_get_edge_width\u0028\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_get_edge_width\u0028\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_get_edge_width", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_get_edge_width\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_align_dimensions(object avcc, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_align_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_align_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_align_dimensions", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_align_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_align_dimensions2(object avcc, int[] iarr1, int[] iarr2, int[] iarr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_align_dimensions2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u005BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_align_dimensions2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_align_dimensions2", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;[I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_align_dimensions2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u005BI\u005BI\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_check_dimensions(object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_check_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_check_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_check_dimensions", "(Lcom/googlecode/javacpp/Pointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_check_dimensions\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_default_get_format(object avcc, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_get_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_get_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_get_format", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_get_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_thread_init(object avcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_thread_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_thread_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_thread_init", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_thread_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_thread_free(object avcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_thread_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_thread_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_thread_free", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_thread_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_default_execute(object avcc, object f, object p, int[] iarr, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_execute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_execute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_execute", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$Func;Lcom/googlecode/javacpp/Pointer;[III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(f);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num8 = i1;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_execute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BIII\u0029I)((int) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_default_execute2(object avcc, object f, object p, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_execute2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_execute2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_execute2", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$Func2;Lcom/googlecode/javacpp/Pointer;[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(f);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_execute2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Func2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029I)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_decode_audio3(object avcc, short[] sarr, int[] iarr, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BS\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BS\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_decode_audio3", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;[S[ILcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) sarr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u005BS\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_decode_audio3(object avcc, ShortBuffer sb, int[] iarr, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_decode_audio3", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Ljava/nio/ShortBuffer;[ILcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) sb);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_decode_audio3\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Fnio\u002FShortBuffer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_decode_subtitle2(object avcc, object avs, int[] iarr, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_decode_subtitle2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_decode_subtitle2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_decode_subtitle2", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacv/cpp/avcodec$AVSubtitle;[ILcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_decode_subtitle2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_encode_audio(object avcc, object bp, int i, short[] sarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u005BS\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u005BS\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_encode_audio", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/BytePointer;I[S)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) sarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u005BS\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_encode_audio(object avcc, object bp, int i, ShortBuffer sb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILjava\u002Fnio\u002FShortBuffer\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILjava\u002Fnio\u002FShortBuffer\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_encode_audio", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/BytePointer;ILjava/nio/ShortBuffer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) sb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILjava\u002Fnio\u002FShortBuffer\u003B\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_encode_audio(object avcc, object bp, int i, object sp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_encode_audio", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/BytePointer;ILcom/googlecode/javacpp/ShortPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(sp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_encode_audio\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003B\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avcodec_encode_subtitle(object avcc, object bp, int i, object avs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_encode_subtitle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_encode_subtitle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_encode_subtitle", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/BytePointer;ILcom/googlecode/javacv/cpp/avcodec$AVSubtitle;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_encode_subtitle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVSubtitle\u003B\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_flush_buffers(object avcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_flush_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_flush_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_flush_buffers", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_flush_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void avcodec_default_free_buffers(object avcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eavcodec_default_free_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eavcodec_default_free_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "avcodec_default_free_buffers", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eavcodec_default_free_buffers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static char av_get_pict_type_char(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_pict_type_char\u0028I\u0029C == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_pict_type_char\u0028I\u0029C = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_pict_type_char", "(I)C");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<char (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_get_pict_type_char\u0028I\u0029C)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_get_bits_per_sample(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_bits_per_sample\u0028I\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_bits_per_sample\u0028I\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_bits_per_sample", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_get_bits_per_sample\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_get_bits_per_sample_format(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_bits_per_sample_format\u0028I\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_bits_per_sample_format\u0028I\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_bits_per_sample_format", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_get_bits_per_sample_format\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_parser_next(object avcp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parser_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parser_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parser_next", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecParser;)Lcom/googlecode/javacv/cpp/avcodec$AVCodecParser;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_parser_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_register_codec_parser(object avcp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_register_codec_parser\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_register_codec_parser\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_register_codec_parser", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecParser;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_register_codec_parser\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParser\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_parser_init(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parser_init\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parser_init\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parser_init", "(I)Lcom/googlecode/javacv/cpp/avcodec$AVCodecParserContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_parser_init\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_parser_parse2(object avcpc, object avcc, object pp, int[] iarr, object bp, int i, long l1, long l2, long l3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parser_parse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIJJJ\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parser_parse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIJJJ\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parser_parse2", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecParserContext;Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/PointerPointer;[ILcom/googlecode/javacpp/BytePointer;IJJJ)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcpc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num9 = i;
        long num10 = l1;
        long num11 = l2;
        long num12 = l3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, long, long, long)>) avcodec.__\u003Cjniptr\u003Eav_parser_parse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIJJJ\u0029I)((long) num2, (long) num3, (long) num4, (int) num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_parser_change(object avcpc, object avcc, object pp, int[] iarr, object bp, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parser_change\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parser_change\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parser_change", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecParserContext;Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Lcom/googlecode/javacpp/PointerPointer;[ILcom/googlecode/javacpp/BytePointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcpc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num9 = i1;
        int num10 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_parser_change\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_parser_close(object avcpc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parser_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parser_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parser_close", "(Lcom/googlecode/javacv/cpp/avcodec$AVCodecParserContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avcpc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_parser_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecParserContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_register_bitstream_filter(object avbsf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_register_bitstream_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_register_bitstream_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_register_bitstream_filter", "(Lcom/googlecode/javacv/cpp/avcodec$AVBitStreamFilter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avbsf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_register_bitstream_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_bitstream_filter_init(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_init\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_init\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_bitstream_filter_init", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avcodec$AVBitStreamFilterContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_init\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_bitstream_filter_filter(object avbsfc, object avcc, string str, object pp, int[] iarr, object bp, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_bitstream_filter_filter", "(Lcom/googlecode/javacv/cpp/avcodec$AVBitStreamFilterContext;Lcom/googlecode/javacv/cpp/avcodec$AVCodecContext;Ljava/lang/String;Lcom/googlecode/javacpp/PointerPointer;[ILcom/googlecode/javacpp/BytePointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avbsfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avcc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num10 = i1;
        int num11 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVCodecContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, num6, num7, num8, num9, (IntPtr) num10, (IntPtr) num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_bitstream_filter_close(object avbsfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_bitstream_filter_close", "(Lcom/googlecode/javacv/cpp/avcodec$AVBitStreamFilterContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avbsfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilterContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_bitstream_filter_next(object avbsf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_bitstream_filter_next", "(Lcom/googlecode/javacv/cpp/avcodec$AVBitStreamFilter;)Lcom/googlecode/javacv/cpp/avcodec$AVBitStreamFilter;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avbsf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_bitstream_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVBitStreamFilter\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_fast_realloc(object p, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_fast_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_fast_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_fast_realloc", "(Lcom/googlecode/javacpp/Pointer;[II)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_fast_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_fast_malloc(object p, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_fast_malloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_fast_malloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_fast_malloc", "(Lcom/googlecode/javacpp/Pointer;[II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_fast_malloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BII\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_picture_copy(object avp1, object avp2, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_picture_copy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_picture_copy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_picture_copy", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;Lcom/googlecode/javacv/cpp/avcodec$AVPicture;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eav_picture_copy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_picture_crop(object avp1, object avp2, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_picture_crop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_picture_crop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_picture_crop", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;Lcom/googlecode/javacv/cpp/avcodec$AVPicture;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) avcodec.__\u003Cjniptr\u003Eav_picture_crop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_picture_pad(object avp1, object avp2, int i1, int i2, int i3, int i4, int i5, int i6, int i7, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_picture_pad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIIIIII\u005BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_picture_pad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIIIIII\u005BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_picture_pad", "(Lcom/googlecode/javacv/cpp/avcodec$AVPicture;Lcom/googlecode/javacv/cpp/avcodec$AVPicture;IIIIIII[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        int num10 = i5;
        int num11 = i6;
        int num12 = i7;
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_picture_pad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPicture\u003BIIIIIII\u005BI\u0029I)(num2, (int) num3, (int) num4, (int) num5, num6, num7, num8, num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12, num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_xiphlacing(object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_xiphlacing\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_xiphlacing\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_xiphlacing", "(Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_xiphlacing\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_parse_video_frame_size(int[] iarr1, int[] iarr2, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parse_video_frame_size\u0028\u005BI\u005BILjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parse_video_frame_size\u0028\u005BI\u005BILjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parse_video_frame_size", "([I[ILjava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_parse_video_frame_size\u0028\u005BI\u005BILjava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_parse_video_frame_rate(object avr, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_parse_video_frame_rate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_parse_video_frame_rate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_parse_video_frame_rate", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_parse_video_frame_rate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLjava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_log_missing_feature(object p, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_log_missing_feature\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_log_missing_feature\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_log_missing_feature", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_log_missing_feature\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_log_ask_for_sample(object p, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_log_ask_for_sample\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_log_ask_for_sample\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_log_ask_for_sample", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_log_ask_for_sample\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_register_hwaccel(object avhwa)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_register_hwaccel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_register_hwaccel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_register_hwaccel", "(Lcom/googlecode/javacv/cpp/avcodec$AVHWAccel;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avhwa);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_register_hwaccel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_hwaccel_next(object avhwa)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_hwaccel_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_hwaccel_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_hwaccel_next", "(Lcom/googlecode/javacv/cpp/avcodec$AVHWAccel;)Lcom/googlecode/javacv/cpp/avcodec$AVHWAccel;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avhwa);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_hwaccel_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVHWAccel\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_lockmgr_register(object c)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_lockmgr_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Cb\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_lockmgr_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Cb\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_lockmgr_register", "(Lcom/googlecode/javacv/cpp/avcodec$Cb;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(c);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_lockmgr_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024Cb\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_find_opt(object p, string str1, string str2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_find_opt\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_find_opt\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_find_opt", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Ljava/lang/String;II)Lcom/googlecode/javacv/cpp/avcodec$AVOption;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num7 = i1;
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_find_opt\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B)((int) num2, (int) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_set_string3(object p, string str1, string str2, int i, object avo)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_set_string3\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_set_string3\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_set_string3", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Ljava/lang/String;ILcom/googlecode/javacv/cpp/avcodec$AVOption;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(avo);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_set_string3\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029I)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_set_double(object p, string str, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_set_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_set_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_set_double", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;D)Lcom/googlecode/javacv/cpp/avcodec$AVOption;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, double)>) avcodec.__\u003Cjniptr\u003Eav_set_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B)((double) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_set_q(object p, string str, object avr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_set_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_set_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_set_q", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avutil$AVRational;)Lcom/googlecode/javacv/cpp/avcodec$AVOption;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_set_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_set_int(object p, string str, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_set_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_set_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_set_int", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;J)Lcom/googlecode/javacv/cpp/avcodec$AVOption;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        long num6 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, long)>) avcodec.__\u003Cjniptr\u003Eav_set_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B)((long) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double av_get_double(object p, string str, object avo)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029D == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029D = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_double", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avcodec$AVOption;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avo);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_get_double\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029D)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_get_q(object p, string str, object avo)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_q", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avcodec$AVOption;)Lcom/googlecode/javacv/cpp/avutil$AVRational;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avo);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_get_q\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static long av_get_int(object p, string str, object avo)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029J == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029J = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_int", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avcodec$AVOption;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avo);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_get_int\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029J)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string av_get_string(object p, string str, object avo, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_get_string\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_get_string\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_get_string", "(Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avcodec$AVOption;[BI)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avo);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num9 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avcodec.__\u003Cjniptr\u003Eav_get_string\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_next_option(object p, object avo)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_next_option\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_next_option\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_next_option", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/avcodec$AVOption;)Lcom/googlecode/javacv/cpp/avcodec$AVOption;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avo);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_next_option\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVOption\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int av_opt_show(object p1, object p2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_opt_show\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_opt_show\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_opt_show", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_opt_show\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_opt_set_defaults(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_opt_set_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_opt_set_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_opt_set_defaults", "(Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_opt_set_defaults\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_opt_set_defaults2(object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_opt_set_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_opt_set_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_opt_set_defaults2", "(Lcom/googlecode/javacpp/Pointer;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_opt_set_defaults2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_fft_init(int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_fft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_fft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_fft_init", "(II)Lcom/googlecode/javacv/cpp/avcodec$FFTContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_fft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B)((int) num2, (int) num3, (IntPtr) num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_fft_permute(object fftc1, object fftc2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_fft_permute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_fft_permute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_fft_permute", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Lcom/googlecode/javacv/cpp/avcodec$FFTComplex;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fftc2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_fft_permute\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_fft_calc(object fftc1, object fftc2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_fft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_fft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_fft_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Lcom/googlecode/javacv/cpp/avcodec$FFTComplex;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fftc2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_fft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTComplex\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_fft_end(object fftc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_fft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_fft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_fft_end", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_fft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_mdct_init(int i1, int i2, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_mdct_init\u0028IID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_mdct_init\u0028IID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_mdct_init", "(IID)Lcom/googlecode/javacv/cpp/avcodec$FFTContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, double)>) avcodec.__\u003Cjniptr\u003Eav_mdct_init\u0028IID\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B)((double) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_imdct_calc(object fftc, float[] farr1, float[] farr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_imdct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;[F[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_imdct_calc(object fftc, FloatBuffer fb1, FloatBuffer fb2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_imdct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) fb1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) fb2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_imdct_calc(object fftc, object fp1, object fp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_imdct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Lcom/googlecode/javacpp/FloatPointer;Lcom/googlecode/javacpp/FloatPointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(fp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_imdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_imdct_half(object fftc, float[] farr1, float[] farr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_imdct_half", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;[F[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_imdct_half(object fftc, FloatBuffer fb1, FloatBuffer fb2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_imdct_half", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) fb1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) fb2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_imdct_half(object fftc, object fp1, object fp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_imdct_half", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Lcom/googlecode/javacpp/FloatPointer;Lcom/googlecode/javacpp/FloatPointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(fp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_imdct_half\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_mdct_calc(object fftc, float[] farr1, float[] farr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_mdct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;[F[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u005BF\u005BF\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_mdct_calc(object fftc, FloatBuffer fb1, FloatBuffer fb2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_mdct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) fb1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) fb2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_mdct_calc(object fftc, object fp1, object fp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_mdct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;Lcom/googlecode/javacpp/FloatPointer;Lcom/googlecode/javacpp/FloatPointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(fp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_mdct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_mdct_end(object fftc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_mdct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_mdct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_mdct_end", "(Lcom/googlecode/javacv/cpp/avcodec$FFTContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(fftc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_mdct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024FFTContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_rdft_init(int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_rdft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_rdft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_rdft_init", "(II)Lcom/googlecode/javacv/cpp/avcodec$RDFTContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_rdft_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B)((int) num2, (int) num3, (IntPtr) num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_rdft_calc(object rdftc, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u005BF\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u005BF\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_rdft_calc", "(Lcom/googlecode/javacv/cpp/avcodec$RDFTContext;[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rdftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u005BF\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_rdft_calc(object rdftc, FloatBuffer fb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_rdft_calc", "(Lcom/googlecode/javacv/cpp/avcodec$RDFTContext;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rdftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_rdft_calc(object rdftc, object fp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_rdft_calc", "(Lcom/googlecode/javacv/cpp/avcodec$RDFTContext;Lcom/googlecode/javacpp/FloatPointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rdftc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_rdft_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_rdft_end(object rdftc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_rdft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_rdft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_rdft_end", "(Lcom/googlecode/javacv/cpp/avcodec$RDFTContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(rdftc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_rdft_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024RDFTContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object av_dct_init(int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_dct_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_dct_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_dct_init", "(II)Lcom/googlecode/javacv/cpp/avcodec$DCTContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        int num4 = i1;
        int num5 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int)>) avcodec.__\u003Cjniptr\u003Eav_dct_init\u0028II\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B)((int) num2, (int) num3, (IntPtr) num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_dct_calc(object dctc, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u005BF\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u005BF\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_dct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$DCTContext;[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(dctc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u005BF\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_dct_calc(object dctc, FloatBuffer fb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_dct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$DCTContext;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(dctc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_dct_calc(object dctc, object fp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_dct_calc", "(Lcom/googlecode/javacv/cpp/avcodec$DCTContext;Lcom/googlecode/javacpp/FloatPointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(dctc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(fp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_dct_calc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void av_dct_end(object dctc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avcodec.__\u003Cjniptr\u003Eav_dct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u0029V == IntPtr.Zero)
        avcodec.__\u003Cjniptr\u003Eav_dct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avcodec.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avcodec", "av_dct_end", "(Lcom/googlecode/javacv/cpp/avcodec$DCTContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avcodec.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avcodec>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(dctc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avcodec.__\u003Cjniptr\u003Eav_dct_end\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024DCTContext\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (avcodec.__\u003CcallerID\u003E == null)
        avcodec.__\u003CcallerID\u003E = (CallerID) new avcodec.__\u003CCallerID\u003E();
      return avcodec.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
