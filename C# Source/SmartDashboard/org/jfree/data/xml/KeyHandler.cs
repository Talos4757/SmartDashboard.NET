// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.KeyHandler
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
  public class KeyHandler : DefaultHandler, DatasetTags
  {
    private RootHandler rootHandler;
    private ItemHandler itemHandler;
    private StringBuffer currentText;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 103, (byte) 103, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyHandler(RootHandler rootHandler, ItemHandler itemHandler)
    {
      base.\u002Ector();
      KeyHandler keyHandler = this;
      this.rootHandler = rootHandler;
      this.itemHandler = itemHandler;
      this.currentText = new StringBuffer();
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void clearCurrentText()
    {
      this.currentText.delete(0, this.currentText.length());
    }

    [LineNumberTable((ushort) 146)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string getCurrentText()
    {
      return this.currentText.toString();
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 42, (byte) 109, (byte) 168, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startElement(string namespaceURI, string localName, string qName, Attributes atts)
    {
      if (String.instancehelper_equals(qName, (object) "Key"))
      {
        this.clearCurrentText();
      }
      else
      {
        string str = new StringBuffer().append("Expecting <Key> but found ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 64, (byte) 109, (byte) 113, (byte) 108, (byte) 254, (byte) 69, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endElement(string namespaceURI, string localName, string qName)
    {
      if (String.instancehelper_equals(qName, (object) "Key"))
      {
        this.itemHandler.setKey((IComparable) this.getCurrentText());
        this.rootHandler.popSubHandler();
        this.rootHandler.pushSubHandler((DefaultHandler) new ValueHandler(this.rootHandler, this.itemHandler));
      }
      else
      {
        string str = new StringBuffer().append("Expecting </Key> but found ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 104, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void characters(char[] ch, int start, int length)
    {
      if (this.currentText == null)
        return;
      this.currentText.append(String.copyValueOf(ch, start, length));
    }
  }
}
