// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.RootHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.xml.sax.helpers;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  [Implements(new string[] {"org.jfree.data.xml.DatasetTags"})]
  public class RootHandler : DefaultHandler, DatasetTags
  {
    private Stack subHandlers;

    [LineNumberTable(new byte[] {(byte) 9, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RootHandler()
    {
      base.\u002Ector();
      RootHandler rootHandler = this;
      this.subHandlers = new Stack();
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 98, (byte) 104, (byte) 110, (byte) 108, (byte) 99, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DefaultHandler getCurrentHandler()
    {
      DefaultHandler defaultHandler = (DefaultHandler) this;
      if (this.subHandlers != null && ((Vector) this.subHandlers).size() > 0)
      {
        object obj = this.subHandlers.peek();
        if (obj != null)
          defaultHandler = (DefaultHandler) obj;
      }
      return defaultHandler;
    }

    public virtual Stack getSubHandlers()
    {
      return this.subHandlers;
    }

    [Throws(new string[] {"org.xml.sax.SAXException"})]
    [LineNumberTable(new byte[] {(byte) 33, (byte) 103, (byte) 100, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void characters(char[] ch, int start, int length)
    {
      DefaultHandler currentHandler = this.getCurrentHandler();
      if (currentHandler == this)
        return;
      currentHandler.characters(ch, start, length);
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void pushSubHandler(DefaultHandler subhandler)
    {
      this.subHandlers.push((object) subhandler);
    }

    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DefaultHandler popSubHandler()
    {
      return (DefaultHandler) this.subHandlers.pop();
    }
  }
}
