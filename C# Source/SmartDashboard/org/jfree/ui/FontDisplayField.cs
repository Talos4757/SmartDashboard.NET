// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.FontDisplayField
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
  public class FontDisplayField : JTextField
  {
    private Font displayFont;
    internal static ResourceBundle __\u003C\u003ElocalizationResources;

    [Modifiers]
    protected internal static ResourceBundle localizationResources
    {
      [HideFromJava] get
      {
        return FontDisplayField.__\u003C\u003ElocalizationResources;
      }
    }

    [LineNumberTable((ushort) 70)]
    static FontDisplayField()
    {
      JTextField.__\u003Cclinit\u003E();
      FontDisplayField.__\u003C\u003ElocalizationResources = ResourceBundleWrapper.getBundle("org.jfree.ui.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 109, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FontDisplayField(Font font)
    {
      base.\u002Ector("");
      FontDisplayField fontDisplayField = this;
      this.setDisplayFont(font);
      ((JComponent) this).setEnabled(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FontDisplayField([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDisplayFont(Font font)
    {
      this.displayFont = font;
      ((JTextComponent) this).setText(this.fontToString(this.displayFont));
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 99, (byte) 191, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string fontToString([In] Font obj0)
    {
      if (obj0 != null)
        return new StringBuffer().append(obj0.getFontName()).append(", ").append(obj0.getSize()).toString();
      else
        return FontDisplayField.__\u003C\u003ElocalizationResources.getString("No_Font_Selected");
    }

    public virtual Font getDisplayFont()
    {
      return this.displayFont;
    }
  }
}
