Создал блок процесс и ввёл туда переменные массива array и newArray, в переменной array указал начальные данные для проверки, в переменной lenNewArray присвоил значение 0 . Затем создаю блок шестиугольник с циклом For, где указаны начальный индекс 0(он проверит строку Russia, а затем строку Denmark с индексом (1)), конечный индекс 2(в моём случае закончит на строке Kazan) и шаг проверки(он равен 1 и присваевается после прохода цикла For). Перехожу к индексу 0 , так как условие выполняется (0<3) то я иду по стрелке Да и попадаю в блок схему условие, где проверяется меньше или равна 3 символам,строка Russia имеет 6 символов, поэтому мы не идем по стрелке Да и не записываем в нем строку Russia, а идем обртно в цикл For где берем строку с индексом 1(так как я прошел цикл For с индексом 0)  это строка Denmark теперь тоже самое делаем что и со строкой Russia, так как строка имеет больше 3 символов то я возвращаюсь обратно в цикл For и беру строку с индексом 2 это Kazan, это строка не проходит проверку условия меньше или равно 3 символов, то цикл For заканчивается потому что следующий индекс 3, а 3 не <= 2 поэтому мы идем дальше по стрелочке Нет, где я создал новый массив с именем newArray который берет строки с массива lenNewArray (в моём случае там ничего нет, ни одно условие не подошло) затем создал переменную idx и присвоил значение 0. Идём в следующую блок схему где указана вывести '[' так как мне строку надо вывести в виде массива идем дальше, попадаю в блок схему For где указан начальный индекс, конечный индекс(после чего цикл завершится) и шаг прохода по циклу по каждому индексу. идем дальше по стрелке Да и берем строку 0-ого индекса из массива array и считаем меньше или равно 3 символов это строка, в моём случае 3 строки имели больше 3 знаков и поэтому мы пропустили следующие шаги, следующим шагом было создание блок схемы где я создал новую переменную с именем newArray и переносил все символы с массива array(тоесть если бы в массиве array была строка со словом Ace, то я бы в эту переменную и внеёс эту строчку каждый символ по порядку), потом прибавляет шаг из внешнего цикла for и проверяю следующую строку из массива array, когда все строки провереныи цикл For завершается , то я перейду в блок схему вывода данных, где сначало закроется квадратная скобка, а потом через запятую выведется строка(-и) которая(-ые) имеют 3 или меньше символов, в моём случае выведется просто [].