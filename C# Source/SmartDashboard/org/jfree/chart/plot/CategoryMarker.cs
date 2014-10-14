// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CategoryMarker
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart.@event;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CategoryMarker : Marker, Cloneable.__Interface, Serializable.__Interface
  {
    private IComparable key;
    private bool drawAsLine;

    [LineNumberTable(new byte[] {(byte) 40, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryMarker(IComparable key, Paint paint, Stroke stroke)
      : this(key, paint, stroke, paint, stroke, 1f)
    {
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 241, (byte) 29, (byte) 231, (byte) 100, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryMarker(IComparable key, Paint paint, Stroke stroke, Paint outlinePaint, Stroke outlineStroke, float alpha)
      : base(paint, stroke, outlinePaint, outlineStroke, alpha)
    {
      CategoryMarker categoryMarker = this;
      this.drawAsLine = false;
      this.key = key;
      this.setLabelOffsetType(LengthAdjustmentType.__\u003C\u003EEXPAND);
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryMarker(IComparable key)
      : this(key, (Paint) Color.gray, (Stroke) new BasicStroke(1f))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryMarker([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryMarker obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryMarker obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setKey(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.key = key;
        this.notifyListeners(new MarkerChangeEvent((Marker) this));
      }
    }

    public virtual bool getDrawAsLine()
    {
      return this.drawAsLine;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 130, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawAsLine(bool drawAsLine)
    {
      this.drawAsLine = drawAsLine;
      this.notifyListeners(new MarkerChangeEvent((Marker) this));
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 99, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == null || !(obj is CategoryMarker) || !base.equals(obj))
        return false;
      CategoryMarker categoryMarker = (CategoryMarker) obj;
      return Object.instancehelper_equals((object) this.key, (object) categoryMarker.key) && this.drawAsLine == categoryMarker.drawAsLine;
    }
  }
}
