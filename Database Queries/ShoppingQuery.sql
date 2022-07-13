use Shopping

create table Products(
Product_Id int Primary Key,
Product_Name varchar(40),
Product_Price int,
Product_Description varchar(MAX),
Product_Image varchar(MAX)
)

insert into Products values(1,'W240 Cashew Kernels',850,'Cashew nut ww240 grade 
(or: Kaju w240, white whole cashew 240, cashew w240, cashew nuts ww240, white whole
cashew w240, cashew grade w240) is a large, white, whole cashew that has between 220 
and 240 nuts/pound (395 – 465 beans/kg) and is known internationally as Premium Large Nuts.
','https://i0.wp.com/www.rawcashewnuts.com/wp-content/uploads/2020/09/cashew-nuts-kernels.jpg?resize =820%2C450&ssl =1 ')

insert into Products values(2,'W320 Cashew Kernels',700,'Cashew nut w320 grade is a very common cashew nut with high
quality, regular-size, non-damaged and non-split and white, popular whole cashew
that would produce between 300 – 320 pieces per pound (453.59g) – (about 660 – 706 pieces per kg) and is known
internationally as Standard Large Nuts.','https://p.globalsources.com/IMAGES/PDT/B1186882121/W320-Raw-Cashews-Nuts.jpg')


insert into Products values(3,'W450 Cashew Kernels',600,'W450 cashew nuts are cheap, they are used to make Snack,
food, and used in the food industry (chocolate factory, pastry factory, biscuit factory…). The name WW450 has 3 parts in it, 
WW450 cashew nut meaning: W stands for Whole cashews. W stands for White cashews. 450 stands for 450 Cashew Kernels in 1 pound.',
'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_XJCcR0tG6J9-tVMB3YP02WDTcOpYH1HZpg&usqp=CAU')

insert into Products values(4,'Split Cashew Kernels',750,'The "Splits" are the Cashews split the long way and 
the "Butts" are Cashews split in half. They are crisp and tasty - perfect for Stir Fry or Chicken Sal
ad, or just for munching.','https://5.imimg.com/data5/HE/OC/MY-3327629/split-cashew-kernel-500x500.jpg')


insert into Products values(5,'Broken Cashew Kernels',550,'Broken cashew nut (known as broken cashew nut kernels, 
broken cashew kernels) are high-quality, broken, maybe split cash
ew nut kernels and are known internationally as Broken Nut Kernels! Broken cashew ke
rnels are used in the food industry to make cashew chocolate, cashew pastry, cashew biscuit, protein bar,etc,..',
'https://www.raplap.com/uploads/raplap/products/41hhj0ktwbl-926966_l.jpg')


insert into Products values(6,'SWP Cashew Kernels',500,'Cashew nut SWP grade (or: Small White Pieces cashew, cashew
small white pieces) is a white cashew nut that is broken into small pieces, internationally as SWP cashew.',
'https://5.imimg.com/data5/EP/NX/CL/SELLER-30469781/swp-sunrise-500x500.jpeg')
select * from Products




Use Shopping


  create table UserRegistration(
  PhoneNumber bigint primary key,
  FirstName varchar(40),
  LastName varchar(40),
  DOB date,
  DeliveryAddress varchar(100),
  UserName varchar(40),
  Pass_Word varchar(20)
  )

  insert into UserRegistration values(9677910915,'Keerthana','Ramesh','2000/01/19','Kadampuliyur,Panruti','Keerthana','Keerthana@19')

  select * from UserRegistration

create table OrderDetails(
orderID int primary Key identity(98765,1),
orderDate date ,
OrderDeliveryDate date,
UserName varchar(40)
)

insert into OrderDetails values(GETDATE(),GETDATE()+2,'Keerthana')

select * from OrderDetails


/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [OrderId]
      ,[OrderDate]
      ,[OrderDeliveryDate]
      ,[CustomerMobNo]
      ,[QuantityOrdered]
      ,[OrderTotalAmount]
  FROM [Shopping].[dbo].[OrderDetails]


  use Shopping

  create table AdminDetails(
  AdminId int primary key identity(198,1),
  Admin_Name varchar(20),
  Admin_Password varchar(20)
  )

  insert into AdminDetails values('Keerthana','Keerthana@19')

  select * from AdminDetails