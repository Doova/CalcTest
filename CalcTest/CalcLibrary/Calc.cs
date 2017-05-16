using System;
using System.Collections.Generic;
using System.IO;
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
            Operations = new List<IOperation>();


            var assm = Assembly.GetAssembly(typeof(IOperation));
            var types = assm.GetTypes().ToList();

            //найти длл рядом с exe
            var dlls = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dll");
            foreach (var dll in dlls)
            {
                //Загрузить библиотеку как сборку 
                assm = Assembly.LoadFrom(dll);
                //Добавить типы
                types.AddRange(assm.GetTypes());
            }

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(typeof(IOperation)))
                {
                    var oper = Activator.CreateInstance(type) as IOperation;
                    if (oper != null)
                    {
                        Operations.Add(oper);
                    }
                }
            }
        }
        /// <summary>
        /// Список доступных операций
        /// </summary>
       public IList<IOperation> Operations { get; private set; }

        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <param name="operation">Название операции</param>
        /// <param name="args">Аргументы операции</param>
        /// <returns></returns>
        public object Execute(string operation, object[] args)
        {
            // находим операцию в списке доступных
            var oper = Operations.FirstOrDefault(it => it.Name == operation);

            // если не нашли - возращаем ошибку
            if (oper == null)
            {
                return "Error";
            }

            // если нашли
            // разибраем аргрументы
            var result = 0;

            var operArgs = oper as IOperationArgs;
            if (operArgs != null)
            {
                result = operArgs.Calc(args.Select(it => int.Parse(it.ToString())));
            }
            else
            {
                int x;
                int.TryParse(args[0].ToString(), out x);

                int y;
                int.TryParse(args[1].ToString(), out y);

                result = oper.Calc(x, y);
            }

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