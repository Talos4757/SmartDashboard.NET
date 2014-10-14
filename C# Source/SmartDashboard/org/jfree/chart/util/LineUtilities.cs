// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.util.LineUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.util
{
  public class LineUtilities : Object
  {
    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 104, (byte) 104, (byte) 104, (byte) 136, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 106, (byte) 138, (byte) 106, (byte) 103, (byte) 130, (byte) 102, (byte) 166, (byte) 167, (byte) 144, (byte) 110, (byte) 136, (byte) 144, (byte) 110, (byte) 136, (byte) 144, (byte) 110, (byte) 133, (byte) 144, (byte) 110, (byte) 131, (byte) 143, (byte) 167, (byte) 144, (byte) 110, (byte) 136, (byte) 144, (byte) 110, (byte) 136, (byte) 144, (byte) 110, (byte) 133, (byte) 144, (byte) 110, (byte) 131, (byte) 138, (byte) 133, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool clipLine(Line2D line, Rectangle2D rect)
    {
      double num1 = line.getX1();
      double num2 = line.getY1();
      double num3 = line.getX2();
      double num4 = line.getY2();
      double minX = ((RectangularShape) rect).getMinX();
      double maxX = ((RectangularShape) rect).getMaxX();
      double minY = ((RectangularShape) rect).getMinY();
      double maxY = ((RectangularShape) rect).getMaxY();
      int num5 = rect.outcode(num1, num2);
      int num6 = rect.outcode(num3, num4);
      while ((num5 | num6) != 0)
      {
        if ((num5 & num6) != 0)
          return false;
        double num7 = num3 - num1;
        double num8 = num4 - num2;
        if (num5 != 0)
        {
          if ((num5 & 1) == 1 && num7 != 0.0)
          {
            num2 += (minX - num1) * num8 / num7;
            num1 = minX;
          }
          else if ((num5 & 4) == 4 && num7 != 0.0)
          {
            num2 += (maxX - num1) * num8 / num7;
            num1 = maxX;
          }
          else if ((num5 & 8) == 8 && num8 != 0.0)
          {
            num1 += (maxY - num2) * num7 / num8;
            num2 = maxY;
          }
          else if ((num5 & 2) == 2 && num8 != 0.0)
          {
            num1 += (minY - num2) * num7 / num8;
            num2 = minY;
          }
          num5 = rect.outcode(num1, num2);
        }
        else if (num6 != 0)
        {
          if ((num6 & 1) == 1 && num7 != 0.0)
          {
            num4 += (minX - num3) * num8 / num7;
            num3 = minX;
          }
          else if ((num6 & 4) == 4 && num7 != 0.0)
          {
            num4 += (maxX - num3) * num8 / num7;
            num3 = maxX;
          }
          else if ((num6 & 8) == 8 && num8 != 0.0)
          {
            num3 += (maxY - num4) * num7 / num8;
            num4 = maxY;
          }
          else if ((num6 & 2) == 2 && num8 != 0.0)
          {
            num3 += (minY - num4) * num7 / num8;
            num4 = minY;
          }
          num6 = rect.outcode(num3, num4);
        }
      }
      line.setLine(num1, num2, num3, num4);
      return true;
    }
  }
}
