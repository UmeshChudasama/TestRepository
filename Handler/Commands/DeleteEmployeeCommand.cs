﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Commands
{
    public class DeleteEmployeeCommand : IRequest<long>
    {
        public long EmployeeId { get; set; }
    }
}
