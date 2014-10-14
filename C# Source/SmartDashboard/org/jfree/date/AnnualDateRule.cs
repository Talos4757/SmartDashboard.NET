// Decompiled with JetBrains decompiler
// Type: org.jfree.date.AnnualDateRule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.date
{
  [Implements(new string[] {"java.lang.Cloneable"})]
  public abstract class AnnualDateRule : Object, Cloneable.__Interface
  {
    [LineNumberTable(new byte[] {(byte) 10, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AnnualDateRule()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AnnualDateRule obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    public abstract SerialDate getDate(int i);

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 83)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
