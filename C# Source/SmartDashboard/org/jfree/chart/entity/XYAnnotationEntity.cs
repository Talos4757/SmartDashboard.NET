// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.XYAnnotationEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class XYAnnotationEntity : ChartEntity, Serializable.__Interface
  {
    private const long serialVersionUID = 2340334068383660799L;
    private int rendererIndex;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYAnnotationEntity(Shape hotspot, int rendererIndex, string toolTipText, string urlText)
      : base(hotspot, toolTipText, urlText)
    {
      XYAnnotationEntity annotationEntity = this;
      this.rendererIndex = rendererIndex;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYAnnotationEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYAnnotationEntity obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int getRendererIndex()
    {
      return this.rendererIndex;
    }

    public virtual void setRendererIndex(int index)
    {
      this.rendererIndex = index;
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 100, (byte) 130, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || base.equals(obj) && obj is XYAnnotationEntity && this.rendererIndex == ((XYAnnotationEntity) obj).rendererIndex;
    }
  }
}
