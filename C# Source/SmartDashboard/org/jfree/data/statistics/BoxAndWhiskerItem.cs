// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.BoxAndWhiskerItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class BoxAndWhiskerItem : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7329649623148167423L;
    private Number mean;
    private Number median;
    private Number q1;
    private Number q3;
    private Number minRegularValue;
    private Number maxRegularValue;
    private Number minOutlier;
    private Number maxOutlier;
    private List outliers;

    [LineNumberTable(new byte[] {(byte) 62, (byte) 136, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerItem(Number mean, Number median, Number q1, Number q3, Number minRegularValue, Number maxRegularValue, Number minOutlier, Number maxOutlier, List outliers)
    {
      base.\u002Ector();
      BoxAndWhiskerItem boxAndWhiskerItem = this;
      this.mean = mean;
      this.median = median;
      this.q1 = q1;
      this.q3 = q3;
      this.minRegularValue = minRegularValue;
      this.maxRegularValue = maxRegularValue;
      this.minOutlier = minOutlier;
      this.maxOutlier = maxOutlier;
      this.outliers = outliers;
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 255, (byte) 40, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerItem(double mean, double median, double q1, double q3, double minRegularValue, double maxRegularValue, double minOutlier, double maxOutlier, List outliers)
      : this((Number) new Double(mean), (Number) new Double(median), (Number) new Double(q1), (Number) new Double(q3), (Number) new Double(minRegularValue), (Number) new Double(maxRegularValue), (Number) new Double(minOutlier), (Number) new Double(maxOutlier), outliers)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BoxAndWhiskerItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BoxAndWhiskerItem obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Number getMean()
    {
      return this.mean;
    }

    public virtual Number getMedian()
    {
      return this.median;
    }

    public virtual Number getQ1()
    {
      return this.q1;
    }

    public virtual Number getQ3()
    {
      return this.q3;
    }

    public virtual Number getMinRegularValue()
    {
      return this.minRegularValue;
    }

    public virtual Number getMaxRegularValue()
    {
      return this.maxRegularValue;
    }

    public virtual Number getMinOutlier()
    {
      return this.minOutlier;
    }

    public virtual Number getMaxOutlier()
    {
      return this.maxOutlier;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getOutliers()
    {
      if (this.outliers == null)
        return (List) null;
      return Collections.unmodifiableList(this.outliers);
    }

    [LineNumberTable((ushort) 244)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append(base.toString()).append("[mean=").append((object) this.mean).append(",median=").append((object) this.median).append(",q1=").append((object) this.q1).append(",q3=").append((object) this.q3).append("]").toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BoxAndWhiskerItem))
        return false;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) obj;
      return ObjectUtilities.equal((object) this.mean, (object) boxAndWhiskerItem.mean) && ObjectUtilities.equal((object) this.median, (object) boxAndWhiskerItem.median) && (ObjectUtilities.equal((object) this.q1, (object) boxAndWhiskerItem.q1) && ObjectUtilities.equal((object) this.q3, (object) boxAndWhiskerItem.q3)) && (ObjectUtilities.equal((object) this.minRegularValue, (object) boxAndWhiskerItem.minRegularValue) && ObjectUtilities.equal((object) this.maxRegularValue, (object) boxAndWhiskerItem.maxRegularValue) && (ObjectUtilities.equal((object) this.minOutlier, (object) boxAndWhiskerItem.minOutlier) && ObjectUtilities.equal((object) this.maxOutlier, (object) boxAndWhiskerItem.maxOutlier))) && ObjectUtilities.equal((object) this.outliers, (object) boxAndWhiskerItem.outliers);
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
