using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Core.Utilities.Mappings.AutoMapper
{
    public class AutoMapperHelper
    {
        public static T MapToSameType<T>(T obj)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<T, T>(); });

            IMapper mapper = config.CreateMapper();
            var result = mapper.Map<T, T>(obj);

            return result;
        }

        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<T, T>(); });

            IMapper mapper = config.CreateMapper();
            var result = mapper.Map<List<T>, List<T>>(list);

            return result;
        }

        public static List<W> MapToDifferentTypeList<T, W>(List<T> list)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<T, W>(); });

            IMapper mapper = config.CreateMapper();
            var result = mapper.Map<List<T>, List<W>>(list);

            return result;
        }

    }
}
