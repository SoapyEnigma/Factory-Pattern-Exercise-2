using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        public void LoadData();
        public void SaveData();
    }

    public enum DBTypes
    {
        LIST = 1,
        SQL,
        MONGO
    }
}
