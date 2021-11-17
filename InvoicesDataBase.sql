create schema Invoices;
use invoices;
create table Clients(
Id int not null,
Namei varchar(80),
Last_Name varchar(80),
Document_Id int primary key
);
create table Invoice(
Id int not null,
Id_Client int,
Cod int primary key,
foreign key (Id_Client) references Clients(Document_Id)
);
create table InvoicesDetails(
Id int not null primary key,
Id_Invoice int,
Descriptioni varchar(80),
Valuei float,
foreign key (Id_Invoice) references Invoice(Cod)
);