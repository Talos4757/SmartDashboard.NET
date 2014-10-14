// Decompiled with JetBrains decompiler
// Type: org.jfree.util.FastStack
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
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
  [Implements(new string[] {"java.io.Serializable", "java.lang.Cloneable"})]
  [Serializable]
  public sealed class FastStack : Object, Serializable.__Interface, Cloneable.__Interface, ISerializable
  {
    private object[] contents;
    private int size;
    private int initialSize;

    [LineNumberTable(new byte[] {(byte) 1, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastStack()
    {
      base.\u002Ector();
      FastStack fastStack = this;
      this.initialSize = 10;
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastStack(int size)
    {
      base.\u002Ector();
      FastStack fastStack = this;
      this.initialSize = Math.max(1, size);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FastStack([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] FastStack obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] FastStack obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    public virtual bool isEmpty()
    {
      return this.size == 0;
    }

    public virtual int size()
    {
      return this.size;
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 104, (byte) 113, (byte) 105, (byte) 103, (byte) 161, (byte) 103, (byte) 110, (byte) 143, (byte) 147, (byte) 116, (byte) 135, (byte) 105})]
    public virtual void push(object o)
    {
      if (this.contents == null)
      {
        this.contents = new object[this.initialSize];
        this.contents[0] = o;
        this.size = 1;
      }
      else
      {
        int index = this.size;
        ++this.size;
        if (this.contents.Length == this.size)
        {
          object[] objArray = new object[this.size + this.initialSize];
          ByteCodeHelper.arraycopy((object) this.contents, 0, (object) objArray, 0, this.size);
          this.contents = objArray;
        }
        this.contents[index] = o;
      }
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 104, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object peek()
    {
      if (this.size != 0)
        return this.contents[this.size - 1];
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new EmptyStackException();
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 104, (byte) 139, (byte) 110, (byte) 110, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object pop()
    {
      if (this.size == 0)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new EmptyStackException();
      }
      else
      {
        --this.size;
        object obj = this.contents[this.size];
        this.contents[this.size] = (object) null;
        return obj;
      }
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 108, (byte) 104, (byte) 155, (byte) 144, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      FastStack fastStack1;
      try
      {
        FastStack fastStack2 = (FastStack) base.clone();
        if (this.contents != null)
          fastStack2.contents = (object[]) this.contents.Clone();
        fastStack1 = fastStack2;
      }
      catch (CloneNotSupportedException ex)
      {
        goto label_5;
      }
      return (object) fastStack1;
label_5:
      string str = "Clone not supported? Why?";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalStateException(str);
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 103, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.size = 0;
      if (this.contents == null)
        return;
      Arrays.fill(this.contents, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 105, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object get(int index)
    {
      if (index < this.size)
        return this.contents[index];
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IndexOutOfBoundsException();
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
