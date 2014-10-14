// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.Marker
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [Implements(new string[] {"java.lang.Cloneable"})]
  public class Marker : Object, Cloneable.__Interface
  {
    public int id;
    public double[] corners;
    public double confidence;
    private static object imageCache;
    [Modifiers]
    private static double[] src;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal srcPts4x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal dstPts4x1;

    [LineNumberTable((ushort) 94)]
    static Marker()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 104, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Marker(int id, double[] corners, double confidence)
    {
      base.\u002Ector();
      Marker marker = this;
      this.id = id;
      this.corners = corners;
      this.confidence = confidence;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Marker(int id, params double[] corners)
      : this(id, corners, 1.0)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Marker obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 236, (byte) 70, (byte) 102, (byte) 110, (byte) 16, (byte) 198, (byte) 109, (byte) 237, (byte) 76})]
    public virtual double[] getCenter()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index = 0; index < 4; ++index)
      {
        num1 += this.corners[2 * index];
        num2 += this.corners[2 * index + 1];
      }
      double num3 = num1 / 4.0;
      double num4 = num2 / 4.0;
      double[] numArray = new double[2];
      int index1 = 0;
      double num5 = num3;
      numArray[index1] = num5;
      int index2 = 1;
      double num6 = num4;
      numArray[index2] = num6;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 95, (byte) 21, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(object image, object color, double scale, object prewarp)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(prewarp, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object image1 = image;
      object obj1 = color;
      double num1 = scale;
      double num2 = scale;
      object obj2 = prewarp;
      double num3 = num2;
      double num4 = num1;
      object color1 = obj1;
      double scaleX = num4;
      double scaleY = num3;
      object prewarp1 = obj2;
      this.draw(image1, color1, scaleX, scaleY, prewarp1);
    }

    [LineNumberTable((ushort) 96)]
    public static object getImage(int id)
    {
      object obj = Marker.imageCache;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 114, (byte) 191, (byte) 21, (byte) 122, (byte) 114, (byte) 100, (byte) 159, (byte) 8, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(object image, object color, double scaleX, double scaleY, object prewarp)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(prewarp, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object map_matrix = ByteCodeHelper.DynamicCast(Marker.H3x3.get(), __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      JavaCV.getPerspectiveTransform(Marker.src, this.corners, map_matrix);
      if (prewarp != null)
      {
        object ca1 = prewarp;
        object obj1 = map_matrix;
        double num1 = 1.0;
        // ISSUE: variable of the null type
        __Null local = null;
        double num2 = 0.0;
        object obj2 = map_matrix;
        int num3 = 0;
        object obj3 = obj2;
        double num4 = num2;
        object obj4 = (object) local;
        double num5 = num1;
        object ca2 = obj1;
        double d1 = num5;
        object ca3 = obj4;
        double d2 = num4;
        object ca4 = obj3;
        int i = num3;
        opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
      }
      this.getImage();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 91)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getImage()
    {
      return Marker.getImage(this.id);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 115, (byte) 98, (byte) 110, (byte) 110, (byte) 115, (byte) 115, (byte) 114, (byte) 114, (byte) 159, (byte) 61, (byte) 228, (byte) 57, (byte) 41, (byte) 233, (byte) 75, (byte) 104, (byte) 139, (byte) 107, (byte) 107, (byte) 108, (byte) 116, (byte) 115, (byte) 127, (byte) 10, (byte) 141, (byte) 235, (byte) 58, (byte) 235, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Marker[][] createArray(Marker.ArraySettings settings, double marginx, double marginy)
    {
      Marker[] markerArray1 = new Marker[settings.rows * settings.columns];
      int num1 = 0;
      for (int index1 = 0; index1 < settings.rows; ++index1)
      {
        for (int index2 = 0; index2 < settings.columns; ++index2)
        {
          double num2 = settings.sizeX / 2.0;
          double num3 = settings.sizeY / 2.0;
          double num4 = (double) index2 * settings.spacingX + num2 + marginx;
          double num5 = (double) index1 * settings.spacingY + num3 + marginy;
          Marker[] markerArray2 = markerArray1;
          int index3 = num1;
          int id = num1;
          double[] corners = new double[8];
          int index4 = 0;
          double num6 = num4 - num2;
          corners[index4] = num6;
          int index5 = 1;
          double num7 = num5 - num3;
          corners[index5] = num7;
          int index6 = 2;
          double num8 = num4 + num2;
          corners[index6] = num8;
          int index7 = 3;
          double num9 = num5 - num3;
          corners[index7] = num9;
          int index8 = 4;
          double num10 = num4 + num2;
          corners[index8] = num10;
          int index9 = 5;
          double num11 = num5 + num3;
          corners[index9] = num11;
          int index10 = 6;
          double num12 = num4 - num2;
          corners[index10] = num12;
          int index11 = 7;
          double num13 = num5 + num3;
          corners[index11] = num13;
          double confidence = 1.0;
          Marker marker = new Marker(id, corners, confidence);
          markerArray2[index3] = marker;
          ++num1;
        }
      }
      if (!settings.checkered)
      {
        Marker[][] markerArray2 = new Marker[1][];
        int index = 0;
        Marker[] markerArray3 = markerArray1;
        markerArray2[index] = markerArray3;
        return markerArray2;
      }
      else
      {
        Marker[] markerArray2 = new Marker[markerArray1.Length / 2];
        Marker[] markerArray3 = new Marker[markerArray1.Length / 2];
        for (int index = 0; index < markerArray1.Length; ++index)
        {
          int num2 = index;
          int num3 = settings.columns;
          int num4 = -1;
          int num5 = num3 != num4 ? num2 % num3 : 0;
          int num6 = index;
          int num7 = settings.columns;
          int num8 = -1;
          int num9 = num7 != num8 ? num6 / num7 : -num6;
          int num10 = num5;
          int num11 = 2;
          int num12 = -1;
          int num13 = (num11 != num12 ? num10 % num11 : 0) != 0 ? 0 : 1;
          int num14 = num9;
          int num15 = 2;
          int num16 = -1;
          int num17 = (num15 != num16 ? num14 % num15 : 0) != 0 ? 0 : 1;
          if ((num13 ^ num17) != 0)
            markerArray3[index / 2] = markerArray1[index];
          else
            markerArray2[index / 2] = markerArray1[index];
        }
        Marker[][] markerArray4 = new Marker[2][];
        int index1 = 0;
        Marker[] markerArray5 = markerArray3;
        markerArray4[index1] = markerArray5;
        int index2 = 1;
        Marker[] markerArray6 = markerArray2;
        markerArray4[index2] = markerArray6;
        return markerArray4;
      }
    }

    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Marker clone()
    {
      return new Marker(this.id, (double[]) this.corners.Clone(), this.confidence);
    }

    [LineNumberTable(new byte[] {(byte) 0, (byte) 98, (byte) 108, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * 7 + this.id) + (this.corners == null ? 0 : Object.instancehelper_hashCode((object) this.corners));
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 104, (byte) 103, (byte) 159, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (!(o is Marker))
        return false;
      Marker marker = (Marker) o;
      return marker.id == this.id && Arrays.equals(marker.corners, this.corners);
    }

    [LineNumberTable((ushort) 105)]
    public virtual void draw(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      Marker marker = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [LineNumberTable((ushort) 215)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Marker[][] createArray(Marker.ArraySettings settings)
    {
      return Marker.createArray(settings, 0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 80, (byte) 131, (byte) 102, (byte) 110, (byte) 114, (byte) 116, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Marker[][] createArray(int rows, int columns, double sizeX, double sizeY, double spacingX, double spacingY, bool checkered, double marginx, double marginy)
    {
      int num = checkered ? 1 : 0;
      return Marker.createArray(new Marker.ArraySettings()
      {
        rows = rows,
        columns = columns,
        sizeX = sizeX,
        sizeY = sizeY,
        spacingX = spacingX,
        spacingY = spacingY,
        checkered = num != 0
      }, marginx, marginy);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 78, (byte) 177, (byte) 154, (byte) 112, (byte) 211})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void applyWarp(Marker[] markers, object warp)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(warp, __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(Marker.srcPts4x1.get(), __typeref (Marker), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      Marker[] markerArray = markers;
      int length = markerArray.Length;
      int index = 0;
      if (index >= length)
        return;
      double[] numArray = markerArray[index].corners;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 255, (byte) 160, (byte) 171, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append("[").append(this.id).append(": ").append("(").append(this.corners[0]).append(", ").append(this.corners[1]).append(") ").append("(").append(this.corners[2]).append(", ").append(this.corners[3]).append(") ").append("(").append(this.corners[4]).append(", ").append(this.corners[5]).append(") ").append("(").append(this.corners[6]).append(", ").append(this.corners[7]).append(")]").toString();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 33)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object \u003Cbridge\u003Eclone()
    {
      return (object) this.clone();
    }

    [InnerClass]
    [SourceFile("Marker.java")]
    [Serializable]
    public class ArraySettings : BaseChildSettings
    {
      internal int rows;
      internal int columns;
      internal double sizeX;
      internal double sizeY;
      internal double spacingX;
      internal double spacingY;
      internal bool checkered;

      [LineNumberTable(new byte[] {(byte) 112, (byte) 104, (byte) 111, (byte) 127, (byte) 33})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ArraySettings()
      {
        Marker.ArraySettings arraySettings = this;
        this.rows = 8;
        this.columns = 12;
        this.sizeX = 200.0;
        this.sizeY = 200.0;
        this.spacingX = 300.0;
        this.spacingY = 300.0;
        this.checkered = true;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ArraySettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual int getRows()
      {
        return this.rows;
      }

      [LineNumberTable(new byte[] {(byte) 121, (byte) 127, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setRows(int rows)
      {
        string str = "rows";
        Integer integer1 = Integer.valueOf(this.rows);
        Marker.ArraySettings arraySettings = this;
        int num1 = rows;
        int num2 = num1;
        this.rows = num1;
        Integer integer2 = Integer.valueOf(num2);
        this.firePropertyChange(str, (object) integer1, (object) integer2);
      }

      public virtual int getColumns()
      {
        return this.columns;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 127, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setColumns(int columns)
      {
        string str = "columns";
        Integer integer1 = Integer.valueOf(this.columns);
        Marker.ArraySettings arraySettings = this;
        int num1 = columns;
        int num2 = num1;
        this.columns = num1;
        Integer integer2 = Integer.valueOf(num2);
        this.firePropertyChange(str, (object) integer1, (object) integer2);
      }

      public virtual double getSizeX()
      {
        return this.sizeX;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 127, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setSizeX(double sizeX)
      {
        string str = "sizeX";
        Double double1 = Double.valueOf(this.sizeX);
        Marker.ArraySettings arraySettings = this;
        double num1 = sizeX;
        double num2 = num1;
        this.sizeX = num1;
        Double double2 = Double.valueOf(num2);
        this.firePropertyChange(str, (object) double1, (object) double2);
      }

      public virtual double getSizeY()
      {
        return this.sizeY;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 127, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setSizeY(double sizeY)
      {
        string str = "sizeY";
        Double double1 = Double.valueOf(this.sizeY);
        Marker.ArraySettings arraySettings = this;
        double num1 = sizeY;
        double num2 = num1;
        this.sizeY = num1;
        Double double2 = Double.valueOf(num2);
        this.firePropertyChange(str, (object) double1, (object) double2);
      }

      public virtual double getSpacingX()
      {
        return this.spacingX;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 127, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setSpacingX(double spacingX)
      {
        string str = "spacingX";
        Double double1 = Double.valueOf(this.spacingX);
        Marker.ArraySettings arraySettings = this;
        double num1 = spacingX;
        double num2 = num1;
        this.spacingX = num1;
        Double double2 = Double.valueOf(num2);
        this.firePropertyChange(str, (object) double1, (object) double2);
      }

      public virtual double getSpacingY()
      {
        return this.spacingY;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 127, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setSpacingY(double spacingY)
      {
        string str = "spacingY";
        Double double1 = Double.valueOf(this.spacingY);
        Marker.ArraySettings arraySettings = this;
        double num1 = spacingY;
        double num2 = num1;
        this.spacingY = num1;
        Double double2 = Double.valueOf(num2);
        this.firePropertyChange(str, (object) double1, (object) double2);
      }

      public virtual bool isCheckered()
      {
        return this.checkered;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 90, (byte) 162, (byte) 127, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setCheckered(bool checkered)
      {
        int num1 = checkered ? 1 : 0;
        string str = "checkered";
        Boolean boolean1 = Boolean.valueOf(this.checkered);
        Marker.ArraySettings arraySettings = this;
        int num2 = num1;
        int num3 = num2;
        this.checkered = num2 != 0;
        Boolean boolean2 = Boolean.valueOf(num3 != 0);
        this.firePropertyChange(str, (object) boolean1, (object) boolean2);
      }
    }
  }
}
