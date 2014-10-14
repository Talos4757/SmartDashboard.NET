// Decompiled with JetBrains decompiler
// Type: org.jfree.util.AttributedStringUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.text;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class AttributedStringUtilities : Object
  {
    [LineNumberTable(new byte[] {(byte) 10, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private AttributedStringUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 99, (byte) 107, (byte) 104, (byte) 104, (byte) 102, (byte) 162, (byte) 104, (byte) 104, (byte) 107, (byte) 162, (byte) 106, (byte) 100, (byte) 130, (byte) 103, (byte) 231, (byte) 59, (byte) 232, (byte) 71, (byte) 100, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(AttributedString s1, AttributedString s2)
    {
      if (s1 == null)
      {
        return s2 == null;
      }
      else
      {
        if (s2 == null)
          return false;
        AttributedCharacterIterator iterator1 = s1.getIterator();
        AttributedCharacterIterator iterator2 = s2.getIterator();
        int num1 = (int) ((CharacterIterator) iterator1).first();
        int num2 = (int) ((CharacterIterator) iterator2).first();
        int num3 = 0;
        while (num1 != (int) ushort.MaxValue)
        {
          int runLimit1 = iterator1.getRunLimit();
          int runLimit2 = iterator2.getRunLimit();
          if (runLimit1 != runLimit2 || !Object.instancehelper_equals((object) iterator1.getAttributes(), (object) iterator2.getAttributes()))
            return false;
          for (int index = num3; index < runLimit1; ++index)
          {
            if (num1 != num2)
              return false;
            num1 = (int) ((CharacterIterator) iterator1).next();
            num2 = (int) ((CharacterIterator) iterator2).next();
          }
          num3 = runLimit1;
        }
        return num2 == (int) ushort.MaxValue;
      }
    }
  }
}
