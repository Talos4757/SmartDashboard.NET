// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.Align
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  public sealed class Align : Object
  {
    public const int CENTER = 0;
    public const int TOP = 1;
    public const int BOTTOM = 2;
    public const int LEFT = 4;
    public const int RIGHT = 8;
    public const int TOP_LEFT = 5;
    public const int TOP_RIGHT = 9;
    public const int BOTTOM_LEFT = 6;
    public const int BOTTOM_RIGHT = 10;
    public const int FIT_HORIZONTAL = 12;
    public const int FIT_VERTICAL = 3;
    public const int FIT = 15;
    public const int NORTH = 1;
    public const int SOUTH = 2;
    public const int WEST = 4;
    public const int EAST = 8;
    public const int NORTH_WEST = 5;
    public const int NORTH_EAST = 9;
    public const int SOUTH_WEST = 6;
    public const int SOUTH_EAST = 10;

    [LineNumberTable(new byte[] {(byte) 69, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Align()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 121, (byte) 121, (byte) 104, (byte) 136, (byte) 102, (byte) 168, (byte) 104, (byte) 168, (byte) 102, (byte) 168, (byte) 102, (byte) 170, (byte) 102, (byte) 168, (byte) 102, (byte) 170, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void align(Rectangle2D rect, Rectangle2D frame, int align)
    {
      double num1 = ((RectangularShape) frame).getCenterX() - ((RectangularShape) rect).getWidth() / 2.0;
      double num2 = ((RectangularShape) frame).getCenterY() - ((RectangularShape) rect).getHeight() / 2.0;
      double width = ((RectangularShape) rect).getWidth();
      double height = ((RectangularShape) rect).getHeight();
      if ((align & 3) == 3)
        height = ((RectangularShape) frame).getHeight();
      if ((align & 12) == 12)
        width = ((RectangularShape) frame).getWidth();
      if ((align & 1) == 1)
        num2 = ((RectangularShape) frame).getMinY();
      if ((align & 2) == 2)
        num2 = ((RectangularShape) frame).getMaxY() - height;
      if ((align & 4) == 4)
        num1 = ((RectangularShape) frame).getX();
      if ((align & 8) == 8)
        num1 = ((RectangularShape) frame).getMaxX() - width;
      rect.setRect(num1, num2, width, height);
    }
  }
}
