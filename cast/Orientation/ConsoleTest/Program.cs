﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using ConsoleTest.Entity;
using ConsoleTest.LeetCode;
using ConsoleTest.MiddleQuestion;
using Newtonsoft.Json;
using Tools.RefTools;

namespace ConsoleTest
{
  class Program
  {
    static void Main(string[] args)
    {
      var rand = new Random();
      CodeTimer timer = new CodeTimer();
      timer.Initialize();

      Console.WriteLine("Hello World!");

      Console.ReadKey(true);
    }

    [Obsolete]
    private static void TestInsertIntoBST()
    {
      InsertIntoBST instance = new InsertIntoBST();

      var treeNode = instance.Solution(new TreeNode(4,
        new TreeNode(2, 1, 3),
        7
      ), 5);

      Console.WriteLine(treeNode);
    }

    private static void ConstructMaximumBinaryTreeTest()
    {
      ConstructMaximumBinaryTree instance = new ConstructMaximumBinaryTree();

      var treeNode = instance.Solution(new[] {3, 2, 1, 6, 0, 5});

      Console.WriteLine(treeNode);
    }

    private static void RangeSumBSTTest()
    {
      RangeSumBST instance = new RangeSumBST();

      Console.WriteLine(instance.Solution(new TreeNode(10,
        new TreeNode(5,
          new TreeNode(3), new TreeNode(7)),
        new TreeNode(15,
          null, new TreeNode(18))
      ), 7, 15));

      Console.WriteLine(instance.Solution(new TreeNode(10,
        new TreeNode(5,
          new TreeNode(3, 1, null), new TreeNode(7, 6, null)),
        new TreeNode(15,
          new TreeNode(13), new TreeNode(18))
      ), 6, 10));
    }

    #region empty

    public void Empty()
    {
      //先进后出
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      //返回最后一个 不删除
      Console.WriteLine(stack.Peek());
      Console.WriteLine(stack.Peek());
      //返回最后一个 删除
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Pop());

      //先进先出
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Enqueue(4);

      Console.WriteLine(queue.Dequeue());
      Console.WriteLine(queue.Dequeue());

      Console.WriteLine(queue.Peek());
      Console.WriteLine(queue.Peek());

      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0xF8, 2));
      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 ^ 0xF8, 2));
      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 & 0xF8, 2));
      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 | 0xF8, 2));

      Console.WriteLine((int) 'a');
      Console.WriteLine((int) 'A');

      Console.WriteLine($"{{rand}}");

      var type = typeof(Types);

      var propertyInfos = type.GetProperties();
      var fieldInfos = type.GetFields(BindingFlags.Static | BindingFlags.Public);

      var descriptionAttribute = fieldInfos[1].GetCustomAttribute<DescriptionAttribute>();

      var strings = Enum.GetNames(type);

      var values = Enum.GetValues(type);
    }

    public static dynamic Build<T>(T instance, string[] properties)
    {
      dynamic obj = new System.Dynamic.ExpandoObject();

      var type = typeof(T);

      foreach (var prop in properties)
      {
        var propertyInfo = type.GetProperty(prop);

        if (propertyInfo != null)
        {
          ((IDictionary<string, object>) obj).Add(propertyInfo.Name, propertyInfo.GetValue(instance));
        }
      }

      return obj;
    }

    enum Types
    {
      [Description("正常")] Normal = 0,
      Special = 1,
    }

    private static void EmptyTest()
    {
      var stu = new Student()
      {
        Age = 18,
        ClassId = 1,
        Name = "xxx"
      };

      var result = Build(stu, new[] {nameof(Student.Age), nameof(Student.Name)});

      Console.WriteLine(result.Age);
      Console.WriteLine(result.Name);
    }

    #endregion
  }
}