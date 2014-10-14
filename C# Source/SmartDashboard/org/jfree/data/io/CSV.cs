// Decompiled with JetBrains decompiler
// Type: org.jfree.data.io.CSV
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data.category;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.data.io
{
  public class CSV : Object
  {
    private char fieldDelimiter;
    private char textDelimiter;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 68, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CSV(char fieldDelimiter, char textDelimiter)
    {
      int num1 = (int) fieldDelimiter;
      int num2 = (int) textDelimiter;
      base.\u002Ector();
      CSV csv = this;
      this.fieldDelimiter = (char) num1;
      this.textDelimiter = (char) num2;
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CSV()
      : this(',', '"')
    {
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 102, (byte) 98, (byte) 98, (byte) 107, (byte) 111, (byte) 132, (byte) 106, (byte) 143, (byte) 100, (byte) 228, (byte) 56, (byte) 230, (byte) 75, (byte) 111, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List extractColumnKeys([In] string obj0)
    {
      ArrayList arrayList = new ArrayList();
      int num1 = 0;
      int num2 = 0;
      for (int index = 0; index < String.instancehelper_length(obj0); ++index)
      {
        if ((int) String.instancehelper_charAt(obj0, index) == (int) this.fieldDelimiter)
        {
          if (num1 > 0)
          {
            string str = String.instancehelper_substring(obj0, num2, index);
            ((List) arrayList).add((object) this.removeStringDelimiters(str));
          }
          num2 = index + 1;
          ++num1;
        }
      }
      string str1 = String.instancehelper_substring(obj0, num2, String.instancehelper_length(obj0));
      ((List) arrayList).add((object) this.removeStringDelimiters(str1));
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 98, (byte) 98, (byte) 98, (byte) 110, (byte) 114, (byte) 99, (byte) 106, (byte) 105, (byte) 130, (byte) 181, (byte) 247, (byte) 69, (byte) 100, (byte) 228, (byte) 48, (byte) 233, (byte) 83, (byte) 186, (byte) 185})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void extractRowKeyAndData([In] string obj0, [In] DefaultCategoryDataset obj1, [In] List obj2)
    {
      string str = (string) null;
      int num1 = 0;
      int num2 = 0;
      for (int index = 0; index < String.instancehelper_length(obj0); ++index)
      {
        if ((int) String.instancehelper_charAt(obj0, index) == (int) this.fieldDelimiter)
        {
          if (num1 == 0)
          {
            str = this.removeStringDelimiters(String.instancehelper_substring(obj0, num2, index));
          }
          else
          {
            Double @double = Double.valueOf(this.removeStringDelimiters(String.instancehelper_substring(obj0, num2, index)));
            obj1.addValue((Number) @double, (IComparable) str, (IComparable) obj2.get(num1 - 1));
          }
          num2 = index + 1;
          ++num1;
        }
      }
      Double double1 = Double.valueOf(this.removeStringDelimiters(String.instancehelper_substring(obj0, num2, String.instancehelper_length(obj0))));
      obj1.addValue((Number) double1, (IComparable) str, (IComparable) obj2.get(num1 - 1));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 103, (byte) 111, (byte) 136, (byte) 118, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string removeStringDelimiters([In] string obj0)
    {
      string str = String.instancehelper_trim(obj0);
      if ((int) String.instancehelper_charAt(str, 0) == (int) this.textDelimiter)
        str = String.instancehelper_substring(str, 1);
      if ((int) String.instancehelper_charAt(str, String.instancehelper_length(str) - 1) == (int) this.textDelimiter)
        str = String.instancehelper_substring(str, 0, String.instancehelper_length(str) - 1);
      return str;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 46, (byte) 102, (byte) 103, (byte) 98, (byte) 98, (byte) 104, (byte) 100, (byte) 99, (byte) 171, (byte) 138, (byte) 104, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryDataset readCategoryDataset(Reader @in)
    {
      DefaultCategoryDataset defaultCategoryDataset = new DefaultCategoryDataset();
      BufferedReader bufferedReader = new BufferedReader(@in);
      List list = (List) null;
      int num = 0;
      string str = bufferedReader.readLine();
      while (str != null)
      {
        if (num == 0)
          list = this.extractColumnKeys(str);
        else
          this.extractRowKeyAndData(str, defaultCategoryDataset, list);
        str = bufferedReader.readLine();
        ++num;
      }
      return (CategoryDataset) defaultCategoryDataset;
    }
  }
}
