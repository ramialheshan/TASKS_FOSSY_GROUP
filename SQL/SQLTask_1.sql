declare @customers table (id int, name varchar(20))
declare @orders table (id int, summa numeric(18,2), customerId int)
declare @payments table (customerId int, payment numeric(18,2))

insert @customers (id, name) values(1,'Первый'),(2, 'Второй'),(3, 'Третий'),(4, 'Четвертый')

insert @orders (id, summa, customerId)
values
(1, 10, 1),
(2, 15, 1),
(3, 20, 1),
(4, 25, 1),
(5, 12, 2),
(6, 14, 2),
(7, 200, 2),
(8, 100, 3),
(9, 200, 3)

insert @payments (customerId, payment)
values(1, 30),(2, 500),(3, 100),(4, 20);

with orders_payments 
as 
(
	select id,_orders.summa, _orders.customerId,_payments.payment, SUM(summa) OVER(PARTITION BY _orders.customerId ORDER BY id) AS SUMM 
	from @orders _orders INNER JOIN @payments _payments
	on _orders.customerId = _payments.customerId 
)
select * from orders_payments
where summ<=payment



