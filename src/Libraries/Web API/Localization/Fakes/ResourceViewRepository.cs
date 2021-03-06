// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.EntityParser;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class ResourceViewRepository : IResourceViewRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.ResourceView> Get()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.ResourceView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.ResourceView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.ResourceView(), 1);
        }



        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.ResourceView(), 1);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.ResourceView(), 1);
        }

    }
}