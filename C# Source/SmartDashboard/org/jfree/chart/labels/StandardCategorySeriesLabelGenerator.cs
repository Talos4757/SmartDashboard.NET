// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardCategorySeriesLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.chart;
using org.jfree.data.category;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.CategorySeriesLabelGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardCategorySeriesLabelGenerator : Object, CategorySeriesLabelGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 4630760091523940820L;
    public const string DEFAULT_LABEL_FORMAT = "{0}";
    private string formatPattern;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategorySeriesLabelGenerator(string format)
    {
      base.\u002Ector();
      StandardCategorySeriesLabelGenerator seriesLabelGenerator = this;
      if (format == null)
      {
        string str = "Null 'format' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.formatPattern = format;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategorySeriesLabelGenerator()
      : this("{0}")
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardCategorySeriesLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardCategorySeriesLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardCategorySeriesLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[] createItemArray(CategoryDataset dataset, int series)
    {
      return new object[1]
      {
        (object) Object.instancehelper_toString((object) dataset.getRowKey(series))
      };
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 99, (byte) 144, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(CategoryDataset dataset, int series)
    {
      if (dataset != null)
        return MessageFormat.format(this.formatPattern, this.createItemArray(dataset, series));
      string str = "Null 'dataset' argument.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is StandardCategorySeriesLabelGenerator && String.instancehelper_equals(this.formatPattern, (object) ((StandardCategorySeriesLabelGenerator) obj).formatPattern);
    }

    [LineNumberTable(new byte[] {(byte) 110, (byte) 99, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode((int) sbyte.MaxValue, this.formatPattern);
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
