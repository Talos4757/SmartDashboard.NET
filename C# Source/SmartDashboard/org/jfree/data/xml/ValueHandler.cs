// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.ValueHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.xml.sax;
using org.xml.sax.helpers;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  [Implements(new string[] {"org.jfree.data.xml.DatasetTags"})]
  public class ValueHandler : DefaultHandler, DatasetTags
  {
    private RootHandler rootHandler;
    private ItemHandler itemHandler;
    private StringBuffer currentText;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 103, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueHandler(RootHandler rootHandler, ItemHandler itemHandler)
    {
      base.\u002Ector();
      ValueHandler valueHandler = this;
      this.rootHandler = rootHandler;
      this.itemHandler = itemHandler;
      this.currentText = new StringBuffer();
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void clearCurrentText()
    {
      this.currentText.delete(0, this.currentText.length());
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 39, (byte) 141, (byte) 168, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startElement(string namespaceURI, string localName, string qName, Attributes atts)
    {
      if (String.instancehelper_equals(qName, (object) "Value"))
      {
        this.clearCurrentText();
      }
      else
      {
        string str = new StringBuffer().append("Expecting <Value> but found ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 62, (byte) 173, (byte) 113, (byte) 109, (byte) 237, (byte) 69, (byte) 2, (byte) 97, (byte) 130, (byte) 108, (byte) 108, (byte) 130, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endElement(string namespaceURI, string localName, string qName)
    {
      if (String.instancehelper_equals(qName, (object) "Value"))
      {
        Double @double;
        try
        {
          @double = Double.valueOf(this.currentText.toString());
          if (@double.isNaN())
          {
            @double = (Double) null;
            goto label_5;
          }
          else
            goto label_5;
        }
        catch (NumberFormatException ex)
        {
        }
        @double = (Double) null;
label_5:
        this.itemHandler.setValue((Number) @double);
        this.rootHandler.popSubHandler();
      }
      else
      {
        string str = new StringBuffer().append("Expecting </Value> but found ").append(qName).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SAXException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 104, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void characters(char[] ch, int start, int length)
    {
      if (this.currentText == null)
        return;
      this.currentText.append(String.copyValueOf(ch, start, length));
    }

    [LineNumberTable((ushort) 151)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string getCurrentText()
    {
      return this.currentText.toString();
    }
  }
}
