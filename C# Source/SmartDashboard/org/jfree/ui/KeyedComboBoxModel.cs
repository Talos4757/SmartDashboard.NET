// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.KeyedComboBoxModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"javax.swing.ComboBoxModel"})]
  public class KeyedComboBoxModel : Object, ComboBoxModel, ListModel
  {
    private int selectedItemIndex;
    private object selectedItemValue;
    private ArrayList data;
    private ArrayList listdatalistener;
    [NonSerialized]
    private ListDataListener[] tempListeners;
    private bool allowOtherValue;

    [LineNumberTable(new byte[] {(byte) 95, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyedComboBoxModel()
    {
      base.\u002Ector();
      KeyedComboBoxModel keyedComboBoxModel = this;
      this.data = new ArrayList();
      this.listdatalistener = new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 109, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyedComboBoxModel(object[] keys, object[] values)
      : this()
    {
      KeyedComboBoxModel keyedComboBoxModel = this;
      this.setData(keys, values);
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 134, (byte) 176, (byte) 107, (byte) 141, (byte) 135, (byte) 12, (byte) 230, (byte) 69, (byte) 103, (byte) 150, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setData(object[] keys, object[] values)
    {
      if (values.Length != keys.Length)
      {
        string str = "Values and text must have the same length.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data.clear();
        this.data.ensureCapacity(keys.Length);
        for (int index = 0; index < values.Length; ++index)
          this.add(keys[index], values[index]);
        this.selectedItemIndex = -1;
        this.fireListDataEvent(new ListDataEvent((object) this, 0, 0, this.data.size() - 1));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 107, (byte) 104, (byte) 109, (byte) 159, (byte) 3, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(object key, object cbitem)
    {
      this.data.add((object) new KeyedComboBoxModel.ComboBoxItemPair(key, cbitem));
      this.fireListDataEvent(new ListDataEvent((object) this, 1, this.data.size() - 2, this.data.size() - 2));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 136, (byte) 223, (byte) 12, (byte) 103, (byte) 135, (byte) 100, (byte) 231, (byte) 61, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    protected internal virtual void fireListDataEvent(ListDataEvent evt)
    {
      if (this.tempListeners == null)
        this.tempListeners = (ListDataListener[]) this.listdatalistener.toArray((object[]) new ListDataListener[this.listdatalistener.size()]);
      foreach (ListDataListener listDataListener in this.tempListeners)
        listDataListener.contentsChanged(evt);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 39, (byte) 131, (byte) 176, (byte) 144, (byte) 114, (byte) 142, (byte) 226, (byte) 59, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int findDataElementIndex([In] object obj0)
    {
      if (obj0 == null)
      {
        string str = "Item to find must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        for (int index = 0; index < this.data.size(); ++index)
        {
          KeyedComboBoxModel.ComboBoxItemPair comboBoxItemPair = (KeyedComboBoxModel.ComboBoxItemPair) this.data.get(index);
          if (Object.instancehelper_equals(obj0, comboBoxItemPair.getKey()))
            return index;
        }
        return -1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 142, (byte) 162, (byte) 114, (byte) 131, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getElementAt(int index)
    {
      if (index >= this.data.size())
        return (object) null;
      KeyedComboBoxModel.ComboBoxItemPair comboBoxItemPair = (KeyedComboBoxModel.ComboBoxItemPair) this.data.get(index);
      if (comboBoxItemPair == null)
        return (object) null;
      return comboBoxItemPair.getValue();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 64, (byte) 131, (byte) 176, (byte) 144, (byte) 114, (byte) 142, (byte) 226, (byte) 59, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int findElementIndex(object key)
    {
      if (key == null)
      {
        string str = "Item to find must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        for (int index = 0; index < this.data.size(); ++index)
        {
          KeyedComboBoxModel.ComboBoxItemPair comboBoxItemPair = (KeyedComboBoxModel.ComboBoxItemPair) this.data.get(index);
          if (Object.instancehelper_equals(key, comboBoxItemPair.getValue()))
            return index;
        }
        return -1;
      }
    }

    private bool isAllowOtherValue()
    {
      return this.allowOtherValue;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 142, (byte) 162, (byte) 132, (byte) 162, (byte) 114, (byte) 131, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getKeyAt(int index)
    {
      if (index >= this.data.size())
        return (object) null;
      if (index < 0)
        return (object) null;
      KeyedComboBoxModel.ComboBoxItemPair comboBoxItemPair = (KeyedComboBoxModel.ComboBoxItemPair) this.data.get(index);
      if (comboBoxItemPair == null)
        return (object) null;
      return comboBoxItemPair.getKey();
    }

    [LineNumberTable((ushort) 385)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSize()
    {
      return this.data.size();
    }

    public virtual object getSelectedItem()
    {
      return this.selectedItemValue;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 131, (byte) 103, (byte) 201, (byte) 104, (byte) 132, (byte) 103, (byte) 201, (byte) 103, (byte) 178, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSelectedKey(object anItem)
    {
      if (anItem == null)
      {
        this.selectedItemIndex = -1;
        this.selectedItemValue = (object) null;
      }
      else
      {
        int dataElementIndex = this.findDataElementIndex(anItem);
        if (dataElementIndex == -1)
        {
          this.selectedItemIndex = -1;
          this.selectedItemValue = (object) null;
        }
        else
        {
          this.selectedItemIndex = dataElementIndex;
          this.selectedItemValue = this.getElementAt(this.selectedItemIndex);
        }
      }
      this.fireListDataEvent(new ListDataEvent((object) this, 0, -1, -1));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 131, (byte) 103, (byte) 201, (byte) 104, (byte) 132, (byte) 136, (byte) 103, (byte) 201, (byte) 103, (byte) 233, (byte) 69, (byte) 103, (byte) 178, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSelectedItem(object anItem)
    {
      if (anItem == null)
      {
        this.selectedItemIndex = -1;
        this.selectedItemValue = (object) null;
      }
      else
      {
        int elementIndex = this.findElementIndex(anItem);
        if (elementIndex == -1)
        {
          if (this.isAllowOtherValue())
          {
            this.selectedItemIndex = -1;
            this.selectedItemValue = anItem;
          }
          else
          {
            this.selectedItemIndex = -1;
            this.selectedItemValue = (object) null;
          }
        }
        else
        {
          this.selectedItemIndex = elementIndex;
          this.selectedItemValue = this.getElementAt(this.selectedItemIndex);
        }
      }
      this.fireListDataEvent(new ListDataEvent((object) this, 0, -1, -1));
    }

    public virtual void setAllowOtherValue(bool allowOtherValue)
    {
      this.allowOtherValue = allowOtherValue;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 131, (byte) 139, (byte) 109, (byte) 103})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addListDataListener(ListDataListener l)
    {
      if (l == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        this.listdatalistener.add((object) l);
        this.tempListeners = (ListDataListener[]) null;
      }
    }

    [LineNumberTable((ushort) 375)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getSelectedKey()
    {
      return this.getKeyAt(this.selectedItemIndex);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 26, (byte) 109, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeListDataListener(ListDataListener l)
    {
      this.listdatalistener.remove((object) l);
      this.tempListeners = (ListDataListener[]) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 87, (byte) 104, (byte) 132, (byte) 161, (byte) 109, (byte) 138, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeDataElement(object key)
    {
      int dataElementIndex = this.findDataElementIndex(key);
      if (dataElementIndex == -1)
        return;
      this.data.remove(dataElementIndex);
      this.fireListDataEvent(new ListDataEvent((object) this, 2, dataElementIndex, dataElementIndex));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 119, (byte) 103, (byte) 107, (byte) 108, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      int size = this.getSize();
      this.data.clear();
      this.fireListDataEvent(new ListDataEvent((object) this, 2, 0, size - 1));
    }

    [InnerClass]
    [SourceFile("KeyedComboBoxModel.java")]
    [Modifiers]
    internal sealed class ComboBoxItemPair : Object
    {
      private object key;
      private object value;

      [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ComboBoxItemPair([In] object obj0, [In] object obj1)
      {
        base.\u002Ector();
        KeyedComboBoxModel.ComboBoxItemPair comboBoxItemPair = this;
        this.key = obj0;
        this.value = obj1;
      }

      public virtual object getKey()
      {
        return this.key;
      }

      public virtual object getValue()
      {
        return this.value;
      }

      public virtual void setValue([In] object obj0)
      {
        this.value = obj0;
      }
    }
  }
}
