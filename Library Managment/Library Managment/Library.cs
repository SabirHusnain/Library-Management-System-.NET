using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    class Library
    {
        private string library_Name;
        private static int rackRow, rackCol;
        private static int booksPerRack;

        public static void setRackData(int _rRow, int _rCol)
        {
            rackRow = _rRow;
            rackCol = _rCol;
        }

        public static void setBooksPerRack(int _bRack)
        {
            booksPerRack = _bRack;
        }

        public void setLibraryName(string name)
        {
            this.library_Name = name;
        }

        public string getLibraryName()
        {
            return library_Name;
        }

        public static int getRackRow()
        {
            return rackRow;
        }

        public static int getRackCol()
        {
            return rackCol;
        }

        public static int getBooksPerRack()
        {
            return booksPerRack;
        }
    }
}