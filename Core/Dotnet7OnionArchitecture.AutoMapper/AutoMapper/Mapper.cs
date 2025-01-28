using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Internal;
using Dotnet7OnionArchitecture.Application.Interfaces.AutoMapper;

namespace Dotnet7OnionArchitecture.AutoMapper.AutoMapper
{
    public class Mapper : Application.Interfaces.AutoMapper.IMapper
    {

        public static List<TypePair> typePairs = new List<TypePair>();

        //hatalı kısım
        private IMapper _mapper;

        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            throw new NotImplementedException();
        }

        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            throw new NotImplementedException();
        }

        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            throw new NotImplementedException();
        }

        public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
        {
            throw new NotImplementedException();
        }
    }
}
