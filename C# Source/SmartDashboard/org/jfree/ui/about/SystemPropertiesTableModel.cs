// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.SystemPropertiesTableModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class SystemPropertiesTableModel : SortableTableModel
  {
    private List properties;
    private string nameColumnLabel;
    private string valueColumnLabel;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 136, (byte) 139, (byte) 102, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 106, (byte) 110, (byte) 203, (byte) 2, (byte) 193, (byte) 145, (byte) 102, (byte) 172, (byte) 146, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SystemPropertiesTableModel()
    {
      SystemPropertiesTableModel propertiesTableModel = this;
      this.properties = (List) new ArrayList();
      try
      {
        Iterator iterator = ((Hashtable) System.getProperties()).keySet().iterator();
        while (iterator.hasNext())
        {
          string name = (string) iterator.next();
          string property = System.getProperty(name);
          this.properties.add((object) new SystemPropertiesTableModel.SystemProperty(name, property));
        }
        goto label_6;
      }
      catch (SecurityException ex)
      {
      }
label_6:
      Collections.sort(this.properties, (Comparator) new SystemPropertiesTableModel.SystemPropertyComparator(true));
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.ui.about.resources.AboutResources");
      this.nameColumnLabel = bundle.getString("system-properties-table.column.name");
      this.valueColumnLabel = bundle.getString("system-properties-table.column.value");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SystemPropertiesTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public override bool isSortable(int column)
    {
      return column == 0;
    }

    [LineNumberTable((ushort) 262)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.properties.size();
    }

    public virtual int getColumnCount()
    {
      return 2;
    }

    public virtual string getColumnName(int column)
    {
      if (column == 0)
        return this.nameColumnLabel;
      else
        return this.valueColumnLabel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 114, (byte) 99, (byte) 169, (byte) 100, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValueAt(int row, int column)
    {
      SystemPropertiesTableModel.SystemProperty systemProperty = (SystemPropertiesTableModel.SystemProperty) this.properties.get(row);
      if (column == 0)
      {
        return (object) systemProperty.getName();
      }
      else
      {
        if (column != 1)
          return (object) null;
        return (object) systemProperty.getValue();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 60, (byte) 98, (byte) 105, (byte) 104, (byte) 211})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void sortByColumn(int column, bool ascending)
    {
      int num = ascending ? 1 : 0;
      if (!this.isSortable(column))
        return;
      base.sortByColumn(column, num != 0);
      Collections.sort(this.properties, (Comparator) new SystemPropertiesTableModel.SystemPropertyComparator(num != 0));
    }

    [InnerClass]
    [SourceFile("SystemPropertiesTableModel.java")]
    public class SystemProperty : Object
    {
      private string name;
      private string value;

      [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SystemProperty(string name, string value)
      {
        base.\u002Ector();
        SystemPropertiesTableModel.SystemProperty systemProperty = this;
        this.name = name;
        this.value = value;
      }

      public virtual string getName()
      {
        return this.name;
      }

      public virtual string getValue()
      {
        return this.value;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.util.Comparator"})]
    [SourceFile("SystemPropertiesTableModel.java")]
    public class SystemPropertyComparator : Object, Comparator
    {
      private bool ascending;

      [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 130, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SystemPropertyComparator(bool ascending)
      {
        int num = ascending ? 1 : 0;
        base.\u002Ector();
        SystemPropertiesTableModel.SystemPropertyComparator propertyComparator = this;
        this.ascending = num != 0;
      }

      [LineNumberTable(new byte[] {(byte) 90, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 180, (byte) 212})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int compare(object o1, object o2)
      {
        if (!(o1 is SystemPropertiesTableModel.SystemProperty) || !(o2 is SystemPropertiesTableModel.SystemProperty))
          return 0;
        SystemPropertiesTableModel.SystemProperty systemProperty1 = (SystemPropertiesTableModel.SystemProperty) o1;
        SystemPropertiesTableModel.SystemProperty systemProperty2 = (SystemPropertiesTableModel.SystemProperty) o2;
        if (this.ascending)
          return String.instancehelper_compareTo(systemProperty1.getName(), systemProperty2.getName());
        else
          return String.instancehelper_compareTo(systemProperty2.getName(), systemProperty1.getName());
      }

      [LineNumberTable(new byte[] {(byte) 116, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 167, (byte) 110, (byte) 162})]
      public virtual bool equals(object o)
      {
        return this == o || o is SystemPropertiesTableModel.SystemPropertyComparator && this.ascending == ((SystemPropertiesTableModel.SystemPropertyComparator) o).ascending;
      }

      public virtual int hashCode()
      {
        return this.ascending ? 1 : 0;
      }
    }
  }
}
