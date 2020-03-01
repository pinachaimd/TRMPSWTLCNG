using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLCNG.LogicLayer
{
    public class Result<T> where T : class
    {
        public bool HasError { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public void AddMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Message += (!string.IsNullOrEmpty(Message)) ? Environment.NewLine + message : message;
            }
        }


    }

}
