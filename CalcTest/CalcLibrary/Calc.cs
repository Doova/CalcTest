using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Calc   
    {
        public Calc()
        {
            operations = new List<IOperation>();

            var assm = Assembly.GetAssembly(typeof(IOperation));

            var types = assm.GetTypes();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(typeof(IOperation)))
                {
                    var oper = Activator.CreateInstance(type) as IOperation;
                    if (oper != null)
                    {
                        operations.Add(oper);
                    }
                }
            }
        }
        /// <summary>
        /// Список доступных операций
        /// </summary>
        private IList<IOperation> operations { get; set; }

        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <param name="operation">Название операции</param>
        /// <param name="args">Аргументы операции</param>
        /// <returns></returns>
        public object Execute(string operation, object[] args)
        {
            // находим операцию в списке доступных
            var oper = operations.FirstOrDefault(it => it.Name == operation);

            // если не нашли - возращаем ошибку
            if (oper == null)
            {
                return "Error";
            }

            // если нашли
            // разибраем аргрументы
            int x;
            int.TryParse(args[0].ToString(), out x);

            int y;
            int.TryParse(args[1].ToString(), out y);

            // вызываем саму операцию
            var result = oper.Calc(x, y);

            // возвращаем результат
            return result;
        }

        [Obsolete("Не используйте")]
        public int Sum(int x, int y)
        {
            var r = Execute("sum", new object[] { x, y });
            return int.Parse(r.ToString());
        }

        public double Divide(int x, int y)
        {
            var r = Execute("divide", new object[] { x, y });
            return int.Parse(r.ToString());
        }
    }
}