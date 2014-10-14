// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.InsetsTextField
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.text;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class InsetsTextField : JTextField
  {
    protected internal static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 64)]
    static InsetsTextField()
    {
      JTextField.__\u003Cclinit\u003E();
      InsetsTextField.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.ui.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InsetsTextField(Insets insets)
    {
      base.\u002Ector();
      InsetsTextField insetsTextField = this;
      this.setInsets(insets);
      ((JComponent) this).setEnabled(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected InsetsTextField([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInsets(Insets insets)
    {
      ((JTextComponent) this).setText(this.formatInsetsString(insets));
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string formatInsetsString(Insets insets)
    {
      insets = insets != null ? insets : new Insets(0, 0, 0, 0);
      return new StringBuffer().append(InsetsTextField.localizationResources.getString("T")).append((int) insets.top).append(", ").append(InsetsTextField.localizationResources.getString("L")).append((int) insets.left).append(", ").append(InsetsTextField.localizationResources.getString("B")).append((int) insets.bottom).append(", ").append(InsetsTextField.localizationResources.getString("R")).append((int) insets.right).toString();
    }
  }
}
