// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIColor
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIColor : Object
  {
    internal static WPIColor __\u003C\u003EBLACK;
    internal static WPIColor __\u003C\u003EBLUE;
    internal static WPIColor __\u003C\u003ECYAN;
    internal static WPIColor __\u003C\u003EGRAY;
    internal static WPIColor __\u003C\u003EGREEN;
    internal static WPIColor __\u003C\u003EMAGENTA;
    internal static WPIColor __\u003C\u003EONE;
    internal static WPIColor __\u003C\u003EONEHALF;
    internal static WPIColor __\u003C\u003ERED;
    internal static WPIColor __\u003C\u003EWHITE;
    internal static WPIColor __\u003C\u003EYELLOW;
    internal static WPIColor __\u003C\u003EZERO;
    [Modifiers]
    private object scalar;
    private Color color;

    [Modifiers]
    public static WPIColor BLACK
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EBLACK;
      }
    }

    [Modifiers]
    public static WPIColor BLUE
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EBLUE;
      }
    }

    [Modifiers]
    public static WPIColor CYAN
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003ECYAN;
      }
    }

    [Modifiers]
    public static WPIColor GRAY
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EGRAY;
      }
    }

    [Modifiers]
    public static WPIColor GREEN
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EGREEN;
      }
    }

    [Modifiers]
    public static WPIColor MAGENTA
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EMAGENTA;
      }
    }

    [Modifiers]
    public static WPIColor ONE
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EONE;
      }
    }

    [Modifiers]
    public static WPIColor ONEHALF
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EONEHALF;
      }
    }

    [Modifiers]
    public static WPIColor RED
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003ERED;
      }
    }

    [Modifiers]
    public static WPIColor WHITE
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EWHITE;
      }
    }

    [Modifiers]
    public static WPIColor YELLOW
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EYELLOW;
      }
    }

    [Modifiers]
    public static WPIColor ZERO
    {
      [HideFromJava] get
      {
        return WPIColor.__\u003C\u003EZERO;
      }
    }

    [LineNumberTable((ushort) 15)]
    static WPIColor()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 135, (byte) 177, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIColor([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIColor), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      base.\u002Ector();
      WPIColor wpiColor = this;
      this.scalar = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 81, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIColor([In] object obj0, [In] Color obj1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIColor), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: explicit constructor call
      this.\u002Ector(obj0);
      WPIColor wpiColor = this;
      this.color = obj1;
    }

    [LineNumberTable((ushort) 47)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIColor(int red, int green, int blue)
    {
      WPIColor wpiColor = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIColor(Color color)
    {
      WPIColor wpiColor = this;
      double num1 = (double) color.getRed();
      double num2 = (double) color.getGreen();
      double num3 = (double) color.getBlue();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    internal virtual object toCvScalar()
    {
      return this.scalar;
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 104, (byte) 151})]
    public virtual Color toColor()
    {
      if (this.color != null)
        return this.color;
      WPIColor wpiColor = this;
      Color.__\u003Cclinit\u003E();
      object obj = this.scalar;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }
  }
}
