// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_core
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
  public class opencv_core : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<opencv_core>.Value).desiredAssertionStatus();
    public const string genericIncludepath = "/opt/local/include/";
    public const string genericLinkpath = "/opt/local/lib/:/opt/local/lib64/:/usr/local/lib/:/usr/local/lib64/";
    public const string windowsIncludepath = "C:/OpenCV2.2/include/";
    public const string windowsLinkpath = "C:/OpenCV2.2/lib/";
    public const string windowsPreloadpath = "C:/OpenCV2.2/bin/Release/;C:/OpenCV2.2/bin/";
    public const string androidIncludepath = "../include/";
    public const string androidLinkpath = "../lib/";
    public const int CV_StsOk = 0;
    public const int CV_StsBackTrace = -1;
    public const int CV_StsError = -2;
    public const int CV_StsInternal = -3;
    public const int CV_StsNoMem = -4;
    public const int CV_StsBadArg = -5;
    public const int CV_StsBadFunc = -6;
    public const int CV_StsNoConv = -7;
    public const int CV_StsAutoTrace = -8;
    public const int CV_HeaderIsNull = -9;
    public const int CV_BadImageSize = -10;
    public const int CV_BadOffset = -11;
    public const int CV_BadDataPtr = -12;
    public const int CV_BadStep = -13;
    public const int CV_BadModelOrChSeq = -14;
    public const int CV_BadNumChannels = -15;
    public const int CV_BadNumChannel1U = -16;
    public const int CV_BadDepth = -17;
    public const int CV_BadAlphaChannel = -18;
    public const int CV_BadOrder = -19;
    public const int CV_BadOrigin = -20;
    public const int CV_BadAlign = -21;
    public const int CV_BadCallBack = -22;
    public const int CV_BadTileSize = -23;
    public const int CV_BadCOI = -24;
    public const int CV_BadROISize = -25;
    public const int CV_MaskIsTiled = -26;
    public const int CV_StsNullPtr = -27;
    public const int CV_StsVecLengthErr = -28;
    public const int CV_StsFilterStructContentErr = -29;
    public const int CV_StsKernelStructContentErr = -30;
    public const int CV_StsFilterOffsetErr = -31;
    public const int CV_StsBadSize = -201;
    public const int CV_StsDivByZero = -202;
    public const int CV_StsInplaceNotSupported = -203;
    public const int CV_StsObjectNotFound = -204;
    public const int CV_StsUnmatchedFormats = -205;
    public const int CV_StsBadFlag = -206;
    public const int CV_StsBadPoint = -207;
    public const int CV_StsBadMask = -208;
    public const int CV_StsUnmatchedSizes = -209;
    public const int CV_StsUnsupportedFormat = -210;
    public const int CV_StsOutOfRange = -211;
    public const int CV_StsParseError = -212;
    public const int CV_StsNotImplemented = -213;
    public const int CV_StsBadMemBlock = -214;
    public const int CV_StsAssert = -215;
    public const int CV_GpuNotSupported = -216;
    public const int CV_GpuApiCallError = -217;
    public const int CV_GpuNppCallError = -218;
    public const int IPL_DEPTH_SIGN = -2147483648;
    public const int IPL_DEPTH_1U = 1;
    public const int IPL_DEPTH_8U = 8;
    public const int IPL_DEPTH_16U = 16;
    public const int IPL_DEPTH_32F = 32;
    public const int IPL_DEPTH_8S = -2147483640;
    public const int IPL_DEPTH_16S = -2147483632;
    public const int IPL_DEPTH_32S = -2147483616;
    public const int IPL_DEPTH_64F = 64;
    public const int IPL_DATA_ORDER_PIXEL = 0;
    public const int IPL_DATA_ORDER_PLANE = 1;
    public const int IPL_ORIGIN_TL = 0;
    public const int IPL_ORIGIN_BL = 1;
    public const int IPL_ALIGN_4BYTES = 4;
    public const int IPL_ALIGN_8BYTES = 8;
    public const int IPL_ALIGN_16BYTES = 16;
    public const int IPL_ALIGN_32BYTES = 32;
    public const int IPL_ALIGN_DWORD = 4;
    public const int IPL_ALIGN_QWORD = 8;
    public const int IPL_BORDER_CONSTANT = 0;
    public const int IPL_BORDER_REPLICATE = 1;
    public const int IPL_BORDER_REFLECT = 2;
    public const int IPL_BORDER_WRAP = 3;
    public const int IPL_IMAGE_HEADER = 1;
    public const int IPL_IMAGE_DATA = 2;
    public const int IPL_IMAGE_ROI = 4;
    public const int IPL_BORDER_REFLECT_101 = 4;
    public const int IPL_BORDER_TRANSPARENT = 5;
    internal static int __\u003C\u003EIPL_IMAGE_MAGIC_VAL;
    public const string CV_TYPE_NAME_IMAGE = "opencv-image";
    public const int CV_CN_MAX = 512;
    public const int CV_CN_SHIFT = 3;
    public const int CV_DEPTH_MAX = 8;
    public const int CV_8U = 0;
    public const int CV_8S = 1;
    public const int CV_16U = 2;
    public const int CV_16S = 3;
    public const int CV_32S = 4;
    public const int CV_32F = 5;
    public const int CV_64F = 6;
    public const int CV_USRTYPE1 = 7;
    public const int CV_MAT_DEPTH_MASK = 7;
    internal static int __\u003C\u003ECV_8UC1;
    internal static int __\u003C\u003ECV_8UC2;
    internal static int __\u003C\u003ECV_8UC3;
    internal static int __\u003C\u003ECV_8UC4;
    internal static int __\u003C\u003ECV_8SC1;
    internal static int __\u003C\u003ECV_8SC2;
    internal static int __\u003C\u003ECV_8SC3;
    internal static int __\u003C\u003ECV_8SC4;
    internal static int __\u003C\u003ECV_16UC1;
    internal static int __\u003C\u003ECV_16UC2;
    internal static int __\u003C\u003ECV_16UC3;
    internal static int __\u003C\u003ECV_16UC4;
    internal static int __\u003C\u003ECV_16SC1;
    internal static int __\u003C\u003ECV_16SC2;
    internal static int __\u003C\u003ECV_16SC3;
    internal static int __\u003C\u003ECV_16SC4;
    internal static int __\u003C\u003ECV_32SC1;
    internal static int __\u003C\u003ECV_32SC2;
    internal static int __\u003C\u003ECV_32SC3;
    internal static int __\u003C\u003ECV_32SC4;
    internal static int __\u003C\u003ECV_32FC1;
    internal static int __\u003C\u003ECV_32FC2;
    internal static int __\u003C\u003ECV_32FC3;
    internal static int __\u003C\u003ECV_32FC4;
    internal static int __\u003C\u003ECV_64FC1;
    internal static int __\u003C\u003ECV_64FC2;
    internal static int __\u003C\u003ECV_64FC3;
    internal static int __\u003C\u003ECV_64FC4;
    public const int CV_AUTO_STEP = 2147483647;
    internal static object __\u003C\u003ECV_WHOLE_ARR;
    public const int CV_MAT_CN_MASK = 4088;
    public const int CV_MAT_TYPE_MASK = 4095;
    public const int CV_MAT_CONT_FLAG_SHIFT = 14;
    public const int CV_MAT_CONT_FLAG = 16384;
    public const int CV_MAT_TEMP_FLAG_SHIFT = 15;
    public const int CV_MAT_TEMP_FLAG = 32768;
    public const int CV_MAGIC_MASK = -65536;
    public const int CV_MAT_MAGIC_VAL = 1111621632;
    public const string CV_TYPE_NAME_MAT = "opencv-matrix";
    public const int CV_MATND_MAGIC_VAL = 1111687168;
    public const string CV_TYPE_NAME_MATND = "opencv-nd-matrix";
    public const int CV_MAX_DIM = 32;
    public const int CV_MAX_DIM_HEAP = 65536;
    public const int CV_SPARSE_MAT_MAGIC_VAL = 1111752704;
    public const string CV_TYPE_NAME_SPARSE_MAT = "opencv-sparse-matrix";
    public const int CV_TERMCRIT_ITER = 1;
    public const int CV_TERMCRIT_NUMBER = 1;
    public const int CV_TERMCRIT_EPS = 2;
    public const int CV_WHOLE_SEQ_END_INDEX = 1073741823;
    internal static object __\u003C\u003ECV_WHOLE_SEQ;
    public const int CV_STORAGE_MAGIC_VAL = 1116274688;
    public const string CV_TYPE_NAME_SEQ = "opencv-sequence";
    public const string CV_TYPE_NAME_SEQ_TREE = "opencv-sequence-tree";
    public const int CV_SET_ELEM_IDX_MASK = 67108863;
    public const int CV_SET_ELEM_FREE_FLAG = 128;
    public const string CV_TYPE_NAME_GRAPH = "opencv-graph";
    public const int CV_SEQ_MAGIC_VAL = 1117323264;
    public const int CV_SET_MAGIC_VAL = 1117257728;
    public const int CV_SEQ_ELTYPE_BITS = 12;
    public const int CV_SEQ_ELTYPE_MASK = 4095;
    internal static int __\u003C\u003ECV_SEQ_ELTYPE_POINT;
    internal static int __\u003C\u003ECV_SEQ_ELTYPE_CODE;
    public const int CV_SEQ_ELTYPE_GENERIC = 0;
    public const int CV_SEQ_ELTYPE_PTR = 7;
    public const int CV_SEQ_ELTYPE_PPOINT = 7;
    internal static int __\u003C\u003ECV_SEQ_ELTYPE_INDEX;
    public const int CV_SEQ_ELTYPE_GRAPH_EDGE = 0;
    public const int CV_SEQ_ELTYPE_GRAPH_VERTEX = 0;
    public const int CV_SEQ_ELTYPE_TRIAN_ATR = 0;
    public const int CV_SEQ_ELTYPE_CONNECTED_COMP = 0;
    internal static int __\u003C\u003ECV_SEQ_ELTYPE_POINT3D;
    public const int CV_SEQ_KIND_BITS = 2;
    public const int CV_SEQ_KIND_MASK = 12288;
    public const int CV_SEQ_KIND_GENERIC = 0;
    public const int CV_SEQ_KIND_CURVE = 4096;
    public const int CV_SEQ_KIND_BIN_TREE = 8192;
    public const int CV_SEQ_KIND_GRAPH = 4096;
    public const int CV_SEQ_KIND_SUBDIV2D = 8192;
    public const int CV_SEQ_FLAG_SHIFT = 14;
    public const int CV_SEQ_FLAG_CLOSED = 16384;
    public const int CV_SEQ_FLAG_SIMPLE = 0;
    public const int CV_SEQ_FLAG_CONVEX = 0;
    public const int CV_SEQ_FLAG_HOLE = 32768;
    public const int CV_GRAPH_FLAG_ORIENTED = 16384;
    public const int CV_GRAPH = 4096;
    public const int CV_ORIENTED_GRAPH = 20480;
    internal static int __\u003C\u003ECV_SEQ_POINT_SET;
    internal static int __\u003C\u003ECV_SEQ_POINT3D_SET;
    internal static int __\u003C\u003ECV_SEQ_POLYLINE;
    internal static int __\u003C\u003ECV_SEQ_POLYGON;
    internal static int __\u003C\u003ECV_SEQ_CONTOUR;
    internal static int __\u003C\u003ECV_SEQ_SIMPLE_POLYGON;
    internal static int __\u003C\u003ECV_SEQ_CHAIN;
    internal static int __\u003C\u003ECV_SEQ_CHAIN_CONTOUR;
    public const int CV_SEQ_POLYGON_TREE = 8192;
    public const int CV_SEQ_CONNECTED_COMP = 0;
    internal static int __\u003C\u003ECV_SEQ_INDEX;
    public const int CV_STORAGE_READ = 0;
    public const int CV_STORAGE_WRITE = 1;
    public const int CV_STORAGE_WRITE_TEXT = 1;
    public const int CV_STORAGE_WRITE_BINARY = 1;
    public const int CV_STORAGE_APPEND = 2;
    public const int CV_NODE_NONE = 0;
    public const int CV_NODE_INT = 1;
    public const int CV_NODE_INTEGER = 1;
    public const int CV_NODE_REAL = 2;
    public const int CV_NODE_FLOAT = 2;
    public const int CV_NODE_STR = 3;
    public const int CV_NODE_STRING = 3;
    public const int CV_NODE_REF = 4;
    public const int CV_NODE_SEQ = 5;
    public const int CV_NODE_MAP = 6;
    public const int CV_NODE_TYPE_MASK = 7;
    public const int CV_NODE_FLOW = 8;
    public const int CV_NODE_USER = 16;
    public const int CV_NODE_EMPTY = 32;
    public const int CV_NODE_NAMED = 64;
    public const int CV_NODE_SEQ_SIMPLE = 256;
    public const int CV_AUTOSTEP = 2147483647;
    public const int CV_MAX_ARR = 10;
    public const int CV_NO_DEPTH_CHECK = 1;
    public const int CV_NO_CN_CHECK = 2;
    public const int CV_NO_SIZE_CHECK = 4;
    public const int CV_CMP_EQ = 0;
    public const int CV_CMP_GT = 1;
    public const int CV_CMP_GE = 2;
    public const int CV_CMP_LT = 3;
    public const int CV_CMP_LE = 4;
    public const int CV_CMP_NE = 5;
    public const int CV_CHECK_RANGE = 1;
    public const int CV_CHECK_QUIET = 2;
    public const int CV_RAND_UNI = 0;
    public const int CV_RAND_NORMAL = 1;
    public const int CV_SORT_EVERY_ROW = 0;
    public const int CV_SORT_EVERY_COLUMN = 1;
    public const int CV_SORT_ASCENDING = 0;
    public const int CV_SORT_DESCENDING = 16;
    public const int CV_GEMM_A_T = 1;
    public const int CV_GEMM_B_T = 2;
    public const int CV_GEMM_C_T = 4;
    public const int CV_SVD_MODIFY_A = 1;
    public const int CV_SVD_U_T = 2;
    public const int CV_SVD_V_T = 4;
    public const int CV_LU = 0;
    public const int CV_SVD = 1;
    public const int CV_SVD_SYM = 2;
    public const int CV_CHOLESKY = 3;
    public const int CV_QR = 4;
    public const int CV_LSQ = 8;
    public const int CV_NORMAL = 16;
    public const int CV_COVAR_SCRAMBLED = 0;
    public const int CV_COVAR_NORMAL = 1;
    public const int CV_COVAR_USE_AVG = 2;
    public const int CV_COVAR_SCALE = 4;
    public const int CV_COVAR_ROWS = 8;
    public const int CV_COVAR_COLS = 16;
    public const int CV_PCA_DATA_AS_ROW = 0;
    public const int CV_PCA_DATA_AS_COL = 1;
    public const int CV_PCA_USE_AVG = 2;
    public const int CV_C = 1;
    public const int CV_L1 = 2;
    public const int CV_L2 = 4;
    public const int CV_NORM_MASK = 7;
    public const int CV_RELATIVE = 8;
    public const int CV_DIFF = 16;
    public const int CV_MINMAX = 32;
    public const int CV_DIFF_C = 17;
    public const int CV_DIFF_L1 = 18;
    public const int CV_DIFF_L2 = 20;
    public const int CV_RELATIVE_C = 9;
    public const int CV_RELATIVE_L1 = 10;
    public const int CV_RELATIVE_L2 = 12;
    public const int CV_REDUCE_SUM = 0;
    public const int CV_REDUCE_AVG = 1;
    public const int CV_REDUCE_MAX = 2;
    public const int CV_REDUCE_MIN = 3;
    public const int CV_DXT_FORWARD = 0;
    public const int CV_DXT_INVERSE = 1;
    public const int CV_DXT_SCALE = 2;
    public const int CV_DXT_INV_SCALE = 3;
    public const int CV_DXT_INVERSE_SCALE = 3;
    public const int CV_DXT_ROWS = 4;
    public const int CV_DXT_MUL_CONJ = 8;
    public const int CV_FRONT = 1;
    public const int CV_BACK = 0;
    public const int CV_GRAPH_VERTEX = 1;
    public const int CV_GRAPH_TREE_EDGE = 2;
    public const int CV_GRAPH_BACK_EDGE = 4;
    public const int CV_GRAPH_FORWARD_EDGE = 8;
    public const int CV_GRAPH_CROSS_EDGE = 16;
    public const int CV_GRAPH_ANY_EDGE = 30;
    public const int CV_GRAPH_NEW_TREE = 32;
    public const int CV_GRAPH_BACKTRACKING = 64;
    public const int CV_GRAPH_OVER = -1;
    public const int CV_GRAPH_ALL_ITEMS = -1;
    public const int CV_GRAPH_ITEM_VISITED_FLAG = 1073741824;
    public const int CV_GRAPH_SEARCH_TREE_NODE_FLAG = 536870912;
    public const int CV_GRAPH_FORWARD_EDGE_FLAG = 268435456;
    public const int CV_FILLED = -1;
    public const int CV_AA = 16;
    public const int CV_FONT_HERSHEY_SIMPLEX = 0;
    public const int CV_FONT_HERSHEY_PLAIN = 1;
    public const int CV_FONT_HERSHEY_DUPLEX = 2;
    public const int CV_FONT_HERSHEY_COMPLEX = 3;
    public const int CV_FONT_HERSHEY_TRIPLEX = 4;
    public const int CV_FONT_HERSHEY_COMPLEX_SMALL = 5;
    public const int CV_FONT_HERSHEY_SCRIPT_SIMPLEX = 6;
    public const int CV_FONT_HERSHEY_SCRIPT_COMPLEX = 7;
    public const int CV_FONT_ITALIC = 16;
    public const int CV_FONT_VECTOR0 = 0;
    public const int CV_KMEANS_USE_INITIAL_LABELS = 1;
    public const int CV_CPU_NONE = 0;
    public const int CV_CPU_MMX = 1;
    public const int CV_CPU_SSE = 2;
    public const int CV_CPU_SSE2 = 3;
    public const int CV_CPU_SSE3 = 4;
    public const int CV_CPU_SSSE3 = 5;
    public const int CV_CPU_SSE4_1 = 6;
    public const int CV_CPU_SSE4_2 = 7;
    public const int CV_CPU_AVX = 10;
    public const int CV_HARDWARE_MAX_FEATURE = 255;
    public const int CV_ErrModeLeaf = 0;
    public const int CV_ErrModeParent = 1;
    public const int CV_ErrModeSilent = 2;
    static IntPtr __\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM_VAR\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003ECV_NEXT_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003ECV_PREV_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003ECV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003ECV_REV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAlloc\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFree_\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvReleaseImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCloneImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvResetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateMatHeader\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitMatHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateMat\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCloneMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetSubRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetRows\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetCols\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetDiag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvScalarToRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRawDataToScalar\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateMatNDHeader\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateMatND\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitMatNDHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BI\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCloneMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateSparseMat\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCloneSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitSparseMatIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetNextSparseNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitNArrayIterator\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvNextNArraySlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetElemType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetDims\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetDimSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvPtr1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvPtr2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvPtr3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvPtrND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u005BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvSet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClearND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReshapeMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReshape\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvRepeat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvReleaseData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCopy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSplit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMerge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMixChannels\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvConvertScale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvConvertScaleAbs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCheckTermCriteria\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B;
    static IntPtr __\u003Cjniptr\u003EcvAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAddS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSub\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSubRS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMul\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDiv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvScaleAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAddWeighted\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDotProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvAnd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAndS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvOr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvOrS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvXor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvXorS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvNot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInRangeS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCmp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCmpS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMin\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMax\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMinS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMaxS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAbsDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAbsDiffS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCartToPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPolarToCart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPow\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvExp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLog\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFastArctan\u0028FF\u0029F;
    static IntPtr __\u003Cjniptr\u003EcvCbrt\u0028F\u0029F;
    static IntPtr __\u003Cjniptr\u003EcvCheckArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDD\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvRandArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRandShuffle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSolveCubic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSolvePoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCrossProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGEMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMulTransposed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvTranspose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCompleteSymm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFlip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSVD\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSVBkSb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvSolve\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvDet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvTrace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvEigenVV\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetIdentity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCalcCovarMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvBackProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMahalanobis\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvSum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCountNonZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvAvgSdv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMinMaxLoc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvNorm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvNormalize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvReduce\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDFT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMulSpectrums\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetOptimalDFTSize\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvDCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSliceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateMemStorage\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateChildMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClearMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSaveMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRestoreMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMemStorageAlloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSetSeqBlockSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqPush\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqPushFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqPop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqPopFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqPushMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqPopMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClearSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetSeqElem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqElemIdx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvStartAppendToSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvStartWriteSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEndWriteSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFlushSeqWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvStartReadSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCvtSeqToArray\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMakeSeqHeaderForArray\u0028IIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqRemoveSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqInsertSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqSearch\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BI\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSeqInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSeqPartition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvChangeSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateSet\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSetAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClearSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateGraph\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGraphAddVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGraphRemoveVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGraphRemoveVtxByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGraphAddEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGraphAddEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGraphRemoveEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGraphRemoveEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindGraphEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFindGraphEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B;
    static IntPtr __\u003Cjniptr\u003EcvClearGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGraphVtxDegree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGraphVtxDegreeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvNextGraphItem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCloneGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B;
    static IntPtr __\u003Cjniptr\u003EcvLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRectangle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRectangleR\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEllipse\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFillConvexPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClipLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvInitLineIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003ECV_NEXT_LINE_POINT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInitFont\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BIDDDII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPutText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetTextSize\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvColorToScalar\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B;
    static IntPtr __\u003Cjniptr\u003EcvEllipse2Poly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvDrawContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLUT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInitTreeNodeIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvNextTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvPrevTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInsertNodeIntoTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRemoveNodeFromTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvTreeToNodeSeq\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvKMeans2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvRegisterModule\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvModuleInfo\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvUseOptimized\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetModuleInfo\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetMemoryManager\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAllocFunc\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFreeFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetIPLAllocators\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateImageHeader\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplAllocateImageData\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplDeallocate\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateROI\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCloneImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvOpenFileStorage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseFileStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvAttrValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003EcvStartWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEndWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWriteInt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWriteReal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWriteString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWriteComment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWrite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvStartNextStream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWriteRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetHashedKey\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetRootFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetFileNodeByName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B;
    static IntPtr __\u003Cjniptr\u003EcvRead\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvStartReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvReadRawDataSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWriteFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetFileNodeName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003EcvRegisterType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvUnregisterType\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFirstType\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFindType\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B;
    static IntPtr __\u003Cjniptr\u003EcvTypeOf\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B;
    static IntPtr __\u003Cjniptr\u003EcvRelease\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClone\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSave\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLoad\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetTickCount\u0028\u0029J;
    static IntPtr __\u003Cjniptr\u003EcvGetTickFrequency\u0028\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvCheckHardwareSupport\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetNumThreads\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetNumThreads\u0028I\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetThreadNum\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetErrStatus\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetErrStatus\u0028I\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetErrMode\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetErrMode\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvError\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvErrorStr\u0028I\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetErrInfo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvErrorFromIppStatus\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvRedirectError\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003B;
    static IntPtr __\u003Cjniptr\u003EcvNulDevReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvStdErrReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGuiBoxReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;

    [Modifiers]
    public static int IPL_IMAGE_MAGIC_VAL
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003EIPL_IMAGE_MAGIC_VAL;
      }
    }

    [Modifiers]
    public static int CV_8UC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8UC1;
      }
    }

    [Modifiers]
    public static int CV_8UC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8UC2;
      }
    }

    [Modifiers]
    public static int CV_8UC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8UC3;
      }
    }

    [Modifiers]
    public static int CV_8UC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8UC4;
      }
    }

    [Modifiers]
    public static int CV_8SC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8SC1;
      }
    }

    [Modifiers]
    public static int CV_8SC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8SC2;
      }
    }

    [Modifiers]
    public static int CV_8SC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8SC3;
      }
    }

    [Modifiers]
    public static int CV_8SC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_8SC4;
      }
    }

    [Modifiers]
    public static int CV_16UC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16UC1;
      }
    }

    [Modifiers]
    public static int CV_16UC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16UC2;
      }
    }

    [Modifiers]
    public static int CV_16UC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16UC3;
      }
    }

    [Modifiers]
    public static int CV_16UC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16UC4;
      }
    }

    [Modifiers]
    public static int CV_16SC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16SC1;
      }
    }

    [Modifiers]
    public static int CV_16SC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16SC2;
      }
    }

    [Modifiers]
    public static int CV_16SC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16SC3;
      }
    }

    [Modifiers]
    public static int CV_16SC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_16SC4;
      }
    }

    [Modifiers]
    public static int CV_32SC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32SC1;
      }
    }

    [Modifiers]
    public static int CV_32SC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32SC2;
      }
    }

    [Modifiers]
    public static int CV_32SC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32SC3;
      }
    }

    [Modifiers]
    public static int CV_32SC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32SC4;
      }
    }

    [Modifiers]
    public static int CV_32FC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32FC1;
      }
    }

    [Modifiers]
    public static int CV_32FC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32FC2;
      }
    }

    [Modifiers]
    public static int CV_32FC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32FC3;
      }
    }

    [Modifiers]
    public static int CV_32FC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_32FC4;
      }
    }

    [Modifiers]
    public static int CV_64FC1
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_64FC1;
      }
    }

    [Modifiers]
    public static int CV_64FC2
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_64FC2;
      }
    }

    [Modifiers]
    public static int CV_64FC3
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_64FC3;
      }
    }

    [Modifiers]
    public static int CV_64FC4
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_64FC4;
      }
    }

    [Modifiers]
    public static object CV_WHOLE_ARR
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_WHOLE_ARR;
      }
    }

    [Modifiers]
    public static object CV_WHOLE_SEQ
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_WHOLE_SEQ;
      }
    }

    [Modifiers]
    public static int CV_SEQ_ELTYPE_POINT
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_ELTYPE_POINT;
      }
    }

    [Modifiers]
    public static int CV_SEQ_ELTYPE_CODE
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_ELTYPE_CODE;
      }
    }

    [Modifiers]
    public static int CV_SEQ_ELTYPE_INDEX
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_ELTYPE_INDEX;
      }
    }

    [Modifiers]
    public static int CV_SEQ_ELTYPE_POINT3D
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_ELTYPE_POINT3D;
      }
    }

    [Modifiers]
    public static int CV_SEQ_POINT_SET
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_POINT_SET;
      }
    }

    [Modifiers]
    public static int CV_SEQ_POINT3D_SET
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_POINT3D_SET;
      }
    }

    [Modifiers]
    public static int CV_SEQ_POLYLINE
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_POLYLINE;
      }
    }

    [Modifiers]
    public static int CV_SEQ_POLYGON
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_POLYGON;
      }
    }

    [Modifiers]
    public static int CV_SEQ_CONTOUR
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_CONTOUR;
      }
    }

    [Modifiers]
    public static int CV_SEQ_SIMPLE_POLYGON
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_SIMPLE_POLYGON;
      }
    }

    [Modifiers]
    public static int CV_SEQ_CHAIN
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_CHAIN;
      }
    }

    [Modifiers]
    public static int CV_SEQ_CHAIN_CONTOUR
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_CHAIN_CONTOUR;
      }
    }

    [Modifiers]
    public static int CV_SEQ_INDEX
    {
      [HideFromJava] get
      {
        return opencv_core.__\u003C\u003ECV_SEQ_INDEX;
      }
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 245, (byte) 71})]
    static opencv_core()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 232, (byte) 175, (byte) 54})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_core()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void cvGEMM(object ca1, object ca2, double d1, object ca3, double d2, object ca4, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGEMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGEMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGEMM", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num8 = d2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num10 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr, double, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGEMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, (double) num4, num5, num6, num7, (IntPtr) num8, num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvDotProduct(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvDotProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvDotProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvDotProduct", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvDotProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 103, (byte) 191, (byte) 20, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvMatMul(object src1, object src2, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object src1_1 = src1;
      object obj1 = src2;
      // ISSUE: variable of the null type
      __Null local = null;
      object obj2 = dst;
      object obj3 = (object) local;
      object src2_1 = obj1;
      object src3 = obj3;
      object dst1 = obj2;
      opencv_core.cvMatMulAdd(src1_1, src2_1, src3, dst1);
    }

    [Modifiers]
    public static double cvInvert(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInvert", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvConvertScale(object ca1, object ca2, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvConvertScale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvConvertScale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvConvertScale", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double)>) opencv_core.__\u003Cjniptr\u003EcvConvertScale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V)((double) num2, (double) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 2075)]
    public static object cvSize(int width, int height)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSize");
    }

    [LineNumberTable((ushort) 3277)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvInvert(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num = 0;
      object ca2 = obj;
      int i = num;
      return opencv_core.cvInvert(ca1, ca2, i);
    }

    [LineNumberTable((ushort) 2753)]
    public static object cvAttrList()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvAttrList");
    }

    [Modifiers]
    public static void cvStartWriteStruct(object cfs, string str1, int i, string str2, object cal)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStartWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStartWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStartWriteStruct", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;ILjava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvAttrList;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cal);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvStartWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BILjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V)(num2, num3, (int) num4, num5, (IntPtr) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvWriteString(object cfs, string str1, string str2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWriteString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWriteString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWriteString", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvWriteString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEndWriteStruct(object cfs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvEndWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvEndWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvEndWriteStruct", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvEndWriteStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvWriteInt(object cfs, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWriteInt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWriteInt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWriteInt", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvWriteInt\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvWriteReal(object cfs, string str, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWriteReal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWriteReal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWriteReal", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvWriteReal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BD\u0029V)((double) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvWrite(object cfs, string str, object p, object cal)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWrite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWrite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWrite", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvAttrList;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cal);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvWrite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetFileNodeByName(object cfs, object cfn, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetFileNodeByName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetFileNodeByName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetFileNodeByName", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;Ljava/lang/String;)Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetFileNodeByName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3899)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvReadIntByName(object fs, object map, string name, int default_value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      object cfs = fs;
      object obj = map;
      string str1 = name;
      object cfn = obj;
      string str2 = str1;
      return opencv_core.cvReadInt(opencv_core.cvGetFileNodeByName(cfs, cfn, str2), default_value);
    }

    [LineNumberTable((ushort) 3913)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvReadRealByName(object fs, object map, string name, double default_value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      object cfs = fs;
      object obj = map;
      string str1 = name;
      object cfn = obj;
      string str2 = str1;
      return opencv_core.cvReadReal(opencv_core.cvGetFileNodeByName(cfs, cfn, str2), default_value);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 181, (byte) 95, (byte) 20, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvReadByName(object fs, object map, string name, object attributes)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(attributes, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvAttrList");
      object cfs1 = fs;
      object obj1 = map;
      string str1 = name;
      object cfn1 = obj1;
      string str2 = str1;
      object fileNodeByName = opencv_core.cvGetFileNodeByName(cfs1, cfn1, str2);
      object cfs2 = fs;
      object obj2 = fileNodeByName;
      object obj3 = attributes;
      object cfn2 = obj2;
      object cal = obj3;
      return opencv_core.cvRead(cfs2, cfn2, cal);
    }

    [LineNumberTable((ushort) 3936)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string cvReadStringByName(object fs, object map, string name, string default_value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      object cfs = fs;
      object obj = map;
      string str1 = name;
      object cfn = obj;
      string str2 = str1;
      return opencv_core.cvReadString(opencv_core.cvGetFileNodeByName(cfs, cfn, str2), default_value);
    }

    [Modifiers]
    public static object cvGetSeqElem(object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetSeqElem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetSeqElem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetSeqElem", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetSeqElem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 187, (byte) 177, (byte) 99, (byte) 98})]
    public static string cvReadString(object node, string default_value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      if (node == null)
        return default_value;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileNode");
    }

    [Modifiers]
    public static int cvSolve(object ca1, object ca2, object ca3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSolve\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSolve\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSolve", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSolve\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3361)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvNorm(object arr1, object arr2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = arr1;
      object obj1 = arr2;
      int num1 = 4;
      object obj2 = (object) null;
      int num2 = num1;
      object ca2 = obj1;
      int i = num2;
      object ca3 = obj2;
      return opencv_core.cvNorm(ca1, ca2, i, ca3);
    }

    [Modifiers]
    public static void cvAvgSdv(object ca1, object cs1, object cs2, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAvgSdv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAvgSdv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAvgSdv", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAvgSdv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetImageROI(object ii, object cr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetImageROI", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvResetImageROI(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvResetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvResetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvResetImageROI", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvResetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetZero(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetZero", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFillConvexPoly(object ca, object cp, int i1, object cs, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFillConvexPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFillConvexPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFillConvexPoly", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvFillConvexPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V)((int) num2, (int) num3, num4, (int) num5, (IntPtr) num6, num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 85, (byte) 113, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvSetIdentity(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      opencv_core.cvSetIdentity(mat, 1.0);
    }

    [Modifiers]
    public static void cvPerspectiveTransform(object ca1, object ca2, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPerspectiveTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 134, (byte) 159, (byte) 3, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvCopy(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj1 = dst;
      object obj2 = (object) null;
      object ca2 = obj1;
      object ca3 = obj2;
      opencv_core.cvCopy(ca1, ca2, ca3);
    }

    [Modifiers]
    public static object cvGetCols(object ca, object cm, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetCols\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetCols\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetCols", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;II)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGetCols\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetRows(object ca, object cm, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetRows\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetRows\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetRows", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;III)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGetRows\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvCheckArr(object ca, int i, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCheckArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDD\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCheckArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDD\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCheckArr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IDD)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        double num6 = d1;
        double num7 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, double, double)>) opencv_core.__\u003Cjniptr\u003EcvCheckArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDD\u0029I)((double) num2, (double) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 1733)]
    public static object cvTermCriteria(int type, int max_iter, double epsilon)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvTermCriteria");
    }

    [Modifiers]
    public static object cvCvtSeqToArray(object cs1, object p, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCvtSeqToArray\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCvtSeqToArray\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCvtSeqToArray", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvSlice;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCvtSeqToArray\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFillPoly(object ca, object cp, int[] iarr, int i1, object cs, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFillPoly", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;[IILcom/googlecode/javacv/cpp/opencv_core$CvScalar;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i1;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V)((int) num2, (int) num3, num4, (int) num5, num6, (IntPtr) num7, num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvCountNonZero(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCountNonZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCountNonZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCountNonZero", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCountNonZero\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCircle(object ca, object cp, int i1, object cs, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCircle", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num8 = i2;
        int num9 = i3;
        int num10 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRectangle(object ca, object cp1, object cp2, object cs, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRectangle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRectangle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRectangle", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num8 = i1;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvRectangle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvLine(object ca, object cp1, object cp2, object cs, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num8 = i1;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvClearMemStorage(object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClearMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClearMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClearMemStorage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClearMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSVD(object ca1, object ca2, object ca3, object ca4, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSVD\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSVD\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSVD", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSVD\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3364)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvNorm(object arr1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = arr1;
      // ISSUE: variable of the null type
      __Null local = null;
      int num1 = 4;
      object obj = (object) null;
      int num2 = num1;
      object ca2 = (object) local;
      int i = num2;
      object ca3 = obj;
      return opencv_core.cvNorm(ca1, ca2, i, ca3);
    }

    [LineNumberTable((ushort) 2225)]
    public static object cvRealScalar(double val0)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [Modifiers]
    public static void cvRandArr(object crng, object ca, int i, object cs1, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRandArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRandArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRandArr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvRNG;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(crng);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRandArr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, num3, (int) num4, num5, (IntPtr) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 133, (byte) 159, (byte) 3, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvSet(object arr, object value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(value, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca1 = arr;
      object obj1 = value;
      object obj2 = (object) null;
      object cs = obj1;
      object ca2 = obj2;
      opencv_core.cvSet(ca1, cs, ca2);
    }

    [LineNumberTable((ushort) 3598)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object CV_RGB(double r, double g, double b)
    {
      return opencv_core.cvScalar(b, g, r, 0.0);
    }

    [Modifiers]
    public static void cvPolyLine(object ca, object cp, int[] iarr, int i1, int i2, object cs, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPolyLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;[IIILcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i1;
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num10 = i3;
        int num11 = i4;
        int num12 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, (int) num6, num7, (IntPtr) num8, num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvGetTextSize(string str, object cf, object cs, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetTextSize\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetTextSize\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetTextSize", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvFont;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cf);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetTextSize\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvPutText(object ca, string str, object cp, object cf, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPutText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPutText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPutText", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvFont;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cf);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPutText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvAnd(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAnd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAnd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAnd", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAnd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvAvg(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAvg", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvTranspose(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvTranspose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvTranspose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvTranspose", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvTranspose\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 2222)]
    public static object cvScalar(double val0, double val1, double val2, double val3)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [Modifiers]
    public static void cvMul(object ca1, object ca2, object ca3, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMul\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMul\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMul", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvMul\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V)((double) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvTransform(object ca1, object ca2, object cm1, object cm2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvAddWeighted(object ca1, double d1, object ca2, double d2, double d3, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAddWeighted\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAddWeighted\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAddWeighted", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;DDLcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        double num5 = d1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num7 = d2;
        double num8 = d3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double, IntPtr, double, double, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAddWeighted\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (double) num3, (double) num4, (IntPtr) num5, (double) num6, (IntPtr) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSub(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSub\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSub\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSub", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSub\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvAddS(object ca1, object cs, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAddS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAddS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAddS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAddS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDiv(object ca1, object ca2, object ca3, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvDiv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvDiv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvDiv", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvDiv\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V)((double) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvNot(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNot", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNot\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSet(object ca1, object cs, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSet", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 230)]
    public static object cvRNG(long seed)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRNG");
    }

    [LineNumberTable((ushort) 233)]
    public static int cvRandInt(object rng)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(rng, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvRNG");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRNG");
    }

    [LineNumberTable((ushort) 949)]
    public static bool CV_IS_IMAGE_HDR(object img)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (img != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      else
        return false;
    }

    public static int CV_MAT_DEPTH(int flags)
    {
      return flags & 7;
    }

    [LineNumberTable((ushort) 973)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_MAKETYPE(int depth, int cn)
    {
      return opencv_core.CV_MAT_DEPTH(depth) + (cn - 1 << 3);
    }

    public static bool CV_IS_MAT_CONT(int flags)
    {
      return (flags & 16384) != 0;
    }

    [LineNumberTable((ushort) 1439)]
    public static bool CV_IS_MAT_HDR(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    public static int CV_MAT_CN(int flags)
    {
      return ((flags & 4088) >> 3) + 1;
    }

    public static int CV_MAT_TYPE(int flags)
    {
      return flags & 4095;
    }

    [LineNumberTable((ushort) 1473)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_ELEM_SIZE(int type)
    {
      opencv_core.CV_MAT_CN(type);
      throw new NoClassDefFoundError("com.googlecode.javacpp.SizeTPointer");
    }

    [LineNumberTable((ushort) 1470)]
    public static int CV_ELEM_SIZE1(int type)
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.SizeTPointer");
    }

    [LineNumberTable((ushort) 1569)]
    public static bool CV_IS_MATND_HDR(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (mat != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMatND");
      else
        return false;
    }

    [LineNumberTable((ushort) 1627)]
    public static bool CV_IS_SPARSE_MAT_HDR(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (mat != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSparseMat");
      else
        return false;
    }

    [LineNumberTable((ushort) 1696)]
    public static object cvRect(int x, int y, int width, int height)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
    }

    [LineNumberTable((ushort) 1865)]
    public static object cvPoint2D32f(double x, double y)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
    }

    [LineNumberTable((ushort) 2585)]
    public static int CV_SEQ_ELTYPE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 2586)]
    public static int CV_SEQ_KIND(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 2588)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_INDEX(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_SEQ_ELTYPE(seq) == opencv_core.__\u003C\u003ECV_SEQ_ELTYPE_INDEX && opencv_core.CV_SEQ_KIND(seq) == 0;
    }

    [LineNumberTable((ushort) 2598)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_POINT_SET(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_SEQ_ELTYPE(seq) == opencv_core.__\u003C\u003ECV_32SC2 || opencv_core.CV_SEQ_ELTYPE(seq) == opencv_core.__\u003C\u003ECV_32FC2;
    }

    [LineNumberTable((ushort) 2604)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_POLYLINE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_SEQ_KIND(seq) == 4096 && opencv_core.CV_IS_SEQ_POINT_SET(seq);
    }

    [LineNumberTable((ushort) 2592)]
    public static bool CV_IS_SEQ_CLOSED(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 2610)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_CHAIN(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      if (opencv_core.CV_SEQ_KIND(seq) != 4096)
        return false;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 2582)]
    public static bool CV_IS_SET(object set)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(set, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (set != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSet");
      else
        return false;
    }

    [LineNumberTable((ushort) 2690)]
    public static object CV_PREV_POINT(object reader)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(reader, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable((ushort) 2689)]
    public static object CV_CURRENT_POINT(object reader)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(reader, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [Modifiers]
    public static void CV_NEXT_SEQ_ELEM(int i, object csr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_NEXT_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_NEXT_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_NEXT_SEQ_ELEM", "(ILcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_NEXT_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    public static int CV_NODE_TYPE(int flags)
    {
      return flags & 7;
    }

    [Modifiers]
    public static void cvFree_(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFree_\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFree_\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFree_", "(Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvFree_\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetSubRect(object ca, object cm, object cr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetSubRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetSubRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetSubRect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetSubRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvInitNArrayIterator(int i1, object pp, object ca, object cmnd, object cnai, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitNArrayIterator\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitNArrayIterator\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitNArrayIterator", "(ILcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;Lcom/googlecode/javacv/cpp/opencv_core$CvNArrayIterator;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cmnd);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cnai);
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvInitNArrayIterator\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003BI\u0029I)((int) num2, num3, (IntPtr) num4, num5, num6, (int) num7, num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvReshapeMatND(object ca1, int i1, object ca2, int i2, int i3, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReshapeMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReshapeMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReshapeMatND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;II[I)Lcom/googlecode/javacv/cpp/opencv_core$CvArr;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num7 = i2;
        int num8 = i3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReshapeMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B)(num2, (int) num3, (int) num4, (IntPtr) num5, (int) num6, (IntPtr) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCopy(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCopy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCopy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCopy", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCopy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMixChannels(object pp1, int i1, object pp2, int i2, int[] iarr, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMixChannels\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMixChannels\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMixChannels", "(Lcom/googlecode/javacpp/PointerPointer;ILcom/googlecode/javacpp/PointerPointer;I[II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp2);
        int num7 = i2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvMixChannels\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u005BII\u0029V)((int) num2, num3, (int) num4, (IntPtr) num5, (int) num6, (IntPtr) num7, num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvConvertScaleAbs(object ca1, object ca2, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvConvertScaleAbs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvConvertScaleAbs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvConvertScaleAbs", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double)>) opencv_core.__\u003Cjniptr\u003EcvConvertScaleAbs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V)((double) num2, (double) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvScaleAdd(object ca1, object cs, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvScaleAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvScaleAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvScaleAdd", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvScaleAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 2228)]
    public static object cvScalarAll(double val0123)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [Modifiers]
    public static void cvAbsDiffS(object ca1, object ca2, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAbsDiffS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAbsDiffS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAbsDiffS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAbsDiffS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 103, (byte) 95, (byte) 37, (byte) 127, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvMatMulAdd(object src1, object src2, object src3, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src3, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src1;
      object obj1 = src2;
      double num1 = 1.0;
      object obj2 = src3;
      double num2 = 1.0;
      object obj3 = dst;
      int num3 = 0;
      object obj4 = obj3;
      double num4 = num2;
      object obj5 = obj2;
      double num5 = num1;
      object ca2 = obj1;
      double d1 = num5;
      object ca3 = obj5;
      double d2 = num4;
      object ca4 = obj4;
      int i = num3;
      opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
    }

    [Modifiers]
    public static void cvFlip(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFlip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFlip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFlip", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvFlip\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetIdentity(object ca, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetIdentity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetIdentity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetIdentity", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetIdentity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 86, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvSetIdentity(object mat, double value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      opencv_core.cvSetIdentity(mat, opencv_core.cvRealScalar(value));
    }

    [Modifiers]
    public static void cvCalcCovarMatrix(object pp, int i1, object ca1, object ca2, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCalcCovarMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCalcCovarMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCalcCovarMatrix", "(Lcom/googlecode/javacpp/PointerPointer;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCalcCovarMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvMahalanobis(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMahalanobis\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMahalanobis\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMahalanobis", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMahalanobis\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvNorm(object ca1, object ca2, int i, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNorm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNorm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNorm", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNorm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvNormalize(object ca1, object ca2, double d1, double d2, int i, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNormalize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNormalize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNormalize", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DDILcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        int num8 = i;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNormalize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (int) num3, (double) num4, (double) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDFT(object ca1, object ca2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvDFT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvDFT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvDFT", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvDFT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvSeqSlice(object cs1, object cs2, object cms, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqSlice", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvSlice;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;I)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSeqSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSetAdd(object cs, object cse1, object cse2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetAdd", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSet;Lcom/googlecode/javacv/cpp/opencv_core$CvSetElem;Lcom/googlecode/javacv/cpp/opencv_core$CvSetElem;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cse1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cse2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSetElem\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 2404)]
    public static bool CV_IS_SET_ELEM(object ptr)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ptr, __typeref (opencv_core), "com.googlecode.javacpp.Pointer");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSetElem");
    }

    [Modifiers]
    public static object cvFindGraphEdge(object cg, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFindGraphEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFindGraphEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFindGraphEdge", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;II)Lcom/googlecode/javacv/cpp/opencv_core$CvGraphEdge;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvFindGraphEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvFindGraphEdgeByPtr(object cg, object cgv1, object cgv2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFindGraphEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFindGraphEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFindGraphEdgeByPtr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;)Lcom/googlecode/javacv/cpp/opencv_core$CvGraphEdge;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cgv2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvFindGraphEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3492)]
    public static object cvGetSetElem(object set_header, int index)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(set_header, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSet");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSetElem");
    }

    [LineNumberTable((ushort) 1871)]
    public static object cvPointFrom32f(object point)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(point, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [Modifiers]
    public static void cvEllipse(object ca, object cp, object cs1, double d1, double d2, double d3, object cs2, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvEllipse\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvEllipse\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvEllipse", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;DDDLcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        double num7 = d1;
        double num8 = d2;
        double num9 = d3;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        int num11 = i1;
        int num12 = i2;
        int num13 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, double, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvEllipse\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, (double) num6, num7, num8, (IntPtr) num9, num10, (IntPtr) num11, (IntPtr) num12, (IntPtr) num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFillPoly(object ca, object pp, int[] iarr, int i1, object cs, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFillPoly", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/PointerPointer;[IILcom/googlecode/javacv/cpp/opencv_core$CvScalar;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i1;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvFillPoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BII\u0029V)((int) num2, (int) num3, num4, (int) num5, num6, (IntPtr) num7, num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvPolyLine(object ca, object pp, int[] iarr, int i1, int i2, object cs, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPolyLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/PointerPointer;[IIILcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i1;
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num10 = i3;
        int num11 = i4;
        int num12 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvPolyLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, (int) num6, num7, (IntPtr) num8, num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3634)]
    public static void cvPolyLine(object img, object pts, int[] npts, int contours, int is_closed, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pts, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvPoint;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [Modifiers]
    public static void cvInitFont(object cf, int i1, double d1, double d2, double d3, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitFont\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BIDDDII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitFont\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BIDDDII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitFont", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFont;IDDDII)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cf);
        int num5 = i1;
        double num6 = d1;
        double num7 = d2;
        double num8 = d3;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, double, double, double, int, int)>) opencv_core.__\u003Cjniptr\u003EcvInitFont\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003BIDDDII\u0029V)((int) num2, (int) num3, (double) num4, (double) num5, num6, (int) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDrawContours(object ca, object cs1, object cs2, object cs3, int i1, int i2, int i3, object cp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvDrawContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvDrawContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvDrawContours", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;IIILcom/googlecode/javacv/cpp/opencv_core$CvPoint;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs3);
        int num8 = i1;
        int num9 = i2;
        int num10 = i3;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvDrawContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V)(num2, (int) num3, (int) num4, (int) num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3891)]
    public static int cvReadInt(object node, int default_value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      if (node == null)
        return default_value;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileNode");
    }

    [LineNumberTable((ushort) 2776)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_NODE_IS_INT(int flags)
    {
      return opencv_core.CV_NODE_TYPE(flags) == 1;
    }

    [LineNumberTable((ushort) 2777)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_NODE_IS_REAL(int flags)
    {
      return opencv_core.CV_NODE_TYPE(flags) == 2;
    }

    [LineNumberTable((ushort) 3905)]
    public static double cvReadReal(object node, double default_value)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      if (node == null)
        return default_value;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileNode");
    }

    [LineNumberTable((ushort) 2778)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_NODE_IS_STRING(int flags)
    {
      return opencv_core.CV_NODE_TYPE(flags) == 3;
    }

    [Modifiers]
    public static object cvRead(object cfs, object cfn, object cal)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRead\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRead\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRead", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;Lcom/googlecode/javacv/cpp/opencv_core$CvAttrList;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cal);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRead\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSave(string str1, object p, string str2, string str3, object cal)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSave\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSave\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSave", "(Ljava/lang/String;Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvAttrList;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cal);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSave\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvLoad(string str1, object cms, string str2, object bp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvLoad\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvLoad\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvLoad", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Ljava/lang/String;Lcom/googlecode/javacpp/BytePointer;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvLoad\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 2157)]
    public static object cvSlice(int start, int end)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSlice");
    }

    [LineNumberTable((ushort) 227)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvRNG()
    {
      return opencv_core.cvRNG(-1L);
    }

    [LineNumberTable((ushort) 239)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvRandReal(object rng)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(rng, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvRNG");
      return (double) ((long) opencv_core.cvRandInt(rng) & (long) uint.MaxValue) * (0.0 * Math.PI);
    }

    [LineNumberTable((ushort) 952)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_IMAGE(object img)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (opencv_core.CV_IS_IMAGE_HDR(img))
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      else
        return false;
    }

    [LineNumberTable((ushort) 974)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_MAKE_TYPE(int depth, int cn)
    {
      return opencv_core.CV_MAKETYPE(depth, cn);
    }

    [LineNumberTable((ushort) 976)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_8UC(int n)
    {
      return opencv_core.CV_MAKETYPE(0, n);
    }

    [LineNumberTable((ushort) 977)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_8SC(int n)
    {
      return opencv_core.CV_MAKETYPE(1, n);
    }

    [LineNumberTable((ushort) 978)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_16UC(int n)
    {
      return opencv_core.CV_MAKETYPE(0, n);
    }

    [LineNumberTable((ushort) 979)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_16SC(int n)
    {
      return opencv_core.CV_MAKETYPE(3, n);
    }

    [LineNumberTable((ushort) 980)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_32SC(int n)
    {
      return opencv_core.CV_MAKETYPE(4, n);
    }

    [LineNumberTable((ushort) 981)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_32FC(int n)
    {
      return opencv_core.CV_MAKETYPE(5, n);
    }

    [LineNumberTable((ushort) 982)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_64FC(int n)
    {
      return opencv_core.CV_MAKETYPE(6, n);
    }

    [LineNumberTable((ushort) 1033)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_CONT_MAT(int flags)
    {
      return (opencv_core.CV_IS_MAT_CONT(flags) ? 1 : 0) != 0;
    }

    public static bool CV_IS_TEMP_MAT(int flags)
    {
      return (flags & 32768) != 0;
    }

    [LineNumberTable((ushort) 1444)]
    public static bool CV_IS_MAT_HDR_Z(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 1449)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_MAT(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (opencv_core.CV_IS_MAT_HDR(mat))
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      else
        return false;
    }

    [LineNumberTable((ushort) 1452)]
    public static bool CV_IS_MASK_ARR(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 1455)]
    public static bool CV_ARE_TYPES_EQ(object mat1, object mat2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 1458)]
    public static bool CV_ARE_CNS_EQ(object mat1, object mat2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 1461)]
    public static bool CV_ARE_DEPTHS_EQ(object mat1, object mat2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 1464)]
    public static bool CV_ARE_SIZES_EQ(object mat1, object mat2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 1467)]
    public static bool CV_IS_MAT_CONST(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    public static int IPL2CV_DEPTH(int depth)
    {
      return 1125516576 >> ((depth & 240) >> 2) + ((depth & int.MinValue) == 0 ? 0 : 20) & 15;
    }

    [LineNumberTable((ushort) 1482)]
    public static object cvMat(int rows, int cols, int type, object data)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(data, __typeref (opencv_core), "com.googlecode.javacpp.Pointer");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvIplDepth(int type)
    {
      int type1 = opencv_core.CV_MAT_DEPTH(type);
      return opencv_core.CV_ELEM_SIZE1(type1) * 8 | (type1 == 1 || type1 == 3 || type1 == 4 ? int.MinValue : 0);
    }

    [LineNumberTable((ushort) 1572)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_MATND(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (opencv_core.CV_IS_MATND_HDR(mat))
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMatND");
      else
        return false;
    }

    [LineNumberTable((ushort) 1630)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SPARSE_MAT(object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      return (opencv_core.CV_IS_SPARSE_MAT_HDR(mat) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 1667)]
    public static object CV_NODE_VAL(object mat, object node)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSparseMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSparseNode");
      throw new NoClassDefFoundError("com.googlecode.javacpp.BytePointer");
    }

    [LineNumberTable((ushort) 1670)]
    public static object CV_NODE_IDX(object mat, object node)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSparseMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSparseNode");
      throw new NoClassDefFoundError("com.googlecode.javacpp.IntPointer");
    }

    [LineNumberTable((ushort) 1699)]
    public static object cvRectToROI(object rect, int coi)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(rect, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplROI");
    }

    [LineNumberTable((ushort) 1708)]
    public static object cvROIToRect(object roi)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$IplROI");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplROI");
    }

    [LineNumberTable((ushort) 1809)]
    public static object cvPoint(int x, int y)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable((ushort) 1868)]
    public static object cvPointTo32f(object point)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(point, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable((ushort) 1935)]
    public static object cvPoint3D32f(double x, double y, double z)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint3D32f");
    }

    [LineNumberTable((ushort) 1991)]
    public static object cvPoint2D64f(double x, double y)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint2D64f");
    }

    [LineNumberTable((ushort) 2052)]
    public static object cvPoint3D64f(double x, double y, double z)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint3D64f");
    }

    [LineNumberTable((ushort) 2096)]
    public static object cvSize2D32f(double width, double height)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSize2D32f");
    }

    [LineNumberTable((ushort) 2286)]
    public static bool CV_IS_STORAGE(object storage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (storage != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      else
        return false;
    }

    [LineNumberTable((ushort) 2579)]
    public static bool CV_IS_SEQ(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      if (seq != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
      else
        return false;
    }

    [LineNumberTable((ushort) 2591)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_CURVE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_SEQ_KIND(seq) == 4096;
    }

    public static bool CV_IS_SEQ_CONVEX(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return false;
    }

    [LineNumberTable((ushort) 2594)]
    public static bool CV_IS_SEQ_HOLE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    public static bool CV_IS_SEQ_SIMPLE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return true;
    }

    [LineNumberTable((ushort) 2601)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_POINT_SUBSET(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_IS_SEQ_INDEX(seq) || opencv_core.CV_SEQ_ELTYPE(seq) == 7;
    }

    [LineNumberTable((ushort) 2607)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_POLYGON(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_IS_SEQ_POLYLINE(seq) && opencv_core.CV_IS_SEQ_CLOSED(seq);
    }

    [LineNumberTable((ushort) 2613)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_CONTOUR(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_IS_SEQ_CLOSED(seq) && (opencv_core.CV_IS_SEQ_POLYLINE(seq) || opencv_core.CV_IS_SEQ_CHAIN(seq));
    }

    [LineNumberTable((ushort) 2616)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_CHAIN_CONTOUR(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_IS_SEQ_CHAIN(seq) && opencv_core.CV_IS_SEQ_CLOSED(seq);
    }

    [LineNumberTable((ushort) 2619)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SEQ_POLYGON_TREE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_SEQ_ELTYPE(seq) == 0 && opencv_core.CV_SEQ_KIND(seq) == 8192;
    }

    [LineNumberTable((ushort) 2623)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_GRAPH(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_IS_SET(seq) && opencv_core.CV_SEQ_KIND(seq) == 4096;
    }

    [LineNumberTable((ushort) 2626)]
    public static bool CV_IS_GRAPH_ORIENTED(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 2629)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_IS_SUBDIV2D(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      return opencv_core.CV_IS_SET(seq) && opencv_core.CV_SEQ_KIND(seq) == 8192;
    }

    [Modifiers]
    public static void CV_WRITE_SEQ_ELEM_VAR(object p, object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM_VAR\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM_VAR\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_WRITE_SEQ_ELEM_VAR", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM_VAR\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void CV_WRITE_SEQ_ELEM(object cp, object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_WRITE_SEQ_ELEM", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_WRITE_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void CV_PREV_SEQ_ELEM(int i, object csr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_PREV_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_PREV_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_PREV_SEQ_ELEM", "(ILcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_PREV_SEQ_ELEM\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void CV_READ_SEQ_ELEM(object cp, object csr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_READ_SEQ_ELEM", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void CV_REV_READ_SEQ_ELEM(object cp, object csr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_REV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_REV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_REV_READ_SEQ_ELEM", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_REV_READ_SEQ_ELEM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 237, (byte) 95, (byte) 20, (byte) 115, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CV_READ_EDGE(object pt1, object pt2, object reader)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(reader, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      if (!opencv_core.\u0024assertionsDisabled)
      {
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      }
      else
      {
        opencv_core.CV_PREV_POINT(reader);
        opencv_core.CV_CURRENT_POINT(reader);
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 236, (byte) 191, (byte) 3, (byte) 116})]
    public static object CV_NEXT_GRAPH_EDGE(object edge, object vertex)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(edge, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vertex, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
      if (!opencv_core.\u0024assertionsDisabled)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
    }

    [LineNumberTable((ushort) 2750)]
    public static object cvAttrList(object attr, object next)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(attr, __typeref (opencv_core), "com.googlecode.javacpp.PointerPointer");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(next, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvAttrList");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvAttrList");
    }

    [LineNumberTable((ushort) 2779)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_NODE_IS_SEQ(int flags)
    {
      return opencv_core.CV_NODE_TYPE(flags) == 5;
    }

    [LineNumberTable((ushort) 2780)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_NODE_IS_MAP(int flags)
    {
      return opencv_core.CV_NODE_TYPE(flags) == 6;
    }

    [LineNumberTable((ushort) 2781)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CV_NODE_IS_COLLECTION(int flags)
    {
      return opencv_core.CV_NODE_TYPE(flags) >= 5;
    }

    public static bool CV_NODE_IS_FLOW(int flags)
    {
      return (flags & 8) != 0;
    }

    public static bool CV_NODE_IS_EMPTY(int flags)
    {
      return (flags & 32) != 0;
    }

    public static bool CV_NODE_IS_USER(int flags)
    {
      return (flags & 16) != 0;
    }

    public static bool CV_NODE_HAS_NAME(int flags)
    {
      return (flags & 64) != 0;
    }

    [LineNumberTable((ushort) 2786)]
    public static bool CV_NODE_SEQ_IS_SIMPLE(object seq)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [Modifiers]
    public static object cvAlloc(long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAlloc\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAlloc\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAlloc", "(J)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        long num4 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, long)>) opencv_core.__\u003Cjniptr\u003EcvAlloc\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((long) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 170, (byte) 81, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvFree(object ptr)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ptr, __typeref (opencv_core), "com.googlecode.javacpp.Pointer");
      opencv_core.cvFree_(ptr);
      throw new NoClassDefFoundError("com.googlecode.javacpp.Pointer");
    }

    [Modifiers]
    public static object cvCreateImageHeader(object cs, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateImageHeader", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;II)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvInitImageHeader(object ii, object cs, int i1, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitImageHeader", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;IIII)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvInitImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, (int) num3, (int) num4, (int) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateImage(object cs, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;II)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseImageHeader(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseImageHeader", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseImageHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseImage(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseImage", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCloneImage(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCloneImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCloneImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCloneImage", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCloneImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetImageCOI(object ii, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetImageCOI", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetImageCOI(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetImageCOI", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetImageCOI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetImageROI(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetImageROI", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)Lcom/googlecode/javacv/cpp/opencv_core$CvRect;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetImageROI\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateMatHeader(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateMatHeader\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateMatHeader\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateMatHeader", "(III)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateMatHeader\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvInitMatHeader(object cm, int i1, int i2, int i3, object p, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitMatHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitMatHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitMatHeader", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;IIILcom/googlecode/javacpp/Pointer;I)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvInitMatHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, num3, (int) num4, num5, num6, (IntPtr) num7, num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateMat(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateMat\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateMat\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateMat", "(III)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateMat\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseMat(object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseMat", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCloneMat(object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCloneMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCloneMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCloneMat", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCloneMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 2988)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvGetSubArr(object arr, object submat, object rect)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(submat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(rect, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      object ca = arr;
      object obj1 = submat;
      object obj2 = rect;
      object cm = obj1;
      object cr = obj2;
      return opencv_core.cvGetSubRect(ca, cm, cr);
    }

    [LineNumberTable((ushort) 2993)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvGetRow(object arr, object submat, int row)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(submat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca = arr;
      object obj = submat;
      int num1 = row;
      int num2 = row + 1;
      int num3 = 1;
      int num4 = num2;
      int num5 = num1;
      object cm = obj;
      int i1 = num5;
      int i2 = num4;
      int i3 = num3;
      return opencv_core.cvGetRows(ca, cm, i1, i2, i3);
    }

    [LineNumberTable((ushort) 2998)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvGetCol(object arr, object submat, int col)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(submat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca = arr;
      object obj = submat;
      int num1 = col;
      int num2 = col + 1;
      int num3 = num1;
      object cm = obj;
      int i1 = num3;
      int i2 = num2;
      return opencv_core.cvGetCols(ca, cm, i1, i2);
    }

    [Modifiers]
    public static object cvGetDiag(object ca, object cm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetDiag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetDiag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetDiag", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;I)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetDiag\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvScalarToRawData(object cs, object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvScalarToRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvScalarToRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvScalarToRawData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacpp/Pointer;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvScalarToRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRawDataToScalar(object p, int i, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRawDataToScalar\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRawDataToScalar\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRawDataToScalar", "(Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRawDataToScalar\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateMatNDHeader(int i1, int[] iarr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateMatNDHeader\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateMatNDHeader\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateMatNDHeader", "(I[II)Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateMatNDHeader\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateMatND(int i1, int[] iarr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateMatND\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateMatND\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateMatND", "(I[II)Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateMatND\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvInitMatNDHeader(object cmnd, int i1, int[] iarr, int i2, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitMatNDHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BI\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitMatNDHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BI\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitMatNDHeader", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;I[IILcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cmnd);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvInitMatNDHeader\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003BI\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseMatND(object cmnd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseMatND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cmnd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCloneMatND(object cmnd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCloneMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCloneMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCloneMatND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;)Lcom/googlecode/javacv/cpp/opencv_core$CvMatND;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cmnd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCloneMatND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMatND\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateSparseMat(int i1, int[] iarr, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateSparseMat\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateSparseMat\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateSparseMat", "(I[II)Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateSparseMat\u0028I\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseSparseMat(object csm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseSparseMat", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCloneSparseMat(object csm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCloneSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCloneSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCloneSparseMat", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCloneSparseMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvInitSparseMatIterator(object csm, object csmi)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitSparseMatIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitSparseMatIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitSparseMatIterator", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMat;Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMatIterator;)Lcom/googlecode/javacv/cpp/opencv_core$CvSparseNode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csm);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csmi);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvInitSparseMatIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetNextSparseNode(object csmi)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetNextSparseNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetNextSparseNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetNextSparseNode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSparseMatIterator;)Lcom/googlecode/javacv/cpp/opencv_core$CvSparseNode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csmi);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetNextSparseNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseMatIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSparseNode\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3051)]
    public static int cvInitNArrayIterator(int count, object arrs, object mask, object stubs, object array_iterator, int flags)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arrs, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mask, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(stubs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMatND");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(array_iterator, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvNArrayIterator");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [Modifiers]
    public static int cvNextNArraySlice(object cnai)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNextNArraySlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNextNArraySlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNextNArraySlice", "(Lcom/googlecode/javacv/cpp/opencv_core$CvNArrayIterator;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cnai);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNextNArraySlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvNArrayIterator\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetElemType(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetElemType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetElemType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetElemType", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetElemType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetDims(object ca, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetDims\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetDims\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetDims", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetDims\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetDimSize(object ca, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetDimSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetDimSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetDimSize", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetDimSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvPtr1D(object ca, int i, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPtr1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPtr1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPtr1D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I[I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPtr1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvPtr2D(object ca, int i1, int i2, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPtr2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPtr2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPtr2D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II[I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPtr2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvPtr3D(object ca, int i1, int i2, int i3, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPtr3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPtr3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPtr3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;III[I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPtr3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvPtrND(object ca, int[] iarr1, int[] iarr2, int i, int[] iarr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPtrND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u005BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPtrND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u005BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPtrND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I[II[I)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPtrND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u005BII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGet1D(object ca, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGet1D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGet2D(object ca, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGet2D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGet3D(object ca, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGet3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;III)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetND(object ca, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetReal1D(object ca, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetReal1D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029D)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetReal2D(object ca, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetReal2D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029D)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetReal3D(object ca, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetReal3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;III)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029D)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetRealND(object ca, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetRealND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029D)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSet1D(object ca, int i, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSet1D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSet1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSet2D(object ca, int i1, int i2, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSet2D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSet2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSet3D(object ca, int i1, int i2, int i3, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSet3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IIILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSet3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetND(object ca, int[] iarr, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetReal1D(object ca, int i, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BID\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BID\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetReal1D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, double)>) opencv_core.__\u003Cjniptr\u003EcvSetReal1D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BID\u0029V)((double) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetReal2D(object ca, int i1, int i2, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetReal2D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        double num7 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, double)>) opencv_core.__\u003Cjniptr\u003EcvSetReal2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V)((double) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetReal3D(object ca, int i1, int i2, int i3, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIID\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIID\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetReal3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IIID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        double num8 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, int, double)>) opencv_core.__\u003Cjniptr\u003EcvSetReal3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIID\u0029V)((double) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetRealND(object ca, int[] iarr, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BID\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BID\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetRealND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[ID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvSetRealND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BID\u0029V)((double) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvClearND(object ca, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClearND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClearND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClearND", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClearND\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetMat(object ca, object cm, int[] iarr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetMat", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;[II)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetMat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetImage(object ca, object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3090)]
    public static object cvReshapeND(object arr, object header, int new_cn, int new_dims, int[] new_sizes)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(header, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("java.lang.Object");
    }

    [Modifiers]
    public static object cvReshape(object ca, object cm, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReshape\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReshape\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReshape", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;II)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvReshape\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRepeat(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRepeat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRepeat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRepeat", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRepeat\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCreateData(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCreateData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseData(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetData(object ca, object p, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/Pointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvGetRawData(object ca, object bp, int[] iarr, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetRawData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/BytePointer;[ILcom/googlecode/javacv/cpp/opencv_core$CvSize;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetSize(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetSize", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)Lcom/googlecode/javacv/cpp/opencv_core$CvSize;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 132, (byte) 145, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvZero(object arr)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      opencv_core.cvSetZero(arr);
    }

    [Modifiers]
    public static void cvSplit(object ca1, object ca2, object ca3, object ca4, object ca5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSplit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSplit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSplit", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSplit\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMerge(object ca1, object ca2, object ca3, object ca4, object ca5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMerge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMerge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMerge", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMerge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3121)]
    public static void cvMixChannels(object src, int src_count, object dst, int dst_count, int[] from_to, int pair_count)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 128, (byte) 95, (byte) 3, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvCvtScale(object src, object dst, double scale, double shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      double num1 = scale;
      double num2 = shift;
      double num3 = num1;
      object ca2 = obj;
      double d1 = num3;
      double d2 = num2;
      opencv_core.cvConvertScale(ca1, ca2, d1, d2);
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 128, (byte) 191, (byte) 3, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvScale(object src, object dst, double scale, double shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      double num1 = scale;
      double num2 = shift;
      double num3 = num1;
      object ca2 = obj;
      double d1 = num3;
      double d2 = num2;
      opencv_core.cvConvertScale(ca1, ca2, d1, d2);
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 127, (byte) 159, (byte) 3, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvConvert(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      double num1 = 1.0;
      double num2 = 0.0;
      double num3 = num1;
      object ca2 = obj;
      double d1 = num3;
      double d2 = num2;
      opencv_core.cvConvertScale(ca1, ca2, d1, d2);
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 126, (byte) 159, (byte) 3, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvCvtScaleAbs(object src, object dst, double scale, double shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      double num1 = scale;
      double num2 = shift;
      double num3 = num1;
      object ca2 = obj;
      double d1 = num3;
      double d2 = num2;
      opencv_core.cvConvertScaleAbs(ca1, ca2, d1, d2);
    }

    [Modifiers]
    public static object cvCheckTermCriteria(object ctc, double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCheckTermCriteria\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCheckTermCriteria\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCheckTermCriteria", "(Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;DI)Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        double num5 = d;
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, double, int)>) opencv_core.__\u003Cjniptr\u003EcvCheckTermCriteria\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B)((int) num2, (double) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvAdd(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAdd", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3148)]
    public static void cvSubS(object src, object value, object dst, object mask)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(value, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mask, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [Modifiers]
    public static void cvSubRS(object ca1, object cs, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSubRS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSubRS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSubRS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSubRS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 122, (byte) 191, (byte) 20, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvAXPY(object A, double real_scalar, object B, object C)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(B, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(C, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = A;
      object obj1 = opencv_core.cvRealScalar(real_scalar);
      object obj2 = B;
      object obj3 = C;
      object obj4 = obj2;
      object cs = obj1;
      object ca2 = obj4;
      object ca3 = obj3;
      opencv_core.cvScaleAdd(ca1, cs, ca2, ca3);
    }

    [Modifiers]
    public static void cvAndS(object ca1, object cs, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAndS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAndS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAndS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAndS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvOr(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvOr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvOr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvOr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvOr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvOrS(object ca1, object cs, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvOrS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvOrS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvOrS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvOrS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvXor(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvXor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvXor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvXor", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvXor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvXorS(object ca1, object cs, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvXorS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvXorS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvXorS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvXorS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInRange(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInRange", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvInRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInRangeS(object ca1, object cs1, object cs2, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInRangeS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInRangeS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInRangeS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvInRangeS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCmp(object ca1, object ca2, object ca3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCmp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCmp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCmp", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCmp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCmpS(object ca1, double d, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCmpS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCmpS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCmpS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        double num5 = d;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCmpS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, (double) num4, (IntPtr) num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMin(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMin\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMin\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMin", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMin\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMax(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMax\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMax\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMax", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMax\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMinS(object ca1, double d, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMinS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMinS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMinS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        double num5 = d;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMinS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (double) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMaxS(object ca1, double d, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMaxS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMaxS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMaxS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        double num5 = d;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMaxS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (double) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvAbsDiff(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAbsDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAbsDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAbsDiff", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAbsDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 114, (byte) 159, (byte) 3, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvAbs(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj1 = dst;
      object obj2 = opencv_core.cvScalarAll(0.0);
      object ca2 = obj1;
      object cs = obj2;
      opencv_core.cvAbsDiffS(ca1, ca2, cs);
    }

    [Modifiers]
    public static void cvCartToPolar(object ca1, object ca2, object ca3, object ca4, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCartToPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCartToPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCartToPolar", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCartToPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvPolarToCart(object ca1, object ca2, object ca3, object ca4, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPolarToCart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPolarToCart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPolarToCart", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvPolarToCart\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvPow(object ca1, object ca2, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPow\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPow\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPow", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvPow\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V)((double) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvExp(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvExp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvExp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvExp", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvExp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvLog(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvLog\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvLog\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvLog", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvLog\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static float cvFastArctan(float f1, float f2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFastArctan\u0028FF\u0029F == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFastArctan\u0028FF\u0029F = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFastArctan", "(FF)F");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        double num4 = (double) f1;
        double num5 = (double) f2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<float (IntPtr, IntPtr, float, float)>) opencv_core.__\u003Cjniptr\u003EcvFastArctan\u0028FF\u0029F)((float) num2, (float) num3, (IntPtr) num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static float cvCbrt(float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCbrt\u0028F\u0029F == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCbrt\u0028F\u0029F = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCbrt", "(F)F");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        double num4 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<float (IntPtr, IntPtr, float)>) opencv_core.__\u003Cjniptr\u003EcvCbrt\u0028F\u0029F)((float) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3205)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvCheckArray(object arr, int flags, double min_val, double max_val)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca = arr;
      int num1 = flags;
      double num2 = min_val;
      double num3 = max_val;
      double num4 = num2;
      int i = num1;
      double d1 = num4;
      double d2 = num3;
      return opencv_core.cvCheckArr(ca, i, d1, d2);
    }

    [Modifiers]
    public static void cvRandShuffle(object ca, object crng, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRandShuffle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRandShuffle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRandShuffle", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvRNG;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(crng);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvRandShuffle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BD\u0029V)((double) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSort(object ca1, object ca2, object ca3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSort", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSolveCubic(object cm1, object cm2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSolveCubic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSolveCubic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSolveCubic", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSolveCubic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSolvePoly(object cm1, object cm2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSolvePoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSolvePoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSolvePoly", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvSolvePoly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCrossProduct(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCrossProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCrossProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCrossProduct", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCrossProduct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 100, (byte) 127, (byte) 38, (byte) 127, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvMatMulAddEx(object srcA, object srcB, double alpha, object srcC, double beta, object dst, int tABC)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcA, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcB, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcC, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = srcA;
      object obj1 = srcB;
      double num1 = alpha;
      object obj2 = srcC;
      double num2 = beta;
      object obj3 = dst;
      int num3 = tABC;
      object obj4 = obj3;
      double num4 = num2;
      object obj5 = obj2;
      double num5 = num1;
      object ca2 = obj1;
      double d1 = num5;
      object ca3 = obj5;
      double d2 = num4;
      object ca4 = obj4;
      int i = num3;
      opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 99, (byte) 127, (byte) 37, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvMatMulAddS(object src, object dst, object transmat, object shiftvec)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(transmat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(shiftvec, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca1 = src;
      object obj1 = dst;
      object obj2 = transmat;
      object obj3 = shiftvec;
      object obj4 = obj2;
      object ca2 = obj1;
      object cm1 = obj4;
      object cm2 = obj3;
      opencv_core.cvTransform(ca1, ca2, cm1, cm2);
    }

    [Modifiers]
    public static void cvMulTransposed(object ca1, object ca2, int i, object ca3, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMulTransposed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMulTransposed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMulTransposed", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num8 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, double)>) opencv_core.__\u003Cjniptr\u003EcvMulTransposed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V)((double) num2, num3, (int) num4, num5, (IntPtr) num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 97, (byte) 95, (byte) 3, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvT(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      opencv_core.cvTranspose(src, dst);
    }

    [Modifiers]
    public static void cvCompleteSymm(object cm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCompleteSymm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCompleteSymm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCompleteSymm", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCompleteSymm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 96, (byte) 127, (byte) 3, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvMirror(object src, object dst, int flip_mode)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num = flip_mode;
      object ca2 = obj;
      int i = num;
      opencv_core.cvFlip(ca1, ca2, i);
    }

    [Modifiers]
    public static void cvSVBkSb(object ca1, object ca2, object ca3, object ca4, object ca5, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSVBkSb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSVBkSb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSVBkSb", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca5);
        int num9 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSVBkSb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3280)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvInv(object src, object dst, int method)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num = method;
      object ca2 = obj;
      int i = num;
      return opencv_core.cvInvert(ca1, ca2, i);
    }

    [LineNumberTable((ushort) 3283)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvInv(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num = 0;
      object ca2 = obj;
      int i = num;
      return opencv_core.cvInvert(ca1, ca2, i);
    }

    [LineNumberTable((ushort) 3287)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvSolve(object A, object B, object X)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(B, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(X, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = A;
      object obj1 = B;
      object obj2 = X;
      int num = 0;
      object obj3 = obj2;
      object ca2 = obj1;
      object ca3 = obj3;
      int i = num;
      return opencv_core.cvSolve(ca1, ca2, ca3, i);
    }

    [Modifiers]
    public static double cvDet(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvDet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvDet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvDet", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvDet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029D)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvTrace(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvTrace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvTrace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvTrace", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvTrace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEigenVV(object ca1, object ca2, object ca3, double d, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvEigenVV\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvEigenVV\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvEigenVV", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DII)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d;
        int num8 = i1;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int, int)>) opencv_core.__\u003Cjniptr\u003EcvEigenVV\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDII\u0029V)((int) num2, (int) num3, (double) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvRange(object ca, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRange", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DD)Lcom/googlecode/javacv/cpp/opencv_core$CvArr;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        double num5 = d1;
        double num6 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, double, double)>) opencv_core.__\u003Cjniptr\u003EcvRange\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B)((double) num2, (double) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3313)]
    public static void cvCalcCovarMatrix(object vects, int count, object cov_mat, object avg, int flags)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vects, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cov_mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(avg, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [Modifiers]
    public static void cvCalcPCA(object ca1, object ca2, object ca3, object ca4, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCalcPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCalcPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCalcPCA", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCalcPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvProjectPCA(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvProjectPCA", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvBackProjectPCA(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvBackProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvBackProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvBackProjectPCA", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvBackProjectPCA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3328)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvMahalonobis(object vec1, object vec2, object mat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vec1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vec2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mat, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = vec1;
      object obj1 = vec2;
      object obj2 = mat;
      object ca2 = obj1;
      object ca3 = obj2;
      return opencv_core.cvMahalanobis(ca1, ca2, ca3);
    }

    [Modifiers]
    public static object cvSum(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSum", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSum\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMinMaxLoc(object ca1, double[] darr1, double[] darr2, object cp1, object cp2, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMinMaxLoc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMinMaxLoc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMinMaxLoc", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMinMaxLoc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3358)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvNorm(object arr1, object arr2, int norm_type)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = arr1;
      object obj1 = arr2;
      int num1 = norm_type;
      object obj2 = (object) null;
      int num2 = num1;
      object ca2 = obj1;
      int i = num2;
      object ca3 = obj2;
      return opencv_core.cvNorm(ca1, ca2, i, ca3);
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 68, (byte) 159, (byte) 3, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvNormalize(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj1 = dst;
      double num1 = 1.0;
      double num2 = 0.0;
      int num3 = 4;
      object obj2 = (object) null;
      int num4 = num3;
      double num5 = num2;
      double num6 = num1;
      object ca2 = obj1;
      double d1 = num6;
      double d2 = num5;
      int i = num4;
      object ca3 = obj2;
      opencv_core.cvNormalize(ca1, ca2, d1, d2, i, ca3);
    }

    [Modifiers]
    public static void cvReduce(object ca1, object ca2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReduce\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReduce\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReduce", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvReduce\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 62, (byte) 95, (byte) 3, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvFFT(object src, object dst, int flags, int nonzero_rows)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num1 = flags;
      int num2 = nonzero_rows;
      int num3 = num1;
      object ca2 = obj;
      int i1 = num3;
      int i2 = num2;
      opencv_core.cvDFT(ca1, ca2, i1, i2);
    }

    [Modifiers]
    public static void cvMulSpectrums(object ca1, object ca2, object ca3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMulSpectrums\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMulSpectrums\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMulSpectrums", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvMulSpectrums\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetOptimalDFTSize(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetOptimalDFTSize\u0028I\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetOptimalDFTSize\u0028I\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetOptimalDFTSize", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetOptimalDFTSize\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDCT(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvDCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvDCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvDCT", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvDCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSliceLength(object cs1, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSliceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSliceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSliceLength", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSlice;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSliceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateMemStorage(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateMemStorage\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateMemStorage\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateMemStorage", "(I)Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateMemStorage\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateChildMemStorage(object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateChildMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateChildMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateChildMemStorage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCreateChildMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseMemStorage(object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseMemStorage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseMemStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSaveMemStoragePos(object cms, object cmsp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSaveMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSaveMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSaveMemStoragePos", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStoragePos;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cmsp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSaveMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRestoreMemStoragePos(object cms, object cmsp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRestoreMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRestoreMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRestoreMemStoragePos", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStoragePos;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cmsp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRestoreMemStoragePos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStoragePos\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvMemStorageAlloc(object cms, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMemStorageAlloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMemStorageAlloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMemStorageAlloc", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;J)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        long num5 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, long)>) opencv_core.__\u003Cjniptr\u003EcvMemStorageAlloc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BJ\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)((long) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvMemStorageAllocString(object cms, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMemStorageAllocString", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Ljava/lang/String;I)Lcom/googlecode/javacv/cpp/opencv_core$CvString;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvMemStorageAllocString(object cms, object bp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMemStorageAllocString", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacpp/BytePointer;I)Lcom/googlecode/javacv/cpp/opencv_core$CvString;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvMemStorageAllocString\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvString\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateSeq(int i1, int i2, int i3, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateSeq", "(IIILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCreateSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetSeqBlockSize(object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetSeqBlockSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetSeqBlockSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetSeqBlockSize", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetSeqBlockSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvSeqPush(object cs, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPush\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPush\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPush", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacpp/BytePointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqPush\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvSeqPushFront(object cs, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPushFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPushFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPushFront", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacpp/BytePointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqPushFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqPop(object cs, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPop", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqPop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqPopFront(object cs, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPopFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPopFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPopFront", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqPopFront\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqPushMulti(object cs, object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPushMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPushMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPushMulti", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvSeqPushMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqPopMulti(object cs, object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPopMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPopMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPopMulti", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvSeqPopMulti\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvSeqInsert(object cs, int i, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqInsert", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;ILcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqRemove(object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqRemove", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSeqRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvClearSeq(object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClearSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClearSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClearSeq", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClearSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSeqElemIdx(object cs, object p, object csb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqElemIdx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqElemIdx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqElemIdx", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqBlock;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(csb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqElemIdx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvStartAppendToSeq(object cs, object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStartAppendToSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStartAppendToSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStartAppendToSeq", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvStartAppendToSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvStartWriteSeq(int i1, int i2, int i3, object cms, object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStartWriteSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStartWriteSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStartWriteSeq", "(IIILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, int, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvStartWriteSeq\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvEndWriteSeq(object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvEndWriteSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvEndWriteSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvEndWriteSeq", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvEndWriteSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFlushSeqWriter(object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFlushSeqWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFlushSeqWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFlushSeqWriter", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvFlushSeqWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvStartReadSeq(object cs, object csr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStartReadSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStartReadSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStartReadSeq", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvStartReadSeq\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetSeqReaderPos(object csr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetSeqReaderPos", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetSeqReaderPos(object csr, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetSeqReaderPos", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvSetSeqReaderPos\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvMakeSeqHeaderForArray(int i1, int i2, int i3, object p, int i4, object cs, object csb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvMakeSeqHeaderForArray\u0028IIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvMakeSeqHeaderForArray\u0028IIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvMakeSeqHeaderForArray", "(IIILcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqBlock;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num8 = i4;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(csb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, IntPtr, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvMakeSeqHeaderForArray\u0028IIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4, (IntPtr) num5, num6, (int) num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3447)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvCloneSeq(object seq, object storage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(seq, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      object cs1 = seq;
      object obj1 = opencv_core.__\u003C\u003ECV_WHOLE_SEQ;
      object obj2 = storage;
      int num = 1;
      object obj3 = obj2;
      object cs2 = obj1;
      object cms = obj3;
      int i = num;
      return opencv_core.cvSeqSlice(cs1, cs2, cms, i);
    }

    [Modifiers]
    public static void cvSeqRemoveSlice(object cs1, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqRemoveSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqRemoveSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqRemoveSlice", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvSlice;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqRemoveSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqInsertSlice(object cs, int i, object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqInsertSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqInsertSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqInsertSlice", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqInsertSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqSort(object cs, object ccf, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqSort", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvCmpFunc;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ccf);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqSort\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvSeqSearch(object cs, object p1, object ccf, int i, int[] iarr, object p2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqSearch\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BI\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqSearch\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BI\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqSearch", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvCmpFunc;I[ILcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ccf);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqSearch\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BI\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, (int) num4, num5, num6, (IntPtr) num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSeqInvert(object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqInvert", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqInvert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSeqPartition(object cs1, object cms, object cs2, object ccf, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSeqPartition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSeqPartition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSeqPartition", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvCmpFunc;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ccf);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSeqPartition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvCmpFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvChangeSeqBlock(object csr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvChangeSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvChangeSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvChangeSeqBlock", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvChangeSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCreateSeqBlock(object csw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateSeqBlock", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeqWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCreateSeqBlock\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqWriter\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateSet(int i1, int i2, int i3, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateSet\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateSet\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateSet", "(IIILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvSet;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCreateSet\u0028IIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3473)]
    public virtual object cvSetNew(object set_header)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(set_header, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSet");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSet");
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 39, (byte) 95, (byte) 3, (byte) 115})]
    public virtual void cvSetRemoveByPtr(object set_header, object elem)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(set_header, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSet");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(elem, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSetElem");
      if (!opencv_core.\u0024assertionsDisabled)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSetElem");
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSet");
    }

    [Modifiers]
    public static void cvSetRemove(object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetRemove", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSet;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvClearSet(object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClearSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClearSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClearSet", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSet;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClearSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSet\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateGraph(int i1, int i2, int i3, int i4, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateGraph\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateGraph\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateGraph", "(IIIILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCreateGraph\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphAddVtx(object cg, object cgv1, object cgv2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphAddVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphAddVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphAddVtx", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cgv2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGraphAddVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphRemoveVtx(object cg, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphRemoveVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphRemoveVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphRemoveVtx", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGraphRemoveVtx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphRemoveVtxByPtr(object cg, object cgv)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphRemoveVtxByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphRemoveVtxByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphRemoveVtxByPtr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGraphRemoveVtxByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphAddEdge(object cg, int i1, int i2, object cge1, object cge2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphAddEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphAddEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphAddEdge", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;IILcom/googlecode/javacv/cpp/opencv_core$CvGraphEdge;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphEdge;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cge1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cge2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGraphAddEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I)(num2, num3, (int) num4, num5, (IntPtr) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphAddEdgeByPtr(object cg, object cgv1, object cgv2, object cge1, object cge2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphAddEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphAddEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphAddEdgeByPtr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphEdge;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphEdge;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cgv2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cge1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cge2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGraphAddEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphEdge\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvGraphRemoveEdge(object cg, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphRemoveEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphRemoveEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphRemoveEdge", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGraphRemoveEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvGraphRemoveEdgeByPtr(object cg, object cgv1, object cgv2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphRemoveEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphRemoveEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphRemoveEdgeByPtr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cgv2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGraphRemoveEdgeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3513)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvGraphFindEdge(object graph, int start_idx, int end_idx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      object cg = graph;
      int num1 = start_idx;
      int num2 = end_idx;
      int i1 = num1;
      int i2 = num2;
      return opencv_core.cvFindGraphEdge(cg, i1, i2);
    }

    [LineNumberTable((ushort) 3516)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvGraphFindEdgeByPtr(object graph, object start_vtx, object end_vtx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(start_vtx, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(end_vtx, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
      object cg = graph;
      object obj1 = start_vtx;
      object obj2 = end_vtx;
      object cgv1 = obj1;
      object cgv2 = obj2;
      return opencv_core.cvFindGraphEdgeByPtr(cg, cgv1, cgv2);
    }

    [Modifiers]
    public static void cvClearGraph(object cg)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClearGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClearGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClearGraph", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClearGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphVtxDegree(object cg, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphVtxDegree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphVtxDegree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphVtxDegree", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGraphVtxDegree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGraphVtxDegreeByPtr(object cg, object cgv)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGraphVtxDegreeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGraphVtxDegreeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGraphVtxDegreeByPtr", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGraphVtxDegreeByPtr\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3522)]
    public static object cvGetGraphVtx(object graph, int idx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
    }

    [LineNumberTable((ushort) 3523)]
    public static int cvGraphVtxIdx(object graph, object vtx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vtx, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
    }

    [LineNumberTable((ushort) 3524)]
    public static int cvGraphEdgeIdx(object graph, object edge)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(edge, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
    }

    [LineNumberTable((ushort) 3525)]
    public static int cvGraphGetVtxCount(object graph)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraph");
    }

    [LineNumberTable((ushort) 3526)]
    public static int cvGraphGetEdgeCount(object graph)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(graph, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraph");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraph");
    }

    [LineNumberTable((ushort) 3546)]
    public static bool CV_IS_GRAPH_EDGE_VISITED(object vtx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vtx, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphVtx");
    }

    [LineNumberTable((ushort) 3549)]
    public static bool CV_IS_GRAPH_VERTEX_VISITED(object edge)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(edge, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvGraphEdge");
    }

    [Modifiers]
    public static object cvCreateGraphScanner(object cg, object cgv, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCreateGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCreateGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCreateGraphScanner", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvGraphVtx;I)Lcom/googlecode/javacv/cpp/opencv_core$CvGraphScanner;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgv);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCreateGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphVtx\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseGraphScanner(object cgs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseGraphScanner", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraphScanner;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cgs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseGraphScanner\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvNextGraphItem(object cgs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNextGraphItem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNextGraphItem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNextGraphItem", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraphScanner;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cgs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNextGraphItem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraphScanner\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCloneGraph(object cg, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCloneGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCloneGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCloneGraph", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvCloneGraph\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRectangleR(object ca, object cr, object cs, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRectangleR\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRectangleR\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRectangleR", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num7 = i1;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_core.__\u003Cjniptr\u003EcvRectangleR\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3616)]
    public static void cvEllipseBox(object img, object box, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(box, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvBox2D");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvBox2D");
    }

    [LineNumberTable((ushort) 3625)]
    public static void cvFillPoly(object img, object pts, int[] npts, int contours, object color, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pts, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvPoint;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 255, (byte) 127, (byte) 37, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawRect(object img, object pt1, object pt2, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca = img;
      object obj1 = pt1;
      object obj2 = pt2;
      object obj3 = color;
      int num1 = thickness;
      int num2 = line_type;
      int num3 = shift;
      int num4 = num2;
      int num5 = num1;
      object obj4 = obj3;
      object obj5 = obj2;
      object cp1 = obj1;
      object cp2 = obj5;
      object cs = obj4;
      int i1 = num5;
      int i2 = num4;
      int i3 = num3;
      opencv_core.cvRectangle(ca, cp1, cp2, cs, i1, i2, i3);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 254, (byte) 127, (byte) 37, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawLine(object img, object pt1, object pt2, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt1, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt2, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca = img;
      object obj1 = pt1;
      object obj2 = pt2;
      object obj3 = color;
      int num1 = thickness;
      int num2 = line_type;
      int num3 = shift;
      int num4 = num2;
      int num5 = num1;
      object obj4 = obj3;
      object obj5 = obj2;
      object cp1 = obj1;
      object cp2 = obj5;
      object cs = obj4;
      int i1 = num5;
      int i2 = num4;
      int i3 = num3;
      opencv_core.cvLine(ca, cp1, cp2, cs, i1, i2, i3);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 253, (byte) 127, (byte) 20, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawCircle(object img, object center, int radius, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(center, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca = img;
      object obj1 = center;
      int num1 = radius;
      object obj2 = color;
      int num2 = thickness;
      int num3 = line_type;
      int num4 = shift;
      int num5 = num3;
      int num6 = num2;
      object obj3 = obj2;
      int num7 = num1;
      object cp = obj1;
      int i1 = num7;
      object cs = obj3;
      int i2 = num6;
      int i3 = num5;
      int i4 = num4;
      opencv_core.cvCircle(ca, cp, i1, cs, i2, i3, i4);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 252, (byte) 159, (byte) 38, (byte) 159, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawEllipse(object img, object center, object axes, double angle, double start_angle, double end_angle, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(center, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(axes, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca = img;
      object obj1 = center;
      object obj2 = axes;
      double num1 = angle;
      double num2 = start_angle;
      double num3 = end_angle;
      object obj3 = color;
      int num4 = thickness;
      int num5 = line_type;
      int num6 = shift;
      int num7 = num5;
      int num8 = num4;
      object obj4 = obj3;
      double num9 = num3;
      double num10 = num2;
      double num11 = num1;
      object obj5 = obj2;
      object cp = obj1;
      object cs1 = obj5;
      double d1 = num11;
      double d2 = num10;
      double d3 = num9;
      object cs2 = obj4;
      int i1 = num8;
      int i2 = num7;
      int i3 = num6;
      opencv_core.cvEllipse(ca, cp, cs1, d1, d2, d3, cs2, i1, i2, i3);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 250, (byte) 95, (byte) 21, (byte) 127, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawPolyLine(object img, object pts, int[] npts, int contours, int is_closed, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pts, __typeref (opencv_core), "[Lcom.googlecode.javacv.cpp.opencv_core$CvPoint;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object img1 = img;
      object obj1 = pts;
      int[] numArray1 = npts;
      int num1 = contours;
      int num2 = is_closed;
      object obj2 = color;
      int num3 = thickness;
      int num4 = line_type;
      int num5 = shift;
      int num6 = num4;
      int num7 = num3;
      object obj3 = obj2;
      int num8 = num2;
      int num9 = num1;
      int[] numArray2 = numArray1;
      object pts1 = obj1;
      int[] npts1 = numArray2;
      int contours1 = num9;
      int is_closed1 = num8;
      object color1 = obj3;
      int thickness1 = num7;
      int line_type1 = num6;
      int shift1 = num5;
      opencv_core.cvPolyLine(img1, pts1, npts1, contours1, is_closed1, color1, thickness1, line_type1, shift1);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 249, (byte) 127, (byte) 21, (byte) 127, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawPolyLine(object img, object pts, int[] npts, int contours, int is_closed, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pts, __typeref (opencv_core), "com.googlecode.javacpp.PointerPointer");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca = img;
      object obj1 = pts;
      int[] numArray1 = npts;
      int num1 = contours;
      int num2 = is_closed;
      object obj2 = color;
      int num3 = thickness;
      int num4 = line_type;
      int num5 = shift;
      int num6 = num4;
      int num7 = num3;
      object obj3 = obj2;
      int num8 = num2;
      int num9 = num1;
      int[] numArray2 = numArray1;
      object pp = obj1;
      int[] iarr = numArray2;
      int i1 = num9;
      int i2 = num8;
      object cs = obj3;
      int i3 = num7;
      int i4 = num6;
      int i5 = num5;
      opencv_core.cvPolyLine(ca, pp, iarr, i1, i2, cs, i3, i4, i5);
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 248, (byte) 159, (byte) 21, (byte) 127, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvDrawPolyLine(object img, object pts, int[] npts, int contours, int is_closed, object color, int thickness, int line_type, int shift)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pts, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      object ca = img;
      object obj1 = pts;
      int[] numArray1 = npts;
      int num1 = contours;
      int num2 = is_closed;
      object obj2 = color;
      int num3 = thickness;
      int num4 = line_type;
      int num5 = shift;
      int num6 = num4;
      int num7 = num3;
      object obj3 = obj2;
      int num8 = num2;
      int num9 = num1;
      int[] numArray2 = numArray1;
      object cp = obj1;
      int[] iarr = numArray2;
      int i1 = num9;
      int i2 = num8;
      object cs = obj3;
      int i3 = num7;
      int i4 = num6;
      int i5 = num5;
      opencv_core.cvPolyLine(ca, cp, iarr, i1, i2, cs, i3, i4, i5);
    }

    [Modifiers]
    public static int cvClipLine(object cs, object cp1, object cp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClipLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClipLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClipLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClipLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvInitLineIterator(object ca, object cp1, object cp2, object cli, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitLineIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003BII\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitLineIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003BII\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitLineIterator", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvLineIterator;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cli);
        int num8 = i1;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvInitLineIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003BII\u0029I)((int) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void CV_NEXT_LINE_POINT(object cli)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003ECV_NEXT_LINE_POINT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003ECV_NEXT_LINE_POINT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "CV_NEXT_LINE_POINT", "(Lcom/googlecode/javacv/cpp/opencv_core$CvLineIterator;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cli);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003ECV_NEXT_LINE_POINT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvLineIterator\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3739)]
    public static object cvFont(double scale, int thickness)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFont");
    }

    [Modifiers]
    public static object cvColorToScalar(double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvColorToScalar\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvColorToScalar\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvColorToScalar", "(DI)Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        double num4 = d;
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double, int)>) opencv_core.__\u003Cjniptr\u003EcvColorToScalar\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B)((int) num2, (double) num3, (IntPtr) num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvEllipse2Poly(object cp1, object cs, int i1, int i2, int i3, object cp2, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvEllipse2Poly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvEllipse2Poly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvEllipse2Poly", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;IIILcom/googlecode/javacv/cpp/opencv_core$CvPoint;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        int num10 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvEllipse2Poly\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I)((int) num2, num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3758)]
    public static void cvDrawContours(object img, object contour, object external_color, object hole_color, int max_level, int thickness, int line_type)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(contour, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(external_color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hole_color, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [Modifiers]
    public static void cvLUT(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvLUT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvLUT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvLUT", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvLUT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInitTreeNodeIterator(object ctni, object p, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInitTreeNodeIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInitTreeNodeIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInitTreeNodeIterator", "(Lcom/googlecode/javacv/cpp/opencv_core$CvTreeNodeIterator;Lcom/googlecode/javacpp/Pointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ctni);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvInitTreeNodeIterator\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvNextTreeNode(object ctni)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNextTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNextTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNextTreeNode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvTreeNodeIterator;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ctni);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNextTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvPrevTreeNode(object ctni)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvPrevTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvPrevTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvPrevTreeNode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvTreeNodeIterator;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ctni);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvPrevTreeNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTreeNodeIterator\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInsertNodeIntoTree(object p1, object p2, object p3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvInsertNodeIntoTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvInsertNodeIntoTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvInsertNodeIntoTree", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvInsertNodeIntoTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRemoveNodeFromTree(object p1, object p2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRemoveNodeFromTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRemoveNodeFromTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRemoveNodeFromTree", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRemoveNodeFromTree\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvTreeToNodeSeq(object p, int i, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvTreeToNodeSeq\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvTreeToNodeSeq\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvTreeToNodeSeq", "(Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvTreeToNodeSeq\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvKMeans2(object ca1, int i1, object ca2, object ctc, int i2, object crng, int i3, object ca3, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvKMeans2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvKMeans2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvKMeans2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;ILcom/googlecode/javacv/cpp/opencv_core$CvRNG;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;[D)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(crng);
        int num10 = i3;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvKMeans2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRNG\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BD\u0029I)(num2, num3, (int) num4, (IntPtr) num5, (int) num6, num7, (IntPtr) num8, (int) num9, (IntPtr) num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvRegisterModule(object cmi)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRegisterModule\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvModuleInfo\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRegisterModule\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvModuleInfo\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRegisterModule", "(Lcom/googlecode/javacv/cpp/opencv_core$CvModuleInfo;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cmi);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRegisterModule\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvModuleInfo\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvUseOptimized(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvUseOptimized\u0028I\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvUseOptimized\u0028I\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvUseOptimized", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvUseOptimized\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvGetModuleInfo(string str, object bp1, object bp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetModuleInfo\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetModuleInfo\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetModuleInfo", "(Ljava/lang/String;Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetModuleInfo\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetMemoryManager(object caf, object cff, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetMemoryManager\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAllocFunc\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFreeFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetMemoryManager\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAllocFunc\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFreeFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetMemoryManager", "(Lcom/googlecode/javacv/cpp/opencv_core$CvAllocFunc;Lcom/googlecode/javacv/cpp/opencv_core$CvFreeFunc;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(caf);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cff);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetMemoryManager\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAllocFunc\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFreeFunc\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetIPLAllocators(object ccih, object caid, object cd, object ccroi, object cci)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetIPLAllocators\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateImageHeader\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplAllocateImageData\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplDeallocate\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateROI\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCloneImage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetIPLAllocators\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateImageHeader\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplAllocateImageData\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplDeallocate\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateROI\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCloneImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetIPLAllocators", "(Lcom/googlecode/javacv/cpp/opencv_core$Cv_iplCreateImageHeader;Lcom/googlecode/javacv/cpp/opencv_core$Cv_iplAllocateImageData;Lcom/googlecode/javacv/cpp/opencv_core$Cv_iplDeallocate;Lcom/googlecode/javacv/cpp/opencv_core$Cv_iplCreateROI;Lcom/googlecode/javacv/cpp/opencv_core$Cv_iplCloneImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccih);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(caid);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cd);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ccroi);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cci);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvSetIPLAllocators\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateImageHeader\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplAllocateImageData\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplDeallocate\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCreateROI\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024Cv_iplCloneImage\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvOpenFileStorage(string str, object cms, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvOpenFileStorage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvOpenFileStorage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvOpenFileStorage", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;I)Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvOpenFileStorage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseFileStorage(object cfs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReleaseFileStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReleaseFileStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReleaseFileStorage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReleaseFileStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string cvAttrValue(object cal, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvAttrValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvAttrValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvAttrValue", "(Lcom/googlecode/javacv/cpp/opencv_core$CvAttrList;Ljava/lang/String;)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cal);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num6 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvAttrValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvAttrList\u003BLjava\u002Flang\u002FString\u003B\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3, num4, num5);
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
    public static void cvWriteComment(object cfs, string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWriteComment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWriteComment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWriteComment", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvWriteComment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvStartNextStream(object cfs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStartNextStream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStartNextStream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStartNextStream", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvStartNextStream\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvWriteRawData(object cfs, object p, int i, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWriteRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWriteRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWriteRawData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacpp/Pointer;ILjava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvWriteRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILjava\u002Flang\u002FString\u003B\u0029V)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetHashedKey(object cfs, string str, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetHashedKey\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetHashedKey\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetHashedKey", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;II)Lcom/googlecode/javacv/cpp/opencv_core$CvStringHashNode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_core.__\u003Cjniptr\u003EcvGetHashedKey\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003B)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetRootFileNode(object cfs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetRootFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetRootFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetRootFileNode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;I)Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetRootFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetFileNode(object cfs, object cfn, object cshn, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetFileNode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;Lcom/googlecode/javacv/cpp/opencv_core$CvStringHashNode;I)Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cshn);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvGetFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvStringHashNode\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 3888)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvReadInt(object node)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      return opencv_core.cvReadInt(node, 0);
    }

    [LineNumberTable((ushort) 3896)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvReadIntByName(object fs, object map, string name)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      object fs1 = fs;
      object obj = map;
      string str1 = name;
      int num = 0;
      string str2 = str1;
      object map1 = obj;
      string name1 = str2;
      int default_value = num;
      return opencv_core.cvReadIntByName(fs1, map1, name1, default_value);
    }

    [LineNumberTable((ushort) 3902)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvReadReal(object node)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      return opencv_core.cvReadReal(node, 0.0);
    }

    [LineNumberTable((ushort) 3910)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvReadRealByName(object fs, object map, string name)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      object fs1 = fs;
      object obj = map;
      string str1 = name;
      double num = 0.0;
      string str2 = str1;
      object map1 = obj;
      string name1 = str2;
      double default_value = num;
      return opencv_core.cvReadRealByName(fs1, map1, name1, default_value);
    }

    [LineNumberTable((ushort) 3916)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string cvReadString(object node)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(node, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      return opencv_core.cvReadString(node, (string) null);
    }

    [LineNumberTable((ushort) 3933)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string cvReadStringByName(object fs, object map, string name)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map, __typeref (opencv_core), "com.googlecode.javacv.cpp.opencv_core$CvFileNode");
      object fs1 = fs;
      object obj = map;
      string str1 = name;
      string str2 = (string) null;
      string str3 = str1;
      object map1 = obj;
      string name1 = str3;
      string default_value = str2;
      return opencv_core.cvReadStringByName(fs1, map1, name1, default_value);
    }

    [Modifiers]
    public static void cvStartReadRawData(object cfs, object cfn, object csr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStartReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStartReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStartReadRawData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvStartReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReadRawDataSlice(object cfs, object csr, int i, object p, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReadRawDataSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReadRawDataSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReadRawDataSlice", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqReader;ILcom/googlecode/javacpp/Pointer;Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(csr);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReadRawDataSlice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqReader\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V)(num2, num3, (int) num4, num5, (IntPtr) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReadRawData(object cfs, object cfn, object p, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvReadRawData", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;Lcom/googlecode/javacpp/Pointer;Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvReadRawData\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvWriteFileNode(object cfs, string str, object cfn, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvWriteFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvWriteFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvWriteFileNode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileStorage;Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvWriteFileNode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileStorage\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string cvGetFileNodeName(object cfn)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetFileNodeName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetFileNodeName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetFileNodeName", "(Lcom/googlecode/javacv/cpp/opencv_core$CvFileNode;)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cfn);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetFileNodeName\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFileNode\u003B\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3, num4);
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
    public static void cvRegisterType(object cti)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRegisterType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRegisterType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRegisterType", "(Lcom/googlecode/javacv/cpp/opencv_core$CvTypeInfo;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cti);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRegisterType\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvUnregisterType(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvUnregisterType\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvUnregisterType\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvUnregisterType", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvUnregisterType\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvFirstType()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFirstType\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFirstType\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFirstType", "()Lcom/googlecode/javacv/cpp/opencv_core$CvTypeInfo;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvFirstType\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvFindType(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvFindType\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvFindType\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvFindType", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/opencv_core$CvTypeInfo;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvFindType\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvTypeOf(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvTypeOf\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvTypeOf\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvTypeOf", "(Lcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacv/cpp/opencv_core$CvTypeInfo;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvTypeOf\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTypeInfo\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRelease(object pp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRelease\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRelease\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRelease", "(Lcom/googlecode/javacpp/PointerPointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRelease\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvClone(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvClone\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvClone\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvClone", "(Lcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvClone\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 175, (byte) 81, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvSave(string filename, object struct_ptr)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(struct_ptr, __typeref (opencv_core), "com.googlecode.javacpp.Pointer");
      string str1 = filename;
      object p = struct_ptr;
      // ISSUE: variable of the null type
      __Null local1 = null;
      // ISSUE: variable of the null type
      __Null local2 = null;
      object obj = opencv_core.cvAttrList();
      string str = (string) local2;
      string str2 = (string) local1;
      string str3 = str;
      object cal = obj;
      opencv_core.cvSave(str1, p, str2, str3, cal);
    }

    [LineNumberTable((ushort) 3969)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvLoad(string filename)
    {
      return opencv_core.cvLoad(filename, (object) null, (string) null, (object) null);
    }

    [Modifiers]
    public static long cvGetTickCount()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetTickCount\u0028\u0029J == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetTickCount\u0028\u0029J = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetTickCount", "()J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetTickCount\u0028\u0029J)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetTickFrequency()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetTickFrequency\u0028\u0029D == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetTickFrequency\u0028\u0029D = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetTickFrequency", "()D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetTickFrequency\u0028\u0029D)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvCheckHardwareSupport(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvCheckHardwareSupport\u0028I\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvCheckHardwareSupport\u0028I\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvCheckHardwareSupport", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvCheckHardwareSupport\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetNumThreads()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetNumThreads\u0028\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetNumThreads\u0028\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetNumThreads", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetNumThreads\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetNumThreads(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetNumThreads\u0028I\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetNumThreads\u0028I\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetNumThreads", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetNumThreads\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetThreadNum()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetThreadNum\u0028\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetThreadNum\u0028\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetThreadNum", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetThreadNum\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetErrStatus()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetErrStatus\u0028\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetErrStatus\u0028\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetErrStatus", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetErrStatus\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetErrStatus(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetErrStatus\u0028I\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetErrStatus\u0028I\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetErrStatus", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetErrStatus\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetErrMode()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetErrMode\u0028\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetErrMode\u0028\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetErrMode", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetErrMode\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSetErrMode(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvSetErrMode\u0028I\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvSetErrMode\u0028I\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvSetErrMode", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvSetErrMode\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvError(int i1, string str1, string str2, string str3, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvError\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvError\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvError", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvError\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, (IntPtr) num4, num5, (int) num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string cvErrorStr(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvErrorStr\u0028I\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvErrorStr\u0028I\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvErrorStr", "(I)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvErrorStr\u0028I\u0029Ljava\u002Flang\u002FString\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static int cvGetErrInfo(object bp1, object bp2, object bp3, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGetErrInfo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGetErrInfo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGetErrInfo", "(Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGetErrInfo\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvErrorFromIppStatus(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvErrorFromIppStatus\u0028I\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvErrorFromIppStatus\u0028I\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvErrorFromIppStatus", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) opencv_core.__\u003Cjniptr\u003EcvErrorFromIppStatus\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvRedirectError(object cec, object p1, object p2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvRedirectError\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003B == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvRedirectError\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003B = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvRedirectError", "(Lcom/googlecode/javacv/cpp/opencv_core$CvErrorCallback;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacv/cpp/opencv_core$CvErrorCallback;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cec);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvRedirectError\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvErrorCallback\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvNulDevReport(int i1, string str1, string str2, string str3, int i2, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvNulDevReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvNulDevReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvNulDevReport", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvNulDevReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, (int) num3, (IntPtr) num4, num5, num6, (int) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvStdErrReport(int i1, string str1, string str2, string str3, int i2, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvStdErrReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvStdErrReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvStdErrReport", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvStdErrReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, (int) num3, (IntPtr) num4, num5, num6, (int) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGuiBoxReport(int i1, string str1, string str2, string str3, int i2, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_core.__\u003Cjniptr\u003EcvGuiBoxReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        opencv_core.__\u003Cjniptr\u003EcvGuiBoxReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_core.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_core", "cvGuiBoxReport", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_core.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_core>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) str3);
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_core.__\u003Cjniptr\u003EcvGuiBoxReport\u0028ILjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, (int) num3, (IntPtr) num4, num5, num6, (int) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (opencv_core.__\u003CcallerID\u003E == null)
        opencv_core.__\u003CcallerID\u003E = (CallerID) new opencv_core.__\u003CCallerID\u003E();
      return opencv_core.__\u003CcallerID\u003E;
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
