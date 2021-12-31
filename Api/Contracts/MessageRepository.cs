using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Contracts
{
    interface MessageRepository<T> where T : Message
    {
        public T Get(int count);
        public bool Create(T message);

    }
}
