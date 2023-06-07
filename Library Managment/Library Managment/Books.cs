using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    class Books
    {
        private static int bookID;
        private static string title, author, publisher, edition;
        private static int publishYr, quantity;
        private static string ISBN;
        private static int rackRow, rackCol;
        private static bool isSoftCopy, isForIssue;
        private static string preface;

        public static void setBookData(string bookID, string title, string author, string edition, string quantity, string ISBN)
        {
            Books.bookID = Convert.ToInt32(bookID);
            Books.title = title;
            Books.author = author;
            Books.edition = edition;
            if (quantity != "")
                Books.quantity = Convert.ToInt32(quantity);
            Books.ISBN = ISBN;
        }

        public static void setPublisherData(string publisher, string publishYr)
        {
            Books.publisher = publisher;
            if (publishYr != "")
                Books.publishYr = Convert.ToInt32(publishYr);
        }

        public static void setLocationData(string rackRow, string rackCol)
        {
            if (rackRow != "")
                Books.rackRow = Convert.ToInt32(rackRow);
            if (rackCol != "")
                Books.rackCol = Convert.ToInt32(rackCol);
        }

        public static void setOthersData(string isSoftCopy, string isForIssue, string preface)
        {
            if (isSoftCopy == "Available")
                Books.isSoftCopy = true;
            else
                Books.isSoftCopy = false;
            if (isForIssue == "Allowed")
                Books.isForIssue = true;
            else
                Books.isForIssue = false;
            Books.preface = preface;
        }

        public static int passID()
        {
            return Books.bookID;
        }

        public static void getBookData()
        {
            AddBooksForm myAddBooks = new AddBooksForm();
            myAddBooks.changeRecord_BookData(Books.bookID, Books.title, Books.author, Books.edition, Convert.ToString(Books.quantity), Books.ISBN);
            myAddBooks.changeRecord_PublisherData(Books.publisher, Convert.ToString(Books.publishYr));
            myAddBooks.changeRecord_Locationata(Convert.ToString(Books.rackRow), Convert.ToString(Books.rackCol));
            myAddBooks.changeRecord_OthersData(Books.isSoftCopy, Books.isForIssue, Books.preface);
            myAddBooks.invokeUpdate();
        }
    }
}