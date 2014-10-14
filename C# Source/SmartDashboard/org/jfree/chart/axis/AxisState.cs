// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.AxisState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.ui;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.axis
{
  public class AxisState : Object
  {
    private double cursor;
    private List ticks;
    private double max;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 105, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisState(double cursor)
    {
      base.\u002Ector();
      AxisState axisState = this;
      this.cursor = cursor;
      this.ticks = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisState()
      : this(0.0)
    {
    }

    public virtual double getCursor()
    {
      return this.cursor;
    }

    public virtual void cursorUp(double units)
    {
      this.cursor = this.cursor - units;
    }

    public virtual void cursorDown(double units)
    {
      this.cursor = this.cursor + units;
    }

    public virtual void cursorLeft(double units)
    {
      this.cursor = this.cursor - units;
    }

    public virtual void cursorRight(double units)
    {
      this.cursor = this.cursor + units;
    }

    public virtual void setCursor(double cursor)
    {
      this.cursor = cursor;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 104, (byte) 138, (byte) 104, (byte) 138, (byte) 104, (byte) 138, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void moveCursor(double units, RectangleEdge edge)
    {
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        this.cursorUp(units);
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        this.cursorDown(units);
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
      {
        this.cursorLeft(units);
      }
      else
      {
        if (edge != RectangleEdge.__\u003C\u003ERIGHT)
          return;
        this.cursorRight(units);
      }
    }

    public virtual List getTicks()
    {
      return this.ticks;
    }

    public virtual void setTicks(List ticks)
    {
      this.ticks = ticks;
    }

    public virtual double getMax()
    {
      return this.max;
    }

    public virtual void setMax(double max)
    {
      this.max = max;
    }
  }
}
