// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.NumberArray
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
  public class NumberArray : ArrayData
  {
    internal static ArrayEntryType __\u003C\u003ETYPE = new ArrayEntryType((byte) 17, DefaultEntryTypes.__\u003C\u003EDOUBLE, (Class) ClassLiteral<NumberArray>.Value);
    private const byte NUMBER_ARRAY_RAW_ID = (byte) 17;

    [Modifiers]
    public static ArrayEntryType TYPE
    {
      [HideFromJava] get
      {
        return NumberArray.__\u003C\u003ETYPE;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberArray()
      : base(NumberArray.__\u003C\u003ETYPE)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double get(int i)
    {
      return ((Double) this.getAsObject(i)).doubleValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double d)
    {
      this._add((object) new Double(d));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void set(int i, double d)
    {
      this._set(i, (object) new Double(d));
    }
  }
}
