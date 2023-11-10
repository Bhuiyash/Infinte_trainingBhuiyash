create database codeBasedTestMVC

use codeBasedTestMVC

-- Create Table
CREATE TABLE Movie (
    Mid INT PRIMARY KEY,
    Moviename VARCHAR(255),
    DateofRelease DATE
);

-- Insert Sample Data
INSERT INTO Movie (Mid, Moviename, DateofRelease) VALUES
(1, 'Inception', '2010-07-16'),
(2, 'The Shawshank Redemption', '1994-09-23'),
(3, 'The Godfather', '1972-03-24');

-- Display All Movies
SELECT * FROM Movie;
