using System;

namespace TgaProduct.MvcCoreWebUI.Models
{
    public class CommentViewModel
    {
    
        public DateTime CreateDate { get; set; }
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public int ProductId { get; set; }
        public string _state { get; set; }

        public string State
        {
            get
            {
                var st = "Olumlu";
                switch (_state)
                {
                    case "1":
                        st = "Olumlu";
                        break;

                    case "2":
                        st = "Nötr";
                        break;

                    case "0":
                        st = "Olumsuz";
                        break;
                    default:
                        st = "Olumlu";
                        break;
                }
                return st;

            }

        }
    }
}
