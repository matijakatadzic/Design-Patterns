**What is a Builder Pattern?**
Builder Design Pattern allows us to separate the construction of a complex object from its representation so that we can use the same construction code to produce different types and representations of an object. It is used to construct a complex object step by step and return the complete object after the final step.

**Pros and Cons of Builder Pattern**

Pros:

- By constructing the object using a step by step approach, you can construct run the steps in a different order for creating a different types of products. You can defer some steps or even run some steps recursively.
- The same construction code can be reused to build various representations of the products.
- The code of creating complex objects can be separated from the business logic which increases code readability and maintainability
- You don’t need to create big constructors with so many parameters to create complex objects.
- 
Cons:

- You need to create many new classes which increase the overall complexity of the code.
- You need to create a separate ConcreteBuilder for each type of product.

**Summary**

The Builder pattern lets you construct composite trees or other complex objects step by step, using only those steps that you really need. This makes our code very easy to understand and maintain. I hope you have found this post useful. If you have any comments or suggestions, please leave your comments below. Don’t forget to share this tutorial with your friends or community.
