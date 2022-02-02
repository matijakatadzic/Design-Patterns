# **What is a Decorator Pattern?**

The decorator pattern (also known as Wrapper) is a structural design pattern and it allows developers to dynamically add new behaviors and features to existing classes without modifying them thus respecting the open-closed principle. This pattern lets you structure your business logic into layers (wrappers) in a way that each layer adds some additional behavior or functionality to an existing object, promoting separation of concern. Furthermore, these layers can be added or removed at runtime and clients can also use the different combinations of decorators to be attached to an existing object.



## **Pros of Decorator Pattern**
- We can extend an object’s behavior without creating a hierarchy of new child classes.
- We can add or remove features from an object at runtime which gives developer flexibility not available in simple inheritance.
- We can combine several features by wrapping an object into multiple decorators
- We can divide a complex object into several smaller classes with specific behaviors which promotes the Single Responsibility Principle
- It supports the Open-closed principle which states that the classes should be open for extension but closed for modification.
## **Cons of Decorator Pattern**
- The object instantiation can be complex as we have to create an object by wrapping it in several decorators.
- Sometimes, it’s hard to keep track of the full wrapper stack, and removing a specific wrapper from the stack is not something easy to achieve.
- Decorators can cause issues if the client using them relies heavily on the object concrete type.

# **Summary**

The decorator pattern can be used to extend classes or to add cross-cutting concerns without changing their code. In this post, we learned how to use the decorator pattern to add features such as logging and caching in ASP.NET Core web applications. We also learn how to register decorators manually and using the Scrutor library. In the end, we learned how to dynamically enable/disable decorators based on environment or configuration settings. I hope, you will keep the decorator pattern in mind for certain use cases while developing your applications.
