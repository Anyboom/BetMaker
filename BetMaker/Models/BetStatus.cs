using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetMaker.Models
{
    enum BetStatus
    {
        [Description("Выигрыш")]
        Win,
        [Description("Проигрыш")]
        Lose,
        [Description("Возврат")]
        Return,
        [Description("Не расчитано")]
        NotCalculated
    }

}
