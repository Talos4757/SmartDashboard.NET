// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.DefaultHeatMapDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.data;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.general.HeatMapDataset", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultHeatMapDataset : AbstractDataset, HeatMapDataset, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private int xSamples;
    private int ySamples;
    private double minX;
    private double maxX;
    private double minY;
    private double maxY;
    private double[][] zValues;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 136, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 114, (byte) 144, (byte) 116, (byte) 144, (byte) 116, (byte) 144, (byte) 116, (byte) 176, (byte) 103, (byte) 103, (byte) 105, (byte) 106, (byte) 106, (byte) 106, (byte) 108, (byte) 102, (byte) 46, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultHeatMapDataset(int xSamples, int ySamples, double minX, double maxX, double minY, double maxY)
    {
      DefaultHeatMapDataset defaultHeatMapDataset = this;
      if (xSamples < 1)
      {
        string str = "Requires 'xSamples' > 0";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (ySamples < 1)
      {
        string str = "Requires 'ySamples' > 0";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (Double.isInfinite(minX) || Double.isNaN(minX))
      {
        string str = "'minX' cannot be INF or NaN.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (Double.isInfinite(maxX) || Double.isNaN(maxX))
      {
        string str = "'maxX' cannot be INF or NaN.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (Double.isInfinite(minY) || Double.isNaN(minY))
      {
        string str = "'minY' cannot be INF or NaN.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (Double.isInfinite(maxY) || Double.isNaN(maxY))
      {
        string str = "'maxY' cannot be INF or NaN.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.xSamples = xSamples;
        this.ySamples = ySamples;
        this.minX = minX;
        this.maxX = maxX;
        this.minY = minY;
        this.maxY = maxY;
        this.zValues = new double[xSamples][];
        for (int index = 0; index < xSamples; ++index)
          this.zValues[index] = new double[ySamples];
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultHeatMapDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultHeatMapDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultHeatMapDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 223)]
    public virtual double getZValue(int xIndex, int yIndex)
    {
      return this.zValues[xIndex][yIndex];
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 77, (byte) 163, (byte) 108, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setZValue(int xIndex, int yIndex, double z, bool notify)
    {
      int num = notify ? 1 : 0;
      this.zValues[xIndex][yIndex] = z;
      if (num == 0)
        return;
      this.fireDatasetChanged();
    }

    public virtual int getXSampleCount()
    {
      return this.xSamples;
    }

    public virtual int getYSampleCount()
    {
      return this.ySamples;
    }

    public virtual double getMinimumXValue()
    {
      return this.minX;
    }

    public virtual double getMaximumXValue()
    {
      return this.maxX;
    }

    public virtual double getMinimumYValue()
    {
      return this.minY;
    }

    public virtual double getMaximumYValue()
    {
      return this.maxY;
    }

    public virtual double getXValue(int xIndex)
    {
      return this.minX + (this.maxX - this.minX) * ((double) xIndex / (double) this.xSamples);
    }

    public virtual double getYValue(int yIndex)
    {
      return this.minY + (this.maxY - this.minY) * ((double) yIndex / (double) this.ySamples);
    }

    [LineNumberTable((ushort) 238)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getZ(int xIndex, int yIndex)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getZValue(xIndex, yIndex));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 136, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setZValue(int xIndex, int yIndex, double z)
    {
      this.setZValue(xIndex, yIndex, z, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultHeatMapDataset))
        return false;
      DefaultHeatMapDataset defaultHeatMapDataset = (DefaultHeatMapDataset) obj;
      return this.xSamples == defaultHeatMapDataset.xSamples && this.ySamples == defaultHeatMapDataset.ySamples && (this.minX == defaultHeatMapDataset.minX && this.maxX == defaultHeatMapDataset.maxX) && (this.minY == defaultHeatMapDataset.minY && this.maxY == defaultHeatMapDataset.maxY && DataUtilities.equal(this.zValues, defaultHeatMapDataset.zValues));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultHeatMapDataset defaultHeatMapDataset = (DefaultHeatMapDataset) base.clone();
      defaultHeatMapDataset.zValues = DataUtilities.clone(this.zValues);
      return (object) defaultHeatMapDataset;
    }
  }
}
