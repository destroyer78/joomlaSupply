using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    public class result
    {
        int code = 0; // Код ошибки
        string message = "OK";  // Текст ошибки
        public result() { }
        public result(int _code, string _mes)
        {
            code = _code;
            message = _mes;
        }
        public void setCode(int v) { code = v; }
        public int getCode() { return code; }
        public void setMessage(string m){ message = m; }
        public string getMessage() {  return message; }
    }
}
