// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.ArgParser
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard
{
  public class ArgParser : Object
  {
    [Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
    private Map argValues;
    [Signature("Ljava/util/Set<Ljava/lang/String;>;")]
    private Set flags;
    [Modifiers]
    private bool ignoreLeadingDash;
    [Modifiers]
    private bool ignoreCase;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 138, (byte) 100, (byte) 232, (byte) 53, (byte) 107, (byte) 235, (byte) 75, (byte) 103, (byte) 135, (byte) 99, (byte) 104, (byte) 46, (byte) 198, (byte) 106, (byte) 139, (byte) 121, (byte) 107, (byte) 103, (byte) 115, (byte) 134, (byte) 115, (byte) 226, (byte) 57, (byte) 235, (byte) 74, (byte) 238, (byte) 51, (byte) 233, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArgParser(string[] args, bool ignoreLeadingDash, bool ignoreCase, string[] valueArgs)
    {
      int num1 = ignoreLeadingDash ? 1 : 0;
      int num2 = ignoreCase ? 1 : 0;
      base.\u002Ector();
      ArgParser argParser = this;
      this.argValues = (Map) new HashMap();
      this.flags = (Set) new HashSet();
      this.ignoreLeadingDash = num1 != 0;
      this.ignoreCase = num2 != 0;
      if (num1 != 0)
      {
        for (int index = 0; index < valueArgs.Length; ++index)
          valueArgs[index] = this.getProcessedName(valueArgs[index]);
      }
label_5:
      for (int index1 = 0; index1 < args.Length; ++index1)
      {
        string processedName = this.getProcessedName(args[index1]);
        string[] strArray = valueArgs;
        int length = strArray.Length;
        for (int index2 = 0; index2 < length; ++index2)
        {
          if (String.instancehelper_equals(strArray[index2], (object) processedName))
          {
            if (index1 < args.Length - 1)
            {
              this.argValues.put((object) processedName, (object) args[index1 + 1]);
              ++index1;
              goto label_5;
            }
            else
            {
              this.argValues.put((object) processedName, (object) "");
              goto label_5;
            }
          }
        }
        this.flags.add((object) processedName);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 153, (byte) 117, (byte) 105, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string getProcessedName([In] string obj0)
    {
      if (this.ignoreLeadingDash && String.instancehelper_startsWith(obj0, "-"))
        obj0 = String.instancehelper_substring(obj0, 1);
      if (this.ignoreCase)
        obj0 = String.instancehelper_toLowerCase(obj0);
      return obj0;
    }

    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasFlag(string name)
    {
      return (this.flags.contains((object) this.getProcessedName(name)) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 48)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasValue(string name)
    {
      return this.argValues.get((object) this.getProcessedName(name)) != null;
    }

    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getValue(string name)
    {
      return (string) this.argValues.get((object) this.getProcessedName(name));
    }
  }
}
