// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.ActionConcentrator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using javax.swing;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.action
{
  public class ActionConcentrator : Object
  {
    [Modifiers]
    private ArrayList actions;

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionConcentrator()
    {
      base.\u002Ector();
      ActionConcentrator actionConcentrator = this;
      this.actions = new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 99, (byte) 139, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAction(Action a)
    {
      if (a == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
        this.actions.add((object) a);
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 99, (byte) 139, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAction(Action a)
    {
      if (a == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
        this.actions.remove((object) a);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 66, (byte) 112, (byte) 114, (byte) 7, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEnabled(bool b)
    {
      int num = b ? 1 : 0;
      for (int index = 0; index < this.actions.size(); ++index)
        ((Action) this.actions.get(index)).setEnabled(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 112, (byte) 114, (byte) 104, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isEnabled()
    {
      for (int index = 0; index < this.actions.size(); ++index)
      {
        if (((Action) this.actions.get(index)).isEnabled())
          return true;
      }
      return false;
    }
  }
}
