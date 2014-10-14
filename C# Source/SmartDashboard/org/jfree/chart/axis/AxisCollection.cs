// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.AxisCollection
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
  public class AxisCollection : Object
  {
    private List axesAtTop;
    private List axesAtBottom;
    private List axesAtLeft;
    private List axesAtRight;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisCollection()
    {
      base.\u002Ector();
      AxisCollection axisCollection = this;
      this.axesAtTop = (List) new ArrayList();
      this.axesAtBottom = (List) new ArrayList();
      this.axesAtLeft = (List) new ArrayList();
      this.axesAtRight = (List) new ArrayList();
    }

    public virtual List getAxesAtTop()
    {
      return this.axesAtTop;
    }

    public virtual List getAxesAtBottom()
    {
      return this.axesAtBottom;
    }

    public virtual List getAxesAtLeft()
    {
      return this.axesAtLeft;
    }

    public virtual List getAxesAtRight()
    {
      return this.axesAtRight;
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Axis axis, RectangleEdge edge)
    {
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (edge == null)
      {
        string str = "Null 'edge' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (edge == RectangleEdge.__\u003C\u003ETOP)
        this.axesAtTop.add((object) axis);
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        this.axesAtBottom.add((object) axis);
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
      {
        this.axesAtLeft.add((object) axis);
      }
      else
      {
        if (edge != RectangleEdge.__\u003C\u003ERIGHT)
          return;
        this.axesAtRight.add((object) axis);
      }
    }
  }
}
