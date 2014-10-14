// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.LibraryPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.util;
using javax.swing;
using javax.swing.table;
using org.jfree.@base;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class LibraryPanel : JPanel
  {
    private JTable table;
    private LibraryTableModel model;

    [HideFromJava]
    static LibraryPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LibraryPanel(ProjectInfo projectInfo)
      : this(LibraryPanel.getLibraries(projectInfo))
    {
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 136, (byte) 107, (byte) 108, (byte) 118, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LibraryPanel(List libraries)
    {
      base.\u002Ector();
      LibraryPanel libraryPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.model = new LibraryTableModel(libraries);
      JTable.__\u003Cclinit\u003E();
      this.table = new JTable((TableModel) this.model);
      JScrollPane.__\u003Cclinit\u003E();
      ((Container) this).add((Component) new JScrollPane((Component) this.table));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LibraryPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 99, (byte) 136, (byte) 102, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List getLibraries([In] ProjectInfo obj0)
    {
      if (obj0 == null)
      {
        return (List) new ArrayList();
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        LibraryPanel.collectLibraries(obj0, (List) arrayList);
        return (List) arrayList;
      }
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 103, (byte) 103, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 236, (byte) 58, (byte) 230, (byte) 75, (byte) 103, (byte) 103, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 236, (byte) 58, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void collectLibraries([In] ProjectInfo obj0, [In] List obj1)
    {
      foreach (Library library in obj0.getLibraries())
      {
        if (!obj1.contains((object) library))
        {
          obj1.add((object) library);
          if (library is ProjectInfo)
            LibraryPanel.collectLibraries((ProjectInfo) library, obj1);
        }
      }
      foreach (Library library in obj0.getOptionalLibraries())
      {
        if (!obj1.contains((object) library))
        {
          obj1.add((object) library);
          if (library is ProjectInfo)
            LibraryPanel.collectLibraries((ProjectInfo) library, obj1);
        }
      }
    }

    public virtual LibraryTableModel getModel()
    {
      return this.model;
    }

    protected internal virtual JTable getTable()
    {
      return this.table;
    }
  }
}
