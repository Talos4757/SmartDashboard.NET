// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.BooleanArray
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public class BooleanArray : ArrayData
  {
    internal static ArrayEntryType __\u003C\u003ETYPE = new ArrayEntryType((byte) 16, DefaultEntryTypes.__\u003C\u003EBOOLEAN, (Class) ClassLiteral<BooleanArray>.Value);
    private const byte BOOLEAN_ARRAY_RAW_ID = (byte) 16;

    [Modifiers]
    public static ArrayEntryType TYPE
    {
      [HideFromJava] get
      {
        return BooleanArray.__\u003C\u003ETYPE;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BooleanArray()
      : base(BooleanArray.__\u003C\u003ETYPE)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool get(int i)
    {
      return (((Boolean) this.getAsObject(i)).booleanValue() ? 1 : 0) != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void set(int i, bool b)
    {
      int num = b ? 1 : 0;
      this._set(i, num == 0 ? (object) Boolean.FALSE : (object) Boolean.TRUE);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(bool b)
    {
      this._add(!b ? (object) Boolean.FALSE : (object) Boolean.TRUE);
    }
  }
}
