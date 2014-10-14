// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.types.NamedDataType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.types
{
  public class NamedDataType : DataType
  {
    [Modifiers]
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/types/NamedDataType;>;")]
    private static Map map;

    [LineNumberTable((ushort) 15)]
    static NamedDataType()
    {
      DataType.__\u003Cclinit\u003E();
      NamedDataType.map = (Map) new HashMap();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 106, (byte) 99, (byte) 144, (byte) 109, (byte) 159, (byte) 16, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal NamedDataType(string name, params DataType[] parents)
      : base(name, parents)
    {
      NamedDataType namedDataType = this;
      if (name == null)
      {
        string str = "Name can not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (NamedDataType.map.containsKey((object) name))
      {
        string str = new StringBuilder().append("Given name \"").append(name).append("\" has already been claimed").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        NamedDataType.map.put((object) name, (object) this);
    }

    [Signature("(Ljava/lang/String;Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;[Ledu/wpi/first/smartdashboard/types/DataType;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 107, (byte) 99, (byte) 144, (byte) 109, (byte) 159, (byte) 16, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal NamedDataType(string name, Class defaultWidget, params DataType[] parents)
      : base(name, defaultWidget, parents)
    {
      NamedDataType namedDataType = this;
      if (name == null)
      {
        string str = "Name can not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (NamedDataType.map.containsKey((object) name))
      {
        string str = new StringBuilder().append("Given name \"").append(name).append("\" has already been claimed").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        NamedDataType.map.put((object) name, (object) this);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static NamedDataType get(string name)
    {
      return (NamedDataType) NamedDataType.map.get((object) name);
    }

    public override sealed bool isNamed()
    {
      return true;
    }
  }
}
