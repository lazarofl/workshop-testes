using System;
using System.Collections.Generic;

namespace Projeto
{
    public interface IChangeData
    {
        List<string> GetChangedData(List<string> data);
    }

    public class ToUpperCaseData : IChangeData
    {
        public List<string> GetChangedData(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
                data[i] = data[i].ToUpper();
            return data;
        }
    }

    public class ToLowerCaseData : IChangeData
    {
        public List<string> GetChangedData(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
                data[i] = data[i].ToLower();
            return data;
        }
    }

    public class ChangeDataContext
    {
        public Dictionary<string, IChangeData> changeStrategy = new Dictionary<string, IChangeData>();

        public ChangeDataContext()
        {
            changeStrategy.Add("Upper", new ToUpperCaseData());
            changeStrategy.Add("Lower", new ToLowerCaseData());
        }

        public List<string> GetChangedData(List<string> data, string changeType)
        {
            return changeStrategy[changeType].GetChangedData(data);
        }
    }

    public class ChangeClient2
    {
        public void Program()
        {
            List<string> data = new List<string> { "Ball", "Apple", "Cat" };
            ChangeDataContext changeContext = new ChangeDataContext();
            List<string> result = changeContext.GetChangedData(data, "Upper");
        }
    }
}
