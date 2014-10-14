// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.categories.Categories
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.annotation;
using java.util;
using org.junit.runner;
using org.junit.runner.manipulation;
using org.junit.runners;
using org.junit.runners.model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.categories
{
  public class Categories : Suite
  {
    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;Lorg/junit/runners/model/RunnerBuilder;)V")]
    [LineNumberTable(new byte[] {(byte) 90, (byte) 138, (byte) 223, (byte) 17, (byte) 2, (byte) 97, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Categories(Class klass, RunnerBuilder builder)
      : base(klass, builder)
    {
      Categories categories = this;
      NoTestsRemainException testsRemainException1;
      try
      {
        Categories.CategoryFilter.__\u003Cclinit\u003E();
        this.filter((org.junit.runner.manipulation.Filter) new Categories.CategoryFilter(this.getIncludedCategory(klass), this.getExcludedCategory(klass)));
        return;
      }
      catch (NoTestsRemainException ex)
      {
        int num = 1;
        testsRemainException1 = (NoTestsRemainException) ByteCodeHelper.MapException<NoTestsRemainException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      NoTestsRemainException testsRemainException2 = testsRemainException1;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new InitializationError((Exception) testsRemainException2);
    }

    [Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 100, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Class getIncludedCategory([In] Class obj0)
    {
      Categories.IncludeCategory ncludeCategory = (Categories.IncludeCategory) obj0.getAnnotation((Class) ClassLiteral<Categories.IncludeCategory>.Value);
      return ncludeCategory != null ? ncludeCategory.value() : (Class) null;
    }

    [Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 105, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Class getExcludedCategory([In] Class obj0)
    {
      Categories.ExcludeCategory excludeCategory = (Categories.ExcludeCategory) obj0.getAnnotation((Class) ClassLiteral<Categories.ExcludeCategory>.Value);
      return excludeCategory != null ? excludeCategory.value() : (Class) null;
    }

    [InnerClass]
    [SourceFile("Categories.java")]
    public class CategoryFilter : org.junit.runner.manipulation.Filter
    {
      [Modifiers]
      [Signature("Ljava/lang/Class<*>;")]
      private Class fIncluded;
      [Modifiers]
      [Signature("Ljava/lang/Class<*>;")]
      private Class fExcluded;

      [HideFromJava]
      static CategoryFilter()
      {
        org.junit.runner.manipulation.Filter.__\u003Cclinit\u003E();
      }

      [Signature("(Ljava/lang/Class<*>;Ljava/lang/Class<*>;)V")]
      [LineNumberTable(new byte[] {(byte) 35, (byte) 104, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CategoryFilter(Class includedCategory, Class excludedCategory)
      {
        Categories.CategoryFilter categoryFilter = this;
        this.fIncluded = includedCategory;
        this.fExcluded = excludedCategory;
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 56, (byte) 104, (byte) 104, (byte) 109, (byte) 123, (byte) 118, (byte) 100, (byte) 123, (byte) 118, (byte) 100})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool hasCorrectCategoryAnnotation([In] Description obj0)
      {
        List list = this.categories(obj0);
        if (list.isEmpty())
        {
          return this.fIncluded == null;
        }
        else
        {
          Iterator iterator1 = list.iterator();
          while (iterator1.hasNext())
          {
            if (this.fExcluded != null && this.fExcluded.isAssignableFrom((Class) iterator1.next()))
              return false;
          }
          Iterator iterator2 = list.iterator();
          while (iterator2.hasNext())
          {
            if (this.fIncluded == null || this.fIncluded.isAssignableFrom((Class) iterator2.next()))
              return true;
          }
          return false;
        }
      }

      [LineNumberTable(new byte[] {(byte) 47, (byte) 105, (byte) 98, (byte) 127, (byte) 1, (byte) 105, (byte) 100})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool shouldRun(Description description)
      {
        if (this.hasCorrectCategoryAnnotation(description))
          return true;
        Iterator iterator = description.getChildren().iterator();
        while (iterator.hasNext())
        {
          if (this.shouldRun((Description) iterator.next()))
            return true;
        }
        return false;
      }

      [Signature("(Lorg/junit/runner/Description;)Ljava/util/List<Ljava/lang/Class<*>;>;")]
      [LineNumberTable(new byte[] {(byte) 69, (byte) 102, (byte) 115, (byte) 121})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private List categories([In] Description obj0)
      {
        ArrayList arrayList = new ArrayList();
        arrayList.addAll((Collection) Arrays.asList((object[]) this.directCategories(obj0)));
        arrayList.addAll((Collection) Arrays.asList((object[]) this.directCategories(this.parentDescription(obj0))));
        return (List) arrayList;
      }

      [Signature("(Lorg/junit/runner/Description;)[Ljava/lang/Class<*>;")]
      [LineNumberTable(new byte[] {(byte) 81, (byte) 113, (byte) 99, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Class[] directCategories([In] Description obj0)
      {
        Category category = (Category) obj0.getAnnotation((Class) ClassLiteral<Category>.Value);
        if (category == null)
          return new Class[0];
        return category.value();
      }

      [LineNumberTable((ushort) 127)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Description parentDescription([In] Description obj0)
      {
        return Description.createSuiteDescription(obj0.getTestClass());
      }

      [Signature("(Ljava/lang/Class<*>;)Lorg/junit/experimental/categories/Categories$CategoryFilter;")]
      [LineNumberTable((ushort) 77)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Categories.CategoryFilter include(Class categoryType)
      {
        return new Categories.CategoryFilter(categoryType, (Class) null);
      }

      [LineNumberTable((ushort) 92)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string describe()
      {
        return new StringBuilder().append("category ").append((object) this.fIncluded).toString();
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.annotation.Annotation"})]
    [SourceFile("Categories.java")]
    [Modifiers]
    [AnnotationAttribute("org.junit.experimental.categories.Categories+ExcludeCategoryAttribute")]
    [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
    public interface ExcludeCategory : Annotation
    {
      [Signature("()Ljava/lang/Class<*>;")]
      Class value();
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.annotation.Annotation"})]
    [SourceFile("Categories.java")]
    [Modifiers]
    [AnnotationAttribute("org.junit.experimental.categories.Categories+IncludeCategoryAttribute")]
    [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
    public interface IncludeCategory : Annotation
    {
      [Signature("()Ljava/lang/Class<*>;")]
      Class value();
    }

    [Modifiers]
    [InnerClass]
    [Implements(new string[] {"org.junit.experimental.categories.Categories$ExcludeCategory"})]
    public sealed class ExcludeCategoryAttribute : AnnotationAttributeBase, Categories.ExcludeCategory
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ExcludeCategoryAttribute([In] object[] obj0)
        : this()
      {
        this.setDefinition(obj0);
      }

      private ExcludeCategoryAttribute()
      {
        base.\u002Ector((Class) ClassLiteral<Categories.ExcludeCategory>.Value);
      }

      [HideFromJava]
      public ExcludeCategoryAttribute(Type value)
        : this()
      {
        this.setValue("value", (object) value);
      }

      Class Categories.ExcludeCategory.value()
      {
        return (Class) this.getValue("value");
      }
    }

    [Modifiers]
    [InnerClass]
    [Implements(new string[] {"org.junit.experimental.categories.Categories$IncludeCategory"})]
    public sealed class IncludeCategoryAttribute : AnnotationAttributeBase, Categories.IncludeCategory
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      public IncludeCategoryAttribute([In] object[] obj0)
        : this()
      {
        this.setDefinition(obj0);
      }

      private IncludeCategoryAttribute()
      {
        base.\u002Ector((Class) ClassLiteral<Categories.IncludeCategory>.Value);
      }

      [HideFromJava]
      public IncludeCategoryAttribute(Type value)
        : this()
      {
        this.setValue("value", (object) value);
      }

      Class Categories.IncludeCategory.value()
      {
        return (Class) this.getValue("value");
      }
    }
  }
}
