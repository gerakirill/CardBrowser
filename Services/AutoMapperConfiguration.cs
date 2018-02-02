namespace CardBrowser.Services
{

    #region usings
    using System;    
    using AutoMapper;

    using BLL.Models;
    using Database;
    using CardRarities = BLL.Enums.CardRarities;
    using CardTypes = BLL.Enums.CardTypes;
    using ViewModels;
    #endregion

    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Cards, ArmorCard>()
                    .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(c => (CardRarities) c.CardRarityId))
                    .ForMember(dest => dest.CardType, opt => opt.MapFrom(c => (CardTypes) c.CardTypeId));

                cfg.CreateMap<Cards, CityCard>()
                    .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(c => (CardRarities)c.CardRarityId))
                    .ForMember(dest => dest.CardType, opt => opt.MapFrom(c => (CardTypes)c.CardTypeId));

                cfg.CreateMap<Cards, ResourceCard>()
                    .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(c => (CardRarities)c.CardRarityId))
                    .ForMember(dest => dest.CardType, opt => opt.MapFrom(c => (CardTypes)c.CardTypeId));

                cfg.CreateMap<Cards, CardViewModel>()
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(c => Convert.ToBase64String(c.Image)))
                    .ReverseMap()
                    .ForMember(dest => dest.Id, opt => opt.Ignore())
                    .ForMember(dest => dest.Image, opt => opt.Ignore())
                ;
                               
            });
        }

    }
}
