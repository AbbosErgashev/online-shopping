namespace OnlineShopping.Infrastructure.Enums;

public enum PaycomOrderCancelReason
{
    RECEIVER_NOT_FOUND = 1,
    DEBIT_OPERATION_ERROR = 2,
    TRANSACTION_ERROR = 3,
    TRANSACTION_TOMEOUT = 4,
    MONEY_BACK = 5,
    UNKNOWN_ERROR = 10
}
