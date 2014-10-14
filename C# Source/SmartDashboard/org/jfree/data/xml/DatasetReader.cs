// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xml.DatasetReader
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using javax.xml.parsers;
using org.jfree.data.category;
using org.jfree.data.general;
using org.xml.sax;
using org.xml.sax.helpers;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.xml
{
  public class DatasetReader : Object
  {
    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DatasetReader()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 38, (byte) 98, (byte) 134, (byte) 103, (byte) 102, (byte) 104, (byte) 255, (byte) 10, (byte) 71, (byte) 226, (byte) 59, (byte) 98, (byte) 209, (byte) 2, (byte) 98, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset readPieDatasetFromXML(InputStream @in)
    {
      PieDataset pieDataset = (PieDataset) null;
      SAXParserFactory saxParserFactory = SAXParserFactory.newInstance();
      SAXException saxException;
      ParserConfigurationException configurationException;
      try
      {
        try
        {
          SAXParser saxParser = saxParserFactory.newSAXParser();
          PieDatasetHandler pieDatasetHandler = new PieDatasetHandler();
          saxParser.parse(@in, (DefaultHandler) pieDatasetHandler);
          pieDataset = pieDatasetHandler.getDataset();
          goto label_6;
        }
        catch (SAXException ex)
        {
          int num = 1;
          saxException = (SAXException) ByteCodeHelper.MapException<SAXException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (ParserConfigurationException ex)
      {
        int num = 1;
        configurationException = (ParserConfigurationException) ByteCodeHelper.MapException<ParserConfigurationException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_5;
      }
      System.get_out().println(saxException.getMessage());
      goto label_6;
label_5:
      System.get_out().println(Throwable.instancehelper_getMessage((Exception) configurationException));
label_6:
      return pieDataset;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 83, (byte) 130, (byte) 134, (byte) 103, (byte) 102, (byte) 104, (byte) 255, (byte) 10, (byte) 71, (byte) 226, (byte) 59, (byte) 98, (byte) 209, (byte) 2, (byte) 98, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryDataset readCategoryDatasetFromXML(InputStream @in)
    {
      CategoryDataset categoryDataset = (CategoryDataset) null;
      SAXParserFactory saxParserFactory = SAXParserFactory.newInstance();
      SAXException saxException;
      ParserConfigurationException configurationException;
      try
      {
        try
        {
          SAXParser saxParser = saxParserFactory.newSAXParser();
          CategoryDatasetHandler categoryDatasetHandler = new CategoryDatasetHandler();
          saxParser.parse(@in, (DefaultHandler) categoryDatasetHandler);
          categoryDataset = categoryDatasetHandler.getDataset();
          goto label_6;
        }
        catch (SAXException ex)
        {
          int num = 1;
          saxException = (SAXException) ByteCodeHelper.MapException<SAXException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (ParserConfigurationException ex)
      {
        int num = 1;
        configurationException = (ParserConfigurationException) ByteCodeHelper.MapException<ParserConfigurationException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_5;
      }
      System.get_out().println(saxException.getMessage());
      goto label_6;
label_5:
      System.get_out().println(Throwable.instancehelper_getMessage((Exception) configurationException));
label_6:
      return categoryDataset;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 22, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset readPieDatasetFromXML(File file)
    {
      return DatasetReader.readPieDatasetFromXML((InputStream) new FileInputStream(file));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 67, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryDataset readCategoryDatasetFromXML(File file)
    {
      return DatasetReader.readCategoryDatasetFromXML((InputStream) new FileInputStream(file));
    }
  }
}
