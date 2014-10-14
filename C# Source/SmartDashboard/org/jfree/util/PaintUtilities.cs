// Decompiled with JetBrains decompiler
// Type: org.jfree.util.PaintUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using java.lang.reflect;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.util
{
  public class PaintUtilities : Object
  {
    internal static Class class\u0024java\u0024awt\u0024Color;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PaintUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 99, (byte) 136, (byte) 99, (byte) 162, (byte) 130, (byte) 118, (byte) 103, (byte) 103, (byte) 255, (byte) 81, (byte) 70, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(Paint p1, Paint p2)
    {
      if (p1 == null)
      {
        return p2 == null;
      }
      else
      {
        if (p2 == null)
          return false;
        int num;
        if (p1 is GradientPaint && p2 is GradientPaint)
        {
          GradientPaint gradientPaint1 = (GradientPaint) p1;
          GradientPaint gradientPaint2 = (GradientPaint) p2;
          num = !gradientPaint1.getColor1().equals((object) gradientPaint2.getColor1()) || !gradientPaint1.getColor2().equals((object) gradientPaint2.getColor2()) || (!gradientPaint1.getPoint1().equals((object) gradientPaint2.getPoint1()) || !gradientPaint1.getPoint2().equals((object) gradientPaint2.getPoint2())) || (gradientPaint1.isCyclic() != gradientPaint2.isCyclic() || gradientPaint1.getTransparency() != gradientPaint1.getTransparency()) ? 0 : 1;
        }
        else
          num = Object.instancehelper_equals((object) p1, (object) p2) ? 1 : 0;
        return num != 0;
      }
    }

    [LineNumberTable((ushort) 116)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, PaintUtilities.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 127, (byte) 10, (byte) 106, (byte) 100, (byte) 191, (byte) 8, (byte) 103, (byte) 110, (byte) 105, (byte) 106, (byte) 229, (byte) 55, (byte) 255, (byte) 0, (byte) 81, (byte) 2, (byte) 225, (byte) 69, (byte) 115, (byte) 104, (byte) 141, (byte) 107, (byte) 105, (byte) 45, (byte) 200, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string colorToString(Color c)
    {
      try
      {
        foreach (Field field in (PaintUtilities.class\u0024java\u0024awt\u0024Color != null ? PaintUtilities.class\u0024java\u0024awt\u0024Color : (PaintUtilities.class\u0024java\u0024awt\u0024Color = PaintUtilities.class\u0024("java.awt.Color"))).getFields(PaintUtilities.__\u003CGetCallerID\u003E()))
        {
          if (Modifier.isPublic(field.getModifiers()) && Modifier.isFinal(field.getModifiers()) && Modifier.isStatic(field.getModifiers()))
          {
            string name = field.getName();
            object obj = field.get((object) null, PaintUtilities.__\u003CGetCallerID\u003E());
            if (obj is Color && c.equals(obj))
              return name;
          }
        }
        goto label_9;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
label_9:
      string str = Integer.toHexString(c.getRGB() & 16777215);
      StringBuffer stringBuffer = new StringBuffer(7);
      stringBuffer.append("#");
      int num1 = 6 - String.instancehelper_length(str);
      for (int index = 0; index < num1; ++index)
        stringBuffer.append("0");
      stringBuffer.append(str);
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 99, (byte) 198, (byte) 149, (byte) 193, (byte) 159, (byte) 11, (byte) 159, (byte) 11, (byte) 97, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color stringToColor(string value)
    {
      if (value == null)
        return (Color) Color.black;
      Color color1;
      try
      {
        color1 = Color.decode(value);
      }
      catch (NumberFormatException ex)
      {
        goto label_5;
      }
      return color1;
label_5:
      Color color2;
      try
      {
        color2 = (Color) (PaintUtilities.class\u0024java\u0024awt\u0024Color != null ? PaintUtilities.class\u0024java\u0024awt\u0024Color : (PaintUtilities.class\u0024java\u0024awt\u0024Color = PaintUtilities.class\u0024("java.awt.Color"))).getField(value, PaintUtilities.__\u003CGetCallerID\u003E()).get((object) null, PaintUtilities.__\u003CGetCallerID\u003E());
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_10;
      }
      return color2;
label_10:
      Log.info((object) new StringBuffer().append("No such Color : ").append(value).toString());
      return (Color) Color.black;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PaintUtilities.__\u003CcallerID\u003E == null)
        PaintUtilities.__\u003CcallerID\u003E = (CallerID) new PaintUtilities.__\u003CCallerID\u003E();
      return PaintUtilities.__\u003CcallerID\u003E;
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
