// Decompiled with JetBrains decompiler
// Type: org.hamcrest.BaseDescription
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.hamcrest.@internal;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.hamcrest
{
  [Implements(new string[] {"org.hamcrest.Description"})]
  public abstract class BaseDescription : Object, Description
  {
    [LineNumberTable((ushort) 14)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseDescription()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 107, (byte) 45, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void append(string str)
    {
      for (int index = 0; index < String.instancehelper_length(str); ++index)
        this.append(String.instancehelper_charAt(str, index));
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 104, (byte) 107, (byte) 45, (byte) 166, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void toJavaSyntax([In] string obj0)
    {
      this.append('"');
      for (int index = 0; index < String.instancehelper_length(obj0); ++index)
        this.toJavaSyntax(String.instancehelper_charAt(obj0, index));
      this.append('"');
    }

    protected internal abstract void append(char ch);

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 130, (byte) 159, (byte) 5, (byte) 107, (byte) 130, (byte) 107, (byte) 130, (byte) 107, (byte) 130, (byte) 107, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void toJavaSyntax([In] char obj0)
    {
      int num1 = (int) obj0;
      int num2 = num1;
      int num3 = 9;
      if (num2 == num3)
      {
        this.append("\\t");
      }
      else
      {
        int num4 = 10;
        if (num2 == num4)
        {
          this.append("\\n");
        }
        else
        {
          int num5 = 13;
          if (num2 == num5)
          {
            this.append("\\r");
          }
          else
          {
            int num6 = 34;
            if (num2 == num6)
              this.append("\\\"");
            else
              this.append((char) num1);
          }
        }
      }
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator<TT;>;)Lorg/hamcrest/Description;")]
    [LineNumberTable((ushort) 65)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Description appendValueList([In] string obj0, [In] string obj1, [In] string obj2, [In] Iterator obj3)
    {
      return this.appendList(obj0, obj1, obj2, (Iterator) new SelfDescribingValueIterator(obj3));
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Iterable<TT;>;)Lorg/hamcrest/Description;")]
    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description appendValueList(string start, string separator, string end, Iterable values)
    {
      return this.appendValueList(start, separator, end, values.iterator());
    }

    [Signature("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator<+Lorg/hamcrest/SelfDescribing;>;)Lorg/hamcrest/Description;")]
    [LineNumberTable(new byte[] {(byte) 23, (byte) 130, (byte) 103, (byte) 105, (byte) 106, (byte) 115, (byte) 98, (byte) 98, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Description appendList([In] string obj0, [In] string obj1, [In] string obj2, [In] Iterator obj3)
    {
      int num = 0;
      this.append(obj0);
      while (obj3.hasNext())
      {
        if (num != 0)
          this.append(obj1);
        this.appendDescriptionOf((SelfDescribing) obj3.next());
        num = 1;
      }
      this.append(obj2);
      return (Description) this;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description appendDescriptionOf(SelfDescribing value)
    {
      value.describeTo((Description) this);
      return (Description) this;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description appendText(string text)
    {
      this.append(text);
      return (Description) this;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 99, (byte) 107, (byte) 109, (byte) 108, (byte) 109, (byte) 104, (byte) 113, (byte) 104, (byte) 109, (byte) 104, (byte) 108, (byte) 107, (byte) 109, (byte) 104, (byte) 108, (byte) 107, (byte) 106, (byte) 104, (byte) 108, (byte) 107, (byte) 111, (byte) 124, (byte) 98, (byte) 104, (byte) 108, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description appendValue(object value)
    {
      if (value == null)
        this.append("null");
      else if (value is string)
        this.toJavaSyntax((string) value);
      else if (value is Character)
      {
        this.append('"');
        this.toJavaSyntax(((Character) value).charValue());
        this.append('"');
      }
      else if (value is Short)
      {
        this.append('<');
        this.append(String.valueOf(value));
        this.append("s>");
      }
      else if (value is Long)
      {
        this.append('<');
        this.append(String.valueOf(value));
        this.append("L>");
      }
      else if (value is Float)
      {
        this.append('<');
        this.append(String.valueOf(value));
        this.append("F>");
      }
      else if (Object.instancehelper_getClass(value).isArray())
      {
        this.appendValueList("[", ", ", "]", (Iterator) new ArrayIterator(value));
      }
      else
      {
        this.append('<');
        this.append(String.valueOf(value));
        this.append('>');
      }
      return (Description) this;
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[TT;)Lorg/hamcrest/Description;")]
    [LineNumberTable((ushort) 57)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description appendValueList(string start, string separator, string end, params object[] values)
    {
      return this.appendValueList(start, separator, end, (Iterable) Arrays.asList(values));
    }

    [Signature("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Iterable<+Lorg/hamcrest/SelfDescribing;>;)Lorg/hamcrest/Description;")]
    [LineNumberTable((ushort) 69)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description appendList(string start, string separator, string end, Iterable values)
    {
      return this.appendList(start, separator, end, values.iterator());
    }
  }
}
