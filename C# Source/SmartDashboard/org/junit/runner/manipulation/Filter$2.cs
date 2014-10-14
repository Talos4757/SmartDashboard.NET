// Decompiled with JetBrains decompiler
// Type: org.junit.runner.manipulation.Filter$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.runner;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner.manipulation
{
  [InnerClass]
  [EnclosingMethod("org.junit.runner.manipulation.Filter", "matchMethodDescription", "(Lorg.junit.runner.Description;)Lorg.junit.runner.manipulation.Filter;")]
  [SourceFile("Filter.java")]
  [Modifiers]
  internal sealed class Filter\u00242 : Filter
  {
    [Modifiers]
    internal Description val\u0024desiredDescription = obj0;

    [HideFromJava]
    static Filter\u00242()
    {
      Filter.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 50)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Filter\u00242([In] Description obj0)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 104, (byte) 175, (byte) 127, (byte) 1, (byte) 105, (byte) 100})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool shouldRun([In] Description obj0)
    {
      if (obj0.isTest())
      {
        return (this.val\u0024desiredDescription.equals((object) obj0) ? 1 : 0) != 0;
      }
      else
      {
        Iterator iterator = obj0.getChildren().iterator();
        while (iterator.hasNext())
        {
          if (this.shouldRun((Description) iterator.next()))
            return true;
        }
        return false;
      }
    }

    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string describe()
    {
      string str = "Method %s";
      object[] objArray = new object[1];
      int index = 0;
      string displayName = this.val\u0024desiredDescription.getDisplayName();
      objArray[index] = (object) displayName;
      return String.format(str, objArray);
    }
  }
}
