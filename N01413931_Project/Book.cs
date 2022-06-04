using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01413931_Project
{
    class Book
    {
        private string isbn;
        private string title;
        private string type;
        private string status;
        private string genre;
        private string publisher;
        private string publdate;
        private string desc;

        public Book(string isbn, string title, string type, string status, string genre, string publisher, string publdate, string desc)
        {
            this.isbn = isbn;
            this.title = title;
            this.type = type;
            this.status = status;
            this.genre = genre;
            this.publisher = publisher;
            this.publdate = publdate;
            this.desc = desc;
        }

        public void setIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setTypee(string type)
        {
            this.type = type;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public void setPublDate(string publdate)
        {
            this.publdate = publdate;
        }

        public void setDesc(string desc)
        {
            this.desc = desc;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getIsbn()
        {
            return this.isbn;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getType()
        {
            return this.type;
        }

        public string getStatus()
        {
            return this.status;
        }

        public string getGenre()
        {
            return this.genre;
        }

        public string getPublisher()
        {
            return this.publisher;
        }

        public string getPubldate()
        {
            return this.publdate;
        }

        public string getDesc()
        {
            return this.desc;
        }

    }
}
