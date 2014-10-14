// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PieLabelDistributor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Serializable]
  public class PieLabelDistributor : AbstractPieLabelDistributor
  {
    private double minGap;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 232, (byte) 56, (byte) 240, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PieLabelDistributor(int labelCount)
    {
      PieLabelDistributor labelDistributor = this;
      this.minGap = 4.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PieLabelDistributor([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sort()
    {
      Collections.sort(this.labels);
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 102, (byte) 112, (byte) 104, (byte) 105, (byte) 130, (byte) 232, (byte) 59, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isOverlap()
    {
      double num = 0.0;
      for (int index = 0; index < this.labels.size(); ++index)
      {
        PieLabelRecord pieLabelRecord = this.getPieLabelRecord(index);
        if (num > pieLabelRecord.getLowerY())
          return true;
        num = pieLabelRecord.getUpperY();
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 117, (byte) 104, (byte) 106, (byte) 110, (byte) 255, (byte) 32, (byte) 60, (byte) 233, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void adjustDownwards(double minY, double height)
    {
      for (int index = 0; index < this.labels.size() - 1; ++index)
      {
        PieLabelRecord pieLabelRecord1 = this.getPieLabelRecord(index);
        PieLabelRecord pieLabelRecord2 = this.getPieLabelRecord(index + 1);
        if (pieLabelRecord2.getLowerY() < pieLabelRecord1.getUpperY())
          pieLabelRecord2.setAllocatedY(Math.min(minY + height - pieLabelRecord2.getLabelHeight() / 2.0, pieLabelRecord1.getUpperY() + this.minGap + pieLabelRecord2.getLabelHeight() / 2.0));
      }
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 117, (byte) 104, (byte) 106, (byte) 110, (byte) 255, (byte) 29, (byte) 60, (byte) 233, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void adjustUpwards(double minY, double height)
    {
      int index = this.labels.size() - 1;
      while (index > 0)
      {
        PieLabelRecord pieLabelRecord1 = this.getPieLabelRecord(index);
        PieLabelRecord pieLabelRecord2 = this.getPieLabelRecord(index - 1);
        if (pieLabelRecord2.getUpperY() > pieLabelRecord1.getLowerY())
          pieLabelRecord2.setAllocatedY(Math.max(minY + pieLabelRecord2.getLabelHeight() / 2.0, pieLabelRecord1.getLowerY() - this.minGap - pieLabelRecord2.getLabelHeight() / 2.0));
        index += -1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 99, (byte) 102, (byte) 112, (byte) 48, (byte) 166, (byte) 102, (byte) 110, (byte) 146, (byte) 114, (byte) 106, (byte) 117, (byte) 104, (byte) 247, (byte) 60, (byte) 232, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void spreadEvenly(double minY, double height)
    {
      double num1 = minY;
      double num2 = 0.0;
      for (int index = 0; index < this.labels.size(); ++index)
        num2 += this.getPieLabelRecord(index).getLabelHeight();
      double num3 = height - num2;
      if (this.labels.size() > 1)
        num3 /= (double) (this.labels.size() - 1);
      for (int index = 0; index < this.labels.size(); ++index)
      {
        PieLabelRecord pieLabelRecord = this.getPieLabelRecord(index);
        double y = num1 + pieLabelRecord.getLabelHeight() / 2.0;
        pieLabelRecord.setAllocatedY(y);
        num1 = y + pieLabelRecord.getLabelHeight() / 2.0 + num3;
      }
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 230, (byte) 69, (byte) 104, (byte) 170, (byte) 104, (byte) 170, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void distributeLabels(double minY, double height)
    {
      this.sort();
      if (this.isOverlap())
        this.adjustDownwards(minY, height);
      if (this.isOverlap())
        this.adjustUpwards(minY, height);
      if (!this.isOverlap())
        return;
      this.spreadEvenly(minY, height);
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 98, (byte) 110, (byte) 103, (byte) 102, (byte) 104, (byte) 106, (byte) 110, (byte) 151, (byte) 175, (byte) 106, (byte) 104, (byte) 110, (byte) 119, (byte) 143, (byte) 100, (byte) 100, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void adjustInwards()
    {
      int index1 = 0;
      int index2 = this.labels.size() - 1;
      while (index2 > index1)
      {
        if (index1 < index2 - 1)
        {
          PieLabelRecord pieLabelRecord1 = this.getPieLabelRecord(index1);
          PieLabelRecord pieLabelRecord2 = this.getPieLabelRecord(index1 + 1);
          if (pieLabelRecord2.getLowerY() < pieLabelRecord1.getUpperY())
          {
            double num = pieLabelRecord1.getUpperY() - pieLabelRecord2.getLowerY() + this.minGap;
            pieLabelRecord2.setAllocatedY(pieLabelRecord2.getAllocatedY() + num);
          }
        }
        PieLabelRecord pieLabelRecord3 = this.getPieLabelRecord(index2 - 1);
        PieLabelRecord pieLabelRecord4 = this.getPieLabelRecord(index2);
        if (pieLabelRecord3.getUpperY() > pieLabelRecord4.getLowerY())
        {
          double num = pieLabelRecord3.getUpperY() - pieLabelRecord4.getLowerY() + this.minGap;
          pieLabelRecord4.setAllocatedY(pieLabelRecord4.getAllocatedY() + num);
        }
        ++index1;
        index2 += -1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 102, (byte) 112, (byte) 61, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      for (int index = 0; index < this.labels.size(); ++index)
        stringBuffer.append(this.getPieLabelRecord(index).toString()).append("\n");
      return stringBuffer.toString();
    }
  }
}
