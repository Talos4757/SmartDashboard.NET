// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.OutlierListCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.renderer
{
  public class OutlierListCollection : Object
  {
    private List outlierLists;
    private bool highFarOut;
    private bool lowFarOut;

    [LineNumberTable(new byte[] {(byte) 31, (byte) 232, (byte) 53, (byte) 231, (byte) 70, (byte) 231, (byte) 70, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OutlierListCollection()
    {
      base.\u002Ector();
      OutlierListCollection outlierListCollection = this;
      this.highFarOut = false;
      this.lowFarOut = false;
      this.outlierLists = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 98, (byte) 104, (byte) 102, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool updateOutlierList([In] OutlierList obj0, [In] Outlier obj1)
    {
      int num = obj0.add(obj1) ? 1 : 0;
      obj0.updateAveragedOutlier();
      obj0.setMultiple(true);
      return num != 0;
    }

    public virtual bool isHighFarOut()
    {
      return this.highFarOut;
    }

    public virtual void setHighFarOut(bool farOut)
    {
      this.highFarOut = farOut;
    }

    public virtual bool isLowFarOut()
    {
      return this.lowFarOut;
    }

    public virtual void setLowFarOut(bool farOut)
    {
      this.lowFarOut = farOut;
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 109, (byte) 180, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 105, (byte) 137, (byte) 98, (byte) 131, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool add(Outlier outlier)
    {
      if (this.outlierLists.isEmpty())
      {
        return (this.outlierLists.add((object) new OutlierList(outlier)) ? 1 : 0) != 0;
      }
      else
      {
        int num = 0;
        Iterator iterator = this.outlierLists.iterator();
        while (iterator.hasNext())
        {
          OutlierList outlierList = (OutlierList) iterator.next();
          if (outlierList.isOverlapped(outlier))
            num = this.updateOutlierList(outlierList, outlier) ? 1 : 0;
        }
        if (num == 0)
          num = this.outlierLists.add((object) new OutlierList(outlier)) ? 1 : 0;
        return num != 0;
      }
    }

    [LineNumberTable((ushort) 164)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator iterator()
    {
      return this.outlierLists.iterator();
    }
  }
}
