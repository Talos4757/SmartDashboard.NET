// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.DowngradeActionMap
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.swing;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.action
{
  public class DowngradeActionMap : Object
  {
    [Modifiers]
    private HashMap actionMap;
    [Modifiers]
    private ArrayList actionList;
    private DowngradeActionMap parent;

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DowngradeActionMap()
    {
      base.\u002Ector();
      DowngradeActionMap downgradeActionMap = this;
      this.actionMap = new HashMap();
      this.actionList = new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(object key)
    {
      this.actionMap.remove(key);
      this.actionList.remove(key);
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 114, (byte) 99, (byte) 130, (byte) 104, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Action get(object key)
    {
      Action action = (Action) this.actionMap.get(key);
      if (action != null)
        return action;
      if (this.parent == null)
        return (Action) null;
      return this.parent.get(key);
    }

    [LineNumberTable((ushort) 164)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] keys()
    {
      return this.actionList.toArray();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 104, (byte) 137, (byte) 108, (byte) 103, (byte) 107, (byte) 107, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] allKeys()
    {
      if (this.parent == null)
      {
        return this.keys();
      }
      else
      {
        object[] objArray1 = this.parent.allKeys();
        object[] objArray2 = this.keys();
        object[] objArray3 = new object[objArray1.Length + objArray2.Length];
        ByteCodeHelper.arraycopy((object) objArray2, 0, (object) objArray3, 0, objArray2.Length);
        ByteCodeHelper.arraycopy((object) objArray3, 0, (object) objArray3, objArray2.Length, objArray3.Length);
        return objArray3;
      }
    }

    public virtual void setParent(DowngradeActionMap map)
    {
      this.parent = map;
    }

    public virtual DowngradeActionMap getParent()
    {
      return this.parent;
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 99, (byte) 169, (byte) 110, (byte) 135, (byte) 110, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void put(object key, Action action)
    {
      if (action == null)
      {
        this.remove(key);
      }
      else
      {
        if (this.actionMap.containsKey(key))
          this.remove(key);
        this.actionMap.put(key, (object) action);
        this.actionList.add(key);
      }
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.actionMap.clear();
      this.actionList.clear();
    }

    [LineNumberTable((ushort) 173)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int size()
    {
      return this.actionMap.size();
    }
  }
}
