// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.OutlierList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.renderer
{
  public class OutlierList : Object
  {
    private List outliers;
    private Outlier averagedOutlier;
    private bool multiple;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 232, (byte) 57, (byte) 231, (byte) 72, (byte) 107, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OutlierList(Outlier outlier)
    {
      base.\u002Ector();
      OutlierList outlierList = this;
      this.multiple = false;
      this.outliers = (List) new ArrayList();
      this.setAveragedOutlier(outlier);
    }

    public virtual void setAveragedOutlier(Outlier averagedOutlier)
    {
      this.averagedOutlier = averagedOutlier;
    }

    public virtual Outlier getAveragedOutlier()
    {
      return this.averagedOutlier;
    }

    [LineNumberTable((ushort) 107)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.outliers.size();
    }

    [LineNumberTable((ushort) 98)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool add(Outlier outlier)
    {
      return (this.outliers.add((object) outlier) ? 1 : 0) != 0;
    }

    public virtual bool isMultiple()
    {
      return this.multiple;
    }

    public virtual void setMultiple(bool multiple)
    {
      this.multiple = multiple;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 99, (byte) 162, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isOverlapped(Outlier other)
    {
      if (other == null)
        return false;
      else
        return other.overlaps(this.getAveragedOutlier());
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 102, (byte) 102, (byte) 103, (byte) 108, (byte) 104, (byte) 109, (byte) 107, (byte) 107, (byte) 98, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateAveragedOutlier()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      int itemCount = this.getItemCount();
      Iterator iterator = this.outliers.iterator();
      while (iterator.hasNext())
      {
        Outlier outlier = (Outlier) iterator.next();
        num1 += outlier.getX();
        num2 += outlier.getY();
      }
      this.getAveragedOutlier().getPoint().setLocation((Point2D) new Point2D.Double(num1 / (double) itemCount, num2 / (double) itemCount));
    }
  }
}
