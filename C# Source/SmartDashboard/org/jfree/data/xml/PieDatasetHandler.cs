// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.PieDatasetHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.general;
using org.xml.sax;
using org.xml.sax.helpers;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  [Implements(new string[] {"org.jfree.data.xml.DatasetTags"})]
  public class PieDatasetHandler : RootHandler, DatasetTags
  {
    private DefaultPieDataset dataset;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PieDatasetHandler()
    {
      PieDatasetHandler pieDatasetHandler = this;
      this.dataset = (DefaultPieDataset) null;
    }

    public virtual PieDataset getDataset()
    {
      return (PieDataset) this.dataset;
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addItem(IComparable key, Number value)
    {
      this.dataset.setValue(key, value);
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 48, (byte) 103, (byte) 100, (byte) 141, (byte) 109, (byte) 141, (byte) 109, (byte) 104, (byte) 109, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startElement(string namespaceURI, string localName, string qName, Attributes atts)
    {
      DefaultHandler currentHandler = this.getCurrentHandler();
      if (currentHandler != this)
        currentHandler.startElement(namespaceURI, localName, qName, atts);
      else if (String.instancehelper_equals(qName, (object) "PieDataset"))
      {
        this.dataset = new DefaultPieDataset();
      }
      else
      {
        if (!String.instancehelper_equals(qName, (object) "Item"))
          return;
        ItemHandler itemHandler = new ItemHandler((RootHandler) this, (DefaultHandler) this);
        this.getSubHandlers().push((object) itemHandler);
        itemHandler.startElement(namespaceURI, localName, qName, atts);
      }
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 76, (byte) 103, (byte) 100, (byte) 171})]
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
