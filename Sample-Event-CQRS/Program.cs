// See https://aka.ms/new-console-template for more information
using System.Reflection;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

using Notification_Event_MediatR.Event;

var serviceCollection = new ServiceCollection()
    .AddMediatR(Assembly.GetExecutingAssembly())
    .BuildServiceProvider();

var mediator = serviceCollection.GetRequiredService<IMediator>();

await mediator.Publish(new MessageNotification()
{
    Email = "youre Email",
    Message = "message"
});
