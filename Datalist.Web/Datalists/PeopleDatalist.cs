﻿using Datalist.Web.Context;
using Datalist.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datalist.Web.Datalists
{
    public class PeopleDatalist : MvcDatalist<PersonModel>
    {
        public PeopleDatalist()
        {
            Filter.Rows = 5;
            Title = "People";
            Url = "/MvcDatalist/Default";
            Filter.SortColumn = "Surname";
            AdditionalFilters.Add("DatalistAge");
        }

        public override IQueryable<PersonModel> GetModels()
        {
            return PeopleRepository.GetPeople();
        }

        public override void AddData(Dictionary<String, String> row, PersonModel model)
        {
            base.AddData(row, model);
            
            if (model.IsWorking == true)
                row.Add("IsWorking", "Person is employed");
            else if (model.IsWorking == false)
                row.Add("IsWorking", "Person is unemployed");
            else
                row.Add("IsWorking", "It's unknown is person is employed or not");
        }

        public override void AddAutocomplete(Dictionary<String, String> row, PersonModel model)
        {
            row.Add(AcKey, model.Name + " " + model.Surname);
        }
    }
}