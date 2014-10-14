// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardCrosshairLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.chart.plot;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.CrosshairLabelGenerator", "java.io.Serializable"})]
  [Serializable]
  public class StandardCrosshairLabelGenerator : Object, CrosshairLabelGenerator, Serializable.__Interface, ISerializable
  {
    private string labelTemplate;
    private NumberFormat numberFormat;

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCrosshairLabelGenerator(string labelTemplate, NumberFormat numberFormat)
    {
      base.\u002Ector();
      StandardCrosshairLabelGenerator crosshairLabelGenerator = this;
      if (labelTemplate == null)
      {
        string str = "Null 'labelTemplate' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (numberFormat == null)
      {
        string str = "Null 'numberFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelTemplate = labelTemplate;
        this.numberFormat = numberFormat;
      }
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCrosshairLabelGenerator()
      : this("{0}", NumberFormat.getNumberInstance())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardCrosshairLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardCrosshairLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual string getLabelTemplate()
    {
      return this.labelTemplate;
    }

    public virtual NumberFormat getNumberFormat()
    {
      return this.numberFormat;
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 155, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(Crosshair crosshair)
    {
      object[] objArray = new object[1];
      int index = 0;
      string str = this.numberFormat.format(crosshair.getValue());
      objArray[index] = (object) str;
      return MessageFormat.format(this.labelTemplate, objArray);
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardCrosshairLabelGenerator))
        return false;
      StandardCrosshairLabelGenerator crosshairLabelGenerator = (StandardCrosshairLabelGenerator) obj;
      return String.instancehelper_equals(this.labelTemplate, (object) crosshairLabelGenerator.labelTemplate) && this.numberFormat.equals((object) crosshairLabelGenerator.numberFormat);
    }

    [LineNumberTable((ushort) 155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.labelTemplate);
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
