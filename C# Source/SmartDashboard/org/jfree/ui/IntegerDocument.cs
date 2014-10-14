// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.IntegerDocument
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
  public class IntegerDocument : PlainDocument
  {
    [HideFromJava]
    static IntegerDocument()
    {
      PlainDocument.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegerDocument()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected IntegerDocument([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"javax.swing.text.BadLocationException"})]
    [LineNumberTable(new byte[] {(byte) 19, (byte) 105, (byte) 156, (byte) 222, (byte) 2, (byte) 97, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertString(int i, string s, AttributeSet attributes)
    {
      base.insertString(i, s, attributes);
      if (s == null)
        return;
      if (String.instancehelper_equals(s, (object) "-"))
      {
        if (i == 0)
        {
          if (String.instancehelper_length(s) < 2)
            return;
        }
      }
      try
      {
        Integer.parseInt(((AbstractDocument) this).getText(0, ((AbstractDocument) this).getLength()));
        return;
      }
      catch (NumberFormatException ex)
      {
      }
      ((AbstractDocument) this).remove(i, String.instancehelper_length(s));
    }
  }
}
