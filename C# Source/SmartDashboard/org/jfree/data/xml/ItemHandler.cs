// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.ItemHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.xml.sax;
using org.xml.sax.helpers;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  [Implements(new string[] {"org.jfree.data.xml.DatasetTags"})]
  public class ItemHandler : DefaultHandler, DatasetTags
  {
    private RootHandler root;
    private DefaultHandler parent;
    private IComparable key;
    private Number value;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ItemHandler(RootHandler root, DefaultHandler parent)
    {
      base.\u002Ector();
      ItemHandler itemHandler = this;
      this.root = root;
      this.parent = parent;
      this.key = (IComparable) null;
      this.value = (Number) null;
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 78, (byte) 109, (byte) 109, (byte) 108, (byte) 98, (byte) 109, (byte) 109, (byte) 108, (byte) 130, (byte) 255, (byte) 6, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startElement(string namespaceURI, string localName, string qName, Attributes atts)
    {
      if (String.instancehelper_equals(qName, (object) "Item"))
        this.root.pushSubHandler((DefaultHandler) new KeyHandler(this.root, this));
      else if (String.instancehelper_equals(qName, (object) "Value"))
      {
        this.root.pushSubHandler((DefaultHandler) new ValueHandler(this.root, this));
      }
      else
      {
        string str = new StringBuffer().append("Expected <Item> or <Value>...found ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    public virtual void setKey(IComparable key)
    {
      this.key = key;
    }

    public virtual Number getValue()
    {
      return this.value;
    }

    public virtual void setValue(Number value)
    {
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 109, (byte) 108, (byte) 114, (byte) 108, (byte) 98, (byte) 109, (byte) 108, (byte) 114, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endElement(string namespaceURI, string localName, string qName)
    {
      if (this.parent is PieDatasetHandler)
      {
        ((PieDatasetHandler) this.parent).addItem(this.key, this.value);
        this.root.popSubHandler();
      }
      else
      {
        if (!(this.parent is CategorySeriesHandler))
          return;
        ((CategorySeriesHandler) this.parent).addItem(this.key, this.value);
        this.root.popSubHandler();
      }
    }
  }
}
