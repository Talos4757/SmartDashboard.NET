// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.HistogramType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
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
  public class HistogramType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static HistogramType __\u003C\u003EFREQUENCY = new HistogramType("FREQUENCY");
    internal static HistogramType __\u003C\u003ERELATIVE_FREQUENCY = new HistogramType("RELATIVE_FREQUENCY");
    internal static HistogramType __\u003C\u003ESCALE_AREA_TO_1 = new HistogramType("SCALE_AREA_TO_1");
    private const long serialVersionUID = 2618927186251997727L;
    private string name;

    [Modifiers]
    public static HistogramType FREQUENCY
    {
      [HideFromJava] get
      {
        return HistogramType.__\u003C\u003EFREQUENCY;
      }
    }

    [Modifiers]
    public static HistogramType RELATIVE_FREQUENCY
    {
      [HideFromJava] get
      {
        return HistogramType.__\u003C\u003ERELATIVE_FREQUENCY;
      }
    }

    [Modifiers]
    public static HistogramType SCALE_AREA_TO_1
    {
      [HideFromJava] get
      {
        return HistogramType.__\u003C\u003ESCALE_AREA_TO_1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 207, (byte) 207})]
    static HistogramType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private HistogramType([In] string obj0)
    {
      base.\u002Ector();
      HistogramType histogramType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HistogramType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HistogramType obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 99, (byte) 162, (byte) 100, (byte) 162, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj != null && (obj == this || obj is HistogramType && String.instancehelper_equals(this.name, (object) ((HistogramType) obj).name));
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 124)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 85, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) HistogramType.__\u003C\u003EFREQUENCY))
        return (object) HistogramType.__\u003C\u003EFREQUENCY;
      if (this.equals((object) HistogramType.__\u003C\u003ERELATIVE_FREQUENCY))
        return (object) HistogramType.__\u003C\u003ERELATIVE_FREQUENCY;
      if (this.equals((object) HistogramType.__\u003C\u003ESCALE_AREA_TO_1))
        return (object) HistogramType.__\u003C\u003ESCALE_AREA_TO_1;
      else
        return (object) null;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    object IObjectReference.IObjectReference\u002EGetRealObject([In] StreamingContext obj0)
    {
      if (((object) this).GetType() != typeof (HistogramType))
        return (object) this;
      else
        return this.readResolve();
    }
  }
}
