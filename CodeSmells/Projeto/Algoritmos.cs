using System;
using System.Collections.Generic;

namespace Projeto
{
    public class Algoritmos
    {
        public List<string> GetChangedData(List<string> data, string changeType)
        {
            List<string> changedData = null;

            switch (changeType)
            {
                case "Upper":
                    for (int i = 0; i < data.Count; i++)
                        data[i] = data[i].ToUpper();
                    changedData = data;
                    break;

                case "Lower":
                    for (int i = 0; i < data.Count; i++)
                        data[i] = data[i].ToLower();
                    changedData = data;
                    break;
            }

            return changedData;
        }
    }

    public class ChangeClient
    {
        public void Program()
        {
            List<string> data = new List<string> { "Ball", "Apple", "Cat" };
            var changeContext = new Algoritmos();
            List<string> result = changeContext.GetChangedData(data, "Upper");
        }
    }
}
