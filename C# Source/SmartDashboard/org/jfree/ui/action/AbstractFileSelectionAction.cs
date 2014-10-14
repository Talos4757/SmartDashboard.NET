// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.AbstractFileSelectionAction
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using javax.swing;
using javax.swing.filechooser;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.action
{
  [Serializable]
  public abstract class AbstractFileSelectionAction : AbstractActionDowngrade
  {
    private JFileChooser fileChooser;
    private Component parent;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractFileSelectionAction(Component parent)
    {
      AbstractFileSelectionAction fileSelectionAction = this;
      this.parent = parent;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractFileSelectionAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 102, (byte) 183, (byte) 103, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual JFileChooser createFileChooser()
    {
      JFileChooser jfileChooser = new JFileChooser();
      jfileChooser.addChoosableFileFilter((FileFilter) new ExtensionFileFilter(this.getFileDescription(), this.getFileExtension()));
      jfileChooser.setMultiSelectionEnabled(false);
      jfileChooser.setCurrentDirectory(this.getCurrentDirectory());
      return jfileChooser;
    }

    protected internal abstract string getFileExtension();

    protected internal abstract string getFileDescription();

    [LineNumberTable((ushort) 98)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual File getCurrentDirectory()
    {
      return new File(".");
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 104, (byte) 172, (byte) 108, (byte) 108, (byte) 115, (byte) 99, (byte) 108, (byte) 103, (byte) 110, (byte) 156, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual File performSelectFile(File selectedFile, int dialogType, bool appendExtension)
    {
      if (this.fileChooser == null)
        this.fileChooser = this.createFileChooser();
      this.fileChooser.setSelectedFile(selectedFile);
      this.fileChooser.setDialogType(dialogType);
      if (this.fileChooser.showDialog(this.parent, (string) null) != 0)
        return (File) null;
      string @base = this.fileChooser.getSelectedFile().getAbsolutePath();
      if (!StringUtils.endsWithIgnoreCase(@base, this.getFileExtension()))
        @base = new StringBuffer().append(@base).append(this.getFileExtension()).toString();
      return new File(@base);
    }
  }
}
