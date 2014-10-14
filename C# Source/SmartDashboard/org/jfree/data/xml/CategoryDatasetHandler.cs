// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.CategoryDatasetHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.category;
using org.xml.sax;
using org.xml.sax.helpers;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  [Implements(new string[] {"org.jfree.data.xml.DatasetTags"})]
  public class CategoryDatasetHandler : RootHandler, DatasetTags
  {
    private DefaultCategoryDataset dataset;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryDatasetHandler()
    {
      CategoryDatasetHandler categoryDatasetHandler = this;
      this.dataset = (DefaultCategoryDataset) null;
    }

    public virtual CategoryDataset getDataset()
    {
      return (CategoryDataset) this.dataset;
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addItem(IComparable rowKey, IComparable columnKey, Number value)
    {
      this.dataset.addValue(value, rowKey, columnKey);
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 49, (byte) 103, (byte) 100, (byte) 144, (byte) 109, (byte) 141, (byte) 109, (byte) 103, (byte) 109, (byte) 107, (byte) 130, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startElement(string namespaceURI, string localName, string qName, Attributes atts)
    {
      DefaultHandler currentHandler = this.getCurrentHandler();
      if (currentHandler != this)
        currentHandler.startElement(namespaceURI, localName, qName, atts);
      else if (String.instancehelper_equals(qName, (object) "CategoryDataset"))
        this.dataset = new DefaultCategoryDataset();
      else if (String.instancehelper_equals(qName, (object) "Series"))
      {
        CategorySeriesHandler categorySeriesHandler = new CategorySeriesHandler((RootHandler) this);
        this.getSubHandlers().push((object) categorySeriesHandler);
        categorySeriesHandler.startElement(namespaceURI, localName, qName, atts);
      }
      else
      {
        string str = new StringBuffer().append("Element not recognised: ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 80, (byte) 103, (byte) 100, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endElement(string namespaceURI, string localName, string qName)
    {
      DefaultHandler currentHandler = this.getCurrentHandler();
      if (currentHandler == this)
        return;
      currentHandler.endElement(namespaceURI, localName, qName);
    }
  }
}
