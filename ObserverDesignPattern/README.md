# **What is Observer Design Pattern?**

The Observer is a behavioral design pattern and it allows some objects (known as subjects or publishers or observables) to notify other objects (known as observers or subscribers) about the changes in their state.

Following are some key points to remember about the Observer pattern:

- The subject maintains a list of all observers
- The subject can subscribe/unsubscribe observers at runtime.
- The subject notifies all observers when its state change or some event occurs
- The subject and observers are loosely coupled because they have no explicit knowledge of each other.
- New observers can be implemented and used without modifying the subject implementation.

# **When to use Observer Design Pattern?**

The Observer pattern is pretty common in programming languages such as C#, Java, etc. because it provides a neat and well-tested design for applications in which multiple objects are dependent on the state of one object.

Some real-world use cases can be following.

- Social media applications that send notifications to multiple followers/subscribers when a new post is published by any user, group, page, etc.
- Apps marketplace that notifies all users of an app if there is a new update available
- Weather forecasting app that notifies users about weather changes in their area
- Sports-related apps which notify users and other systems about the latest match or score updates
- Ecommerce application that notifies admins or users if any product goes out of stock or notifies users if the product is shipped.
- GUI toolkits and frameworks that allow multiple UI components to respond to events that occurred in other components.

# **How to Implement Observer Design Pattern?**

To show you a real-world implementation of the Observer pattern, I picked a simple use case in which we will perform the following actions.
 
- We will implement multiple observers
- We will implement a subject that will act as a publisher
- We will attach/detach multiple observers with the subject
- We will display a fictitious order on the page
- We will allow the user to update/change the order status
- We will notify all attached observers as soon as the order status is updated
- We will also send the order details from the subject to observers

# **Summary**

The Observer pattern is useful and can be used in situations where one object has to observe another object and need to receive notifications when the state of another object changes. I hope you have found this post useful. If you have any comments or suggestions, please leave your comments below. Don’t forget to share this tutorial with your friends or community.
