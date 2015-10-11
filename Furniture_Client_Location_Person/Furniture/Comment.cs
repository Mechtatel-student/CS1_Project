using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    enum EntityType  { Product, User, Client, Order, Category }
    class Comment
    {
        string Text;
        EntityType entityType;

    }
}
