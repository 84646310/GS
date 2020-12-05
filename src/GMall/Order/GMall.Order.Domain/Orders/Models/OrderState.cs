using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Order.Domain.Orders
{
    public class OrderState
    {
    }
    public enum EnumOrderState
    {

        WaitPay=10,
        WaitSend=20,
        WaitConfirm=30,
        WaitRate=40,
    }
}
