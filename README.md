# Shipping-Company-Desktop-Application

Our Project is a small model from (MRSOOL), which is a delivery platform that gets the order or  
specifying types of products  from the sender and delivers it to the receiver through the company's trucks and employees. 



## Problem Definition:
Imagine you go to a shipping company to send something to your
friends or family and you find out that the product is sent to another
branch due to wrong address details, late delivery due to the company
not knowing available trucks and drivers, or even your order hasn’t
been shipped yet. This makes an ineffective company that can lead to
company loss, and bad rating. It is important for a shipping company
to have a database management system to organize requests, save
the right customer information, manage and monitor trips, and monitor
bills and money transactions. Making a database will increase the
company efficiency, and make it able to have control of all its assets
and how to improve the company.










## Tech Stack

**Client:** Microsoft .Netframework, [Krypton UI Toolkit](https://github.com/ComponentFactory/Krypton), [BoldReports](https://www.boldreports.com)

**Server:** Azure SQL Database server
<br/>
Database schema was defined using [Datagrip](https://www.jetbrains.com/datagrip/) tool  and hosted onto azure SQL server, canned transactions were done by using stored procedures in SQL server, then the frontend and dealing with the server was done by .NET framework to have a complete solution.



 






## Database Entity-Relationship diagram

![App Screenshot](
Pictures/1.png)

## Screenshots Samples
![App Screenshot]()





## Lessons Learned

- Using SQL intensively and being familiar with SQL syntax and built-in functions
- Using hosting solution (azure)
- How to build software with .NET framework
- Being familiar with C# syntax


## List of system users and privileges of each user:
### Employee.
● Add/Edit user data (sender and receiver)<br/>
● Add product to Branch(product table)<br/>
● View data of sender and receiver<br/>
● Product received (change the status of product)<br/>
● View product details<br/>
● Pay bills<br/>
● Sign in/out<br/>
### Supervisors
● Update price list<br/>
● Add Driver to driver table (Hire driver)<br/>
● Add employees data (Hire employee)<br/>
● Receive the trucks<br/>
● Create trip (assign driver / truck)<br/>
● View available driver/trucks (check if they are<br/>
available to make a trip)<br/>
● Assign products to available trucks<br/>
### Manager
● Update employee table (move them from one branch to another)<br/>
● View all the assets in the company (view all tables in the company )<br/>
● Update salaries (increasing or decreasing salary)<br/>
● Add manager<br/>
● Add supervisors to branches<br/>
● Add trucks to any branch<br/>
● Delete Employees from table (Fire them)<br/>
## List of entities and a brief description for each entity:
● Client: Clients have two types, sender and receiver; sender is the
person who requests to send a product from the branch to another
one, and the receiver is the person who receives the product from the
branch after transportation.<br/>
● Branch: The place where the client goes to send or receive the
product. Also the place where trucks transport products from one to
another.<br/>
● Product: It is the thing that needs to be transported from one branch
to another.<br/>
● Trip: Action of transporting the products where it contains starting
and ending locations, the products in this trip, and the driver driving
the truck.<br/>
● Drivers: People who drive the truck through a trip transporting the
product from one branch to another.<br/>
● Trucks: They contain the products that need to be transported.
Trucks have capacities.<br/>
● Price List: The price of the transportation, calculated according to the
product description(Product weight, product size, …etc), and the type
of transporting(Normal, Vip)<br/>
● Bill: It has the company profit, employees salaries, taxes, …etc.<br/>
● Employee: Employees are three types: normal employee supervisor
and manager; Employee is the one who takes data from the user
when he reaches the branch, he can view data of user and receiver.
Supervisor is the one who is responsible for trips, he checks for
available trucks and drivers and then creates a trip. Finally the
Manager is the one who is the big boss who can access all company
assets, move employees from branch to another and could also fire
them.<br/>
## List of relationships and brief description for each
### relationship:
● WORKS IN:
(employee and branch): Every employee works in one branch
where the branch can take more than one employee.<br/>
● PAY:
(client and employee): The client pays the employee to make
the order employee can deal with many clients<br/>
● CREATE:
(employee and bills):create a bill for the client by checking his
product weight and type, and determine the fees based on the
price list.<br/>
● HAS
(product and trip):each transporting product has trip moving it from
one branch to another
(product and Bill):each product has a bill created by the
employee who is recording the transaction.
(Trip and driver) : each trip has driver to move it from branch to
another
(Trip and truck) : each trip has is transferred to the other branch
through truck that carry the product and driver who drives it
<br/>● ENROLLED
(Client and Branch): each client has a main branch where he
can receive and send his products.
<br/>● START/END
(Trip and Branch): every trip starts from branch to another one.
<br/>● CATEGORIZED
(Product and price list): each product price is categorized according
to a price list with respect to weight range ,type of transporting and
type of the product itself example: ( this product broken easily or not ,
delivered fast or not )
<br/>● MANAGES:
(Supervisor and Branch): each Branch has supervisor that manages
employees




