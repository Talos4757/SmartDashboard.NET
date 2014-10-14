// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryLabelWidthType
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
  public sealed class CategoryLabelWidthType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static CategoryLabelWidthType __\u003C\u003ECATEGORY = new CategoryLabelWidthType("CategoryLabelWidthType.CATEGORY");
    internal static CategoryLabelWidthType __\u003C\u003ERANGE = new CategoryLabelWidthType("CategoryLabelWidthType.RANGE");
    private const long serialVersionUID = -6976024792582949656L;
    private string name;

    [Modifiers]
    public static CategoryLabelWidthType CATEGORY
    {
      [HideFromJava] get
      {
        return CategoryLabelWidthType.__\u003C\u003ECATEGORY;
      }
    }

    [Modifiers]
    public static CategoryLabelWidthType RANGE
    {
      [HideFromJava] get
      {
        return CategoryLabelWidthType.__\u003C\u003ERANGE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 239, (byte) 70})]
    static CategoryLabelWidthType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private CategoryLabelWidthType([In] string obj0)
    {
      base.\u002Ector();
      CategoryLabelWidthType categoryLabelWidthType = this;
      if (obj0 == null)
      {
        string str = "Null 'name' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryLabelWidthType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryLabelWidthType obj0)
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

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is CategoryLabelWidthType && String.instancehelper_equals(this.name, (object) ((CategoryLabelWidthType) obj).toString());
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 70, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) CategoryLabelWidthType.__\u003C\u003ECATEGORY))
        return (object) CategoryLabelWidthType.__\u003C\u003ECATEGORY;
      if (this.equals((object) CategoryLabelWidthType.__\u003C\u003ERANGE))
        return (object) CategoryLabelWidthType.__\u003C\u003ERANGE;
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
