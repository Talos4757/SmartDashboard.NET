// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PlotOrientation
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

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class PlotOrientation : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static PlotOrientation __\u003C\u003EHORIZONTAL = new PlotOrientation("PlotOrientation.HORIZONTAL");
    internal static PlotOrientation __\u003C\u003EVERTICAL = new PlotOrientation("PlotOrientation.VERTICAL");
    private const long serialVersionUID = -2508771828190337782L;
    private string name;

    [Modifiers]
    public static PlotOrientation HORIZONTAL
    {
      [HideFromJava] get
      {
        return PlotOrientation.__\u003C\u003EHORIZONTAL;
      }
    }

    [Modifiers]
    public static PlotOrientation VERTICAL
    {
      [HideFromJava] get
      {
        return PlotOrientation.__\u003C\u003EVERTICAL;
      }
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 207})]
    static PlotOrientation()
    {
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PlotOrientation([In] string obj0)
    {
      base.\u002Ector();
      PlotOrientation plotOrientation = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PlotOrientation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PlotOrientation obj0)
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

    [LineNumberTable(new byte[] {(byte) 44, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is PlotOrientation && String.instancehelper_equals(this.name, (object) ((PlotOrientation) obj).toString());
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 113)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 74, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      PlotOrientation plotOrientation = (PlotOrientation) null;
      if (this.equals((object) PlotOrientation.__\u003C\u003EHORIZONTAL))
        plotOrientation = PlotOrientation.__\u003C\u003EHORIZONTAL;
      else if (this.equals((object) PlotOrientation.__\u003C\u003EVERTICAL))
        plotOrientation = PlotOrientation.__\u003C\u003EVERTICAL;
      return (object) plotOrientation;
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
      return this.readResolve();
    }
  }
}
