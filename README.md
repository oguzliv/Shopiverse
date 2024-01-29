Simple MVC for project for the mini challenge. 

Technologies Used : 
1. .NetCore 7
2. Entity Framework
3. MySql

1. clone the code
2. run directly sql script in order to get the DB on MySQL(You can ignore Table A and B for the project)
3. Then you can simple run the project iwth terminal or visual studio code, you have to see the index.
4. In order to get the Orders, you should send a GET request to http://localhost:5140/api/order/. You can add FirstName,LastName, StartDate and EndDate as parameters to filter them.
5. After project is up and running, go to http://localhost:5140/Home/UserDetails. You will see the current users on top half of the page as a table. Under the table, There is an input box to create user.


Conventions
1. I stored id as an integer, and in order to fast delivery, I do not care about if it auto incremented or not. Thus, that feature can have further advancements.
2. Views can be organized better with partial views, I decided eto cretate a page for each and every task.
3. I did not configure a mapper since there are pretty less endpoints and dtos, it can be configured to achieve better code cohesion.
