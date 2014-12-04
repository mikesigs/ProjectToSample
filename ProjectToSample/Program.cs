using System;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ProjectToSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.CreateMap<Parent, ParentDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ChildNames, opt => opt.MapFrom(src => src.Children.Where(c => !c.Disowned).Select(c => c.Name)));

            using (var ctx = new Context())
            {
                ctx.Database.Log = Console.WriteLine;

                var families = ctx.Parents.Project().To<ParentDto>().ToList();
                Console.WriteLine("FAMILIES");
                Console.WriteLine("=================================");
                foreach (var fam in families)
                {
                    Console.WriteLine("Parent: " + fam.Name);
                    Console.WriteLine("Kids: " + String.Join(", ", fam.ChildNames));
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
