// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.dc1394
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
  public class dc1394 : Object
  {
    public const short POLLIN = (short) 1;
    public const short POLLPRI = (short) 2;
    public const short POLLOUT = (short) 4;
    public const short POLLMSG = (short) 1024;
    public const short POLLREMOVE = (short) 4096;
    public const short POLLRDHUP = (short) 8192;
    public const short POLLERR = (short) 8;
    public const short POLLHUP = (short) 16;
    public const short POLLNVAL = (short) 32;
    public const int DC1394_SUCCESS = 0;
    public const int DC1394_FAILURE = -1;
    public const int DC1394_NOT_A_CAMERA = -2;
    public const int DC1394_FUNCTION_NOT_SUPPORTED = -3;
    public const int DC1394_CAMERA_NOT_INITIALIZED = -4;
    public const int DC1394_MEMORY_ALLOCATION_FAILURE = -5;
    public const int DC1394_TAGGED_REGISTER_NOT_FOUND = -6;
    public const int DC1394_NO_ISO_CHANNEL = -7;
    public const int DC1394_NO_BANDWIDTH = -8;
    public const int DC1394_IOCTL_FAILURE = -9;
    public const int DC1394_CAPTURE_IS_NOT_SET = -10;
    public const int DC1394_CAPTURE_IS_RUNNING = -11;
    public const int DC1394_RAW1394_FAILURE = -12;
    public const int DC1394_FORMAT7_ERROR_FLAG_1 = -13;
    public const int DC1394_FORMAT7_ERROR_FLAG_2 = -14;
    public const int DC1394_INVALID_ARGUMENT_VALUE = -15;
    public const int DC1394_REQ_VALUE_OUTSIDE_RANGE = -16;
    public const int DC1394_INVALID_FEATURE = -17;
    public const int DC1394_INVALID_VIDEO_FORMAT = -18;
    public const int DC1394_INVALID_VIDEO_MODE = -19;
    public const int DC1394_INVALID_FRAMERATE = -20;
    public const int DC1394_INVALID_TRIGGER_MODE = -21;
    public const int DC1394_INVALID_TRIGGER_SOURCE = -22;
    public const int DC1394_INVALID_ISO_SPEED = -23;
    public const int DC1394_INVALID_IIDC_VERSION = -24;
    public const int DC1394_INVALID_COLOR_CODING = -25;
    public const int DC1394_INVALID_COLOR_FILTER = -26;
    public const int DC1394_INVALID_CAPTURE_POLICY = -27;
    public const int DC1394_INVALID_ERROR_CODE = -28;
    public const int DC1394_INVALID_BAYER_METHOD = -29;
    public const int DC1394_INVALID_VIDEO1394_DEVICE = -30;
    public const int DC1394_INVALID_OPERATION_MODE = -31;
    public const int DC1394_INVALID_TRIGGER_POLARITY = -32;
    public const int DC1394_INVALID_FEATURE_MODE = -33;
    public const int DC1394_INVALID_LOG_TYPE = -34;
    public const int DC1394_INVALID_BYTE_ORDER = -35;
    public const int DC1394_INVALID_STEREO_METHOD = -36;
    public const int DC1394_BASLER_NO_MORE_SFF_CHUNKS = -37;
    public const int DC1394_BASLER_CORRUPTED_SFF_CHUNK = -38;
    public const int DC1394_BASLER_UNKNOWN_SFF_CHUNK = -39;
    public const int DC1394_ERROR_MIN = -39;
    public const int DC1394_ERROR_MAX = 0;
    public const int DC1394_ERROR_NUM = 40;
    public const int DC1394_LOG_ERROR = 768;
    public const int DC1394_LOG_WARNING = 769;
    public const int DC1394_LOG_DEBUG = 770;
    public const int DC1394_LOG_MIN = 768;
    public const int DC1394_LOG_MAX = 770;
    public const int DC1394_LOG_NUM = 3;
    public const int DC1394_VIDEO_MODE_160x120_YUV444 = 64;
    public const int DC1394_VIDEO_MODE_320x240_YUV422 = 65;
    public const int DC1394_VIDEO_MODE_640x480_YUV411 = 66;
    public const int DC1394_VIDEO_MODE_640x480_YUV422 = 67;
    public const int DC1394_VIDEO_MODE_640x480_RGB8 = 68;
    public const int DC1394_VIDEO_MODE_640x480_MONO8 = 69;
    public const int DC1394_VIDEO_MODE_640x480_MONO16 = 70;
    public const int DC1394_VIDEO_MODE_800x600_YUV422 = 71;
    public const int DC1394_VIDEO_MODE_800x600_RGB8 = 72;
    public const int DC1394_VIDEO_MODE_800x600_MONO8 = 73;
    public const int DC1394_VIDEO_MODE_1024x768_YUV422 = 74;
    public const int DC1394_VIDEO_MODE_1024x768_RGB8 = 75;
    public const int DC1394_VIDEO_MODE_1024x768_MONO8 = 76;
    public const int DC1394_VIDEO_MODE_800x600_MONO16 = 77;
    public const int DC1394_VIDEO_MODE_1024x768_MONO16 = 78;
    public const int DC1394_VIDEO_MODE_1280x960_YUV422 = 79;
    public const int DC1394_VIDEO_MODE_1280x960_RGB8 = 80;
    public const int DC1394_VIDEO_MODE_1280x960_MONO8 = 81;
    public const int DC1394_VIDEO_MODE_1600x1200_YUV422 = 82;
    public const int DC1394_VIDEO_MODE_1600x1200_RGB8 = 83;
    public const int DC1394_VIDEO_MODE_1600x1200_MONO8 = 84;
    public const int DC1394_VIDEO_MODE_1280x960_MONO16 = 85;
    public const int DC1394_VIDEO_MODE_1600x1200_MONO16 = 86;
    public const int DC1394_VIDEO_MODE_EXIF = 87;
    public const int DC1394_VIDEO_MODE_FORMAT7_0 = 88;
    public const int DC1394_VIDEO_MODE_FORMAT7_1 = 89;
    public const int DC1394_VIDEO_MODE_FORMAT7_2 = 90;
    public const int DC1394_VIDEO_MODE_FORMAT7_3 = 91;
    public const int DC1394_VIDEO_MODE_FORMAT7_4 = 92;
    public const int DC1394_VIDEO_MODE_FORMAT7_5 = 93;
    public const int DC1394_VIDEO_MODE_FORMAT7_6 = 94;
    public const int DC1394_VIDEO_MODE_FORMAT7_7 = 95;
    public const int DC1394_VIDEO_MODE_MIN = 64;
    public const int DC1394_VIDEO_MODE_MAX = 95;
    public const int DC1394_VIDEO_MODE_NUM = 32;
    public const int DC1394_VIDEO_MODE_FORMAT7_MIN = 88;
    public const int DC1394_VIDEO_MODE_FORMAT7_MAX = 95;
    public const int DC1394_VIDEO_MODE_FORMAT7_NUM = 8;
    public const int DC1394_COLOR_CODING_MONO8 = 352;
    public const int DC1394_COLOR_CODING_YUV411 = 353;
    public const int DC1394_COLOR_CODING_YUV422 = 354;
    public const int DC1394_COLOR_CODING_YUV444 = 355;
    public const int DC1394_COLOR_CODING_RGB8 = 356;
    public const int DC1394_COLOR_CODING_MONO16 = 357;
    public const int DC1394_COLOR_CODING_RGB16 = 358;
    public const int DC1394_COLOR_CODING_MONO16S = 359;
    public const int DC1394_COLOR_CODING_RGB16S = 360;
    public const int DC1394_COLOR_CODING_RAW8 = 361;
    public const int DC1394_COLOR_CODING_RAW16 = 362;
    public const int DC1394_COLOR_CODING_MIN = 352;
    public const int DC1394_COLOR_CODING_MAX = 362;
    public const int DC1394_COLOR_CODING_NUM = 11;
    public const int DC1394_COLOR_FILTER_RGGB = 512;
    public const int DC1394_COLOR_FILTER_GBRG = 513;
    public const int DC1394_COLOR_FILTER_GRBG = 514;
    public const int DC1394_COLOR_FILTER_BGGR = 515;
    public const int DC1394_COLOR_FILTER_MIN = 512;
    public const int DC1394_COLOR_FILTER_MAX = 515;
    public const int DC1394_COLOR_FILTER_NUM = 4;
    public const int DC1394_BYTE_ORDER_UYVY = 800;
    public const int DC1394_BYTE_ORDER_YUYV = 801;
    public const int DC1394_BYTE_ORDER_MIN = 800;
    public const int DC1394_BYTE_ORDER_MAX = 801;
    public const int DC1394_BYTE_ORDER_NUM = 2;
    public const int DC1394_FALSE = 0;
    public const int DC1394_TRUE = 1;
    public const int DC1394_OFF = 0;
    public const int DC1394_ON = 1;
    public const int DC1394_IIDC_VERSION_1_04 = 544;
    public const int DC1394_IIDC_VERSION_1_20 = 545;
    public const int DC1394_IIDC_VERSION_PTGREY = 546;
    public const int DC1394_IIDC_VERSION_1_30 = 547;
    public const int DC1394_IIDC_VERSION_1_31 = 548;
    public const int DC1394_IIDC_VERSION_1_32 = 549;
    public const int DC1394_IIDC_VERSION_1_33 = 550;
    public const int DC1394_IIDC_VERSION_1_34 = 551;
    public const int DC1394_IIDC_VERSION_1_35 = 552;
    public const int DC1394_IIDC_VERSION_1_36 = 553;
    public const int DC1394_IIDC_VERSION_1_37 = 554;
    public const int DC1394_IIDC_VERSION_1_38 = 555;
    public const int DC1394_IIDC_VERSION_1_39 = 556;
    public const int DC1394_IIDC_VERSION_MIN = 544;
    public const int DC1394_IIDC_VERSION_MAX = 556;
    public const int DC1394_IIDC_VERSION_NUM = 13;
    public const int DC1394_POWER_CLASS_NONE = 608;
    public const int DC1394_POWER_CLASS_PROV_MIN_15W = 609;
    public const int DC1394_POWER_CLASS_PROV_MIN_30W = 610;
    public const int DC1394_POWER_CLASS_PROV_MIN_45W = 611;
    public const int DC1394_POWER_CLASS_USES_MAX_1W = 612;
    public const int DC1394_POWER_CLASS_USES_MAX_3W = 613;
    public const int DC1394_POWER_CLASS_USES_MAX_6W = 614;
    public const int DC1394_POWER_CLASS_USES_MAX_10W = 615;
    public const int DC1394_POWER_CLASS_MIN = 608;
    public const int DC1394_POWER_CLASS_MAX = 615;
    public const int DC1394_POWER_CLASS_NUM = 8;
    public const int DC1394_PHY_DELAY_MAX_144_NS = 640;
    public const int DC1394_PHY_DELAY_UNKNOWN_0 = 641;
    public const int DC1394_PHY_DELAY_UNKNOWN_1 = 642;
    public const int DC1394_PHY_DELAY_UNKNOWN_2 = 643;
    public const int DC1394_PHY_DELAY_MIN = 640;
    public const int DC1394_PHY_DELAY_MAX = 641;
    public const int DC1394_PHY_DELAY_NUM = 2;
    public const int DC1394_TRIGGER_MODE_0 = 384;
    public const int DC1394_TRIGGER_MODE_1 = 385;
    public const int DC1394_TRIGGER_MODE_2 = 386;
    public const int DC1394_TRIGGER_MODE_3 = 387;
    public const int DC1394_TRIGGER_MODE_4 = 388;
    public const int DC1394_TRIGGER_MODE_5 = 389;
    public const int DC1394_TRIGGER_MODE_14 = 390;
    public const int DC1394_TRIGGER_MODE_15 = 391;
    public const int DC1394_TRIGGER_MODE_MIN = 384;
    public const int DC1394_TRIGGER_MODE_MAX = 391;
    public const int DC1394_TRIGGER_MODE_NUM = 8;
    public const int DC1394_FEATURE_BRIGHTNESS = 416;
    public const int DC1394_FEATURE_EXPOSURE = 417;
    public const int DC1394_FEATURE_SHARPNESS = 418;
    public const int DC1394_FEATURE_WHITE_BALANCE = 419;
    public const int DC1394_FEATURE_HUE = 420;
    public const int DC1394_FEATURE_SATURATION = 421;
    public const int DC1394_FEATURE_GAMMA = 422;
    public const int DC1394_FEATURE_SHUTTER = 423;
    public const int DC1394_FEATURE_GAIN = 424;
    public const int DC1394_FEATURE_IRIS = 425;
    public const int DC1394_FEATURE_FOCUS = 426;
    public const int DC1394_FEATURE_TEMPERATURE = 427;
    public const int DC1394_FEATURE_TRIGGER = 428;
    public const int DC1394_FEATURE_TRIGGER_DELAY = 429;
    public const int DC1394_FEATURE_WHITE_SHADING = 430;
    public const int DC1394_FEATURE_FRAME_RATE = 431;
    public const int DC1394_FEATURE_ZOOM = 432;
    public const int DC1394_FEATURE_PAN = 433;
    public const int DC1394_FEATURE_TILT = 434;
    public const int DC1394_FEATURE_OPTICAL_FILTER = 435;
    public const int DC1394_FEATURE_CAPTURE_SIZE = 436;
    public const int DC1394_FEATURE_CAPTURE_QUALITY = 437;
    public const int DC1394_FEATURE_MIN = 416;
    public const int DC1394_FEATURE_MAX = 437;
    public const int DC1394_FEATURE_NUM = 22;
    public const int DC1394_TRIGGER_SOURCE_0 = 576;
    public const int DC1394_TRIGGER_SOURCE_1 = 577;
    public const int DC1394_TRIGGER_SOURCE_2 = 578;
    public const int DC1394_TRIGGER_SOURCE_3 = 579;
    public const int DC1394_TRIGGER_SOURCE_SOFTWARE = 580;
    public const int DC1394_TRIGGER_SOURCE_MIN = 576;
    public const int DC1394_TRIGGER_SOURCE_MAX = 580;
    public const int DC1394_TRIGGER_SOURCE_NUM = 5;
    public const int DC1394_TRIGGER_ACTIVE_LOW = 704;
    public const int DC1394_TRIGGER_ACTIVE_HIGH = 705;
    public const int DC1394_TRIGGER_ACTIVE_MIN = 704;
    public const int DC1394_TRIGGER_ACTIVE_MAX = 705;
    public const int DC1394_TRIGGER_ACTIVE_NUM = 2;
    public const int DC1394_FEATURE_MODE_MANUAL = 736;
    public const int DC1394_FEATURE_MODE_AUTO = 737;
    public const int DC1394_FEATURE_MODE_ONE_PUSH_AUTO = 738;
    public const int DC1394_FEATURE_MODE_MIN = 736;
    public const int DC1394_FEATURE_MODE_MAX = 738;
    public const int DC1394_FEATURE_MODE_NUM = 3;
    public const int DC1394_CAPTURE_POLICY_WAIT = 672;
    public const int DC1394_CAPTURE_POLICY_POLL = 673;
    public const int DC1394_CAPTURE_POLICY_MIN = 672;
    public const int DC1394_CAPTURE_POLICY_MAX = 673;
    public const int DC1394_CAPTURE_POLICY_NUM = 2;
    public const int DC1394_CAPTURE_FLAGS_CHANNEL_ALLOC = 1;
    public const int DC1394_CAPTURE_FLAGS_BANDWIDTH_ALLOC = 2;
    public const int DC1394_CAPTURE_FLAGS_DEFAULT = 4;
    public const int DC1394_CAPTURE_FLAGS_AUTO_ISO = 8;
    public const int DC1394_ISO_SPEED_100 = 0;
    public const int DC1394_ISO_SPEED_200 = 1;
    public const int DC1394_ISO_SPEED_400 = 2;
    public const int DC1394_ISO_SPEED_800 = 3;
    public const int DC1394_ISO_SPEED_1600 = 4;
    public const int DC1394_ISO_SPEED_3200 = 5;
    public const int DC1394_ISO_SPEED_MIN = 0;
    public const int DC1394_ISO_SPEED_MAX = 5;
    public const int DC1394_ISO_SPEED_NUM = 6;
    public const int DC1394_FRAMERATE_1_875 = 32;
    public const int DC1394_FRAMERATE_3_75 = 33;
    public const int DC1394_FRAMERATE_7_5 = 34;
    public const int DC1394_FRAMERATE_15 = 35;
    public const int DC1394_FRAMERATE_30 = 36;
    public const int DC1394_FRAMERATE_60 = 37;
    public const int DC1394_FRAMERATE_120 = 38;
    public const int DC1394_FRAMERATE_240 = 39;
    public const int DC1394_FRAMERATE_MIN = 32;
    public const int DC1394_FRAMERATE_MAX = 39;
    public const int DC1394_FRAMERATE_NUM = 8;
    public const int DC1394_OPERATION_MODE_LEGACY = 480;
    public const int DC1394_OPERATION_MODE_1394B = 481;
    public const int DC1394_OPERATION_MODE_MIN = 480;
    public const int DC1394_OPERATION_MODE_MAX = 481;
    public const int DC1394_OPERATION_MODE_NUM = 2;
    public const int DC1394_BAYER_METHOD_NEAREST = 0;
    public const int DC1394_BAYER_METHOD_SIMPLE = 1;
    public const int DC1394_BAYER_METHOD_BILINEAR = 2;
    public const int DC1394_BAYER_METHOD_HQLINEAR = 3;
    public const int DC1394_BAYER_METHOD_DOWNSAMPLE = 4;
    public const int DC1394_BAYER_METHOD_EDGESENSE = 5;
    public const int DC1394_BAYER_METHOD_VNG = 6;
    public const int DC1394_BAYER_METHOD_AHD = 7;
    public const int DC1394_BAYER_METHOD_MIN = 0;
    public const int DC1394_BAYER_METHOD_MAX = 7;
    public const int DC1394_BAYER_METHOD_NUM = 8;
    public const int DC1394_STEREO_METHOD_INTERLACED = 0;
    public const int DC1394_STEREO_METHOD_FIELD = 1;
    public const int DC1394_STEREO_METHOD_MIN = 0;
    public const int DC1394_STEREO_METHOD_MAX = 1;
    public const int DC1394_STEREO_METHOD_NUM = 2;
    public const int DC1394_QUERY_FROM_CAMERA = -1;
    public const int DC1394_USE_MAX_AVAIL = -2;
    public const int DC1394_USE_RECOMMENDED = -3;
    static IntPtr __\u003Cjniptr\u003Epoll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024pollfd\u003BJI\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Edc1394_log_register_handler\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024Log_handler\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_log_set_default_handler\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_log_error\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Edc1394_log_warning\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Edc1394_log_debug\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Edc1394_new\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B;
    static IntPtr __\u003Cjniptr\u003Edc1394_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_set_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_get_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_reset_bus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_read_cycle_timer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BJ\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_get_node\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_enumerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_free_list\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_new\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_new_unit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_print_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_print\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_print_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_whitebalance_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_whitebalance_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_temperature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_temperature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_whiteshading_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_whiteshading_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_is_present\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_is_readable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_is_switchable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_modes_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_has_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_absolute_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_set_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIF\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_set_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_set_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_get_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_has_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_set_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_get_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_external_trigger_get_supported_sources\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394trigger_sources_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_software_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_software_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_pio_set\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_pio_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_camera_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_memory_busy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_memory_save\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_memory_load\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_capture_setup\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_capture_stop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_capture_get_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_capture_dequeue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_capture_enqueue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_capture_is_frame_corrupt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_supported_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_modes_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_supported_framerates\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394framerates_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_set_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_video_get_bandwidth_usage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_convert_to_YUV422\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_convert_to_MONO8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_convert_to_RGB8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_deinterlace_stereo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_bayer_decoding_8bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_bayer_decoding_16bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_convert_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_debayer_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_deinterlace_stereo_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_max_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_unit_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_set_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_set_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_unit_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_color_codings\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_set_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_color_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_packet_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_set_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_recommended_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_packets_per_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_frame_interval\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_pixel_number\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_total_bytes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BJ\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_modeset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7modeset_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_mode_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7mode_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_set_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIIIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_format7_get_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_iso_set_persist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_iso_allocate_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_iso_release_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_iso_allocate_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_iso_release_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_iso_release_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_set_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_image_size_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_framerate_as_float\u0028I\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_color_coding_data_depth\u0028I\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_color_coding_bit_size\u0028I\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_get_color_coding_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_is_color\u0028I\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_is_video_mode_scalable\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_is_video_mode_still_image\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_is_same_camera\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Edc1394_feature_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Edc1394_error_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Edc1394_checksum_crc16\u0028\u005BBI\u0029S;
    static IntPtr __\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Ljava\u002Fnio\u002FByteBuffer\u003BI\u0029S;
    static IntPtr __\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029S;

    [LineNumberTable((ushort) 66)]
    static dc1394()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 232, (byte) 163, (byte) 165})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public dc1394()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object dc1394_new()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_new\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_new\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_new", "()Lcom/googlecode/javacv/cpp/dc1394$dc1394_t;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_new\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_enumerate(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_enumerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_enumerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_enumerate", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_list_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_enumerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object dc1394_camera_new_unit(object _param1, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_new_unit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_new_unit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_new_unit", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394_t;JI)Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, long, int)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_new_unit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void dc1394_camera_free(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029V == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029V = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_free", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void dc1394_camera_free_list(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_free_list\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029V == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_free_list\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029V = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_free_list", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_list_t;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_free_list\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_list_t\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void dc1394_free(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B\u0029V == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B\u0029V = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_free", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394_t;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_free\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_mode(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_framerate(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_framerate", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_set_power(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_set_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_set_mode(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_set_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_set_source(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_set_source", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_operation_mode(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_operation_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_iso_speed(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_iso_speed", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_mode(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_is_video_mode_scalable(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_is_video_mode_scalable\u0028I\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_is_video_mode_scalable\u0028I\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_is_video_mode_scalable", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_is_video_mode_scalable\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_set_roi(object _param1, int i1, int i2, int i3, int i4, int i5, int i6, int i7)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_set_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIIIIIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_set_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIIIIIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_set_roi", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;IIIIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        int num9 = i5;
        int num10 = i6;
        int num11 = i7;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_set_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIIIIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_framerate(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_framerate", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_framerate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_capture_setup(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_capture_setup\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_capture_setup\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_capture_setup", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_capture_setup\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_set_absolute_value(object _param1, int i, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_set_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIF\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_set_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIF\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_set_absolute_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;IF)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        double num6 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, float)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_set_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIF\u0029I)((float) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_absolute_value(object _param1, int i, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_absolute_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_capture_get_fileno(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_capture_get_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_capture_get_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_capture_get_fileno", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_capture_get_fileno\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_transmission(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_transmission", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_reset_bus(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_reset_bus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_reset_bus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_reset_bus", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_reset_bus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int poll(object _param1, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Epoll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024pollfd\u003BJI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Epoll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024pollfd\u003BJI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "poll", "(Lcom/googlecode/javacv/cpp/dc1394$pollfd;JI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, int)>) dc1394.__\u003Cjniptr\u003Epoll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024pollfd\u003BJI\u0029I)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_capture_stop(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_capture_stop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_capture_stop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_capture_stop", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_capture_stop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_capture_enqueue(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_capture_enqueue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_capture_enqueue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_capture_enqueue", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_capture_enqueue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_one_shot(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_one_shot", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_software_trigger_get_power(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_software_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_software_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_software_trigger_get_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_software_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_software_trigger_set_power(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_software_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_software_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_software_trigger_set_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_software_trigger_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_capture_dequeue(object \u0031, int i, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_capture_dequeue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_capture_dequeue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_capture_dequeue", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;ILcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(param2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_capture_dequeue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_debayer_frames(object \u0031, object \u0032, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_debayer_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_debayer_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_debayer_frames", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_debayer_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_convert_frames(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_convert_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_convert_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_convert_frames", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_convert_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_log_register_handler(int i, object l, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_log_register_handler\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024Log_handler\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_log_register_handler\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024Log_handler\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_log_register_handler", "(ILcom/googlecode/javacv/cpp/dc1394$Log_handler;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(l);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_log_register_handler\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024Log_handler\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_log_set_default_handler(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_log_set_default_handler\u0028I\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_log_set_default_handler\u0028I\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_log_set_default_handler", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_log_set_default_handler\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void dc1394_log_error(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_log_error\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_log_error\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_log_error", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_log_error\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void dc1394_log_warning(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_log_warning\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_log_warning\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_log_warning", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_log_warning\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void dc1394_log_debug(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_log_debug\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_log_debug\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_log_debug", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_log_debug\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_set_broadcast(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_set_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_set_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_set_broadcast", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_set_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_get_broadcast(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_get_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_get_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_get_broadcast", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_get_broadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_read_cycle_timer(object _param1, int[] iarr, long[] larr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_read_cycle_timer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BJ\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_read_cycle_timer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BJ\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_read_cycle_timer", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I[J)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) larr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_read_cycle_timer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BJ\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_get_node(object _param1, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_get_node\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_get_node\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_get_node", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_get_node\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object dc1394_camera_new(object _param1, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_new\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_new\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_new", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394_t;J)Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, long)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_new\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394_t\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B)((long) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_print_info(object _param1, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_print_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_print_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_print_info", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_print_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_all(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_all", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394featureset_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394feature_info_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_print(object _param1, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_print\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_print\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_print", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394feature_info_t;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_print\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_info_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_print_all(object _param1, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_print_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_print_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_print_all", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394featureset_t;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_print_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394featureset_t\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_whitebalance_get_value(object _param1, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_whitebalance_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_whitebalance_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_whitebalance_get_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_whitebalance_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_whitebalance_set_value(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_whitebalance_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_whitebalance_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_whitebalance_set_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_whitebalance_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_temperature_get_value(object _param1, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_temperature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_temperature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_temperature_get_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_temperature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_temperature_set_value(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_temperature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_temperature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_temperature_set_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_temperature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_whiteshading_get_value(object _param1, int[] iarr1, int[] iarr2, int[] iarr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_whiteshading_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_whiteshading_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_whiteshading_get_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_whiteshading_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_whiteshading_set_value(object _param1, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_whiteshading_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_whiteshading_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_whiteshading_set_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_whiteshading_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_value(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_set_value(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_set_value", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_set_value\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_is_present(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_is_present\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_is_present\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_is_present", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_is_present\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_is_readable(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_is_readable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_is_readable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_is_readable", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_is_readable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_boundaries(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_boundaries", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_is_switchable(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_is_switchable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_is_switchable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_is_switchable", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_is_switchable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_power(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_set_power(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_set_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_modes(object \u0031, int i, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_modes_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_modes_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_modes", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;ILcom/googlecode/javacv/cpp/dc1394$dc1394feature_modes_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(param2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394feature_modes_t\u003B\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_mode(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_set_mode(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_set_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_set_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_has_absolute_control(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_has_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_has_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_has_absolute_control", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_has_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_absolute_boundaries(object _param1, int i, float[] farr1, float[] farr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u005BF\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u005BF\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_absolute_boundaries", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[F[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_boundaries\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u005BF\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_get_absolute_control(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_absolute_control", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_feature_set_absolute_control(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_set_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_set_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_set_absolute_control", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_set_absolute_control\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_set_polarity(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_set_polarity", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_set_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_get_polarity(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_get_polarity", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_has_polarity(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_has_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_has_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_has_polarity", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_has_polarity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_get_power(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_get_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_get_mode(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_get_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_get_source(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_get_source", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_source\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_external_trigger_get_supported_sources(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_supported_sources\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394trigger_sources_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_supported_sources\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394trigger_sources_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_external_trigger_get_supported_sources", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394trigger_sources_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_external_trigger_get_supported_sources\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394trigger_sources_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_pio_set(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_pio_set\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_pio_set\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_pio_set", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_pio_set\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_pio_get(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_pio_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_pio_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_pio_get", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_pio_get\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_reset(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_reset", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_reset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_camera_set_power(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_camera_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_camera_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_camera_set_power", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_camera_set_power\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_memory_busy(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_memory_busy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_memory_busy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_memory_busy", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_memory_busy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_memory_save(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_memory_save\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_memory_save\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_memory_save", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_memory_save\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_memory_load(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_memory_load\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_memory_load\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_memory_load", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_memory_load\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_capture_is_frame_corrupt(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_capture_is_frame_corrupt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_capture_is_frame_corrupt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_capture_is_frame_corrupt", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_capture_is_frame_corrupt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_supported_modes(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_supported_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_modes_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_supported_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_modes_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_supported_modes", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394video_modes_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_supported_modes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_modes_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_supported_framerates(object \u0031, int i, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_supported_framerates\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394framerates_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_supported_framerates\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394framerates_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_supported_framerates", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;ILcom/googlecode/javacv/cpp/dc1394$dc1394framerates_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(param2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_supported_framerates\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394framerates_t\u003B\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_operation_mode(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_operation_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_operation_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_iso_speed(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_iso_speed", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_iso_speed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_iso_channel(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_iso_channel", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_iso_channel(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_iso_channel", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_iso_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_data_depth(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_data_depth", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_transmission(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_transmission", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_transmission\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_one_shot(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_one_shot", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_one_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_set_multi_shot(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_set_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_set_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_set_multi_shot", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_video_set_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_multi_shot(object _param1, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_multi_shot", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_multi_shot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_video_get_bandwidth_usage(object _param1, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_video_get_bandwidth_usage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_video_get_bandwidth_usage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_video_get_bandwidth_usage", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_video_get_bandwidth_usage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_convert_to_YUV422(object bp1, object bp2, int i1, int i2, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_convert_to_YUV422\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_convert_to_YUV422\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_convert_to_YUV422", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;IIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        int num10 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_convert_to_YUV422\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I)((int) num2, (int) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_convert_to_MONO8(object bp1, object bp2, int i1, int i2, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_convert_to_MONO8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_convert_to_MONO8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_convert_to_MONO8", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;IIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        int num10 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_convert_to_MONO8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I)((int) num2, (int) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_convert_to_RGB8(object bp1, object bp2, int i1, int i2, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_convert_to_RGB8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_convert_to_RGB8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_convert_to_RGB8", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;IIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        int num10 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_convert_to_RGB8\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIIII\u0029I)((int) num2, (int) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_deinterlace_stereo(object bp1, object bp2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_deinterlace_stereo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_deinterlace_stereo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_deinterlace_stereo", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_deinterlace_stereo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_bayer_decoding_8bit(object bp1, object bp2, int i1, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_bayer_decoding_8bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_bayer_decoding_8bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_bayer_decoding_8bit", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;IIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_bayer_decoding_8bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BIIII\u0029I)((int) num2, (int) num3, (int) num4, (int) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_bayer_decoding_16bit(object sp1, object sp2, int i1, int i2, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_bayer_decoding_16bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BIIIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_bayer_decoding_16bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BIIIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_bayer_decoding_16bit", "(Lcom/googlecode/javacpp/ShortPointer;Lcom/googlecode/javacpp/ShortPointer;IIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(sp2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        int num10 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_bayer_decoding_16bit\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FShortPointer\u003BIIIII\u0029I)((int) num2, (int) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_deinterlace_stereo_frames(object \u0031, object \u0032, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_deinterlace_stereo_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_deinterlace_stereo_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_deinterlace_stereo_frames", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394video_frame_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_deinterlace_stereo_frames\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394video_frame_t\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_max_image_size(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_max_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_max_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_max_image_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_max_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_unit_size(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_unit_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_unit_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_unit_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_unit_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_image_size(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_image_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_set_image_size(object _param1, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_set_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_set_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_set_image_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_set_image_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_image_position(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_image_position", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_set_image_position(object _param1, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_set_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_set_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_set_image_position", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_set_image_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_unit_position(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_unit_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_unit_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_unit_position", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_unit_position\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_color_coding(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_color_coding", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_color_codings(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_codings\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_codings\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_color_codings", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_codings\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_set_color_coding(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_set_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_set_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_set_color_coding", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_set_color_coding\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_color_filter(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_color_filter", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_color_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_packet_parameters(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packet_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packet_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_packet_parameters", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packet_parameters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_packet_size(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_packet_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_set_packet_size(object _param1, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_set_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_set_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_set_packet_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_set_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_recommended_packet_size(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_recommended_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_recommended_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_recommended_packet_size", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_recommended_packet_size\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_packets_per_frame(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packets_per_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packets_per_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_packets_per_frame", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_packets_per_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_data_depth(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_data_depth", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_data_depth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_frame_interval(object _param1, int i, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_frame_interval\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_frame_interval\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_frame_interval", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_frame_interval\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BF\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_pixel_number(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_pixel_number\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_pixel_number\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_pixel_number", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_pixel_number\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_total_bytes(object _param1, int i, long[] larr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_total_bytes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BJ\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_total_bytes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BJ\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_total_bytes", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[J)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) larr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_total_bytes\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BJ\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_modeset(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_modeset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7modeset_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_modeset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7modeset_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_modeset", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394format7modeset_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_modeset\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7modeset_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_mode_info(object \u0031, int i, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_mode_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7mode_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_mode_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7mode_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_mode_info", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;ILcom/googlecode/javacv/cpp/dc1394$dc1394format7mode_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(param2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_mode_info\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394format7mode_t\u003B\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_format7_get_roi(object _param1, int i, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5, int[] iarr6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_format7_get_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_format7_get_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_format7_get_roi", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr6);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_format7_get_roi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, num6, num7, (int) num8, num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_iso_set_persist(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_iso_set_persist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_iso_set_persist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_iso_set_persist", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_iso_set_persist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_iso_allocate_channel(object _param1, long l, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_iso_allocate_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_iso_allocate_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_iso_allocate_channel", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_iso_allocate_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I)(num2, (long) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_iso_release_channel(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_iso_release_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_iso_release_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_iso_release_channel", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_iso_release_channel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_iso_allocate_bandwidth(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_iso_allocate_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_iso_allocate_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_iso_allocate_bandwidth", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_iso_allocate_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_iso_release_bandwidth(object _param1, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_iso_release_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_iso_release_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_iso_release_bandwidth", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_iso_release_bandwidth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_iso_release_all(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_iso_release_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_iso_release_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_iso_release_all", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_iso_release_all\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_registers(object _param1, long l, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_registers", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_get_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I)((int) num2, num3, (long) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_registers(object _param1, long l, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_registers", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I)((int) num2, num3, (long) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_control_registers(object _param1, long l, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_control_registers", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_get_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I)((int) num2, num3, (long) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_control_registers(object _param1, long l, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_control_registers", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I)((int) num2, num3, (long) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_adv_control_registers(object _param1, long l, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_adv_control_registers", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_get_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I)((int) num2, num3, (long) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_adv_control_registers(object _param1, long l, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_adv_control_registers", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_adv_control_registers\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BII\u0029I)((int) num2, num3, (long) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_format7_register(object _param1, int i, long l, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_format7_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;IJ[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        long num6 = l;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I)(num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_format7_register(object _param1, int i1, long l, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_format7_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;IJI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        long num6 = l;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_format7_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I)((int) num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_absolute_register(object _param1, int i, long l, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_absolute_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;IJ[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        long num6 = l;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJ\u005BI\u0029I)(num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_absolute_register(object _param1, int i1, long l, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_absolute_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;IJI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i1;
        long num6 = l;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, long, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_absolute_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BIJI\u0029I)((int) num2, (long) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_PIO_register(object _param1, long l, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_PIO_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I)(num2, (long) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_PIO_register(object _param1, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_PIO_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;JI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_PIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_SIO_register(object _param1, long l, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_SIO_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I)(num2, (long) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_SIO_register(object _param1, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_SIO_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;JI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_SIO_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_strobe_register(object _param1, long l, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_strobe_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;J[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJ\u005BI\u0029I)(num2, (long) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_set_strobe_register(object _param1, long l, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_set_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_set_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_set_strobe_register", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;JI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        long num5 = l;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, int)>) dc1394.__\u003Cjniptr\u003Edc1394_set_strobe_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BJI\u0029I)((int) num2, (long) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_image_size_from_video_mode(object _param1, int i, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_image_size_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_image_size_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_image_size_from_video_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_image_size_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u005BI\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_framerate_as_float(int i, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_framerate_as_float\u0028I\u005BF\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_framerate_as_float\u0028I\u005BF\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_framerate_as_float", "(I[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_framerate_as_float\u0028I\u005BF\u0029I)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_color_coding_data_depth(int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_data_depth\u0028I\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_data_depth\u0028I\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_color_coding_data_depth", "(I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_data_depth\u0028I\u005BI\u0029I)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_color_coding_bit_size(int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_bit_size\u0028I\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_bit_size\u0028I\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_color_coding_bit_size", "(I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_bit_size\u0028I\u005BI\u0029I)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_get_color_coding_from_video_mode(object _param1, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_get_color_coding_from_video_mode", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_t;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_get_color_coding_from_video_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_t\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_is_color(int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_is_color\u0028I\u005BI\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_is_color\u0028I\u005BI\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_is_color", "(I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_is_color\u0028I\u005BI\u0029I)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_is_video_mode_still_image(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_is_video_mode_still_image\u0028I\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_is_video_mode_still_image\u0028I\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_is_video_mode_still_image", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_is_video_mode_still_image\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int dc1394_is_same_camera(object \u0031, object \u0032)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_is_same_camera\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003B\u0029I == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_is_same_camera\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003B\u0029I = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_is_same_camera", "(Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_id_t;Lcom/googlecode/javacv/cpp/dc1394$dc1394camera_id_t;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(param1);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) dc1394.__\u003Cjniptr\u003Edc1394_is_same_camera\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fdc1394\u0024dc1394camera_id_t\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string dc1394_feature_get_string(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_feature_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_feature_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_feature_get_string", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_feature_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static string dc1394_error_get_string(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_error_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_error_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_error_get_string", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_error_get_string\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static short dc1394_checksum_crc16(byte[] barr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028\u005BBI\u0029S == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028\u005BBI\u0029S = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_checksum_crc16", "([BI)S");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<short (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028\u005BBI\u0029S)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static short dc1394_checksum_crc16(ByteBuffer bb, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Ljava\u002Fnio\u002FByteBuffer\u003BI\u0029S == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Ljava\u002Fnio\u002FByteBuffer\u003BI\u0029S = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_checksum_crc16", "(Ljava/nio/ByteBuffer;I)S");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<short (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Ljava\u002Fnio\u002FByteBuffer\u003BI\u0029S)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static short dc1394_checksum_crc16(object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029S == IntPtr.Zero)
        dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029S = JNI.Frame.GetFuncPtr(dc1394.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/dc1394", "dc1394_checksum_crc16", "(Lcom/googlecode/javacpp/BytePointer;I)S");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(dc1394.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<dc1394>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<short (IntPtr, IntPtr, IntPtr, int)>) dc1394.__\u003Cjniptr\u003Edc1394_checksum_crc16\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029S)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (dc1394.__\u003CcallerID\u003E == null)
        dc1394.__\u003CcallerID\u003E = (CallerID) new dc1394.__\u003CCallerID\u003E();
      return dc1394.__\u003CcallerID\u003E;
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
