CREATE DATABASE TEST
USE TEST

CREATE TABLE Weather
(
  id INT,
  recordDate DATE,
  temperature INT,
  constraint PK_ID PRIMARY KEY (id),
);

INSERT INTO Weather VALUES 
(1, '2015-01-01', 10),
(2, '2015-01-02', 25),
(3, '2015-01-03', 20),
(4, '2015-01-04', 30)


SELECT W2.id
FROM Weather W1 JOIN Weather W2	
ON DATEDIFF(DAY, W1.recordDate, W2.recordDate) = 1
WHERE W2.temperature > W1.temperature