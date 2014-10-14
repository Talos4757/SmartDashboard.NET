// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.StringCache
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.util
{
  [SourceFile(null)]
  public abstract class StringCache : Object
  {
    [Modifiers]
    private Hashtable cache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringCache()
    {
      base.\u002Ector();
      StringCache stringCache = this;
      this.cache = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string get(string str)
    {
      string str1 = (string) this.cache.get((object) str);
      if (str1 == null)
        this.cache.put((object) str, (object) (str1 = this.calc(str)));
      return str1;
    }

    public abstract string calc(string str);
  }
}
