// Decompiled with JetBrains decompiler
// Type: junit.framework.JUnit4TestAdapterCache
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.junit.runner;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace junit.framework
{
  [Signature("Ljava/util/HashMap<Lorg/junit/runner/Description;Ljunit/framework/Test;>;")]
  [Serializable]
  public class JUnit4TestAdapterCache : HashMap
  {
    [Modifiers]
    private static JUnit4TestAdapterCache fInstance = new JUnit4TestAdapterCache();
    private const long serialVersionUID = 1L;

    [LineNumberTable((ushort) 18)]
    static JUnit4TestAdapterCache()
    {
    }

    [LineNumberTable((ushort) 16)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit4TestAdapterCache()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected JUnit4TestAdapterCache([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public static JUnit4TestAdapterCache getDefault()
    {
      return JUnit4TestAdapterCache.fInstance;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 102, (byte) 237, (byte) 82})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RunNotifier getNotifier(TestResult result, JUnit4TestAdapter adapter)
    {
      RunNotifier runNotifier = new RunNotifier();
      runNotifier.addListener((RunListener) new JUnit4TestAdapterCache\u00241(this, result));
      return runNotifier;
    }

    [Signature("(Lorg/junit/runner/Description;)Ljava/util/List<Ljunit/framework/Test;>;")]
    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 152, (byte) 102, (byte) 127, (byte) 1, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List asTestList(Description description)
    {
      if (description.isTest())
      {
        Test[] testArray = new Test[1];
        int index = 0;
        Test test = this.asTest(description);
        testArray[index] = test;
        return Arrays.asList((object[]) testArray);
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        Iterator iterator = description.getChildren().iterator();
        while (iterator.hasNext())
        {
          Description description1 = (Description) iterator.next();
          ((List) arrayList).add((object) this.asTest(description1));
        }
        return (List) arrayList;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 104, (byte) 138, (byte) 105, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Test asTest(Description description)
    {
      if (description.isSuite())
      {
        return this.createTest(description);
      }
      else
      {
        if (!this.containsKey((object) description))
          this.put((object) description, (object) this.createTest(description));
        return (Test) this.get((object) description);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 104, (byte) 137, (byte) 108, (byte) 127, (byte) 1, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual Test createTest([In] Description obj0)
    {
      if (obj0.isTest())
      {
        return (Test) new JUnit4TestCaseFacade(obj0);
      }
      else
      {
        TestSuite testSuite = new TestSuite(obj0.getDisplayName());
        Iterator iterator = obj0.getChildren().iterator();
        while (iterator.hasNext())
        {
          Description description = (Description) iterator.next();
          testSuite.addTest(this.asTest(description));
        }
        return (Test) testSuite;
      }
    }
  }
}
