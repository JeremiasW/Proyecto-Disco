using DiscOwl.DTO;
using DiscOwl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.DataAccessLayer
{
    public class DiscData
    {
        public List<DiscDTO> Get()
        {
            List<Disc> discSet = new List<Disc>();
            List<DiscDTO> discSetDTO = new List<DiscDTO>();

            using (DALDisc dal = new DALDisc())
            {
                discSet = dal.DiscDbSet
                                .Include("Performer")
                                .Include("DiscTypeSet")
                                .Include("ScoreSet")
                                .ToList();

                discSetDTO = this.ObtainData(discSet);
            }

            return discSetDTO;
        }

        public List<DiscDTO> GetByName(String name)
        {
            List<Disc> discSet = new List<Disc>();
            List<DiscDTO> discSetDTO = new List<DiscDTO>();

            using (DALDisc dal = new DALDisc())
            {
                discSet = dal.DiscDbSet
                                    .Include("Performer")
                                    .Include("DiscTypeSet")
                                    .Include("ScoreSet")
                                    .Where(d => d.Title.ToLower() == name.ToLower())
                                    .ToList();

                discSetDTO = this.ObtainData(discSet);
            }

            return discSetDTO;
        }

        private List<DiscDTO> ObtainData(List<Disc> discSet)
        {
            List<DiscDTO> discSetDTO = new List<DiscDTO>();

            discSetDTO = discSet
                            .Select(i => new DiscDTO
                            {
                                DiscId = i.DiscId,
                                Title = i.Title,
                                Year = i.Year,
                                PerformerId = i.PerformerId,
                                Performer = new PerformerDTO
                                {
                                    Id = i.Performer.Id,
                                    PerformerName = i.Performer.PerformerName
                                },
                                DiscTypeSet = i.DiscTypeSet.Select(p => new DiscTypeDTO
                                {
                                    Id = p.Id,
                                    DiscId = p.DiscId,
                                    TypeId = p.TypeId,
                                    TypeElement = new TypeDTO
                                    {
                                        Id = p.TypeElement.Id,
                                        TypeName = p.TypeElement.TypeName
                                    }
                                }).ToList(),
                                ScoreSet = i.ScoreSet.Select(p => new ScoreDTO
                                {
                                    Id = p.Id,
                                    CustomerId = p.CustomerId,
                                    DiscId = p.DiscId,
                                    ScoreValue = p.ScoreValue
                                }).ToList()
                            }).ToList();

            return discSetDTO;
        }
    }
}