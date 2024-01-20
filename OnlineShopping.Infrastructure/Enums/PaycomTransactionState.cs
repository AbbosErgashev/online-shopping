namespace OnlineShopping.Infrastructure.Enums;

public enum PaycomTransactionState
{
    STATTE_NEW = 0,
    STATE_IN_PROGRESS = 1,
    STATE_DONE = 2,
    STATE_CANCELLED = -1,
    STATE_POST_CANCELLED = -2
}
