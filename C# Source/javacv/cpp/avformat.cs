// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.avformat
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
  public class avformat : Object
  {
    public const int LIBAVFORMAT_VERSION_MAJOR = 52;
    public const int LIBAVFORMAT_VERSION_MINOR = 64;
    public const int LIBAVFORMAT_VERSION_MICRO = 2;
    internal static int __\u003C\u003ELIBAVFORMAT_VERSION_INT;
    internal static string __\u003C\u003ELIBAVFORMAT_VERSION;
    internal static int __\u003C\u003ELIBAVFORMAT_BUILD;
    internal static string __\u003C\u003ELIBAVFORMAT_IDENT;
    public const int URL_RDONLY = 0;
    public const int URL_WRONLY = 1;
    public const int URL_RDWR = 2;
    public const int AVSEEK_SIZE = 65536;
    public const int AVSEEK_FORCE = 131072;
    public const int URL_EOF = -1;
    public const int AV_METADATA_MATCH_CASE = 1;
    public const int AV_METADATA_IGNORE_SUFFIX = 2;
    public const int AV_METADATA_DONT_STRDUP_KEY = 4;
    public const int AV_METADATA_DONT_STRDUP_VAL = 8;
    public const int AV_METADATA_DONT_OVERWRITE = 16;
    public const int AVPROBE_SCORE_MAX = 100;
    public const int AVPROBE_PADDING_SIZE = 32;
    public const int AVFMT_NOFILE = 1;
    public const int AVFMT_NEEDNUMBER = 2;
    public const int AVFMT_SHOW_IDS = 8;
    public const int AVFMT_RAWPICTURE = 32;
    public const int AVFMT_GLOBALHEADER = 64;
    public const int AVFMT_NOTIMESTAMPS = 128;
    public const int AVFMT_GENERIC_INDEX = 256;
    public const int AVFMT_TS_DISCONT = 512;
    public const int AVFMT_VARIABLE_FPS = 1024;
    public const int AVFMT_NODIMENSIONS = 2048;
    public const int AVSTREAM_PARSE_NONE = 0;
    public const int AVSTREAM_PARSE_FULL = 1;
    public const int AVSTREAM_PARSE_HEADERS = 2;
    public const int AVSTREAM_PARSE_TIMESTAMPS = 3;
    public const int AV_DISPOSITION_DEFAULT = 1;
    public const int AV_DISPOSITION_DUB = 2;
    public const int AV_DISPOSITION_ORIGINAL = 4;
    public const int AV_DISPOSITION_COMMENT = 8;
    public const int AV_DISPOSITION_LYRICS = 16;
    public const int AV_DISPOSITION_KARAOKE = 32;
    public const int AV_PROGRAM_RUNNING = 1;
    public const int AVFMTCTX_NOHEADER = 1;
    public const int MAX_STREAMS = 20;
    public const int AVSEEK_FLAG_BACKWARD = 1;
    public const int AVSEEK_FLAG_BYTE = 2;
    public const int AVSEEK_FLAG_ANY = 4;
    public const int AVSEEK_FLAG_FRAME = 8;
    public const int FFM_PACKET_SIZE = 4096;
    static IntPtr __\u003Cjniptr\u003Eavformat_version\u0028\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eavformat_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavformat_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eurl_open_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003BLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BJI\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_exist\u0028Ljava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_filesize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_get_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_get_filename\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eurl_set_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_url_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_url_read_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BIJI\u0029J;
    static IntPtr __\u003Cjniptr\u003Efirst_protocol\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B;
    static IntPtr __\u003Cjniptr\u003Efirst_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eurl_interrupt_cb\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B;
    static IntPtr __\u003Cjniptr\u003Eurl_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_protocol_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_register_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Einit_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_alloc_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eput_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eput_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eurl_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJI\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_fskip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V;
    static IntPtr __\u003Cjniptr\u003Eurl_ftell\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_fsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_feof\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_ferror\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_url_read_fpause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_url_read_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BIJI\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_fgetc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_fprintf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_fgets\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eput_flush_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eget_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eget_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eurl_fdopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_setbufsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_resetbuf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_fopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_fclose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eurl_fget_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_close_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_open_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_open_dyn_packet_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eurl_close_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eget_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Einit_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Update_checksum\u003BJ\u0029V;
    static IntPtr __\u003Cjniptr\u003Eudp_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_metadata_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_metadata_set2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_metadata_conv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_metadata_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_get_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Efirst_iformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Efirst_iformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Efirst_oformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Efirst_oformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_iformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_oformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_guess_image2_codec\u0028Ljava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_register_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_register_output_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_guess_format\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_guess_codec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_hex_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_hex_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_pkt_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_pkt_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_register_all\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_codec_get_id\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_codec_get_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_find_input_format\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_probe_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProbeData\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_open_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_open_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavformat_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_find_stream_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_read_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_read_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_seek_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavformat_seek_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_read_play\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_close_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_close_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_new_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_new_program\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProgram\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_set_pts_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_find_default_stream_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_index_search_timestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_add_index_entry\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJJIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_seek_frame_binary\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_update_cur_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJ\u0029V;
    static IntPtr __\u003Cjniptr\u003Eav_gen_search\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJJJJI\u005BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u0024Read_timestamp\u003B\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_set_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_write_header\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_interleaved_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_interleave_packet_per_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_write_trailer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edump_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BILjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Eparse_date\u0028Ljava\u002Flang\u002FString\u003BI\u0029J;
    static IntPtr __\u003Cjniptr\u003Eav_gettime\u0028\u0029J;
    static IntPtr __\u003Cjniptr\u003Effm_read_write_index\u0028I\u0029J;
    static IntPtr __\u003Cjniptr\u003Effm_write_write_index\u0028IJ\u0029I;
    static IntPtr __\u003Cjniptr\u003Effm_set_write_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BJJ\u0029V;
    static IntPtr __\u003Cjniptr\u003Efind_info_tag\u0028\u005BBILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_get_frame_filename\u0028\u005BBILjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_filename_number_test\u0028Ljava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavf_sdp_create\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BBI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eav_match_ext\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I;

    [Modifiers]
    public static int LIBAVFORMAT_VERSION_INT
    {
      [HideFromJava] get
      {
        return avformat.__\u003C\u003ELIBAVFORMAT_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBAVFORMAT_VERSION
    {
      [HideFromJava] get
      {
        return avformat.__\u003C\u003ELIBAVFORMAT_VERSION;
      }
    }

    [Modifiers]
    public static int LIBAVFORMAT_BUILD
    {
      [HideFromJava] get
      {
        return avformat.__\u003C\u003ELIBAVFORMAT_BUILD;
      }
    }

    [Modifiers]
    public static string LIBAVFORMAT_IDENT
    {
      [HideFromJava] get
      {
        return avformat.__\u003C\u003ELIBAVFORMAT_IDENT;
      }
    }

    [LineNumberTable((ushort) 75)]
    static avformat()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<avcodec>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 232, (byte) 164, (byte) 26})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public avformat()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void av_register_all()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_register_all\u0028\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_register_all\u0028\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_register_all", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_register_all\u0028\u0029V)(num2, num3);
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
    public static object av_find_input_format(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_find_input_format\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_find_input_format\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_find_input_format", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_find_input_format\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B)(num2, num3, num4);
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
    public static int av_open_input_file(object avfc, string str, object avif, int i, object avfp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_open_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_open_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_open_input_file", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;ILcom/googlecode/javacv/cpp/avformat$AVFormatParameters;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avif);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(avfp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_open_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
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
    public static int av_find_stream_info(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_find_stream_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_find_stream_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_find_stream_info", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_find_stream_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I)(num2, num3, num4);
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
    public static void dump_format(object avfc, int i1, string str, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Edump_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BILjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Edump_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BILjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "dump_format", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;ILjava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avformat.__\u003Cjniptr\u003Edump_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BILjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static void av_close_input_file(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_close_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_close_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_close_input_file", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_close_input_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V)(num2, num3, num4);
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
    public static int av_read_frame(object avfc, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_read_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_read_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_read_frame", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_read_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5);
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
    public static object av_guess_format(string str1, string str2, string str3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_guess_format\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_guess_format\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_guess_format", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_guess_format\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B)(num2, num3, num4, num5, num6);
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
    public static object avformat_alloc_context()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eavformat_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eavformat_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "avformat_alloc_context", "()Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eavformat_alloc_context\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B)(num2, num3);
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
    public static object av_new_stream(object avfc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_new_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_new_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_new_stream", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;I)Lcom/googlecode/javacv/cpp/avformat$AVStream;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_new_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int av_set_parameters(object avfc, object avfp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_set_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_set_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_set_parameters", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avformat$AVFormatParameters;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avfp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_set_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I)(num2, num3, num4, num5);
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
    public static int url_fopen(object bioc, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fopen", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_fopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int av_write_header(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_write_header\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_write_header\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_write_header", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_write_header\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I)(num2, num3, num4);
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
    public static int av_write_trailer(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_write_trailer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_write_trailer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_write_trailer", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_write_trailer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_fclose(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fclose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fclose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fclose", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fclose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int av_write_frame(object avfc, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_write_frame", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5);
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
    public static int avformat_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eavformat_version\u0028\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eavformat_version\u0028\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "avformat_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eavformat_version\u0028\u0029I)(num2, num3);
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
    public static string avformat_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eavformat_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eavformat_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "avformat_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eavformat_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static string avformat_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eavformat_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eavformat_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "avformat_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eavformat_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static int url_open_protocol(object urlc, object urlp, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003BLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003BLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open_protocol", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Lcom/googlecode/javacv/cpp/avformat$URLProtocol;Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(urlp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_open_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003BLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static int url_open(object urlc, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_read(object urlc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_read", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_read(object urlc, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_read", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Ljava/nio/ByteBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_read(object urlc, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_read", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_read\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_read_complete(object urlc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_read_complete", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_read_complete(object urlc, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_read_complete", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Ljava/nio/ByteBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_read_complete(object urlc, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_read_complete", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_read_complete\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_write(object urlc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_write", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_write(object urlc, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_write", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Ljava/nio/ByteBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int url_write(object urlc, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_write", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_write\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static long url_seek(object urlc, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BJI\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BJI\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_seek", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;JI)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, long, int)>) avformat.__\u003Cjniptr\u003Eurl_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BJI\u0029J)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static int url_close(object urlc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_close", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_close\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_exist(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_exist\u0028Ljava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_exist\u0028Ljava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_exist", "(Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_exist\u0028Ljava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4);
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
    public static long url_filesize(object urlc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_filesize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_filesize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_filesize", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_filesize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029J)(num2, num3, num4);
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
    public static int url_get_file_handle(object urlc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_get_file_handle", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_get_max_packet_size(object urlc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_get_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_get_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_get_max_packet_size", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_get_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I)(num2, num3, num4);
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
    public static void url_get_filename(object urlc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_get_filename\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_get_filename\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_get_filename", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;[BI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_get_filename\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u005BBI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void url_set_interrupt_cb(object urlicb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_set_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_set_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_set_interrupt_cb", "(Lcom/googlecode/javacv/cpp/avformat$URLInterruptCB;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlicb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_set_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V)(num2, num3, num4);
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
    public static int av_url_read_pause(object urlc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_url_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_url_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_url_read_pause", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_url_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static long av_url_read_seek(object urlc, int i1, long l, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_url_read_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BIJI\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_url_read_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BIJI\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_url_read_seek", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;IJI)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        int num5 = i1;
        long num6 = l;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, int, long, int)>) avformat.__\u003Cjniptr\u003Eav_url_read_seek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003BIJI\u0029J)((int) num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static object first_protocol()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efirst_protocol\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efirst_protocol\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "first_protocol", "()Lcom/googlecode/javacv/cpp/avformat$URLProtocol;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efirst_protocol\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B)(num2, num3);
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
    public static void first_protocol(object urlp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efirst_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efirst_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "first_protocol", "(Lcom/googlecode/javacv/cpp/avformat$URLProtocol;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efirst_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029V)(num2, num3, num4);
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
    public static object url_interrupt_cb()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_interrupt_cb\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_interrupt_cb\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_interrupt_cb", "()Lcom/googlecode/javacv/cpp/avformat$URLInterruptCB;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_interrupt_cb\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B)(num2, num3);
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
    public static void url_interrupt_cb(object urlicb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_interrupt_cb", "(Lcom/googlecode/javacv/cpp/avformat$URLInterruptCB;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlicb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_interrupt_cb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLInterruptCB\u003B\u0029V)(num2, num3, num4);
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
    public static object av_protocol_next(object urlp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_protocol_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_protocol_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_protocol_next", "(Lcom/googlecode/javacv/cpp/avformat$URLProtocol;)Lcom/googlecode/javacv/cpp/avformat$URLProtocol;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_protocol_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B)(num2, num3, num4);
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
    public static int av_register_protocol(object urlp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_register_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_register_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_register_protocol", "(Lcom/googlecode/javacv/cpp/avformat$URLProtocol;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_register_protocol\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLProtocol\u003B\u0029I)(num2, num3, num4);
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
    public static int init_put_byte(object bioc, object bp, int i1, int i2, object p, object biocr, object biocw, object biocs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Einit_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Einit_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "init_put_byte", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacpp/BytePointer;IILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Read_packet;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Write_packet;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Seek;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(biocr);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(biocw);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(biocs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Einit_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11);
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
    public static object av_alloc_put_byte(object bp, int i1, int i2, object p, object biocr, object biocw, object biocs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_alloc_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_alloc_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_alloc_put_byte", "(Lcom/googlecode/javacpp/BytePointer;IILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Read_packet;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Write_packet;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Seek;)Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(biocr);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(biocw);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(biocs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_alloc_put_byte\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Read_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Write_packet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Seek\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B)(num2, num3, num4, (IntPtr) num5, num6, (int) num7, num8, num9, num10);
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
    public static void put_byte(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_byte", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_buffer(object bioc, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacpp/BytePointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void put_le64(object bioc, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_le64", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;J)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, long)>) avformat.__\u003Cjniptr\u003Eput_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V)((long) num2, num3, num4, (IntPtr) num5);
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
    public static void put_be64(object bioc, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_be64", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;J)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, long)>) avformat.__\u003Cjniptr\u003Eput_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V)((long) num2, num3, num4, (IntPtr) num5);
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
    public static void put_le32(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_le32", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_be32(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_be32", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_le24(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_le24", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_be24(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_be24", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_le16(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_le16", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_be16(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_be16", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eput_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void put_tag(object bioc, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_tag", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eput_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void put_strz(object bioc, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_strz", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eput_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4, num5);
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
    public static long url_fseek(object bioc, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJI\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJI\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fseek", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;JI)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, long, int)>) avformat.__\u003Cjniptr\u003Eurl_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJI\u0029J)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static void url_fskip(object bioc, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fskip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fskip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fskip", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;J)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, long)>) avformat.__\u003Cjniptr\u003Eurl_fskip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BJ\u0029V)((long) num2, num3, num4, (IntPtr) num5);
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
    public static long url_ftell(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_ftell\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_ftell\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_ftell", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_ftell\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J)(num2, num3, num4);
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
    public static long url_fsize(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fsize", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J)(num2, num3, num4);
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
    public static int url_feof(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_feof\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_feof\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_feof", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_feof\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_ferror(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_ferror\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_ferror\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_ferror", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_ferror\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int av_url_read_fpause(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_url_read_fpause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_url_read_fpause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_url_read_fpause", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_url_read_fpause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static long av_url_read_fseek(object bioc, int i1, long l, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_url_read_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BIJI\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_url_read_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BIJI\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_url_read_fseek", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;IJI)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i1;
        long num6 = l;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, int, long, int)>) avformat.__\u003Cjniptr\u003Eav_url_read_fseek\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BIJI\u0029J)((int) num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int url_fgetc(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fgetc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fgetc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fgetc", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fgetc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_fprintf(object bioc, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fprintf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fprintf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fprintf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fprintf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4, num5);
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
    public static string url_fgets(object bioc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fgets\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fgets\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fgets", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;[BI)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num7 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_fgets\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num7);
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
    public static void put_flush_packet(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eput_flush_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eput_flush_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "put_flush_packet", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eput_flush_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029V)(num2, num3, num4);
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
    public static int get_buffer(object bioc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int get_buffer(object bioc, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/nio/ByteBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int get_buffer(object bioc, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int get_partial_buffer(object bioc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_partial_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int get_partial_buffer(object bioc, ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_partial_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/nio/ByteBuffer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int get_partial_buffer(object bioc, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_partial_buffer", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_partial_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int get_byte(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_byte", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_byte\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int get_le24(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_le24", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_le24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int get_le32(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_le32", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_le32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static long get_le64(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_le64", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_le64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J)(num2, num3, num4);
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
    public static int get_le16(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_le16", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_le16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static string get_strz(object bioc, byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_strz", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;[BI)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num7 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eget_strz\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBI\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num7);
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
    public static int get_be16(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_be16", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_be16\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int get_be24(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_be24", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_be24\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int get_be32(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_be32", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_be32\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static long get_be64(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_be64", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_be64\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J)(num2, num3, num4);
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

    [LineNumberTable((ushort) 422)]
    public static bool url_is_streamed(object s)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(s, __typeref (avformat), "com.googlecode.javacv.cpp.avformat$ByteIOContext");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$ByteIOContext");
    }

    [Modifiers]
    public static int url_fdopen(object bioc, object urlc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fdopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fdopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fdopen", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacv/cpp/avformat$URLContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fdopen\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I)(num2, num3, num4, num5);
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
    public static int url_setbufsize(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_setbufsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_setbufsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_setbufsize", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_setbufsize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int url_resetbuf(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_resetbuf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_resetbuf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_resetbuf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_resetbuf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object url_fileno(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fileno", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)Lcom/googlecode/javacv/cpp/avformat$URLContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B)(num2, num3, num4);
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
    public static int url_fget_max_packet_size(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_fget_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_fget_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_fget_max_packet_size", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_fget_max_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_open_buf(object bioc, byte[] barr, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBII\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBII\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;[BII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u005BBII\u0029I)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int url_open_buf(object bioc, ByteBuffer bb, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BII\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BII\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/nio/ByteBuffer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Fnio\u002FByteBuffer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int url_open_buf(object bioc, object bp, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacpp/BytePointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avformat.__\u003Cjniptr\u003Eurl_open_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int url_close_buf(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_close_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_close_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_close_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_close_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_open_dyn_buf(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open_dyn_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_open_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029I)(num2, num3, num4);
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
    public static int url_open_dyn_packet_buf(object bioc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_open_dyn_packet_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_open_dyn_packet_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_open_dyn_packet_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eurl_open_dyn_packet_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int url_close_dyn_buf(object bioc, object pp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eurl_close_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eurl_close_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "url_close_dyn_buf", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacpp/PointerPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eurl_close_dyn_buf\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I)(num2, num3, num4, num5);
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
    public static long get_checksum(object bioc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eget_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eget_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "get_checksum", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eget_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003B\u0029J)(num2, num3, num4);
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
    public static void init_checksum(object bioc, object biocu, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Einit_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Update_checksum\u003BJ\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Einit_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Update_checksum\u003BJ\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "init_checksum", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext$Update_checksum;J)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(biocu);
        long num6 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, long)>) avformat.__\u003Cjniptr\u003Einit_checksum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u0024Update_checksum\u003BJ\u0029V)((long) num2, num3, num4, num5, (IntPtr) num6);
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
    public static int udp_get_file_handle(object urlc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eudp_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eudp_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "udp_get_file_handle", "(Lcom/googlecode/javacv/cpp/avformat$URLContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(urlc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eudp_get_file_handle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024URLContext\u003B\u0029I)(num2, num3, num4);
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
    public static object av_metadata_get(object avm, string str, object avmt, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_metadata_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_metadata_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_metadata_get", "(Lcom/googlecode/javacv/cpp/avformat$AVMetadata;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avformat$AVMetadataTag;I)Lcom/googlecode/javacv/cpp/avformat$AVMetadataTag;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avm);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avmt);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_metadata_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataTag\u003B)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static int av_metadata_set2(object avm, string str1, string str2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_metadata_set2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_metadata_set2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_metadata_set2", "(Lcom/googlecode/javacv/cpp/avformat$AVMetadata;Ljava/lang/String;Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avm);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_metadata_set2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static void av_metadata_conv(object avfc, object avmc1, object avmc2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_metadata_conv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_metadata_conv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_metadata_conv", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avformat$AVMetadataConv;Lcom/googlecode/javacv/cpp/avformat$AVMetadataConv;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avmc1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avmc2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_metadata_conv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadataConv\u003B\u0029V)(num2, num3, num4, num5, num6);
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
    public static void av_metadata_free(object avm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_metadata_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_metadata_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_metadata_free", "(Lcom/googlecode/javacv/cpp/avformat$AVMetadata;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_metadata_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVMetadata\u003B\u0029V)(num2, num3, num4);
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
    public static int av_get_packet(object bioc, object avp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_get_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_get_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_get_packet", "(Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_get_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static object first_iformat()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efirst_iformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efirst_iformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "first_iformat", "()Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efirst_iformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B)(num2, num3);
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
    public static void first_iformat(object avif)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efirst_iformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efirst_iformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "first_iformat", "(Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avif);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efirst_iformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V)(num2, num3, num4);
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
    public static object first_oformat()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efirst_oformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efirst_oformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "first_oformat", "()Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efirst_oformat\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B)(num2, num3);
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
    public static void first_oformat(object avof)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efirst_oformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efirst_oformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "first_oformat", "(Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avof);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efirst_oformat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V)(num2, num3, num4);
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
    public static object av_iformat_next(object avif)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_iformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_iformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_iformat_next", "(Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;)Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avif);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_iformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B)(num2, num3, num4);
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
    public static object av_oformat_next(object avof)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_oformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_oformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_oformat_next", "(Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;)Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avof);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_oformat_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B)(num2, num3, num4);
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
    public static int av_guess_image2_codec(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_guess_image2_codec\u0028Ljava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_guess_image2_codec\u0028Ljava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_guess_image2_codec", "(Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_guess_image2_codec\u0028Ljava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4);
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
    public static void av_register_input_format(object avif)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_register_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_register_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_register_input_format", "(Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avif);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_register_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B\u0029V)(num2, num3, num4);
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
    public static void av_register_output_format(object avof)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_register_output_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_register_output_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_register_output_format", "(Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avof);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_register_output_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003B\u0029V)(num2, num3, num4);
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
    public static int av_guess_codec(object avof, string str1, string str2, string str3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_guess_codec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_guess_codec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_guess_codec", "(Lcom/googlecode/javacv/cpp/avformat$AVOutputFormat;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avof);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_guess_codec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVOutputFormat\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
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
    public static void av_hex_dump(object p, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_hex_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_hex_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_hex_dump", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/BytePointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_hex_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_hex_dump_log(object p, int i1, object bp, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_hex_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_hex_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_hex_dump_log", "(Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacpp/BytePointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_hex_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029V)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static void av_pkt_dump(object p, object avp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_pkt_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_pkt_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_pkt_dump", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_pkt_dump\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void av_pkt_dump_log(object p, int i1, object avp, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_pkt_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_pkt_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_pkt_dump_log", "(Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/avcodec$AVPacket;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_pkt_dump_log\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029V)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static int av_codec_get_id(object avct, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_codec_get_id\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_codec_get_id\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_codec_get_id", "(Lcom/googlecode/javacv/cpp/avformat$AVCodecTag;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avct);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_codec_get_id\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int av_codec_get_tag(object avct, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_codec_get_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_codec_get_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_codec_get_tag", "(Lcom/googlecode/javacv/cpp/avformat$AVCodecTag;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avct);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_codec_get_tag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVCodecTag\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object av_probe_input_format(object avpd, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_probe_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProbeData\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_probe_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProbeData\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_probe_input_format", "(Lcom/googlecode/javacv/cpp/avformat$AVProbeData;I)Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avpd);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_probe_input_format\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProbeData\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int av_open_input_stream(object avfc, object bioc, string str, object avif, object avfp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_open_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_open_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_open_input_stream", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avformat$ByteIOContext;Ljava/lang/String;Lcom/googlecode/javacv/cpp/avformat$AVInputFormat;Lcom/googlecode/javacv/cpp/avformat$AVFormatParameters;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bioc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avif);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(avfp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_open_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024ByteIOContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatParameters\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8);
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
    public static int av_read_packet(object avfc, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_read_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_read_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_read_packet", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_read_packet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5);
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
    public static int av_seek_frame(object avfc, int i1, long l, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_seek_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_seek_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_seek_frame", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;IJI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i1;
        long num6 = l;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, int)>) avformat.__\u003Cjniptr\u003Eav_seek_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I)((int) num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int avformat_seek_file(object avfc, int i1, long l1, long l2, long l3, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eavformat_seek_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eavformat_seek_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "avformat_seek_file", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;IJJJI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i1;
        long num6 = l1;
        long num7 = l2;
        long num8 = l3;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, long, long, int)>) avformat.__\u003Cjniptr\u003Eavformat_seek_file\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJI\u0029I)((int) num2, (long) num3, (long) num4, (long) num5, (int) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
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
    public static int av_read_play(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_read_play\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_read_play\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_read_play", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_read_play\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I)(num2, num3, num4);
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
    public static int av_read_pause(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_read_pause", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_read_pause\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I)(num2, num3, num4);
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
    public static void av_close_input_stream(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_close_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_close_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_close_input_stream", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_close_input_stream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029V)(num2, num3, num4);
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
    public static object av_new_program(object avfc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_new_program\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProgram\u003B == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_new_program\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProgram\u003B = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_new_program", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;I)Lcom/googlecode/javacv/cpp/avformat$AVProgram;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_new_program\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVProgram\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void av_set_pts_info(object avs, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_set_pts_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BIII\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_set_pts_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BIII\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_set_pts_info", "(Lcom/googlecode/javacv/cpp/avformat$AVStream;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avs);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, int)>) avformat.__\u003Cjniptr\u003Eav_set_pts_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int av_find_default_stream_index(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_find_default_stream_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_find_default_stream_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_find_default_stream_index", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_find_default_stream_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003B\u0029I)(num2, num3, num4);
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
    public static int av_index_search_timestamp(object avs, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_index_search_timestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_index_search_timestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_index_search_timestamp", "(Lcom/googlecode/javacv/cpp/avformat$AVStream;JI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avs);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, int)>) avformat.__\u003Cjniptr\u003Eav_index_search_timestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJI\u0029I)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static int av_add_index_entry(object avs, long l1, long l2, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_add_index_entry\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJJIII\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_add_index_entry\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJJIII\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_add_index_entry", "(Lcom/googlecode/javacv/cpp/avformat$AVStream;JJIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avs);
        long num5 = l1;
        long num6 = l2;
        int num7 = i1;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, long, int, int, int)>) avformat.__\u003Cjniptr\u003Eav_add_index_entry\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJJIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
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
    public static int av_seek_frame_binary(object avfc, int i1, long l, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_seek_frame_binary\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_seek_frame_binary\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_seek_frame_binary", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;IJI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i1;
        long num6 = l;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, int)>) avformat.__\u003Cjniptr\u003Eav_seek_frame_binary\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJI\u0029I)((int) num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void av_update_cur_dts(object avfc, object avs, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_update_cur_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJ\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_update_cur_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJ\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_update_cur_dts", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avformat$AVStream;J)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avs);
        long num6 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, long)>) avformat.__\u003Cjniptr\u003Eav_update_cur_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVStream\u003BJ\u0029V)((long) num2, num3, num4, num5, (IntPtr) num6);
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
    public static long av_gen_search(object avfc, int i1, long l1, long l2, long l3, long l4, long l5, long l6, int i2, long[] larr, object avifr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_gen_search\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJJJJI\u005BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u0024Read_timestamp\u003B\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_gen_search\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJJJJI\u005BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u0024Read_timestamp\u003B\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_gen_search", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;IJJJJJJI[JLcom/googlecode/javacv/cpp/avformat$AVInputFormat$Read_timestamp;)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i1;
        long num6 = l1;
        long num7 = l2;
        long num8 = l3;
        long num9 = l4;
        long num10 = l5;
        long num11 = l6;
        int num12 = i2;
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) larr);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef(avifr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, int, long, long, long, long, long, long, int, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_gen_search\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BIJJJJJJI\u005BJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVInputFormat\u0024Read_timestamp\u003B\u0029J)(num2, num3, (int) num4, (long) num5, num6, num7, num8, num9, num10, (int) num11, (IntPtr) num12, num13, num14);
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
    public static int av_interleaved_write_frame(object avfc, object avp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_interleaved_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_interleaved_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_interleaved_write_frame", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_interleaved_write_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003B\u0029I)(num2, num3, num4, num5);
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
    public static int av_interleave_packet_per_dts(object avfc, object avp1, object avp2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_interleave_packet_per_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_interleave_packet_per_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_interleave_packet_per_dts", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;Lcom/googlecode/javacv/cpp/avcodec$AVPacket;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avp2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_interleave_packet_per_dts\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favcodec\u0024AVPacket\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static long parse_date(string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eparse_date\u0028Ljava\u002Flang\u002FString\u003BI\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eparse_date\u0028Ljava\u002Flang\u002FString\u003BI\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "parse_date", "(Ljava/lang/String;I)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eparse_date\u0028Ljava\u002Flang\u002FString\u003BI\u0029J)((int) num2, num3, num4, (IntPtr) num5);
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
    public static long av_gettime()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_gettime\u0028\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_gettime\u0028\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_gettime", "()J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_gettime\u0028\u0029J)(num2, num3);
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
    public static long ffm_read_write_index(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Effm_read_write_index\u0028I\u0029J == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Effm_read_write_index\u0028I\u0029J = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "ffm_read_write_index", "(I)J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr, int)>) avformat.__\u003Cjniptr\u003Effm_read_write_index\u0028I\u0029J)((int) num2, num3, (IntPtr) num4);
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
    public static int ffm_write_write_index(int i, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Effm_write_write_index\u0028IJ\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Effm_write_write_index\u0028IJ\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "ffm_write_write_index", "(IJ)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        int num4 = i;
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, long)>) avformat.__\u003Cjniptr\u003Effm_write_write_index\u0028IJ\u0029I)((long) num2, (int) num3, (IntPtr) num4, (IntPtr) num5);
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
    public static void ffm_set_write_index(object avfc, long l1, long l2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Effm_set_write_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BJJ\u0029V == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Effm_set_write_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BJJ\u0029V = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "ffm_set_write_index", "(Lcom/googlecode/javacv/cpp/avformat$AVFormatContext;JJ)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        long num5 = l1;
        long num6 = l2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, long, long)>) avformat.__\u003Cjniptr\u003Effm_set_write_index\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favformat\u0024AVFormatContext\u003BJJ\u0029V)((long) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static int find_info_tag(byte[] barr, int i, string str1, string str2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Efind_info_tag\u0028\u005BBILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Efind_info_tag\u0028\u005BBILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "find_info_tag", "([BILjava/lang/String;Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Efind_info_tag\u0028\u005BBILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
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
    public static int av_get_frame_filename(byte[] barr, int i1, string str, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_get_frame_filename\u0028\u005BBILjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_get_frame_filename\u0028\u005BBILjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_get_frame_filename", "([BILjava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eav_get_frame_filename\u0028\u005BBILjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static int av_filename_number_test(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_filename_number_test\u0028Ljava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_filename_number_test\u0028Ljava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_filename_number_test", "(Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_filename_number_test\u0028Ljava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4);
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
    public static int avf_sdp_create(object pp, int i1, byte[] barr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eavf_sdp_create\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BBI\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eavf_sdp_create\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BBI\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "avf_sdp_create", "(Lcom/googlecode/javacpp/PointerPointer;I[BI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avformat.__\u003Cjniptr\u003Eavf_sdp_create\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BBI\u0029I)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static int av_match_ext(string str1, string str2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avformat.__\u003Cjniptr\u003Eav_match_ext\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        avformat.__\u003Cjniptr\u003Eav_match_ext\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(avformat.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avformat", "av_match_ext", "(Ljava/lang/String;Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avformat.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avformat>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) avformat.__\u003Cjniptr\u003Eav_match_ext\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4, num5);
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
      if (avformat.__\u003CcallerID\u003E == null)
        avformat.__\u003CcallerID\u003E = (CallerID) new avformat.__\u003CCallerID\u003E();
      return avformat.__\u003CcallerID\u003E;
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
