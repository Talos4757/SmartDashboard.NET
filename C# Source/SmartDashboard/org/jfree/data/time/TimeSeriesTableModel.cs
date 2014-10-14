// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimeSeriesTableModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.swing.table;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"org.jfree.data.general.SeriesChangeListener"})]
  [Serializable]
  public class TimeSeriesTableModel : AbstractTableModel, SeriesChangeListener, EventListener
  {
    private TimeSeries series;
    private bool editable;
    private RegularTimePeriod newTimePeriod;
    private Number newValue;
    internal static Class class\u0024java\u0024lang\u0024String;
    internal static Class class\u0024java\u0024lang\u0024Double;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesTableModel(TimeSeries series)
      : this(series, false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 66, (byte) 104, (byte) 103, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesTableModel(TimeSeries series, bool editable)
    {
      int num = editable ? 1 : 0;
      base.\u002Ector();
      TimeSeriesTableModel seriesTableModel = this;
      this.series = series;
      this.series.addChangeListener((SeriesChangeListener) this);
      this.editable = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesTableModel()
      : this(new TimeSeries((IComparable) "Untitled"))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeSeriesTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable((ushort) 117)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, TimeSeriesTableModel.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    public virtual int getColumnCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 99, (byte) 191, (byte) 0, (byte) 100, (byte) 191, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Class getColumnClass(int column)
    {
      if (column == 0)
      {
        if (TimeSeriesTableModel.class\u0024java\u0024lang\u0024String == null)
          return TimeSeriesTableModel.class\u0024java\u0024lang\u0024String = TimeSeriesTableModel.class\u0024("java.lang.String");
        else
          return TimeSeriesTableModel.class\u0024java\u0024lang\u0024String;
      }
      else
      {
        if (column != 1)
          return (Class) null;
        if (TimeSeriesTableModel.class\u0024java\u0024lang\u0024Double == null)
          return TimeSeriesTableModel.class\u0024java\u0024lang\u0024Double = TimeSeriesTableModel.class\u0024("java.lang.Double");
        else
          return TimeSeriesTableModel.class\u0024java\u0024lang\u0024Double;
      }
    }

    public virtual string getColumnName(int column)
    {
      if (column == 0)
        return "Period:";
      if (column == 1)
        return "Value:";
      else
        return (string) null;
    }

    [LineNumberTable((ushort) 158)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.series.getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 110, (byte) 99, (byte) 175, (byte) 100, (byte) 175, (byte) 226, (byte) 69, (byte) 99, (byte) 167, (byte) 100, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValueAt(int row, int column)
    {
      if (row < this.series.getItemCount())
      {
        if (column == 0)
        {
          return (object) this.series.getTimePeriod(row);
        }
        else
        {
          if (column != 1)
            return (object) null;
          return (object) this.series.getValue(row);
        }
      }
      else
      {
        if (column == 0)
          return (object) this.newTimePeriod;
        if (column == 1)
          return (object) this.newValue;
        else
          return (object) null;
      }
    }

    public virtual bool isCellEditable(int row, int column)
    {
      return this.editable && (column == 0 || column == 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 174, (byte) 135, (byte) 108, (byte) 248, (byte) 69, (byte) 2, (byte) 97, (byte) 111, (byte) 194, (byte) 131, (byte) 137, (byte) 100, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueAt(object value, int row, int column)
    {
      if (row < this.series.getItemCount())
      {
        if (column != 1)
          return;
        try
        {
          Double @double = Double.valueOf(Object.instancehelper_toString(value));
          this.series.update(row, (Number) @double);
          return;
        }
        catch (NumberFormatException ex)
        {
        }
        System.get_err().println("Number format exception");
      }
      else if (column == 0)
      {
        this.newTimePeriod = (RegularTimePeriod) null;
      }
      else
      {
        if (column != 1)
          return;
        this.newValue = (Number) Double.valueOf(Object.instancehelper_toString(value));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void seriesChanged(SeriesChangeEvent @event)
    {
      this.fireTableDataChanged();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TimeSeriesTableModel.__\u003CcallerID\u003E == null)
        TimeSeriesTableModel.__\u003CcallerID\u003E = (CallerID) new TimeSeriesTableModel.__\u003CCallerID\u003E();
      return TimeSeriesTableModel.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
