
Thread.Sleep & Thread.Yield

正如Eric Lippert在封面博客中所解释的，同时演示了如何实现锁定 源代码

.NET Framework为您提供了多种工具，可用于构建更复杂的等待策略：Thread.SpinWait将处理器置于紧密循环中，允许您等待几纳秒或几微秒而无需将控制权交给另一个线程。Thread.Sleep（0）将控制权交给任何具有相同优先级的就绪线程，或者如果没有，则继续保持当前线程。Thread.Yield将控制权交给与当前处理器关联的任何就绪线程。正如我们所见，Thread.Sleep（1）将控制权交给操作系统选择的任何就绪线程。通过仔细选择这些调用的混合并在实际条件下进行性能测试，您可以构建高性能实现，当然这也是CLR团队实际完成的工作。