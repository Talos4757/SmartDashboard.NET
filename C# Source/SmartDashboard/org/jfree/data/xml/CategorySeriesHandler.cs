// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.CategorySeriesHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.xml.sax;
using org.xml.sax.helpers;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  [Implements(new string[] {"org.jfree.data.xml.DatasetTags"})]
  public class CategorySeriesHandler : DefaultHandler, DatasetTags
  {
    private RootHandler root;
    private IComparable seriesKey;
    private DefaultKeyedValues values;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategorySeriesHandler(RootHandler root)
    {
      base.\u002Ector();
      CategorySeriesHandler categorySeriesHandler = this;
      this.root = root;
      this.values = new DefaultKeyedValues();
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 59, (byte) 109, (byte) 114, (byte) 109, (byte) 108, (byte) 98, (byte) 109, (byte) 109, (byte) 108, (byte) 107, (byte) 162, (byte) 223, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startElement(string namespaceURI, string localName, string qName, Attributes atts)
    {
      if (String.instancehelper_equals(qName, (object) "Series"))
      {
        this.setSeriesKey((IComparable) atts.getValue("name"));
        this.root.pushSubHandler((DefaultHandler) new ItemHandler(this.root, (DefaultHandler) this));
      }
      else if (String.instancehelper_equals(qName, (object) "Item"))
      {
        ItemHandler itemHandler = new ItemHandler(this.root, (DefaultHandler) this);
        this.root.pushSubHandler((DefaultHandler) itemHandler);
        itemHandler.startElement(namespaceURI, localName, qName, atts);
      }
      else
      {
        string str = new StringBuffer().append("Expecting <Series> or <Item> tag...found ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    public virtual void setSeriesKey(IComparable key)
    {
      this.seriesKey = key;
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addItem(IComparable key, Number value)
    {
      this.values.addValue(key, value);
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 112, (byte) 140, (byte) 113, (byte) 104, (byte) 108, (byte) 109, (byte) 110, (byte) 130, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endElement(string namespaceURI, string localName, string qName)
    {
      if (!(this.root is CategoryDatasetHandler))
        return;
      CategoryDatasetHandler categoryDatasetHandler = (CategoryDatasetHandler) this.root;
      Iterator iterator = this.values.getKeys().iterator();
      while (iterator.hasNext())
      {
        IComparable comparable = (IComparable) iterator.next();
        Number number = this.values.getValue(comparable);
        categoryDatasetHandler.addItem(this.seriesKey, comparable, number);
      }
      this.root.popSubHandler();
    }
  }
}
