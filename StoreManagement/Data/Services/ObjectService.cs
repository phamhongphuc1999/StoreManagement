using StoreManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace StoreManagement.Data.Services
{
    public class ObjectService
    {
        private SQLData database;

        public ObjectService()
        {
            database = SQLConnecter.Instance.SqlData;
        }
        public ObservableCollection<InventoryObject> GetInventoryObject()
        {
            int Stt = 0;
            List<ObjectTable> objectTables = database.ObjectTables.ToList();
            IEnumerable<InventoryObject> result = objectTables.Select(x =>
            {
                List<InputInfo> inputInfos = database.InputInfos.Where(info => info.IdObject.Equals(x.Id)).ToList();
                List<OutputInfo> outputInfos = database.OutputInfos.Where(output => output.IdObject.Equals(x.Id)).ToList();
                int inputCount = 0, outputCount = 0;
                inputInfos.ForEach(x => inputCount += x.Count);
                outputInfos.ForEach(x => outputCount += x.Count);
                return new InventoryObject
                {
                    objectTable = x,
                    Stt = ++Stt,
                    Count = inputCount - outputCount
                };
            });
            return new ObservableCollection<InventoryObject>(result);
        }

        public ObservableCollection<InventoryObject> GetInventoryObjects(DateTime startTime, DateTime endTime)
        {
            int Stt = 0;
            List<ObjectTable> objectTables = database.ObjectTables.ToList();
            IEnumerable<InventoryObject> result = objectTables.Select(x =>
            {
                List<InputInfo> inputInfos = database.InputInfos.AsEnumerable().Where(info =>
                {
                    Input input = database.Inputs.Find(info.IdInput);
                    if (!info.IdObject.Equals(x.Id)) return false;
                    if (input.DateInput >= startTime && input.DateInput <= endTime) return true;
                    return false;
                }).ToList();
                List<OutputInfo> outputInfos = database.OutputInfos.AsEnumerable().Where(info =>
                {
                    Output output = database.Outputs.Find(info.IdOutput);
                    if (!info.IdObject.Equals(x.Id)) return false;
                    if (output.DateOutput >= startTime && output.DateOutput <= endTime) return true;
                    return false;
                }).ToList();
                int inputCount = 0, outputCount = 0;
                inputInfos.ForEach(x => inputCount += x.Count);
                outputInfos.ForEach(x => outputCount += x.Count);
                return new InventoryObject
                {
                    objectTable = x,
                    Stt = ++Stt,
                    Count = inputCount - outputCount
                };
            });
            return new ObservableCollection<InventoryObject>(result);
        }
    }
}
