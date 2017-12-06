using System;

namespace WikiDeck
{
    [Flags]
    public enum ValidateDeckResult
    {
        Valid = 0,
        BadFormat = 1,
        UnknownCard = 2,
        MaxInHandExceeded = 4,
        LessThan60Cards = 8,
        ContainsDuplicates = 16
    }
}
