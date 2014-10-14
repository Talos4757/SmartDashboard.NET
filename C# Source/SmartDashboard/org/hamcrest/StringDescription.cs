// Decompiled with JetBrains decompiler
// Type: org.hamcrest.StringDescription
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace org.hamcrest
{
  public class StringDescription : BaseDescription
  {
    [Modifiers]
    private Appendable @out;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringDescription(Appendable @out)
    {
      StringDescription stringDescription = this;
      this.@out = @out;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringDescription()
      : this((Appendable) new StringBuilder())
    {
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string toString(SelfDescribing value)
    {
      return Object.instancehelper_toString((object) new StringDescription().appendDescriptionOf(value));
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string asString(SelfDescribing selfDescribing)
    {
      return StringDescription.toString(selfDescribing);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 191, (byte) 16, (byte) 2, (byte) 97, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void append(string str)
    {
      IOException ioException1;
      try
      {
        Appendable appendable = this.@out;
        object obj = (object) str;
        CharSequence charSequence1;
        charSequence1.__\u003Cref\u003E = (__Null) obj;
        CharSequence charSequence2 = charSequence1;
        appendable.append(charSequence2);
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      IOException ioException2 = ioException1;
      string str1 = "Could not write description";
      IOException ioException3 = ioException2;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str1, (Exception) ioException3);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 130, (byte) 66, (byte) 191, (byte) 0, (byte) 2, (byte) 97, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void append(char c)
    {
      int num1 = (int) c;
      IOException ioException1;
      try
      {
        this.@out.append((char) num1);
        return;
      }
      catch (IOException ex)
      {
        int num2 = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
      }
      IOException ioException2 = ioException1;
      string str = "Could not write description";
      IOException ioException3 = ioException2;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str, (Exception) ioException3);
    }

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return Object.instancehelper_toString((object) this.@out);
    }
  }
}
