﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Exceptions;
internal class PropertyNullOrEmptyException: Exception
{
    public PropertyNullOrEmptyException() { }
    public PropertyNullOrEmptyException(string message): base(message) { }
}
