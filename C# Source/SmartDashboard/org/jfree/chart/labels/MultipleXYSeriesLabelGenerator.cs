// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.MultipleXYSeriesLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart;
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
  [Implements(new string[] {"org.jfree.chart.labels.XYSeriesLabelGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class MultipleXYSeriesLabelGenerator : Object, XYSeriesLabelGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 138976236941898560L;
    public const string DEFAULT_LABEL_FORMAT = "{0}";
    private string formatPattern;
    private string additionalFormatPattern;
    private Map seriesLabelLists;

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultipleXYSeriesLabelGenerator(string format)
    {
      base.\u002Ector();
      MultipleXYSeriesLabelGenerator seriesLabelGenerator = this;
      if (format == null)
      {
        string str = "Null 'format' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.formatPattern = format;
        this.additionalFormatPattern = "\n{0}";
        this.seriesLabelLists = (Map) new HashMap();
      }
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultipleXYSeriesLabelGenerator()
      : this("{0}")
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MultipleXYSeriesLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] MultipleXYSeriesLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MultipleXYSeriesLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[] createItemArray(XYDataset dataset, int series)
    {
      return new object[1]
      {
        (object) Object.instancehelper_toString((object) dataset.getSeriesKey(series))
      };
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 103, (byte) 114, (byte) 104, (byte) 102, (byte) 147, (byte) 125})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeriesLabel(int series, string label)
    {
      Integer integer = new Integer(series);
      object obj1 = (object) (List) this.seriesLabelLists.get((object) integer);
      if ((List) obj1 == null)
      {
        obj1 = (object) new ArrayList();
        this.seriesLabelLists.put((object) integer, (object) (ArrayList) obj1);
      }
      object obj2 = obj1;
      object obj3 = (object) label;
      List list1;
      if (obj2 != null)
      {
        List list2 = obj2 as List;
        if (list2 == null)
          throw new IncompatibleClassChangeError();
        list1 = list2;
      }
      else
        list1 = (List) null;
      object obj4 = obj3;
      list1.add(obj4);
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSeriesLabels(int series)
    {
      this.seriesLabelLists.put((object) new Integer(series), (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 99, (byte) 144, (byte) 102, (byte) 154, (byte) 103, (byte) 114, (byte) 99, (byte) 103, (byte) 109, (byte) 107, (byte) 142, (byte) 233, (byte) 60, (byte) 232, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(XYDataset dataset, int series)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        StringBuffer stringBuffer = new StringBuffer();
        stringBuffer.append(MessageFormat.format(this.formatPattern, this.createItemArray(dataset, series)));
        List list = (List) this.seriesLabelLists.get((object) new Integer(series));
        if (list != null)
        {
          object[] objArray = new object[1];
          for (int index = 0; index < list.size(); ++index)
          {
            objArray[0] = list.get(index);
            string str = MessageFormat.format(this.additionalFormatPattern, objArray);
            stringBuffer.append(str);
          }
        }
        return stringBuffer.toString();
      }
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 140, (byte) 107, (byte) 108, (byte) 103, (byte) 104, (byte) 103, (byte) 110, (byte) 100, (byte) 105, (byte) 105, (byte) 137, (byte) 111, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      MultipleXYSeriesLabelGenerator seriesLabelGenerator = (MultipleXYSeriesLabelGenerator) base.clone();
      seriesLabelGenerator.seriesLabelLists = (Map) new HashMap();
      Iterator iterator = this.seriesLabelLists.keySet().iterator();
      while (iterator.hasNext())
      {
        object obj1 = iterator.next();
        object obj2 = this.seriesLabelLists.get(obj1);
        object obj3 = obj2;
        if (obj2 is PublicCloneable)
          obj3 = ((PublicCloneable) obj2).clone();
        seriesLabelGenerator.seriesLabelLists.put(obj1, obj3);
      }
      return (object) seriesLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MultipleXYSeriesLabelGenerator))
        return false;
      MultipleXYSeriesLabelGenerator seriesLabelGenerator = (MultipleXYSeriesLabelGenerator) obj;
      return String.instancehelper_equals(this.formatPattern, (object) seriesLabelGenerator.formatPattern) && String.instancehelper_equals(this.additionalFormatPattern, (object) seriesLabelGenerator.additionalFormatPattern) && Object.instancehelper_equals((object) this.seriesLabelLists, (object) seriesLabelGenerator.seriesLabelLists);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 99, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode((int) sbyte.MaxValue, this.formatPattern), this.additionalFormatPattern), (object) this.seriesLabelLists);
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
