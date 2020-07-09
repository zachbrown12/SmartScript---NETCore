using AutoMapper;
using SmartScript_NETCore.Controllers.Resources;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResource>();
            CreateMap<User, UserEndResource>();
            CreateMap<Chemical, ChemicalResource>();
            CreateMap<Drug, DrugResource>();
            CreateMap<Variant, VariantResource>();
            CreateMap<UserRow, UserRowResource>();
            CreateMap<Effect, EffectResource>();
            CreateMap<Ingredient, IngredientResource>();
            CreateMap<Prescription, PrescriptionResource>();
            CreateMap<UserVariant, UserVariantResource>();
        }
        
    }
}