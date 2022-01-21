# **What is Observer Design Pattern?**

The strategy pattern (also known as the policy pattern) is a behavioural design pattern that allows us to implement a family of algorithms (strategies) into separate classes and then switch from one algorithm (strategy) to another during runtime. Using this pattern, developers can isolate the code, internal logic, and the dependencies of various algorithms from the rest of the application code which makes the code easy to maintain and easy to scale. This pattern also allows us to alter the behavior of the application at runtime by switching from one algorithm to another algorithm.

# **Pros of Strategy Pattern**
- We can isolate the implementation details of different algorithms from the business logic that uses these algorithms
- We can switch from one algorithm to another at runtime
- We can introduce or replace algorithms without changing the context

# **Cons of Strategy Pattern**
- If you have only a couple of algorithms that rarely change, then you don’t have to overcomplicate your code by introducing new classes and interfaces that come along with this pattern.
- The client needs to know the difference between different strategies to select the most suitable one.

# **Summary**

The Observer pattern is useful and can be used in situations where one object has to observe another object and need to receive notifications when the state of another object changes. I hope you have found this post useful. If you have any comments or suggestions, please leave your comments below. Don’t forget to share this tutorial with your friends or community.
