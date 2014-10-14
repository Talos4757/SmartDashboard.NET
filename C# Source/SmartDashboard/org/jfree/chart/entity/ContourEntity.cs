// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.ContourEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Obsolete]
  [Serializable]
  public class ContourEntity : ChartEntity, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 1249570520505992847L;
    private int index;

    [LineNumberTable(new byte[] {(byte) 26, (byte) 234, (byte) 55, (byte) 231, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContourEntity(Shape area, string toolTipText)
      : base(area, toolTipText)
    {
      ContourEntity contourEntity = this;
      this.index = -1;
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 235, (byte) 44, (byte) 231, (byte) 85})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContourEntity(Shape area, string toolTipText, string urlText)
      : base(area, toolTipText, urlText)
    {
      ContourEntity contourEntity = this;
      this.index = -1;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ContourEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ContourEntity obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ContourEntity obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int getIndex()
    {
      return this.index;
    }

    public virtual void setIndex(int index)
    {
      this.index = index;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 100, (byte) 130, (byte) 113, (byte) 103, (byte) 110, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is ContourEntity && base.equals(obj) && this.index == ((ContourEntity) obj).index;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 137)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
