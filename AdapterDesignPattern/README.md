# **What is Adapter Design Pattern?**

The Adapter design pattern is one of the most common and useful structural design patterns. It allows objects with incompatible interfaces to collaborate with each other. This design pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.

In the above image, on the right-hand side, we have a third-party Analytics library that consumes data in JSON format, and on the left-hand side, we have a client application that generates stock data in XML format. We can easily see that these two systems are incompatible and that’s why we have an XML to JSON Adapter in the middle that can facilitate the communication between these two systems.

The Adapter Design Pattern is composed of the following components:

Client: A class that wants to consume an incompatible third-party application.
Target: An interface that needs to be implemented by the Adapter and used by the client. The client class can see only this interface and don’t directly communicate with third party application.
Adapter: A class that makes two incompatible systems work together. The Adapter class implements the Target interface also has the reference to the Adaptee object.
Adaptee: A class that contains the functionality requires by the client but it’s not compatible with the existing client code. This class needs to be adopted by the adapter before the client can use it. In simple words, the client will call the Adapter and the Adapter will do the conversion if required and then it will make a call to the Adaptee.

# **Pros and Cons of Adapter Pattern**

## Pros:

- It encourages the Single Responsibility Principal because we can separate the conversion code from the primary business logic of the program.
- It increases the transparency and reusability of the class because the specific implementation is encapsulated in the adapter class which is transparent to the client class.
- We can introduce new types of adapters without breaking the existing client code.

## Cons:

- Too many adapters make the system messy and difficult to understand and navigate as a whole.

# **Implementing Adapter Pattern using Object Adapter**

Using this technique, the Adapter class implements the Target interface but doesn’t inherit the Adaptee class. The Adaptee object is passed into the constructor of the Adapter class. The Adapter class then perform all the conversions and used the Adaptee object to delegate all requests to Adaptee. The main advantage of implementing an adapter pattern using the Object Adapter technique is that you can implement (adapt) multiple adapters to the same target.

Let’s learn more about the Object Adapter pattern by implementing a complete example. In this example, I will create two separate classes which are not compatible with each other, and then we will introduce an adapter in the middle of these two classes to facilitate communication.

# **Summary**

The Builder pattern lets you construct composite trees or other complex objects step by step, using only those steps that you really need. This makes our code very easy to understand and maintain. I hope you have found this post useful. If you have any comments or suggestions, please leave your comments below. Don’t forget to share this tutorial with your friends or community.
