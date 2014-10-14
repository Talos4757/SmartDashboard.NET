// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.CustomXYToolTipGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYToolTipGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class CustomXYToolTipGenerator : Object, XYToolTipGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 8636030004670141362L;
    private List toolTipSeries;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 232, (byte) 58, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomXYToolTipGenerator()
    {
      base.\u002Ector();
      CustomXYToolTipGenerator toolTipGenerator = this;
      this.toolTipSeries = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CustomXYToolTipGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CustomXYToolTipGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CustomXYToolTipGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 81)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getListCount()
    {
      return this.toolTipSeries.size();
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 130, (byte) 105, (byte) 114, (byte) 99, (byte) 105, (byte) 237, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getToolTipText(int series, int item)
    {
      string str = (string) null;
      if (series < this.getListCount())
      {
        List list = (List) this.toolTipSeries.get(series);
        if (list != null && item < list.size())
          str = (string) list.get(item);
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getToolTipCount(int list)
    {
      int num = 0;
      List list1 = (List) this.toolTipSeries.get(list);
      if (list1 != null)
        num = list1.size();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addToolTipSeries(List toolTips)
    {
      this.toolTipSeries.add((object) toolTips);
    }

    [LineNumberTable((ushort) 145)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTip(XYDataset data, int series, int item)
    {
      return this.getToolTipText(series, item);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 108, (byte) 140, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      CustomXYToolTipGenerator toolTipGenerator = (CustomXYToolTipGenerator) base.clone();
      if (this.toolTipSeries != null)
        toolTipGenerator.toolTipSeries = (List) new ArrayList((Collection) this.toolTipSeries);
      return (object) toolTipGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 100, (byte) 162, (byte) 107, (byte) 103, (byte) 98, (byte) 110, (byte) 111, (byte) 106, (byte) 106, (byte) 100, (byte) 181, (byte) 236, (byte) 57, (byte) 41, (byte) 233, (byte) 76, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CustomXYToolTipGenerator))
        return false;
      CustomXYToolTipGenerator toolTipGenerator = (CustomXYToolTipGenerator) obj;
      int num = 1;
      for (int index1 = 0; index1 < this.getListCount(); ++index1)
      {
        for (int index2 = 0; index2 < this.getToolTipCount(index1); ++index2)
        {
          string toolTipText1 = this.getToolTipText(index1, index2);
          string toolTipText2 = toolTipGenerator.getToolTipText(index1, index2);
          num = toolTipText1 == null ? (num == 0 || toolTipText2 != null ? 0 : 1) : (num == 0 || !String.instancehelper_equals(toolTipText1, (object) toolTipText2) ? 0 : 1);
        }
      }
      return num != 0;
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
