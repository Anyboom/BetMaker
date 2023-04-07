using System.ComponentModel;

namespace BetMaker.Models
{
    public enum BetStatus
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
