create database hospital;

create table AddPatient
(
Name varchar(150),
Full_Address varchar(300),
Contact bigint,
Age int,
Gender varchar(10),
Blood_Group varchar(20),
Major_Disease varchar(20),
pid bigint unique,
)