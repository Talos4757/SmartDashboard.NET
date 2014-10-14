// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PlotRenderingInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class PlotRenderingInfo : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 8446720134379617220L;
    private ChartRenderingInfo owner;
    [NonSerialized]
    private Rectangle2D plotArea;
    [NonSerialized]
    private Rectangle2D dataArea;
    private List subplotInfo;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 104, (byte) 103, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlotRenderingInfo(ChartRenderingInfo owner)
    {
      base.\u002Ector();
      PlotRenderingInfo plotRenderingInfo = this;
      this.owner = owner;
      this.dataArea = (Rectangle2D) new Rectangle2D.Double();
      this.subplotInfo = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PlotRenderingInfo([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PlotRenderingInfo obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PlotRenderingInfo obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Rectangle2D getDataArea()
    {
      return this.dataArea;
    }

    [LineNumberTable((ushort) 155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubplotCount()
    {
      return this.subplotInfo.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 99, (byte) 144, (byte) 103, (byte) 102, (byte) 104, (byte) 103, (byte) 105, (byte) 226, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubplotIndex(Point2D source)
    {
      if (source == null)
      {
        string str = "Null 'source' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int subplotCount = this.getSubplotCount();
        for (int index = 0; index < subplotCount; ++index)
        {
          if (((RectangularShape) this.getSubplotInfo(index).getDataArea()).contains(source))
            return index;
        }
        return -1;
      }
    }

    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PlotRenderingInfo getSubplotInfo(int index)
    {
      return (PlotRenderingInfo) this.subplotInfo.get(index);
    }

    public virtual ChartRenderingInfo getOwner()
    {
      return this.owner;
    }

    public virtual void setPlotArea(Rectangle2D area)
    {
      this.plotArea = area;
    }

    public virtual void setDataArea(Rectangle2D area)
    {
      this.dataArea = area;
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubplotInfo(PlotRenderingInfo info)
    {
      this.subplotInfo.add((object) info);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 108, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 118, (byte) 112, (byte) 146, (byte) 242, (byte) 61, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      PlotRenderingInfo plotRenderingInfo1 = (PlotRenderingInfo) base.clone();
      if (this.plotArea != null)
        plotRenderingInfo1.plotArea = (Rectangle2D) ((RectangularShape) this.plotArea).clone();
      if (this.dataArea != null)
        plotRenderingInfo1.dataArea = (Rectangle2D) ((RectangularShape) this.dataArea).clone();
      plotRenderingInfo1.subplotInfo = (List) new ArrayList(this.subplotInfo.size());
      for (int index = 0; index < this.subplotInfo.size(); ++index)
      {
        PlotRenderingInfo plotRenderingInfo2 = (PlotRenderingInfo) this.subplotInfo.get(index);
        plotRenderingInfo1.subplotInfo.add(plotRenderingInfo2.clone());
      }
      return (object) plotRenderingInfo1;
    }

    public virtual Rectangle2D getPlotArea()
    {
      return this.plotArea;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is PlotRenderingInfo))
        return false;
      PlotRenderingInfo plotRenderingInfo = (PlotRenderingInfo) obj;
      return ObjectUtilities.equal((object) this.dataArea, (object) plotRenderingInfo.dataArea) && ObjectUtilities.equal((object) this.plotArea, (object) plotRenderingInfo.plotArea) && ObjectUtilities.equal((object) this.subplotInfo, (object) plotRenderingInfo.subplotInfo);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape((Shape) this.dataArea, obj0);
      SerialUtilities.writeShape((Shape) this.plotArea, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 170, (byte) 102, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.dataArea = (Rectangle2D) SerialUtilities.readShape(obj0);
      this.plotArea = (Rectangle2D) SerialUtilities.readShape(obj0);
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
