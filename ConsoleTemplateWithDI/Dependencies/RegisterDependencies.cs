namespace ConsoleTemplateWithDI.Dependencies
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    internal static class RegisterDependencies
    {
        internal static void Register()
        {
            IServiceProvider serviceProvider = new ServiceCollection()
                //.AddSingleton<IChristmasDiscountVisitor, ChristmasDiscountVisitor>()
                //.AddSingleton<IMothersDayDiscountVisitor, MothersDayDiscountVisitor>()
                //.AddSingleton<IDoSomethingElseVisitor, DoSomethingElseVisitor>()
                //.AddSingleton<IVisitor>(s => s.GetRequiredService<IChristmasDiscountVisitor>())
                //.AddSingleton<IVisitor>(s => s.GetRequiredService<IMothersDayDiscountVisitor>())
                //.AddSingleton<IVisitor>(s => s.GetRequiredService<IDoSomethingElseVisitor>())
                .BuildServiceProvider();
        }
    }
}
