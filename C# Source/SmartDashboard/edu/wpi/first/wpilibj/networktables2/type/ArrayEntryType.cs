// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.ArrayEntryType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public class ArrayEntryType : ComplexEntryType
  {
    [Modifiers]
    private NetworkTableEntryType elementType;
    [Modifiers]
    private Class externalArrayType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrayEntryType(byte b, NetworkTableEntryType ntet, Class c)
      : base(b, new StringBuilder().append("Array of [").append(ntet.__\u003C\u003Ename).append("]").toString())
    {
      ArrayEntryType arrayEntryType = this;
      if (!((Class) ClassLiteral<ArrayData>.Value).isAssignableFrom(c))
      {
        string str = "External Array Data Type must extend ArrayData";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
      {
        this.externalArrayType = c;
        this.elementType = ntet;
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void sendValue(object obj, DataOutputStream dos)
    {
      if (obj is object[])
      {
        object[] objArray = (object[]) obj;
        if (objArray.Length > (int) byte.MaxValue)
        {
          string str = new StringBuilder().append("Cannot write ").append(obj).append(" as ").append(this.__\u003C\u003Ename).append(". Arrays have a max length of 255 values").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IOException(str);
        }
        else
        {
          dos.writeByte(objArray.Length);
          for (int index = 0; index < objArray.Length; ++index)
            this.elementType.sendValue(objArray[index], dos);
        }
      }
      else
      {
        string str = new StringBuilder().append("Cannot write ").append(obj).append(" as ").append(this.__\u003C\u003Ename).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IOException(str);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object readValue(DataInputStream dis)
    {
      int length = dis.readUnsignedByte();
      object[] objArray = new object[length];
      for (int index = 0; index < length; ++index)
        objArray[index] = this.elementType.readValue(dis);
      return (object) objArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object internalizeValue(string str, object obj1, object obj2)
    {
      if (this.externalArrayType.isInstance(obj1))
      {
        ArrayData arrayData = (ArrayData) obj1;
        object[] objArray1;
        if (obj2 is object[] && (objArray1 = (object[]) obj2).Length == arrayData.size())
        {
          ByteCodeHelper.arraycopy((object) arrayData.getDataArray(), 0, (object) objArray1, 0, objArray1.Length);
          return (object) objArray1;
        }
        else
        {
          object[] objArray2 = new object[arrayData.size()];
          ByteCodeHelper.arraycopy((object) arrayData.getDataArray(), 0, (object) objArray2, 0, objArray2.Length);
          return (object) objArray2;
        }
      }
      else
      {
        string str1 = str;
        string str2 = new StringBuilder().append(obj1).append(" is not a ").append((object) this.externalArrayType).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TableKeyExistsWithDifferentTypeException(str1, (NetworkTableEntryType) this, str2);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void exportValue(string str, object obj1, object obj2)
    {
      if (!this.externalArrayType.isInstance(obj2))
      {
        string str1 = str;
        string str2 = new StringBuilder().append(obj2).append(" is not a ").append((object) this.externalArrayType).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TableKeyExistsWithDifferentTypeException(str1, (NetworkTableEntryType) this, str2);
      }
      else if (!(obj1 is object[]))
      {
        string str1 = str;
        string str2 = new StringBuilder().append("Internal data: ").append(obj1).append(" is not an array").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TableKeyExistsWithDifferentTypeException(str1, (NetworkTableEntryType) this, str2);
      }
      else
      {
        object[] objArray = (object[]) obj1;
        ArrayData arrayData = (ArrayData) obj2;
        arrayData.setSize(objArray.Length);
        ByteCodeHelper.arraycopy((object) objArray, 0, (object) arrayData.getDataArray(), 0, objArray.Length);
      }
    }
  }
}
