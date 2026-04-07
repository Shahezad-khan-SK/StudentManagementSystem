# StudentManagementSystem

1) Clone the project first
2) Go to the clone location and find the "Sql Changes" folder execute the file inside it in sql server
3) now open the visual studio and open solution file (.sln) from the cloned project
4) open the appsettings.json file and change the connection string according to your sql server authentication user id and password and          server name also
5) clean rebuild the project and run it
6) now check the running project url copy the local url like for example "http://localhost:5088"  and open the postman to test the web api
7) now first for get bearer token call the url "http://localhost:5088/Authenticate/login" select post method request then select Body and       select Json  body and copy andn paste below json format for login 
   {
  "username": "shahezadkhan",
  "password": "khan@123"
   }
8) now you will get the bearer token in response copy the token go to postman authorization tab and select type Bearer token and then paste the token there
9) now For adding the student select post request paste url "http://localhost:5088/api/Student" in body tab paste below json format data
    {
     "name": "Shahezad Khan",
     "email": "shahezad@example.com",
     "age": 23,
     "course": "Software Engineering"
     }
 10) Now to see the inserted data select the Get Request and send url "http://localhost:5088/api/Student" it will return the data in json format
 11) Now for update select the put Method request and paste url "http://localhost:5088/api/Student/1" and in body tabcopy and paste json format updated data from below  after sending this request you will get updated data in response 
     {
  "name": "Shahezad Khan",
  "email": "khanshahezad2002@gmail.com",
  "age": 24,
  "course": "Software Engineering"
}
 12) now last is to delete the data just select the Delete Method request and paste url "http://localhost:5088/api/Student/1" and hit the api it will delete the data and return true.
