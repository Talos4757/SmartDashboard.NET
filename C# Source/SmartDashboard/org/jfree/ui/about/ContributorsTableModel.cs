// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.ContributorsTableModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using javax.swing.table;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class ContributorsTableModel : AbstractTableModel
  {
    private List contributors;
    private string nameColumnLabel;
    private string contactColumnLabel;

    [LineNumberTable(new byte[] {(byte) 30, (byte) 136, (byte) 135, (byte) 102, (byte) 139, (byte) 145, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContributorsTableModel(List contributors)
    {
      base.\u002Ector();
      ContributorsTableModel contributorsTableModel = this;
      this.contributors = contributors;
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.ui.about.resources.AboutResources");
      this.nameColumnLabel = bundle.getString("contributors-table.column.name");
      this.contactColumnLabel = bundle.getString("contributors-table.column.contact");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ContributorsTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable((ushort) 100)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.contributors.size();
    }

    public virtual int getColumnCount()
    {
      return 2;
    }

    public virtual string getColumnName(int column)
    {
      string str = (string) null;
      int num1 = column;
      int num2 = 0;
      if (num1 == num2)
      {
        str = this.nameColumnLabel;
      }
      else
      {
        int num3 = 1;
        if (num1 == num3)
          str = this.contactColumnLabel;
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 98, (byte) 178, (byte) 99, (byte) 137, (byte) 100, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValueAt(int row, int column)
    {
      string str = (string) null;
      Contributor contributor = (Contributor) this.contributors.get(row);
      if (column == 0)
        str = contributor.getName();
      else if (column == 1)
        str = contributor.getEmail();
      return (object) str;
    }
  }
}
