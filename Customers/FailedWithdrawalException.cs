﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException()
        {

        }

        public FailedWithdrawalException(string message): base(message)
        {

        }

    }
}
