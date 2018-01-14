using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

using CardBrowser.BLL.Models;
using CardBrowser.Database;
using CardRarities = CardBrowser.BLL.Enums.CardRarities;
using CardTypes = CardBrowser.BLL.Enums.CardTypes;
using CardBrowser.ViewModels;

namespace CardBrowser.Infrastructure.Services
{
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
                cfg.CreateMap<CardBase, CardViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(c => Convert.ToBase64String(c.Image)));
            });
        }

    }
}
