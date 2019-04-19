# joomlaSupply
JoomShopping Supply

1.Программа позволяет принимать поставки товара для магазина joomlaShopping  по EAN коду товара. Можно создать поставщика в БД. При поставке быстро найти его по ОГРН или ИНН. 
2. Распечатать сборочный лист для заказа. При этом статус заказа меняется со статуса "Подтвержден" на статус "Сборка". А так же подтвердить сборку заказа. После подтверждения статус заказа меняется на "Собран"
3. Позволяет посмотреть отчеты по товару, поставкам и продажам.

Статусы заказа:
(1-Ожидание) - Не используется в программе
2-Подтвержден
(3-Отменен) - Не используется в программе
(4-Возврат) - Не используется в программе
5-Сборка
6-Собран
(7-Завершен) - Не используется в программе

SQL для создания дополниельных таблиц в файле additionalTableForJoomlaShopping.sql
Сокращения:
EAN - European Article Number.
PAN - Producer Article Number.

Настройки подключения в файле нужно изменить. Указать адрес сервера и имя БД. 
!!! Точку с запятой в конце строки подключения не убирать !!! 

-----------------------------------------------------INFO----------------------------------------------------------
1. The program allows you to take delivery of goods for the joomlaShopping store by EAN product code. You can create a provider in the database. When shipped, quickly find it by OGRN or TIN.
2. Print the assembly sheet for the order. At the same time, the status of the order changes from the status "Confirmed" to the status "Assembly". And also confirm the assembly order. After confirming the order status is changed to "Assembled"
3. Allows you to view reports on the product, supplies and sales.

Orders status:
(1-Pending) - Not used in the program
2-Confirmed
(3-Canceled) - Not used in the program
(4-Return) - Not used in the program
5-Compile
6-Compiled
(7-Completed) - Not used in the program


The connection settings in the file need to be changed. Specify the server address and database name.
!!! Do not remove the semicolon at the end of the connection string !!!
