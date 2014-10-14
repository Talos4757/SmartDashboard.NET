// Decompiled with JetBrains decompiler
// Type: org.junit.ComparisonFailure
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.junit
{
  [Serializable]
  public class ComparisonFailure : AssertionError
  {
    private const int MAX_CONTEXT_LENGTH = 20;
    private const long serialVersionUID = 1L;
    private string fExpected;
    private string fActual;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComparisonFailure(string message, string expected, string actual)
    {
      base.\u002Ector((object) message);
      ComparisonFailure comparisonFailure = this;
      this.fExpected = expected;
      this.fActual = actual;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ComparisonFailure([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getMessage()
    {
      return ComparisonFailure.ComparisonCompactor.access\u0024000(new ComparisonFailure.ComparisonCompactor(20, this.fExpected, this.fActual), ((Throwable) this).getMessage());
    }

    public virtual string getActual()
    {
      return this.fActual;
    }

    public virtual string getExpected()
    {
      return this.fExpected;
    }

    [InnerClass]
    [SourceFile("ComparisonFailure.java")]
    [Modifiers]
    internal sealed class ComparisonCompactor : Object
    {
      private const string ELLIPSIS = "...";
      private const string DELTA_END = "]";
      private const string DELTA_START = "[";
      private int fContextLength;
      private string fExpected;
      private string fActual;
      private int fPrefix;
      private int fSuffix;

      [LineNumberTable(new byte[] {(byte) 30, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ComparisonCompactor([In] int obj0, [In] string obj1, [In] string obj2)
      {
        base.\u002Ector();
        ComparisonFailure.ComparisonCompactor comparisonCompactor = this;
        this.fContextLength = obj0;
        this.fExpected = obj1;
        this.fActual = obj2;
      }

      [LineNumberTable(new byte[] {(byte) 37, (byte) 120, (byte) 149, (byte) 102, (byte) 102, (byte) 109, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private string compact([In] string obj0)
      {
        if (this.fExpected == null || this.fActual == null || this.areStringsEqual())
        {
          return Assert.format(obj0, (object) this.fExpected, (object) this.fActual);
        }
        else
        {
          this.findCommonPrefix();
          this.findCommonSuffix();
          string str1 = this.compactString(this.fExpected);
          string str2 = this.compactString(this.fActual);
          return Assert.format(obj0, (object) str1, (object) str2);
        }
      }

      [LineNumberTable((ushort) 135)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool areStringsEqual()
      {
        return (String.instancehelper_equals(this.fExpected, (object) this.fActual) ? 1 : 0) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 57, (byte) 103, (byte) 124, (byte) 105, (byte) 127, (byte) 5, (byte) 2, (byte) 208})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void findCommonPrefix()
      {
        this.fPrefix = 0;
        int num = Math.min(String.instancehelper_length(this.fExpected), String.instancehelper_length(this.fActual));
        while (this.fPrefix < num && (int) String.instancehelper_charAt(this.fExpected, this.fPrefix) == (int) String.instancehelper_charAt(this.fActual, this.fPrefix))
          ++this.fPrefix;
      }

      [LineNumberTable(new byte[] {(byte) 66, (byte) 110, (byte) 110, (byte) 114, (byte) 122, (byte) 2, (byte) 202, (byte) 115})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void findCommonSuffix()
      {
        int num1 = String.instancehelper_length(this.fExpected) - 1;
        int num2 = String.instancehelper_length(this.fActual) - 1;
        while (num2 >= this.fPrefix && num1 >= this.fPrefix && (int) String.instancehelper_charAt(this.fExpected, num1) == (int) String.instancehelper_charAt(this.fActual, num2))
        {
          num2 += -1;
          num1 += -1;
        }
        this.fSuffix = String.instancehelper_length(this.fExpected) - num1;
      }

      [LineNumberTable(new byte[] {(byte) 48, (byte) 127, (byte) 32, (byte) 105, (byte) 124, (byte) 105, (byte) 124})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private string compactString([In] string obj0)
      {
        string str = new StringBuilder().append("[").append(String.instancehelper_substring(obj0, this.fPrefix, String.instancehelper_length(obj0) - this.fSuffix + 1)).append("]").toString();
        if (this.fPrefix > 0)
          str = new StringBuilder().append(this.computeCommonPrefix()).append(str).toString();
        if (this.fSuffix > 0)
          str = new StringBuilder().append(str).append(this.computeCommonSuffix()).toString();
        return str;
      }

      [LineNumberTable((ushort) 126)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private string computeCommonPrefix()
      {
        return new StringBuilder().append(this.fPrefix <= this.fContextLength ? "" : "...").append(String.instancehelper_substring(this.fExpected, Math.max(0, this.fPrefix - this.fContextLength), this.fPrefix)).toString();
      }

      [LineNumberTable(new byte[] {(byte) 80, (byte) 127, (byte) 13})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private string computeCommonSuffix()
      {
        return new StringBuilder().append(String.instancehelper_substring(this.fExpected, String.instancehelper_length(this.fExpected) - this.fSuffix + 1, Math.min(String.instancehelper_length(this.fExpected) - this.fSuffix + 1 + this.fContextLength, String.instancehelper_length(this.fExpected)))).append(String.instancehelper_length(this.fExpected) - this.fSuffix + 1 >= String.instancehelper_length(this.fExpected) - this.fContextLength ? "" : "...").toString();
      }

      [Modifiers]
      [LineNumberTable((ushort) 59)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static string access\u0024000([In] ComparisonFailure.ComparisonCompactor obj0, [In] string obj1)
      {
        return obj0.compact(obj1);
      }
    }
  }
}
