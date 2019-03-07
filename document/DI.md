
>  SOLID（单一功能、开闭原则、里氏替换、接口隔离以及依赖反转） SOLID (面向对象设计) 

what is ioc:
	
	控制注入，是一种设计模式

the benefits of using this:
	
	降低耦合度

> 什么是DI

	什么是依赖？

	当一个类需要另一个类协作来完成工作的时候就产生了依赖

	例如：在日志处理类中，需要将日志写入数据库，这是就需要一个写入数据库的相关类，从而就产生了依赖

	按照抽象设计:
	LogContext -> IWriteLog -> WriteDbLog

	什么是注入？
	依旧是上面那个例子，既然产生了依赖，就需要获得这个依赖的对象

	step1：在LogContext定义一个 IWriteLog 的属性
	step2: 在构造函数中直接实例化这个属性 - 
		考虑到业务变动，你不应该自己创建它而是应该由你的调用者给你
	(2) step2:在构造函数中定义相应的参数，让调用者传入
		把依赖的创建丢给其它人，自己只负责使用，

	其它人丢给你依赖的这个过程理解为注入。
		
	什么是反转?
		本应该由LogContext控制依赖的实现，但却由调用者注入，就产生了反转

	什么是容器？
		为什么要用容器？
			上面这种情况控制是反转了，依赖的创建也移交到了外部。
			但若是程序中存在100个这种地方，岂不是在100个地方进行注入，依赖太多，也不便于进行管理

		所以需要一个地方统一管理系统中所有的依赖，这便是容器的诞生

	容器负责两件事情：
		• 绑定服务与实例之间的关系
		• 获取实例，并对实例进行管理（创建与销毁）

	为什么要使用DI？
		以上例为说明
			不使用DI时：
				1.增加耦合度，日志的处理在日志中写入，当需要写入数据库时，会增加数据库相关的依赖，当写入磁盘时，又会增加磁盘的相关依赖
				2.增加维护成本，当一个类的内容涉及过广时，很难察觉到真正需要关注的地方。
			使用DI时：
				1.降低耦合，一层依赖(抽象依赖),简单易用，降低耦合
				2.降低维护成本，调整写入数据库逻辑，便只需要关注写入数据库的内容，调整写入磁盘也是如此
				3.便于扩展，当调整写入缓存时，只需外部更改注入类，无效考虑日志处理类的做法
	

for example:
	
![](https://i.imgur.com/O5kyWaD.png)

> 图解

#### 常见场景 ####
	
	request --> UI层 --> response
	
	小型UI层:
		获取dal/dbcontext
		执行操作

	三层UI业务:
		获取 service
			获取service关联的dal
		执行操作
	
	多层业务:
		获取 service
			获取上述关联层实例
			获取上述关联层实例
			获取上述关联层实例...
		执行操作

### flow ###

> 未使用IOC vs 使用了IOC

	<IOC>
	1. UI只与容器关联
	2. 容器与对象之间通过标识关联(通常是泛型type+抽象)
	3. 业务调整时，无需考虑相关层的业务关系，只需维护本层业务
	4. 当业务内容过多时，可以自行建立层级标准来维护标识的准确性
	5. 简单易用,无需考虑过多元素

	<无IOC时>
	1. UI与最低层关联
	2. 最低层与上层层层关联
	3. 业务调整时，应考虑相关层的使用
	4. 当业务内容过多时，阅读业务含义需要访问所有关联层方可理解
	5. 复杂关联，容易出现代码重复，即便抽象也难以维护。。。
	
emm... 总结太多了，熟悉得不能再熟悉了。

----------
author:monster

since:12/11/2018 3:26:09 PM 

direction:ioc