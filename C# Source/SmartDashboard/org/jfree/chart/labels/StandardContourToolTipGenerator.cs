// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardContourToolTipGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.data.contour;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.ContourToolTipGenerator", "java.io.Serializable"})]
  [Obsolete]
  [Serializable]
  public class StandardContourToolTipGenerator : Object, ContourToolTipGenerator, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -1881659351247502711L;
    private DecimalFormat valueForm;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 232, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardContourToolTipGenerator()
    {
      base.\u002Ector();
      StandardContourToolTipGenerator toolTipGenerator = this;
      this.valueForm = new DecimalFormat("##.###");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardContourToolTipGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardContourToolTipGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 106, (byte) 106, (byte) 106, (byte) 130, (byte) 105, (byte) 139, (byte) 103, (byte) 187, (byte) 105, (byte) 130, (byte) 142, (byte) 104, (byte) 255, (byte) 53, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTip(ContourDataset data, int item)
    {
      double xvalue = data.getXValue(0, item);
      double yvalue = data.getYValue(0, item);
      double zvalue = data.getZValue(0, item);
      string str;
      if (data.isDateAxis(0))
      {
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("MM/dd/yyyy hh:mm:ss");
        StringBuffer stringBuffer = new StringBuffer();
        str = simpleDateFormat.format(new Date(ByteCodeHelper.d2l(xvalue)), stringBuffer, new FieldPosition(0)).toString();
      }
      else
        str = ((NumberFormat) this.valueForm).format(xvalue);
      if (!Double.isNaN(zvalue))
        return new StringBuffer().append("X: ").append(str).append(", Y: ").append(((NumberFormat) this.valueForm).format(yvalue)).append(", Z: ").append(((NumberFormat) this.valueForm).format(zvalue)).toString();
      else
        return new StringBuffer().append("X: ").append(str).append(", Y: ").append(((NumberFormat) this.valueForm).format(yvalue)).append(", Z: no data").toString();
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 100, (byte) 162, (byte) 104, (byte) 130, (byte) 135, (byte) 104, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardContourToolTipGenerator))
        return false;
      StandardContourToolTipGenerator toolTipGenerator = (StandardContourToolTipGenerator) obj;
      if (this.valueForm == null)
        return false;
      return (this.valueForm.equals((object) toolTipGenerator.valueForm) ? 1 : 0) != 0;
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
