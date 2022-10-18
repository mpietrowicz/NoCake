using NoCake.Core.Abstract;
using NoCake.Core.Providers;
using StrongInject;

namespace NoCake.Core;

[Register(typeof(ParameterProvider), Scope.SingleInstance, typeof(IParameterProvider))]
[Register(typeof(App),typeof(IApp))]
public partial class NoCakeContainer : IContainer<IApp> {}