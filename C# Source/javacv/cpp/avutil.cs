// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.avutil
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
  public class avutil : Object
  {
    public const string genericIncludepath = "/opt/local/include/ffmpeg/:/usr/local/include/ffmpeg/:/opt/local/include/:/usr/include/ffmpeg/";
    public const string genericLinkpath = "/opt/local/lib/:/opt/local/lib64/:/usr/local/lib/:/usr/local/lib64/";
    public const string windowsIncludepath = "C:/MinGW/local/include/ffmpeg/;C:/MinGW/include/ffmpeg/;C:/MinGW/local/include/";
    public const string windowsLinkpath = "C:/MinGW/local/lib/;C:/MinGW/lib/";
    public const string windowsPreloadpath = "C:/MinGW/local/bin/;C:/MinGW/bin/";
    public const string androidIncludepath = "../include/";
    public const string androidLinkpath = "../lib/";
    public const int LIBAVUTIL_VERSION_MAJOR = 50;
    public const int LIBAVUTIL_VERSION_MINOR = 15;
    public const int LIBAVUTIL_VERSION_MICRO = 1;
    internal static int __\u003C\u003ELIBAVUTIL_VERSION_INT;
    internal static string __\u003C\u003ELIBAVUTIL_VERSION;
    internal static int __\u003C\u003ELIBAVUTIL_BUILD;
    internal static string __\u003C\u003ELIBAVUTIL_IDENT;
    public const int AVMEDIA_TYPE_UNKNOWN = -1;
    public const int AVMEDIA_TYPE_VIDEO = 0;
    public const int AVMEDIA_TYPE_AUDIO = 1;
    public const int AVMEDIA_TYPE_DATA = 2;
    public const int AVMEDIA_TYPE_SUBTITLE = 3;
    public const int AVMEDIA_TYPE_ATTACHMENT = 4;
    public const int AVMEDIA_TYPE_NB = 5;
    public const double M_E = 2.71828182845905;
    public const double M_LN2 = 0.693147180559945;
    public const double M_LN10 = 2.30258509299405;
    public const double M_LOG2_10 = 3.32192809488736;
    public const double M_PI = 3.14159265358979;
    public const double M_SQRT1_2 = 0.707106781186548;
    public const double M_SQRT2 = 1.4142135623731;
    public const double NAN = double.NaN;
    public const double INFINITY = double.PositiveInfinity;
    public const int AV_ROUND_ZERO = 0;
    public const int AV_ROUND_INF = 1;
    public const int AV_ROUND_DOWN = 2;
    public const int AV_ROUND_UP = 3;
    public const int AV_ROUND_NEAR_INF = 5;
    public const int AV_LOG_QUIET = -8;
    public const int AV_LOG_PANIC = 0;
    public const int AV_LOG_FATAL = 8;
    public const int AV_LOG_ERROR = 16;
    public const int AV_LOG_WARNING = 24;
    public const int AV_LOG_INFO = 32;
    public const int AV_LOG_VERBOSE = 40;
    public const int AV_LOG_DEBUG = 48;
    public const int PIX_FMT_NONE = -1;
    public const int PIX_FMT_YUV420P = 0;
    public const int PIX_FMT_YUYV422 = 1;
    public const int PIX_FMT_RGB24 = 2;
    public const int PIX_FMT_BGR24 = 3;
    public const int PIX_FMT_YUV422P = 4;
    public const int PIX_FMT_YUV444P = 5;
    public const int PIX_FMT_YUV410P = 6;
    public const int PIX_FMT_YUV411P = 7;
    public const int PIX_FMT_GRAY8 = 8;
    public const int PIX_FMT_MONOWHITE = 9;
    public const int PIX_FMT_MONOBLACK = 10;
    public const int PIX_FMT_PAL8 = 11;
    public const int PIX_FMT_YUVJ420P = 12;
    public const int PIX_FMT_YUVJ422P = 13;
    public const int PIX_FMT_YUVJ444P = 14;
    public const int PIX_FMT_XVMC_MPEG2_MC = 15;
    public const int PIX_FMT_XVMC_MPEG2_IDCT = 16;
    public const int PIX_FMT_UYVY422 = 17;
    public const int PIX_FMT_UYYVYY411 = 18;
    public const int PIX_FMT_BGR8 = 19;
    public const int PIX_FMT_BGR4 = 20;
    public const int PIX_FMT_BGR4_BYTE = 21;
    public const int PIX_FMT_RGB8 = 22;
    public const int PIX_FMT_RGB4 = 23;
    public const int PIX_FMT_RGB4_BYTE = 24;
    public const int PIX_FMT_NV12 = 25;
    public const int PIX_FMT_NV21 = 26;
    public const int PIX_FMT_ARGB = 27;
    public const int PIX_FMT_RGBA = 28;
    public const int PIX_FMT_ABGR = 29;
    public const int PIX_FMT_BGRA = 30;
    public const int PIX_FMT_GRAY16BE = 31;
    public const int PIX_FMT_GRAY16LE = 32;
    public const int PIX_FMT_YUV440P = 33;
    public const int PIX_FMT_YUVJ440P = 34;
    public const int PIX_FMT_YUVA420P = 35;
    public const int PIX_FMT_VDPAU_H264 = 36;
    public const int PIX_FMT_VDPAU_MPEG1 = 37;
    public const int PIX_FMT_VDPAU_MPEG2 = 38;
    public const int PIX_FMT_VDPAU_WMV3 = 39;
    public const int PIX_FMT_VDPAU_VC1 = 40;
    public const int PIX_FMT_RGB48BE = 41;
    public const int PIX_FMT_RGB48LE = 42;
    public const int PIX_FMT_RGB565BE = 43;
    public const int PIX_FMT_RGB565LE = 44;
    public const int PIX_FMT_RGB555BE = 45;
    public const int PIX_FMT_RGB555LE = 46;
    public const int PIX_FMT_BGR565BE = 47;
    public const int PIX_FMT_BGR565LE = 48;
    public const int PIX_FMT_BGR555BE = 49;
    public const int PIX_FMT_BGR555LE = 50;
    public const int PIX_FMT_VAAPI_MOCO = 51;
    public const int PIX_FMT_VAAPI_IDCT = 52;
    public const int PIX_FMT_VAAPI_VLD = 53;
    public const int PIX_FMT_YUV420P16LE = 54;
    public const int PIX_FMT_YUV420P16BE = 55;
    public const int PIX_FMT_YUV422P16LE = 56;
    public const int PIX_FMT_YUV422P16BE = 57;
    public const int PIX_FMT_YUV444P16LE = 58;
    public const int PIX_FMT_YUV444P16BE = 59;
    public const int PIX_FMT_VDPAU_MPEG4 = 60;
    public const int PIX_FMT_DXVA2_VLD = 61;
    public const int PIX_FMT_RGB444BE = 62;
    public const int PIX_FMT_RGB444LE = 63;
    public const int PIX_FMT_BGR444BE = 64;
    public const int PIX_FMT_BGR444LE = 65;
    public const int PIX_FMT_Y400A = 66;
    public const int PIX_FMT_NB = 67;
    internal static int __\u003C\u003EPIX_FMT_RGB32;
    internal static int __\u003C\u003EPIX_FMT_RGB32_1;
    internal static int __\u003C\u003EPIX_FMT_BGR32;
    internal static int __\u003C\u003EPIX_FMT_BGR32_1;
    internal static int __\u003C\u003EPIX_FMT_GRAY16;
    internal static int __\u003C\u003EPIX_FMT_RGB48;
    internal static int __\u003C\u003EPIX_FMT_RGB565;
    internal static int __\u003C\u003EPIX_FMT_RGB555;
    internal static int __\u003C\u003EPIX_FMT_RGB444;
    internal static int __\u003C\u003EPIX_FMT_BGR565;
    internal static int __\u003C\u003EPIX_FMT_BGR555;
    internal static int __\u003C\u003EPIX_FMT_BGR444;
    internal static int __\u003C\u003EPIX_FMT_YUV420P16;
    internal static int __\u003C\u003EPIX_FMT_YUV422P16;
    internal static int __\u003C\u003EPIX_FMT_YUV444P16;
    public const int AV_CRC_8_ATM = 0;
    public const int AV_CRC_16_ANSI = 1;
    public const int AV_CRC_16_CCITT = 2;
    public const int AV_CRC_32_IEEE = 3;
    public const int AV_CRC_32_IEEE_LE = 4;
    public const int AV_CRC_MAX = 5;
    public const int AV_LZO_INPUT_DEPLETED = 1;
    public const int AV_LZO_OUTPUT_FULL = 2;
    public const int AV_LZO_INVALID_BACKPTR = 4;
    public const int AV_LZO_ERROR = 8;
    public const int AV_LZO_INPUT_PADDING = 8;
    public const int AV_LZO_OUTPUT_PADDING = 12;
    public const int PIX_FMT_BE = 1;
    public const int PIX_FMT_PAL = 2;
    public const int PIX_FMT_BITSTREAM = 4;
    public const int PIX_FMT_HWACCEL = 8;
    static IntPtr __\u003Cjniptr\u003Eavutil_version\u0028\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eavutil_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavutil_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_malloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_free\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_mallocz\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_strdup\u0028Ljava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_freep\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_strerror\u0028I\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_gcd\u0028JJ\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_rescale\u0028JJJ\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_rescale_rnd\u0028JJJI\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_rescale_q\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_compare_ts\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_reduce\u0028\u005BI\u005BIJJJ\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_mul_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_div_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_add_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_sub_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_d2q\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_nearer_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_find_nearest_q_idx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_int2dbl\u0028J\u0029D;
    static IntPtr __\u003Cjniptr\u003Eav_int2flt\u0028I\u0029F;
    static IntPtr __\u003Cjniptr\u003Eav_ext2dbl\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003Eav_dbl2int\u0028D\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_flt2int\u0028F\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_dbl2ext\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_vlog\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_log_get_level\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_log_set_level\u0028I\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_log_set_callback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024LogCallback\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_log_default_callback\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_adler32_update\u0028JLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_strstart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_stristart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_stristr\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_strlcpy\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_strlcat\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_strlcatf\u0028\u005BBILjava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_d2str\u0028D\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_base64_decode\u0028\u005BB\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_base64_decode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_base64_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_base64_encode\u0028\u005BBI\u005BBI\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_base64_encode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BILjava\u002Fnio\u002FByteBuffer\u003BI\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_base64_encode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_crc_init\u0028\u005BIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_crc_get_table\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_crc\u0028\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_alloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_space\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_generic_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_read\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_generic_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_write\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_realloc2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_drain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_fifo_peek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029B;
    static IntPtr __\u003Cjniptr\u003Eav_lzo1x_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_memcpy_backptr\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_size\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_md5_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BBI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BB\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_sum\u0028\u005BB\u005BBI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_sum\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_md5_sum\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_pix_fmt_descriptors\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_get_pix_fmt\u0028Ljava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_get_bits_per_pixel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_sha1_size\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_sha1_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BBI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_sha1_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BB\u0029V;

    [Modifiers]
    public static int LIBAVUTIL_VERSION_INT
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003ELIBAVUTIL_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBAVUTIL_VERSION
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003ELIBAVUTIL_VERSION;
      }
    }

    [Modifiers]
    public static int LIBAVUTIL_BUILD
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003ELIBAVUTIL_BUILD;
      }
    }

    [Modifiers]
    public static string LIBAVUTIL_IDENT
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003ELIBAVUTIL_IDENT;
      }
    }

    [Modifiers]
    public static int PIX_FMT_RGB32
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_RGB32;
      }
    }

    [Modifiers]
    public static int PIX_FMT_RGB32_1
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_RGB32_1;
      }
    }

    [Modifiers]
    public static int PIX_FMT_BGR32
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_BGR32;
      }
    }

    [Modifiers]
    public static int PIX_FMT_BGR32_1
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_BGR32_1;
      }
    }

    [Modifiers]
    public static int PIX_FMT_GRAY16
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_GRAY16;
      }
    }

    [Modifiers]
    public static int PIX_FMT_RGB48
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_RGB48;
      }
    }

    [Modifiers]
    public static int PIX_FMT_RGB565
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_RGB565;
      }
    }

    [Modifiers]
    public static int PIX_FMT_RGB555
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_RGB555;
      }
    }

    [Modifiers]
    public static int PIX_FMT_RGB444
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_RGB444;
      }
    }

    [Modifiers]
    public static int PIX_FMT_BGR565
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_BGR565;
      }
    }

    [Modifiers]
    public static int PIX_FMT_BGR555
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_BGR555;
      }
    }

    [Modifiers]
    public static int PIX_FMT_BGR444
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_BGR444;
      }
    }

    [Modifiers]
    public static int PIX_FMT_YUV420P16
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_YUV420P16;
      }
    }

    [Modifiers]
    public static int PIX_FMT_YUV422P16
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_YUV422P16;
      }
    }

    [Modifiers]
    public static int PIX_FMT_YUV444P16
    {
      [HideFromJava] get
      {
        return avutil.__\u003C\u003EPIX_FMT_YUV444P16;
      }
    }

    [LineNumberTable((ushort) 74)]
    static avutil()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 232, (byte) 162, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public avutil()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object av_d2q(double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_d2q\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_d2q\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_d2q", "(DI)Lcom/googlecode/javacv/cpp/avutil$AVRational;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        double num4 = d;
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double, int)>) avutil.__\u003Cjniptr\u003Eav_d2q\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B)((int) num2, (double) num3, (IntPtr) num4, (IntPtr) num5);
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
    public static object av_malloc(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_malloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_malloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_malloc", "(I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_malloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static void av_free(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_free\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_free\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_free", "(Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_free\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4);
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
    public static void av_freep(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_freep\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_freep\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_freep", "(Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_freep\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4);
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
    public static long av_rescale_q(long l, object avr1, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_rescale_q\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029J == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_rescale_q\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029J = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_rescale_q", "(JLcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, long, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_rescale_q\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029J)(num2, num3, num4, num5, num6);
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

    public static int AV_VERSION_INT(int a, int b, int c)
    {
      return a << 16 | b << 8 | c;
    }

    [LineNumberTable((ushort) 93)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string AV_VERSION(int a, int b, int c)
    {
      return avutil.AV_VERSION_DOT(a, b, c);
    }

    [LineNumberTable((ushort) 92)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string AV_VERSION_DOT(int a, int b, int c)
    {
      return new StringBuilder().append(a).append(".").append(b).append(".").append(c).toString();
    }

    [Modifiers]
    public static int av_find_nearest_q_idx(object avr1, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_find_nearest_q_idx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_find_nearest_q_idx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_find_nearest_q_idx", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_find_nearest_q_idx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I)(num2, num3, num4, num5);
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

    [LineNumberTable((ushort) 284)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool AV_HAVE_BIGENDIAN()
    {
      return ByteOrder.nativeOrder() == ByteOrder.BIG_ENDIAN;
    }

    [Modifiers]
    public static int avutil_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eavutil_version\u0028\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eavutil_version\u0028\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "avutil_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eavutil_version\u0028\u0029I)(num2, num3);
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
    public static string avutil_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eavutil_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eavutil_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "avutil_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eavutil_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static string avutil_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eavutil_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eavutil_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "avutil_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eavutil_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static object av_realloc(object p, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_realloc", "(Lcom/googlecode/javacpp/Pointer;I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_realloc\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object av_mallocz(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_mallocz\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_mallocz\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_mallocz", "(I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_mallocz\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static string av_strdup(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_strdup\u0028Ljava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_strdup\u0028Ljava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_strdup", "(Ljava/lang/String;)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_strdup\u0028Ljava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3, num4);
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
    public static int av_strerror(int i1, byte[] barr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_strerror\u0028I\u005BBI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_strerror\u0028I\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_strerror", "(I[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_strerror\u0028I\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static long av_gcd(long l1, long l2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_gcd\u0028JJ\u0029J == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_gcd\u0028JJ\u0029J = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_gcd", "(JJ)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l1;
        long num5 = l2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, long, long)>) avutil.__\u003Cjniptr\u003Eav_gcd\u0028JJ\u0029J)((long) num2, (long) num3, (IntPtr) num4, (IntPtr) num5);
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
    public static long av_rescale(long l1, long l2, long l3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_rescale\u0028JJJ\u0029J == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_rescale\u0028JJJ\u0029J = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_rescale", "(JJJ)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l1;
        long num5 = l2;
        long num6 = l3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, long, long, long)>) avutil.__\u003Cjniptr\u003Eav_rescale\u0028JJJ\u0029J)((long) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static long av_rescale_rnd(long l1, long l2, long l3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_rescale_rnd\u0028JJJI\u0029J == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_rescale_rnd\u0028JJJI\u0029J = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_rescale_rnd", "(JJJI)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l1;
        long num5 = l2;
        long num6 = l3;
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, long, long, long, int)>) avutil.__\u003Cjniptr\u003Eav_rescale_rnd\u0028JJJI\u0029J)((int) num2, (long) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int av_compare_ts(long l1, object avr1, long l2, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_compare_ts\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_compare_ts\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_compare_ts", "(JLcom/googlecode/javacv/cpp/avutil$AVRational;JLcom/googlecode/javacv/cpp/avutil$AVRational;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        long num6 = l2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, long, IntPtr, long, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_compare_ts\u0028JLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I)(num2, (long) num3, (IntPtr) num4, (long) num5, (IntPtr) num6, num7);
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

    [LineNumberTable((ushort) 182)]
    public static long av_cmp_q(object a, object b)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(a, __typeref (avutil), "com.googlecode.javacv.cpp.avutil$AVRational");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(b, __typeref (avutil), "com.googlecode.javacv.cpp.avutil$AVRational");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avutil$AVRational");
    }

    [LineNumberTable((ushort) 188)]
    public static double av_q2d(object a)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(a, __typeref (avutil), "com.googlecode.javacv.cpp.avutil$AVRational");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avutil$AVRational");
    }

    [Modifiers]
    public static int av_reduce(int[] iarr1, int[] iarr2, long l1, long l2, long l3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_reduce\u0028\u005BI\u005BIJJJ\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_reduce\u0028\u005BI\u005BIJJJ\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_reduce", "([I[IJJJ)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        long num6 = l1;
        long num7 = l2;
        long num8 = l3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, long, long, long)>) avutil.__\u003Cjniptr\u003Eav_reduce\u0028\u005BI\u005BIJJJ\u0029I)((long) num2, (long) num3, (long) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
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
    public static object av_mul_q(object avr1, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_mul_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_mul_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_mul_q", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)Lcom/googlecode/javacv/cpp/avutil$AVRational;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_mul_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B)(num2, num3, num4, num5);
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
    public static object av_div_q(object avr1, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_div_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_div_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_div_q", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)Lcom/googlecode/javacv/cpp/avutil$AVRational;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_div_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B)(num2, num3, num4, num5);
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
    public static object av_add_q(object avr1, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_add_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_add_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_add_q", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)Lcom/googlecode/javacv/cpp/avutil$AVRational;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_add_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B)(num2, num3, num4, num5);
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
    public static object av_sub_q(object avr1, object avr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sub_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sub_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sub_q", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)Lcom/googlecode/javacv/cpp/avutil$AVRational;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_sub_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B)(num2, num3, num4, num5);
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
    public static int av_nearer_q(object avr1, object avr2, object avr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_nearer_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_nearer_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_nearer_q", "(Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;Lcom/googlecode/javacv/cpp/avutil$AVRational;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_nearer_q\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVRational\u003B\u0029I)(num2, num3, num4, num5, num6);
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

    [LineNumberTable((ushort) 199)]
    public static int av_find_nearest_q_idx(object q, object q_list)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(q, __typeref (avutil), "com.googlecode.javacv.cpp.avutil$AVRational");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(q_list, __typeref (avutil), "[Lcom.googlecode.javacv.cpp.avutil$AVRational;");
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.avutil$AVRational;");
    }

    [Modifiers]
    public static double av_int2dbl(long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_int2dbl\u0028J\u0029D == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_int2dbl\u0028J\u0029D = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_int2dbl", "(J)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, long)>) avutil.__\u003Cjniptr\u003Eav_int2dbl\u0028J\u0029D)((long) num2, num3, (IntPtr) num4);
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
    public static float av_int2flt(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_int2flt\u0028I\u0029F == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_int2flt\u0028I\u0029F = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_int2flt", "(I)F");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<float (IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_int2flt\u0028I\u0029F)((int) num2, num3, (IntPtr) num4);
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
    public static double av_ext2dbl(object avef)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_ext2dbl\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B\u0029D == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_ext2dbl\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B\u0029D = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_ext2dbl", "(Lcom/googlecode/javacv/cpp/avutil$AVExtFloat;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avef);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_ext2dbl\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B\u0029D)(num2, num3, num4);
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
    public static long av_dbl2int(double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_dbl2int\u0028D\u0029J == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_dbl2int\u0028D\u0029J = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_dbl2int", "(D)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        double num4 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, double)>) avutil.__\u003Cjniptr\u003Eav_dbl2int\u0028D\u0029J)((double) num2, num3, (IntPtr) num4);
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
    public static int av_flt2int(float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_flt2int\u0028F\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_flt2int\u0028F\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_flt2int", "(F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        double num4 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, float)>) avutil.__\u003Cjniptr\u003Eav_flt2int\u0028F\u0029I)((float) num2, num3, (IntPtr) num4);
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
    public static object av_dbl2ext(double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_dbl2ext\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_dbl2ext\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_dbl2ext", "(D)Lcom/googlecode/javacv/cpp/avutil$AVExtFloat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        double num4 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double)>) avutil.__\u003Cjniptr\u003Eav_dbl2ext\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVExtFloat\u003B)((double) num2, num3, (IntPtr) num4);
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
    public static void av_log(object p, int i, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_log", "(Lcom/googlecode/javacpp/Pointer;ILjava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
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
    public static void av_vlog(object p1, int i, string str, object p2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_vlog\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_vlog\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_vlog", "(Lcom/googlecode/javacpp/Pointer;ILjava/lang/String;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_vlog\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
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
    public static int av_log_get_level()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_log_get_level\u0028\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_log_get_level\u0028\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_log_get_level", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_log_get_level\u0028\u0029I)(num2, num3);
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
    public static void av_log_set_level(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_log_set_level\u0028I\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_log_set_level\u0028I\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_log_set_level", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_log_set_level\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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
    public static void av_log_set_callback(object lc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_log_set_callback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024LogCallback\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_log_set_callback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024LogCallback\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_log_set_callback", "(Lcom/googlecode/javacv/cpp/avutil$LogCallback;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(lc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_log_set_callback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024LogCallback\u003B\u0029V)(num2, num3, num4);
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
    public static void av_log_default_callback(object p1, int i, string str, object p2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_log_default_callback\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_log_default_callback\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_log_default_callback", "(Lcom/googlecode/javacpp/Pointer;ILjava/lang/String;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_log_default_callback\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
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
    public static long av_adler32_update(long l, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_adler32_update\u0028JLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029J == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_adler32_update\u0028JLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029J = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_adler32_update", "(JLcom/googlecode/javacpp/BytePointer;I)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        long num4 = l;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, long, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_adler32_update\u0028JLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029J)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int av_strstart(string str1, string str2, object pp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_strstart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_strstart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_strstart", "(Ljava/lang/String;Ljava/lang/String;Lcom/googlecode/javacpp/PointerPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_strstart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I)(num2, num3, num4, num5, num6);
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
    public static int av_stristart(string str1, string str2, object pp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_stristart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_stristart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_stristart", "(Ljava/lang/String;Ljava/lang/String;Lcom/googlecode/javacpp/PointerPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_stristart\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I)(num2, num3, num4, num5, num6);
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
    public static string av_stristr(string str1, string str2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_stristr\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_stristr\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_stristr", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num6 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_stristr\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3, num4, num5);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num6);
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
    public static int av_strlcpy(byte[] barr, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_strlcpy\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_strlcpy\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_strlcpy", "([BLjava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_strlcpy\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int av_strlcat(byte[] barr, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_strlcat\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_strlcat\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_strlcat", "([BLjava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_strlcat\u0028\u005BBLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int av_strlcatf(byte[] barr, int i, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_strlcatf\u0028\u005BBILjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_strlcatf\u0028\u005BBILjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_strlcatf", "([BILjava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_strlcatf\u0028\u005BBILjava\u002Flang\u002FString\u003B\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
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
    public static string av_d2str(double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_d2str\u0028D\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_d2str\u0028D\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_d2str", "(D)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        double num4 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double)>) avutil.__\u003Cjniptr\u003Eav_d2str\u0028D\u0029Ljava\u002Flang\u002FString\u003B)((double) num2, num3, (IntPtr) num4);
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
    public static int av_base64_decode(byte[] barr1, byte[] barr2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028\u005BB\u005BBI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028\u005BB\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_base64_decode", "([B[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028\u005BB\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int av_base64_decode(ByteBuffer bb1, ByteBuffer bb2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_base64_decode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) bb1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int av_base64_decode(object bp1, object bp2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_base64_decode", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_base64_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static string av_base64_encode(byte[] barr1, int i1, byte[] barr2, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028\u005BBI\u005BBI\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028\u005BBI\u005BBI\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_base64_encode", "([BI[BI)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num8 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028\u005BBI\u005BBI\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num8);
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
    public static string av_base64_encode(ByteBuffer bb1, int i1, ByteBuffer bb2, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BILjava\u002Fnio\u002FByteBuffer\u003BI\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BILjava\u002Fnio\u002FByteBuffer\u003BI\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_base64_encode", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) bb1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) bb2);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num8 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028Ljava\u002Fnio\u002FByteBuffer\u003BILjava\u002Fnio\u002FByteBuffer\u003BI\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num8);
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
    public static string av_base64_encode(object bp1, int i1, object bp2, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_base64_encode", "(Lcom/googlecode/javacpp/BytePointer;ILcom/googlecode/javacpp/BytePointer;I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num8 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_base64_encode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num8);
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
    public static int av_crc_init(int[] iarr, int i1, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_crc_init\u0028\u005BIIIII\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_crc_init\u0028\u005BIIIII\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_crc_init", "([IIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, int)>) avutil.__\u003Cjniptr\u003Eav_crc_init\u0028\u005BIIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
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
    public static object av_crc_get_table(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_crc_get_table\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_crc_get_table\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_crc_get_table", "(I)Lcom/googlecode/javacpp/IntPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_crc_get_table\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static int av_crc(int[] iarr, int i1, object bp, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_crc\u0028\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_crc\u0028\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_crc", "([IILcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_crc\u0028\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static object av_fifo_alloc(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_alloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_alloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_alloc", "(I)Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_fifo_alloc\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static void av_fifo_free(object avfb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_free", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_fifo_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V)(num2, num3, num4);
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
    public static void av_fifo_reset(object avfb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_reset", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_fifo_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029V)(num2, num3, num4);
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
    public static int av_fifo_size(object avfb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_size", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_fifo_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I)(num2, num3, num4);
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
    public static int av_fifo_space(object avfb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_space\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_space\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_space", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_fifo_space\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003B\u0029I)(num2, num3, num4);
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
    public static int av_fifo_generic_read(object avfb, object p, int i, object f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_generic_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_read\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_generic_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_read\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_generic_read", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/avutil$Func_read;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(f);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_fifo_generic_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_read\u003B\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
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
    public static int av_fifo_generic_write(object avfb, object p, int i, object f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_generic_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_write\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_generic_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_write\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_generic_write", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/avutil$Func_write;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(f);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_fifo_generic_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024Func_write\u003B\u0029I)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
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
    public static int av_fifo_realloc2(object avfb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_realloc2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_realloc2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_realloc2", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_fifo_realloc2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void av_fifo_drain(object avfb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_drain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_drain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_drain", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_fifo_drain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static byte av_fifo_peek(object avfb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_fifo_peek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_fifo_peek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_fifo_peek", "(Lcom/googlecode/javacv/cpp/avutil$AVFifoBuffer;I)B");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfb);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<byte (IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_fifo_peek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVFifoBuffer\u003BI\u0029B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int av_lzo1x_decode(object p1, int[] iarr1, object p2, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_lzo1x_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BI\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_lzo1x_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_lzo1x_decode", "(Lcom/googlecode/javacpp/Pointer;[ILcom/googlecode/javacpp/Pointer;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_lzo1x_decode\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BI\u0029I)(num2, num3, num4, num5, num6, num7);
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
    public static void av_memcpy_backptr(object bp, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_memcpy_backptr\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_memcpy_backptr\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_memcpy_backptr", "(Lcom/googlecode/javacpp/BytePointer;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) avutil.__\u003Cjniptr\u003Eav_memcpy_backptr\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static int av_md5_size()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_size\u0028\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_size\u0028\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_size", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_md5_size\u0028\u0029I)(num2, num3);
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
    public static void av_md5_init(object avmd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_init", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_md5_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u0029V)(num2, num3, num4);
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
    public static void av_md5_update(object avmd, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BBI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BBI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_update", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;[BI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BBI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_md5_update(object avmd, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_update", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;Ljava/nio/ByteBuffer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_md5_update(object avmd, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_update", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;Lcom/googlecode/javacpp/BytePointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_md5_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_md5_final(object avmd, byte[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BB\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BB\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_final", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;[B)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003B\u005BB\u0029V)(num2, num3, num4, num5);
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
    public static void av_md5_final(object avmd, ByteBuffer bb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_final", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;Ljava/nio/ByteBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLjava\u002Fnio\u002FByteBuffer\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void av_md5_final(object avmd, object bp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_final", "(Lcom/googlecode/javacv/cpp/avutil$AVMD5;Lcom/googlecode/javacpp/BytePointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avmd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_md5_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVMD5\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void av_md5_sum(byte[] barr1, byte[] barr2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028\u005BB\u005BBI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028\u005BB\u005BBI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_sum", "([B[BI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028\u005BB\u005BBI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_md5_sum(ByteBuffer bb1, ByteBuffer bb2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_sum", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) bb1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028Ljava\u002Fnio\u002FByteBuffer\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_md5_sum(object bp1, object bp2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_md5_sum", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_md5_sum\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static object av_pix_fmt_descriptors()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_pix_fmt_descriptors\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_pix_fmt_descriptors\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_pix_fmt_descriptors", "()Lcom/googlecode/javacv/cpp/avutil$AVPixFmtDescriptor;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_pix_fmt_descriptors\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B)(num2, num3);
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
    public static int av_get_pix_fmt(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_get_pix_fmt\u0028Ljava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_get_pix_fmt\u0028Ljava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_get_pix_fmt", "(Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_get_pix_fmt\u0028Ljava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4);
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
    public static int av_get_bits_per_pixel(object avpfd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_get_bits_per_pixel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_get_bits_per_pixel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_get_bits_per_pixel", "(Lcom/googlecode/javacv/cpp/avutil$AVPixFmtDescriptor;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avpfd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_get_bits_per_pixel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVPixFmtDescriptor\u003B\u0029I)(num2, num3, num4);
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
    public static int av_sha1_size()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sha1_size\u0028\u0029I == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sha1_size\u0028\u0029I = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sha1_size", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_sha1_size\u0028\u0029I)(num2, num3);
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
    public static void av_sha1_init(object avsha)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sha1_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sha1_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sha1_init", "(Lcom/googlecode/javacv/cpp/avutil$AVSHA1;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avsha);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_sha1_init\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u0029V)(num2, num3, num4);
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
    public static void av_sha1_update(object avsha, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BBI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BBI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sha1_update", "(Lcom/googlecode/javacv/cpp/avutil$AVSHA1;[BI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avsha);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BBI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_sha1_update(object avsha, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sha1_update", "(Lcom/googlecode/javacv/cpp/avutil$AVSHA1;Ljava/nio/ByteBuffer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avsha);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_sha1_update(object avsha, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sha1_update", "(Lcom/googlecode/javacv/cpp/avutil$AVSHA1;Lcom/googlecode/javacpp/BytePointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avsha);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avutil.__\u003Cjniptr\u003Eav_sha1_update\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_sha1_final(object avsha, byte[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avutil.__\u003Cjniptr\u003Eav_sha1_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BB\u0029V == IntPtr.Zero)
        avutil.__\u003Cjniptr\u003Eav_sha1_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BB\u0029V = JNI.Frame.GetFuncPtr(avutil.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avutil", "av_sha1_final", "(Lcom/googlecode/javacv/cpp/avutil$AVSHA1;[B)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avutil.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avutil>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avsha);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avutil.__\u003Cjniptr\u003Eav_sha1_final\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVSHA1\u003B\u005BB\u0029V)(num2, num3, num4, num5);
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
      if (avutil.__\u003CcallerID\u003E == null)
        avutil.__\u003CcallerID\u003E = (CallerID) new avutil.__\u003CCallerID\u003E();
      return avutil.__\u003CcallerID\u003E;
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
