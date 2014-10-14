// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.IntervalMarker
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart.@event;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class IntervalMarker : Marker, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -1762344775267627916L;
    private double startValue;
    private double endValue;
    private GradientPaintTransformer gradientPaintTransformer;

    [LineNumberTable(new byte[] {(byte) 67, (byte) 114, (byte) 105, (byte) 105, (byte) 103, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalMarker(double start, double end, Paint paint, Stroke stroke, Paint outlinePaint, Stroke outlineStroke, float alpha)
      : base(paint, stroke, outlinePaint, outlineStroke, alpha)
    {
      IntervalMarker intervalMarker = this;
      this.startValue = start;
      this.endValue = end;
      this.gradientPaintTransformer = (GradientPaintTransformer) null;
      this.setLabelOffsetType(LengthAdjustmentType.__\u003C\u003ECONTRACT);
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 159, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalMarker(double start, double end)
      : this(start, end, (Paint) Color.gray, (Stroke) new BasicStroke(0.5f), (Paint) Color.gray, (Stroke) new BasicStroke(0.5f), 0.8f)
    {
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 126})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalMarker(double start, double end, Paint paint)
      : this(start, end, paint, (Stroke) new BasicStroke(0.5f), (Paint) null, (Stroke) null, 0.8f)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected IntervalMarker([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] IntervalMarker obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] IntervalMarker obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getStartValue()
    {
      return this.startValue;
    }

    public virtual double getEndValue()
    {
      return this.endValue;
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartValue(double value)
    {
      this.startValue = value;
      this.notifyListeners(new MarkerChangeEvent((Marker) this));
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEndValue(double value)
    {
      this.endValue = value;
      this.notifyListeners(new MarkerChangeEvent((Marker) this));
    }

    public virtual GradientPaintTransformer getGradientPaintTransformer()
    {
      return this.gradientPaintTransformer;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 72, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGradientPaintTransformer(GradientPaintTransformer transformer)
    {
      this.gradientPaintTransformer = transformer;
      this.notifyListeners(new MarkerChangeEvent((Marker) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is IntervalMarker) || !base.equals(obj))
        return false;
      IntervalMarker intervalMarker = (IntervalMarker) obj;
      return this.startValue == intervalMarker.startValue && this.endValue == intervalMarker.endValue && ObjectUtilities.equal((object) this.gradientPaintTransformer, (object) intervalMarker.gradientPaintTransformer);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 230)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
