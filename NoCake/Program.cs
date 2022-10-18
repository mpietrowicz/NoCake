using System.ComponentModel;
using NoCake;
using NoCake.Core;
using NoCake.Core.Abstract;

using var ownedOfA = new NoCakeContainer().Resolve<IApp>();
await ownedOfA.Value.Run(args);
