using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    internal class Task4
    {

        // Reflexion: неправильно понял, надо было рассказать про открытые классы в библиотеках dll, и что подключаются через using.

        // Task4: 

        // (Close)OfficialDocument -> (Close)ContractualDocument -> (Open)SupAgreement
        //                          -> (Close)ContractBase -> (Open)Contract

        // Закрыто поскольку при обновлении ЕСМ платформы кастомные изменения клиентов могут спровоцировать конфликты.
        // Логику и возможность наследования, разрешение на расширение лежит непосредственно на Вендоре, только он отвечает за границы полета фантазий будущих потребителей.
    }
}
