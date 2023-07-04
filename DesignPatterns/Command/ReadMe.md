## COMMAND (Команда)
The "Command" pattern allows you to encapsulate a request to perform a specific action as a separate object. This action request object is called a command. In this case, the objects that initiate requests to perform an action are separated from the objects that perform this action.

Commands may use parameters that pass information associated with the command. In addition, commands can be queued and can also be cancelled.

![Screenshot](Command.png)

## When the chain of responsibility applies:
* When it is necessary to pass as parameters certain actions that are called in response to other actions. That is, when you need callback functions in response to certain actions.
* When it is necessary to ensure the execution of the queue of requests, as well as their possible cancellation.
* When it is necessary to support logging of changes as a result of requests.
Using logs can help restore the state of the system - for this it will be necessary to use a sequence of logged commands.

## Participants according to the diagram:

###Command:
An interface that represents a command. Usually defines an Execute() method to execute an action, and often also includes an Undo() method,
whose implementation should be to cancel the action of the command

### ConcreteCommand:
The concrete implementation of the command, implements the Execute() method, in which a specific method is called, defined in the Receiver class

### Receiver:
command recipient. Defines the actions to be taken as a result of the request.

### Invoker:
Command initiator - invokes a command to perform a specific request

###Client:
Client - creates a command and sets its recipient using the SetCommand() method

Thus, the initiator sending the request does not know anything about the recipient, who will execute the command.
In addition, if we need to apply some new commands, we can simply inherit classes from the abstract Command class and implement its Execute and Undo methods.

Commands are widely used in C# programs. So, in WPF technology and other technologies that use XAML and the MVVM approach,
User interaction is largely based on commands. In some architectures, such as the CQRS architecture, instructions are one of the key components.

Often, control panels or interface buttons act as the initiator of commands. The simplest situation is to programmatically organize the switching on and off of a device, for example, a TV.
