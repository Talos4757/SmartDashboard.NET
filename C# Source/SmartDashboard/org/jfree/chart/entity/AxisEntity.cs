// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.AxisEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Serializable]
  public class AxisEntity : ChartEntity
  {
    private const long serialVersionUID = -4445994133561919083L;
    private Axis axis;

    [LineNumberTable(new byte[] {(byte) 25, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisEntity(Shape area, Axis axis)
      : this(area, axis, (string) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisEntity(Shape area, Axis axis, string toolTipText)
      : this(area, axis, toolTipText, (string) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 108, (byte) 99, (byte) 176, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisEntity(Shape area, Axis axis, string toolTipText, string urlText)
      : base(area, toolTipText, urlText)
    {
      AxisEntity axisEntity = this;
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.axis = axis;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AxisEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual Axis getAxis()
    {
      return this.axis;
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 107, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      StringBuffer stringBuffer = new StringBuffer("AxisEntity: ");
      stringBuffer.append("tooltip = ");
      stringBuffer.append(this.getToolTipText());
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AxisEntity))
        return false;
      AxisEntity axisEntity = (AxisEntity) obj;
      return Object.instancehelper_equals((object) this.getArea(), (object) axisEntity.getArea()) && ObjectUtilities.equal((object) this.getToolTipText(), (object) axisEntity.getToolTipText()) && (ObjectUtilities.equal((object) this.getURLText(), (object) axisEntity.getURLText()) && this.axis.equals((object) axisEntity.axis));
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 99, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(39, this.getToolTipText()), this.getURLText());
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.getArea(), obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.setArea(SerialUtilities.readShape(obj0));
    }
  }
}
