using DiscOwl.DataAccessLayer;
using DiscOwl.DTO;
using DiscOwl.Models;
using DiscOwl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.BusinessAccessLayer
{
    public class DiscBusiness
    {
        public ICollection<DiscViewModel> Get()
        {
            List<DiscViewModel> vm = new List<DiscViewModel>();
            DiscViewModel dvm;
            List<DiscDTO> data = new DiscData().Get();

            foreach (DiscDTO item in data)
            {
                dvm = new DiscViewModel();

                dvm.DiscName = item.Title;
                dvm.Author = item.Performer.PerformerName;
                dvm.TypeSet = item.DiscTypeSet.Select(i => i.TypeElement.TypeName).ToList();
                dvm.Score = item.ScoreSet.Sum(i => i.ScoreValue);

                vm.Add(dvm);
            }

            return vm;
        }

        public ICollection<DiscViewModel> GetByName(String name)
        {
            List<DiscViewModel> vm = new List<DiscViewModel>();
            DiscViewModel dvm;
            List<DiscDTO> data = new DiscData().GetByName(name);

            foreach (DiscDTO item in data)
            {
                dvm = new DiscViewModel();

                dvm.DiscName = item.Title;
                dvm.Author = item.Performer.PerformerName;
                dvm.TypeSet = item.DiscTypeSet.Select(i => i.TypeElement.TypeName).ToList();
                dvm.Score = item.ScoreSet.Sum(i => i.ScoreValue);

                vm.Add(dvm);
            }

            return vm;
        }
    }
}