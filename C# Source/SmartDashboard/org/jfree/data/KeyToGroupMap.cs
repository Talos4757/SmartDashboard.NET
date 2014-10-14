// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyToGroupMap
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class KeyToGroupMap : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -2228169345475318082L;
    private IComparable defaultGroup;
    private List groups;
    private Map keyToGroupMap;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 31, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyToGroupMap()
      : this((IComparable) "Default Group")
    {
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyToGroupMap(IComparable defaultGroup)
    {
      base.\u002Ector();
      KeyToGroupMap keyToGroupMap = this;
      if (defaultGroup == null)
      {
        string str = "Null 'defaultGroup' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.defaultGroup = defaultGroup;
        this.groups = (List) new ArrayList();
        this.keyToGroupMap = (Map) new HashMap();
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected KeyToGroupMap([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] KeyToGroupMap obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] KeyToGroupMap obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 104)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getGroupCount()
    {
      return this.groups.size() + 1;
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 99, (byte) 144, (byte) 103, (byte) 114, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getGroup(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        IComparable comparable1 = this.defaultGroup;
        IComparable comparable2 = (IComparable) this.keyToGroupMap.get((object) key);
        if (comparable2 != null)
          comparable1 = comparable2;
        return comparable1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 109, (byte) 100, (byte) 110, (byte) 196, (byte) 132})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getGroupIndex(IComparable group)
    {
      int num = this.groups.indexOf((object) group);
      if (num < 0)
      {
        if (Object.instancehelper_equals((object) this.defaultGroup, (object) group))
          num = 0;
      }
      else
        ++num;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is KeyToGroupMap))
        return false;
      KeyToGroupMap keyToGroupMap = (KeyToGroupMap) obj;
      return ObjectUtilities.equal((object) this.defaultGroup, (object) keyToGroupMap.defaultGroup) && Object.instancehelper_equals((object) this.keyToGroupMap, (object) keyToGroupMap.keyToGroupMap);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 99, (byte) 144, (byte) 98, (byte) 113, (byte) 104, (byte) 108, (byte) 105, (byte) 132, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getKeyCount(IComparable group)
    {
      if (group == null)
      {
        string str = "Null 'group' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = 0;
        Iterator iterator = this.keyToGroupMap.values().iterator();
        while (iterator.hasNext())
        {
          IComparable comparable = (IComparable) iterator.next();
          if (Object.instancehelper_equals((object) group, (object) comparable))
            ++num;
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 99, (byte) 130, (byte) 103, (byte) 130, (byte) 119, (byte) 141, (byte) 223, (byte) 8, (byte) 18, (byte) 98, (byte) 242, (byte) 70, (byte) 2, (byte) 97, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static object clone([In] object obj0)
    {
      if (obj0 == null)
        return (object) null;
      Class @class = Object.instancehelper_getClass(obj0);
      object obj = (object) null;
      Exception exception1;
      try
      {
        Method method = @class.getMethod("clone", (Class[]) null, KeyToGroupMap.__\u003CGetCallerID\u003E());
        if (Modifier.isPublic(method.getModifiers()))
        {
          try
          {
            obj = method.invoke(obj0, (object[]) null, KeyToGroupMap.__\u003CGetCallerID\u003E());
            goto label_15;
          }
          catch (Exception ex)
          {
            int num = 0;
            M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
            if (m0 == null)
              throw;
            else
              exception1 = (Exception) m0;
          }
        }
        else
          goto label_15;
      }
      catch (NoSuchMethodException ex)
      {
        goto label_10;
      }
      Exception exception2 = exception1;
      try
      {
        Throwable.instancehelper_printStackTrace((Exception) exception2);
        goto label_15;
      }
      catch (NoSuchMethodException ex)
      {
      }
      // ISSUE: variable of the null type
      __Null local = null;
      goto label_14;
label_10:
      local = null;
label_14:
      obj = obj0;
label_15:
      return obj;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 98, (byte) 134, (byte) 118, (byte) 103, (byte) 104, (byte) 148, (byte) 215, (byte) 2, (byte) 97, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Collection clone([In] Collection obj0)
    {
      List list1 = (List) null;
      if (obj0 != null)
      {
        try
        {
          List list2 = (List) Object.instancehelper_getClass((object) obj0).newInstance(KeyToGroupMap.__\u003CGetCallerID\u003E());
          Iterator iterator = obj0.iterator();
          while (iterator.hasNext())
            list2.add(KeyToGroupMap.clone(iterator.next()));
          list1 = list2;
          goto label_8;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
        string str = "Exception.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new CloneNotSupportedException(str);
      }
label_8:
      return (Collection) list1;
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 102, (byte) 109, (byte) 108, (byte) 104, (byte) 108, (byte) 105, (byte) 136, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getGroups()
    {
      ArrayList arrayList = new ArrayList();
      ((List) arrayList).add((object) this.defaultGroup);
      Iterator iterator = this.groups.iterator();
      while (iterator.hasNext())
      {
        IComparable comparable = (IComparable) iterator.next();
        if (!((List) arrayList).contains((object) comparable))
          ((List) arrayList).add((object) comparable);
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 99, (byte) 144, (byte) 104, (byte) 110, (byte) 105, (byte) 104, (byte) 100, (byte) 205, (byte) 99, (byte) 175, (byte) 110, (byte) 110, (byte) 173, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapKeyToGroup(IComparable key, IComparable group)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        IComparable group1 = this.getGroup(key);
        if (!Object.instancehelper_equals((object) group1, (object) this.defaultGroup) && !Object.instancehelper_equals((object) group1, (object) group) && this.getKeyCount(group1) == 1)
          this.groups.remove((object) group1);
        if (group == null)
        {
          this.keyToGroupMap.remove((object) key);
        }
        else
        {
          if (!this.groups.contains((object) group) && !Object.instancehelper_equals((object) this.defaultGroup, (object) group))
            this.groups.add((object) group);
          this.keyToGroupMap.put((object) key, (object) group);
        }
      }
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 108, (byte) 150, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      KeyToGroupMap keyToGroupMap = (KeyToGroupMap) base.clone();
      keyToGroupMap.defaultGroup = (IComparable) KeyToGroupMap.clone((object) this.defaultGroup);
      keyToGroupMap.groups = (List) KeyToGroupMap.clone((Collection) this.groups);
      keyToGroupMap.keyToGroupMap = (Map) KeyToGroupMap.clone((object) this.keyToGroupMap);
      return (object) keyToGroupMap;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (KeyToGroupMap.__\u003CcallerID\u003E == null)
        KeyToGroupMap.__\u003CcallerID\u003E = (CallerID) new KeyToGroupMap.__\u003CCallerID\u003E();
      return KeyToGroupMap.__\u003CcallerID\u003E;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
