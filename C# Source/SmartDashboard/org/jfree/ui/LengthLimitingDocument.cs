// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.LengthLimitingDocument
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using javax.swing.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class LengthLimitingDocument : PlainDocument
  {
    private int maxlen;

    [HideFromJava]
    static LengthLimitingDocument()
    {
      PlainDocument.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LengthLimitingDocument(int maxlen)
    {
      base.\u002Ector();
      LengthLimitingDocument limitingDocument = this;
      this.maxlen = maxlen;
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LengthLimitingDocument()
      : this(-1)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LengthLimitingDocument([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual void setMaxLength(int maxlen)
    {
      this.maxlen = maxlen;
    }

    public virtual int getMaxLength()
    {
      return this.maxlen;
    }

    [Throws(new string[] {"javax.swing.text.BadLocationException"})]
    [LineNumberTable(new byte[] {(byte) 59, (byte) 99, (byte) 161, (byte) 105, (byte) 169, (byte) 103, (byte) 102, (byte) 118, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertString(int offs, string str, AttributeSet a)
    {
      if (str == null)
        return;
      if (this.maxlen < 0)
        base.insertString(offs, str, a);
      char[] chArray = String.instancehelper_toCharArray(str);
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(chArray, 0, Math.min(this.maxlen, chArray.Length));
      base.insertString(offs, stringBuffer.toString(), a);
    }
  }
}
