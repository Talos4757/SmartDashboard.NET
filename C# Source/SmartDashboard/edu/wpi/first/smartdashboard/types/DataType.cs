// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.types.DataType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements;
using edu.wpi.first.wpilibj.tables;
using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.types
{
  public class DataType : Object
  {
    internal static DataType __\u003C\u003EBASIC = new DataType("Basic", (Class) ClassLiteral<TextBox>.Value, new DataType[0]);
    [Modifiers]
    private DataType[] parents;
    [Modifiers]
    private string name;
    [Signature("Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;")]
    private Class defaultClass;
    internal static DataType __\u003C\u003ENUMBER;
    internal static DataType __\u003C\u003EBOOLEAN;
    internal static DataType __\u003C\u003ESTRING;
    internal static DataType __\u003C\u003ETABLE;

    [Modifiers]
    public static DataType BASIC
    {
      [HideFromJava] get
      {
        return DataType.__\u003C\u003EBASIC;
      }
    }

    [Modifiers]
    public static DataType NUMBER
    {
      [HideFromJava] get
      {
        return DataType.__\u003C\u003ENUMBER;
      }
    }

    [Modifiers]
    public static DataType BOOLEAN
    {
      [HideFromJava] get
      {
        return DataType.__\u003C\u003EBOOLEAN;
      }
    }

    [Modifiers]
    public static DataType STRING
    {
      [HideFromJava] get
      {
        return DataType.__\u003C\u003ESTRING;
      }
    }

    [Modifiers]
    public static DataType TABLE
    {
      [HideFromJava] get
      {
        return DataType.__\u003C\u003ETABLE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 122, (byte) 127, (byte) 3, (byte) 127, (byte) 3, (byte) 127, (byte) 3})]
    static DataType()
    {
      string str1 = "Number";
      // ISSUE: variable of the null type
      __Null local1 = ClassLiteral<TextBox>.Value;
      DataType[] dataTypeArray1 = new DataType[1];
      int index1 = 0;
      DataType dataType1 = DataType.__\u003C\u003EBASIC;
      dataTypeArray1[index1] = dataType1;
      DataType.__\u003C\u003ENUMBER = new DataType(str1, (Class) local1, dataTypeArray1);
      string str2 = "Boolean";
      // ISSUE: variable of the null type
      __Null local2 = ClassLiteral<TextBox>.Value;
      DataType[] dataTypeArray2 = new DataType[1];
      int index2 = 0;
      DataType dataType2 = DataType.__\u003C\u003EBASIC;
      dataTypeArray2[index2] = dataType2;
      DataType.__\u003C\u003EBOOLEAN = new DataType(str2, (Class) local2, dataTypeArray2);
      string str3 = "String";
      // ISSUE: variable of the null type
      __Null local3 = ClassLiteral<TextBox>.Value;
      DataType[] dataTypeArray3 = new DataType[1];
      int index3 = 0;
      DataType dataType3 = DataType.__\u003C\u003EBASIC;
      dataTypeArray3[index3] = dataType3;
      DataType.__\u003C\u003ESTRING = new DataType(str3, (Class) local3, dataTypeArray3);
      DataType.__\u003C\u003ETABLE = new DataType("Table", new DataType[0]);
    }

    [Signature("(Ljava/lang/String;Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;[Ledu/wpi/first/smartdashboard/types/DataType;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DataType(string _param1, Class _param2, params DataType[] _param3)
    {
      base.\u002Ector();
      DataType dataType = this;
      this.name = param0;
      this.parents = param2;
      this.defaultClass = param1;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DataType(string _param1, params DataType[] _param2)
    {
      base.\u002Ector();
      DataType dataType = this;
      this.name = param0;
      this.parents = param1;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual string getName()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 99, (byte) 112, (byte) 104, (byte) 135, (byte) 109, (byte) 108, (byte) 137, (byte) 134, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DataType getType(object value)
    {
      if (value == null)
      {
        string str = "Can not be given null value";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (value is ITable)
      {
        ITable table = (ITable) value;
        if (!table.containsKey("~TYPE~"))
          return DataType.__\u003C\u003ETABLE;
        return (DataType) NamedDataType.get(table.getString("~TYPE~"));
      }
      else
      {
        if (value is Double)
          return DataType.__\u003C\u003ENUMBER;
        if (value is Boolean)
          return DataType.__\u003C\u003EBOOLEAN;
        if (value is string)
          return DataType.__\u003C\u003ESTRING;
        string str = new StringBuilder().append("Can not get type for class:").append(Object.instancehelper_getClass(value).getName()).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [Signature("()Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;")]
    public virtual Class getDefault()
    {
      return this.defaultClass;
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 105, (byte) 98, (byte) 108, (byte) 112, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isChildOf(DataType parent)
    {
      if (Object.instancehelper_equals((object) this, (object) parent))
        return true;
      for (int index = 0; index < this.parents.Length; ++index)
      {
        if (this.parents[index].isChildOf(parent))
          return true;
      }
      return false;
    }

    [Signature("(Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;)V")]
    public virtual void setDefault(Class defaultClass)
    {
      this.defaultClass = defaultClass;
    }

    [LineNumberTable((ushort) 39)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DataType[] getParents()
    {
      return (DataType[]) this.parents.Clone();
    }

    public virtual bool isNamed()
    {
      return false;
    }

    [LineNumberTable((ushort) 63)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append("[Type:").append(this.name).append("]").toString();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 126, (byte) 162, (byte) 99, (byte) 137, (byte) 114, (byte) 102, (byte) 114, (byte) 102, (byte) 114, (byte) 102, (byte) 114, (byte) 102, (byte) 114, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DataType getType(string type, bool isNamedType)
    {
      if (isNamedType)
      {
        return (DataType) NamedDataType.get(type);
      }
      else
      {
        if (String.instancehelper_equals(type, (object) DataType.__\u003C\u003ENUMBER.getName()))
          return DataType.__\u003C\u003ENUMBER;
        if (String.instancehelper_equals(type, (object) DataType.__\u003C\u003EBOOLEAN.getName()))
          return DataType.__\u003C\u003EBOOLEAN;
        if (String.instancehelper_equals(type, (object) DataType.__\u003C\u003EBASIC.getName()))
          return DataType.__\u003C\u003EBASIC;
        if (String.instancehelper_equals(type, (object) DataType.__\u003C\u003ESTRING.getName()))
          return DataType.__\u003C\u003ESTRING;
        if (String.instancehelper_equals(type, (object) DataType.__\u003C\u003ETABLE.getName()))
          return DataType.__\u003C\u003ETABLE;
        return (DataType) NamedDataType.get(type);
      }
    }
  }
}
