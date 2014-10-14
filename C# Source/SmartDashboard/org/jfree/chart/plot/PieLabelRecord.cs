// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PieLabelRecord
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class PieLabelRecord : Object, Comparable, Serializable.__Interface, ISerializable
  {
    private IComparable key;
    private double angle;
    private double baseY;
    private double allocatedY;
    private TextBox label;
    private double labelHeight;
    private double gap;
    private double linkPercent;

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 103, (byte) 105, (byte) 105, (byte) 105, (byte) 104, (byte) 106, (byte) 106, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PieLabelRecord(IComparable key, double angle, double baseY, TextBox label, double labelHeight, double gap, double linkPercent)
    {
      base.\u002Ector();
      PieLabelRecord pieLabelRecord = this;
      this.key = key;
      this.angle = angle;
      this.baseY = baseY;
      this.allocatedY = baseY;
      this.label = label;
      this.labelHeight = labelHeight;
      this.gap = gap;
      this.linkPercent = linkPercent;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PieLabelRecord([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PieLabelRecord obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getLowerY()
    {
      return this.allocatedY - this.labelHeight / 2.0;
    }

    public virtual double getUpperY()
    {
      return this.allocatedY + this.labelHeight / 2.0;
    }

    public virtual double getAllocatedY()
    {
      return this.allocatedY;
    }

    public virtual void setAllocatedY(double y)
    {
      this.allocatedY = y;
    }

    public virtual double getLabelHeight()
    {
      return this.labelHeight;
    }

    [LineNumberTable((ushort) 282)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append(this.baseY).append(", ").append(Object.instancehelper_toString((object) this.key)).toString();
    }

    public virtual double getBaseY()
    {
      return this.baseY;
    }

    public virtual void setBaseY(double @base)
    {
      this.baseY = @base;
    }

    public virtual double getAngle()
    {
      return this.angle;
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    public virtual TextBox getLabel()
    {
      return this.label;
    }

    public virtual double getGap()
    {
      return this.gap;
    }

    public virtual double getLinkPercent()
    {
      return this.linkPercent;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 98, (byte) 104, (byte) 103, (byte) 110, (byte) 132, (byte) 110, (byte) 162})]
    public virtual int compareTo(object obj)
    {
      int num = 0;
      if (obj is PieLabelRecord)
      {
        PieLabelRecord pieLabelRecord = (PieLabelRecord) obj;
        if (this.baseY < pieLabelRecord.baseY)
          num = -1;
        else if (this.baseY > pieLabelRecord.baseY)
          num = 1;
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 128, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PieLabelRecord))
        return false;
      PieLabelRecord pieLabelRecord = (PieLabelRecord) obj;
      return Object.instancehelper_equals((object) this.key, (object) pieLabelRecord.key) && this.angle == pieLabelRecord.angle && (this.gap == pieLabelRecord.gap && this.allocatedY == pieLabelRecord.allocatedY) && (this.baseY == pieLabelRecord.baseY && this.labelHeight == pieLabelRecord.labelHeight && (this.linkPercent == pieLabelRecord.linkPercent && this.label.equals((object) pieLabelRecord.label)));
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
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
