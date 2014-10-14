// Decompiled with JetBrains decompiler
// Type: org.jfree.util.LineBreakIterator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  [Implements(new string[] {"java.util.Iterator"})]
  public class LineBreakIterator : Object, Iterator
  {
    public const int DONE = -1;
    private char[] text;
    private int position;

    [LineNumberTable(new byte[] {(byte) 16, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBreakIterator()
    {
      base.\u002Ector();
      LineBreakIterator lineBreakIterator = this;
      this.setText("");
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBreakIterator(string text)
    {
      base.\u002Ector();
      LineBreakIterator lineBreakIterator = this;
      this.setText(text);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 103, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setText(string text)
    {
      this.position = 0;
      this.text = String.instancehelper_toCharArray(text);
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 136, (byte) 130, (byte) 137, (byte) 226, (byte) 69, (byte) 104, (byte) 199, (byte) 164, (byte) 103, (byte) 162, (byte) 98, (byte) 194, (byte) 136, (byte) 106, (byte) 138, (byte) 98, (byte) 226, (byte) 58, (byte) 232, (byte) 74, (byte) 99, (byte) 131, (byte) 100, (byte) 133, (byte) 144, (byte) 164, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.Synchronized)]
    public virtual int nextPosition()
    {
      if (this.text == null || this.position == -1)
        return -1;
      int length = this.text.Length;
      int num1 = this.position;
      while (num1 < length)
      {
        int num2 = 0;
        int num3 = 0;
        int index1;
        for (index1 = num1; index1 < length; ++index1)
        {
          num3 = (int) this.text[index1];
          switch (num3)
          {
            case 10:
            case 13:
              num2 = 1;
              goto label_10;
            default:
              goto default;
          }
        }
label_10:
        num1 = index1;
        if (num2 != 0)
        {
          int index2 = num1 + 1;
          if (num3 == 13 && index2 < length && (int) this.text[index2] == 10)
            ++index2;
          this.position = index2;
          return this.position;
        }
      }
      this.position = -1;
      return -1;
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 103, (byte) 132, (byte) 130, (byte) 138, (byte) 103, (byte) 130, (byte) 103, (byte) 132, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int nextWithEnd()
    {
      int num1 = this.position;
      if (num1 == -1)
        return -1;
      if (num1 == this.text.Length)
      {
        this.position = -1;
        return -1;
      }
      else
      {
        int num2 = this.nextPosition();
        if (num2 == -1)
          return this.text.Length;
        else
          return num2;
      }
    }

    [LineNumberTable((ushort) 175)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getText()
    {
      return String.newhelper(this.text);
    }

    public virtual bool hasNext()
    {
      return this.position != -1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 169, (byte) 162, (byte) 103, (byte) 103, (byte) 164, (byte) 216, (byte) 132, (byte) 98, (byte) 255, (byte) 7, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object next()
    {
      if (this.position == -1)
        return (object) null;
      int num1 = this.position;
      int num2 = this.nextWithEnd();
      if (num2 == -1)
      {
        return (object) String.newhelper(this.text, num1, this.text.Length - num1);
      }
      else
      {
        if (num2 > 0)
        {
          int num3 = num1;
          while (num2 > num3 && ((int) this.text[num2 - 1] == 10 || (int) this.text[num2 - 1] == 13))
            num2 += -1;
        }
        return (object) String.newhelper(this.text, num1, num2 - num1);
      }
    }

    [LineNumberTable((ushort) 253)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove()
    {
      string str = "This iterator is read-only.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new UnsupportedOperationException(str);
    }
  }
}
