// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.StringArray
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
  public class StringArray : ArrayData
  {
    internal static ArrayEntryType __\u003C\u003ETYPE = new ArrayEntryType((byte) 18, DefaultEntryTypes.__\u003C\u003ESTRING, (Class) ClassLiteral<StringArray>.Value);
    private const byte STRING_ARRAY_RAW_ID = (byte) 18;

    [Modifiers]
    public static ArrayEntryType TYPE
    {
      [HideFromJava] get
      {
        return StringArray.__\u003C\u003ETYPE;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringArray()
      : base(StringArray.__\u003C\u003ETYPE)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string get(int i)
    {
      return (string) this.getAsObject(i);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void set(int i, string str)
    {
      this._set(i, (object) str);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(string str)
    {
      this._add((object) str);
    }
  }
}
