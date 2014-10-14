// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.LibraryTableModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using javax.swing.table;
using org.jfree.@base;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class LibraryTableModel : AbstractTableModel
  {
    private Library[] libraries;
    private string nameColumnLabel;
    private string versionColumnLabel;
    private string licenceColumnLabel;
    private string infoColumnLabel;

    [LineNumberTable(new byte[] {(byte) 37, (byte) 136, (byte) 191, (byte) 2, (byte) 102, (byte) 171, (byte) 145, (byte) 145, (byte) 145, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LibraryTableModel(List libraries)
    {
      base.\u002Ector();
      LibraryTableModel libraryTableModel = this;
      this.libraries = (Library[]) libraries.toArray((object[]) new Library[libraries.size()]);
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.ui.about.resources.AboutResources");
      this.nameColumnLabel = bundle.getString("libraries-table.column.name");
      this.versionColumnLabel = bundle.getString("libraries-table.column.version");
      this.licenceColumnLabel = bundle.getString("libraries-table.column.licence");
      this.infoColumnLabel = bundle.getString("libraries-table.column.info");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LibraryTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable((ushort) 113)]
    public virtual int getRowCount()
    {
      return this.libraries.Length;
    }

    public virtual int getColumnCount()
    {
      return 4;
    }

    public virtual string getColumnName(int column)
    {
      string str = (string) null;
      switch (column)
      {
        case 0:
          str = this.nameColumnLabel;
          break;
        case 1:
          str = this.versionColumnLabel;
          break;
        case 2:
          str = this.licenceColumnLabel;
          break;
        case 3:
          str = this.infoColumnLabel;
          break;
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 98, (byte) 137, (byte) 99, (byte) 137, (byte) 100, (byte) 137, (byte) 100, (byte) 137, (byte) 100, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValueAt(int row, int column)
    {
      string str = (string) null;
      Library library = this.libraries[row];
      if (column == 0)
        str = library.getName();
      else if (column == 1)
        str = library.getVersion();
      else if (column == 2)
        str = library.getLicenceName();
      else if (column == 3)
        str = library.getInfo();
      return (object) str;
    }

    [LineNumberTable((ushort) 192)]
    public virtual Library[] getLibraries()
    {
      return (Library[]) this.libraries.Clone();
    }
  }
}
