﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _01_MyAsmBuilder
{
  class Program
  {
    public static void CreateMyAsm(AppDomain curAppDomain)
    {
      // Установить общие характеристики сборки
      AssemblyName assemblyName = new AssemblyName
      {
        Name = "MyAssembly",
        Version = new Version("1.0.0.0")
      };

      // Создать новую сборку в текущем домене
      AssemblyBuilder assembly = curAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
      ModuleBuilder module = assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");

      // Определить открытый класс по имени HelloWorld
      TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", TypeAttributes.Public);

      // Определить закрытую переменную-член типа String по имени theMessage
      FieldBuilder msgField = helloWorldClass.DefineField("theMessage", Type.GetType("System.String"),
        FieldAttributes.Private);

      // Создать специальный конструктор
      Type[] constructorArgs = new Type[1];
      constructorArgs[0] = typeof (string);
      ConstructorBuilder constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public,
        CallingConventions.Standard, constructorArgs);
      ILGenerator constructorIL = constructor.GetILGenerator();
      constructorIL.Emit(OpCodes.Ldarg_0);
      Type objectClass = typeof (object);
      ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
      constructorIL.Emit(OpCodes.Call, superConstructor);
      constructorIL.Emit(OpCodes.Ldarg_0);
      constructorIL.Emit(OpCodes.Ldarg_1);
      constructorIL.Emit(OpCodes.Stfld, msgField);
      constructorIL.Emit(OpCodes.Ret);

      // Создать стандартный конструктор
      helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);
      // Создать метод GetMsg()
      MethodBuilder getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, typeof (string), null);
      ILGenerator methodIL = getMsgMethod.GetILGenerator();
      methodIL.Emit(OpCodes.Ldarg_0);
      methodIL.Emit(OpCodes.Ldfld, msgField);
      methodIL.Emit(OpCodes.Ret);

      // Создать метод SayHello()
      MethodBuilder sayHiMethod = helloWorldClass.DefineMethod("SayHello", MethodAttributes.Public, null, null);
      methodIL = sayHiMethod.GetILGenerator();
      methodIL.EmitWriteLine("Hello from HelloWorld class");
      methodIL.Emit(OpCodes.Ret);

      // Построить класс HelloWorld
      helloWorldClass.CreateType();
      // Сохранить сборку в файле
      assembly.Save("MyAssembly.dll");

    }
  }
}
