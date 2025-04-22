Use InsuranceManagementSystem

create table Users 
(
userId int primary key,
userName varchar(100) not null,
password varchar(100) not null,
role varchar(50) not null
)

Create table Policy 
(
policyId int primary key,
policyName varchar(100) not null,
coverageAmount int not null
)

Create table Client 
(
clientId int primary key,
clientName varchar(100) not null,
contactInfo varchar(100),
policyId int not null,
foreign key (policyId) references policy(policyId)
)

Create table Claim 
(
claimId int primary key,
claimNumber varchar(50) not null,
dateFiled date not null,
claimAmount float not null,
status varchar(50) not null,
policyId int not null,
clientId int not null,
foreign key (policyId) references policy(policyId),
foreign key (clientId) references client(clientId)
)

Create table Payment 
(
paymentId int primary key,
paymentDate date not null,
paymentAmount float not null,
clientId int not null,
foreign key (clientId) references client(clientId)
)

Insert into Users 
values  
(1, 'RahulSharma', 'pass123', 'Admin'),  
(2, 'AnitaSingh', 'secure456', 'Agent'),  
(3, 'VikramPatel', 'pass789', 'Manager'),  
(4, 'MehakGupta', 'abc123', 'Executive'),  
(5, 'SanjayReddy', 'xyz789', 'Supervisor'),  
(6, 'PoonamJain', 'poo2024', 'Analyst'),  
(7, 'AlokMishra', 'alokpass', 'Support'),  
(8, 'ShruthiRaj', 'shru@123', 'Auditor'),  
(9, 'TanmayJoshi', 'tanny321', 'Reviewer'),  
(10, 'NivedithaMenon', 'niv@456', 'TeamLead'),  
(11, 'AshokKumar', 'ashok987', 'Admin'),  
(12, 'BhavaniRao', 'bhav@2024', 'Supervisor'),  
(13, 'LakshmiP', 'lakshmi789', 'Agent'),  
(14, 'PraveenK', 'praveen1', 'Manager'),  
(15, 'DeepikaJain', 'deepika123', 'Executive')

Insert into Policy 
values  
(1, 'Health Secure Plus', 500000),  
(2, 'Car Protect Plan', 300000),  
(3, 'Home Shield Basic', 800000),  
(4, 'Life Saver Elite', 1000000),  
(5, 'Travel Guard', 200000),  
(6, 'Critical Illness Cover', 700000),  
(7, 'Senior Health Plan', 600000),  
(8, 'Two Wheeler Insurance', 150000),  
(9, 'Student Health Plan', 250000),  
(10, 'Family Floater Plan', 900000),  
(11, 'Child Education Plan', 550000),  
(12, 'Cancer Care Policy', 750000),  
(13, 'House Fire Protection', 850000),  
(14, 'Accident Shield', 400000),  
(15, 'Retirement Saver Plan', 950000)

Insert into Client 
values  
(1, 'Karan Verma', 'karanv@gmail.com', 1),  
(2, 'Divya Iyer', 'divyaiyer@hotmail.com', 2),  
(3, 'Manoj Desai', 'manojd@rediffmail.com', 3),  
(4, 'Sneha Rao', 'snehar@outlook.com', 4),  
(5, 'Ajay Kumar', 'ajayk@gmail.com', 5),  
(6, 'Rekha Sharma', 'rekhas@yahoo.com', 6),  
(7, 'Rohit Singh', 'rohits@hotmail.com', 7),  
(8, 'Isha Mehra', 'isham@rediffmail.com', 8),  
(9, 'Amit Joshi', 'amitj@gmail.com', 9),  
(10, 'Neha Kapoor', 'nehak@outlook.com', 10),  
(11, 'Vivek Yadav', 'viveky@yahoo.com', 11),  
(12, 'Shruti Naik', 'shrutinaik@gmail.com', 12),  
(13, 'Anil Reddy', 'anilreddy@hotmail.com', 13),  
(14, 'Meena Devi', 'meenad@gmail.com', 14),  
(15, 'Rajat Gupta', 'rajatg@rediffmail.com', 15)

insert into Claim 
values  
(1, 'clm001', '2024-01-05', 150000, 'Approved', 1, 1),  
(2, 'clm002', '2024-02-10', 120000, 'Pending', 2, 2),  
(3, 'clm003', '2024-03-15', 200000, 'Rejected', 3, 3),  
(4, 'clm004', '2024-01-22', 75000, 'Approved', 4, 4),  
(5, 'clm005', '2024-03-03', 50000, 'Pending', 5, 5),  
(6, 'clm006', '2024-04-01', 90000, 'Approved', 6, 6),  
(7, 'clm007', '2024-03-20', 110000, 'Approved', 7, 7),  
(8, 'clm008', '2024-02-28', 60000, 'Rejected', 8, 8),  
(9, 'clm009', '2024-01-15', 130000, 'Pending', 9, 9),  
(10, 'clm010', '2024-03-18', 95000, 'Approved', 10, 10),  
(11, 'clm011', '2024-04-02', 72000, 'Pending', 11, 11),  
(12, 'clm012', '2024-02-09', 80000, 'Approved', 12, 12),  
(13, 'clm013', '2024-03-22', 87000, 'Rejected', 13, 13),  
(14, 'clm014', '2024-01-30', 100000, 'Approved', 14, 14),  
(15, 'clm015', '2024-02-18', 105000, 'Pending', 15, 15)

insert into Payment 
values  
(1, '2024-01-10', 45000, 1),  
(2, '2024-02-15', 70000, 2),  
(3, '2024-03-05', 120000, 3),  
(4, '2024-03-10', 60000, 4),  
(5, '2024-03-18', 90000, 5),  
(6, '2024-04-01', 30000, 6),  
(7, '2024-04-06', 50000, 7),  
(8, '2024-02-20', 40000, 8),  
(9, '2024-01-25', 35000, 9),  
(10, '2024-03-15', 47000, 10),  
(11, '2024-03-30', 52000, 11),  
(12, '2024-02-05', 39000, 12),  
(13, '2024-04-10', 63000, 13),  
(14, '2024-03-22', 41000, 14),  
(15, '2024-02-28', 58000, 15)

Select * from Policy