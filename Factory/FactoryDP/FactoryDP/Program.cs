/**
 * Consider an example of using multiple database servers
 * like SQL Server and Oracle.If you are developing an application
 * using SQL Server database as backend, but in future need to change
 * backend database to oracle, you will need to modify all your code,
 * if you haven’t written your code following factory design pattern.**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    interface Database
    {
        void create(string array);
    }

    class MySql : Database
    {
        public void create(string array)
        {
            Console.WriteLine(array +" Database connected.");
        }
    }
    class Oracle : Database
    {
        public void create(string array)
        {
            Console.WriteLine(array, " Database connected.");
        }
    }
    class MongoDB : Database
    {
        public void create(string array)
        {
            Console.WriteLine(array, " Database connected.");
        }
    }
    class DBFactory
    {
        public void createTable(string dbTypeConfig)
        {
            if (dbTypeConfig == "mysql")
            {
                MySql sql = new MySql();
                sql.create(dbTypeConfig);
            }
            else if (dbTypeConfig == "oracle")
            {
                Oracle oracle = new Oracle();
                oracle.create(dbTypeConfig);
            }
            else if (dbTypeConfig == "mongodb")
            {
                MongoDB mongodb = new MongoDB();
                mongodb.create(dbTypeConfig);
            }
        }
    }

    class Program
    {
        static string dbType = "mysql";

        static void Main(string[] args)
        {
            DBFactory dBFactory = new DBFactory();
            dBFactory.createTable(dbTypeConfig: dbType);

        }
    }
}
