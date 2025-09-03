using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice10C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
    }

    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Вот тут были бы данные из БД";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Вот тут были бы данные из файла";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Вот тут были бы данные из API";
        }
    }
}
