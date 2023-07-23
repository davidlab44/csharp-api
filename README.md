# csharp-api
csharp-api

Thats a simple skeleton for a csharp API, 

This api is linked to a simple sql server 2019 database named 'dfv2' with only a table name 'dbo.products' with 2 columns 'id_Column','name'

![image](https://github.com/davidlab44/csharp-api/assets/49595047/59dae74c-9090-456d-bfab-8a7688c07ea6)

******************************************

To start using:
1) Clone this repository
2) Download visual studio 2022 and open this project
3) Replace the string connection within appsettings.json with your own data
 "ConnectionStrings": {
    "dfv2": "SERVER=[add-here-your-server-name];DATABASE=[add-here-your-datebase-name];UID=[add-here-your-own-user;PWD=[add-here-your-password]"
  }

and launch it,

you should see one register in the browser, something like this

![image](https://github.com/davidlab44/csharp-api/assets/49595047/bc7d6308-f5fc-4fbf-84cb-9050d1fc6008)
