using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel.Exceptions
{
    public class WhatDidIEatBaseException : Exception
    {
    }

    public class MealNotFoundException : WhatDidIEatBaseException
    {
    }

    public class DuplicateIngredientsException : WhatDidIEatBaseException
    {
    }




}
