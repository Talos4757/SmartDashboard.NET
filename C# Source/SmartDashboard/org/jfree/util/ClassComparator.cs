// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ClassComparator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Implements(new string[] {"java.util.Comparator", "java.io.Serializable"})]
  [Serializable]
  public class ClassComparator : Object, Comparator, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -5225335361837391120L;

    [LineNumberTable(new byte[] {(byte) 14, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassComparator()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ClassComparator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ClassComparator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 103, (byte) 103, (byte) 105, (byte) 130, (byte) 105, (byte) 162, (byte) 105, (byte) 208})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare(object o1, object o2)
    {
      Class class1 = (Class) o1;
      Class class2 = (Class) o2;
      if (Object.instancehelper_equals((object) class1, o2))
        return 0;
      if (class1.isAssignableFrom(class2))
        return -1;
      if (class2.isAssignableFrom(class2))
        return 1;
      string str = "The classes share no relation";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isComparable(Class c1, Class c2)
    {
      return c1.isAssignableFrom(c2) || c2.isAssignableFrom(c1);
    }

    [HideFromJava]
    bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
    {
      return Object.instancehelper_equals((object) this, obj0);
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
