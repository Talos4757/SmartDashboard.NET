// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryAnchor
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

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class CategoryAnchor : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static CategoryAnchor __\u003C\u003ESTART = new CategoryAnchor("CategoryAnchor.START");
    internal static CategoryAnchor __\u003C\u003EMIDDLE = new CategoryAnchor("CategoryAnchor.MIDDLE");
    internal static CategoryAnchor __\u003C\u003EEND = new CategoryAnchor("CategoryAnchor.END");
    private const long serialVersionUID = -2604142742210173810L;
    private string name;

    [Modifiers]
    public static CategoryAnchor START
    {
      [HideFromJava] get
      {
        return CategoryAnchor.__\u003C\u003ESTART;
      }
    }

    [Modifiers]
    public static CategoryAnchor MIDDLE
    {
      [HideFromJava] get
      {
        return CategoryAnchor.__\u003C\u003EMIDDLE;
      }
    }

    [Modifiers]
    public static CategoryAnchor END
    {
      [HideFromJava] get
      {
        return CategoryAnchor.__\u003C\u003EEND;
      }
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 207, (byte) 207})]
    static CategoryAnchor()
    {
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private CategoryAnchor([In] string obj0)
    {
      base.\u002Ector();
      CategoryAnchor categoryAnchor = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryAnchor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryAnchor obj0)
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

    [LineNumberTable(new byte[] {(byte) 48, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is CategoryAnchor && String.instancehelper_equals(this.name, (object) ((CategoryAnchor) obj).toString());
    }

    public virtual string toString()
    {
      return this.name;
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 70, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) CategoryAnchor.__\u003C\u003ESTART))
        return (object) CategoryAnchor.__\u003C\u003ESTART;
      if (this.equals((object) CategoryAnchor.__\u003C\u003EMIDDLE))
        return (object) CategoryAnchor.__\u003C\u003EMIDDLE;
      if (this.equals((object) CategoryAnchor.__\u003C\u003EEND))
        return (object) CategoryAnchor.__\u003C\u003EEND;
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
      return this.readResolve();
    }
  }
}
