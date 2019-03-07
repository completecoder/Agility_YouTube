using System;
using System.Collections.Generic;
using Agility.CoreData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Agility.CoreData.ViewModels;

namespace Agility.CoreData.WebAPI.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void CanGetViewModelFromSchemaAndData()
        {
            Schema schema = new Schema()
            {
                Name = "Customer",
                SchemaProperties = new List<SchemaProperty> {
                    new SchemaProperty{ Id="1", Name="CustomerName", DisplayText="Customer Name", DataType="string" }
                }
            };

            DataModel model = new DataModel()
            {
                DataProperties = new List<DataProperty> {
                    new DataProperty{ Id="1", SchemaPropertyId="1", Value="Complete Coder" }
                }
            };

            ModelView view = new ModelView();
            view.ModelViewProperties = (from m in model.DataProperties
                                        join s in schema.SchemaProperties on
                                        m.SchemaPropertyId equals s.Id
                                        select new ModelViewProperty() {
                                            DataType = s.DataType,
                                            Name = s.Name,
                                            Value = m.Value
                                        }).ToList();

            Assert.AreEqual(view.ModelViewProperties.Count, 1);
            Assert.AreEqual(view.ModelViewProperties.FirstOrDefault(v => v.Name == "CustomerName").Value, "Complete Coder");


        }
    }
}
