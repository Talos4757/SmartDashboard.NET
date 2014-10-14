// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.xml.SmartDashboardXMLReader
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.livewindow.elements;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using java.util;
using javax.xml.parsers;
using org.w3c.dom;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.xml
{
  public class SmartDashboardXMLReader : Object
  {
    [Modifiers]
    [Signature("Ljava/util/List<Ledu/wpi/first/smartdashboard/xml/XMLWidget;>;")]
    private List widgets;
    [Modifiers]
    [Signature("Ljava/util/Map<Ledu/wpi/first/smartdashboard/xml/XMLWidget;Ljava/util/Map<Ljava/lang/Integer;Ledu/wpi/first/smartdashboard/xml/XMLWidget;>;>;")]
    private Map subsystems;
    [Signature("Ljava/util/List<Ljava/lang/String;>;")]
    private List hiddenFields;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
    private Map properties;
    private bool finishedReading;
    private SmartDashboardXMLReader self;

    [Throws(new string[] {"java.io.FileNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 72, (byte) 232, (byte) 159, (byte) 91, (byte) 139, (byte) 139, (byte) 107, (byte) 107, (byte) 103, (byte) 231, (byte) 160, (byte) 159, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SmartDashboardXMLReader(string fileName)
    {
      base.\u002Ector();
      SmartDashboardXMLReader dashboardXmlReader = this;
      this.widgets = (List) new ArrayList();
      this.subsystems = (Map) new HashMap();
      this.hiddenFields = (List) new ArrayList();
      this.properties = (Map) new HashMap();
      this.finishedReading = false;
      this.self = this;
      this.self = this;
      new SmartDashboardXMLReader.ReaderThread(this, fileName).start();
    }

    [Signature("()Ljava/util/List<Ledu/wpi/first/smartdashboard/xml/XMLWidget;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getXMLWidgets()
    {
      this.waitToFinish();
      return this.widgets;
    }

    [Signature("()Ljava/util/Map<Ledu/wpi/first/smartdashboard/xml/XMLWidget;Ljava/util/Map<Ljava/lang/Integer;Ledu/wpi/first/smartdashboard/xml/XMLWidget;>;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Map getSubsystems()
    {
      this.waitToFinish();
      return this.subsystems;
    }

    [Signature("(Ledu/wpi/first/smartdashboard/xml/XMLWidget;)Ljava/util/Map<Ljava/lang/Integer;Ledu/wpi/first/smartdashboard/xml/XMLWidget;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Map getSubwidgetMap(XMLWidget subsystem)
    {
      this.waitToFinish();
      return (Map) this.subsystems.get((object) subsystem);
    }

    [Signature("()Ljava/util/List<Ljava/lang/String;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getHiddenFields()
    {
      this.waitToFinish();
      return this.hiddenFields;
    }

    [Signature("()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Map getProperties()
    {
      this.waitToFinish();
      return this.properties;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 98, (byte) 127, (byte) 6, (byte) 125, (byte) 164, (byte) 99, (byte) 127, (byte) 17, (byte) 103, (byte) 104, (byte) 105, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsWidgetOfName(LWSubsystem subsystem, string name)
    {
      XMLWidget xmlWidget1 = (XMLWidget) null;
      Iterator iterator1 = this.subsystems.keySet().iterator();
      while (iterator1.hasNext())
      {
        XMLWidget xmlWidget2 = (XMLWidget) iterator1.next();
        if (String.instancehelper_equals(((Widget) xmlWidget2.convertToDisplayElement()).getFieldName(), (object) subsystem.getFieldName()))
          xmlWidget1 = xmlWidget2;
      }
      if (xmlWidget1 != null)
      {
        Iterator iterator2 = ((Map) this.subsystems.get((object) xmlWidget1)).values().iterator();
        while (iterator2.hasNext())
        {
          XMLWidget xmlWidget2 = (XMLWidget) iterator2.next();
          string field = xmlWidget2.getField();
          if (xmlWidget2 == null || field == null)
            return false;
          if (String.instancehelper_equals(field, (object) name))
            return true;
        }
      }
      return false;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u0024000([In] SmartDashboardXMLReader obj0, [In] NodeList obj1)
    {
      obj0.load(obj1);
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static bool access\u0024102([In] SmartDashboardXMLReader obj0, [In] bool obj1)
    {
      int num1 = obj1 ? 1 : 0;
      SmartDashboardXMLReader dashboardXmlReader1 = obj0;
      int num2 = num1;
      SmartDashboardXMLReader dashboardXmlReader2 = dashboardXmlReader1;
      int num3 = num2;
      dashboardXmlReader2.finishedReading = num2 != 0;
      return num3 != 0;
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 110, (byte) 119, (byte) 126, (byte) 109, (byte) 102, (byte) 106, (byte) 112, (byte) 121, (byte) 120, (byte) 121, (byte) 117, (byte) 121, (byte) 243, (byte) 58, (byte) 235, (byte) 74, (byte) 135, (byte) 110, (byte) 113, (byte) 127, (byte) 3, (byte) 102, (byte) 112, (byte) 145, (byte) 122, (byte) 151, (byte) 122, (byte) 245, (byte) 58, (byte) 235, (byte) 74, (byte) 111, (byte) 127, (byte) 5, (byte) 127, (byte) 10, (byte) 127, (byte) 0, (byte) 127, (byte) 10, (byte) 127, (byte) 3, (byte) 112, (byte) 102, (byte) 113, (byte) 122, (byte) 114, (byte) 122, (byte) 240, (byte) 60, (byte) 235, (byte) 71, (byte) 104, (byte) 138, (byte) 127, (byte) 8, (byte) 107, (byte) 103, (byte) 112, (byte) 112, (byte) 113, (byte) 122, (byte) 122, (byte) 122, (byte) 119, (byte) 122, (byte) 245, (byte) 58, (byte) 235, (byte) 73, (byte) 127, (byte) 21, (byte) 113, (byte) 117, (byte) 113, (byte) 102, (byte) 112, (byte) 113, (byte) 127, (byte) 0, (byte) 119, (byte) 127, (byte) 0, (byte) 245, (byte) 60, (byte) 235, (byte) 71, (byte) 112, (byte) 115, (byte) 127, (byte) 8, (byte) 110, (byte) 255, (byte) 6, (byte) 48, (byte) 235, (byte) 83, (byte) 159, (byte) 117, (byte) 123, (byte) 239, (byte) 159, (byte) 187, (byte) 235, (byte) 160, (byte) 72, (byte) 127, (byte) 5, (byte) 141, (byte) 127, (byte) 1, (byte) 109, (byte) 109, (byte) 121, (byte) 25, (byte) 232, (byte) 69, (byte) 127, (byte) 1, (byte) 109, (byte) 102, (byte) 112, (byte) 121, (byte) 113, (byte) 121, (byte) 239, (byte) 60, (byte) 235, (byte) 71, (byte) 104, (byte) 240, (byte) 159, (byte) 144, (byte) 233, (byte) 160, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void load([In] NodeList obj0)
    {
      for (int index1 = 0; index1 < obj0.getLength(); ++index1)
      {
        if (String.instancehelper_equals(obj0.item(index1).getNodeName(), (object) "widget") || String.instancehelper_equals(obj0.item(index1).getNodeName(), (object) "static-widget"))
        {
          NamedNodeMap attributes1 = obj0.item(index1).getAttributes();
          XMLWidget xmlWidget1 = new XMLWidget();
          System.get_out().println();
          for (int index2 = 0; index2 < attributes1.getLength(); ++index2)
          {
            if (String.instancehelper_equals(attributes1.item(index2).getNodeName(), (object) "field"))
              xmlWidget1.setField(attributes1.item(index2).getNodeValue());
            else if (String.instancehelper_equals(attributes1.item(index2).getNodeName(), (object) "class"))
              xmlWidget1.setClass(attributes1.item(index2).getNodeValue());
            else if (String.instancehelper_equals(attributes1.item(index2).getNodeName(), (object) "type"))
              xmlWidget1.setType(attributes1.item(index2).getNodeValue());
          }
          TreeMap treeMap = new TreeMap();
          NodeList childNodes1 = obj0.item(index1).getChildNodes();
          for (int index2 = 0; index2 < childNodes1.getLength(); ++index2)
          {
            if (String.instancehelper_equals(String.instancehelper_trim(childNodes1.item(index2).getNodeName()), (object) "location"))
            {
              int num1 = 0;
              int num2 = 0;
              NamedNodeMap attributes2 = childNodes1.item(index2).getAttributes();
              for (int index3 = 0; index3 < attributes2.getLength(); ++index3)
              {
                if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "x"))
                  num1 = Integer.parseInt(attributes2.item(index3).getNodeValue());
                else if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "y"))
                  num2 = Integer.parseInt(attributes2.item(index3).getNodeValue());
              }
              xmlWidget1.setLocation(new Point(num1, num2));
            }
            else if (String.instancehelper_equals(String.instancehelper_trim(childNodes1.item(index2).getNodeName()), (object) "width"))
              xmlWidget1.setWidth(Integer.parseInt(childNodes1.item(index2).getChildNodes().item(0).getNodeValue()));
            else if (String.instancehelper_equals(String.instancehelper_trim(childNodes1.item(index2).getNodeName()), (object) "height"))
              xmlWidget1.setHeight(Integer.parseInt(childNodes1.item(index2).getChildNodes().item(0).getNodeValue()));
            else if (String.instancehelper_equals(String.instancehelper_trim(childNodes1.item(index2).getNodeName()), (object) "property"))
            {
              NamedNodeMap attributes2 = childNodes1.item(index2).getAttributes();
              string name = (string) null;
              string str = (string) null;
              for (int index3 = 0; index3 < attributes2.getLength(); ++index3)
              {
                if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "name"))
                  name = attributes2.item(index3).getNodeValue();
                else if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "value"))
                  str = attributes2.item(index3).getNodeValue();
              }
              if (name != null && str != null)
                xmlWidget1.addProperty(name, str);
            }
            else if (String.instancehelper_equals(String.instancehelper_trim(childNodes1.item(index2).getNodeName()), (object) "widget"))
            {
              LWSubsystem.setLoaded(this.self);
              XMLWidget xmlWidget2 = new XMLWidget();
              NamedNodeMap attributes2 = childNodes1.item(index2).getAttributes();
              NodeList childNodes2 = childNodes1.item(index2).getChildNodes();
              for (int index3 = 0; index3 < attributes2.getLength(); ++index3)
              {
                if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "field"))
                  xmlWidget2.setField(attributes2.item(index3).getNodeValue());
                else if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "class"))
                  xmlWidget2.setClass(attributes2.item(index3).getNodeValue());
                else if (String.instancehelper_equals(attributes2.item(index3).getNodeName(), (object) "type"))
                  xmlWidget2.setType(attributes2.item(index3).getNodeValue());
              }
              System.get_out().println(new StringBuilder().append("\nLoading subwidget \"").append(xmlWidget2.getField()).append("\"").toString());
              for (int index3 = 0; index3 < childNodes2.getLength(); ++index3)
              {
                string str = String.instancehelper_trim(childNodes2.item(index3).getNodeName());
                if (String.instancehelper_equals(str, (object) "location"))
                {
                  int num1 = 0;
                  int num2 = 0;
                  NamedNodeMap attributes3 = childNodes2.item(index3).getAttributes();
                  for (int index4 = 0; index4 < attributes3.getLength(); ++index4)
                  {
                    if (String.instancehelper_equals(String.instancehelper_trim(attributes3.item(index4).getNodeName()), (object) "x"))
                      num1 = Integer.parseInt(attributes3.item(index4).getNodeValue());
                    else if (String.instancehelper_equals(String.instancehelper_trim(attributes3.item(index4).getNodeName()), (object) "y"))
                      num2 = Integer.parseInt(attributes3.item(index4).getNodeValue());
                  }
                  xmlWidget2.setLocation(new Point(num1, num2));
                }
                else if (String.instancehelper_equals(str, (object) "height"))
                  xmlWidget2.setHeight(Integer.parseInt(childNodes2.item(index3).getChildNodes().item(0).getNodeValue()));
                else if (String.instancehelper_equals(str, (object) "width"))
                  xmlWidget2.setWidth(Integer.parseInt(childNodes2.item(index3).getChildNodes().item(0).getNodeValue()));
              }
              System.get_out().println(new StringBuilder().append("\tLocation: [").append((int) xmlWidget2.getLocation().x).append(",").append((int) xmlWidget2.getLocation().y).append("]").append("\n\tSize: (").append((int) xmlWidget2.getSize().width).append(",").append((int) xmlWidget2.getSize().height).append(")").toString());
              ((Map) treeMap).put((object) Integer.valueOf((int) xmlWidget2.getLocation().y), (object) xmlWidget2);
              this.subsystems.put((object) xmlWidget1, (object) treeMap);
            }
          }
          string elementClass = xmlWidget1.getElementClass();
          object obj = (object) "livewindow.elements";
          CharSequence charSequence1;
          charSequence1.__\u003Cref\u003E = (__Null) obj;
          CharSequence charSequence2 = charSequence1;
          if (!String.instancehelper_contains(elementClass, charSequence2))
            this.widgets.add((object) xmlWidget1);
        }
        else if (String.instancehelper_equals(obj0.item(index1).getNodeName(), (object) "hidden"))
        {
          NamedNodeMap attributes = obj0.item(index1).getAttributes();
          for (int index2 = 0; index2 < attributes.getLength(); ++index2)
          {
            if (String.instancehelper_equals(attributes.item(index2).getNodeName(), (object) "field"))
              this.hiddenFields.add((object) attributes.item(index2).getNodeValue());
          }
        }
        else if (String.instancehelper_equals(obj0.item(index1).getNodeName(), (object) "property"))
        {
          NamedNodeMap attributes = obj0.item(index1).getAttributes();
          string str1 = (string) null;
          string str2 = (string) null;
          for (int index2 = 0; index2 < attributes.getLength(); ++index2)
          {
            if (String.instancehelper_equals(attributes.item(index2).getNodeName(), (object) "name"))
              str1 = attributes.item(index2).getNodeValue();
            else if (String.instancehelper_equals(attributes.item(index2).getNodeName(), (object) "value"))
              str2 = attributes.item(index2).getNodeValue();
          }
          if (str1 != null && str2 != null)
            this.properties.put((object) str1, (object) str2);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 136, (byte) 186, (byte) 2, (byte) 97, (byte) 102, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void waitToFinish()
    {
      while (!this.finishedReading)
      {
        InterruptedException interruptedException;
        try
        {
          Thread.sleep(25L);
          continue;
        }
        catch (InterruptedException ex)
        {
          int num = 1;
          interruptedException = (InterruptedException) ByteCodeHelper.MapException<InterruptedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        Throwable.instancehelper_printStackTrace((Exception) interruptedException);
      }
    }

    public virtual bool isFinishedReading()
    {
      return this.finishedReading;
    }

    [InnerClass]
    [SourceFile("SmartDashboardXMLReader.java")]
    [Modifiers]
    internal sealed class ReaderThread : Thread
    {
      internal File xmlFile;
      [Modifiers]
      internal SmartDashboardXMLReader this\u00240;

      [HideFromJava]
      static ReaderThread()
      {
        Thread.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 111, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ReaderThread([In] SmartDashboardXMLReader obj0, [In] string obj1)
      {
        base.\u002Ector();
        SmartDashboardXMLReader.ReaderThread readerThread = this;
        this.xmlFile = new File(obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 134, (byte) 103, (byte) 109, (byte) 139, (byte) 108, (byte) 141, (byte) 113, (byte) 162, (byte) 119, (byte) 255, (byte) 19, (byte) 69, (byte) 226, (byte) 61, (byte) 98, (byte) 127, (byte) 10, (byte) 167, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void run()
      {
        Exception exception1;
        try
        {
          Document document = DocumentBuilderFactory.newInstance().newDocumentBuilder().parse(this.xmlFile);
          ((Node) document.getDocumentElement()).normalize();
          NodeList elementsByTagName1 = document.getElementsByTagName("dashboard");
          NodeList elementsByTagName2 = document.getElementsByTagName("live-window");
          if (elementsByTagName1.getLength() == 0 && elementsByTagName2.getLength() == 0)
            return;
          SmartDashboardXMLReader.access\u0024000(this.this\u00240, elementsByTagName1.item(0).getChildNodes());
          SmartDashboardXMLReader.access\u0024000(this.this\u00240, elementsByTagName2.item(0).getChildNodes());
          goto label_7;
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
            throw;
          else
            exception1 = (Exception) m0;
        }
        Exception exception2 = exception1;
        System.get_out().println(new StringBuilder().append("Error while reading ").append((object) this.xmlFile).toString());
        Throwable.instancehelper_printStackTrace((Exception) exception2);
label_7:
        SmartDashboardXMLReader.access\u0024102(this.this\u00240, true);
      }
    }
  }
}
