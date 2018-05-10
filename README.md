# Bank Account
Разработать систему типов для описания работы с банковским счетом. Состояние счета определяется его номером, данными о владельце счета (имя, фамилия, e-mail), суммой на счете и некоторыми бонусными баллами, которые увеличиваются/уменьшаются каждый раз при пополнении счета/списании со счета на величины различные для пополнения и списания и рассчитываемые в зависимости от некоторых значений величин «стоимости» баланса и «стоимости» пополнения. Величины «стоимости» баланса и «стоимости» пополнения являются целочисленными значениями и зависят от типа счета, который может быть, например, Base, Gold, Platinum. Для работы со счетом реализовать следующие возможности:

 *выполнить пополнение на счет;
 *выполнить списание со счета;
 *создать новый счет;
 *закрыть счет.
Для хранения информации о счетах использовать fake-имплементацию репозитория (хранилища) в виде класса-обертки для коллекции List.

Работу классов продемонстрировать на примере консольного приложения.

При проектировании типов учитывать следующие возможности расширения/изменения функциональности

1) добавление новых видов счетов;
2) изменение/добавление источников хранения информации о счетах;
3) изменение логики расчета бонусных баллов;
4) изменении логики генерации номера счета.
Для организации классов и интерфейсов использовать “The Stairway pattern” (“заготовка” в архиве AccountSystemDemo.7z).

Для разрешения зависимостей использовать Ninject- фреймворк.

Протестировать слой Bll (NUnit и Moq фреймворки).
