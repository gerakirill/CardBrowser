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
    using ViewModels.BindingModel;
    #endregion

    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Cards, ArmorCard>()
                    .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(c => (CardRarities)c.CardRarityId))
                    .ForMember(dest => dest.CardType, opt => opt.MapFrom(c => (CardTypes)c.CardTypeId));

                cfg.CreateMap<Cards, CityCard>()
                    .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(c => (CardRarities)c.CardRarityId))
                    .ForMember(dest => dest.CardType, opt => opt.MapFrom(c => (CardTypes)c.CardTypeId));

                cfg.CreateMap<Cards, ResourceCard>()
                    .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(c => (CardRarities)c.CardRarityId))
                    .ForMember(dest => dest.CardType, opt => opt.MapFrom(c => (CardTypes)c.CardTypeId));

                cfg.CreateMap<Cards, CardViewModel>()
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(c => Convert.ToBase64String(c.Image)));

                cfg.CreateMap<CardBindingModel, Cards>();

                cfg.CreateMap<Cards, Cards>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CardRarityId, opt => opt.Ignore())
                .ForMember(dest => dest.CardText, opt => opt.Ignore())
                .ForMember(dest => dest.CardTypeId, opt => opt.Ignore())
                .ForMember(dest => dest.Image, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.Ignore())
                .ForMember(dest => dest.CardRarities, opt => opt.Ignore())
                .ForMember(dest => dest.CardsAbilitiesValues, opt => opt.Ignore())
                .ForMember(dest => dest.CardTypes, opt => opt.Ignore());

            });
        }

    }
}
