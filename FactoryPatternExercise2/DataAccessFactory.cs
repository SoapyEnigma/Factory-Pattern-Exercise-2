using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(DBTypes type)
        {
            switch(type)
            {
                case DBTypes.LIST: return new ListDataAccess();
                case DBTypes.SQL: return new SQLDataAccess();
                case DBTypes.MONGO: return new MongoDataAccess();
                default: return new ListDataAccess(); // Should error/log
            }
        }
    }
}
