// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.AbstractTableWidget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.livewindow.elements;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [Serializable]
  public abstract class AbstractTableWidget : Widget, ITableListener
  {
    protected internal ITable table;
    public NameTag nameTag;
    [Modifiers]
    private bool listenSubtables;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/gui/elements/bindings/BooleanBindable;>;")]
    private Map booleanFields;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/gui/elements/bindings/NumberBindable;>;")]
    private Map numberFields;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/gui/elements/bindings/StringBindable;>;")]
    private Map stringFields;

    [HideFromJava]
    static AbstractTableWidget()
    {
      Widget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 135, (byte) 98, (byte) 232, (byte) 95, (byte) 107, (byte) 107, (byte) 235, (byte) 32, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractTableWidget(bool listenSubtables)
    {
      int num = listenSubtables ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      AbstractTableWidget abstractTableWidget = this;
      this.booleanFields = (Map) new HashMap();
      this.numberFields = (Map) new HashMap();
      this.stringFields = (Map) new HashMap();
      this.listenSubtables = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractTableWidget()
      : this(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractTableWidget([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 103, (byte) 103, (byte) 102, (byte) 100, (byte) 136, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setField(string name, Widget element, DataType type, object value, LWSubsystem subsystem, Point point)
    {
      element.setFieldName(name);
      element.setType(type);
      element.init();
      if (value != null)
        element.setValue(value);
      ((Container) subsystem).add((Component) element);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 98, (byte) 114, (byte) 99, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void booleanChanged(ITable source, string key, bool value, bool isNew)
    {
      int num = value ? 1 : 0;
      BooleanBindable booleanBindable = (BooleanBindable) this.booleanFields.get((object) key);
      if (booleanBindable == null)
        return;
      booleanBindable.setBindableValue(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 114, (byte) 99, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void doubleChanged(ITable source, string key, double value, bool isNew)
    {
      NumberBindable numberBindable = (NumberBindable) this.numberFields.get((object) key);
      if (numberBindable == null)
        return;
      numberBindable.setBindableValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 114, (byte) 99, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void stringChanged(ITable source, string key, string value, bool isNew)
    {
      StringBindable stringBindable = (StringBindable) this.stringFields.get((object) key);
      if (stringBindable == null)
        return;
      stringBindable.setBindableValue(value);
    }

    public virtual void tableChanged(ITable source, string key, ITable value, bool isNew)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 104, (byte) 135, (byte) 99, (byte) 135, (byte) 103, (byte) 99, (byte) 104, (byte) 104, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setValue(object value)
    {
      if (!(value is ITable))
        return;
      ITable table = (ITable) value;
      if (table != null)
        table.removeTableListener((ITableListener) this);
      this.table = table;
      if (table == null)
        return;
      table.addTableListener((ITableListener) this, true);
      if (!this.listenSubtables)
        return;
      table.addSubTableListener((ITableListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 126, (byte) 99, (byte) 104, (byte) 116, (byte) 104, (byte) 116, (byte) 104, (byte) 111, (byte) 104, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged(ITable source, string key, object value, bool isNew)
    {
      int num = isNew ? 1 : 0;
      if (value is Boolean)
        this.booleanChanged(source, key, ((Boolean) value).booleanValue(), num != 0);
      if (value is Double)
        this.doubleChanged(source, key, ((Double) value).doubleValue(), num != 0);
      if (value is string)
        this.stringChanged(source, key, (string) value, num != 0);
      if (!(value is ITable))
        return;
      this.tableChanged(source, key, (ITable) value, num != 0);
    }

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Widget.MultiTypeBindable getTableEntryBindable(string key)
    {
      return (Widget.MultiTypeBindable) new AbstractTableWidget\u00241(this, key);
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 110, (byte) 127, (byte) 6, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setBooleanBinding(string key, BooleanBindable displayer)
    {
      if (this.booleanFields.containsKey((object) key))
      {
        string str = new StringBuilder().append("Cannot have multiple boolean fields for the same key: ").append(key).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
        this.booleanFields.put((object) key, (object) displayer);
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 110, (byte) 127, (byte) 6, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setNumberBinding(string key, NumberBindable displayer)
    {
      if (this.numberFields.containsKey((object) key))
      {
        string str = new StringBuilder().append("Cannot have multiple number fields for the same key: ").append(key).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
        this.numberFields.put((object) key, (object) displayer);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 110, (byte) 127, (byte) 6, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setStringBinding(string key, StringBindable displayer, string defaultValue)
    {
      if (this.stringFields.containsKey((object) key))
      {
        string str = new StringBuilder().append("Cannot have multiple string fields for the same key: ").append(key).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
      {
        displayer.setBindableValue(defaultValue);
        this.stringFields.put((object) key, (object) displayer);
      }
    }

    [InnerClass]
    [SourceFile("AbstractTableWidget.java")]
    [Serializable]
    public class BooleanTableCheckBox : Widget.BindableBooleanCheckBox
    {
      [Modifiers]
      internal AbstractTableWidget this\u00240 = atw;

      [HideFromJava]
      static BooleanTableCheckBox()
      {
        Widget.BindableBooleanCheckBox.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 87, (byte) 103, (byte) 111, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BooleanTableCheckBox(AbstractTableWidget atw, string key)
        : base((BooleanBindable) atw.getTableEntryBindable(key))
      {
        AbstractTableWidget.BooleanTableCheckBox booleanTableCheckBox = this;
        atw.setBooleanBinding(key, (BooleanBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BooleanTableCheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }

    [InnerClass]
    [SourceFile("AbstractTableWidget.java")]
    [Serializable]
    public class BooleanTableField : Widget.BindableBooleanField
    {
      [Modifiers]
      internal AbstractTableWidget this\u00240 = atw;

      [HideFromJava]
      static BooleanTableField()
      {
        Widget.BindableBooleanField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 93, (byte) 103, (byte) 111, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BooleanTableField(AbstractTableWidget atw, string key)
        : base((BooleanBindable) atw.getTableEntryBindable(key))
      {
        AbstractTableWidget.BooleanTableField booleanTableField = this;
        atw.setBooleanBinding(key, (BooleanBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BooleanTableField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }

    [InnerClass]
    [SourceFile("AbstractTableWidget.java")]
    [Serializable]
    public class NumberTableField : Widget.BindableNumberField
    {
      [Modifiers]
      internal AbstractTableWidget this\u00240 = atw;

      [HideFromJava]
      static NumberTableField()
      {
        Widget.BindableNumberField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 99, (byte) 103, (byte) 111, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NumberTableField(AbstractTableWidget atw, string key)
        : base((NumberBindable) atw.getTableEntryBindable(key))
      {
        AbstractTableWidget.NumberTableField numberTableField = this;
        atw.setNumberBinding(key, (NumberBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected NumberTableField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }

    [InnerClass]
    [SourceFile("AbstractTableWidget.java")]
    [Serializable]
    public class StringTableField : Widget.BindableStringField
    {
      [Modifiers]
      internal AbstractTableWidget this\u00240 = atw;

      [HideFromJava]
      static StringTableField()
      {
        Widget.BindableStringField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 105, (byte) 103, (byte) 111, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public StringTableField(AbstractTableWidget atw, string key)
        : base((StringBindable) atw.getTableEntryBindable(key))
      {
        AbstractTableWidget.StringTableField stringTableField = this;
        atw.setStringBinding(key, (StringBindable) this, "");
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected StringTableField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }
  }
}
