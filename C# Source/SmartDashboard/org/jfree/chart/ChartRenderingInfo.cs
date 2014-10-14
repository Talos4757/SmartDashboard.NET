// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartRenderingInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class ChartRenderingInfo : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2751952018173406822L;
    [NonSerialized]
    private Rectangle2D chartArea;
    private PlotRenderingInfo plotInfo;
    private EntityCollection entities;

    [LineNumberTable(new byte[] {(byte) 52, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartRenderingInfo()
      : this((EntityCollection) new StandardEntityCollection())
    {
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 104, (byte) 107, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartRenderingInfo(EntityCollection entities)
    {
      base.\u002Ector();
      ChartRenderingInfo chartRenderingInfo = this;
      this.chartArea = (Rectangle2D) new Rectangle2D.Double();
      this.plotInfo = new PlotRenderingInfo(this);
      this.entities = entities;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartRenderingInfo([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ChartRenderingInfo obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ChartRenderingInfo obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual EntityCollection getEntityCollection()
    {
      return this.entities;
    }

    public virtual PlotRenderingInfo getPlotInfo()
    {
      return this.plotInfo;
    }

    public virtual Rectangle2D getChartArea()
    {
      return this.chartArea;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setChartArea(Rectangle2D area)
    {
      this.chartArea.setRect(area);
    }

    public virtual void setEntityCollection(EntityCollection entities)
    {
      this.entities = entities;
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 127, (byte) 0, (byte) 108, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.chartArea.setRect(0.0, 0.0, 0.0, 0.0);
      this.plotInfo = new PlotRenderingInfo(this);
      if (this.entities == null)
        return;
      this.entities.clear();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ChartRenderingInfo))
        return false;
      ChartRenderingInfo chartRenderingInfo = (ChartRenderingInfo) obj;
      return ObjectUtilities.equal((object) this.chartArea, (object) chartRenderingInfo.chartArea) && ObjectUtilities.equal((object) this.plotInfo, (object) chartRenderingInfo.plotInfo) && ObjectUtilities.equal((object) this.entities, (object) chartRenderingInfo.entities);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 108, (byte) 104, (byte) 150, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      ChartRenderingInfo chartRenderingInfo = (ChartRenderingInfo) base.clone();
      if (this.chartArea != null)
        chartRenderingInfo.chartArea = (Rectangle2D) ((RectangularShape) this.chartArea).clone();
      if (this.entities is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.entities;
        chartRenderingInfo.entities = (EntityCollection) publicCloneable.clone();
      }
      return (object) chartRenderingInfo;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape((Shape) this.chartArea, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 102, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.chartArea = (Rectangle2D) SerialUtilities.readShape(obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
