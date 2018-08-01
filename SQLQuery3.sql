
create table item(
id int identity(101,1),
name nvarchar(150),
reorderlevel int,
categoryId int,
companyId int,
date date default getdate(),
primary key(id)

)

insert into item(name,reorderlevel,categoryId,companyId) values('fan',10,101,101)
select * from item