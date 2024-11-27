using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Enums
{
    public enum BookCategory
    {
        Fiction,
        NonFiction,
        Science,
        Technology,
        History,
        Biography,
        Children,
        Mystery,
        Fantasy,
        Romance,
        Horror,
        Thriller,
        Philosophy,
        Religion,
        Poetry,
        Comics
    }

    public enum BookStatus
    {
        Available,  
        Borrowed,   
        Reserved,   
        Lost,      
        Damaged     
    }
}
