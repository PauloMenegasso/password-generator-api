## Strong Password Generator API

This is a simple .NetCore API that will generate strong passwords for you!

There are two get endpoints, so you can use it directly from your browser given that it's up on your machine.

# Running the project

On the base folder, simply open a CMD and type "dotnet run" It should open up a web server at https://localhost:7070
Note that the port can change depend on what is currently running on your PC.

# URIs

You should acess https://localhost:7070/Password
which will generate a 12-character password

To generate longer passwords, you should acess https://localhost:7070/Password/PutAnIntegerNumberHere
Please keep in mind that the highest possible number is 100.
