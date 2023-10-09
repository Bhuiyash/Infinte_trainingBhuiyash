
--Codebased test sql one Bhuiyash Kumar
create database CodebasedTest
use CodebasedTest



--create table for question one.
create table Books (
    id int primary key,
    title varchar(255),
    author varchar(255),
    isbn varchar(13) unique,
    published_date datetime
)
--value insert
insert into Books (id,title, author, isbn, published_date)
values (1,'My first SQL book', 'Mary Parker', '981483029127', convert(datetime, '2012-02-22 12:08:17', 120));
insert into Books (id,title, author, isbn, published_date)
values (2,'My Second SQL book','John Mayer','857300923713',convert (datetime,'1972-07-03 09:22:45',120)),
	   (3,'My Third SQL book','Cary Flint','523120967812',convert (datetime,'2015-10-18 14:05:44',120))
--display table columns.

	  
	   --create second table:
	   create table reviews (
    id int primary key,
    book_id int,
    reviewer_name varchar(255),
    content varchar(255),
    rating int,
    published_date datetime
);



--insert values:

insert into reviews (id, book_id, reviewer_name, content, rating, published_date)
values (1, 1, 'John Smith','My first review', 4,convert(datetime,'2017-12-10 05:50:11',120))



insert into reviews (id, book_id, reviewer_name, content, rating, published_date)
values (2, 2, 'John Smith', 'My Second review', 5,convert(datetime,'2017-10-13 15:05:12',120)),
		(3, 3, 'Alice Walker','Another review', 1,convert(datetime,'2017-10-22 23:47:10',120))
		 select * from Books

select * from reviews

	   --Given Query 1.
	   --Write a query to fetch the details of the books written by author whose name ends with er
select b.title, b.author, r.reviewer_name
from Books as b
join reviews as r on b.id = r.book_id
where b.author like '%er';
 --Display the Title ,Author and ReviewerName for all the books from the above table
select b.title, b.author, r.reviewer_name
from Books as b
left join reviews as r on b.id = r.book_id;


--question two

--Display the reviewer name who reviewed more than one book.

select reviewer_name
from reviews
group by reviewer_name
having count(distinct book_id) > 1;
