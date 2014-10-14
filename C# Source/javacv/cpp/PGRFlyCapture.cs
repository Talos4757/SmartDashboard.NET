// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.PGRFlyCapture
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv.cpp
{
  public class PGRFlyCapture : Object
  {
    public const int FLYCAPTURE_OK = 0;
    public const int FLYCAPTURE_FAILED = 1;
    public const int FLYCAPTURE_INVALID_ARGUMENT = 2;
    public const int FLYCAPTURE_INVALID_CONTEXT = 3;
    public const int FLYCAPTURE_NOT_IMPLEMENTED = 4;
    public const int FLYCAPTURE_ALREADY_INITIALIZED = 5;
    public const int FLYCAPTURE_ALREADY_STARTED = 6;
    public const int FLYCAPTURE_CALLBACK_NOT_REGISTERED = 7;
    public const int FLYCAPTURE_CALLBACK_ALREADY_REGISTERED = 8;
    public const int FLYCAPTURE_CAMERACONTROL_PROBLEM = 9;
    public const int FLYCAPTURE_COULD_NOT_OPEN_FILE = 10;
    public const int FLYCAPTURE_COULD_NOT_OPEN_DEVICE_HANDLE = 11;
    public const int FLYCAPTURE_MEMORY_ALLOC_ERROR = 12;
    public const int FLYCAPTURE_NO_IMAGE = 13;
    public const int FLYCAPTURE_NOT_INITIALIZED = 14;
    public const int FLYCAPTURE_NOT_STARTED = 15;
    public const int FLYCAPTURE_MAX_BANDWIDTH_EXCEEDED = 16;
    public const int FLYCAPTURE_NON_PGR_CAMERA = 17;
    public const int FLYCAPTURE_INVALID_MODE = 18;
    public const int FLYCAPTURE_ERROR_UNKNOWN = 19;
    public const int FLYCAPTURE_INVALID_CUSTOM_SIZE = 20;
    public const int FLYCAPTURE_TIMEOUT = 21;
    public const int FLYCAPTURE_TOO_MANY_LOCKED_BUFFERS = 22;
    public const int FLYCAPTURE_VERSION_MISMATCH = 23;
    public const int FLYCAPTURE_DEVICE_BUSY = 24;
    public const int FLYCAPTURE_DEPRECATED = 25;
    public const int FLYCAPTURE_BUFFER_SIZE_TOO_SMALL = 26;
    public const int FLYCAPTURE_BRIGHTNESS = 0;
    public const int FLYCAPTURE_AUTO_EXPOSURE = 1;
    public const int FLYCAPTURE_SHARPNESS = 2;
    public const int FLYCAPTURE_WHITE_BALANCE = 3;
    public const int FLYCAPTURE_HUE = 4;
    public const int FLYCAPTURE_SATURATION = 5;
    public const int FLYCAPTURE_GAMMA = 6;
    public const int FLYCAPTURE_IRIS = 7;
    public const int FLYCAPTURE_FOCUS = 8;
    public const int FLYCAPTURE_ZOOM = 9;
    public const int FLYCAPTURE_PAN = 10;
    public const int FLYCAPTURE_TILT = 11;
    public const int FLYCAPTURE_SHUTTER = 12;
    public const int FLYCAPTURE_GAIN = 13;
    public const int FLYCAPTURE_TRIGGER_DELAY = 14;
    public const int FLYCAPTURE_FRAME_RATE = 15;
    public const int FLYCAPTURE_SOFTWARE_WHITEBALANCE = 16;
    public const int FLYCAPTURE_TEMPERATURE = 17;
    public const int FLYCAPTURE_MESSAGE_BUS_RESET = 2;
    public const int FLYCAPTURE_MESSAGE_DEVICE_ARRIVAL = 3;
    public const int FLYCAPTURE_MESSAGE_DEVICE_REMOVAL = 4;
    public const int FLYCAPTURE_INFINITE = -1;
    public const int FLYCAPTURE_FRAMERATE_1_875 = 0;
    public const int FLYCAPTURE_FRAMERATE_3_75 = 1;
    public const int FLYCAPTURE_FRAMERATE_7_5 = 2;
    public const int FLYCAPTURE_FRAMERATE_15 = 3;
    public const int FLYCAPTURE_FRAMERATE_30 = 4;
    public const int FLYCAPTURE_FRAMERATE_UNUSED = 5;
    public const int FLYCAPTURE_FRAMERATE_60 = 6;
    public const int FLYCAPTURE_FRAMERATE_120 = 7;
    public const int FLYCAPTURE_FRAMERATE_240 = 8;
    public const int FLYCAPTURE_NUM_FRAMERATES = 9;
    public const int FLYCAPTURE_FRAMERATE_CUSTOM = 10;
    public const int FLYCAPTURE_FRAMERATE_ANY = 11;
    public const int FLYCAPTURE_VIDEOMODE_160x120YUV444 = 0;
    public const int FLYCAPTURE_VIDEOMODE_320x240YUV422 = 1;
    public const int FLYCAPTURE_VIDEOMODE_640x480YUV411 = 2;
    public const int FLYCAPTURE_VIDEOMODE_640x480YUV422 = 3;
    public const int FLYCAPTURE_VIDEOMODE_640x480RGB = 4;
    public const int FLYCAPTURE_VIDEOMODE_640x480Y8 = 5;
    public const int FLYCAPTURE_VIDEOMODE_640x480Y16 = 6;
    public const int FLYCAPTURE_VIDEOMODE_800x600YUV422 = 17;
    public const int FLYCAPTURE_VIDEOMODE_800x600RGB = 18;
    public const int FLYCAPTURE_VIDEOMODE_800x600Y8 = 7;
    public const int FLYCAPTURE_VIDEOMODE_800x600Y16 = 19;
    public const int FLYCAPTURE_VIDEOMODE_1024x768YUV422 = 20;
    public const int FLYCAPTURE_VIDEOMODE_1024x768RGB = 21;
    public const int FLYCAPTURE_VIDEOMODE_1024x768Y8 = 8;
    public const int FLYCAPTURE_VIDEOMODE_1024x768Y16 = 9;
    public const int FLYCAPTURE_VIDEOMODE_1280x960YUV422 = 22;
    public const int FLYCAPTURE_VIDEOMODE_1280x960RGB = 23;
    public const int FLYCAPTURE_VIDEOMODE_1280x960Y8 = 10;
    public const int FLYCAPTURE_VIDEOMODE_1280x960Y16 = 24;
    public const int FLYCAPTURE_VIDEOMODE_1600x1200YUV422 = 50;
    public const int FLYCAPTURE_VIDEOMODE_1600x1200RGB = 51;
    public const int FLYCAPTURE_VIDEOMODE_1600x1200Y8 = 11;
    public const int FLYCAPTURE_VIDEOMODE_1600x1200Y16 = 52;
    public const int FLYCAPTURE_VIDEOMODE_CUSTOM = 15;
    public const int FLYCAPTURE_VIDEOMODE_ANY = 16;
    public const int FLYCAPTURE_NUM_VIDEOMODES = 23;
    public const int FLYCAPTURE_FIREFLY = 0;
    public const int FLYCAPTURE_DRAGONFLY = 1;
    public const int FLYCAPTURE_AIM = 2;
    public const int FLYCAPTURE_SCORPION = 3;
    public const int FLYCAPTURE_TYPHOON = 4;
    public const int FLYCAPTURE_FLEA = 5;
    public const int FLYCAPTURE_DRAGONFLY_EXPRESS = 6;
    public const int FLYCAPTURE_FLEA2 = 7;
    public const int FLYCAPTURE_FIREFLY_MV = 8;
    public const int FLYCAPTURE_DRAGONFLY2 = 9;
    public const int FLYCAPTURE_BUMBLEBEE = 10;
    public const int FLYCAPTURE_BUMBLEBEE2 = 11;
    public const int FLYCAPTURE_BUMBLEBEEXB3 = 12;
    public const int FLYCAPTURE_GRASSHOPPER = 13;
    public const int FLYCAPTURE_CHAMELEON = 14;
    public const int FLYCAPTURE_UNKNOWN = -1;
    public const int FLYCAPTURE_BLACK_AND_WHITE = 0;
    public const int FLYCAPTURE_COLOR = 1;
    public const int FLYCAPTURE_S100 = 0;
    public const int FLYCAPTURE_S200 = 1;
    public const int FLYCAPTURE_S400 = 2;
    public const int FLYCAPTURE_S480 = 3;
    public const int FLYCAPTURE_S800 = 4;
    public const int FLYCAPTURE_S1600 = 5;
    public const int FLYCAPTURE_S3200 = 6;
    public const int FLYCAPTURE_S_FASTEST = 7;
    public const int FLYCAPTURE_ANY = 8;
    public const int FLYCAPTURE_SPEED_UNKNOWN = -1;
    public const int FLYCAPTURE_DISABLE = 0;
    public const int FLYCAPTURE_EDGE_SENSING = 1;
    public const int FLYCAPTURE_NEAREST_NEIGHBOR = 2;
    public const int FLYCAPTURE_NEAREST_NEIGHBOR_FAST = 3;
    public const int FLYCAPTURE_RIGOROUS = 4;
    public const int FLYCAPTURE_HQLINEAR = 5;
    public const int FLYCAPTURE_STIPPLEDFORMAT_BGGR = 0;
    public const int FLYCAPTURE_STIPPLEDFORMAT_GBRG = 1;
    public const int FLYCAPTURE_STIPPLEDFORMAT_GRBG = 2;
    public const int FLYCAPTURE_STIPPLEDFORMAT_RGGB = 3;
    public const int FLYCAPTURE_STIPPLEDFORMAT_DEFAULT = 4;
    public const int FLYCAPTURE_MONO8 = 1;
    public const int FLYCAPTURE_411YUV8 = 2;
    public const int FLYCAPTURE_422YUV8 = 4;
    public const int FLYCAPTURE_444YUV8 = 8;
    public const int FLYCAPTURE_RGB8 = 16;
    public const int FLYCAPTURE_MONO16 = 32;
    public const int FLYCAPTURE_RGB16 = 64;
    public const int FLYCAPTURE_S_MONO16 = 128;
    public const int FLYCAPTURE_S_RGB16 = 256;
    public const int FLYCAPTURE_RAW8 = 512;
    public const int FLYCAPTURE_RAW16 = 1024;
    public const int FLYCAPTURE_BGR = 268435457;
    public const int FLYCAPTURE_BGRU = 268435458;
    public const int FLYCAPTURE_FILEFORMAT_PGM = 0;
    public const int FLYCAPTURE_FILEFORMAT_PPM = 1;
    public const int FLYCAPTURE_FILEFORMAT_BMP = 2;
    public const int FLYCAPTURE_FILEFORMAT_JPG = 3;
    public const int FLYCAPTURE_FILEFORMAT_PNG = 4;
    public const int FLYCAPTURE_FILEFORMAT_RAW = 5;
    public const int FLYCAPTURE_IMAGE_FILTER_NONE = 0;
    public const int FLYCAPTURE_IMAGE_FILTER_SCORPION_CROSSTALK = 1;
    public const int FLYCAPTURE_IMAGE_FILTER_ALL = -1;
    public const int FLYCAPTURE_BUS_MESSAGE = 999999999;
    public const int FLYCAPTURE_BUS_RESET = 0;
    public const int FLYCAPTURE_DEVICE_ARRIVAL = 1;
    public const int FLYCAPTURE_DEVICE_REMOVAL = 2;
    public const int FLYCAPTURE_BUS_ERROR = 3;
    public const int FLYCAPTURE_GRABBED_IMAGE = 4;
    public const int FLYCAPTURE_REGISTER_READ = 5;
    public const int FLYCAPTURE_REGISTER_READ_BLOCK = 6;
    public const int FLYCAPTURE_REGISTER_WRITE = 7;
    public const int FLYCAPTURE_REGISTER_WRITE_BLOCK = 8;
    static IntPtr __\u003Cjniptr\u003EflycaptureBusCameraCount\u0028\u005BI\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EflycaptureBusEnumerateCamerasEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureModifyCallback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureCreateContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureDestroyContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureInitialize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureInitializeFromSerialNumber\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetLibraryVersion\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003EflycaptureRegisterToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003EflycaptureCheckVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u005BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCurrentVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCurrentCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BF\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureQueryCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureQueryCustomImageEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStartCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetGrabTimeoutEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGrabImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGrabImage2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSaveImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLjava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetJPEGCompressionQuality\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureInplaceRGB24toBGR24\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureInplaceWhiteBalance\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BZ\u005BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u005BI\u005BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraPropertyRangeEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BF\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraRegisterBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSaveToMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureRestoreFromMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetCameraTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BBBB\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureQueryTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BZ\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetStrobeBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureQueryStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureQueryLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BZ\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureEnableLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureInitializePlus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStartCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStartLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStartLockNextCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureStartLockNextCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJJJJJJI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSyncForLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureLockLatest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureUnlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureUnlockAll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureParseImageTimestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureWaitForImageEvent\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImageEvent\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetPacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetCustomImagePacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureReadRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureWriteRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureSetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureGetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureInitializeMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureCloseMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureReceiveMessage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureMessage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EflycaptureBusErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B;

    [LineNumberTable((ushort) 86)]
    static PGRFlyCapture()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 232, (byte) 173, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PGRFlyCapture()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static int flycaptureBusCameraCount(int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusCameraCount\u0028\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusCameraCount\u0028\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureBusCameraCount", "([I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusCameraCount\u0028\u005BI\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureBusEnumerateCamerasEx(object pgrfcfcie, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusEnumerateCamerasEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusEnumerateCamerasEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureBusEnumerateCamerasEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureInfoEx;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcie);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusEnumerateCamerasEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureCreateContext(object pgrfcfcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCreateContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCreateContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureCreateContext", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCreateContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureInitializePlus(object pgrfcfcc, int i1, int i2, object bp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializePlus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializePlus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureInitializePlus", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IILcom/googlecode/javacpp/BytePointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializePlus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I)(num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureDestroyContext(object pgrfcfcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureDestroyContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureDestroyContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureDestroyContext", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureDestroyContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetTrigger(object pgrfcfcc, bool[] barr, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetTrigger", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[Z[I[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
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
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetTrigger(object pgrfcfcc, bool b, int i1, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetTrigger", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;ZIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = b ? 1 : 0;
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, bool, int, int, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6 != 0, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraRegister(object pgrfcfcc, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraRegister", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraRegister(object pgrfcfcc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraRegister", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraRegister\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetBusSpeed(object pgrfcfcc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetBusSpeed", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraAbsProperty(object pgrfcfcc, int i, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraAbsProperty", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IF)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        double num6 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, float)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I)((float) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraAbsProperty(object pgrfcfcc, int i, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BF\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BF\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraAbsProperty", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BF\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStart(object pgrfcfcc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStart", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetGrabTimeoutEx(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetGrabTimeoutEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetGrabTimeoutEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetGrabTimeoutEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetGrabTimeoutEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStop(object pgrfcfcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStop", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGrabImage2(object pgrfcfcc, object pgrfcfci)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGrabImage2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGrabImage2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGrabImage2", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImage;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfci);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGrabImage2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureConvertImage(object pgrfcfcc, object pgrfcfci1, object pgrfcfci2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureConvertImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImage;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImage;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfci1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfci2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGrabImage(object pgrfcfcc, object pp, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGrabImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGrabImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGrabImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacpp/PointerPointer;[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGrabImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureModifyCallback(object pgrfcfcc1, object pgrfcfcc2, object p, bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureModifyCallback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureModifyCallback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureModifyCallback", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureCallback;Lcom/googlecode/javacpp/Pointer;Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num7 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureModifyCallback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BZ\u0029I)((bool) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureInitialize(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitialize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitialize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureInitialize", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitialize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureInitializeFromSerialNumber(object pgrfcfcc, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializeFromSerialNumber\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializeFromSerialNumber\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureInitializeFromSerialNumber", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;J)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializeFromSerialNumber\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJ\u0029I)((long) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraInfo(object pgrfcfcc, object pgrfcfcie)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraInfo", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureInfoEx;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcie);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureInfoEx\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetBusSpeed(object pgrfcfcc, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetBusSpeed", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetBusSpeed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetLibraryVersion()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetLibraryVersion\u0028\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetLibraryVersion\u0028\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetLibraryVersion", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetLibraryVersion\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string flycaptureErrorToString(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureErrorToString", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static string flycaptureRegisterToString(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureRegisterToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureRegisterToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureRegisterToString", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureRegisterToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static int flycaptureCheckVideoMode(object pgrfcfcc, int i1, int i2, bool[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCheckVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u005BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCheckVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u005BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureCheckVideoMode", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;II[Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCheckVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u005BZ\u0029I)(num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCurrentVideoMode(object pgrfcfcc, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCurrentVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCurrentVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCurrentVideoMode", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCurrentVideoMode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCurrentCustomImage(object pgrfcfcc, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5, int[] iarr6, float[] farr, int[] iarr7)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCurrentCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BF\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCurrentCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BF\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCurrentCustomImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I[I[I[I[I[I[F[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr6);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr7);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCurrentCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BF\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetColorProcessingMethod(object pgrfcfcc, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetColorProcessingMethod", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetColorProcessingMethod(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetColorProcessingMethod", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetColorProcessingMethod\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetColorTileFormat(object pgrfcfcc, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetColorTileFormat", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetColorTileFormat(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetColorTileFormat", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetColorTileFormat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureQueryCustomImage(object pgrfcfcc, int i, bool[] barr, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureQueryCustomImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[I[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, num6, num7, (int) num8, num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureQueryCustomImageEx(object pgrfcfcc, int i, bool[] barr, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5, int[] iarr6, int[] iarr7)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryCustomImageEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryCustomImageEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureQueryCustomImageEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[I[I[I[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr6);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr7);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryCustomImageEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, num6, num7, num8, num9, (int) num10, num11, num12, num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStartCustomImage(object pgrfcfcc, int i1, int i2, int i3, int i4, int i5, float f, int i6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStartCustomImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IIIIIFI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        int num9 = i5;
        double num10 = (double) f;
        int num11 = i6;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, int, int, float, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I)((int) num2, (float) num3, (int) num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 1422)]
    public static int flycaptureGrabImage(object context, object ppImageBuffer, int[] piRows, int[] piCols, int[] piRowInc, int[] pVideoMode)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(context, __typeref (PGRFlyCapture), "com.googlecode.javacv.cpp.PGRFlyCapture$FlyCaptureContext");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ppImageBuffer, __typeref (PGRFlyCapture), "[Lcom.googlecode.javacpp.BytePointer;");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [Modifiers]
    public static int flycaptureSaveImage(object pgrfcfcc, object pgrfcfci, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSaveImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLjava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSaveImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLjava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSaveImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImage;Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfci);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSaveImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImage\u003BLjava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetJPEGCompressionQuality(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetJPEGCompressionQuality\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetJPEGCompressionQuality\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetJPEGCompressionQuality", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetJPEGCompressionQuality\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureInplaceRGB24toBGR24(object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInplaceRGB24toBGR24\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInplaceRGB24toBGR24\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureInplaceRGB24toBGR24", "(Lcom/googlecode/javacpp/BytePointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInplaceRGB24toBGR24\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureInplaceWhiteBalance(object pgrfcfcc, object bp, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInplaceWhiteBalance\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInplaceWhiteBalance\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureInplaceWhiteBalance", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacpp/BytePointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInplaceWhiteBalance\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraPropertyRange(object pgrfcfcc, int i, bool[] barr1, int[] iarr1, int[] iarr2, int[] iarr3, bool[] barr2, bool[] barr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BZ\u005BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BZ\u005BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraPropertyRange", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[I[I[I[Z[Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) barr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BI\u005BI\u005BI\u005BZ\u005BZ\u0029I)(num2, num3, num4, (IntPtr) num5, num6, num7, (int) num8, num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraProperty(object pgrfcfcc, int i, int[] iarr1, int[] iarr2, bool[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u005BI\u005BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u005BI\u005BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraProperty", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[I[I[Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u005BI\u005BZ\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraProperty(object pgrfcfcc, int i1, int i2, int i3, bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraProperty", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IIIZ)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, bool)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I)((bool) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraPropertyBroadcast(object pgrfcfcc, int i1, int i2, int i3, bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraPropertyBroadcast", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IIIZ)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, bool)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIZ\u0029I)((bool) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraPropertyRangeEx(object pgrfcfcc, int i, bool[] barr1, bool[] barr2, bool[] barr3, bool[] barr4, bool[] barr5, bool[] barr6, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyRangeEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyRangeEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraPropertyRangeEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[Z[Z[Z[Z[Z[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) barr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) barr4);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) barr5);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) barr6);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyRangeEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, num6, num7, num8, num9, (int) num10, num11, num12, num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraPropertyEx(object pgrfcfcc, int i, bool[] barr1, bool[] barr2, bool[] barr3, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraPropertyEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[Z[Z[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) barr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, num6, (int) num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraPropertyEx(object pgrfcfcc, int i1, bool b1, bool b2, bool b3, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraPropertyEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IZZZII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = b1 ? 1 : 0;
        int num7 = b2 ? 1 : 0;
        int num8 = b3 ? 1 : 0;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, bool, bool, bool, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I)((int) num2, (int) num3, (bool) num4, num5 != 0, num6 != 0, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraPropertyBroadcastEx(object pgrfcfcc, int i1, bool b1, bool b2, bool b3, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraPropertyBroadcastEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IZZZII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = b1 ? 1 : 0;
        int num7 = b2 ? 1 : 0;
        int num8 = b3 ? 1 : 0;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, bool, bool, bool, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZII\u0029I)((int) num2, (int) num3, (bool) num4, num5 != 0, num6 != 0, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraAbsPropertyRange(object pgrfcfcc, int i, bool[] barr, float[] farr1, float[] farr2, object bp1, object bp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BF\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BF\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraAbsPropertyRange", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[F[FLcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BF\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029I)(num2, num3, num4, (IntPtr) num5, num6, (int) num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraAbsPropertyEx(object pgrfcfcc, int i, bool[] barr1, bool[] barr2, bool[] barr3, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BF\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BF\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraAbsPropertyEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[Z[Z[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) barr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BF\u0029I)(num2, num3, num4, (IntPtr) num5, (int) num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraAbsPropertyEx(object pgrfcfcc, int i, bool b1, bool b2, bool b3, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraAbsPropertyEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IZZZF)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        int num6 = b1 ? 1 : 0;
        int num7 = b2 ? 1 : 0;
        int num8 = b3 ? 1 : 0;
        double num9 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, bool, bool, bool, float)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I)((float) num2, (bool) num3, (bool) num4, num5 != 0, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraAbsPropertyBroadcastEx(object pgrfcfcc, int i, bool b1, bool b2, bool b3, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraAbsPropertyBroadcastEx", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IZZZF)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        int num6 = b1 ? 1 : 0;
        int num7 = b2 ? 1 : 0;
        int num8 = b3 ? 1 : 0;
        double num9 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, bool, bool, bool, float)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcastEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZZF\u0029I)((float) num2, (bool) num3, (bool) num4, num5 != 0, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraAbsPropertyBroadcast(object pgrfcfcc, int i, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraAbsPropertyBroadcast", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IF)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        double num6 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, float)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraAbsPropertyBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIF\u0029I)((float) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraRegisterBroadcast(object pgrfcfcc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraRegisterBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraRegisterBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraRegisterBroadcast", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraRegisterBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetMemoryChannel(object pgrfcfcc, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetMemoryChannel", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSaveToMemoryChannel(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSaveToMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSaveToMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSaveToMemoryChannel", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSaveToMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureRestoreFromMemoryChannel(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureRestoreFromMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureRestoreFromMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureRestoreFromMemoryChannel", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureRestoreFromMemoryChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCameraTrigger(object pgrfcfcc, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCameraTrigger", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraTrigger(object pgrfcfcc, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraTrigger", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetCameraTriggerBroadcast(object pgrfcfcc, byte b1, byte b2, byte b3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BBBB\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BBBB\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetCameraTriggerBroadcast", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;BBB)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = (int) b1;
        int num6 = (int) b2;
        int num7 = (int) b3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, byte, byte, byte)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetCameraTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BBBB\u0029I)((byte) num2, (byte) num3, (byte) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureQueryTrigger(object pgrfcfcc, bool[] barr1, bool[] barr2, bool[] barr3, bool[] barr4, bool[] barr5, int[] iarr1, bool[] barr6, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BZ\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BZ\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureQueryTrigger", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[Z[Z[Z[Z[Z[I[Z[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) barr4);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) barr5);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) barr6);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryTrigger\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BZ\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetTriggerBroadcast(object pgrfcfcc, bool b, int i1, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetTriggerBroadcast", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;ZIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = b ? 1 : 0;
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, bool, int, int, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetTriggerBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6 != 0, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetStrobe(object pgrfcfcc, int i, bool[] barr1, bool[] barr2, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetStrobe", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[Z[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, (int) num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetStrobe(object pgrfcfcc, int i1, bool b1, bool b2, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetStrobe", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IZZII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = b1 ? 1 : 0;
        int num7 = b2 ? 1 : 0;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, bool, bool, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I)((int) num2, (int) num3, (bool) num4, num5 != 0, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetStrobeBroadcast(object pgrfcfcc, int i1, bool b1, bool b2, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetStrobeBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetStrobeBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetStrobeBroadcast", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IZZII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = b1 ? 1 : 0;
        int num7 = b2 ? 1 : 0;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, bool, bool, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetStrobeBroadcast\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIZZII\u0029I)((int) num2, (int) num3, (bool) num4, num5 != 0, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureQueryStrobe(object pgrfcfcc, int i, bool[] barr1, bool[] barr2, bool[] barr3, bool[] barr4, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureQueryStrobe", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[Z[Z[Z[Z[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) barr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) barr4);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryStrobe\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BZ\u005BZ\u005BZ\u005BZ\u005BI\u005BI\u0029I)(num2, num3, num4, (IntPtr) num5, num6, num7, (int) num8, num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureQueryLookUpTable(object pgrfcfcc, bool[] barr1, int[] iarr1, bool[] barr2, int[] iarr2, int[] iarr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BZ\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BZ\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureQueryLookUpTable", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[Z[I[Z[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) barr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureQueryLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u005BI\u005BZ\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureEnableLookUpTable(object pgrfcfcc, bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureEnableLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureEnableLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureEnableLookUpTable", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, bool)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureEnableLookUpTable\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I)((bool) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetLookUpTableChannel(object pgrfcfcc, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetLookUpTableChannel", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetLookUpTableChannel(object pgrfcfcc, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetLookUpTableChannel", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetLookUpTableChannel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u005BI\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStartCustomImagePacket(object pgrfcfcc, int i1, int i2, int i3, int i4, int i5, int i6, int i7)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStartCustomImagePacket", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IIIIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        int num9 = i5;
        int num10 = i6;
        int num11 = i7;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStartLockNext(object pgrfcfcc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStartLockNext", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BII\u0029I)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStartLockNextCustomImage(object pgrfcfcc, int i1, int i2, int i3, int i4, int i5, float f, int i6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNextCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNextCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStartLockNextCustomImage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IIIIIFI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        int num9 = i5;
        double num10 = (double) f;
        int num11 = i6;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, int, int, float, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNextCustomImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIIIFI\u0029I)((int) num2, (float) num3, (int) num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureStartLockNextCustomImagePacket(object pgrfcfcc, long l1, long l2, long l3, long l4, long l5, long l6, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNextCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJJJJJJI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNextCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJJJJJJI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureStartLockNextCustomImagePacket", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;JJJJJJI)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        long num5 = l1;
        long num6 = l2;
        long num7 = l3;
        long num8 = l4;
        long num9 = l5;
        long num10 = l6;
        int num11 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, long, long, long, long, long, long, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureStartLockNextCustomImagePacket\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BJJJJJJI\u0029I)((int) num2, (long) num3, (long) num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSyncForLockNext(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSyncForLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSyncForLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSyncForLockNext", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSyncForLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureLockNext(object pgrfcfcc, object pgrfcfcip)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureLockNext", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImagePlus;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcip);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureLockNext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureLockLatest(object pgrfcfcc, object pgrfcfcip)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureLockLatest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureLockLatest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureLockLatest", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImagePlus;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcip);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureLockLatest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImagePlus\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureUnlock(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureUnlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureUnlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureUnlock", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureUnlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureUnlockAll(object pgrfcfcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureUnlockAll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureUnlockAll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureUnlockAll", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureUnlockAll\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetImageFilters(object pgrfcfcc, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetImageFilters", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetImageFilters(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetImageFilters", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetImageFilters\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetImageTimestamping(object pgrfcfcc, bool[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetImageTimestamping", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetImageTimestamping(object pgrfcfcc, bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetImageTimestamping", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, bool)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetImageTimestamping\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I)((bool) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureParseImageTimestamp(object pgrfcfcc, object bp, int[] iarr1, int[] iarr2, int[] iarr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureParseImageTimestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureParseImageTimestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureParseImageTimestamp", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacpp/BytePointer;[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureParseImageTimestamp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureWaitForImageEvent(object pgrfcfcc, object pgrfcfcie, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureWaitForImageEvent\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImageEvent\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureWaitForImageEvent\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImageEvent\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureWaitForImageEvent", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureImageEvent;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcie);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureWaitForImageEvent\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureImageEvent\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetPacketInfo(object pgrfcfcc, int i1, int i2, object pgrfcfcpi)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetPacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetPacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetPacketInfo", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IILcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCapturePacketInfo;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcpi);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetPacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I)(num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetCustomImagePacketInfo(object pgrfcfcc, int i1, int i2, int i3, int i4, object pgrfcfcpi)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCustomImagePacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCustomImagePacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetCustomImagePacketInfo", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;IIIILcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCapturePacketInfo;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcpi);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetCustomImagePacketInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCapturePacketInfo\u003B\u0029I)(num2, (int) num3, (int) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureReadRegisterBlock(object pgrfcfcc, short s, int i1, int[] iarr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureReadRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureReadRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureReadRegisterBlock", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;SI[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = (int) s;
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, short, int, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureReadRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I)((int) num2, num3, (int) num4, (short) num5, (IntPtr) num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureWriteRegisterBlock(object pgrfcfcc, short s, int i1, int[] iarr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureWriteRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureWriteRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureWriteRegisterBlock", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;SI[II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = (int) s;
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, short, int, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureWriteRegisterBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BSI\u005BII\u0029I)((int) num2, num3, (int) num4, (short) num5, (IntPtr) num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureSetMessageLoggingStatus(object pgrfcfcc, bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureSetMessageLoggingStatus", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, bool)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureSetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BZ\u0029I)((bool) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureGetMessageLoggingStatus(object pgrfcfcc, bool[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureGetMessageLoggingStatus", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;[Z)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureGetMessageLoggingStatus\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003B\u005BZ\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureInitializeMessaging(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializeMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializeMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureInitializeMessaging", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureInitializeMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureCloseMessaging(object pgrfcfcc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCloseMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCloseMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureCloseMessaging", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureCloseMessaging\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int flycaptureReceiveMessage(object pgrfcfcc, int i, object pgrfcfcm, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureReceiveMessage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureMessage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureReceiveMessage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureMessage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureReceiveMessage", "(Lcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureContext;ILcom/googlecode/javacv/cpp/PGRFlyCapture$FlyCaptureMessage;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pgrfcfcm);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureReceiveMessage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002FPGRFlyCapture\u0024FlyCaptureMessage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string flycaptureBusErrorToString(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(PGRFlyCapture.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/PGRFlyCapture", "flycaptureBusErrorToString", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PGRFlyCapture.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<PGRFlyCapture>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) PGRFlyCapture.__\u003Cjniptr\u003EflycaptureBusErrorToString\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
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

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PGRFlyCapture.__\u003CcallerID\u003E == null)
        PGRFlyCapture.__\u003CcallerID\u003E = (CallerID) new PGRFlyCapture.__\u003CCallerID\u003E();
      return PGRFlyCapture.__\u003CcallerID\u003E;
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
